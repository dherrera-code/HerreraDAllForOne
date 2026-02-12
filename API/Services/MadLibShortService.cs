using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class MadLibShortService
    {
        public string Story(string name, string location, string adjective, string creature, string mood )
        {
            return $"There was once a(n) {adjective} adventurer named {name} who always loved to explore (the) {location}. One day, {name} happened to run into a(n) {creature} who stood in (his/her) path. {name} had to quell the {creature}'s {mood} and so they fought! With the {creature} defeated, {name} can now go home to enjoy life!";
        }
    }
}