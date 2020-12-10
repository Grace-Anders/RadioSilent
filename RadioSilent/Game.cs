using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace RadioSilent
{
    class Game
    {
        Player spaceman = new Current_Player();
        Item item = new Item();

        public bool RandomMethod;
        public bool PlayerHasRelic;
        public bool getfood;
        public bool crackers;
        public bool jerky;
        public bool forbiddenberries;
        public bool bigbug;
        public bool getfuel;
        public bool leavefuel;
        public bool explore;
        public bool continue_exploring;
        public int Fuel;

        public Game()
        {
            RandomMethod = false;
            PlayerHasRelic = false;
            getfood = false;
            crackers = false;
            jerky = false;
            forbiddenberries = false;
            bigbug = false;
            getfuel = false;
            leavefuel = false;
            explore = false;
            continue_exploring = false;
            Fuel = 5;
            spaceman.PlayerStamina = 30;
            StartGame();
           
            
        }

        public void StartGame()
        {
            Clear();
            string textToEnter = "You are alone on a ship...";
            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter.Length / 2)) + "}\n", textToEnter));
            ForegroundColor = ConsoleColor.DarkGray;
            string textToEnter1 = "Tip: When you come across a line of text, like this, press any key to continue";
            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter1.Length / 2)) + "}", textToEnter1));
            ResetColor();
            ReadKey(true);
            Clear();
            string textToEnter2 = "You must find a way to survive...";
            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter2.Length / 2)) + "}", textToEnter2));
            ReadKey(true);
            Clear();
            string textToEnter3 = "Good luck...";
            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter3.Length / 2)) + "}", textToEnter3));
            ReadKey(true);
            Clear();
            string prompt = "What would you like to do first?";
            string[] options = { "Search the ship for Fuel (10 Stamina)", "Search the ship for Food (10 Stamina)" };
            ForegroundColor = ConsoleColor.DarkGray;
            string textToEnter4 = "Tip: When coming across choices, like you are about to see, use the up and down arrows to select and the Enter key to lock in you choice...";
            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter4.Length / 2)) + "}", textToEnter4));
            ResetColor();
            ReadKey(true);
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    spaceman.PlayerStamina -= 10;
                    ForegroundColor = ConsoleColor.DarkGray;
                    string textToEnter5 = "You have " + spaceman.PlayerStamina + " stamina left...";
                    Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter5.Length / 2)) + "}\n", textToEnter5));
                    ResetColor();
                    ReadKey(true);
                    GetFuel();
                    break;
                case 1:
                    spaceman.PlayerStamina -= 10;
                    ForegroundColor = ConsoleColor.DarkGray;
                    string textToEnter6 = "You have " + spaceman.PlayerStamina + " stamina left...";
                    Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter6.Length / 2)) + "}\n", textToEnter6));
                    ResetColor();
                    ReadKey(true);
                    GetFoodShip();
                    break;
            }
        }

        public void GetFuel()
        {
            Random randomfuel = new Random();

            List<Item> fuel = new List<Item>();
            fuel.Add(new Item("","",10));
            fuel.Add(new Item("","",20));
            fuel.Add(new Item("","",30));

            int i = 0;

            var randfuel = fuel.OrderBy(c => randomfuel.Next()).Select(c => c.ItemWorth).ToList();

            string textToEnter = "You found " + randfuel[i] + " gallons of Fuel...";
            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
            ReadKey(true);
            string prompt = "Do you wish to take it or leave it?";
            string[] options = { "Take (10 Stamina)", "Leave (0 Stamina)" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    if (10 == randfuel[i])
                    {
                        if(spaceman.PlayerStamina < 10) { StaminaEnding(); }
                        Fuel += 10;
                        spaceman.PlayerStamina -= 10;
                        string textToEnter1 = "You decided to take " + randfuel[i] + " gallons of fuel...";
                        Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter1.Length / 2)) + "}", textToEnter1));
                        getfuel = true;
                        ReadKey(true);
                        ForegroundColor = ConsoleColor.DarkGray;
                        string textToEnter5 = "You have " + spaceman.PlayerStamina + " stamina left...";
                        Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter5.Length / 2)) + "}\n", textToEnter5));
                        ResetColor();
                        ReadKey(true);
                        Leave();
                    }
                    if (20 == randfuel[i])
                    {
                        if (spaceman.PlayerStamina < 10) { StaminaEnding(); }
                        Fuel += 20;
                        spaceman.PlayerStamina -= 10;
                        string textToEnter2 = "You decided to take " + randfuel[i] + " gallons of fuel...";
                        Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter2.Length / 2)) + "}", textToEnter2));
                        getfuel = true;
                        ReadKey(true);
                        ForegroundColor = ConsoleColor.DarkGray;
                        string textToEnter6 = "You have " + spaceman.PlayerStamina + " stamina left...";
                        Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter6.Length / 2)) + "}\n", textToEnter6));
                        ResetColor();
                        ReadKey(true);
                        Leave();
                    }
                    if (30 == randfuel[i])
                    {
                        if (spaceman.PlayerStamina < 10) { StaminaEnding(); }
                        Fuel += 30;
                        spaceman.PlayerStamina -= 10;
                        string textToEnter3 = "You decided to take " + randfuel[i] + " gallons of fuel";
                        Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter3.Length / 2)) + "}", textToEnter3));
                        getfuel = true;
                        ReadKey(true);
                        ForegroundColor = ConsoleColor.DarkGray;
                        string textToEnter6 = "You have " + spaceman.PlayerStamina + " stamina left...";
                        Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter6.Length / 2)) + "}\n", textToEnter6));
                        ResetColor();
                        ReadKey(true);
                        Leave();
                    }
                    break;
                case 1:
                    if (spaceman.PlayerStamina < 10) { StaminaEnding(); }
                    else 
                    {
                        string textToEnter4 = "You decided to leave the fuel";
                        leavefuel = true;
                        Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter4.Length / 2)) + "}", textToEnter4));
                        ReadKey(true);
                        Leave();
                    }
                    break;
            }
        }

        public void GetFuelPlanet()
        {
            Random randomfuel = new Random();

            List<Item> fuel = new List<Item>();
            fuel.Add(new Item("", "", 10));
            fuel.Add(new Item("", "", 20));
            fuel.Add(new Item("", "", 30));

            int i = 0;

            var randfuel = fuel.OrderBy(c => randomfuel.Next()).Select(c => c.ItemWorth).ToList();

            string textToEnter = "You found " + randfuel[i] + " gallons of Fuel...";
            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
            ReadKey(true);
            string prompt = "Do you wish to take it or leave it?";
            string[] options = { "Take (10 Stamina)", "Leave (0 Stamina)" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    if (10 == randfuel[i])
                    {
                        if (spaceman.PlayerStamina < 10) { StaminaEnding(); }
                        Fuel += 10;
                        spaceman.PlayerStamina -= 10;
                        string textToEnter1 = "You decided to take " + randfuel[i] + " gallons of fuel...";
                        Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter1.Length / 2)) + "}", textToEnter1));
                        getfuel = true;
                        ReadKey(true);
                        ForegroundColor = ConsoleColor.DarkGray;
                        string textToEnter6 = "You have " + spaceman.PlayerStamina + " stamina left...";
                        Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter6.Length / 2)) + "}\n", textToEnter6));
                        ResetColor();
                        ReadKey(true);
                        ContinueExploring();
                    }
                    if (20 == randfuel[i])
                    {
                        if (spaceman.PlayerStamina < 10) { StaminaEnding(); }
                        Fuel += 20;
                        spaceman.PlayerStamina -= 10;
                        string textToEnter2 = "You decided to take " + randfuel[i] + " gallons of fuel...";
                        Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter2.Length / 2)) + "}", textToEnter2));
                        getfuel = true;
                        ReadKey(true);
                        ForegroundColor = ConsoleColor.DarkGray;
                        string textToEnter6 = "You have " + spaceman.PlayerStamina + " stamina left...";
                        Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter6.Length / 2)) + "}\n", textToEnter6));
                        ResetColor();
                        ReadKey(true);
                        ContinueExploring();
                    }
                    if (30 == randfuel[i])
                    {
                        if (spaceman.PlayerStamina < 10) { StaminaEnding(); }
                        Fuel += 30;
                        spaceman.PlayerStamina -= 10;
                        string textToEnter3 = "You decided to take " + randfuel[i] + " gallons of fuel";
                        Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter3.Length / 2)) + "}", textToEnter3));
                        getfuel = true;
                        ReadKey(true);
                        ContinueExploring();
                    }
                    break;
                case 1:
                    if (spaceman.PlayerStamina < 10) { StaminaEnding(); }
                    else
                    {
                        string textToEnter4 = "You decided to leave the fuel";
                        leavefuel = true;
                        Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter4.Length / 2)) + "}", textToEnter4));
                        ReadKey(true);
                        ContinueExploring();
                    }
                    break;
            }
        }

        public void GetFoodShip()
        {
            Random randomfood = new Random();

            List<Item> Food = new List<Item>();
            Food.Add(new Item("Crackers", "A thin, crisp biscuit",20));
            Food.Add(new Item("Jerky", "Lean trimmed meat that has been cut into strips and dried", 30));

            int i = 0;

            var item = Food.OrderBy(c => randomfood.Next()).Select(c => c.ItemName).ToList();

            string prompt = "You found " + item[i] + " do you wish to take it or leave it?";
            string[] options = { "Take (10 Stamina)", "Leave (0 Stamina)" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    if("Crackers" == item[i])
                    {
                        if (spaceman.PlayerStamina < 10) { StaminaEnding(); }
                        spaceman.PlayerStamina -= 10;
                        string textToEnter = "You took " + item[i] + "...";
                        Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
                        ReadKey(true);              
                        getfood = true;
                        crackers = true;
                        ForegroundColor = ConsoleColor.DarkGray;
                        string textToEnter6 = "You have " + spaceman.PlayerStamina + " stamina left...";
                        Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter6.Length / 2)) + "}\n", textToEnter6));
                        ResetColor();
                        ReadKey(true);
                        UseOrNot();
                    }
                    if("Jerky" == item[i])
                    {
                        if (spaceman.PlayerStamina < 10) { StaminaEnding(); }
                        spaceman.PlayerStamina -= 10;
                        string textToEnter1 = "You took " + item[i] + "...";
                        Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter1.Length / 2)) + "}", textToEnter1));
                        ReadKey(true);
                        getfood = true;
                        jerky = true;
                        ForegroundColor = ConsoleColor.DarkGray;
                        string textToEnter6 = "You have " + spaceman.PlayerStamina + " stamina left...";
                        Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter6.Length / 2)) + "}\n", textToEnter6));
                        ResetColor();
                        ReadKey(true);
                        UseOrNot();
                    }
                    break;
                case 1:
                    if (spaceman.PlayerStamina < 10) { StaminaEnding(); }
                    else
                    {
                        string textToEnter4 = "You decided to leave the " + item[i];
                        Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter4.Length / 2)) + "}", textToEnter4));
                        ReadKey(true);
                        Leave();
                    }
                    break;
            }
        }

        public void GetFoodPlanet()
        {
            Random randomfood = new Random();

            List<Item> Food = new List<Item>();
            Food.Add(new Item("Forbidden Berries", "An unknown food that looks edible", 30));
            Food.Add(new Item("Big Bug", "A large insect like creature that emits a green glow", 40));

            int i = 0;

            var item = Food.OrderBy(c => randomfood.Next()).Select(c => c.ItemName).ToList();

            string prompt = "You found " + item[i] + ", do you wish to take it or leave it?";
            string[] options = { "Take (10 Stamina)", "Leave (0 Stamina)" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    if ("Forbidden Berries" == item[i])
                    {
                        if (spaceman.PlayerStamina < 10) { StaminaEnding(); }
                        spaceman.PlayerStamina -= 10;
                        string textToEnter = "You took " + item[i] + "...";
                        Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
                        ReadKey(true);
                        spaceman.Inventory.Add(new Item("Forbidden Berries", "An unknown food that looks edible", 30));
                        getfood = true;
                        forbiddenberries = true;
                        ForegroundColor = ConsoleColor.DarkGray;
                        string textToEnter6 = "You have " + spaceman.PlayerStamina + " stamina left...";
                        Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter6.Length / 2)) + "}\n", textToEnter6));
                        ResetColor();
                        ReadKey(true);
                        ContinueExploring();
                    }
                    if ("Big Bug" == item[i])
                    {
                        if (spaceman.PlayerStamina < 10) { StaminaEnding(); }
                        spaceman.PlayerStamina -= 10;
                        string textToEnter1 = "You took " + item[i] + "...";
                        Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter1.Length / 2)) + "}", textToEnter1));
                        ReadKey(true);
                        spaceman.Inventory.Add(new Item("Big Bug", "A large insect like creature that emits a green glow", 40));
                        getfood = true;
                        bigbug = true;
                        ForegroundColor = ConsoleColor.DarkGray;
                        string textToEnter6 = "You have " + spaceman.PlayerStamina + " stamina left...";
                        Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter6.Length / 2)) + "}\n", textToEnter6));
                        ResetColor();
                        ReadKey(true);
                        ContinueExploring();
                    }
                    break;
                case 1:
                    if (spaceman.PlayerStamina < 10) { StaminaEnding(); }
                    else
                    {
                        string textToEnter4 = "You decided to leave the " + item[i];
                        Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter4.Length / 2)) + "}", textToEnter4));
                        ReadKey(true);
                        ContinueExploring();
                    }
                    break;
            }
        }

        public void UseOrNot()
        {
            string prompt = "What do you want to do with this Item?";
            string[] options = { "Use Now (0 Stamina)", "Save for Later(0 Stamina)" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    if(crackers == true)
                    {
                        string textToEnter = "You ate the crackers, your stamina is now at " + spaceman.PlayerStamina;
                        Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
                        spaceman.PlayerStamina += 20;
                        crackers = false;
                        getfood = true;
                        ReadKey(true);
                        Leave();
                        
                    }
                    if(jerky == true)
                    {
                        string textToEnter1 = "You ate the jerky, your stamina is now at " + spaceman.PlayerStamina;
                        Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter1.Length / 2)) + "}", textToEnter1));
                        spaceman.PlayerStamina += 30;
                        jerky = false;
                        getfood = true;
                        ReadKey(true);
                        Leave();
                    }
                        break;
                case 1:
                    if(crackers == true)
                    {
                        spaceman.Inventory.Add(new Item("Crackers", "A thin, crisp biscuit", 20));
                        Leave();
                    }
                    if(jerky == true)
                    {
                        spaceman.Inventory.Add(new Item("Jerky", "Lean trimmed meat that has been cut into strips and dried", 30));
                        Leave();
                    }
                    
                    break;
            }
        }

        public void LandPlanet()
        {
            bool viableplanet = false;
            
            var random = new Random();
            bool randomBool = random.Next(20) == 1;

            viableplanet = randomBool;

            if (viableplanet == true)
            {
                ViableEEnding();
            }
            if (viableplanet == false)
            {
                string prompt = "This planet is not viable what would you like to do?";
                string[] options = { "Leave (0 Stamina)", "Explore (10 Stamina)", "Check Inventory (0 Stamina)" };
                Menu mainMenu = new Menu(prompt, options);
                int selectedIndex = mainMenu.Run();

                switch (selectedIndex)
                {
                    case 0:
                        Leave();
                        break;
                    case 1:
                        spaceman.PlayerStamina -= 10;
                        ForegroundColor = ConsoleColor.DarkGray;
                        string textToEnter6 = "You have " + spaceman.PlayerStamina + " stamina left...";
                        Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter6.Length / 2)) + "}\n", textToEnter6));
                        ResetColor();
                        ReadKey(true);
                        Explore();
                        break;
                    case 2:
                        CheckInventory();
                        break;
                } 
            }
        }

        public void TravelFurther()
        {
            string prompt = "What would you like to do?";
            string[] options = { "Investigate the Object in the Distance (15 Fuel)", "Land on the Planet to the Right (10 Fuel)", "Check Inventory (0 Stamina)" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    if(Fuel < 15 && Fuel > 10)
                    {
                        string textToEnter = "You do not have enough fuel to do this, but you do have enough to land on the planet on the right...";
                        Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter.Length / 2)) + "}\n", textToEnter));
                        ReadKey(true);
                        LandPlanet();
                    }
                    if(Fuel < 10)
                    {
                        string textToEnter1 = "You no longer have enough fuel to power the ship and provide oxeygen...";
                        Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter1.Length / 2)) + "}\n", textToEnter1));
                        ReadKey(true);
                        HealthEnding();
                    }
                    else
                    {
                        Fuel -= 15;
                        ForegroundColor = ConsoleColor.DarkGray;
                        string textToEnter2 = "You have " + spaceman.PlayerStamina + " stamina left...";
                        Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter2.Length / 2)) + "}\n", textToEnter2));
                        ReadKey(true);
                        string textToEnter3 = "You have " + spaceman.PlayerStamina + " stamina left...";
                        Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter3.Length / 2)) + "}\n", textToEnter3));
                        ResetColor();
                        ReadKey(true);
                        ShuttleEnding();
                    }
                    break;
                case 1:
                    if(Fuel < 10)
                    {
                        string textToEnter4 = "You no longer have enough fuel to power the ship and provide oxeygen...";
                        Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter4.Length / 2)) + "}\n", textToEnter4));
                        ReadKey(true);
                        HealthEnding();
                    }
                    Fuel -= 10;
                    ForegroundColor = ConsoleColor.DarkGray;
                    string textToEnter5 = "You have " + spaceman.PlayerStamina + " stamina left...";
                    Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter5.Length / 2)) + "}\n", textToEnter5));
                    ReadKey(true);
                    string textToEnter6 = "You have " + spaceman.PlayerStamina + " stamina left...";
                    Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter6.Length / 2)) + "}\n", textToEnter6));
                    ResetColor();
                    ReadKey(true);
                    LandPlanet();
                    break;
                case 2:
                    CheckInventory();
                    break;
            }
        }

        public void Leave()
        {
            if (spaceman.PlayerStamina < 10) { StaminaEnding(); }
            else
            {
                if (getfood == true && getfuel == true)
                {
                    string prompt = "What would you like to do next?";
                    string[] options = { "Land on the nearest Planet (10 Fuel)", "Travel Further (15 Fuel)", "Check Inventory (0 Stamina)" };
                    Menu mainMenu = new Menu(prompt, options);
                    int selectedIndex = mainMenu.Run();

                    switch (selectedIndex)
                    {
                        case 0:
                            if (Fuel < 10)
                            {
                                string textToEnter = "You no longer have enough fuel to power the ship and provide oxeygen...";
                                Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter.Length / 2)) + "}\n", textToEnter));
                                ReadKey(true);
                                HealthEnding();
                            }
                            Fuel -= 10;
                            ForegroundColor = ConsoleColor.DarkGray;
                            string textToEnter1 = "You have " + spaceman.PlayerStamina + " stamina left...";
                            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter1.Length / 2)) + "}\n", textToEnter1));
                            ReadKey(true);
                            string textToEnter2 = "You have " + spaceman.PlayerStamina + " stamina left...";
                            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter2.Length / 2)) + "}\n", textToEnter2));
                            ResetColor();
                            ReadKey(true);
                            LandPlanet();
                            break;
                        case 1:
                            if (Fuel < 15 && Fuel > 10)
                            {
                                string textToEnter3 = "You do not have enough fuel to do this, but you do have enough to land on the planet on the right...";
                                Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter3.Length / 2)) + "}\n", textToEnter3));
                                ReadKey(true);
                                LandPlanet();
                            }
                            if (Fuel < 10)
                            {
                                string textToEnter4 = "You no longer have enough fuel to power the ship and provide oxeygen...";
                                Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter4.Length / 2)) + "}\n", textToEnter4));
                                ReadKey(true);
                                HealthEnding();
                            }
                            else
                            {
                                Fuel -= 15;
                                ForegroundColor = ConsoleColor.DarkGray;
                                string textToEnter5 = "You have " + spaceman.PlayerStamina + " stamina left...";
                                Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter5.Length / 2)) + "}\n", textToEnter5));
                                ReadKey(true);
                                string textToEnter6 = "You have " + spaceman.PlayerStamina + " stamina left...";
                                Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter6.Length / 2)) + "}\n", textToEnter6));
                                ResetColor();
                                ReadKey(true);
                                TravelFurther();
                            }
                            break;
                        case 2:
                            CheckInventory();
                            break;
                    }

                }
                if (getfuel == true && getfood == false)
                {
                    string prompt = "What would you like to do next?";
                    string[] options = { "Search Ship for Food (10 Stamina)", "Land on the nearest Planet (10 Fuel)", "Check Inventory (0 Stamina)" };
                    Menu mainMenu = new Menu(prompt, options);
                    int selectedIndex = mainMenu.Run();

                    switch (selectedIndex)
                    {
                        case 0:
                            spaceman.PlayerStamina -= 10;
                            ForegroundColor = ConsoleColor.DarkGray;
                            string textToEnter = "You have " + spaceman.PlayerStamina + " stamina left...";
                            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter.Length / 2)) + "}\n", textToEnter));
                            ResetColor();
                            ReadKey(true);
                            ForegroundColor = ConsoleColor.DarkGray;
                            string textToEnter1 = "You have " + spaceman.PlayerStamina + " stamina left...";
                            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter1.Length / 2)) + "}\n", textToEnter1));
                            ResetColor();
                            ReadKey(true);
                            GetFoodShip();
                            break;
                        case 1:
                            if (Fuel < 10)
                            {
                                string textToEnter2 = "You no longer have enough fuel to power the ship and provide oxygen...";
                                Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter2.Length / 2)) + "}\n", textToEnter2));
                                ReadKey(true);
                                HealthEnding();
                            }
                            Fuel -= 10;
                            ForegroundColor = ConsoleColor.DarkGray;
                            string textToEnter3 = "You have " + spaceman.PlayerStamina + " stamina left...";
                            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter3.Length / 2)) + "}\n", textToEnter3));
                            ReadKey(true);
                            string textToEnter4 = "You have " + spaceman.PlayerStamina + " stamina left...";
                            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter4.Length / 2)) + "}\n", textToEnter4));
                            ResetColor();
                            ReadKey(true);
                            LandPlanet();
                            break;
                        case 2:
                            CheckInventory();
                            break;
                    }
                }
                if (getfood == true && getfuel == false)
                {
                    string prompt = "What would you like to do next?";
                    string[] options = { "Search Ship for Fuel (10 Stamina)", "Land on the nearest Planet (10 Fuel)", "Check Inventory (0 Stamina)" };
                    Menu mainMenu = new Menu(prompt, options);
                    int selectedIndex = mainMenu.Run();

                    switch (selectedIndex)
                    {
                        case 0:
                            spaceman.PlayerStamina -= 10;
                            ForegroundColor = ConsoleColor.DarkGray;
                            string textToEnter = "You have " + spaceman.PlayerStamina + " stamina left...";
                            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter.Length / 2)) + "}\n", textToEnter));
                            ResetColor();
                            ReadKey(true);
                            GetFuel();
                            break;
                        case 1:
                            if (Fuel < 10)
                            {
                                string textToEnter1 = "You no longer have enough fuel to power the ship and provide oxeygen...";
                                Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter1.Length / 2)) + "}\n", textToEnter1));
                                ReadKey(true);
                                HealthEnding();
                            }
                            Fuel -= 10;
                            ForegroundColor = ConsoleColor.DarkGray;
                            string textToEnter2 = "You have " + Fuel + " fuel left...";
                            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter2.Length / 2)) + "}\n", textToEnter2));
                            ResetColor();
                            ReadKey(true);
                            LandPlanet();
                            break;
                        case 2:
                            CheckInventory();
                            break;
                    }
                }
                if (getfood == false && getfuel == false)
                {
                    string prompt = "What would you like to do next?";
                    string[] options = { "Search Ship for Fuel (10 Stamina)", "Search Ship for Food (10 Stamina)", "Check Inventory (0 Stamina)" };
                    Menu mainMenu = new Menu(prompt, options);
                    int selectedIndex = mainMenu.Run();

                    switch (selectedIndex)
                    {
                        case 0:
                            spaceman.PlayerStamina -= 10;
                            ForegroundColor = ConsoleColor.DarkGray;
                            string textToEnter = "You have " + spaceman.PlayerStamina + " stamina left...";
                            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter.Length / 2)) + "}\n", textToEnter));
                            ResetColor();
                            ReadKey(true);
                            GetFuel();
                            break;
                        case 1:
                            spaceman.PlayerStamina -= 10;
                            ForegroundColor = ConsoleColor.DarkGray;
                            string textToEnter1 = "You have " + spaceman.PlayerStamina + " stamina left...";
                            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter1.Length / 2)) + "}\n", textToEnter1));
                            ResetColor();
                            ReadKey(true);
                            GetFoodShip();
                            break;
                        case 2:
                            CheckInventory();
                            break;
                    }
                }
            }

        }

        public void Explore()
        {
            explore = true;
            string prompt = "What direction would you like to explore?";
            string[] options = { "Left (10 Stamina)", "Right (10 Stamina)", "Check Inventory (0 Stamina)" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();
            
            RandomMethod = false;

            var random = new Random();
            bool randomBool = random.Next(2) == 1;

            RandomMethod = randomBool;

            if (PlayerHasRelic == false)
            {
                switch (selectedIndex)
                {
                    case 0:
                        spaceman.PlayerStamina -= 10;
                        ForegroundColor = ConsoleColor.DarkGray;
                        string textToEnter = "You have " + spaceman.PlayerStamina + " stamina left...";
                        Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter.Length / 2)) + "}\n", textToEnter));
                        ResetColor();
                        ReadKey(true);
                        GetRelic();
                        break;
                    case 1:
                        spaceman.PlayerStamina -= 10;
                        ForegroundColor = ConsoleColor.DarkGray;
                        string textToEnter1 = "You have " + spaceman.PlayerStamina + " stamina left...";
                        Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter1.Length / 2)) + "}\n", textToEnter1));
                        ResetColor();
                        ReadKey(true);
                        if (RandomMethod == true)
                        {
                            explore = false;
                            GetFoodPlanet();
                        }
                        if (RandomMethod == false)
                        {
                            explore = false;
                            GetFuelPlanet();
                        }
                        break;
                    case 2:
                        CheckInventory();
                        break;
                }
            }
            if (PlayerHasRelic == true)
            {
                switch (selectedIndex)
                {
                    case 0:
                        spaceman.PlayerStamina -= 10;
                        GetFoodPlanet();
                        break;
                    case 1:
                        spaceman.PlayerStamina -= 10;
                        GetFuel();
                        break;
                    case 2:
                        CheckInventory();
                        break;
                }
            }
        }

        public void ContinueExploring()
        {
            continue_exploring = true;
            string prompt = "Would you like to keep searching, or leave?";
            string[] options = { "Keep Searching (0 Stamina)", "Head Back to Ship (10 Stamina)", "Check Inventory (0 Stamina)" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    continue_exploring = false;
                    KeepSearching();
                    break;
                case 1:
                    continue_exploring = false;
                    spaceman.PlayerStamina -= 10;
                    ForegroundColor = ConsoleColor.DarkGray;
                    string textToEnter = "You have " + spaceman.PlayerStamina + " stamina left...";
                    Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter.Length / 2)) + "}\n", textToEnter));
                    ResetColor();
                    ReadKey(true);
                    Leave();
                    break;
                case 2:
                    CheckInventory();
                    break;
            }

        }

        public void KeepSearching()
        {
            string prompt = "Are you certin you want to continue searching, your Oxeygen levels are extreamly low...";
            string[] options = { "Keep Searching (0 Stamina)", "Head Back to Ship (10 Stamina)", "Check Inventory (0 Stamina)" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    HealthEnding();
                    break;
                case 1:
                    spaceman.PlayerStamina -= 10;
                    ForegroundColor = ConsoleColor.DarkGray;
                    string textToEnter = "You have " + spaceman.PlayerStamina + " stamina left...";
                    Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter.Length / 2)) + "}\n", textToEnter));
                    ResetColor();
                    ReadKey(true);
                    Leave();
                    break;
                case 2:
                    CheckInventory();
                    break;
            }
        }

        public void CheckInventory()
        {
            if (spaceman.PlayerStamina < 10) { StaminaEnding(); }
            else
            {
                if (explore == true)
                {
                    bool isEmpty = !spaceman.Inventory.Any();
                    if (isEmpty)
                    {
                        Clear();
                        string textToEnter = "Your inventroy is empty...";
                        Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter.Length / 2)) + "}\n", textToEnter));
                        explore = false;
                        ReadKey(true);
                        ContinueExploring();
                    }
                    else
                    {
                        foreach (Item item in spaceman.Inventory)
                        {
                            string textToEnter = "Item: " + item.ItemName;
                            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));

                            string textToEnter1 = "Discription: " + item.ItemDescription;
                            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter1.Length / 2)) + "}", textToEnter1));

                            string textToEnter2 = "Item Worth: " + item.ItemWorth;
                            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter2.Length / 2)) + "}", textToEnter2));

                            string textToEnter3 = "   ";
                            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter3.Length / 2)) + "}", textToEnter3));
                        }

                        string prompt = "Would you like to eat the items in your inventory?";
                        string[] options = { "Yes", "No" };
                        Menu mainMenu = new Menu(prompt, options);
                        int selectedIndex = mainMenu.Run();

                        switch (selectedIndex)
                        {
                            case 0:
                                if (crackers == true)
                                {
                                    spaceman.PlayerStamina += 20;
                                    string textToEnter = "You ate the crackers, Your stamina is now at " + spaceman.PlayerStamina + "...";
                                    Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
                                    ReadKey(true);
                                    crackers = false;
                                    spaceman.Inventory.RemoveAt(0);
                                }
                                if (jerky == true)
                                {
                                    spaceman.PlayerStamina += 30;
                                    string textToEnter = "You ate the jerky, Your stamina is now at " + spaceman.PlayerStamina + "...";
                                    Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
                                    ReadKey(true);
                                    jerky = false;
                                    spaceman.Inventory.RemoveAt(0);
                                }
                                if (forbiddenberries == true)
                                {
                                    spaceman.PlayerStamina += 30;
                                    string textToEnter = "You ate the forbidden berries, Your stamina is now at " + spaceman.PlayerStamina + "...";
                                    Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
                                    ReadKey(true);
                                    forbiddenberries = false;
                                    spaceman.Inventory.RemoveAt(0);
                                }
                                if (bigbug == true)
                                {
                                    spaceman.PlayerStamina += 40;
                                    string textToEnter = "You ate the big bug, Your stamina is now at " + spaceman.PlayerStamina + "...";
                                    Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
                                    ReadKey(true);
                                    bigbug = false;
                                    spaceman.Inventory.RemoveAt(0);
                                }
                                explore = false;
                                ContinueExploring();
                                break;
                            case 1:
                                explore = false;
                                ContinueExploring();
                                break;
                        }
                    }
                }
                if (continue_exploring == true)
                {
                    bool isEmpty = !spaceman.Inventory.Any();
                    if (isEmpty)
                    {
                        Clear();
                        string textToEnter = "Your inventroy is empty...";
                        Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter.Length / 2)) + "}\n", textToEnter));
                        continue_exploring = false;
                        ReadKey(true);
                        KeepSearching();
                    }
                    else
                    {
                        foreach (Item item in spaceman.Inventory)
                        {
                            string textToEnter = "Item: " + item.ItemName;
                            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));

                            string textToEnter1 = "Discription: " + item.ItemDescription;
                            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter1.Length / 2)) + "}", textToEnter1));

                            string textToEnter2 = "Item Worth: " + item.ItemWorth;
                            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter2.Length / 2)) + "}", textToEnter2));

                            string textToEnter3 = "   ";
                            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter3.Length / 2)) + "}", textToEnter3));
                        }

                        string prompt = "Would you like to eat the items in your inventory?";
                        string[] options = { "Yes", "No" };
                        Menu mainMenu = new Menu(prompt, options);
                        int selectedIndex = mainMenu.Run();

                        switch (selectedIndex)
                        {
                            case 0:
                                if (crackers == true)
                                {
                                    spaceman.PlayerStamina += 20;
                                    string textToEnter = "You ate the crackers, Your stamina is now at " + spaceman.PlayerStamina + "...";
                                    Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
                                    ReadKey(true);
                                    crackers = false;
                                    spaceman.Inventory.RemoveAt(0);
                                }
                                if (jerky == true)
                                {
                                    spaceman.PlayerStamina += 30;
                                    string textToEnter = "You ate the jerky, Your stamina is now at " + spaceman.PlayerStamina + "...";
                                    Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
                                    ReadKey(true);
                                    jerky = false;
                                    spaceman.Inventory.RemoveAt(0);
                                }
                                if (forbiddenberries == true)
                                {
                                    spaceman.PlayerStamina += 30;
                                    string textToEnter = "You ate the forbidden berries, Your stamina is now at " + spaceman.PlayerStamina + "...";
                                    Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
                                    ReadKey(true);
                                    forbiddenberries = false;
                                    spaceman.Inventory.RemoveAt(0);
                                }
                                if (bigbug == true)
                                {
                                    spaceman.PlayerStamina += 40;
                                    string textToEnter = "You ate the big bug, Your stamina is now at " + spaceman.PlayerStamina + "...";
                                    Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
                                    ReadKey(true);
                                    bigbug = false;
                                    spaceman.Inventory.RemoveAt(0);
                                }
                                continue_exploring = false;
                                KeepSearching();
                                break;
                            case 1:
                                continue_exploring = false;
                                KeepSearching();
                                break;
                        }
                    }
                }
                else
                {
                    bool isEmpty = !spaceman.Inventory.Any();
                    if (isEmpty)
                    {
                        Clear();
                        string textToEnter = "Your inventroy is empty...";
                        Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter.Length / 2)) + "}\n", textToEnter));
                        ReadKey(true);
                        Leave();
                    }
                    else
                    {
                        foreach (Item item in spaceman.Inventory)
                        {
                            string textToEnter = "Item: " + item.ItemName;
                            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));

                            string textToEnter1 = "Discription: " + item.ItemDescription;
                            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter1.Length / 2)) + "}", textToEnter1));

                            string textToEnter2 = "Item Worth: " + item.ItemWorth;
                            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter2.Length / 2)) + "}", textToEnter2));

                            string textToEnter3 = "   ";
                            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter3.Length / 2)) + "}", textToEnter3));
                        }

                        string prompt = "Would you like to eat the items in your inventory?";
                        string[] options = { "Yes", "No" };
                        Menu mainMenu = new Menu(prompt, options);
                        int selectedIndex = mainMenu.Run();

                        switch (selectedIndex)
                        {
                            case 0:
                                if (crackers == true)
                                {
                                    spaceman.PlayerStamina += 20;
                                    string textToEnter = "You ate the crackers, Your stamina is now at " + spaceman.PlayerStamina + "...";
                                    Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
                                    ReadKey(true);
                                    crackers = false;
                                    spaceman.Inventory.RemoveAt(0);
                                }
                                if (jerky == true)
                                {
                                    spaceman.PlayerStamina += 30;
                                    string textToEnter = "You ate the jerky, Your stamina is now at " + spaceman.PlayerStamina + "...";
                                    Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
                                    ReadKey(true);
                                    jerky = false;
                                    spaceman.Inventory.RemoveAt(0);
                                }
                                if (forbiddenberries == true)
                                {
                                    spaceman.PlayerStamina += 30;
                                    string textToEnter = "You ate the forbidden berries, Your stamina is now at " + spaceman.PlayerStamina + "...";
                                    Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
                                    ReadKey(true);
                                    forbiddenberries = false;
                                    spaceman.Inventory.RemoveAt(0);
                                }
                                if (bigbug == true)
                                {
                                    spaceman.PlayerStamina += 40;
                                    string textToEnter = "You ate the big bug, Your stamina is now at " + spaceman.PlayerStamina + "...";
                                    Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
                                    ReadKey(true);
                                    bigbug = false;
                                    spaceman.Inventory.RemoveAt(0);
                                }
                                Leave();
                                break;
                            case 1:
                                Leave();
                                break;
                        }
                    }
                }

            }

        }

        public void StaminaEnding()
        {
            if (PlayerHasRelic == true)
            {
                SecretEnding();
            }
            else
            {
                Clear();
                string textToEnter = "Your are out of stamina and can no longer continue...";
                Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
                ReadKey(true);
                Clear();
                string textToEnter1 = "You are stuck here...";
                Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter1.Length / 2)) + "}", textToEnter1));
                ReadKey(true);
                Clear();
                string textToEnter2 = "Thank you for playing, you have unlocked the Stamina Ending (1/5)...";
                Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter2.Length / 2)) + "}", textToEnter2));
                ReadKey(true);

                string prompt = "You have finished Radio Silent";
                string[] options = { "Play Again", "End Game" };
                Menu mainMenu = new Menu(prompt, options);
                int selectedIndex = mainMenu.Run();

                switch (selectedIndex)
                {
                    case 0:
                        StartGame();
                        break;
                    case 1:
                        Environment.Exit(0);
                        break;
                }
            }
        }

        public void HealthEnding()
        {
            if (PlayerHasRelic == true)
            {
                SecretEnding();
            }
            else
            {
                Clear();
                string textToEnter = "Your health has hit zero...";
                Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
                ReadKey(true);
                Clear();
                string textToEnter1 = "You have died...";
                Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter1.Length / 2)) + "}", textToEnter1));
                ReadKey(true);
                Clear();
                string textToEnter2 = "Thank you for playing, you have unlocked the Health Ending (2/5)...";
                Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter2.Length / 2)) + "}", textToEnter2));
                ReadKey(true);

                string prompt = "You have finished Radio Silent";
                string[] options = { "Play Again", "End Game" };
                Menu mainMenu = new Menu(prompt, options);
                int selectedIndex = mainMenu.Run();

                switch (selectedIndex)
                {
                    case 0:
                        StartGame();
                        break;
                    case 1:
                        Environment.Exit(0);
                        break;
                }
            }
        }

        public void ShuttleEnding()
        {
            Clear();
            string textToEnter = "You found a space shuttle...";
            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
            ReadKey(true);
            Clear();
            string textToEnter1 = "You have made contact with other humans...";
            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter1.Length / 2)) + "}", textToEnter1));
            ReadKey(true);
            Clear();
            string textToEnter2 = "Thank you for playing, you have unlocked the Shuttle Ending (3/5)...";
            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter2.Length / 2)) + "}", textToEnter2));
            ReadKey(true);

            string prompt = "You have finished Radio Silent";
            string[] options = { "Play Again", "End Game" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    StartGame();
                    break;
                case 1:
                    Environment.Exit(0);
                    break;
            }

        }

        public void ViableEEnding()
        {
            Clear();
            string textToEnter = "You found a viable planet...";
            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
            ReadKey(true);
            Clear();
            string textToEnter1 = "You are safe...";
            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter1.Length / 2)) + "}", textToEnter1));
            ReadKey(true);
            Clear();
            string textToEnter2 = "Or are you...";
            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter2.Length / 2)) + "}", textToEnter2));
            ReadKey(true);
            Clear();
            string textToEnter3 = "Thank you for playing, you have unlocked the Viable Planet Ending (4/5)...";
            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter3.Length / 2)) + "}", textToEnter3));
            ReadKey(true);

            string prompt = "You have finished Radio Silent";
            string[] options = { "Play Again", "End Game" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    StartGame();
                    break;
                case 1:
                    Environment.Exit(0);
                    break;
            }
        }

        public void SecretEnding()
        {
            Clear();
            string textToEnter = "The Relic you picked up has saved you...";
            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
            ReadKey(true);
            Clear();
            string textToEnter1 = "Extraterrestrials have picked you up...";
            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter1.Length / 2)) + "}", textToEnter1));
            ReadKey(true);
            Clear();
            string textToEnter2 = "You will survive...";
            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter2.Length / 2)) + "}", textToEnter2));
            ReadKey(true);
            Clear();
            string textToEnter3 = "Thank you for playing, you have unlocked the Secret Ending (5/5)...";
            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter3.Length / 2)) + "}", textToEnter3));
            ReadKey(true);

            string prompt = "You have finished Radio Silent";
            string[] options = { "Play Again", "End Game" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    StartGame();
                    break;
                case 1:
                    Environment.Exit(0);
                    break;
            }
        }

        public void GetRelic()
        {
            Item Relic = new Item("Relic", "An unknown object that emits a purple glow", 0);

            string prompt = "Would you like to pick up the strange object?";
            string[] options = { "Yes", "No" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                PlayerHasRelic = true;
                    ContinueExploring();
                    break;
                case 1:
                PlayerHasRelic = false;
                    ContinueExploring();
                    break;
            }
        }
    }
}
    
