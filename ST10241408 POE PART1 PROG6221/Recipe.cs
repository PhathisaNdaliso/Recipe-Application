
// Recipe class to manage the recipe


public class Recipe
{
    private string recipeName;
    private List<Ingredient> ingredients;
    private List<string> steps;

    public Recipe()
    {
        ingredients = new List<Ingredient>();
        steps = new List<string>();
    }
    

// Method to add recipe name
public void AddRecipeName()
    {
        Console.Write("Enter recipe name: ");
        recipeName = Console.ReadLine();
        Console.WriteLine($"Recipe name '{recipeName}' added successfully.");
        Console.WriteLine();
    }

    // Method to add number of ingredients
    public void AddNumberOfIngredients()
    {
        Console.Write("Enter the number of ingredients: ");
        int numIngredients = int.Parse(Console.ReadLine());

        for (int i = 0; i < numIngredients; i++)
        {
            Console.Write($"Add ingredient {i + 1}: ");
            string name = Console.ReadLine();
            Console.Write($"Enter quantity for {name}: ");
            int quantity = int.Parse(Console.ReadLine());
            Console.Write($"Enter unit of measurement for {name}: ");
            string unitOfMeasurement = Console.ReadLine();

            ingredients.Add(new Ingredient(name, quantity, unitOfMeasurement));
            Console.WriteLine("Ingredient added successfully.");
            Console.WriteLine();
        }
    }

    // Method to add steps

    public void AddSteps()
    {
        Console.Write("Enter number of steps: ");
        int numSteps = int.Parse(Console.ReadLine());
        Console.WriteLine($"Steps set to \"{numSteps}\".");
        Console.WriteLine();

        for (int i = 0; i < numSteps; i++)
        {
            Console.Write($"Enter step {i + 1} details: ");
            string description = Console.ReadLine();
            steps.Add(description);
        }

        Console.WriteLine("steps captured");
        Console.WriteLine("---------------------------");
    }

    //method to display recipe 
    public void DisplayRecipe()
    {

        Console.WriteLine("---------------------------");
        Console.WriteLine($"Recipe name: {recipeName}");
        Console.WriteLine("---------------------------");
        Console.WriteLine("Number of ingredients: " + ingredients.Count);
        Console.WriteLine("*******************");
        foreach (var ingredient in ingredients)
        {
            Console.WriteLine($"Ingredient: {ingredient.Name}");
            Console.WriteLine($"Quantity: {ingredient.Quantity}");
            Console.WriteLine($"Unit of measurement: {ingredient.UnitOfMeasurement}");
            Console.WriteLine();
        }
       
        Console.WriteLine("---------------------------");
        Console.WriteLine("Steps");
        foreach (var step in steps)
        {
            Console.WriteLine($"Step: {step}");
           
        }
        Console.WriteLine("*****************");
    }

    //method to scale recipe 
    public void ScaleRecipe(double factor)
    {
        foreach (var ingredient in ingredients)
        {
            ingredient.ScaleQuantity(factor);
            Console.WriteLine($"Scaled quantity for {ingredient.Name}: {ingredient.Quantity}");
        }
        Console.WriteLine("Recipe scaled successfully!");
        Console.WriteLine("---------------------------------");
    }

    //method to reset recipe 
    public void ResetRecipe()
    {
        foreach (var ingredient in ingredients)
        {
            ingredient.ResetQuantity();
        }
        Console.WriteLine("Recipe reset successfully!");
        Console.WriteLine("--------------------------------");
    }

    //method to clear data 
    public void ClearData()
    {
        recipeName = null;
        ingredients.Clear();
        steps.Clear();
        Console.WriteLine("Data has been cleared!");
        Console.WriteLine();
    }
}
