using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sys = Cosmos.System;

namespace AmogusOS.System
{

    public class FS
    {
        public Sys.FileSystem.CosmosVFS fs = new Sys.FileSystem.CosmosVFS();

        public void InitFS()
        {
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
        }

        public double GetAvaibleSpace()
        {
            var available_space = fs.GetAvailableFreeSpace(@"0:\");
            double converted_value = Converting.ConvertOnFile.ConvertBytesToMegabytes(available_space);

            // Return the value as MB
            return converted_value;
        }

        public string GetFSType()
        {
            return fs.GetFileSystemType(@"0:\");
        }

        public void PrintAllFilesFromDirectory(string directory)
        {
            var directory_list = Directory.GetFiles(directory);

            foreach (var file in directory_list)
            {
                Console.WriteLine(file);
            }
        }

        internal void CreateDirectory(string filename)
        {
            try
            {
                var file_stream = Directory.CreateDirectory(filename);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void ReadFilesInDirectory(string directory)
        {
            var directory_list = Directory.GetFiles(directory);

            try
            {
                foreach (var file in directory_list)
                {
                    var content = File.ReadAllText(file);

                    Console.WriteLine("File name: " + file);
                    Console.WriteLine("File size: " + content.Length);
                    Console.WriteLine("Content: " + content);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void CreateFile(string filename)
        {
            try
            {
                var file_stream = File.Create(filename);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void WriteToFile(string filename, string text)
        {
            try
            {
                File.WriteAllText(filename, text);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void ReadFile(string filename)
        {
            try
            {
                Console.WriteLine(File.ReadAllText(filename));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
