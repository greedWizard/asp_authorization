using System;

namespace WebApplication1.Models
{
    public class LoginModel
    {
        public string login { get; set; }
        public string password { get; set; }
        public bool logInSuccess { get; set; }
    }
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
