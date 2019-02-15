using System.Collections.Generic;

namespace nelnet_pet_finder
{
    class ProcessPlayer
    {        
        public static void BeginProcess()
        {
            List<iBasePet> petList = BasePet.InitializePetList();

            var name = OutputMessages.EnterName();
            var preferredClass = OutputMessages.PreferredPetClass();
            var preferredType = OutputMessages.PreferredPetType();

            OutputMessages.ResultsOutput(name);

            foreach(iBasePet singlePet in petList)
            {
                if(preferredClass.Contains(singlePet.PetClass.ToUpper()) || preferredType.Contains(singlePet.PetType.ToUpper()) )
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
