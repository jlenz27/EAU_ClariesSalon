using System.Collections.Generic;

namespace HairSalons.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string Name { get; set; }
    public List<Stylist> stylists { get; set; }
  }
}