namespace HHPW_BE.API
{
    public class ItemsApi
    {
        public static void Map(WebApplication app)
        {
            app.MapGet("/items", (HHPWDbContext db) =>
            {
                return db.Items.ToList();
            });

            app.MapDelete("/items/delete/{id}", (HHPWDbContext db, int id) =>
            {
                
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
