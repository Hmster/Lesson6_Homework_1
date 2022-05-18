using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lesson6_Homework_1
{
    internal static class Lesson6
    {
        internal static void KillById(int id)
        {
            Process Id = Process.GetProcessById(id);
            Id.Kill();
        }

        internal static void KillByName(string name)
        {
            foreach (var process in Process.GetProcessesByName(name))
            {
                process.Kill();
            }
        }
    }
}
