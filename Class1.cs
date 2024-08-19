using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessAround
{
    public class CharacterBuild
    {
        //Intro to game. Choose name and select character.
        public void SetName()
        {
            //calls on Name method in Characters class. sets name to default. user enters name
            Characters character = new Characters();
            string? nameOfCharacter = character.Name();
            Console.WriteLine("Please Enter Name Of Character. Then Press Enter.");
            nameOfCharacter = Console.ReadLine();

            //if statement for null vaules and a joke to set standard for game breakers
            if (nameOfCharacter == null || nameOfCharacter == " " || nameOfCharacter == "")
            {
                Console.WriteLine("Really...... no name ...... try again");
                Console.WriteLine("Please Enter Name Of Character. Then Press Enter.");
                nameOfCharacter = Console.ReadLine();
                if (nameOfCharacter == null || nameOfCharacter == " " || nameOfCharacter == "")
                {
                    Console.WriteLine("And then the great adventures of ");
                    Console.Write(nameOfCharacter);
                    Console.Write("are about to begin...");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("..... you see how dumb that is.... you're dumb..... and now you're stuck with it");
                }
            }

            //name is now set to user input. final message before choosing class
            Console.Write("The great adventurer ");
            Console.Write(nameOfCharacter);
        }
    }
