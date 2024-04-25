using System.Drawing;
using System.Globalization;

namespace Day3_Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Day 3 Assignment
            //Console.WriteLine("===========================================");

            //_3DPoint p1 = new _3DPoint(1,2,3);
            //Console.WriteLine(p1.ToString());  //testing over loading on ToString() func  

            //_3DPoint p2 = new _3DPoint(1,2,3);
            //Console.WriteLine(p2.ToString());  //testing over loading on ToString() func

            //Console.WriteLine("\nTesting Over loading on Equal func :");
            //Console.WriteLine(p1.Equals(p2));

            //Console.WriteLine("\nTesting == opertaor :");
            //Console.WriteLine(p1 == p2);

            //Console.WriteLine("===========================================");

            //_3DPoint p3 = new _3DPoint(1, 2, 3);
            //_3DPoint p4 = new _3DPoint(10, 20, 30);

            //Console.WriteLine("\nTesting Over loading on Equal func :");
            //Console.WriteLine(p3.Equals(p4));

            //Console.WriteLine("\nTesting == opertaor :");
            //Console.WriteLine(p3 == p4);

            //Console.WriteLine("===========================================");

            //_3DPoint p5 = new _3DPoint(1, 2, 3);
            //_3DPoint p6 = p5; 

            //Console.WriteLine("\nTesting Over loading on Equal func :");
            //Console.WriteLine(p5.Equals(p6));

            //Console.WriteLine("\nTesting == opertaor :");
            //Console.WriteLine(p5 == p6);

            //Console.WriteLine("===========================================");

            //_3DPoint p7 = new _3DPoint(12,4,2);
            //_3DPoint p8 = new _3DPoint(2,11,6);
            //_3DPoint p9 = new _3DPoint(62,6,88);
            //_3DPoint p10 = new _3DPoint(25,1,27);

            //_3DPoint[] points = new _3DPoint[] { p7, p8, p9, p10 };

            //_3DPoint.Display3DPointsArr(points);

            //Console.WriteLine("===========================================");


            //Person pr1 = new Person();
            //Person pr2 = new Person("Ali" , 30);

            //Console.WriteLine(pr1.ToString());
            //Console.WriteLine(pr2.ToString());

            //Employee e1 = new Employee();
            //Employee e2 = new Employee(1, 1000);

            //Console.WriteLine(e1.ToString());
            //Console.WriteLine(e2.ToString());

            //Trainee T1 = new Trainee();
            //Trainee T2 = new Trainee(2,44);

            //Console.WriteLine(T1.ToString());
            //Console.WriteLine(T2.ToString());

            //Console.WriteLine("-------------------------");    

            //Person[] persons = new Person[] { pr1, pr2 , e1 , e2 , T1 , T2 };

            //for(int i = 0; i < persons.Length; i++)
            //{
            //    Console.WriteLine(persons[i].ToString());
            //}

            //Console.WriteLine("==========================================="); 
            #endregion

            #region Day 4 Assignment

            //_3DPoint[] points = new _3DPoint[3];

            //points[0] = new _3DPoint(1, 1, 1);
            //points[1] = new _3DPoint(2, 2, 2);
            //points[2] = new _3DPoint(3, 3, 3);

            //Array.Sort(points);

            //for (int i = 0; i < points.Length; i++)
            //{
            //    Console.WriteLine(points[i]);
            //}

            //Console.WriteLine("------------------");

            //_3DPoint p1 = new _3DPoint(1, 2, 3 ) ;
            //object p2 = p1.Clone() ;
            //_3DPoint p3 = p1.Clone() as _3DPoint ;

            //Console.WriteLine(p2);
            //Console.WriteLine(p3);

            //Console.WriteLine("------------------");

            //Employee e1 = new Employee() ;
            //e1.Salary = 1000m ;
            //Console.WriteLine(e1.ShowPayment());

            //Console.WriteLine("------------------");

            //Trainee t1 = new Trainee();
            //t1.Salary = 2000m ;
            //Console.WriteLine(t1.ShowPayment());

            //Console.WriteLine("------------------"); 
            #endregion

            decimal x = 7 / 5;

            Console.WriteLine(x);

        }
    }
}