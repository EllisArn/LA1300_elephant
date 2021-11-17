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

Um einen StreamWriter oder einen StreamReader zu benutzen muss man `using System.IO;` benutzen. Und man muss eine variable mit dem Pfad Deklinieren und Initialisieren.
<br>
Falls man eine Textdatei haben will, würde ich anstatt `.txt` eher `.csv` benutzen, weil es ein Bisschen schneller ist.
<br>
```csharp
string pathGer = @"C:\Users\Public\deinPfad.csv";
```
