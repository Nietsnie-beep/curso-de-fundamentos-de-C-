string[] userNames = new string[10] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "" };
int arrayCurrentIndex = 9;
bool userType;

Console.WriteLine("Welcome to the best restaurant in the world!");
while (arrayCurrentIndex < 10) //true
{
    //if (arrayCurrentIndex == 10)
    //{
    //    Console.WriteLine("The restaurant is full, try again next year \n these are the guests to the dinner");
    //    int auxIndex = 0;
    //    foreach (String element in userNames)
    //    {
    //        Console.WriteLine($"user number {auxIndex + 1} and user name: {userNames[auxIndex]}");
    //        auxIndex++;
    //    }
    //    Environment.Exit(0);
    //}

        Console.WriteLine("\n \n Are you a registered user? Write true, or write false to register");
    userType = userNames.Contains(Console.ReadLine());
    Console.WriteLine(userType);

    if (userType)
    {  
         Console.WriteLine("Hello, you are a registered user, please enter your exact user name");
        string userToSearch = Console.ReadLine();
        Console.WriteLine("The user you searched is  {0}", userToSearch);
        int index = Array.IndexOf(userNames, userToSearch);
        if (index == -1)
        {
            Console.WriteLine("User not found, try again or register");
        }
        else
        {
            Console.WriteLine("welcome {0}, it's a pleasure to give you food", userNames[index]);
        }
    }
    else if (userType == false) {
        Console.WriteLine("Please write and remember your user Name");
        userNames[arrayCurrentIndex] = Console.ReadLine();
        Console.WriteLine("Your User Has been saved successfully \n" + "Your Use name is> {0}", userNames[arrayCurrentIndex]);
        arrayCurrentIndex++;
    }
}

Console.WriteLine("The restaurant is full, try again next year \n these are the guests to the dinner");
int auxIndex = 0;
foreach (String element in userNames)
{
    Console.WriteLine($"user number {auxIndex + 1} and user name: {userNames[auxIndex]}");
    auxIndex++;
}
Environment.Exit(0);


