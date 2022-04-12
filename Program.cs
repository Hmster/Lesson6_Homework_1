using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lesson6_Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var process in Process.GetProcesses())
            {
                Console.WriteLine($"ID:|\t{process.Id}\tNAME:|\t{process.ProcessName}");
                Console.WriteLine("_________________________________________________");
            }

            string name = string.Empty;

            while (name != "x")
            {
                Console.WriteLine("Enter name/id of process to close(Enter \"x\" to exit.)");
                name = Console.ReadLine();

                if (int.TryParse(name, out int id))
                    Lesson6.KillById(id);
                else
                    Lesson6.KillByName(name);
            }
        }
    }
}
