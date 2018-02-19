using System;
using System.Collections.Generic;
using System.Text;

namespace MyHowestWeek2
{
    public enum Graad
    {
        voldoening,
        onderscheiding
    }

    public class Student
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public Graad AfstudeerGraad { get; set; }

        public override string ToString()
        {
            return $"{Id} {Naam} {AfstudeerGraad}";
        }
    }
}
