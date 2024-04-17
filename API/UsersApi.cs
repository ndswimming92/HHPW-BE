using HHPW_BE.DTO_s;

namespace HHPW_BE.API
{
    public class UsersApi
    {
        public static void Map(WebApplication app)
        {

            // Check if User is present
            app.MapPost("/checkUser", (HHPWDbContext db, UserDTO userAuthDto) => {
                var userUid = db.Users.SingleOrDefault(user => user.Uid == userAuthDto.Uid);

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
