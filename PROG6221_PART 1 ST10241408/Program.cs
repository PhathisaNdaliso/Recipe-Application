using System;
// Entry point of the Recipe Application
//welcome message 

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("--------------------------------------");
Console.WriteLine("Welcome to Recipe Application");
Console.WriteLine("--------------------------------------");
Console.ResetColor();
Console.WriteLine();

// Object of the recipe class
Recipe recipe = new Recipe();

// Main loop for the console menu
int exit = -1;
while (exit != 0)
{
    // Show available options to the user and get their choice
    int chosenOption = ShowOptions();

    // Perform actions based on user's choice
    switch (chosenOption)
    {
        //case will allow user to add recipe details at once 
        case 1:
            recipe.AddRecipeName();
            recipe.AddNumberOfIngredients();
            recipe.AddSteps();
            break;
        case 2:
            //case to display the recipe 
            recipe.DisplayRecipe();
            break;
        case 3:
            //case will scale the ingredient quantity 
            Console.WriteLine("Would you like to scale the recipe (yes) y or (no) n?");
            string scaleChoice = Console.ReadLine();
            if (scaleChoice.ToLower() == "y" || scaleChoice.ToLower() == "yes")
            {
                Console.WriteLine("What factor would you like to scale the recipe in : 0.5(half) ,2(double),3(triple)?");
                double factor = double.Parse(Console.ReadLine());
                recipe.ScaleRecipe(factor);
            }
            else if (scaleChoice.ToLower() == "n" || scaleChoice.ToLower() == "no")
            {
                Console.WriteLine("Recipe not reset.");
            }
            break;
        case 4:
            //case will reset the ingredient quantity back to its original quantity 
            Console.WriteLine("Would you like to reset your recipe (yes) y or (no) n?");
            string resetChoice = Console.ReadLine();
            if (resetChoice.ToLower() == "y" || resetChoice.ToLower() == "yes")
            {
                recipe.ResetRecipe();

            }
            else if (resetChoice.ToLower() == "n" || resetChoice.ToLower() == "no")
            {
                Console.WriteLine("Recipe not reset.");
            }
            break;
        case 5:
            //case will clear recipe data
            recipe.ClearData();
            break;
        case 6:
            //case will allow user to click any key to exit the application
            exit = 0;
            Console.WriteLine("Exiting Recipe Application...");
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }


    //option menu that will be displayed to the user 

    int ShowOptions()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("Options:");
        Console.WriteLine("1. Add Recipe");
        Console.WriteLine("2. Display Recipe");
        Console.WriteLine("3. Scale Recipe");
        Console.WriteLine("4. Reset Recipe");
        Console.WriteLine("5. Clear Data");
        Console.WriteLine("6. Exit Application");
        Console.Write("Enter your choice: ");
        Console.ResetColor();
        return int.Parse(Console.ReadLine());

    }

}





