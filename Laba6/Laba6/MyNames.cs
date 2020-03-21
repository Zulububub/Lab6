using CommandDotNet.Attributes;
using ConsoleTables;
using System.Linq;

namespace Laba6
{
    public class MyNames
    {
        [ApplicationMetadata(Description = "List of names")]
        public void GetNames()
        {
            ConsoleTable
                .From(DataBase.Get())
                .Write();
        }
        [ApplicationMetadata(Description = "Add new name")]
        public void SetName(string v1, string v2, string v3)
        {
            string name = System.String.Join(" ", v1, v2, v3);
            DataBase.Set(name);
            System.Console.WriteLine("---------------------");
            System.Console.WriteLine("| New name is added |");
            System.Console.WriteLine("---------------------");
        }
    }
}
