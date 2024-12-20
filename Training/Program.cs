// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Diagnostics;
namespace ProgrammingExercise
{
    class RockPaperScisser
    {
        static void Main(string[] args)
        {
            bool RePlay = true;

            while (RePlay)
            {


                string Rock = "Rock".ToUpper(), Paper = "Paper".ToUpper(), Scisser = "Scisser".ToUpper();

                int PcScore = 0, UserScore = 0, WinerScore = 3;

                Console.WriteLine("Game Started");
                bool isfristTime = true;
                while (UserScore < WinerScore && PcScore < WinerScore)
                {
                    Console.WriteLine("Enter Your Choice");
                    if (isfristTime)
                    {
                        Console.WriteLine("1: Rock");
                        Console.WriteLine("2: Paper");
                        Console.WriteLine("3: Scisser");
                        isfristTime = false;

                    }
                    string YourChoice = Console.ReadLine(), PcChoice = "";

                    int RandomNumber = new Random().Next(1, 3);

                    switch (RandomNumber)
                    {
                        case 1:
                            PcChoice = Rock;
                            break;
                        case 2:
                            PcChoice = Paper;
                            break;
                        case 3:
                            PcChoice = Scisser;
                            break;
                    }
                    switch (YourChoice)
                    {

                        case "1":
                            YourChoice = Rock;
                            break;
                        case "2":
                            YourChoice = Paper;
                            break;
                        case "3":
                            YourChoice = Scisser;
                            break;
                    }
                    if (YourChoice == PcChoice)
                    {
                        Console.WriteLine("Draw");
                        Console.WriteLine("Your Score is : " + UserScore);
                        Console.WriteLine("PC Score is : " + PcScore);
                    }
                    else if (YourChoice == Rock && PcChoice == Paper)
                    {
                        PcScore++;
                        Console.WriteLine("Your Choice : " + YourChoice + " and Pc Choice : " + PcChoice + " then Pc win the round");
                        Console.WriteLine("Your Score is : " + UserScore);
                        Console.WriteLine("PC Score is : " + PcScore);
                    }
                    else if (YourChoice == Rock && PcChoice == Scisser)
                    {
                        UserScore++;
                        Console.WriteLine("Your Choice : " + YourChoice + " and Pc Choice : " + PcChoice + " then You win the round");
                        Console.WriteLine("Your Score is : " + UserScore);
                        Console.WriteLine("PC Score is : " + PcScore);
                    }
                    else if (YourChoice == Paper && PcChoice == Rock)
                    {
                        UserScore++;
                        Console.WriteLine("Your Choice : " + YourChoice + " and Pc Choice : " + PcChoice + " then You win the round");
                        Console.WriteLine("Your Score is : " + UserScore);
                        Console.WriteLine("PC Score is : " + PcScore);
                    }
                    else if (YourChoice == Paper && PcChoice == Scisser)
                    {
                        PcScore++;
                        Console.WriteLine("Your Choice : " + YourChoice + " and Pc Choice : " + PcChoice + " then PC win the round");
                        Console.WriteLine("Your Score is : " + UserScore);
                        Console.WriteLine("PC Score is : " + PcScore);
                    }
                    else if (YourChoice == Scisser && PcChoice == Paper)
                    {
                        UserScore++;
                        Console.WriteLine("Your Choice : " + YourChoice + " and Pc Choice : " + PcChoice + " then You win the round");
                        Console.WriteLine("Your Score is : " + UserScore);
                        Console.WriteLine("PC Score is : " + PcScore);
                    }
                    else if (YourChoice == Scisser && PcChoice == Rock)
                    {
                        PcScore++;
                        Console.WriteLine("Your Choice : " + YourChoice + " and Pc Choice : " + PcChoice + " then Pc win the round");
                        Console.WriteLine("Your Score is : " + UserScore);
                        Console.WriteLine("PC Score is : " + PcScore);
                    }

                }
                if (UserScore >= WinerScore)
                {
                    Console.WriteLine("You Win the Game");
                    Console.WriteLine("End Game");
                }
                else
                {
                    Console.WriteLine("PC Win the Game");
                    Console.WriteLine("End Game");
                }
                Console.WriteLine("Do You Want Play Again ? (Y/N) ");
                char inter = char.Parse(Console.ReadLine().ToUpper());
                if (inter == 'Y')
                {
                    RePlay = true;
                }
                else
                {
                    RePlay = false;
                    Console.WriteLine("GoodBye!");
                }
            }
        }
    }
}