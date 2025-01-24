namespace Mission3me;

public class FoodItem
{
    public string Name;
    public string Category;
    public int Quantity;
    public string Date;
    
    // create a FoodItem object that hols name, category quantity, and date
    public FoodItem(string name, string category, int quantity, string date)
    {
        Name = name;
        Category = category;
        Quantity = quantity;
        Date = date;
        
    }
}