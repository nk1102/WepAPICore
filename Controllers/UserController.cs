using Microsoft.AspNetCore.Mvc;
using WepAPICore.Interface;
using WepAPICore.Model;
using WepAPICore.Repository;

namespace WepAPICore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {

        private readonly IUser userRepository;

        public UserController(IUser userRepository)
        {
            this.userRepository = userRepository;
        }

        [HttpPost]
        [Route("AddUser")]
        public IActionResult AddUser(User user)
        {
            if (user == null)
            {
                return BadRequest("User data is empty.");
            }

            bool isUserAdded = userRepository.AddUser(user);

            if (isUserAdded)
            {
                return Ok("User added successfully.");
            }

            return StatusCode(500, "Case Id already exists.");
        }
        
        [HttpGet]
        [Route("GetAllUsers")]
        public ActionResult<List<User>> GetAllUsers()
        {
            var cases = userRepository.GetAllUsers();
            if (cases == null || cases.Count == 0)
            {
                return StatusCode(500);
            }
            return cases;
        }
        [HttpGet("GetClientById/{id}")]
        public ActionResult<User> GetClientByCaseId(int id)
        {
            var user = userRepository.GetUserById(id);
            if (user == null)
            {
                return StatusCode(500);
            }
            return user;
        }


        [HttpPut]
        [Route("UpdateMobile/{id}")]
        public IActionResult UpdateUserMobile(int id, [FromBody] string MobileNumber)
        {
            if (id == 0 || string.IsNullOrEmpty(MobileNumber))
            {
                return StatusCode(500);
            }

            bool isUpdated = userRepository.UpdateUserMobile(id, MobileNumber);

            if (isUpdated)
            {
                return Ok("true"); 
            }
            else
            {
                return StatusCode(500);
            }
        }


        [HttpDelete]
        [Route("DeleteUser/{id}")]
        public IActionResult RemoveUser(int id)
        {
            // Validate the caseId parameter
            if (id == 0 || id == null)
            {
                return StatusCode(500);
            }

            bool isDeleted = userRepository.RemoveUser(id);

            if (isDeleted)
            {
                return Ok("true"); 
            }
            else
            {
                return StatusCode(500);
            }
        }


    }
}