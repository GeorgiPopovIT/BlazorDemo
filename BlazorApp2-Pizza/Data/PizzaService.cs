namespace BlazorApp2_Pizza.Data
{
    public class PizzaService
    {
        public Task<Pizza[]> GetPizzasAsync()
        {
            var pizzas = new Pizza[]
            {
                new Pizza(){ Name = "Margharitta",Description = "Vkusna", Price = 9.50m,Vegan = true,Vegetarian = false},              
                new Pizza(){ Name = "Margharitta",Description = "Vkusna", Price = 9.50m,Vegan = true ,Vegetarian = false},
                new Pizza(){ Name = "Margharitta",Description = "Vkusna", Price = 9.50m,Vegan = true,Vegetarian = false},
                new Pizza(){ Name = "Margharitta",Description = "Vkusna", Price = 9.50m,Vegan = true, Vegetarian = false}
            };

            return Task.FromResult(pizzas);
        }
    }
}
