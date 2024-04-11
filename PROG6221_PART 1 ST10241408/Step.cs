// Step class to represent steps in the recipe.
public class Step
{
    //description of step 
    public string Description { get; set; }

    //constructor to initialize the step obj with description
    public Step(string description)
    {
        Description = description;
    }
}

