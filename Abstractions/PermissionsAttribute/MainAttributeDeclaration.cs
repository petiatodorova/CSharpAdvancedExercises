using System;
using System.Reflection;
using System.Linq;

namespace PermissionsAttribute
{
    [Author("Someone", Year = 2018)]
    class MainAttributeDeclaration
    {
        static void Main(string[] args)
        {
            var value = Permissions.Read | Permissions.Write;

            if (value.HasFlag(Permissions.Read))
            {
                Console.WriteLine($"Reading");
            }
            if (value.HasFlag(Permissions.Write))
            {
                Console.WriteLine($"Writing");
            }
            Cat cat = new Cat("Mimi", 100);
            Console.WriteLine($"{cat.Age}");

            var attributes = typeof(MainAttributeDeclaration).GetCustomAttributes(false);

            foreach (var attr in attributes)
            {
                Console.WriteLine($"{attr.ToString()}");
            }

            var types = Assembly
                    .GetEntryAssembly()
                    .GetTypes()
                    .Where(t => t.GetCustomAttribute<AuthorAttribute>() != null);

            foreach (var type in types)
            {
                var name = type.Name;
                var author = type
                        .GetCustomAttribute<AuthorAttribute>()
                        .AuthorName;

                Console.WriteLine($"{name} --> {author}");
            }
        }
    }
}
