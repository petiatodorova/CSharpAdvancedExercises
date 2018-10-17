using System;
using System.ComponentModel.DataAnnotations;

namespace PermissionsAttribute
{
    [Author("Someone")]
    public class Cat
    {
        public Cat(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        public DateTime BirthDay { get; set; }

        [Range(0,50)]
        public int Age { get; set; }
    }
}
