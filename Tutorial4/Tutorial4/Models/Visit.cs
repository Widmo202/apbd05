namespace Tutorial4.Models;

public class Visit
{
    public DateTime DateOfVisit { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }

    public Visit(DateTime dateOfVisit, string description, decimal price)
    {
        DateOfVisit = dateOfVisit;
        Description = description;
        Price = price;
    }
}