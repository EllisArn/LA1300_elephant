using System;
using System.Diagnostics;
using System.IO;

namespace LA1300_elephant
{
    class Program
    {
        static void readFile()
        {
            string pathGer = @"C:\Users\Public\textGer.csv";
            if (!File.Exists(pathGer))
            {

                using (StreamWriter sw = File.CreateText(pathGer))
                {
                    sw.WriteLine("ja");
                    sw.WriteLine("nein");
                    sw.WriteLine("vielleicht");
                    sw.WriteLine("bitte");
                    sw.WriteLine("danke");
                    sw.WriteLine("entschuldigung");
                    sw.WriteLine("alles klar");
                    sw.WriteLine("ich verstehe");
                    sw.WriteLine("ich verstehe nicht");
                    sw.WriteLine("sprechen sie deutsch");
                    sw.WriteLine("ich spreche kein englisch");
                    sw.WriteLine("hilfe");
                    sw.WriteLine("ein bisschen lagsamer bitte");
                    sw.WriteLine("gesundheit");
                    sw.WriteLine("prost");
                    sw.WriteLine("wo");
                    sw.WriteLine("wann");
                    sw.WriteLine("wer");
                    sw.WriteLine("warum");
                    sw.WriteLine("name");
                    sw.WriteLine("wie heissen sie");
                    sw.WriteLine("mein name ist");
                    sw.WriteLine("ich bin");
                    sw.WriteLine("es ist nett sie kennenzulernen");
                    sw.WriteLine("ich bin x jahre alt");
                    sw.WriteLine("ich komme aus");
                    sw.WriteLine("wie alt sind sie");
                    sw.WriteLine("woher kommen sie");
                    sw.WriteLine("wo arbeiten sie");
                    sw.WriteLine("was bringt sie hierher");
                    sw.WriteLine("wie war ihre reise");
                    sw.WriteLine("haben sie eine gute zeit");
                    sw.WriteLine("was halten sie von");
                    sw.WriteLine("meine freunde nennen mich");
                    sw.WriteLine("kennen wir uns");
                    sw.WriteLine("das ist");
                    sw.WriteLine("wie war ihr wochenende");
                    sw.WriteLine("hallo");
                    sw.WriteLine("guten morgen");
                    sw.WriteLine("guten tag");
                    sw.WriteLine("guten abend");
                    sw.WriteLine("gute nacht");
                    sw.WriteLine("tschüss");
                    sw.WriteLine("auf wiedersehen");
                    sw.WriteLine("wie geht es ihnen");
                    sw.WriteLine("gut");
                    sw.WriteLine("schlecht");
                    sw.WriteLine("mach's gut");
                    sw.WriteLine("wie gehts");
                    sw.WriteLine("ich hätte gerne");
                }
            }

            string pathEng = @"C:\Users\Public\textEng.csv";
            if (!File.Exists(pathEng))
            {

                using (StreamWriter sw = File.CreateText(pathEng))
                {
                    sw.WriteLine("yes");
                    sw.WriteLine("no");
                    sw.WriteLine("maybe");
                    sw.WriteLine("please");
                    sw.WriteLine("thank you");
                    sw.WriteLine("sorry");
                    sw.WriteLine("alright");
                    sw.WriteLine("i understand");
                    sw.WriteLine("i don't understand");
                    sw.WriteLine("do you speak german");
                    sw.WriteLine("i don't speak english");
                    sw.WriteLine("help");
                    sw.WriteLine("a little slower please");
                    sw.WriteLine("bless you");
                    sw.WriteLine("cheers");
                    sw.WriteLine("where");
                    sw.WriteLine("when");
                    sw.WriteLine("who");
                    sw.WriteLine("why");
                    sw.WriteLine("name");
                    sw.WriteLine("what is your name");
                    sw.WriteLine("my name is");
                    sw.WriteLine("i am");
                    sw.WriteLine("it is nice to meet you");
                    sw.WriteLine("i am x years old");
                    sw.WriteLine("i am from");
                    sw.WriteLine("how old are you");
                    sw.WriteLine("where are you from");
                    sw.WriteLine("where do you work");
                    sw.WriteLine("what brings you here");
                    sw.WriteLine("how was your trip");
                    sw.WriteLine("have a good time");
                    sw.WriteLine("what do you think about");
                    sw.WriteLine("my friends call me");
                    sw.WriteLine("have we met before");
                    sw.WriteLine("this is");
                    sw.WriteLine("how was your weekend");
                    sw.WriteLine("hello");
                    sw.WriteLine("good morning");
                    sw.WriteLine("good day");
                    sw.WriteLine("good evening");
                    sw.WriteLine("good night");
                    sw.WriteLine("goodbye");
                    sw.WriteLine("see you");
                    sw.WriteLine("how are you");
                    sw.WriteLine("good");
                    sw.WriteLine("bad");
                    sw.WriteLine("take care");
                    sw.WriteLine("how are you");
                    sw.WriteLine("i would like");


                }
            }

            string pathText = @"C:\Users\Public\text.csv";
            if (!File.Exists(pathText))
            {

                using (StreamWriter sw = File.CreateText(pathText))
                {
                }
            }
        }

