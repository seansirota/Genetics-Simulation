using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetics_Simulation
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ConfigurationForm configForm = new ConfigurationForm();
            Application.Run(configForm);
        }
    }
}