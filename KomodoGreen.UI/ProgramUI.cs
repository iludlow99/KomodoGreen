using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KomdoGreen.BLL;

namespace KomodoGreen.UI
{
    class ProgramUI
    {
        private readonly IConsole _console;
        public SearchEngine SearchEngine;

        public ProgramUI(IConsole consoleForAllReadsAndWrites)
        {
            _console = consoleForAllReadsAndWrites;
            SearchEngine = new SearchEngine();
        }

        public void Run()
        {
            bool isRunning = true;

            while (isRunning)
            {
                _console.Write("Command (addCar, listCars, search, or deleteCar): ");
                var command = _console.ReadLine().ToLower();

                if (String.IsNullOrWhiteSpace(command))
                {
                    isRunning = false;
                }
                else if (command == "addCar")
                {
                    AddLink();
                }
                else if (command == "listCars")
                {
                    ListLinks();
                }
                else if (command == "search")
                {
                    Search();
                }
                else if (command == "deleteCar")
                {
                    Financials();
                }

                //SearchEngine.PrintTheList();

                //!Leave this at the bottom for spacing reasons!
                _console.WriteLine();
            }
        }
    }
}
