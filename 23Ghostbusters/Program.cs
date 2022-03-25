using System;

namespace _23Ghostbusters
{
    class Program
    {
        static void Main(string[] args)
        {
            NoisyGhost foxy = new NoisyGhost("Foxy");
            Console.WriteLine(foxy);
            foxy.haunt();

            Ghost g = new NoisyGhost("Fix");
            Console.WriteLine(g);
            g.haunt();

            SlimeGhost slimy = new SlimeGhost("Slimy", "green");
            Ghost badguy = new SlimeGhost("Bad Guy", "black");
            Console.WriteLine(slimy);
            Console.WriteLine(badguy);
            slimy.haunt();
            badguy.haunt();


            CannibalGhost mrHungry = new CannibalGhost("Mr. Hungry");
            mrHungry.eat(foxy);
            mrHungry.eat(g);
            mrHungry.eat(slimy);
            mrHungry.eat(badguy);
            mrHungry.haunt();
            mrHungry.eat(mrHungry);

            Console.WriteLine(mrHungry.Size);
        }
    }
}
