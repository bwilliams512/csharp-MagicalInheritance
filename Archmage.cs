// Archmage.cs
using System;

namespace MagicalInheritance
{
  class Archmage : Mage
  {
    // Add a Archmage constructor with one string arg
    public Archmage(string title) : base(title)
    {}

    // Override the CastRainStorm() method
    public override Storm CastRainStorm() 
    {
      Storm s = new Storm("rain", true, Title);
      return s;
    }

    // Define a CastLightningStorm() method
    public Storm CastLightningStorm() 
    {
      Storm s = new Storm("lightning", true, Title);
      return s;
    }
  }
}
