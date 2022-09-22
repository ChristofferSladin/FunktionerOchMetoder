using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using FunktionerOchMetoder.Model;

namespace FunktionerOchMetoder
{
    internal class FunktionerOchMetoderLabbar
    {
        public void ShowMenu()
        {
            Console.WriteLine("1. Skapa spelare");
            Console.WriteLine("2. Lista spelare");
            Console.WriteLine("3. Ta bort spelare");
            Console.WriteLine("4. Ändra spelare");
            Console.WriteLine("5. Exit");
            Console.WriteLine("---------------------------");
        }

        public HockeyPlayer GetNewPlayer(List<HockeyPlayer> allLegendaryPlayers)
        {
            Console.WriteLine("Ange namn på nya spelare");
            var name = Console.ReadLine();
            Console.WriteLine("Ange ålder på nya spelare");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Ange nummr på tröjan på nya spelare");
            int jersey = int.Parse(Console.ReadLine());

            var player = new HockeyPlayer();
            
            player.Name = name;
            player.Age = age;
            player.JerseyNumber = jersey;

            return player;
        }
        public void ListAllPlayers(List<HockeyPlayer> allLegendaryPlayers)
        {
            foreach (var player in allLegendaryPlayers)
                Console.WriteLine($"Namn: {player.Name}\nTröjnummer: {player.JerseyNumber}\nÅlder: {player.Age}\n");
        }
        public void LegendaryPlayers() // PROGRAMMET VI KÖR
        {
            var allLegendaryPlayers = new List<HockeyPlayer>();
            bool run = true;

            while (run)
            {
                ShowMenu();
                var menyVal = GetIntInput("Ange ett menyval", 1, 5);

                switch (menyVal)
                {
                    case 1:
                        var player = GetNewPlayer(allLegendaryPlayers);
                        allLegendaryPlayers.Add(player);
                        break;

                    case 2:
                        ListAllPlayers(allLegendaryPlayers);
                        break;

                    case 3:

                        Console.WriteLine("Ange spelaren du vill ta bort");
                        Console.WriteLine("Namn, ålder, tröjnummer");




                        break;

                    case 4:


                        break;

                    case 5:
                        run = false;

                        break;
                }
            }
        }

        public int GetIntInput(string prompt, int minValue, int maxValue)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                try
                {
                    int menyVal = int.Parse(Console.ReadLine());

                    if (menyVal < minValue || menyVal > maxValue)
                    {
                        Console.WriteLine($"Mata in ett tal mellan {minValue} och {maxValue} tack");
                    }
                    else
                        return menyVal;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Mata in siffror tack");
                }
            }
        }



        //int CalculateSalary(int age, int hourlySalary, int hoursWorked)
        //{
        //    int salary = 0;
        //    if (age > 50)
        //    {
        //        salary = Convert.ToInt32(hourlySalary * hoursWorked * 1.1f);
        //    }
        //    else if (age < 18)
        //    {
        //        salary = Convert.ToInt32(hourlySalary * hoursWorked * 0.5f);
        //    }
        //    else
        //        salary = hourlySalary * hoursWorked;
        //    return salary;
        //}

        public void Run()
        {
            LegendaryPlayers();

            //Console.WriteLine("Ange ålder");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ange timlön");
            //int hourlySalary = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ange arbetade timmar");
            //int hoursWorked = int.Parse(Console.ReadLine());

            //int calculatedSalary = CalculateSalary(age, hourlySalary, hoursWorked); 
            //Console.WriteLine($"Lönen är {calculatedSalary}");
        }


        
    }
}
