using AutoMapper;
using CleanArchitecture.Application.DTOs;
using CleanArchitecture.Infrastracture.Models;
using CleanArchitecture.Infrastracture.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.API.Controllers
{
    [Route("User")]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserController(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }


        [HttpGet]
        [Route("List")]
        public IActionResult Index()
        {
            return View(_userRepository.Users.Include(user => user.Borrowings));
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult AddUser([FromBody] UserDTO userDto)
        {
            var user = _mapper.Map<User>(userDto);
            _userRepository.CreateUser(user);

            return View(user);
        }

        [HttpPost]
        [Route("Delete/{id}")]
        public IActionResult DeleteUser(int id)
        {
            var userRetrieved = _userRepository.Users.FirstOrDefault(u => u.Id == id);

            if (userRetrieved == null) 
            {
                return RedirectToAction("Index");
            }

            _userRepository.DeleteUser(userRetrieved);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("Edit/{id}")]
        public IActionResult EditUser(int id, [FromBody] UserDTO userDto)
        {
            var user = _userRepository.Users.FirstOrDefault(u => u.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            _mapper.Map(userDto, user);
            _userRepository.UpdateUser(user);

            return View(user);
        }
    }
}
