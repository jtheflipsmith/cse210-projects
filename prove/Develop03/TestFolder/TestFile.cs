using System;
using System.Collections;
using System.Threading.Tasks.Dataflow;
using System.Xml;
namespace Develop03.Test
{
    class TestProgram
    {
        public static void RunTest()
        { 
            Reference reference = new Reference("John", 3, 16);

            Scripture scripture = new Scripture(reference, "God so loved the world that he gave his only begotten son that whosoever should believe in him might be saved");

            string text = scripture.GetScriptureText();

            Console.WriteLine(text);


        }
    }
}