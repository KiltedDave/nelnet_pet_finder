using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nelnet_pet_finder
{
    class ProcessPlayer
    {        
        public static void BeginProcess()
        {
            List<iBasePet> petList = BasePet.InitializePetList();

            var name = OutputMessages.EnterName();
            var preferedClass = OutputMessages.PreferedPetClass();
            var preferedType = OutputMessages.PreferedPetType();

            OutputMessages.ResultsOutput(name);

            foreach(iBasePet singlePet in petList)
            {
                if(singlePet.PetClass.ToUpper() == preferedClass || singlePet.PetType.ToUpper() == preferedType)
                {
                    OutputMessages.PetMatchOutput(singlePet.PetName, true);
                }
                else
                {
                    OutputMessages.PetMatchOutput(singlePet.PetName, false);
                }
            }
        }
    }
}
