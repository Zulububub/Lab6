using System.Collections.Generic;
using System.IO;

namespace Laba6
{
    public class Names
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
    }
    public class DataBase
    {
        public static List<Names> names = new List<Names>();
        public static List<Names> Get()
        {
            using (StreamReader sr = new StreamReader("c:/MSI/test.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] words = line.Split(new char[] { ' ' });
                    names.Add(new Names() { Name = words[0], Surname = words[1], PhoneNumber = words[2] });
                }
            }
            return names;
        }
        public static void Set(string item)
        {
            using(StreamWriter sw = new StreamWriter("c:/MSI/test.txt", true))
            {
                sw.WriteLine(item);
            }
        }
    }
}
