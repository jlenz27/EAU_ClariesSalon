namespace HairSalons.Models
{
  public class Stylist
  {
    public int StylistId { get; set; }
    public string StylistName { get; set; }
    public int Description { get; set; }
    public List<Client> Clients { get; set; }
  }
}