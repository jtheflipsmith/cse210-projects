using System.Globalization;
using System.Collections.Generic;
using System.IO;
public class Journal
{
     public List<Entry> _userJournal = new List<Entry>();

     DateTime theCurrentTime = DateTime.Now;
     string dateText = theCurrentTime.ToShortDateString();

     public void DisplayList()
     {
          foreach ( i in _userJournal)
          {
               
          }
     }
     
     public void AddEntry(Entry entry)
     {
          _userJournal.Add(entry);

     }
     public static List<Entry> DisplayFile()
     {

          Console.WriteLine("Reading from file...");
          List<Entry> journal = new List<Entry>();
          string journalFile = "path.txt";
          string[] lines = System.IO.File.ReadAllLines(journalFile);

          foreach (string line in lines)
          {
               string[] parts = line.Split(",");
               
               Console.WriteLine(parts);
          }
          return journal;
     }
     public void SaveFile(string filePath)
     {
          Console.WriteLine("Saving to file...");
          
     }

     public void LoadFile()
     {

     }


     

}