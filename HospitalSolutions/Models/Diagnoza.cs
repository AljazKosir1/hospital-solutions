// File:    Diagnoza.cs
// Author:  aljaz
// Created: Thursday, April 16, 2026 5:09:44 PM
// Purpose: Definition of Class Diagnoza

using System;

namespace HospitalSolutions.Models
{
    public class Diagnoza
    {
       private String opis = string.Empty;
       private String koda = string.Empty;

       public string Opis
       {
          get { return opis; }
          set { opis = value; }
       }

       public string Koda
       {
          get { return koda; }
          set { koda = value; }
       }

       public void shrani()
       {
          Repository.Diagnoze.Add(this);
       }
    }
}
