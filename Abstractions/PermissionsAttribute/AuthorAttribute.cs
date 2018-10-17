using System;

namespace PermissionsAttribute
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum)]
    public class AuthorAttribute : Attribute
    {
        public AuthorAttribute(string name)
        {
            this.AuthorName = name;
        }

        public string AuthorName { get; set; }

        public int Year { get; set; }
    }
}
