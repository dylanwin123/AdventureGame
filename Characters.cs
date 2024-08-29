using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AdventureGame
{
    public class Characters
    {

        public string Name()
        {


            string? nameOfCharacter = "Loser";
            return nameOfCharacter;

        }

        public Dictionary<string, int> CharacterTraits()
        {


            Dictionary<string, int> characterTraits = new Dictionary<String, int>
            {
                {"Strength", 0 },
                {"Health", 100 },
                {"Stamina", 100 },
                {"Armor", 0 }
            };
            return characterTraits;


        }
    }
}
