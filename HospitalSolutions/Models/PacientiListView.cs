// File:    PacientiListView.cs
// Author:  aljaz
// Created: Thursday, April 16, 2026 5:09:42 PM
// Purpose: Definition of Class PacientiListView

using System;
using System.Collections.Generic;

namespace HospitalSolutions.Models
{
    public class PacientiListView
    {
       private List<string> seznamPacientov = new List<string>();

       public List<string> SeznamPacientov
       {
          get { return seznamPacientov; }
          set { seznamPacientov = value; }
       }

       public void prikaziSeznam()
       {
          seznamPacientov = new List<string>();
          for (int i = 0; i < Repository.Pacienti.Count; i++)
          {
             var p = Repository.Pacienti[i];
             int id = i + 1;
             seznamPacientov.Add(id + ": " + p.Ime + " " + p.Priimek + " (" + p.Emso + ")");
          }
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
