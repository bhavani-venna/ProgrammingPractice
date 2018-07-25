using System;
class Program
{ 
    static void Main() 
    { 
        int[] n = new int[10];
        n = Test1(); 
        Test(n);
    }
    static int[] Test1() 
    { 
        int[] n = new int[10]; 
        for (int i = 0; i < 10; i++) 
        { 
            n[i] = i;
        } 
    return n;
    } 
    static void Test(int[] n) 
    { 
        for (int i = 0; i < 10; i++)
        { 
            Console.WriteLine(n[i]);
        } 
    } 
    Console.ReadLine();
}
