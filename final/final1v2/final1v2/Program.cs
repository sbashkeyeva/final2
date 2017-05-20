using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final1v2
{
    class Program
    {
        
        
        static bool check(int x)
        {
            int cur = 1;
            while (cur < x) {
                cur = cur + cur;
            }
            if (cur == x)
            {
                return true;
            }
            return false;
           }
        
        static void Main(string[] args)
        {
            DirectoryInfo Finfo = new DirectoryInfo(@"C:\Users\Chrome\Documents\Task1");
            int cnt = 0;
            // string s = Console.ReadLine(); 
            for (int i = 0; i < Finfo.GetFileSystemInfos().Length; i++)
            {
                if (Finfo.GetFileSystemInfos()[i].Name.Contains(".txt"))
                {
                    Console.Write(Finfo.GetFileSystemInfos()[i].Name);
                    string s = Finfo.GetFileSystemInfos()[i].FullName;
                    
                    StreamReader sr = new StreamReader(s);
                    string p = sr.ReadLine();
                    string[] t = p.Split();
                    int[] arr = new int[t.Length];
                    for (int j = 0; j < t.Length; j++)
                    {
                        arr[j] = int.Parse(t[j]);
                        if (check(arr[j]))
                        {
                            Console.Write(" " + arr[j] + " ");
                        }
                    }
                    Console.WriteLine();
                    cnt++;
                    
                }
            }
            if (cnt == 0)
            {
                Console.WriteLine("Not Found");
            }
            Console.ReadKey();
            //Console.WriteLine); 

        }
    }
}

