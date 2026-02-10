using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class MabLib
    {
        public string? Name { get; set; }
        public string? Pronoun { get; set; }
        public string? Occupation { get; set; }
        public string? Adjective { get; set; }
        public string? Adjective2 { get; set; }
        public string? Location { get; set; }    
        public string? Weather { get; set; }
        public string? Creature {get; set;}
        public string? Mood1 { get; set; }
        public string? Mood2 { get; set; }
        public string? Object1 { get; set; }
        public string? AnimalSound { get; set; }
        public string? Food { get; set; }
    }
}