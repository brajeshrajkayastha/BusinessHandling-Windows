using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Pasal
{
    class Validation
    {
        private string exp;

        public bool email(string email)
        {
            if (email != "")
            {
                exp = "^(([a-zA-Z0-9][_-/./+*!=])@([a-zA-Z0-9]{2-9}[._-/+]{0-2}).([a-zA-Z0-9]{2-9}.[a-zA-Z]{0-2}))|(([a-zA-Z0-9][_-/./+*!=])@([a-zA-Z0-9]{2-9}[._-/+]{0-2}).([a-zA-Z0-9]{2-9}))$";
                Regex valid = new Regex(exp);
                return (valid.IsMatch(email));
            }
            else {
                return false;
            }
        }
        public bool username(string username)
        {
            if (username != "")
            {
                exp = "^([a-zA-z0-9-_+*%#./])&";
                Regex valid = new Regex(exp);
                return (valid.IsMatch(username));
            }
            else {
                return false;
            }
        }
        public bool name(string name)
        {
            if (name != "")
            {
                    exp = "^[a-zA-Z ]*$";
                Regex valid = new Regex(exp);
                return (valid.IsMatch(name));
            }
            else {
                return false;
            }

        }

        public bool contact(string contact)
        {
            if (contact != "")
            {
                exp = "^(+[0-9-]{5,15})|([0-9-]{5,15}))$";
                Regex valid = new Regex(exp);
                return (valid.IsMatch(contact));
            }
            else {
                return false;
            }
        }

        public bool password(string pass)
        {
            if (pass != "")
            {
                exp = "^([0-9]{1,}[a-zA-Z]{1,}[_-$*%().,/+!@#]{1,})$";
                Regex valid = new Regex(exp);
                return (valid.IsMatch(pass));
            }
            else {
                return false;    
            }
        }

        public bool number(string num)
        {
            if (num != "")
            {
                exp = "^[0-9]{1,}$";
                Regex valid = new Regex(exp);
                return (valid.IsMatch(num));
            }
            else {
                return false;
            }
        }
    }
}
