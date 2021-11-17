# LA1300_elephant

Ein Vokabeltrainer geschrieben in C#


## Ziele dieses Portfolios

Der Leser soll nach diesem Portfolio verstehen, wie man Dateien mit einem Programm in C# erstellt und ausliest.


## Streamwriter und Streamreader in C#

Der SteamWriter implementiert einen TextWriter zum schreiben von Zeichen in einen Stream in einer bestimmten Codierung.
<br>
Der StreamReader implementiert einen TextReader zum lesen von Zeichen in einen Stream in einer bestimmten Codierung.
<br>
Das heisst, dass der StreamWriter eine Datei erstellen und diese auch beabeiten kann und dass der StreamReader diese dann auslesen kann.


## Anleitung

Um einen StreamWriter oder einen StreamReader zu benutzen muss man `using System.IO;` benutzen. Und man muss eine variable mit dem Pfad Deklinieren und Initialisieren. Dabei ist es wichtig, ein "@" davor zu setzen.
<br>
Falls man eine Textdatei haben will, würde ich anstatt `.txt` eher `.csv` benutzen, weil es ein Bisschen schneller ist.
<br>
```csharp
string pathGer = @"C:\Users\Public\yourPath.csv";
```

Um eine Datei zu erstellen, muss man zuerst abfragen, ob es bereits eine Datei hat. Dann kann man mit dem StreamWriter
```
if (!File.Exists(yourPath))
{
       using (StreamWriter sw = File.CreateText(yourPath))
       {
               sw.WrtiteLine("text"); 
       }
}
```



## Reflexion

Ich habe den StreamWriter und den StreamReader gewählt, weil ich es noch nicht kannte. Ich habe auch gesehen, dass man auch nicht nur Textdateien wie .txt und .csv erstellen kann, sondern auch z.B. .xlsx oder .docx. Das und dass man überhaupt Dateien so einfach erstellen kann, hat mich irgendwie fasziniert und deshalb wollte ich darüber ein Portfolio schreiben.

