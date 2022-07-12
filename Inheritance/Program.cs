using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var seagull = new Bird();
            seagull.Beak = "orange";
            seagull.Wings = "small";
            seagull.Feathers = "white";
            seagull.LikesWorms = true;
            seagull.IsInZoo = true;
            seagull.NeedsFood = true;
            seagull.HasEyes = true;
            seagull.HasLegs = true;
            Console.WriteLine($"the reasearchers observing the bird noticed that the Seagulls beak was {seagull.Beak} and it's feathers were {seagull.Feathers}.");
            Console.WriteLine($"the Seagulls {seagull.Wings} wings were very tired from flying all day.");
            Console.WriteLine($"On the researchers notes, they had written down the following : does it like worms? {seagull.LikesWorms}.");
            Console.WriteLine($"Does he eat food and does it like to eat worms? {seagull.LikesWorms} and also {seagull.LikesWorms}.");
            Console.WriteLine($"Does he have eyes on the side of its head? {seagull.HasEyes}.");
            Console.WriteLine($"Does he have very small legs? {seagull.HasEyes}.");
            Console.WriteLine("Upon leaving the researchers heard the following sound:");
            seagull.BirdSound();

            var snake = new Reptile();
            snake.ReptileEggs = "large";
            snake.BreathesWithLungs = true;
            snake.ReptileSkin = "scales";
            snake.IsColdBlooded = true;
            snake.IsInZoo = true;
            snake.NeedsFood = true;
            snake.HasEyes = true;
            snake.HasLegs = false;
            Console.WriteLine($"Inside the Central Park Zoo, a guest had asked the zookeeper if it is true the snake is in the zoo?");
            Console.WriteLine($"the zookeeper answered with {snake.IsInZoo}.");
            Console.WriteLine($"The zookeeper was writing down notes on the new snake that had arrived into the zoo and had wrote down the following:");
            Console.WriteLine($"Does he need food? {snake.NeedsFood}. Is his eyes red? {snake.HasEyes}. Does he have legs? {snake.HasLegs}. ");
            Console.WriteLine($"Is he cold blooded? {snake.IsColdBlooded}. The guest asked what kind of skin does he have? The researcher answered with {snake.ReptileSkin}.");
            Console.WriteLine($"The guest then asked how big are the eggs? The zookeeper answered with {snake.ReptileEggs}.");
            Console.WriteLine($"The last note written said: Does he breathe with lungs? It was answered with {snake.BreathesWithLungs}, but only through one lung.");
            Console.WriteLine("Before the zookeeper could finish the research, the snake wiggled up to the zookeeper and made a terrifying sound:");
            snake.ReptileSound();
            Console.ReadLine();




            
        }
    }
}
