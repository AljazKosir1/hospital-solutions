// File:    Pregled.cs
// Author:  aljaz
// Created: Thursday, April 16, 2026 5:09:44 PM
// Purpose: Definition of Class Pregled

using System;
using System.Collections.Generic;

namespace HospitalSolutions.Models
{
    public class Pregled
    {
       private DateTime datum;
       private String opombe = string.Empty;

       public DateTime Datum
       {
          get { return datum; }
          set { datum = value; }
       }

       public string Opombe
       {
          get { return opombe; }
          set { opombe = value; }
       }

       public void shrani()
       {
          Repository.Pregledi.Add(this);
       }

       public List<Pregled> getZgodovina(int idPacienta)
       {
          var rezultat = new List<Pregled>();
          foreach (var p in Repository.Pregledi)
          {
             int povezaniId;
             if (Repository.PregledZaPacient.TryGetValue(p, out povezaniId))
             {
                if (povezaniId == idPacienta)
                {
                   rezultat.Add(p);
                }
             }
          }
          return rezultat;
       }

       public System.Collections.ArrayList diagnoza;

       /// <summary>
       /// Property for collection of Diagnoza
       /// </summary>
       /// <pdGenerated>Default opposite class collection property</pdGenerated>
       public System.Collections.ArrayList Diagnoza
       {
          get
          {
             if (diagnoza == null)
                diagnoza = new System.Collections.ArrayList();
             return diagnoza;
          }
          set
          {
             RemoveAllDiagnoza();
             if (value != null)
             {
                foreach (Diagnoza oDiagnoza in value)
                   AddDiagnoza(oDiagnoza);
             }
          }
       }

       /// <summary>
       /// Add a new Diagnoza in the collection
       /// </summary>
       /// <pdGenerated>Default Add</pdGenerated>
       public void AddDiagnoza(Diagnoza newDiagnoza)
       {
          if (newDiagnoza == null)
             return;
          if (this.diagnoza == null)
             this.diagnoza = new System.Collections.ArrayList();
          if (!this.diagnoza.Contains(newDiagnoza))
             this.diagnoza.Add(newDiagnoza);
       }

       /// <summary>
       /// Remove an existing Diagnoza from the collection
       /// </summary>
       /// <pdGenerated>Default Remove</pdGenerated>
       public void RemoveDiagnoza(Diagnoza oldDiagnoza)
       {
          if (oldDiagnoza == null)
             return;
          if (this.diagnoza != null)
             if (this.diagnoza.Contains(oldDiagnoza))
                this.diagnoza.Remove(oldDiagnoza);
       }

       /// <summary>
       /// Remove all instances of Diagnoza from the collection
       /// </summary>
       /// <pdGenerated>Default removeAll</pdGenerated>
       public void RemoveAllDiagnoza()
       {
          if (diagnoza != null)
             diagnoza.Clear();
       }
       public System.Collections.ArrayList terapija;

       /// <summary>
       /// Property for collection of Terapija
       /// </summary>
       /// <pdGenerated>Default opposite class collection property</pdGenerated>
       public System.Collections.ArrayList Terapija
       {
          get
          {
             if (terapija == null)
                terapija = new System.Collections.ArrayList();
             return terapija;
          }
          set
          {
             RemoveAllTerapija();
             if (value != null)
             {
                foreach (Terapija oTerapija in value)
                   AddTerapija(oTerapija);
             }
          }
       }

       /// <summary>
       /// Add a new Terapija in the collection
       /// </summary>
       /// <pdGenerated>Default Add</pdGenerated>
       public void AddTerapija(Terapija newTerapija)
       {
          if (newTerapija == null)
             return;
          if (this.terapija == null)
             this.terapija = new System.Collections.ArrayList();
          if (!this.terapija.Contains(newTerapija))
             this.terapija.Add(newTerapija);
       }

       /// <summary>
       /// Remove an existing Terapija from the collection
       /// </summary>
       /// <pdGenerated>Default Remove</pdGenerated>
       public void RemoveTerapija(Terapija oldTerapija)
       {
          if (oldTerapija == null)
             return;
          if (this.terapija != null)
             if (this.terapija.Contains(oldTerapija))
                this.terapija.Remove(oldTerapija);
       }

       /// <summary>
       /// Remove all instances of Terapija from the collection
       /// </summary>
       /// <pdGenerated>Default removeAll</pdGenerated>
       public void RemoveAllTerapija()
       {
          if (terapija != null)
             terapija.Clear();
       }
    }
}
