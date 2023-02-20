using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginExample.ViewModels
{
    public class LoginModel
    {
        public Dictionary<string, string> Users { get; set; } = new Dictionary<string, string>();

        public LoginModel()
        {
            Users.Add("P2454", "password1");
            Users.Add("P2453", "password2");
        }
    }
}
