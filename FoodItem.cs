namespace Mission3me;

public class FoodItem
{
    public string Name;
    public string Category;
    public int Quantity;
    public string Date;
    
    public FoodItem(string name, string category, int quantity, string date)
    {
        Name = name;
        Category = category;
        Quantity = quantity;
        Date = date;
        
    }
}