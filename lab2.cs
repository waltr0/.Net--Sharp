using System;
class lab2{
    public static void Main(){
        int a;
        int b;
        Console.Write("enter 1st num ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("enter 2st num ");
        b = Convert.ToInt32(Console.ReadLine());
        int c=a+b;
        int d=a-b;
        int e=a*b;
        int f=a/b;
        Console.WriteLine("Addition: "+c);
        Console.WriteLine("Subtraction: "+d);
        Console.WriteLine("Multiplication: "+e);
        Console.WriteLine("Division: "+f);
    }
}