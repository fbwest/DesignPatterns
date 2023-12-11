namespace Builder;

public class BurgerBuilder : IBurgerBuilder
{
    private Burger _burger;

    public BurgerBuilder()
    {
        _burger = new Burger();
    }
    public IBurgerBuilder SetName(string name)
    {
        _burger.Name = name;
        return this;
    }
    public IBurgerBuilder WithCutlet()
    {
        _burger.Cutlet = true;
        return this;
    }
    public IBurgerBuilder WithCheese()
    {
        _burger.Cheese = true;
        return this;
    }
    public IBurgerBuilder WithOnion()
    {
        _burger.Onions = true;
        return this;
    }
    public IBurgerBuilder WithBacon()
    {
        _burger.Bacon = true;
        return this;
    }
    public IBurgerBuilder WithTomato()
    {
        _burger.Tomatoes = true;
        return this;
    }
    public IBurgerBuilder WithLetuce()
    {
        _burger.Lettuce = true;
        return this;
    }
    public IBurgerBuilder WithCucumber()
    {
        _burger.Pickles = true;
        return this;
    }
    public IBurgerBuilder WithEgg()
    {
        _burger.Egg = true;
        return this;
    }
    public IBurgerBuilder WithMushrooms()
    {
        _burger.Mushrooms = true;
        return this;
    }
    public IBurgerBuilder WithChili()
    {
        _burger.Chili = true;
        return this;
    }
    public IBurgerBuilder WithJalapeno()
    {
        _burger.Jalapeno = true;
        return this;
    }
    
    public Burger GetBurger()
    {
        var burger = _burger;
        _burger = new Burger();
        return burger;
    }
}