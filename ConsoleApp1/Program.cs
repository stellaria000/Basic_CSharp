using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int[] array1 = new int[3];
        array1[0] = 10;
        array1[1] = 20;
        array1[2] = 30;

        int[] array2 = new int[] { 1, 2, 3 };

        int[] array3 = { 4, 5, 6 };

        //Console.WriteLine(array1);
        //Console.WriteLine(array2);
        //Console.WriteLine(array3);

        Console.WriteLine(array1[0]);
        Console.WriteLine(array1[2]);
        Console.WriteLine(array1[1]);

        for(int i= 0; i< 3; i++) { Console.WriteLine(array2[i]); }

        foreach(int i in array3)
        {
            Console.WriteLine(i);
        }

        int[] array = { 1, 2, 3, 4, 5 };

        Console.WriteLine(array.Length);
    }
}
