using WepAPICore.Model;

namespace WepAPICore.Interface
{
    public interface IUser
    {
        bool AddUser(User user);

        List<User> GetAllCases();

        User GetUserById(int caseId);

        bool UpdateUserMobile(int caseId, string MobileNumber);

        bool RemoveUser(int caseId);
    }
}
