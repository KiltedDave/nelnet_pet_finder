using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nelnet_pet_finder
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputMessages.WelcomeScreen();
            
            var ans = OutputMessages.WannaPlay();

            while (ans == "NA")
            {
                OutputMessages.WrongAnswer();                
                ans = OutputMessages.WannaPlay();
            }

            if(ans == "Y")
            {
                ProcessPlayer.BeginProcess();
            }

            OutputMessages.ReturnAgain();
        }
    }
}
