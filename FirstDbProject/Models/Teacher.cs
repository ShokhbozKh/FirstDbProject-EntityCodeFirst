using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDbProject.Models
{
    public class Teacher
    {
        public Guid Id { get; set; }
        public string FirtName { get; set; }
        public string LastName { get; set; }
        public int Age {  get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"Name:{FirtName} , LastName: {LastName}, Age: {Age}";
        }
    }
}
