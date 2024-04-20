namespace HHPW_BE.API
{
    public class UsersApi
    {
        public static void Map(WebApplication app)
        {

            // Check if User is present
            app.MapPost("/checkUserPresent", (HHPWDbContext db, string Uid) => {
                var userUid = db.Users.SingleOrDefault(user => user.Uid == user.Uid);

                if (userUid == null)
                {
                    return Results.NotFound("User not found.");
                }
                else
                {
                    return Results.Ok(userUid);
                }
            });
        }
    }
}
