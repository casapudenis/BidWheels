using BidWheels.Models;
using Microsoft.AspNetCore.Identity;

namespace BidWheels.Services.Interfaces;

public interface IRegisterService
{
	Task<IdentityResult> RegisterAsync(RegisterModel model);
}