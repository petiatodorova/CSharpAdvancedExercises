using System;
using System.Collections.Generic;
using System.Text;

namespace PermissionsAttribute
{
    [Flags]
    [Author("Other")]
    public enum Permissions
    {
        Read,
        Write,
        Test,
        AnotherTest
    }
}
