using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.Services
{
    public class MadLibService
    {
        public string MadLib(MabLib story)
        {
            return $"\nThere was once a(n) {story.Adjective2} {story.Occupation} named {story.Name} who always loved to explore (the) {story.Location}. On a particular {story.Weather} day, {story.Name} happened to run into a(n) {story.Creature} who stood in (his/her) path. {story.Name} who felt {story.Mood1} had to quell the {story.Creature}'s {story.Mood2} so {story.Pronoun} pulled out a(n) {story.Object1}. They fought and the {story.Creature} {story.AnimalSound}ed however with a long fought battle the {story.Occupation} prevailed. With the {story.Creature} dealt with and the path is clear, the {story.Occupation} felt {story.Adjective}. Now {story.Pronoun} can return home and eat some quality {story.Food}.";
        }
    }
}