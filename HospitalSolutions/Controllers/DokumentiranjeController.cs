using System;
using HospitalSolutions.Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalSolutions.Controllers
{
    public class DokumentiranjeController : Controller
    {
        // GET /Dokumentiranje
        public IActionResult Index()
        {
            var view = new PacientiListView();
            view.prikaziSeznam();
            return View("PacientiListView", view);
        }

        // GET /Dokumentiranje/Pregled?idPacienta=1
        [HttpGet]
        public IActionResult Pregled(int idPacienta)
        {
            var controller = new PregledController();
            var pacient = controller.pridobiPodatke(idPacienta);
            if (pacient == null)
            {
                TempData["Napaka"] = "Pacient z ID " + idPacienta + " ne obstaja.";
                return RedirectToAction("Index");
            }

            var pregled = new Pregled();
            var zgodovina = pregled.getZgodovina(idPacienta);

            var forma = new PregledForma();
            forma.prikaziFormo();
            forma.Pacient = pacient;
            forma.Zgodovina = zgodovina;

            ViewData["IdPacienta"] = idPacienta;
            return View("PregledForma", forma);
        }

        // POST /Dokumentiranje/Shrani
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Shrani(int idPacienta, string opisDiagnoze, string kodaDiagnoze,
                                    string nazivTerapije, string navodilaTerapije)
        {
            var controller = new PregledController();
            var pacient = controller.pridobiPodatke(idPacienta);
            if (pacient == null)
            {
                TempData["Napaka"] = "Pacient z ID " + idPacienta + " ne obstaja.";
                return RedirectToAction("Index");
            }

            controller.ustvariDiagnozo(opisDiagnoze ?? string.Empty, kodaDiagnoze ?? string.Empty);
            controller.ustvariTerapijo(nazivTerapije ?? string.Empty, navodilaTerapije ?? string.Empty);

            var alergije = new AlergijePreverjanje();
            bool konflikt = alergije.preveriAlergije(pacient, nazivTerapije ?? string.Empty);

            var forma = new PregledForma();
            forma.Pacient = pacient;
            forma.Zgodovina = new Pregled().getZgodovina(idPacienta);
            forma.vnosDiagnoze(opisDiagnoze ?? string.Empty, kodaDiagnoze ?? string.Empty);
            forma.vnosTerapije(nazivTerapije ?? string.Empty, navodilaTerapije ?? string.Empty);

            ViewData["IdPacienta"] = idPacienta;

            if (konflikt)
            {
                forma.prikaziPotrditev(alergije.vrniRezultat());
                ViewData["JeKonflikt"] = true;
                return View("PregledForma", forma);
            }

            controller.potrdiVnos();
            forma.potrdiVnos();

            TempData["UspesnoShranjeno"] = "Pregled je bil uspešno dokumentiran za pacienta "
                + pacient.Ime + " " + pacient.Priimek + ".";
            TempData["DiagnozaOpis"] = opisDiagnoze;
            TempData["DiagnozaKoda"] = kodaDiagnoze;
            TempData["TerapijaNaziv"] = nazivTerapije;
            TempData["TerapijaNavodila"] = navodilaTerapije;

            return RedirectToAction("Potrditev");
        }

        // GET /Dokumentiranje/Potrditev
        public IActionResult Potrditev()
        {
            return View();
        }
    }
}
