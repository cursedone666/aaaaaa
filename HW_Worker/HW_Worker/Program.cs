using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Worker
{
    public class Program
    {
        static void Main(string[] args)
        {
            int option, subordinates, respLevel, profOpt;
            double salary;
            string name;
            bool quit = true;
            List<Worker> workers = new List<Worker>();
            int choose;
            do
            {   //amount of workers to create
                Console.WriteLine("Enter amount of workers you would like to create");
                choose = int.Parse(Console.ReadLine());
            
            
                //prof choosing and seting data
                if (choose != 0)
                {   
                    for (int i = 0; i < choose; i++)
                    {   
                        Console.WriteLine("Choose position: \n 1. Professor \n 2. Rector \n 3. Dean \n 4. Laborant \n 5. Assistant \n 6. Exit");
                        profOpt = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the name of worker: ");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter salary: ");
                        salary = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter subordinates: ");
                        subordinates = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter level of responsibility: ");
                        respLevel = int.Parse(Console.ReadLine());

                        Add_worker(profOpt, salary, name, subordinates, respLevel, workers);
                    }
                }
                else if (choose < 0 || choose == 0)
                {
                    Console.WriteLine("You must enter number bigger than 0");
                }

                //show list of workers
                Console.WriteLine("Do you wanna see the list of workers? \n 1. Yes \n 2. No");
                option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    for (int i = 0; i < choose; i++)
                    {
                        Console.WriteLine("======================");
                        Console.WriteLine($"Position: {workers[i].Position()}");
                        Console.WriteLine($"Name: {workers[i].Name()}");
                        Console.WriteLine($"Salary: {workers[i].Salary()}");
                        Console.WriteLine($"Subordinates: {workers[i].Subordinates()}");
                        Console.WriteLine($"Level of responsibility: {workers[i].ResponsibilityLevel()} \n======================");
                    }
                }
                //worker searching by name
                bool cycle_opt = true;           
                Console.WriteLine("Do you wanna find worker by name? \n 1. Yes \n 2. No");
                int variant = int.Parse(Console.ReadLine());
                if (variant == 1)
                {
                    do
                    {

                        Console.WriteLine("Enter users name or enter 9 to exit");
                        name = Console.ReadLine();
                        foreach (Worker worker in workers)
                        {
                            if (name == worker.Name())
                            {
                                Console.WriteLine($"=====================");
                                Console.WriteLine($"Position: {worker.Position()}");
                                Console.WriteLine($"Name: {worker.Name()}");
                                Console.WriteLine($"Salary: {worker.Salary()}");
                                Console.WriteLine($"Subordinates: {worker.Subordinates()}");
                                Console.WriteLine($"Level of responsibility: {worker.ResponsibilityLevel()}");
                                Console.WriteLine($"=====================");
                            }
                            if (name == "9")
                            {
                                
                                cycle_opt = false;
                            }
                        }
                    } while (cycle_opt);
                } else if (variant == 2)
                {
                    Console.WriteLine("Quiting");
                }
                Console.WriteLine("Do u wanna quit?\n 1. Yes \n 2. No");
                if (int.Parse(Console.ReadLine()) == 1)
                {
                    quit = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You are moved to creation ");
                    continue;
                }


            } while (quit);
        }

        static void Add_worker(int profOpt, double salary, string name, int subordinates, int respLevel, List<Worker> workers)
        {
            switch (profOpt)
            {
                case 1:

                     workers.Add(new Professor(name, salary, subordinates, respLevel));
                    break;
                case 2:
                    workers.Add(new Rector(name, salary, subordinates, respLevel));
                    break;
                case 3:
                    workers.Add(new Dean(name, salary, subordinates, respLevel));
                    break;
                case 4:
                    workers.Add(new Laborant(name, salary, subordinates, respLevel));
                    break;
                case 5:
                    workers.Add(new Assistant(name, salary, subordinates, respLevel));
                    break;
                default:
                    throw new Exception();
            }
        }


    }
}
