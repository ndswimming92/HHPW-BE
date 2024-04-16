using HHPW_BE.Models;

namespace HHPW_BE.API
{
    public class ItemsApi
    {
        public static void Map(WebApplication app)
        {
            // Get All Items
            app.MapGet("/items", (HHPWDbContext db) =>
            {
                return db.Items.ToList();
            });

            app.MapDelete("/items/delete/{id}", (HHPWDbContext db, int id) =>
            {

                // Delete Items by Id
                var itemToDelete = db.Items.FirstOrDefault(i => i.Id == id);
                if (itemToDelete == null)
                {
                    return Results.NotFound();
                }
                db.Items.Remove(itemToDelete);
                db.SaveChanges();
                return Results.Ok(db.Items);

            });
        }
    }

}
