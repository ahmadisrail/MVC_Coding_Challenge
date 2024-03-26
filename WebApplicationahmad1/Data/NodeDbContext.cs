using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using WebApplicationahmad1.Models.Node;
namespace WebApplicationahmad1.Data
{
   public class NodeDbContext : DbContext
   {
  public DbSet<Node> Nodes { get; set; }  
    }

}

