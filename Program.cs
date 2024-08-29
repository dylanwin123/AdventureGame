// See https://aka.ms/new-console-template for more information
using AdventureGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Program
    {
        public static void Main(string[] args)
        {
            CharacterBuild characterBuild = new CharacterBuild();
            characterBuild.SetName();
            Console.WriteLine();
            Console.WriteLine("Press enter to close ");
        }

    }
    
}

