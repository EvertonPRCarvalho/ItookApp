using ItookApp.Domain.Products;
using ItookApp.Infra.Data;
using Microsoft.AspNetCore.Mvc;

namespace ItookApp.Endpoints.Categories;

public class CategoryPut
{
    public static string Template => "/categories/{id:guid }";

    public static string[] Methods => new string[] { HttpMethod.Put.ToString() };
    public static Delegate Handle => Action;

    public static IResult Action([FromRoute] Guid id,CategoryRequest categoryRequest ,ApplicationDbContext context)
    {
        var category = context.Categories.Where(c => c.Id == id ).FirstOrDefault();

        if (category == null)
            return Results.NotFound();

        category.Name = categoryRequest.Name;
        category.Active = categoryRequest.IsActive;

        context.SaveChanges();

        return Results.Ok();
    }
}
