namespace BlazorServerProject.Components;

public class MealResponse
{
    public List<Meal> Meals { get; set; } = new();
}

public class Meal
{
    public string IdMeal { get; set; } = "";
    public string StrMeal { get; set; } = "";
    public string? StrCategory { get; set; }
    public string? StrArea { get; set; }
    public string? StrMealThumb { get; set; }
}
