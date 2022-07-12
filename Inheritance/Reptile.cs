using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public string ReptileSkin { get; set; }
        public bool IsColdBlooded { get; set; }
        public string ReptileEggs { get; set; }
        public bool BreathesWithLungs { get; set; }

        public void ReptileSound()
        {
            Console.WriteLine("Hiss!");
        }
    }
}
