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
          //ADDED: free write to the options list.
          Console.WriteLine("1. Free Write");
          //These are the project required optins
          Console.WriteLine("2. Write With Prompt");
          Console.WriteLine("3. Display");
          Console.WriteLine("4. Load");
          Console.WriteLine("5. Save");
          Console.WriteLine("6. Quit");

     }

     //ADDED: Method for letting user user free form in their journal entry.
     public void FreeEntry(Entry entry)
     {
          string[] date = DateTime.Today.ToString().Split(" ");
          entry._dateEntry = date[0];
          //ADDED Text option without prompt.
          Console.Write("");
          entry._freeEntry = Console.ReadLine();
          _userJournal.Add(entry);
     }
     
     public void PromptEntry(Entry newEntry)
     {
          
          string[] date = DateTime.Today.ToString().Split(" ");
          newEntry._dateEntry = date[0];
          
          Prompt prompt = new Prompt();
          newEntry._promptText = prompt.GetRandomPrompt();
          Console.WriteLine($"{newEntry._promptText}");
          
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
               entry.Summary();
               entry.Display();
          }
          
     }
     public void SaveFile(List<Entry> _userJournal, string file)
     {    

          Console.WriteLine("Saving to file...");

          string fileName = $"{file}.txt";

          using (StreamWriter outputFile = new StreamWriter(fileName))
          {
               foreach (Entry entry in _userJournal)
               {
                    string entryDetails = $"{entry._dateEntry} | {entry._promptText} | {entry._userEntry}";
                    outputFile.WriteLine(entryDetails);
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