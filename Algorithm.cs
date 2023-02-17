# Kruskal-Algorithm
using System;
using System.Collections.Generic;
using System.Linq;
public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Количество точек");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Количество ребер");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Точка, ребро, вeс");
        List<string[]> tree = new List<string[]>();
        int cost = 0;
        int[] toch = new int[n];
        for (int i = 0; i < n; i++)
        {
            toch[i] = i+1;
        }
        for (int i = 0; i < m; i++)
        {
            string[] a = Console.ReadLine().Split();
            tree.Add(a);
        }

        for (int write = 0; write < tree.Count; write++)
        {
            for (int sort = 0; sort < tree.Count - 1; sort++)
            {
                if (Convert.ToInt32(tree[sort][2]) > Convert.ToInt32(tree[sort+1][2]))
                {
                    string[]temp = tree[sort + 1];
                    tree[sort + 1] = tree[sort];
                    tree[sort] = temp;
                }
            }
        }


        for (int i = 0; i < m; i++)
        {
            if (toch[Convert.ToInt32(tree[i][0])-1] != toch[Convert.ToInt32(tree[i][1])-1])
            {
                cost += Convert.ToInt32(tree[i][2]);
                Console.WriteLine("{0} - {1}, {2}", Convert.ToInt32(tree[i][0]), Convert.ToInt32(tree[i][1]), Convert.ToInt32(tree[i][2]));
                for (int j = 0; j < n;j++ )
                {
                    if (toch[j] == Convert.ToInt32(tree[i][1]))
                    {
                        toch[j] = Convert.ToInt32(tree[i][0]);
                        Console.WriteLine(toch[j]);
                    }
                }
            }
        }
        Console.WriteLine(cost);
    }
}
