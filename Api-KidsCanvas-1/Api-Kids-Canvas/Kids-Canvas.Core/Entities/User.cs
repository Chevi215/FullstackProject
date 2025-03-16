using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kids_Canvas.Core.Entities
{
    public enum Role {Admin,Manager,User,Guest};
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Notial_Id { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public DateTime Created { get; set; }
        public DateTime Uptated { get; set; }

    }
}