        static void Main(string[] args)
        {
            String[] userText = new string[50];
            String[] engText = new string[50];
            String[] gerText = new string[50];
            String engLine;
            String gerLine;
            double score = 0;

            Console.ForegroundColor = ConsoleColor.Cyan;

            readFile();

            try
            {
                string round = "y";

                do
                {
                    StreamReader eng = new StreamReader(@"C:\Users\Public\textEng.csv");
                    StreamReader samOut = new StreamReader(@"C:\Users\Public\text.csv");
                    StreamReader ger = new StreamReader(@"C:\Users\Public\textGer.csv");


                    engLine = eng.ReadLine();

                    for (int i = 0; i < 50; i++)
                    {
                        engText[i] = engLine;
                        engLine = eng.ReadLine();
                    }


                    gerLine = ger.ReadLine();

                    for (int i = 0; i < 50; i++)
                    {
                        gerText[i] = gerLine;
                        gerLine = ger.ReadLine();
                    }

                    string logo = @"
 _                     _             _             
| |                   (_)           | |            
| |     ___ _ __ _ __  _ _ __   __ _| |_ ___  _ __ 
| |    / _ \ '__| '_ \| | '_ \ / _` | __/ _ \| '__|
| |___|  __/ |  | | | | | | | | (_| | || (_) | |   
\_____/\___|_|  |_| |_|_|_| |_|\__,_|\__\___/|_|   
                                                                                                     
";
                    Console.WriteLine(logo);
                    Console.WriteLine("Drücken Sie Enter um zu starten");
                    Console.ReadLine();
                    Stopwatch stopWatch = new Stopwatch();
                    stopWatch.Start();
                    Console.Clear();


                    Console.WriteLine("Zuerst ein paar Regeln:");
                    Console.WriteLine("1. Schreiben Sie alle Wörter klein");
                    Console.WriteLine("2. Wenn Sie [skip] eingeben wird das aktuelle Wort übersprungen.");
                    Console.WriteLine("3. Wenn Sie [stop] eingeben wird das Programm beendet.");
                    Console.WriteLine("Das waren die Regeln, nun Wünschen wir Ihnen viel Spass beim Lernen.");
                    Console.WriteLine("(Drücken Sie eine Taste um fortzufahren.)");
                    Console.ReadKey();
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Cyan;


                    Console.Clear();
                    string modePicker = UserMode();

                    if (modePicker == "2")
                    {
                        for (int i = 0; i < engText.Length; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;

                            Console.WriteLine("Geben Sie das englische Wort für [" + gerText[i] + "] ein");
                            Console.WriteLine("(Ohne Gross-/Kleinschreibung und ohne Satzzeichen)");

                            Stopwatch pointWatch = new Stopwatch();
                            pointWatch.Start();

                            Console.ForegroundColor = ConsoleColor.White;
                            userText[i] = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.Cyan;

                            if (userText[i] == engText[i])
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Richtige Antwort");
                                Console.WriteLine();
                                stopWatch.Stop();

                                TimeSpan pW = pointWatch.Elapsed;

                                string elapsedPoints = string.Format("{0:00}:{1:00}:{2:00}",
                                pW.Hours, pW.Minutes, pW.Seconds,
                                pW.Milliseconds / 10);

                                if (pW.Seconds < 3)
                                {
                                    score = score + 1;
                                }
                                else if (pW.Seconds < 8)
                                {
                                    score = score + 0.9;
                                }
                                else
                                {
                                    score = score + 0.8;
                                }


                                Console.ForegroundColor = ConsoleColor.Cyan;
                            }

                            else if (userText[i] == "skip")
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Die richtige Lösung lautet " + engText[i]);
                                Console.ForegroundColor = ConsoleColor.Cyan;
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

                            }

                            else if (userText[i] == "stop")
                            {
                                Environment.Exit(0);
                            }

                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Clear();
                                Console.WriteLine("Falsche Antwort");
                                Console.WriteLine();
                                Console.WriteLine("Ihre Antwort war: " + userText[i]);
                                Console.WriteLine("Die richtige Antwort wäre: " + engText[i]);
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
                                i--;

                            }
                        }
                    }
                    else if (modePicker == "1")
                    {
                        for (int i = 0; i < gerText.Length; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Geben Sie das deutsche Wort für [" + engText[i] + "] ein");
                            Console.WriteLine("(Ohne Gross-/Kleinschreibung und ohne Satzzeichen)");

                            Stopwatch pointWatch = new Stopwatch();
                            pointWatch.Start();

                            Console.ForegroundColor = ConsoleColor.White;
                            userText[i] = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.Cyan;

                            if (userText[i] == gerText[i])
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Richtige Antwort");
                                Console.WriteLine();
                                stopWatch.Stop();

                                TimeSpan pW = pointWatch.Elapsed;

                                string elapsedPoints = string.Format("{0:00}:{1:00}:{2:00}",
                                pW.Hours, pW.Minutes, pW.Seconds,
                                pW.Milliseconds / 10);

                                if (pW.Seconds < 3)
                                {
                                    score = score + 1;
                                }
                                else if (pW.Seconds < 8)
                                {
                                    score = score + 0.9;
                                }
                                else
                                {
                                    score = score + 0.8;
                                }
                                Console.ForegroundColor = ConsoleColor.Cyan;
                            }

                            else if (userText[i] == "skip")
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Die richtige Lösung lautet " + gerText[i]);
                                Console.ForegroundColor = ConsoleColor.Cyan;
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

                            }

                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Clear();
                                Console.WriteLine("Falsche Antwort");
                                Console.WriteLine();
                                Console.WriteLine("Ihre Antwort war: " + userText[i]);
                                Console.WriteLine("Die richtige Antwort wäre: " + gerText[i]);
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
                                i--;

                            }
                        }
                    }

                    ger.Close();
                    eng.Close();
                    samOut.Close();

                    stopWatch.Stop();

                    TimeSpan ts = stopWatch.Elapsed;

                    string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}",
                    ts.Hours, ts.Minutes, ts.Seconds,
                    ts.Milliseconds / 10);

                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Sie haben " + elapsedTime + " gebraucht");
                    Console.WriteLine("und " + score + " Punkte erreicht! Die maximale Punktzahl wäre 100 gewesen.");

                    Console.WriteLine("Wollen Sie die Übung wiederholen? [y/n]");
                    round = Console.ReadLine();

                }
                while (round == "y");

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("Drücken Sie Enter um zu beenden");
                Console.ReadLine();
            }
        }

        static string UserMode()
        {
            bool X = false;
            string Mode = "";
            do
            {
                Console.WriteLine("Wie wollen Sie lernen?");
                Console.WriteLine("Wenn Sie mit Deutsch antworten wollen schreiben Sie [1].");
                Console.WriteLine("Wenn Sie mit Englisch antworten wollen schreiben Sie [2].");
                Console.ForegroundColor = ConsoleColor.White;
                string modeTip = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Clear();
                try
                {

                    if (modeTip == "1" || modeTip == "2")
                    {
                        X = true;
                        Mode = modeTip;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ihr Eingabe ist ungültig.");
                    X = false;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
            } while (X == false);

            return Mode;
        }
    }
}
