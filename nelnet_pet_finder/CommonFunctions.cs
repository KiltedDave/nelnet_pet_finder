using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nelnet_pet_finder
{
    class CommonFunctions
    {
        public static string CleanYesNoAnswer(string ans)
        {
            if(ans == "Y" || ans == "YES")
            {
                return "Y";
            }
            else if(ans == "N" || ans == "NO")
            {
                return "N";
            }
            else
            {
                return "NA";
            }
        }
    }
}
