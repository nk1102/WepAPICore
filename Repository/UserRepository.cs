using Microsoft.EntityFrameworkCore;
using WepAPICore.Interface;
using WepAPICore.Model;

namespace WepAPICore.Repository
{
    public class UserRepository : IUser
    {
        private readonly UserDbContext _context;

        public UserRepository(UserDbContext context)
        {
            _context = context;
        }

        // This method is Used to get all the cases listed in the staticData.cs
        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }
        // this method is used to find the specific case id and display that in the Request
        public User GetUserById(int Id)
        {
            return _context.Users.FirstOrDefault(user => user.Id == Id);
        }

        public bool AddUser(User user)
        {
            if (_context.Users.Any(u => u.Id == user.Id))
            {
                return false;
            }
            _context.Add(user);
            _context.SaveChanges();
            return true;
        }
        public bool UpdateUserMobile(int caseId, string MobileNumber)
        {
            
            User userToUpdate = _context.Users.FirstOrDefault(user => user.Id == caseId);

            if (userToUpdate == null)
            {
                return false;
            }

            userToUpdate.PhoneNumber = MobileNumber;
            return true;
        }



        // Method to delete a Specific User


        public bool RemoveUser(int caseId)
        {
            User userToRemove = _context.Users.FirstOrDefault(user => user.Id == caseId);

            if (userToRemove == null)
            {
                return false;
            }

            _context.Remove(userToRemove);
            _context.SaveChanges();
            return true;
        }
    }
}