using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public string Feathers { get; set; }
        public string Beak { get; set; }
        public string Wings { get; set; }
        public bool LikesWorms { get; set; }

        public void BirdSound()
        {
            Console.WriteLine("Caacaw!");
        }
    }
}
