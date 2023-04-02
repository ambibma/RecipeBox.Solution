namespace RecipeBox.models
{
  public class RecipeTag
  {
    public int RecipeTagId {get;set;}
    public int TagsId{get;set;}
    public int RecipeId {get;set;}
    public Recipe Recipe{get;set;}
    public Tag Tag {get;set;}
  }

}