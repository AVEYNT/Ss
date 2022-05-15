using System;
using System.Collections.Generic;
using System.Data;


class Search
{
    static int [] data = new int[4] { 10, 24, 3, 5 };
    static int x;

    static void Main (String [] args)
    {
        Console.WriteLine ("Masukkan nilai yang dicari= ");
        x = Int32.Parse(Console.ReadLine());

        cari(x, data);
    }
    private static void cari ( int x, int [] data)
    {
        for(int i=0; i<data.Length; i++)
        {
            if (data[i] == x)
            {
                Console.WriteLine("Data Ditemukan");
            }
        }
    }
}