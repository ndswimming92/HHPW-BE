using HHPW_BE.Models;

namespace HHPW_BE.Data
{
    public class UsersData
    {
        public static List<User> Users = new List<User>()
        {
            new User() { Id = 1, Cashier = true, Uid = "firebaseUid1" },
            new User() { Id = 2, Cashier = false, Uid = "firebaseUid2" }
        };
    }
}
