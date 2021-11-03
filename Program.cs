/*
In this project, I got to develop a system in C# to track the weather magicians in the guild and their spells.

Pupils have a title and can create one weak wind storm.
Mages have a title and can create a weak wind storm and a weak rain storm.
Archmages have a title and can create a weak wind storm, a strong rain storm, and a strong lightning storm.

There will be a Storm class, which stores the essence, strength, and the title of the magician who created it.
*/

using System;

namespace MagicalInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
     // Uncomment code below to test class Storm
     //Storm s = new Storm("wind", false, "Zul'rajas");
     //Console.WriteLine(s.Announce());    

     // Uncomment code below to test class Pupil
     //Pupil p = new Pupil("Mezil-kree");
     //var Storm = p.CastWindStorm();
     //Console.WriteLine(Storm.Announce());         

     // Uncomment code below to test class Mage
     //Mage m = new Mage("Gul'dan");
     //var Rain = m.CastRainStorm();
     //Console.WriteLine(Rain.Announce());       

     // Uncomment code below to test class Archmage; try one 'var Storm' at a time
     //Archmage a = new Archmage("Nielas Aran");
     //var Storm = a.CastRainStorm();
     //var Storm = a.CastLightningStorm();
     //Console.WriteLine(Storm.Announce());     
    }
  }
}
