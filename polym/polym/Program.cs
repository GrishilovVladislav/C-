using System;
using System.Collections.Generic;

namespace polym
{
    class Program
    {
        static void Main(string[] args)
        {
            Human P1 = new Human();
            Black B1 = new Black();
            White W1 = new White();
            Humans persons = new Humans();
            persons[0] = P1;
            persons[1] = B1;
            persons[2] = W1;
            P1.skin();
            B1.skin();
        }

    }
}

class Human
{
    public virtual void skin()
    {
        Console.WriteLine("I have skin");
    }
}

class Black : Human
{
    public override void skin()
    {
        base.skin();
        Console.WriteLine(" black");
    }
}
class White : Human
{
    public override void skin()
    {
        base.skin();
        Console.WriteLine(" white");
    }
}

class Humans
{
    List<Human> MyHumans;
    private int HowManyHumans = 0;
    public Humans()
    {
        MyHumans = new List<Human>();
        HowManyHumans = 0;
    }
    public Human this[int ID]
    {
        get
        {
            if (ID < 0 || ID >= HowManyHumans)
            {
                throw new Exception("There is no such index");
            }
            return MyHumans[ID];
        }
        set
        {
            MyHumans.Insert(ID, value);
            ++HowManyHumans;
        }
    }
}