using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order>{};
    private static Dictionary<string, int> _search = new Dictionary<string, int>();

    public Order (string title, string description, int price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      _instances.Add(this);
      Id = _instances.Count;
      _search.Add(this.Title, this.Id);
    }

    public static void ClearAll()
    {
      _instances.Clear();
      _search.Clear();
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static Order Find(int id)
    {
      return _instances[id-1];
    }

    public static int SearchByTitle(string title)
    {
      int value = 0;
      if (_search.TryGetValue(title, out value))
      {
      return value;
      }
      else
      {
        return -1;
      }

    }
  }
}