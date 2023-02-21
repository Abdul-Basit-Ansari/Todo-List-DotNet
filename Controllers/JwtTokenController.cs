// using TodoApi.Models;
// using Microsoft.AspNetCore.Http;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.IdentityModel.Tokens;
// using System.IdentityModel.Tokens.Jwt;
// using System.Security.Claims;
// using System.Text;

// namespace TodoApi.Controllers
// {
//     [Route("api/[controller]")]
//     [ApiController]
//     public class JwtTokenController : ControllerBase
//     {
//         public IConfiguration _configuration;
//         public readonly TodoContext _context;
//         public JwtTokenController(IConfiguration configuration, TodoContext context)
//         {
//             _context = context;
//             _configuration = configuration;
//         }
//         [HttpPost]
//         public async Task<IActionResult> Post(User user)
//         {
//             if (user != null && user.UserName != null && user.Password != null)
//             {
//                 var userData = await GetUser(user.UserName, user.Password);
//                 var jwt = _configuration.GetSection("JWT").Get<Jwt>();
//                 if (user != null)
//                 {
//                     var claims = new[]
//                     {
//                         new Claim(JwtRegisteredClaimNames.Sub, jwt.Subject),
//                         new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
//                         new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
//                         new Claim("Id", user.UserId.ToString()),
//                         new Claim("UserName", user.UserName),
//                         new Claim("Password", user.Password)

//                     };
//                     var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.key));
//                     var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
//                     var token = new JwtSecurityToken(
//                        jwt.Issuer,
//                        jwt.Audience,
//                         claims,
//                         expires: DateTime.Now.AddMinutes(20),
//                         signingCredentials: signIn
//                     );
//                     return Ok(new JwtSecurityTokenHandler().WriteToken(token));
//                 }
//                 else
//                 {
//                     return BadRequest("Invalid Credentials");
//                 }


//             }
//             else
//             {
//                 return BadRequest("Invalid Credentials");
//             }
//         }
        // [HttpGet]
        // public async Task<IActionResult> GetToken(string userName, string password)
        // {
        //     if (userName != null && password != null)
        //     {
        //         var userData = await GetToken(userName, password);
        //         var jwt = _configuration.GetSection("JWT").Get<Jwt>();
        //         var claims = new[]
        //         {
        //             new Claim(JwtRegisteredClaimNames.Sub, jwt.Subject),
        //             new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        //             new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
        //             new Claim("UserName", userName),
        //             new Claim("Password", password)

        //         };
        //         var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.key));
        //         var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        //         var token = new JwtSecurityToken(
        //             jwt.Issuer,
        //             jwt.Audience,
        //             claims,
        //             expires: DateTime.Now.AddMinutes(20),
        //             signingCredentials: signIn
        //         );
        //         return Ok(new JwtSecurityTokenHandler().WriteToken(token));
        //     }
        //     else
        //     {
        //         return BadRequest("Invalid Credentials");
        //     }
        // }
//         [HttpGet]
//         public async Task<IActionResult> GetUser(string userName, string password)
//         {
//             if (userName != null && password != null){
//             return Ok(await _context.User.FirstOrDefaultAsync(u => u.UserName == userName && u.Password == password));
//             }
//             else
//             {
//                 return BadRequest("Fileds Is required");
//             }
//         }
//     }
// }