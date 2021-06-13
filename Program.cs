using System;

namespace finalnum5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numofitem;
           
            numofitem = int.Parse(Console.ReadLine());
            string findofitem;
            string[] nameofitem = new string[numofitem];
            string[] typeofitem = new string[numofitem];
            for (int i = 0; i < numofitem; i++)
            {
                nameofitem[i] = Console.ReadLine();
                typeofitem[i] = Console.ReadLine();
            }
            string findofitemcheck = "notCorrect";
            do
            {
                findofitemcheck = "notCorrect";
                findofitem = Console.ReadLine();
                if (findofitem == "ShowAll")
                {
                    for (int i = 0; i < numofitem; i++)
                    {
                        Console.WriteLine();
                        Console.WriteLine(nameofitem[i]);
                        Console.WriteLine(typeofitem[i]);
                       
                    }
                }

                else
                {
                    for (int i = 0; i < numofitem; i++)
                    {
                        if (findofitem == typeofitem[i])
                        {
                            if (findofitem == typeofitem[i])
                            {
                                Console.WriteLine(nameofitem[i]);
                                Console.WriteLine();
                                findofitemcheck = "truely";
                            }
                        }
                    }
                

                }
            } while (findofitem == "ShowAll" || findofitemcheck == "truely");
            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
