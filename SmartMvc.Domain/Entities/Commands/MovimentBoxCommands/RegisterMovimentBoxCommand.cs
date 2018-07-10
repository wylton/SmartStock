using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMvc.Domain.Entities.Commands.MovimentBoxCommands
{
    public class RegisterMovimentBoxCommand
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Function { get; set; }
        public bool IsAdmin { get; set; }

        public RegisterMovimentBoxCommand(string name, string password, string function, bool isAdmin)
        {
            this.Name = name;
            this.Password = password;
            this.Function = function;
            this.IsAdmin = isAdmin;
        }
    }
}
