// See https://aka.ms/new-console-template for more information

Console.WriteLine("Jorge Mejorada - CSE 310 Applied Programming");

// Print backstory to user
Console.WriteLine("Welcome to the Lost Treasure Island");
Console.WriteLine("You, your best friend Mike and Anna are in the middle of the sea in a mysterious island");
Console.WriteLine("In order to get back home you should find the lost treasure, so you would be back home and get a great treasure");
Console.WriteLine("The Island is full of tall trees, there are some lakes and the animal murmur is constant");
Console.WriteLine("You guys are in the middle of a mountain, do you want to go to the (1) tall trees part or to the (2) rocky part of the island");

// Prompt the user for a choice 
Console.Write("> ");
string sideMountain = Console.ReadLine();

// Ask player which side they want to go
if (sideMountain == "1")
{
    Console.WriteLine("Now you are in the middle of trees as tall you can see the top");
    Console.WriteLine("Now you look a map behind a big tree");
    Console.WriteLine("Do you want to take that map? (1) Yes or (2) No");

    // Promt the user for a choice
    Console.Write("> ");
    string mapChoice = Console.ReadLine();
    if (mapChoice == "1")
    {
        Console.WriteLine("Now you have the map in your hands and realize that will guide you to the lost treasure");
        Console.WriteLine("Now you decide to follow the instruction to find the treasure");
    }
    else if (mapChoice == "2")
    {
        Console.WriteLine("You decide not to take the map");
        Console.WriteLine("You suddenly wake up and realize everything was a dream!");
    }
    else
    {
        Console.WriteLine("Invalid choice. Please answer 1 or 2");
    }
}
else if (sideMountain == "2")
{
    Console.WriteLine("Now you are in the middle of hundreds of rock, there are some inches rocks and several feet rock size");
    Console.WriteLine("As you walk in you realize there is compass");
    Console.WriteLine("Would you like to take it? (1) Yes or (2) No");

    // Prompt the user for a choice
    Console.Write("> ");
    string compassChoice = Console.ReadLine();
    int compassint = int.Parse(compassChoice);


    // While loop for displaying message
    while (compassint == 1)
    {
        Console.WriteLine("Great!");
        break;
    }

    while (compassint == 2)
    {
        Console.WriteLine("Oh! Oh!");
        break;
    }

    if (compassChoice == "1")
    {
        Console.WriteLine("You take the compass and realize is a magic compass, is telling where to go and how to go to the lost treasure");
        Console.WriteLine("Now you follow the compass instructions and find the treasure");
        Console.WriteLine("You arrive to a giant rock that is blocking the way, in order to move the giant rorck you have to solve this operation:");
        Console.WriteLine("150 + 225 + 175 - 85");

        // Prompt the use for a choice
        Console.WriteLine("> ");
        string operationChoice = Console.ReadLine();
        int operationint = int.Parse(operationChoice);

        // Numbers
        int num1 = 150;
        int num2 = 225;
        int num3 = 175;
        int num4 = 85;

        // Function
        int result = Add(num1, num2, num3, num4);

        if (operationint == result)
        {
            Console.WriteLine("Congratulations! You hae find the treasure! You are free!");
        }
        else if (operationint != result)
        {
            Console.WriteLine("Sorry, that answer is wrong! You lose!");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please answer 1 or 2");
        }
    }
    else if (compassChoice == "2")
    {
        Console.WriteLine("You decide not to take the compass, you felt a scary feeling about it");
        Console.WriteLine("Then you start feeling scare and preassure in you ears");
        Console.WriteLine("You feel a sensation of your whole body under water and everything starts to shake");
        Console.WriteLine("Suddenly you get back to life, and realize you just have been resurected, you were drowned in the pool");
        Console.WriteLine("Was this a dream or a flash of a past or future life?");
    }
    else
    {
        Console.WriteLine("Invalid choice. Please entre 1 or 2");
    }
}
else
{
    Console.WriteLine("Invalid choice. Please answer 1 or 2");
}

// Function
static int Add(int num1, int num2, int num3, int num4)
{
    int result = num1 + num2 + num3 - num4;
    return result;
}