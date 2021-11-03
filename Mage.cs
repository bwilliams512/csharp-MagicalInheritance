// Mage.cs
using System;

namespace MagicalInheritance
{
  class Mage : Pupil
  {
    // Add a Mage constructor with one string arg
    public Mage(string title) : base(title)
    {}
    
    // Define a CastRainStorm() method
    public virtual Storm CastRainStorm() 
    {
      Storm s = new Storm("rain", false, Title);
      return s;
    }
  }
}
