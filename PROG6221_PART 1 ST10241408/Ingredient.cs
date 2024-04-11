// Ingredient class to represent ingredients in the recipe.
public class Ingredient
{
    public string Name { get; set; }
    public int Quantity { get; set; }

    // Original quantity of the ingredient
    private int originalQuantity;

    public string UnitOfMeasurement { get; set; }

    public Ingredient(string name, int quantity, string unitOfMeasurement)
    {
        Name = name;
        Quantity = quantity;
        UnitOfMeasurement = unitOfMeasurement;
        originalQuantity = quantity; // Store the original quantity
    }

    public void ScaleQuantity(double factor)
    {
        Quantity = (int)(Quantity * factor);
    }
    public void ResetQuantity()
    {
        Quantity = originalQuantity;
    }

}

