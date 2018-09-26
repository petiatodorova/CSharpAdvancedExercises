using System;
using System.IO;

namespace StreamReaderAndWriter
{
    class FileReadWrite
    {
        static void Main(string[] args)
        {
            using (var stream = new StreamReader("(full path)\\TextFileToRead.txt"))
            {
                using (var streamWrite = new StreamWriter("(full path)\\TextFileToWrite.txt"))
                {
                    string line = stream.ReadLine();
                    while (line != null)
                    {
                        for (int i = line.Length - 1; i >= 0; i--)
                        {
                            streamWrite.Write(line[i]);
                        }

                        streamWrite.WriteLine();
                        line = stream.ReadLine();
                    }
                }
            }
        }
    }
}
