using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Vendor {
    private static List<Vendor> _instances = new List<Vendor> { };
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    // add Orders list after creating the Order class and constructor
    // public List<Order> Orders { get; set; }

    public Vendor(string vendorName)
    {
      Name = vendorName;
      _instances.Add(this);
      Id = _instances.Count;
      // Orders = new List<Order> { }; 
    }
  }
}