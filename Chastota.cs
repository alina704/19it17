using System;
using System.Linq;
using System.Collections.Generic;
 
public class Chastota
{
    public static void Main(String[] args)
    {
        List<Int16> Virables = new List<Int16>();

        for (Int32 i = Int32.Parse(Console.ReadLine()); i > 0; i--)
            Virables.Add(Int16.Parse(Console.ReadLine()));

        foreach (var Line in from g in Virables
                             group g by g into ng
                             orderby ng.Key
                             select new
                             {
                                 Count = ng.Count(),
                                 Key = ng.Key
                             })
            Console.WriteLine("{0} {1}", Line.Key, Line.Count);
    }
}