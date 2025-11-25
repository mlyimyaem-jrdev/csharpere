using System.Reflection.Metadata;

namespace ConsoleApp1;

public class MethodsLesson
{
    static int getAge()
    {
        return 20;
        int x = 21;
    }
    static int Sum(int a, int b)
    {
        int add = a + b;
        return add;
    }
    static int Sum(int a = 1, int b = 1, int c = 1)
    {
        int add = a + b + c;
        return add;
    }
    static void PassByRef(ref int o)
    {
        o += 1; // o = o+1;
        System.Console.WriteLine($"the value of p inside PassByRef is {o}");
    }
    static void PassByRefOut(out int o)
    {
        o = 1; // o = o+1;
        System.Console.WriteLine($"the value of p inside PassByRefOut is {o}");
    }
    static bool tOrF()
    {
        return false;
    }
    static string myName(string name)
    {
        return $"Welcome {name}, have a nice day!!!";
    }
    static Tree tree()
    {
        return new Tree();
    }
    static int Sum(string name, params int[] nums)
    {
        int add = 0;
        foreach (int num in nums)
        {
            add += num; // add = add+nums;
        }
        return add;
    }
    static void Main(string[] args)
    {
        System.Console.WriteLine("Welcome to .Net Programming");
        int age = getAge();
        System.Console.WriteLine($"Age is : {age}");
        System.Console.WriteLine(Sum(+10, +20));
        System.Console.WriteLine(Sum(+10, +20, 30));
        System.Console.WriteLine(Sum(c: 20, b: 10, a: -20));
        int p = 8;
        System.Console.WriteLine(Sum());
        System.Console.WriteLine(Sum(p));
        System.Console.WriteLine(Sum(8, 2, 2));
        PassByRef(ref p);
        System.Console.WriteLine(p);
        int q;
        PassByRefOut(out q);
        System.Console.WriteLine(q);
        System.Console.WriteLine(myName("Marco"));
        System.Console.WriteLine(Sum("marco",1,2,3,4,5,6,7,8,9,10));

    }
}

class Tree
{
    int age;
    string name;
}