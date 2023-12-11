namespace Builder;

public interface IBurgerBuilder
{
    IBurgerBuilder SetName(string name);
    IBurgerBuilder WithCutlet();
    IBurgerBuilder WithCheese();
    IBurgerBuilder WithOnion();
    IBurgerBuilder WithBacon();
    IBurgerBuilder WithTomato();
    IBurgerBuilder WithLetuce();
    IBurgerBuilder WithCucumber();
    IBurgerBuilder WithEgg();
    IBurgerBuilder WithMushrooms();
    IBurgerBuilder WithChili();
    IBurgerBuilder WithJalapeno();
    Burger GetBurger();
}