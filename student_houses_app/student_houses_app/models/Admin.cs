using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_houses_app.models
{
    public class Admin
    {
        public string Name {  get; set; }
        public string Password { get; set; }

        public Admin (string  name, string password)
        {
            this.Name = name;
            this.Password = password;
        }
    }
}
