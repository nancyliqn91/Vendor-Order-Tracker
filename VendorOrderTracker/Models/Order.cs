using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Order
  {

    private static List<Order> _instances = new List<Order> {};
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public int Amount { get; set; }
    public int Id { get; }

    public Order(string title, string description,int price,int amount)
    {
      Title = title;
      Description = description;
      Price = price;
      Amount = amount;
      _instances.Add(this);
      Id = _instances.Count;
    }

    // public static void ClearAll()
    // {
    //   _instances.Clear();
    // }



  }
}