# LA1300_elephant

Ein Vokabeltrainer geschrieben in C#


## Ziele dieses Portfolios

Der Leser soll nach diesem Portfolio verstehen, wie man Dateien mit einem Programm in C# erstellt und ausliest.


## Streamwriter / Streamreader und File-Methode in C#

Der SteamWriter implementiert einen TextWriter zum schreiben von Zeichen in einen Stream in einer bestimmten Codierung.
<br>
Der StreamReader implementiert einen TextReader zum lesen von Zeichen in einen Stream in einer bestimmten Codierung.
<br>
Die File-Methode (File.Create) erstellt eine Datei an einem zuvor bestimmten Speicherort.
<br>
Das heisst, dass die File-Methode eine Datei erstellen kann, der Streamreader diese beabeiten kann und dass der StreamReader diese dann auslesen kann.


## Anleitung

Um einen StreamWriter oder einen StreamReader zu benutzen muss man `using System.IO;` benutzen. Und man muss eine variable mit dem Pfad Deklinieren und Initialisieren. Dabei ist es wichtig, ein "@" davor zu setzen.
<br>
Falls man eine Textdatei haben will, würde ich anstatt `.txt` eher `.csv` benutzen, weil es ein Bisschen schneller ist.
<br>
```csharp
string yourPath = @"C:\Users\Public\yourFile.csv";
```

Um eine Datei zu erstellen, muss man zuerst abfragen, ob es bereits eine Datei hat. Dann kann man mit dem StreamWriter (sw ist eine Variable) und mit der `File.Create();` Methode eine Datei erstellen und gleich mit `sw.WriteLine();` einen Text in diese Datei schreiben.
```
if (!File.Exists(yourPath))
{
       using (StreamWriter sw = File.CreateText(yourPath))
       {
               sw.WrtiteLine("text"); 
       }
}
```

Um eine Datei mit einem StreamReader auszulesen, muss man noch einen Streamreader erstellen, der die Datei ausliest. Danach muss man noch ein Array oder eine Liste erstellen, in der die Wörter, die der StreamReader aus der Datei ausliest, gespeichert werden.
<br> 
Da ich einen text mit 50 Zeilen habe, benutze ich eine `for`-Schleife, um alle Wörter auszulesen und einen `String` in dem das jeweilige Wort temporär gespeichert wird, um es von dort in das Array zu speichern.
```
StreamReader text = new StreamReader(@"C:\Users\Public\yourFile.csv");
String[] textArr = new string[50];
string textLine = text.ReadLine()

for (int i = 0; i < 50; i++)
{
       textArr[i] = textLine;
       textLine = text.ReadLine();
}

```

Um alle Wörter auf einmal anzuzeigen, kann man `foreach` benutzen.
```
foreach (var item in namesArray)
{
       Console.Write(item);
}
```

## Reflexion

Ich habe den StreamWriter und den StreamReader gewählt, weil ich es noch nicht kannte. Ich habe auch gesehen, dass man auch nicht nur Textdateien wie .txt und .csv erstellen kann, sondern auch z.B. .xlsx oder .docx Dateien. Auch wenn ich das noch nicht ganz geschafft hab, da ich die dateien nicht richtig öffnen kann. Das und dass man überhaupt Dateien so einfach erstellen kann, hat mich irgendwie fasziniert und deshalb wollte ich darüber ein Portfolio schreiben.

## Verifikation

Das nächste Mal werde ich es irgendwie schaffen auch andere Dateientypen, so zu erstellen, dass man sie auch richtig öffnen kann. Und ich werde meinen Code von anfang an übersichtlicher schreiben.



