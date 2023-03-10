using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string ClientName { get; set;}
    public int StylistId {get; set;}

    public Stylist stylist {get; set;}
  }
}