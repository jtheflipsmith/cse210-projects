using System.Globalization;

public class Journal
{
     public List<Entry> _userJournal = new List<Entry>();
     Prompt prompt;


     public void AddEntry()
     {
          DateTime theCurrentTime = DateTime.Now;
          string dateText = theCurrentTime.ToShortDateString();
          string prompt = newPrompt;

     }
     public void DisplayFile()
     {
          string journalFile = "notes.txt";
          string[] lines = System.IO.File.ReadAllLines(journalFile);

          foreach (Entry line in lines)
          {
               string[] parts = line.Split(",");

               string _dateEntry = parts[0];
               string _promptText = parts[1];
               string _userEntry = parts[3];
               
          }
     }
     public void SaveFile()
     {
          string journalFile = "notes.txt";
          using (StreamWriter outputFile = new StreamWriter(journalFile));
   


     }

     public void LoadFile()
     {

     }


     

}