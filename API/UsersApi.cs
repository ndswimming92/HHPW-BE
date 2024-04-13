using HHPW_BE.DTO_s;

namespace HHPW_BE.API
{
    public class UsersApi
    {
        public static void Map(WebApplication app)
        {

            // CHeck if User is present
            app.MapPost("/checkIfUser", (HHPWDbContext db, UserDTO userAuthDto) => {
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
