using System.Collections.Generic;

namespace RecipeBox.Models
{

  public class Tag
  {
    public int TagId { get; set; }
    public string Description { get; set; }
    public List<RecipeTag> JoinEntities { get; set; }
  }
}