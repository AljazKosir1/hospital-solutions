using System;
using System.Collections.Generic;

namespace HospitalSolutions.Models
{
    public static class Repository
    {
       public static List<Pacient> Pacienti = new List<Pacient>();
       public static List<Pregled> Pregledi = new List<Pregled>();
       public static List<Diagnoza> Diagnoze = new List<Diagnoza>();
       public static List<Terapija> Terapije = new List<Terapija>();

       public static Dictionary<Pregled, int> PregledZaPacient = new Dictionary<Pregled, int>();

       private static bool inicializirano = false;

       public static void Init()
       {
          if (inicializirano)
          {
             return;
          }
          inicializirano = true;

          var p1 = new Pacient();
          p1.Ime = "Janez";
          p1.Priimek = "Novak";
          p1.DatumRojstva = new DateTime(1985, 4, 12);
          p1.Emso = "1204985500123";
          p1.Alergije = new List<string> { "Penicilin", "Cvetni prah" };
          Pacienti.Add(p1);

          var p2 = new Pacient();
          p2.Ime = "Marija";
          p2.Priimek = "Kovač";
          p2.DatumRojstva = new DateTime(1972, 9, 3);
          p2.Emso = "0309972505234";
          p2.Alergije = new List<string> { "Mačja dlaka" };
          Pacienti.Add(p2);

          var p3 = new Pacient();
          p3.Ime = "Anže";
          p3.Priimek = "Horvat";
          p3.DatumRojstva = new DateTime(1990, 1, 25);
          p3.Emso = "2501990500456";
          p3.Alergije = new List<string>();
          Pacienti.Add(p3);

          var p4 = new Pacient();
          p4.Ime = "Nina";
          p4.Priimek = "Zupančič";
          p4.DatumRojstva = new DateTime(1965, 6, 18);
          p4.Emso = "1806965505789";
          p4.Alergije = new List<string> { "Oreščki", "Penicilin" };
          Pacienti.Add(p4);

          var zacetniPregled = new Pregled();
          zacetniPregled.Datum = new DateTime(2025, 11, 8);
          zacetniPregled.Opombe = "Redni pregled.";
          var d = new Diagnoza();
          d.Opis = "Prehlad";
          d.Koda = "A1";
          var t = new Terapija();
          t.Naziv = "Paracetamol";
          t.Navodila = "1 tableta zjutraj in zvečer";

          d.shrani();
          t.shrani();
          zacetniPregled.AddDiagnoza(d);
          zacetniPregled.AddTerapija(t);
          zacetniPregled.shrani();
          PregledZaPacient[zacetniPregled] = 1;
       }
    }
}
