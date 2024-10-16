using System.Globalization;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata.Ecma335;
public class Journal
{
     public List<Entry> _userJournal;
     public List<Entry> _freeWrite;

     public Journal()
     {
          _userJournal = new List<Entry>();
          _freeWrite = new List<Entry>();
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
          Console.Write("Text: ");
          entry._freeEntry = Console.ReadLine();
          _freeWrite.Add(entry);
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

          int listEntries = _userJournal.Count + _freeWrite.Count;

          Console.WriteLine($"Number of entries: {listEntries}");
    
          foreach (Entry entry in _userJournal)
          {
               entry.Display();
          }

          foreach (Entry entry1 in _freeWrite)
          {
               entry1.Summary();
          }
          
     }
     public void SaveFile(List<Entry> _userJournal, List<Entry> _freeWWrite,  string file)
     {    


          string fileName = Path.Combine("C:\\Users\\joshu\\cse210\\cse210-projects\\prove\\Develop02\\", $"{file}.txt");

          using (StreamWriter outputFile = new StreamWriter(fileName))
          {
               foreach (Entry entry in _userJournal)
               {
                    string entryDetails = $"{entry._dateEntry} | {entry._promptText} | {entry._userEntry}";
                    outputFile.WriteLine(entryDetails);
               }
               foreach (Entry entry in _freeWrite)
               {
                    string newEntry = $"{entry._dateEntry} | {entry._freeEntry}";
                    outputFile.WriteLine(newEntry);
               }
          }
          Console.WriteLine("Saving to file...");
          Console.WriteLine("");

          
     }

     public void LoadFile(List<Entry> _freeWrite, List<Entry> _userJournal, string file)
     {
          string root = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
          
          string fileName = Path.Combine(root, $"{file}.txt");
          
          string[] lines = System.IO.File.ReadAllLines(fileName);

          foreach (string line in lines)
          {
               string[] parts = line.Split("|");

               if (parts.Length == 3)
               {
                    Entry userEntry = new Entry()
                    {
                         _dateEntry = DateTime.Parse(parts[0].Trim()).ToString(),
                         _promptText = parts[1].Trim(),
                         _userEntry = parts[2]
                    };
                    _userJournal.Add(userEntry);
               }
               else if (parts.Length == 2)
               {
                    Entry freeEntry = new Entry()
                    {
                         _dateEntry = DateTime.Parse(parts[0].Trim()).ToString(),
                         _userEntry = parts[1].Trim()
                    };
                    _freeWrite.Add(freeEntry);
               }

               

          }
          Console.WriteLine("File Loaded Successfully.");
     }


     

}