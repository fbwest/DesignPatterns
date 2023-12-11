namespace Builder;

public class BurgerDirector
{
    private readonly IBurgerBuilder _builder;

    public BurgerDirector(IBurgerBuilder builder) => _builder = builder;

    public void Build()
    {
        _builder
            .SetName("Wopper")
            .WithCheese()
            .WithBacon()
            .WithOnion()
            .WithLetuce()
            .WithCutlet()
            .WithEgg()
            .WithChili()
            .WithJalapeno();
    }
}