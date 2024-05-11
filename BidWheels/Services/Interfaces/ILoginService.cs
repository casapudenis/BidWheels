using Microsoft.AspNetCore.Identity;

namespace BidWheels.Services.Interfaces;

public interface ILoginService
{
	Task<SignInResult> SignInAsync(string email, string password, bool rememberMe);
}