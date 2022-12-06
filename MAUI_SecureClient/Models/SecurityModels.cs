using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_SecureClient.Models
{
    public class RegisterNewUser
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }
    }
    public class AuthenticateUser
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
    }

    public class SecureResponse
    {
        public string? UserName { get; set; }
        public string? Message { get; set; }
        public int StatusCode { get; set; }
        public string? Token { get; set; }
    }
}
