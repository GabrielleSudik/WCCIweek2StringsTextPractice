using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCCIweek2StringsTextPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //some ways of stringing strings
            //ie -- concatenation
            string greet = "Hello, ";
            string name = "reader.";
            string result = string.Concat(greet, name);
            Console.WriteLine(result);

            string result2 = greet + name;
            Console.WriteLine(result2);

            //upper and lower case stuff

            string text = "All KINDS of LeTTerS";
            Console.WriteLine(text.ToLower());
            Console.WriteLine(text.ToUpper());

            string text2 = text.ToLower();
            Console.WriteLine(text2);
            string text3 = text.ToUpper();
            Console.WriteLine(text3);

            //search for a string within a string

            string book = "Introduction to C# book";
            int index = book.IndexOf("C#");
            //that looks for position of the "C"
            Console.WriteLine($"Position of index = {index}.");

            string title = "C# Programming Course";
            int index2 = title.IndexOf("C#"); //gives index 0
            index2 = title.IndexOf("ram"); //gives index 7
            index2 = title.IndexOf("COURSE"); //gives -1 because that word doesn't exist here (capitalized)


            //extract part of a string

            string path = "C:\\Pics\\CoolPic.jpg";
            string fileName = path.Substring(8, 7);
                //that took 7 letters starting from 8th position
            Console.WriteLine(fileName);

            int index3 = path.LastIndexOf("\\");
                //looks for last instance of \\ in the string
            string fullName = path.Substring(index3 + 1);
            Console.WriteLine(fullName);

            //replacing a substring

            string doc = "Hello, gob@gmail.com. Do you wish to use gob@gmail.com as your user name?";
            Console.WriteLine(doc);
            string fixedDoc = doc.Replace("gob@gmail.com", "gab@gmail.com");
            Console.WriteLine(fixedDoc);

            //regular expressions and replacing:
            //like say you want to replace a bunch of phone numbers with ****

            string doc2 = "Smith: 0898880022\nFrank: 0888445566\nSteve: 0887654321";
            Console.WriteLine(doc2);
            //string replacedDoc2 = Regex.Replace(doc, "(08)[0-9]{8}", "$1********");
                //note commented out because you need some System.Text. loaded
            //Console.WriteLine(replacedDoc2);
            //how that worked: looked for the pattern of starting with "08" (08)
            //and followed by exactly 8 digits {8} and having
            //characters of 0-9 [0-9]

            //trim

            string gabName = "     Gabrielle     !!   ";
            Console.WriteLine(gabName);
            char[] trimChars = new char[] { '!' };
            string reduced = gabName.Trim(trimChars);
            Console.WriteLine(reduced);

            string reduced2 = gabName.TrimStart();
            string reduced3 = gabName.TrimStart(trimChars);
            Console.WriteLine(reduced2);
            Console.WriteLine(reduced3);
            //hmm they didn't all print as expected

            //something not to do because it uses too much memory:
            //the example counts from 0 to 200,000
            //up to the 1024th spot.

            //Console.WriteLine(DateTime.Now);

            //string collector = "Numbers: ";
            //for (int index4 = 1; index4 <= 200000; index4++)
            //{
            //    collector += index4;
            //}

            //Console.WriteLine(collector.Substring(0, 1024));

            //Console.WriteLine(DateTime.Now);

            //well that didn't work lol.
            //eh, you learned DateTime.Now
            //note it's a variable type:

            DateTime currentDate = DateTime.Now;
            Console.WriteLine(currentDate);
            Console.WriteLine(currentDate.ToString());

            //parsing data (ie converting from one type to another)

            string text5 = "52";
            Console.WriteLine(text5);
            int text5Value = int.Parse(text5);
            Console.WriteLine(text5Value + 3);

            string text6 = "True";
            Console.WriteLine(text6);
            bool text6BoolValue = bool.Parse(text6);
            Console.WriteLine(text6);

            string text7 = "08/08/1974";
            Console.WriteLine(text7);
            DateTime parsedDate = DateTime.Parse(text7);
            Console.WriteLine(parsedDate);

            Console.ReadLine();
        }
    }
}
