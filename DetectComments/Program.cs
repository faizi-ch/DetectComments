using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectComments
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader(@"f:\test.txt");

            string line = file.ReadLine();

            DetectComment(line);

            Console.ReadKey();
        }
        static void DetectComment(string s)
        {
            Console.Clear();

            /*Console.Write("Enter a string: ");
            string s = Console.ReadLine();*/

            string temp = "";
            char[] ar = s.ToCharArray();

            int b = 0;

            bool sc = false;
            bool mc = false;

            Console.WriteLine("\nComment:");

            if (s.Contains("//"))
            {
                for (int i = 0; i < ar.Length; i++)
                {
                    if (ar[i] == '/' && ar[i + 1] == '/')
                    {
                        i += 2;
                        sc = true;
                    }

                    if (sc)
                    {
                        Console.Write(ar[i]);
                    }

                    if (!sc)
                    {
                        temp += ar[i];
                    }
                }
            }
            else if (s.Contains("/*"))
            {
                for (int i = 0; i < ar.Length; i++)
                {
                    if (ar[i] == '/' && ar[i + 1] == '*')
                    {
                        i += 2;
                        mc = true;
                    }

                    if (ar[i] == '*' && ar[i + 1] == '/')
                    {
                        i += 2;
                        mc = false;
                    }

                    if (mc)
                    {
                        Console.Write(ar[i]);
                    }

                    if (!mc)
                    {
                        temp += ar[i];
                    }
                }
            }


            Console.WriteLine("\n\nWithout comment: " + temp);


        }
    }
}
