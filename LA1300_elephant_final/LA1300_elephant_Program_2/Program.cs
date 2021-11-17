using System;
using System.IO;

namespace LA1300_elephant_Program_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string Logo1 = @"
 _                     _             _             
| |                   (_)           | |            
| |     ___ _ __ _ __  _ _ __   __ _| |_ ___  _ __ 
| |    / _ \ '__| '_ \| | '_ \ / _` | __/ _ \| '__|
| |___|  __/ |  | | | | | | | | (_| | || (_) | |   
\_____/\___|_|  |_| |_|_|_| |_|\__,_|\__\___/|_|   
                                                                                                     
";
            Console.WriteLine(Logo1);


            string pathGer = @"C:\Users\Public\textGer.csv";
            string pathEng = @"C:\Users\Public\textEng.csv";

            string textGer = File.ReadAllText(pathGer);
            string textEng = File.ReadAllText(pathEng);

            string[] wordsGer = textGer.Split("\r\n");
            string[] wordsEng = textEng.Split("\r\n");


            Console.WriteLine("Drücken Sie Enter um fortzufahren");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Zuerst ein paar Regeln.");
            Console.WriteLine("1. Schreiben Sie alle Wörter klein");
            Console.WriteLine("2. Wenn Sie [skip] eingeben wird das aktuelle Wort übersprungen.");
            Console.WriteLine("3. Wenn Sie [stop] eingeben wird das Programm beendet.");
            Console.WriteLine("Das waren die Regeln, nun Wünschen wir Ihnen viel Spass beim Lernen.");
            Console.WriteLine("(Drücken Sie eine Taste um fortzufahren.)");
            Console.ReadKey();
            Console.Clear();


            int ModePicker = UserMode();
            if (ModePicker == 1)
            {
                EngMode();
            }
            if (ModePicker == 2)
            {
                DeMode();
            }


            static int UserMode()
            {
                bool X = false;
                int Modetip = 0;
                Console.WriteLine("Wie wollen Sie lernen?");
                do
                {
                    Console.WriteLine("Wenn Sie mit Deutsch antworten wollen schreiben Sie [1].");
                    Console.WriteLine("Wenn Sie mit Englisch antworten wollen schreiben Sie [2].");
                    Console.Write("[1/2]: ");
                    try
                    {
                        Modetip = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if (Modetip == 1 || Modetip == 2)
                        {
                            X = true;
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Ihr Eingabe ist ungültig.");
                        X = false;
                    }
                } while (X == false);

                return Modetip;
            }


            static string userInput()
            {
                string Output = "";
                try
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Output = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                catch
                {
                    Console.WriteLine("*ungültige Eingabe*");
                }
                return Output;
            }

            static void DeMode()
            {
                string pathGer = @"C:\Users\Public\textGer.csv";
                string pathEng = @"C:\Users\Public\textEng.csv";

                string textGer = File.ReadAllText(pathGer);
                string textEng = File.ReadAllText(pathEng);

                string[] wordsGer = textGer.Split("\r\n");
                string[] wordsEng = textEng.Split("\r\n");

                int i = 0;

                try
                {

                    do
                    {
                        Console.WriteLine("Was bedeutet [" + wordsGer[i] + "] auf Englisch?");
                        string userIn = userInput();
                        if (userIn == wordsEng[i])
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Richtige Antwort");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                        }
                        else if (userIn == "skip")
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Die richtige Lösung lautet " + wordsEng[i]);
                            Console.Write(5);
                            System.Threading.Thread.Sleep(1000);
                            Console.Write("\b");
                            Console.Write(4);
                            System.Threading.Thread.Sleep(1000);
                            Console.Write("\b");
                            Console.Write(3);
                            System.Threading.Thread.Sleep(1000);
                            Console.Write("\b");
                            Console.Write(2);
                            System.Threading.Thread.Sleep(1000);
                            Console.Write("\b");
                            Console.Write(1);
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                        }
                        else if (userIn == "stop")
                        {
                            throw new Exception();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Clear();
                            Console.WriteLine("Falsche Antwort");
                            Console.WriteLine();
                            Console.WriteLine("Ihre Antwort war: " + userIn);
                            Console.WriteLine("Die richtige Antwort wäre: " + wordsEng[i]);
                            Console.Write(5);
                            System.Threading.Thread.Sleep(1000);
                            Console.Write("\b");
                            Console.Write(4);
                            System.Threading.Thread.Sleep(1000);
                            Console.Write("\b");
                            Console.Write(3);
                            System.Threading.Thread.Sleep(1000);
                            Console.Write("\b");
                            Console.Write(2);
                            System.Threading.Thread.Sleep(1000);
                            Console.Write("\b");
                            Console.Write(1);
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            i--;
                        }
                        i++;
                    } while (i < wordsGer.Length);
                }
                catch
                {

                }
            }

            static void EngMode()
            {
                string pathGer = @"C:\Users\Public\textGer.csv";
                string pathEng = @"C:\Users\Public\textEng.csv";

                string textGer = File.ReadAllText(pathGer);
                string textEng = File.ReadAllText(pathEng);

                string[] wordsGer = textGer.Split("\r\n");
                string[] wordsEng = textEng.Split("\r\n");

                int i = 0;

                try
                {

                    do
                    {
                        Console.WriteLine("Was bedeutet [" + wordsEng[i] + "] auf Deutsch?");
                        string userIn = userInput();
                        if (userIn == wordsGer[i])
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Richtige Antwort");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                        }
                        else if (userIn == "skip")
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Die richtige Lösung lautet " + wordsGer[i]);
                            Console.Write(5);
                            System.Threading.Thread.Sleep(1000);
                            Console.Write("\b");
                            Console.Write(4);
                            System.Threading.Thread.Sleep(1000);
                            Console.Write("\b");
                            Console.Write(3);
                            System.Threading.Thread.Sleep(1000);
                            Console.Write("\b");
                            Console.Write(2);
                            System.Threading.Thread.Sleep(1000);
                            Console.Write("\b");
                            Console.Write(1);
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                        }
                        else if (userIn == "stop")
                        {
                            throw new Exception();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Clear();
                            Console.WriteLine("Falsche Antwort");
                            Console.WriteLine();
                            Console.WriteLine("Ihre Antwort war: " + userIn);
                            Console.WriteLine("Die richtige Antwort wäre: " + wordsGer[i]);
                            Console.Write(5);
                            System.Threading.Thread.Sleep(1000);
                            Console.Write("\b");
                            Console.Write(4);
                            System.Threading.Thread.Sleep(1000);
                            Console.Write("\b");
                            Console.Write(3);
                            System.Threading.Thread.Sleep(1000);
                            Console.Write("\b");
                            Console.Write(2);
                            System.Threading.Thread.Sleep(1000);
                            Console.Write("\b");
                            Console.Write(1);
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            i--;
                        }
                        i++;
                    } while (i < wordsEng.Length);
                }
                catch
                {

                }

            }
        }
    }
}
