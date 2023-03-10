using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public int StylistId { get; set; }
    public string StylistName { get; set; }
    public string StylistDetails { get; set; }
    public List<Client> Clients { get; set; }
  }
}