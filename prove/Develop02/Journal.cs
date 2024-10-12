using System.Globalization;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata.Ecma335;
public class Journal
{
     public List<Entry> _userJournal;

     public Journal()
     {
          _userJournal = new List<Entry>();
     }
 
     public void DisplayList()
     {
          Console.WriteLine("1. Write");
          Console.WriteLine("2. Display");
          Console.WriteLine("3. Load");
          Console.WriteLine("4. Save");
          Console.WriteLine("5. Quit");

     }
     
     public void AddEntry(Entry newEntry)
     {
          //Adding date
          string[] date = DateTime.Today.ToString().Split(" ");
          newEntry._dateEntry = date[0];
          //Adding prompt
          Prompt prompt = new Prompt();
          newEntry._promptText = prompt.GetRandomPrompt();
          Console.WriteLine($"{newEntry._promptText}");
          //Adding entry
          Console.Write("");
          newEntry._userEntry = Console.ReadLine();

          _userJournal.Add(newEntry);
     }
     public void DisplayAll()
     {

          Console.WriteLine("Accessing entries...");

          int listEntries = _userJournal.Count;

          Console.WriteLine($"Number of entries: {listEntries}");
    
          foreach (Entry entry in _userJournal)
          {
               entry.Display();
          }
          
     }
     public void SaveFile( string file)
     {    

          Console.WriteLine("Saving to file...");

          string fileName = $"{file}.txt";

          using (StreamWriter outputFile = new StreamWriter(fileName))
          {
               foreach (Entry entry in _userJournal)
               {
                    outputFile.WriteLine($"{entry._dateEntry} | {entry._promptText} | {entry._userEntry}");
               }
          }
          Console.WriteLine("");
          
     }

     public void LoadFile(string file)
     {

          
          string[] lines = System.IO.File.ReadAllLines(file);

          foreach (string line in lines)
          {
               string[] parts = line.Split(",");
          }
     }


     

}