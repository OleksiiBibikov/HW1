using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    public enum Gender
    {
        Male,
        Female
    }
    internal class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; private set; }
        public Gender Gender { get; set; }

        public User()
        {
            
        }

        public User(string firstName, string lastName, int age, Gender gender)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Gender = gender;
        }

        public override string ToString() 
        {
            return $"Hi, my name is {FirstName} and last name {LastName}. I am {20} years old. I am {Gender}.";
        }
    }
}
