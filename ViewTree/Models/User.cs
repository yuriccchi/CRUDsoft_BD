using System.Security.Cryptography;
using System.Text;

namespace ViewTree.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public bool isAdmin { get; set; }
        public bool isActive { get; set; }

        public static string GetPasswordHash(string password)
        {
            using (SHA1 sha1Hash = SHA1.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha1Hash.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);
                return hash;
            }
        }

        public static User Login(string username, string password)
        {
            try
            {
                var bd = new UserContext();

                var user = bd.Users.FirstOrDefault(u => u.Name == username && u.Password == GetPasswordHash(password));

                return user;
            }
            catch
            {
                return null;
            }
        }
    }
}
