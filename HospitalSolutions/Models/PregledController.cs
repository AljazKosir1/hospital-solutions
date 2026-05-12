// File:    PregledController.cs
// Author:  aljaz
// Created: Thursday, April 16, 2026 5:09:43 PM
// Purpose: Definition of Class PregledController

using System;

namespace HospitalSolutions.Models
{
    public class PregledController
    {
       private Pacient trenutniPacient;
       private Pregled trenutniPregled;
       private Diagnoza trenutnaDiagnoza;
       private Terapija trenutnaTerapija;
       private int trenutniIdPacienta;

       public Pacient pridobiPodatke(int idPacienta)
       {
          trenutniIdPacienta = idPacienta;
          int pozicija = idPacienta - 1;
          if (pozicija < 0 || pozicija >= Repository.Pacienti.Count)
          {
             return null;
          }
          trenutniPacient = Repository.Pacienti[pozicija];
          AddPacient(trenutniPacient);
          return trenutniPacient.getPodatke();
       }

       public void shraniPregled()
       {
          if (trenutniPregled == null)
          {
             trenutniPregled = new Pregled();
             trenutniPregled.Datum = DateTime.Now;
          }

          if (trenutnaDiagnoza != null)
          {
             trenutnaDiagnoza.shrani();
             trenutniPregled.AddDiagnoza(trenutnaDiagnoza);
          }

          if (trenutnaTerapija != null)
          {
             trenutnaTerapija.shrani();
             trenutniPregled.AddTerapija(trenutnaTerapija);
          }

          trenutniPregled.shrani();
          AddPregled(trenutniPregled);

          if (trenutniIdPacienta > 0)
          {
             Repository.PregledZaPacient[trenutniPregled] = trenutniIdPacienta;
          }
       }

       public Diagnoza ustvariDiagnozo(String opis, String koda)
       {
          trenutnaDiagnoza = new Diagnoza();
          trenutnaDiagnoza.Opis = opis;
          trenutnaDiagnoza.Koda = koda;
          return trenutnaDiagnoza;
       }

       public Terapija ustvariTerapijo(String naziv, String navodila)
       {
          trenutnaTerapija = new Terapija();
          trenutnaTerapija.Naziv = naziv;
          trenutnaTerapija.Navodila = navodila;
          return trenutnaTerapija;
       }

       public void potrdiVnos()
       {
          shraniPregled();
       }

       public System.Collections.ArrayList alergijePreverjanje;

       /// <summary>
       /// Property for collection of AlergijePreverjanje
       /// </summary>
       /// <pdGenerated>Default opposite class collection property</pdGenerated>
       public System.Collections.ArrayList AlergijePreverjanje
       {
          get
          {
             if (alergijePreverjanje == null)
                alergijePreverjanje = new System.Collections.ArrayList();
             return alergijePreverjanje;
          }
          set
          {
             RemoveAllAlergijePreverjanje();
             if (value != null)
             {
                foreach (AlergijePreverjanje oAlergijePreverjanje in value)
                   AddAlergijePreverjanje(oAlergijePreverjanje);
             }
          }
       }

       /// <summary>
       /// Add a new AlergijePreverjanje in the collection
       /// </summary>
       /// <pdGenerated>Default Add</pdGenerated>
       public void AddAlergijePreverjanje(AlergijePreverjanje newAlergijePreverjanje)
       {
          if (newAlergijePreverjanje == null)
             return;
          if (this.alergijePreverjanje == null)
             this.alergijePreverjanje = new System.Collections.ArrayList();
          if (!this.alergijePreverjanje.Contains(newAlergijePreverjanje))
             this.alergijePreverjanje.Add(newAlergijePreverjanje);
       }

       /// <summary>
       /// Remove an existing AlergijePreverjanje from the collection
       /// </summary>
       /// <pdGenerated>Default Remove</pdGenerated>
       public void RemoveAlergijePreverjanje(AlergijePreverjanje oldAlergijePreverjanje)
       {
          if (oldAlergijePreverjanje == null)
             return;
          if (this.alergijePreverjanje != null)
             if (this.alergijePreverjanje.Contains(oldAlergijePreverjanje))
                this.alergijePreverjanje.Remove(oldAlergijePreverjanje);
       }

       /// <summary>
       /// Remove all instances of AlergijePreverjanje from the collection
       /// </summary>
       /// <pdGenerated>Default removeAll</pdGenerated>
       public void RemoveAllAlergijePreverjanje()
       {
          if (alergijePreverjanje != null)
             alergijePreverjanje.Clear();
       }
       public System.Collections.ArrayList pacient;

       /// <summary>
       /// Property for collection of Pacient
       /// </summary>
       /// <pdGenerated>Default opposite class collection property</pdGenerated>
       public System.Collections.ArrayList Pacient
       {
          get
          {
             if (pacient == null)
                pacient = new System.Collections.ArrayList();
             return pacient;
          }
          set
          {
             RemoveAllPacient();
             if (value != null)
             {
                foreach (Pacient oPacient in value)
                   AddPacient(oPacient);
             }
          }
       }

       /// <summary>
       /// Add a new Pacient in the collection
       /// </summary>
       /// <pdGenerated>Default Add</pdGenerated>
       public void AddPacient(Pacient newPacient)
       {
          if (newPacient == null)
             return;
          if (this.pacient == null)
             this.pacient = new System.Collections.ArrayList();
          if (!this.pacient.Contains(newPacient))
             this.pacient.Add(newPacient);
       }

       /// <summary>
       /// Remove an existing Pacient from the collection
       /// </summary>
       /// <pdGenerated>Default Remove</pdGenerated>
       public void RemovePacient(Pacient oldPacient)
       {
          if (oldPacient == null)
             return;
          if (this.pacient != null)
             if (this.pacient.Contains(oldPacient))
                this.pacient.Remove(oldPacient);
       }

       /// <summary>
       /// Remove all instances of Pacient from the collection
       /// </summary>
       /// <pdGenerated>Default removeAll</pdGenerated>
       public void RemoveAllPacient()
       {
          if (pacient != null)
             pacient.Clear();
       }
       public System.Collections.ArrayList pregled;

       /// <summary>
       /// Property for collection of Pregled
       /// </summary>
       /// <pdGenerated>Default opposite class collection property</pdGenerated>
       public System.Collections.ArrayList Pregled
       {
          get
          {
             if (pregled == null)
                pregled = new System.Collections.ArrayList();
             return pregled;
          }
          set
          {
             RemoveAllPregled();
             if (value != null)
             {
                foreach (Pregled oPregled in value)
                   AddPregled(oPregled);
             }
          }
       }

       /// <summary>
       /// Add a new Pregled in the collection
       /// </summary>
       /// <pdGenerated>Default Add</pdGenerated>
       public void AddPregled(Pregled newPregled)
       {
          if (newPregled == null)
             return;
          if (this.pregled == null)
             this.pregled = new System.Collections.ArrayList();
          if (!this.pregled.Contains(newPregled))
             this.pregled.Add(newPregled);
       }

       /// <summary>
       /// Remove an existing Pregled from the collection
       /// </summary>
       /// <pdGenerated>Default Remove</pdGenerated>
       public void RemovePregled(Pregled oldPregled)
       {
          if (oldPregled == null)
             return;
          if (this.pregled != null)
             if (this.pregled.Contains(oldPregled))
                this.pregled.Remove(oldPregled);
       }

       /// <summary>
       /// Remove all instances of Pregled from the collection
       /// </summary>
       /// <pdGenerated>Default removeAll</pdGenerated>
       public void RemoveAllPregled()
       {
          if (pregled != null)
             pregled.Clear();
       }
    }
}
