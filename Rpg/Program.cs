using System;

//variables -------------------------------------------------------------------
string? heroName;
string? heroClass;
string? captureName;
string? captureClass;
int heroPv = 10;
int enemyPv = 10;

//skills -------------------------------------------------------------------
string[] paladinSkills = new string[2];
string[] rogueSkills = new string[2];
string[] mageSkills = new string[2];

paladinSkills[0] = "Holy Light";
paladinSkills[1] = "Fire Sky";

rogueSkills[0] = "First Aid";
rogueSkills[1] = "Multilate";

mageSkills[0] = "Mana Beer";
mageSkills[1] = "Fire Ball";

//start menu -------------------------------------------------------------------
Console.WriteLine("Welcome to Nihil Battle Game!");
Console.WriteLine("Whats is your name hero?\n");
captureName = Console.ReadLine();
heroName = captureName;

Console.WriteLine("Now choose your Hero class!\n");

Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine("1 - to select Paladin.\n");
Console.ResetColor();
Console.WriteLine($"Yours skills are: {paladinSkills[0]} and {paladinSkills[1]}.\n");
Console.WriteLine($"{paladinSkills[0]}: Restore 3 hero PV.");
Console.WriteLine($"{paladinSkills[1]}: Inflict 3 damage in enemy PV.\n");

Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine("2 - to select Rogue.\n");
Console.ResetColor();
Console.WriteLine($"Yours skills are: {rogueSkills[0]} and {rogueSkills[1]}.\n");
Console.WriteLine($"{rogueSkills[0]}: Restore 2 hero PV.");
Console.WriteLine($"{rogueSkills[1]}: Inflict 4 damage in enemy PV.\n");

Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine("3 - to select Mage.\n");
Console.ResetColor();
Console.WriteLine($"Yours skills are: {mageSkills[0]} and {mageSkills[1]}.\n");
Console.WriteLine($"{mageSkills[0]}: Restore 2 hero PV.");
Console.WriteLine($"{mageSkills[1]}: Inflict 4 damage in enemy PV.\n");

bool choose = false;

do
{
    captureClass = Console.ReadLine();
    heroClass = captureClass;
    if (heroClass == "1")
    {
        heroClass = "Paladin";
        break;
    }

    else if (heroClass == "2")
    {
        heroClass = "Rogue";
        break;
    }

    else if (heroClass == "3")
    {
        heroClass = "Mage";
        break;
    }

    else
    {
        Console.WriteLine("Please, choose a valid option!\n");
        Console.WriteLine("1 - Paladin.");
        Console.WriteLine("2 - Rogue.");
        Console.WriteLine("3 - Mage.");
    }
} while (choose == false);

//battle start -------------------------------------------------------------------
if (heroClass == "Paladin")
{
    Console.WriteLine($"Ok, your name is {heroName}, and your class is {heroClass}. \n");

    Console.WriteLine("Press any key to continue...\n");
    Console.ReadKey();
    Console.WriteLine("Nice! Lests begin the battle!");
    Console.WriteLine("The monster is coming, prepare your weapons and your soul.\n");
    Console.WriteLine("Press any key to start!");
    Console.ReadKey();
    Console.Clear();

    bool heroStatus = true;
    bool enemyStatus = true;

    do
    {
        Random dice = new Random();
        Console.WriteLine("------ BATTLE ------");
        int heroRoll = dice.Next(1, 7);
        Console.WriteLine("Press any key to roll your dice!\n");
        Console.ReadKey();
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.WriteLine($"You dice rolls {heroRoll}.\n");
        Console.ResetColor();

        Console.WriteLine("Press any key to roll the ENEMY dice!\n");
        Console.ReadKey();
        int enemyRoll = dice.Next(1, 7);
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.WriteLine($"The enemy dice rolls {enemyRoll}.\n");
        Console.ResetColor();

        //hero atack
        if (heroRoll > enemyRoll)
        {
            Console.WriteLine("You Wins in the rolls!");
            if (heroRoll >= 6)
            {

                bool skill = false;
                do
                {
                    Console.WriteLine("You have a critical roll, you can use a SKILL, choose:\n");
                    Console.WriteLine($"1 - {paladinSkills[0]}");
                    Console.WriteLine($"2 - {paladinSkills[1]}");
                    string selectSkill = Console.ReadLine();

                    if (selectSkill == "1")
                    {
                        heroPv += 3;
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine("Your PV was restored in 3!");
                        Console.ResetColor();
                        skill = true;
                    }
                    else if (selectSkill == "2")
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("You Inflict 3 damage in enemy PV.");
                        Console.ResetColor();
                        enemyPv -= 3;
                        skill = true;
                    }
                } while (skill == false);

            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("You atack the enemy, inflict 2 damage on PV.");
                Console.ResetColor();
                enemyPv -= 2;
                Console.ReadKey();
            }
        }

        //draw
        else if (heroRoll == enemyRoll)
        {
            Console.WriteLine("The rolls was a draw!, lets try again!");
        }

        //enemy atack
        else
        {
            if (enemyRoll >= 6)
            {
                Console.WriteLine("The enemy win a critial roll! And atack you with a critical atack!");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("You taken 4 damage on PV.\n");
                Console.ResetColor();
                Console.WriteLine($"{heroName} scream: Oh shit...");
                heroPv -= 4;
            }
            else
            {
                Console.WriteLine("The enemy win in roll dice, and atack you!");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("You taken 2 damage on PV.");
                Console.ResetColor();
                heroPv -= 2;
            }


        }

        //PVs score
        Console.WriteLine("-------------------\n");
        Console.WriteLine($"Your PV is {heroPv}");
        Console.WriteLine($"The enemy PV is {enemyPv}\n");
        Console.WriteLine("-------------------\n");
        Console.WriteLine("Press key to continue!");
        Console.ReadKey();

        Console.Clear();


        if (heroPv <= 0)
        {
            heroStatus = false;
            break;
        }
        else if (enemyPv <= 0)
        {
            enemyStatus = false;
            break;
        }



    } while (heroStatus == true || enemyStatus == true);

    if (heroPv <= 0)
    {
        Console.WriteLine("You die! The enemy wins the battle!");
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }

    else
    {
        Console.WriteLine("You Win!");
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}

