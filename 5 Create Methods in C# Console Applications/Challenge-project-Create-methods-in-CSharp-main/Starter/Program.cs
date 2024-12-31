using System;

Random random = new Random();
Console.CursorVisible = false;
int height = Console.WindowHeight - 1;
int width = Console.WindowWidth - 5;
bool shouldExit = false;
bool allowNonDirectionalKeys = true;
bool allowFastMovement = true;

// Console position of the player
int playerX = 0;
int playerY = 0;

// Console position of the food
int foodX = 0;
int foodY = 0;

// Available player and food strings
string[] states = {"('-')", "(^-^)", "(X_X)"};
string[] foods = {"@@@@@", "$$$$$", "#####"};

// Current player string displayed in the Console
string player = states[0];

// Index of the current food
int food = 0;

InitializeGame();
while (!shouldExit) 
{
    if (TerminalResized()) 
    {
        shouldExit = true;
        ShowClosingMessage("Console was resized. Program exiting.");
        continue;
    }
    Move(allowNonDirectionalKeys, allowFastMovement);
}

// Returns true if the Terminal was resized 
bool TerminalResized() 
{
    return height != Console.WindowHeight - 1 || width != Console.WindowWidth - 5;
}

// Displays random food at a random location
void ShowFood() 
{
    // Update food to a random index
    food = random.Next(0, foods.Length);

    // Update food position to a random location
    foodX = random.Next(0, width - player.Length);
    foodY = random.Next(0, height - 1);

    // Display the food at the location
    Console.SetCursorPosition(foodX, foodY);
    Console.Write(foods[food]);
}

// Changes the player to match the food consumed
void ChangePlayer() 
{
    player = states[food];
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

// Temporarily stops the player from moving
void FreezePlayer() 
{
    System.Threading.Thread.Sleep(1000);
    player = states[0];
}

// Reads directional input from the Console and moves the player
void Move(bool allowNonDirectionalKeys = false, bool allowFastMovement = false) 
{
    int lastX = playerX;
    int lastY = playerY;

    switch (Console.ReadKey(true).Key) 
    {
        case ConsoleKey.UpArrow:
            playerY--;
            if (playerIsNimble()) playerY -= 2;
            break;
		case ConsoleKey.DownArrow: 
            playerY++;
            if (playerIsNimble()) playerY += 2;
            break;
		case ConsoleKey.LeftArrow:  
            playerX--; 
            if (playerIsNimble()) playerX -= 2;
            break;
		case ConsoleKey.RightArrow: 
            playerX++;
            if (playerIsNimble()) playerX += 2;
            break;
		case ConsoleKey.Escape:     
            shouldExit = true; 
            break;
        default:
            if (!allowNonDirectionalKeys)
            {
                shouldExit = true;
                ShowClosingMessage("Non directional input detected, Program exiting.");
                return;
            }
            break;
    }

    // Clear the characters at the previous position
    Console.SetCursorPosition(lastX, lastY);
    for (int i = 0; i < player.Length; i++) 
    {
        Console.Write(" ");
    }

    // Keep player position within the bounds of the Terminal window
    playerX = (playerX < 0) ? 0 : (playerX >= width ? width : playerX);
    playerY = (playerY < 0) ? 0 : (playerY >= height ? height : playerY);

    // var foodXStart = foodX;
    // var foodXEnd = foodX + foods[food].Length - 1;
    // playerX >= foodX && playerX <= foodXEnd 
    if (playerX == foodX && playerY == foodY)
    {
        ChangePlayer();
        ShowFood();
    }
    
    if (playerIsOverloaded())
        FreezePlayer();

    // Draw the player at the new location
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

// Clears the console, displays the food and player
void InitializeGame() 
{
    Console.Clear();
    ShowFood();
    Console.SetCursorPosition(0, 0);
    Console.Write(player);
}

void ShowClosingMessage(string message)
{
    Console.Clear();
    Console.WriteLine(message);
    Thread.Sleep(1500);
}

bool playerIsOverloaded() 
{
    return player == states[2];
}

bool playerIsNimble()
{
     return player == states[1] && allowFastMovement;
}