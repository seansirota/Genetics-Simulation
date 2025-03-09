using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetics_Simulation
{
    //The main program class which contains the entry point for the application.
    static class Program
    {
        [STAThread]
        //The main method which creates and runs the configuration form.
        static void Main()
        {
            ConfigurationForm configForm = new ConfigurationForm();
            Application.Run(configForm);
        }
    }
}