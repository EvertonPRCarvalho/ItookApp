using ItookApp.Domain.Products;
using ItookApp.Infra.Data;
using Microsoft.AspNetCore.Mvc;

namespace ItookApp.Endpoints.Categories;

public class CategoryDelete
{
    public static string Template => "/categories/{id}";

    public static string[] Methods => new string[] { HttpMethod.Get.ToString() };
    public static Delegate Handle => Action;

    public static IResult Action([FromRoute] Guid id,CategoryRequest categoryRequest ,ApplicationDbContext context)
    {
       // var category = context.Categories.Where(c => c.Id == id);
       //var response = category.Select(c => new CategoryResponse { Id = c.Id, Name = c.Name, Active = c.Active });
        return Results.Ok();
    }
}