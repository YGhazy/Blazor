using Blazor.API.Common;
using Blazor.API.Helper;
using Blazor.Application.Services.IServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Blazor_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController :  BaseResultHandlerController<IAccountService>
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly APISettings _aPISettings;
        private readonly IAccountService _accountService;

        public AccountController(
            RoleManager<IdentityRole> roleManager, IAccountService accountService,
            IOptions<APISettings> options)
            : base(accountService)
        {
            _roleManager=roleManager;
            _aPISettings= options.Value;
            _accountService = accountService;
        }

        //[HttpPost]
        //public async Task<IActionResult> SignUp([FromBody] SignUpRequestDTO signUpRequestDTO)
        //{
        //}

        //[HttpPost]
        //public async Task<IActionResult> SignIn([FromBody] SignInRequestDTO signInRequestDTO)
        //{

        //}


        //private SigningCredentials GetSigningCredentials()
        //{

        //}

        //private async Task<List<Claim>> GetClaims(ApplicationUser user)
        //{

        //}
    }
}
