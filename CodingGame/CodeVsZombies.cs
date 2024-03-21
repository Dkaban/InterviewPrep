using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;

/**
 * Save humans, destroy zombies!
 **/
class Player
{
    static void Main(string[] args)
    {
        string[] inputs;

        // game loop
        while (true)
        {
            inputs = Console.ReadLine().Split(' ');
            int x = int.Parse(inputs[0]);
            int y = int.Parse(inputs[1]);

            List<Human> humanList = new List<Human>();
            int humanCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < humanCount; i++)
            {
                inputs = Console.ReadLine().Split(' ');
                int humanId = int.Parse(inputs[0]);
                int humanX = int.Parse(inputs[1]);
                int humanY = int.Parse(inputs[2]);

                humanList.Add(new Human(humanId,humanX,humanY));
            }

            List<Zombie> zombieList = new List<Zombie>();
            int zombieCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < zombieCount; i++)
            {
                inputs = Console.ReadLine().Split(' ');
                int zombieId = int.Parse(inputs[0]);
                int zombieX = int.Parse(inputs[1]);
                int zombieY = int.Parse(inputs[2]);
                int zombieXNext = int.Parse(inputs[3]);
                int zombieYNext = int.Parse(inputs[4]);

                zombieList.Add(new Zombie(zombieId,zombieX,zombieY,zombieXNext,zombieYNext));
            }

            float destX = 0;
            float destY = 0;
            var dist = 0.0f;

            //Move to the guy who has the zombies the furthest away

            for(int h=0;h<humanList.Count;h++)
            {
                for(int z=0;z<zombieList.Count;z++)
                {
                    var newDist = Vector2.Distance(humanList[h].position, zombieList[z].position);

                    if(newDist > dist)
                    {
                        dist = newDist;
                        destX = humanList[h].position.X;
                        destY = humanList[h].position.Y;
                    }

                    //Need to negate everything if a zombie is too close
                    if(newDist < 300)
                    {
                        z = zombieList.Count-1;
                    }
                }
            }
            Console.WriteLine($"{destX} {destY}");
        }
    }
}

class Human
{
    public int iD;
    public Vector2 position;

    public Human(int id, int x, int y)
    {
        iD = id;
        position = new Vector2(x,y);
    }
}

public class Zombie
{
    public int Id;
    public Vector2 position;
    public Vector2 movePosition;

    public Zombie(int id, int x, int y, int xNext, int yNext)
    {
        Id = id;
        position = new Vector2(x,y);
        movePosition = new Vector2(xNext, yNext);
    }
}
