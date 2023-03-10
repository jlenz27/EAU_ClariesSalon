namespace HairSalons.Models
{
  public class Stylist
  {
    public int StylistId { get; set; }
    public string Description { get; set; }
    public int ClientsId { get; set; }
    public Client Client { get; set; }
  }
}