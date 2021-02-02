using System;

namespace assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            LearnAssignment learn = new LearnAssignment();
            FileHandling newFile = new FileHandling();
            newFile.CreateFile();
            newFile.writeFile();
            
        //    Console.WriteLine("User please press 1 for addition. Press 2 for subtraction. Press 3 for multiplicaiton. Press 4 for Division");
        //    int ActionToPerform = Convert.ToInt32(Console.ReadLine());

        //    switch (ActionToPerform)
        //    {
        //        case 1:
        //            Console.WriteLine("Please input four values");
        //            int a = Convert.ToInt32(Console.ReadLine());
        //            int b = Convert.ToInt32(Console.ReadLine());
        //            int c = Convert.ToInt32(Console.ReadLine());
        //            int d = Convert.ToInt32(Console.ReadLine());
        //            learn.calculation(a, b, c, d);
        //            break;

        //        case 2:
        //            Console.WriteLine("Please input two values");
        //            int e = Convert.ToInt32(Console.ReadLine());
        //            int f = Convert.ToInt32(Console.ReadLine());
        //            learn.calculation(e, f);
        //            break;

        //        case 3:
        //            Console.WriteLine("Please input three values");
        //            int a1 = Convert.ToInt32(Console.ReadLine());
        //            int b1 = Convert.ToInt32(Console.ReadLine());
        //            int c1 = Convert.ToInt32(Console.ReadLine());
        //            learn.calculation(a1, b1, c1);
        //            break;

        //        case 4:
        //            Console.WriteLine("Please input two values");
        //            int a2 = Convert.ToInt32(Console.ReadLine());
        //            int b2 = Convert.ToInt32(Console.ReadLine());
                   
        //            learn.calculation(a2, b2,"Please listen");

        //            break;

        //    }
        //
        }

    }
}