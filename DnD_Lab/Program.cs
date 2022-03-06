using System;

namespace CIS3025_Lab2_DnD
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            System.Random randNumGen = new Random();
            char rollOrKeep = 'r';
            string charLabel = "";
            string[] attributeLabels = new string[6] { "STR", "DEX", "CON", "INT", "WIS", "CHA" };
            int[] attributes = new int[6];
            while (rollOrKeep != 'k')
            {
                for (int attr = 0; attr < attributes.Length; attr++)
                {
                    int[] dice = new int[4];
                    for (int die = 0; die < dice.Length; die++)
                    {
                        dice[die] = randNumGen.Next(0, 6) + 1;
                    }
                    System.Array.Sort(dice);
                    attributes[attr] = dice[1] + dice[2] + dice[3];
                }
                System.Console.WriteLine("Randomly Generated Scores: ");
                System.Console.WriteLine("  STR: " + "{0,2}", attributes[0]);
                System.Console.WriteLine("  DEX: " + "{0,2}", attributes[1]);
                System.Console.WriteLine("  CON: " + "{0,2}", attributes[2]);
                System.Console.WriteLine("  INT: " + "{0,2}", attributes[3]);
                System.Console.WriteLine("  WIS: " + "{0,2}", attributes[4]);
                System.Console.WriteLine("  CHA: " + "{0,2}", attributes[5]);
                System.Console.WriteLine();
                System.Console.Write("Do you want to (k)eep or (r)eroll? ");
                rollOrKeep = (System.Console.ReadLine()).ToCharArray()[0];
                System.Console.WriteLine("\n\n====================================");
            }
            char raceSelect = '0';
            System.Console.WriteLine("  1 - Dragonborn");
            System.Console.WriteLine("  2 - Dwarf");
            System.Console.WriteLine("  3 - Elf");
            System.Console.WriteLine("  4 - Gnome");
            System.Console.WriteLine("  5 - Half-Elf");
            System.Console.WriteLine("  6 - Half-Orc");
            System.Console.WriteLine("  7 - Halfling");
            System.Console.WriteLine("  8 - Human");
            System.Console.WriteLine("  9 - Tiefling");
            System.Console.WriteLine();
            System.Console.Write("  Select a race: ");
            while (raceSelect < '1' || raceSelect > '9')
            {
                raceSelect = (System.Console.ReadLine()).ToCharArray()[0];

            }
            System.Console.WriteLine("\n\n====================================");

            char subraceSelect = '0';
            char statChoice = '0';
            char secondStatChoice = '0';
            /* SUBRACE SELECTION */

            if (raceSelect == '2')
            {
                System.Console.WriteLine("Regardless of your choice you'll have to start digging immediately. ");
                System.Console.WriteLine("  1 - Hill Dwarf");
                System.Console.WriteLine("  2 - Mountain Dwarf");
                System.Console.WriteLine();
                System.Console.Write("Select a sub-race: ");
                while (subraceSelect < '1' || subraceSelect > '2')
                {
                    subraceSelect = (System.Console.ReadLine()).ToCharArray()[0];

                }
                System.Console.WriteLine("\n\n====================================");
            }

            if (raceSelect == '3')
            {
                System.Console.WriteLine("Let me guess, no matter which you pick you'll be very beautiful and graceful like Legolas or something? ");
                System.Console.WriteLine("  1 - High Elf");
                System.Console.WriteLine("  2 - Wood Elf");
                System.Console.WriteLine("  3 - Dark Elf (Drow)");
                System.Console.WriteLine();
                System.Console.Write("Select a sub-race: ");
                while (subraceSelect < '1' || subraceSelect > '3')
                {
                    subraceSelect = (System.Console.ReadLine()).ToCharArray()[0];

                }
                System.Console.WriteLine("\n\n====================================");
            }


            if (raceSelect == '4')
            {
                System.Console.WriteLine("Do you want your Gnome to be hard, deep or from a forest? ");
                System.Console.WriteLine("  1 - Forest Gnome");
                System.Console.WriteLine("  2 - Hard Gnome");
                System.Console.WriteLine("  3 - Deep Gnome (Svirfneblin)");
                System.Console.WriteLine();
                System.Console.Write("Select a sub-race: ");
                while (subraceSelect < '1' || subraceSelect > '3')
                {
                    subraceSelect = (System.Console.ReadLine()).ToCharArray()[0];

                }
                System.Console.WriteLine("\n\n====================================");
            }

            if (raceSelect == '5')
            {

                System.Console.WriteLine("  1 - Strength (STR)");
                System.Console.WriteLine("  2 - Dexterity (DEX)");
                System.Console.WriteLine("  3 - Constitution (CON)");
                System.Console.WriteLine("  4 - Intelligence (INT)");
                System.Console.WriteLine("  5 - Wisdom (WIS)");
                System.Console.WriteLine();
                System.Console.Write("Select an attribute to increase: ");
                while (statChoice < '1' || statChoice > '5')
                {
                    statChoice = (System.Console.ReadLine()).ToCharArray()[0];

                }
                System.Console.WriteLine("\n\n====================================");
                if (statChoice != '1')
                {
                    System.Console.WriteLine("  1 - Strength (STR)");
                }
                else
                {
                    System.Console.WriteLine();
                }
                if (statChoice != '2')
                {
                    System.Console.WriteLine("  2 - Dexterity (DEX)");
                }
                else
                {
                    System.Console.WriteLine();
                }
                if (statChoice != '3')
                {
                    System.Console.WriteLine("  3 - Constitution (CON)");
                }
                else
                {
                    System.Console.WriteLine();
                }
                if (statChoice != '4')
                {
                    System.Console.WriteLine("  4 - Intelligence (INT)");
                }
                else
                {
                    System.Console.WriteLine();
                }
                if (statChoice != '5')
                {
                    System.Console.WriteLine("  5 - Wisdom (WIS)");
                }
                System.Console.WriteLine();
                System.Console.Write("Select a second attribute to increase: ");
                while (secondStatChoice < '1' || secondStatChoice > '5' || secondStatChoice == statChoice)
                {
                    secondStatChoice = (System.Console.ReadLine()).ToCharArray()[0];

                }
                System.Console.WriteLine("\n\n====================================");
            }

            if (raceSelect == '7')
            {
                System.Console.WriteLine("but why tho?");

                System.Console.WriteLine("  1 - Tiny Dancer");
                System.Console.WriteLine("  2 - Stout");
                System.Console.WriteLine();
                System.Console.Write("Select a sub-race: ");
                while (subraceSelect < '1' || subraceSelect > '2')
                {
                    subraceSelect = (System.Console.ReadLine()).ToCharArray()[0];

                }
                System.Console.WriteLine("\n\n====================================");
            }

            if (raceSelect == '9')
            {
                System.Console.WriteLine("  1 - Dexterity (DEX)");
                System.Console.WriteLine("  2 - Charisma (CHA)");
                System.Console.WriteLine();
                System.Console.Write("Select an attribute to increase: ");
                while (statChoice < '1' || statChoice > '2')
                {
                    statChoice = (System.Console.ReadLine()).ToCharArray()[0];

                }
                System.Console.WriteLine("\n\n====================================");
            }


            int[] racialModifiers = new int[6] { 0, 0, 0, 0, 0, 0 };
            if (raceSelect == '1')
            {
                System.Console.WriteLine("Fair Warning, DnD and Skyrim are very different. You aren't the chosen one, you're just a lizard man. ");
                charLabel = "Dragonborn";
                racialModifiers = new int[6] { 2, 0, 0, 0, 0, 1 };
            }
            else if (raceSelect == '2')
            {
                racialModifiers = new int[6] { 0, 0, 2, 0, 0, 0 };
                if (subraceSelect == '1')
                {
                    charLabel = "Hill Dwarf";
                    racialModifiers[4] += 1;
                }
                else
                {
                    charLabel = "Mountain Dwarf";
                    racialModifiers[0] += 2;
                }
            }
            else if (raceSelect == '3')
            {
                racialModifiers = new int[6] { 0, 2, 0, 0, 0, 0 };
                if (subraceSelect == '1')
                {
                    charLabel = "High Elf";
                    racialModifiers[3] += 1;
                }
                else if (subraceSelect == '2')
                {
                    charLabel = "Wood Elf";
                    racialModifiers[4] += 1;
                }
                else
                {
                    charLabel = "Dark Elf (Drow)";
                    racialModifiers[5] += 1;
                }
            }
            else if (raceSelect == '4')
            {
                racialModifiers = new int[6] { 0, 0, 0, 2, 0, 0 };
                if (subraceSelect == '1')
                {
                    charLabel = "Forest Gnome";
                    racialModifiers[1] += 1;
                }
                else if (subraceSelect == '2')
                {
                    charLabel = "Hard Gnome";
                    racialModifiers[2] += 1;
                }
                else
                {
                    charLabel = "Deep Gnome (Svirfneblin)";
                    racialModifiers[1] += 1;
                }
            }
            else if (raceSelect == '5')
            {
                charLabel = "Half-Elf";
                racialModifiers = new int[6] { 0, 0, 0, 0, 0, 2 };
                racialModifiers[statChoice - '1'] += 1;
                racialModifiers[secondStatChoice - '1'] += 1;
            }
            else if (raceSelect == '6')
            {
                charLabel = "Half-Orc";
                racialModifiers = new int[6] { 2, 0, 1, 0, 0, 0 };
            }
            else if (raceSelect == '7')
            {
                racialModifiers = new int[6] { 0, 2, 0, 0, 0, 0 };
                if (subraceSelect == '1')
                {
                    charLabel = "Tiny Dancer Halfling";
                    racialModifiers[5] += 1;
                }
                else
                {
                    charLabel = "Stout Halfling";
                    racialModifiers[2] += 1;
                }
            }
            else if (raceSelect == '8')
            {
                System.Console.WriteLine("Daring today aren't we? ");
                charLabel = "Human";
                racialModifiers = new int[6] { 1, 1, 1, 1, 1, 1 };
            }
            else if (raceSelect == '9')
            {
                racialModifiers = new int[6] { 0, 0, 0, 1, 0, 0 };
                if (statChoice == '1')
                {
                    racialModifiers[1] += 2;
                }
                else
                {
                    racialModifiers[5] += 2;
                }
            }

            System.Console.WriteLine($"{charLabel}\n");
            for (int row = 0; row < attributes.Length; row++)
            {
                System.Console.WriteLine($"{attributeLabels[row]}: {(attributes[row] + racialModifiers[row]),2} = {attributes[row],2} + {racialModifiers[row],2}");
            }

            System.Console.WriteLine("\n====================================");
        }
    }
}

