using System;

namespace TheSumofAdd1
{
    class Program
    {
        static void Main(string[] args)
        {
            int? magic_numbah = null;
            Console.WriteLine("Scanning index.txt\n");
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Tajs\source\repos\TheSumofAdd1\TheSumofAdd1\input.txt");

            // Display the file contents by using a foreach loop.
            
            foreach (string line1 in lines)
            {
                int firstint = Convert.ToInt32(line1.Replace(',', ' ').Trim());

                

                foreach (string line2 in lines)
                {
                    int secondint = Convert.ToInt32(line2.Replace(',', ' ').Trim());


                    //Saafremt at der kun skal findes to tal skal nedenstaaende loekke blot kommenteres vaek
                    foreach (string line3 in lines)
                    {
                        int thirdint = Convert.ToInt32(line3.Replace(',', ' ').Trim());






                        if (firstint + secondint + thirdint == 2020)
                        {
                            magic_numbah = firstint * secondint * thirdint;
                        }
                    }

                    /*
                    if (firstint + secondint == 2020)
                    {
                        magic_numbah = firstint * secondint;
                    }
                    */
                }
                

            }
            Console.Clear();
            if (magic_numbah == null)
            {
                Console.WriteLine("No magic number found.");
                System.Console.ReadKey();
            }
            else
            // Keep the console window open in debug mode.
            Console.WriteLine(magic_numbah.ToString() + " is the magic number"); 
            System.Console.ReadKey();


        }
    }
}
