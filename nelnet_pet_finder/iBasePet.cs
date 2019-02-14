using System.Collections.Generic;

namespace nelnet_pet_finder
{
    class iBasePet
    {
        public string PetName { get; set; }
        public string PetClass { get; set; }
        public string PetType { get; set; }
    }

    class BasePet
    {
        public static List<iBasePet> InitializePetList()
        {
            List<iBasePet> petList = new List<iBasePet>
            {
                new iBasePet{ PetName = "Garfield", PetClass = "Mammal", PetType = "Cat"},
                new iBasePet{ PetName = "Odie", PetClass = "Mammal", PetType = "Dog"},
                new iBasePet{ PetName = "Peter Parker", PetClass = "Arachnid", PetType = "Spider"},
                new iBasePet{ PetName = "Kaa", PetClass = "Reptile", PetType = "Snake"},
                new iBasePet{ PetName = "Nemo", PetClass = "Fish", PetType = "Goldfish"},
                new iBasePet{ PetName = "Alpha", PetClass = "Fish", PetType = "Betta"},
                new iBasePet{ PetName = "Splinter", PetClass = "Mammal", PetType = "Rat"},
                new iBasePet{ PetName = "Coco", PetClass = "Bird", PetType = "Parrot"},
                new iBasePet{ PetName = "Tweety", PetClass = "Bird", PetType = "Canary"}
            };

            return petList;
        }
    }
}
