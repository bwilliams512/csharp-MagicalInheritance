// Storm.cs
using System;

namespace MagicalInheritance
{
  class Storm 
  {
    public string Essence //type of storm
    { get; private set; }

    public bool IsStrong //true if storm is strong
    { get; private set; }

    public string Caster //magician casting storm
    { get; private set; }

    // Define constructor
    public Storm(string essence, bool isStrong, string caster) 
    {
      Essence = essence;
      IsStrong = isStrong;
      Caster = caster;
    }

    // Define a Announce() method
    public string Announce() 
    {
      string power;

      if (IsStrong) 
      {
        power = "strong";
        return $"{Caster} cast a {power} {Essence} storm!";
      }
      else 
      {
        power = "weak";
        return $"{Caster} cast a {power} {Essence} storm!";
      }
    }
  }
}


