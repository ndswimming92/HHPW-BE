using HHPW_BE.Models;

namespace HHPW_BE.API
{
    public class ItemsApi
    {
        public static void Map(WebApplication app)
        {
            // Get All Items
            app.MapGet("/api/getAllItems", (HHPWDbContext db) =>
            {
                return db.Items.ToList();
            });

            // Get Single Item
            app.MapGet("/api/getSingleItem/{id}", (HHPWDbContext db, int id) =>
            {
                var itemID = db.Items.FirstOrDefault(c => c.Id == id);

                if (itemID == null)
                {
                    return Results.NotFound("Item Not Found.");
                }

                return Results.Ok(itemID);
            });

        }
    }

}
