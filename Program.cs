using System;

namespace matrix
{
    class Program
    {
        static void Main(string[] args)
    {
        int [] arr1,arr2,arr3,arr4;
        arr1=new int[4];
        arr2=new int[4];
        arr3=new int[4];
        arr4=new int[4];
        for (int i=0;i<=3;i++)
        {
            arr1[i]=i+1;
            arr2[i]=i+2;
            arr3[i]=i+3;
            arr4[i]=i+4;
            Console.WriteLine($"{arr1[i]} {arr2[i]} {arr3[i]} {arr4[i]}");
        }
        Console.WriteLine();
        for (int i=3;i>=0;i--)
        {
        Console.WriteLine($"{arr1[i]} {arr2[i]} {arr3[i]} {arr4[i]}");
    }
    }
}
}

