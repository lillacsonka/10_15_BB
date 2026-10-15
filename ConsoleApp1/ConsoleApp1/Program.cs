namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            //Character Test = new Character("test");
            //Jani died for our sins
            /*Console.WriteLine(Test.GetDiscription());
            Console.WriteLine("test is alive"+ Test.IsAlive());
            Console.WriteLine("Total number of characters:" + Character.Count);*/


            Warrior w = new Warrior("w", 5);
            Console.WriteLine("Warrior name: " + w.Name);
            Console.WriteLine("warrrior health: " + w.Health);
            Console.WriteLine("warrior armour: " + w.Armor);
            Console.WriteLine(w.GetDiscription());

            Mage m = new Mage("m", 15);
            Console.WriteLine("Mage name: " + m.Name);
            Console.WriteLine("Mage health " + m.Health);
            Console.WriteLine("Mega mana: " + m.Mana);
            Console.WriteLine(m.GetDiscription);


                

            
        }
    }
}