else if (heroClass == "Rogue")
{
    {
        Console.WriteLine($"Ok, your name is {heroName}, and your class is {heroClass}. \n");

        Console.WriteLine("Press any key to continue...\n");
        Console.ReadKey();
        Console.WriteLine("Nice! Lests begin the battle!");
        Console.WriteLine("The monster is coming, prepare your weapons and your soul.\n");
        Console.WriteLine("Press any key to start!");
        Console.ReadKey();
        Console.Clear();

        bool heroStatus = true;
        bool enemyStatus = true;

        do
        {
            Random dice = new Random();
            Console.WriteLine("------ BATTLE ------");
            int heroRoll = dice.Next(1, 7);
            Console.WriteLine("Press any key to roll your dice!\n");
            Console.ReadKey();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"You dice rolls {heroRoll}.\n");
            Console.ResetColor();

            Console.WriteLine("Press any key to roll the ENEMY dice!\n");
            Console.ReadKey();
            int enemyRoll = dice.Next(1, 7);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"The enemy dice rolls {enemyRoll}.\n");
            Console.ResetColor();

            //hero atack
            if (heroRoll > enemyRoll)
            {
                Console.WriteLine("You Wins in the rolls!");
                if (heroRoll >= 6)
                {

                    bool skill = false;
                    do
                    {
                        Console.WriteLine("You have a critical roll, you can use a SKILL, choose:\n");
                        Console.WriteLine($"1 - {rogueSkills[0]}");
                        Console.WriteLine($"2 - {rogueSkills[1]}");
                        string selectSkill = Console.ReadLine();

                        if (selectSkill == "1")
                        {
                            heroPv += 2;
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.WriteLine("Your PV was restored in 2!");
                            Console.ResetColor();
                            skill = true;
                        }
                        else if (selectSkill == "2")
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("You Inflict 4 damage in enemy PV.");
                            Console.ResetColor();
                            enemyPv -= 4;
                            skill = true;
                        }
                    } while (skill == false);

                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("You atack the enemy, inflict 2 damage on PV.");
                    Console.ResetColor();
                    enemyPv -= 2;
                    Console.ReadKey();
                }
            }

            //draw
            else if (heroRoll == enemyRoll)
            {
                Console.WriteLine("The rolls was a draw!, lets try again!");
            }

            //enemy atack
            else
            {
                if (enemyRoll >= 6)
                {
                    Console.WriteLine("The enemy win a critial roll! And atack you with a critical atack!");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("You taken 4 damage on PV.\n");
                    Console.ResetColor();
                    Console.WriteLine($"{heroName} scream: Oh shit...");
                    heroPv -= 4;
                }
                else
                {
                    Console.WriteLine("The enemy win in roll dice, and atack you!");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("You taken 2 damage on PV.");
                    Console.ResetColor();
                    heroPv -= 2;
                }


            }

            //PVs score
            Console.WriteLine("-------------------\n");
            Console.WriteLine($"Your PV is {heroPv}");
            Console.WriteLine($"The enemy PV is {enemyPv}\n");
            Console.WriteLine("-------------------\n");
            Console.WriteLine("Press key to continue!");
            Console.ReadKey();

            Console.Clear();


            if (heroPv <= 0)
            {
                heroStatus = false;
                break;
            }
            else if (enemyPv <= 0)
            {
                enemyStatus = false;
                break;
            }



        } while (heroStatus == true || enemyStatus == true);

        if (heroPv <= 0)
        {
            Console.WriteLine("You die! The enemy wins the battle!");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        else
        {
            Console.WriteLine("You Win!");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

else if (heroClass == "Mage")
{
    {
        Console.WriteLine($"Ok, your name is {heroName}, and your class is {heroClass}. \n");

        Console.WriteLine("Press any key to continue...\n");
        Console.ReadKey();
        Console.WriteLine("Nice! Lests begin the battle!");
        Console.WriteLine("The monster is coming, prepare your weapons and your soul.\n");
        Console.WriteLine("Press any key to start!");
        Console.ReadKey();
        Console.Clear();

        bool heroStatus = true;
        bool enemyStatus = true;

        do
        {
            Random dice = new Random();
            Console.WriteLine("------ BATTLE ------");
            int heroRoll = dice.Next(1, 7);
            Console.WriteLine("Press any key to roll your dice!\n");
            Console.ReadKey();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"You dice rolls {heroRoll}.\n");
            Console.ResetColor();

            Console.WriteLine("Press any key to roll the ENEMY dice!\n");
            Console.ReadKey();
            int enemyRoll = dice.Next(1, 7);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"The enemy dice rolls {enemyRoll}.\n");
            Console.ResetColor();

            //hero atack
            if (heroRoll > enemyRoll)
            {
                Console.WriteLine("You Wins in the rolls!");
                if (heroRoll >= 6)
                {

                    bool skill = false;
                    do
                    {
                        Console.WriteLine("You have a critical roll, you can use a SKILL, choose:\n");
                        Console.WriteLine($"1 - {mageSkills[0]}");
                        Console.WriteLine($"2 - {mageSkills[1]}");
                        string selectSkill = Console.ReadLine();

                        if (selectSkill == "1")
                        {
                            heroPv += 2;
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.WriteLine("Your PV was restored in 2!");
                            Console.ResetColor();
                            skill = true;
                        }
                        else if (selectSkill == "2")
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("You Inflict 4 damage in enemy PV.");
                            Console.ResetColor();
                            enemyPv -= 4;
                            skill = true;
                        }
                    } while (skill == false);

                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("You atack the enemy, inflict 2 damage on PV.");
                    Console.ResetColor();
                    enemyPv -= 2;
                    Console.ReadKey();
                }
            }

            //draw
            else if (heroRoll == enemyRoll)
            {
                Console.WriteLine("The rolls was a draw!, lets try again!");
            }

            //enemy atack
            else
            {
                if (enemyRoll >= 6)
                {
                    Console.WriteLine("The enemy win a critial roll! And atack you with a critical atack!");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("You taken 4 damage on PV.\n");
                    Console.ResetColor();
                    Console.WriteLine($"{heroName} scream: Oh shit...");
                    heroPv -= 4;
                }
                else
                {
                    Console.WriteLine("The enemy win in roll dice, and atack you!");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("You taken 2 damage on PV.");
                    Console.ResetColor();
                    heroPv -= 2;
                }


            }

            //PVs score
            Console.WriteLine("-------------------\n");
            Console.WriteLine($"Your PV is {heroPv}");
            Console.WriteLine($"The enemy PV is {enemyPv}\n");
            Console.WriteLine("-------------------\n");
            Console.WriteLine("Press key to continue!");
            Console.ReadKey();

            Console.Clear();


            if (heroPv <= 0)
            {
                heroStatus = false;
                break;
            }
            else if (enemyPv <= 0)
            {
                enemyStatus = false;
                break;
            }



        } while (heroStatus == true || enemyStatus == true);

        if (heroPv <= 0)
        {
            Console.WriteLine("You die! The enemy wins the battle!");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        else
        {
            Console.WriteLine("You Win!");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}












