using ClubPersonnelManagerConsoleApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubPersonnelManagerConsoleApp
{
    class Program
    {

        static void Main()
        {
            Globals.User = new User();

            do
            {
                UserInput userInput = new UserInput();
                userInput.Clear();

            } while (true);

        }

    }
}