namespace TypeGetType
{
    using System;

    class TypeGetTypeExamp
    {
        public static void Main()
        {
            object[] values = { (int)100, (long)17111 };
            foreach (var value in values)
            {

                Type tp = value.GetType();

                if (tp.Equals(typeof(int)))
                    Console.WriteLine("{0} is an integer data type.", value);

                else
                    Console.WriteLine("'{0}' is not an int data type.", value);
            }
        }
    }
}
