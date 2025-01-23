// See https://aka.ms/new-console-template for more information
using Mission3me;

int userSelection = 0;
string stringSelect = "";
List<FoodItem> foodItems = new List<FoodItem>();
bool running = true;
Console.WriteLine("Welcome to the Food Bank Inventory System!");


while (running)
{
    Console.WriteLine();
    Console.WriteLine("Select which task you would like to run (enter the number):");
    Console.WriteLine("1. Add food items");
    Console.WriteLine("2. Delete food items");
    Console.WriteLine("3. Print list of current food items");
    Console.WriteLine("4. Exit the program");
    stringSelect = Console.ReadLine();
    userSelection = int.Parse(stringSelect) - 1;
    
    while (userSelection < 0 || userSelection > 3)
    {
        Console.WriteLine("Enter a number 1-4 to perform a task");
        stringSelect = Console.ReadLine();
        userSelection = int.Parse(stringSelect) - 1;
    } 


    if (userSelection == 0)
    {
        string foodName;
        string foodCategory;
        string foodQuantity;
        string foodExpDate;
        int foodNum;
        
        Console.WriteLine();
        Console.WriteLine("What is the food's name?");
        foodName = Console.ReadLine();
        Console.WriteLine("What is the food's category?");
        foodCategory = Console.ReadLine();
        Console.WriteLine("What is the food's quantity?");
        foodQuantity = Console.ReadLine();
        foodNum = int.Parse(foodQuantity);
        Console.WriteLine("What is the food's expiration date?");
        foodExpDate = Console.ReadLine();
        Console.WriteLine();

        foodItems.Add(new FoodItem(foodName, foodCategory, foodNum, foodExpDate));

    } else if (userSelection == 1)
    {
        if (foodItems.Count > 0)
        {
            int removeNum;
            string removeItem;
            Console.WriteLine();
            Console.WriteLine("Enter the number of the food item you would like to delete.");
            Console.WriteLine();
            for (int i = 0; i < foodItems.Count; i++)
            {
                Console.WriteLine((i + 1) + " - Name: " + foodItems[i].Name + " Category: " + foodItems[i].Category +
                                  " Quantity: " + foodItems[i].Quantity);
            }

            Console.WriteLine();
            removeItem = Console.ReadLine();
            removeNum = int.Parse(removeItem) - 1;
            while (removeNum < 0 || removeNum >= foodItems.Count)
            {
                Console.WriteLine("Enter a number that corresponds to a valid food item.");
                removeItem = Console.ReadLine();
                removeNum = int.Parse(removeItem) - 1;
            } 
            foodItems.RemoveAt(removeNum);
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Please add items to inventory to be able to delete.");
            Console.WriteLine();
        }
    } else if (userSelection == 2)
    {
        Console.WriteLine();
        for (int i = 0; i < foodItems.Count; i++)
        {
            
            Console.WriteLine( "Name: " + foodItems[i].Name + " Category: " + foodItems[i].Category +
                              " Quantity: " + foodItems[i].Quantity);
        }
    } else if (userSelection == 3)
    {
        running = false;
    }
}
