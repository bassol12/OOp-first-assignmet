using System;
using System.Drawing;
using System.Security;

namespace ConsoleApp6
{
    #region question 1
    //enum weekdays
    //{
    //    sunday=0,
    //    monday=1,
    //    tuesday =2,
    //    wednesday=3,
    //    thursday=4, 
    //    friday=5,
    //    satarday=6
    //}

    #endregion

    #region question 3
    //enum Seasons
    //{
    //    Spring = 0,
    //    summer = 1,
    //    autumn = 2,
    //    winter = 3
    //}
    #endregion

    #region question 4
    //[Flags]
    //enum Permission
    //{
    //    read=1,
    //    write=2,
    //    delete=4,
    //    execute = 8
    //}

    #endregion

    #region question 6
        //enum Colors
        //{
        //    red = 0,
        //    blue = 1,
        //    green = 2
        //}
        #endregion

    internal class Program
    {
        static void Main(string[] args)
        {

            #region question 1

            //foreach (string day in Enum.GetNames(typeof(weekdays)))
            //{
            //  Console.WriteLine(day);
            //}
            #endregion

            #region question 2
            //person[] person = new person[3];
            //person[0].name = "bassell";
            //person[0].age = 20;
            //person[1].name = "hassan";
            //person[1].age = 30; 
            //person[2].name = "sayed";
            //person[2].age = 40;

            //for (int i = 0; i < person.Length; i++)
            //{
            //    Console.WriteLine($"Name: {person[i].name}, Age: {person[i].age}");
            //}
            #endregion

            #region question 3
            //Console.WriteLine("enter season");
            //string input = Console.ReadLine();
            //if (Enum.TryParse(typeof(Seasons), input, true ,out object result))
            //{
            //    Seasons seasons = (Seasons)result;

            //    switch (seasons)
            //    { 
            //        case Seasons.Spring:
            //            Console.WriteLine("March, April, May");
            //           break;
            //        case Seasons.summer:
            //            Console.WriteLine("June, July, August");
            //            break;
            //        case Seasons.autumn:
            //            Console.WriteLine("September, October, November");
            //            break;
            //        case Seasons.winter:
            //            Console.WriteLine("December, January, February");
            //            break;
            //    }   
            //}


            #endregion

            #region question 4
            //Permission user = Permission.read | Permission.write;
            //Console.WriteLine(user);

            //if ((user & Permission.read) == Permission.read)
            //{
            //    Console.WriteLine("read is alredy exists");

            //}
            // else
            //    user |= Permission.read;
            //Console.WriteLine(user);
            #endregion

            #region question 5
            //point p1 = new point();
            //point p2 = new point();

            //Console.WriteLine("Enter X for point 1:");
            //p1.x = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter Y for point 1:");
            //p1.y = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter X for point 2:");
            //p2.x = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter Y for point 2:");
            //p2.y = Convert.ToDouble(Console.ReadLine());

            //double distance = Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
            //Console.WriteLine(distance);
            #endregion

            #region question 6
            //Console.WriteLine("enter color");
            //string input = Console.ReadLine();
            //if (Enum.TryParse(typeof(Colors), input, true, out object result))
            //{
            //    Colors scolor = (Colors)result;

            //    if (scolor == Colors.red || scolor == Colors.blue || scolor == Colors.green)
            //    {
            //        Console.WriteLine($" {scolor} is primary color");

            //    }
            //    else
            //    {
            //        Console.WriteLine($"{scolor} is not a primary color.");
            //    }
            #endregion

            #region question 7
            //person2 p1 = new person2();
            //person2 p2 = new person2();
            //person2 p3 = new person2();


            //Console.WriteLine("enter person 1 name and age");
            //p1.name = Console.ReadLine();
            //p1.age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("enter person 3 name and age");
            //p2.name = Console.ReadLine();
            //p2.age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("enter person 2 name and age");
            //p3.name = Console.ReadLine();
            //p3.age = Convert.ToInt32(Console.ReadLine());
            //person2 oldest = p1;

            //if (p2.age > oldest.age)
            //{
            //    oldest = p2;
            //}

            //if (p3.age > oldest.age)
            //{
            //    oldest = p3;
            //}
            //Console.WriteLine($"The oldest person is {oldest.name} with age {oldest.age}");

            #endregion

        }
    }
}
