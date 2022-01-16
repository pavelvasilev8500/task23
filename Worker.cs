using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CustomException
{
    public class Worker
    {
        private readonly string namepattern = @"[A-Za-zА-Яа-яЁё]+(\s+[A-Za-zА-Яа-яЁё]+)?";
        private readonly string emailpattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + 
            @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
        private readonly string phonedpattern = @"^(\s*)?(\+)?([-_():= +]?\d[-_():= +]?){10,14}(\s*)?$";

        private string name;
        private int age;
        private string phone;
        private string email;

        public string Name 
        { 
            get { return name; } 
            set
            {
                if (Regex.IsMatch(value, namepattern))
                {
                    name = value;
                }
                else
                    throw new WorkerException("Incorrect name.");
            }
        }
        public int Age 
        {
            get { return age; }
            set 
            {
                if (value < 18 | value > 60)
                    throw new WorkerException("Age must be within the following limits:\n 17 - 60");
                else
                    age = value; 
            }
        }
        public string Phone
        {
            get { return phone; }
            set
            {
                if (Regex.IsMatch(value, phonedpattern))
                {
                    phone = value;
                }
                else
                    throw new WorkerException("Incorrect phone number.\nTry input phone number in next format:\n+7(903)888-88-88\n8(999)99-999-99\n+1-541-754-3010");
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (Regex.IsMatch(value, emailpattern))
                {
                    email = value;
                }
                else
                    throw new WorkerException("Incorrect email.\nTry input email in next format:\n userlogin@mail.com");
            }
        }
        public Worker(string name, int age, string phone, string email)
        {
            Name = name;
            Age = age;
            Phone = phone;
            Email = email;
        }
    }
}
