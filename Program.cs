using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        private static bool else_;

        static void Main(string[] args)
        {
            string chosen_f;
            //string else_;

            //Reading in the files
            string[] File1 = System.IO.File.ReadAllLines(@"GitRepositories_1a.txt");
            string[] File2 = System.IO.File.ReadAllLines(@"GitRepositories_1b.txt");
            string[] File3 = System.IO.File.ReadAllLines(@"GitRepositories_2a.txt");
            string[] File4 = System.IO.File.ReadAllLines(@"GitRepositories_2b.txt");
            string[] File5 = System.IO.File.ReadAllLines(@"GitRepositories_3a.txt");
            string[] File6 = System.IO.File.ReadAllLines(@"GitRepositories_3b.txt");


            Console.WriteLine("Please select the files you wish to compare with each other: ");
            
            {
                Console.WriteLine(" A) File 1A compared to File 1B");
                Console.WriteLine(" B) File 2A compared to File 2B");
                Console.WriteLine(" C) File 3A compared to File 3B");

                chosen_f = Console.ReadLine();

                if (chosen_f == "A")
                {
                    //This compares the files line by line
                    IEnumerable<string>diff1 = File1.Except(File2);
                    bool check = false;
                    //True or false to check to if they are the same or not

                    foreach(string words in diff1)
                    {
                        check = true;
                    }
                    
                    if(check == true)
                    {
                        Console.WriteLine("Hit any key to find the results");
                        Console.ReadKey();
                        Console.WriteLine("Files are different ");
                        Console.WriteLine("The program will now close");
                        System.Environment.Exit(0);
                    }
                }   else
                    {
                        Console.WriteLine("Files are not different");
                        Console.WriteLine("The program will now close");
                        System.Environment.Exit(0);
                    }
            }       else_=(chosen_f == "B");
                    {
                        IEnumerable<string> diff2 = File3.Except(File4);
                        bool check2 = false;
                        foreach (string words in diff2)
                        {
                            check2 = true;
                        }
                        if(check2 == true)
                        {
                            Console.WriteLine("Hit any key to find the results");
                            Console.ReadKey();
                            Console.WriteLine("The files are different ");
                            Console.WriteLine("The program will now close");
                            System.Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("The files are the same");
                            Console.WriteLine("The program will now close");
                            System.Environment.Exit(0);
                        }
                    }
                    
                    if(chosen_f == "C")
            {
                IEnumerable<string> diff3 = File5.Except(File6);
                bool check3 = false;

                foreach (string words in diff3)
                {
                    check3 = true;
                }
                if(check3 == true)
                {
                    Console.WriteLine("Hit any key to find the results");
                    Console.ReadKey();
                    Console.WriteLine("The files are different");
                    Console.WriteLine("The program will now close");
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Files are not different");
                    Console.WriteLine("The program will now close");
                    System.Environment.Exit(0);
                }
            }
        }
    }
}
