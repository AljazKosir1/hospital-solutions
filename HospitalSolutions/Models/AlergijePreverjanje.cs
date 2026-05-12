// File:    AlergijePreverjanje.cs
// Author:  aljaz
// Created: Thursday, April 16, 2026 5:09:43 PM
// Purpose: Definition of Class AlergijePreverjanje

using System;

namespace HospitalSolutions.Models
{
    public class AlergijePreverjanje
    {
       private string zadnjiRezultat = "Ni preverjeno.";

       public bool preveriAlergije(Pacient pacient, String zdravilo)
       {
          if (pacient == null || pacient.Alergije == null || string.IsNullOrWhiteSpace(zdravilo))
          {
             zadnjiRezultat = "Ni konfliktov z alergijami.";
             return false;
          }

          string zdraviloLower = zdravilo.ToLowerInvariant();
          foreach (var alergen in pacient.Alergije)
          {
             if (string.IsNullOrWhiteSpace(alergen))
             {
                continue;
             }
             if (zdraviloLower.Contains(alergen.ToLowerInvariant()))
             {
                zadnjiRezultat = "Konflikt: pacient je alergičen na '" + alergen + "'.";
                return true;
             }
          }

          zadnjiRezultat = "Ni konfliktov z alergijami.";
          return false;
       }

       public String vrniRezultat()
       {
          return zadnjiRezultat;
       }
    }
}
