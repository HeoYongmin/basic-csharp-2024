﻿namespace ex08_generics
{
    internal class Program
    {
        static void copyArray(int[] src, int[] dest)
        {
            for (int i = 0; i < src.Length; i++)
                dest[i] = src[i];
        }

        static void copyArray(float[] src, float[] dest)
        {
            for (int i = 0; i < src.Length; i++)
                dest[i] = src[i];
        }

        static void Main(string[] args)
        {
            int[] array1 = { 10, 20, 30, 50, 70 };
            int[] array2 = new int[array1.Length];

            copyArray(array1, array2);

            Console.WriteLine(array2[4]);

            float[] array3 = { 3.4f, 2.2f, 7.7f };
            float[] array4 = new float[array3.Length];

            copyArray(array3, array4);
            Console.WriteLine(array4[0]);

        }
    }
}