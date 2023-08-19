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
        public List<User> GetAllCases()
        {
            return _context.Users.ToList();
        }
        // this method is used to find the specific case id and display that in the Request
        public User GetUserById(int caseId)
        {
            return _context.Users.FirstOrDefault(user => user.CaseId == caseId);
        }

        public bool AddUser(User user)
        {
            if (_context.Users.Any(u => u.CaseId == user.CaseId))
            {
                return false;
            }
            _context.Add(user);
            _context.SaveChanges();
            return true;
        }
        public bool UpdateUserMobile(int caseId, string MobileNumber)
        {
            
            User userToUpdate = _context.Users.FirstOrDefault(user => user.CaseId == caseId);

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
            User userToRemove = _context.Users.FirstOrDefault(user => user.CaseId == caseId);

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