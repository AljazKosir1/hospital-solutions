// File:    PregledForma.cs
// Author:  aljaz
// Created: Thursday, April 16, 2026 5:09:41 PM
// Purpose: Definition of Class PregledForma

using System;
using System.Collections.Generic;

namespace HospitalSolutions.Models
{
    public class PregledForma
    {
       private Pacient pacient;
       private List<Pregled> zgodovina = new List<Pregled>();
       private Diagnoza diagnoza;
       private Terapija terapija;
       private string sporocilo = string.Empty;
       private bool potrjeno = false;

       public Pacient Pacient
       {
          get { return pacient; }
          set { pacient = value; }
       }

       public List<Pregled> Zgodovina
       {
          get { return zgodovina; }
          set { zgodovina = value; }
       }

       public Diagnoza Diagnoza
       {
          get { return diagnoza; }
          set { diagnoza = value; }
       }

       public Terapija Terapija
       {
          get { return terapija; }
          set { terapija = value; }
       }

       public string Sporocilo
       {
          get { return sporocilo; }
          set { sporocilo = value; }
       }

       public bool Potrjeno
       {
          get { return potrjeno; }
          set { potrjeno = value; }
       }

       public void prikaziFormo()
       {
          sporocilo = string.Empty;
          potrjeno = false;
       }

       public void potrdiVnos()
       {
          potrjeno = true;
       }

       public void vnosDiagnoze(String opis, String koda)
       {
          diagnoza = new Diagnoza();
          diagnoza.Opis = opis;
          diagnoza.Koda = koda;
       }

       public void vnosTerapije(String naziv, String navodila)
       {
          terapija = new Terapija();
          terapija.Naziv = naziv;
          terapija.Navodila = navodila;
       }

       public void prikaziPotrditev(String sporocilo)
       {
          this.sporocilo = sporocilo;
       }

       public System.Collections.ArrayList pregledController;

       /// <summary>
       /// Property for collection of PregledController
       /// </summary>
       /// <pdGenerated>Default opposite class collection property</pdGenerated>
       public System.Collections.ArrayList PregledController
       {
          get
          {
             if (pregledController == null)
                pregledController = new System.Collections.ArrayList();
             return pregledController;
          }
          set
          {
             RemoveAllPregledController();
             if (value != null)
             {
                foreach (PregledController oPregledController in value)
                   AddPregledController(oPregledController);
             }
          }
       }

       /// <summary>
       /// Add a new PregledController in the collection
       /// </summary>
       /// <pdGenerated>Default Add</pdGenerated>
       public void AddPregledController(PregledController newPregledController)
       {
          if (newPregledController == null)
             return;
          if (this.pregledController == null)
             this.pregledController = new System.Collections.ArrayList();
          if (!this.pregledController.Contains(newPregledController))
             this.pregledController.Add(newPregledController);
       }

       /// <summary>
       /// Remove an existing PregledController from the collection
       /// </summary>
       /// <pdGenerated>Default Remove</pdGenerated>
       public void RemovePregledController(PregledController oldPregledController)
       {
          if (oldPregledController == null)
             return;
          if (this.pregledController != null)
             if (this.pregledController.Contains(oldPregledController))
                this.pregledController.Remove(oldPregledController);
       }

       /// <summary>
       /// Remove all instances of PregledController from the collection
       /// </summary>
       /// <pdGenerated>Default removeAll</pdGenerated>
       public void RemoveAllPregledController()
       {
          if (pregledController != null)
             pregledController.Clear();
       }
    }
}
