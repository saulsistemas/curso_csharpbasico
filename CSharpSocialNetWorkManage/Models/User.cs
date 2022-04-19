using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSocialNetWorkManage.Models
{
    internal class User
    {
        public User()
        {
            DateCreated= DateTime.Now; 
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime DateCreated { get; set; }
        public short Age { get; set; }

        public bool IsValid(bool validateAge)
        {
            if(string.IsNullOrEmpty(Name)|| string.IsNullOrEmpty(Email))
            {
                return false;
            }

            if((Age<0 || Age > 250) && validateAge)  return false;
            
            return true;
        }
    }
}
