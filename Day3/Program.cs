namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Inheritance & Polymorphism
            /*Creature c1 = new Creature();
                Creature c2 = new Creature(50);*/

            /*Human h = new Human();
            h.Move();

            Creature c3 = new Human();
            //c3.Move();
            //c3.Test();

            Employee e1 = new Employee();
            Human h1 = new Employee();
            Creature c4 = new Employee();

            //e1.Eat();
            c4.Eat();*/
            #endregion

            Human h1 = new Human();
            Human h2 = new Human();

            /* h1.Age = h2.Age = 10;

             if(h1.Equals(100))
             {
                 Console.WriteLine("Equals");
             }
             else 
             {
                 Console.WriteLine("Not Equal");
             }*/
            h1.Age = 20;
            Console.WriteLine(h1.GetHashCode());
            Console.WriteLine(h2.GetHashCode());

            Human h3 = h1.Clone();



        }
    }
}