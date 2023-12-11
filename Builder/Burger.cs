namespace Builder;

public class Burger
{
    public string Name { get; set; } = null!;
    public bool Cutlet { get; set; }
    public bool Cheese { get; set; }
    public bool Onions { get; set; }
    public bool Bacon { get; set; }
    public bool Tomatoes { get; set; }
    public bool Lettuce { get; set; }
    public bool Pickles { get; set; }
    public bool Egg { get; set; }
    public bool Mushrooms { get; set; }
    public bool Chili { get; set; }
    public bool Jalapeno { get; set; }

    public override string ToString()
    {
        var spicy = Chili || Jalapeno ? "\n   Hot spicy!" : "";

        return string.Format("Burger '{0}'\n   calories: {1}\n   ingredients: {2}{3}\nHave a nice meal!",
            Name, CalculateCalories(), GetIngredients(), spicy);
    }

    private string GetIngredients()
    {
        var ingredients = new List<string>();
        if (Cutlet) ingredients.Add("cutlet");
        if (Cheese) ingredients.Add("cheese");
        if (Onions) ingredients.Add("onion");
        if (Bacon) ingredients.Add("bacon");
        if (Tomatoes) ingredients.Add("tomato");
        if (Lettuce) ingredients.Add("letuce");
        if (Pickles) ingredients.Add("cucumber");
        if (Egg) ingredients.Add("egg");
        if (Mushrooms) ingredients.Add("mushrooms");
        if (Chili) ingredients.Add("chili");
        if (Jalapeno) ingredients.Add("jalapeno");

        return string.Join(", ", ingredients);
    }

    private decimal CalculateCalories()
    {
        var calories = 100m;
        if (Cutlet) calories += 70m;
        if (Cheese) calories += 70m;
        if (Onions) calories += 23m;
        if (Bacon) calories += 90m;
        if (Tomatoes) calories += 12m;
        if (Lettuce) calories += 2m;
        if (Pickles) calories += 20m;
        if (Egg) calories += 120m;
        if (Mushrooms) calories += 10m;
        if (Chili) calories += 7m;
        if (Jalapeno) calories += 8m;

        return calories;
    }
}