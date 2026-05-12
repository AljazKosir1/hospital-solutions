// File:    Pacient.cs
// Author:  aljaz
// Created: Thursday, April 16, 2026 5:09:43 PM
// Purpose: Definition of Class Pacient

using System;
using System.Collections.Generic;

namespace HospitalSolutions.Models
{
    public class Pacient
    {
       private String ime = string.Empty;
       private String priimek = string.Empty;
       private DateTime datumRojstva;
       private List<string> alergije = new List<string>();
       private String emso = string.Empty;

       public string Ime
       {
          get { return ime; }
          set { ime = value; }
       }

       public string Priimek
       {
          get { return priimek; }
          set { priimek = value; }
       }

       public DateTime DatumRojstva
       {
          get { return datumRojstva; }
          set { datumRojstva = value; }
       }

       public List<string> Alergije
       {
          get { return alergije; }
          set { alergije = value; }
       }

       public string Emso
       {
          get { return emso; }
          set { emso = value; }
       }

       public Pacient getPodatke()
       {
          return this;
       }
    }
}
