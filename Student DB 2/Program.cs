using System;
using System.Collections.Generic;

namespace Student_DB_2
{
    internal class Program
    {
        static void Main(string[] args) //Git -> commit or stash -> skriv noget i message -> sync -> save
        {

            //sætter Id til 1
            int startId = 1;
            //laver en ny liste han kaldte listen students
            List<student> studentsList = new List<student>();



            //add'er ny studerende
            studentsList.Add(new student(startId)
            {
                FirstName = "Jacob ",
                LastName = "Lauritzen ",
                
                birthdate = new birthdate(false)
                {
                    day = 20,
                    month = 1,
                    year = 1989
                }
                

            });
            startId++;

            //add'er ny studerende
            studentsList.Add(new student(startId)
            {
                FirstName = "Alex ",
                LastName = "Dietz ",
                birthdate = new birthdate(false)
                {
                    day = 1,
                    month = 12,
                    year = 1999
                }

            });
            startId++;

            while (true) {
                {

                    while (true)
                    {

                        Console.WriteLine("1 - Vis liste over studerende, 2 - tilføj ny studerende");
                        string input = Console.ReadLine();
                        if (input == "1") //bruger vælger at se oversigten
                        {
                            foreach (var student in studentsList)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(student.ToString());
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            break;
                        }



                        else if (input == "2") //bruger tilføjer ny student
                        {

                            Console.WriteLine("Skriv navn på den nye student ");
                            var firstname = Console.ReadLine();

                            Console.WriteLine("Skriv efternavn på den nye student ");
                            var lastname = Console.ReadLine();

                            birthdate b = new birthdate(true);

                            studentsList.Add(new student(startId)
                            {

                                FirstName = firstname,
                                LastName = lastname,
                                birthdate = b

                            });
                            startId++;

                            foreach (var student in studentsList)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(student.ToString());
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\n\n Du skal vælge 1 eller 2 ! \n \n");
                        }
                        
                        //kommentar

                    };
                }


            }
        }
    }
}

