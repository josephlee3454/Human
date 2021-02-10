using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
class Human
{
    // Fields for Human
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    private int Health;

    public int health
    {
        get {return Health;}
    }
     
    public Human(string name ){
        Name = name;
        Strength = 3;
        Intelligence = 3; 
        Dexterity = 3;
        Health = 100;

    }
     public Human(string name , int str, int intelect, int dex , int health ){
        Name = name;
        Strength = str;
        Intelligence = intelect; 
        Dexterity = dex;
        Health = health;

    }
      public int Attack(Human target)
    {
        target.Health -= 5 * Strength;
        return target.health;
    }
     static void Main(string[] args)
        {
            
        }

}
    }
}