using Api.Contracts;
using Api.Data;
using Api.Entities;
using Api.Services;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserManager<UserEntity> _userManager;
        private readonly SignInManager<UserEntity> _signInManager;
        private readonly TokenService _tokenService;
        private readonly IMapper _mapper;
        private readonly ApplicationContext _context;

        public UserController(
         UserManager<UserEntity> userManager,
         SignInManager<UserEntity> signInManager,
         TokenService tokenService, IMapper mapper,
         ApplicationContext context
         )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
            _mapper = mapper;
            _context = context;
        }

        [HttpPost("login")]
public async Task<ActionResult<UserDto>> Login(LoginUser loginUser)
{
    var user = await _userManager.FindByEmailAsync(loginUser.Email);

    if (user == null)
    {
        return NotFound("User not found");
    }

    var result = await _signInManager.CheckPasswordSignInAsync(user, loginUser.Password, false);

    if (!result.Succeeded)
    {
        return BadRequest("Invalid password or email");
    }

    var token = await _tokenService.CreateUserToken(user);

    // Fetch user files
    var files = await _context.Materials
        .Where(m => m.UserId == user.Id)
        .Select(m => new FileDto
        {
            Id = m.Id,
            FileName = m.FileName,
            DateUploaded = m.DateUploaded,
            UserId = m.UserId,
            FileType = m.FileType,
            FileSizeInBytes = m.FileSizeInBytes,
            FileContent = m.FileContent
        }).ToListAsync();

    return Ok(new UserDto
    {
        UserId = user.Id,
        Token = token,
        UserName = user.UserName,
        Email = user.Email,
        Uploads = files
    });
}


        [HttpPost("register")]
        public async Task<ActionResult> Register(CreateUser createUser)
        {
            if (await _userManager.Users.AnyAsync(x => x.Email == createUser.Email))
            {
                return BadRequest("Email is taken");
            }

            var user = new UserEntity
            {
                UserName = createUser.UserName,
                Email = createUser.Email
            };

            var result = await _userManager.CreateAsync(user, createUser.Password);

            if (result.Succeeded)
            {
                var token = await _tokenService.CreateUserToken(user);

                var userId = user.Id;
                var userName = user.UserName;
                var email = user.Email;

                return Ok(new UserDto
                {
                    UserId = userId,
                    Token = token,
                    UserName = userName,
                    Email = email
                });
            }
            return BadRequest("Invalid password or email");
        }
    }
}