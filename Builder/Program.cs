using Builder;

IBurgerBuilder builder = new BurgerBuilder();
var director = new BurgerDirector(builder);

director.Build();

var burger = builder.GetBurger();

Console.WriteLine(burger);
Console.ReadKey();