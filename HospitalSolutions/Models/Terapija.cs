// File:    Terapija.cs
// Author:  aljaz
// Created: Thursday, April 16, 2026 5:09:45 PM
// Purpose: Definition of Class Terapija

using System;

namespace HospitalSolutions.Models
{
    public class Terapija
    {
       private String naziv = string.Empty;
       private String navodila = string.Empty;

       public string Naziv
       {
          get { return naziv; }
          set { naziv = value; }
       }

       public string Navodila
       {
          get { return navodila; }
          set { navodila = value; }
       }

       public void shrani()
       {
          Repository.Terapije.Add(this);
       }
    }
}
