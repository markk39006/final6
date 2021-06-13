using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] textfile = new string[] {"","","","",""};
            bool check = true;
            int n;
            string text;
            while (check == true)
            {
                Console.WriteLine("Please input a number from 0 - 3 to choose the following menu:”");
                Console.WriteLine("“[0] Show all recent files”");
                Console.WriteLine("“[1] Open new file”");
                Console.WriteLine("“[2] Open recent file”");
                Console.WriteLine("“[3] Exit”");
                n = int.Parse(Console.ReadLine());
                
                textxx(ref textfile, n,check);
            }

        }
        static void textxx(ref string[] textfile,int n, bool check) 
        {
            if (n != 0 && n != 1 && n != 2)
            {
                while (check == true)
                {
                    Console.WriteLine("Invalid menu number.");
                    n = int.Parse(Console.ReadLine());
                    if (n == 0 || n == 1 || n == 2)
                    {
                        check = false;
                    }
                }
            }
            if (n == 1)
            {
                textfile[4] = "";
                textfile[3] = textfile[2];
                textfile[2] = textfile[1];
                textfile[1] = textfile[0];
                textfile[0] = Console.ReadLine();


            }
            if (n == 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("[{0}] {1}", i, textfile[i]);
                }
            }
            if (n == 2)
            {
                int p = int.Parse(Console.ReadLine());
                textfile[4] = "";
                textfile[3] = textfile[2];
                textfile[2] = textfile[1];
                textfile[1] = textfile[0];
                textfile[0] = textfile[p+1];
                if(textfile[p]== "")
                {
                    Console.WriteLine("No recent file.");
                }
            }
            if (n == 3)
            {
                check = false;
            }
        }
    }
}
