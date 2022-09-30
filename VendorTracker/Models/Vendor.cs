using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public string PhoneNumber { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }
    private static List<Vendor> _instances = new List<Vendor>{};

    public Vendor(string name, string description, string phoneNumber)
    {
      Name = name;
      Description = description;
      PhoneNumber = phoneNumber;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order>{};
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }
  }
}