using System;
using System.IO;
namespace lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string FileDir = @"D:\ExampleDir\Documents\DIR.txt";
            string Dir = @"D:\ExampleDir\";
            DirectoryInfo rootDir = new DirectoryInfo(FileDir);
            // DirTreesRekurs(Dir,FileDir);
            DirTrees(Dir);
            
        }

        //private static void DirTreesRekurs(DirectoryInfo rootDir)
        //{
          //  throw new NotImplementedException();
        //}

        static void DirTrees(string workDir)
        {
            string FileDir = @"D:\ExampleDir\Documents\DIR.txt";
            //Console.WriteLine(Directory.Exists(workDir));
            using (StreamWriter stream = new StreamWriter(FileDir))
            {
                string[] entries = Directory.GetFileSystemEntries(workDir, "*", SearchOption.AllDirectories);
                //for (int i = 0; i < entries.Length; i++)
                //{
                //    stream.WriteLine(entries[i]);
                //}

                foreach (string dirinfo in entries)
                {
                    stream.WriteLine(dirinfo);
                    stream.Close();
                    DirTrees(workDir);
                }
                //Console.Writeline(entries);
                //DirTrees(workDir);
            }

        }

        static void DirTreesRekurs(string root,string fileDir)
        {
            
            using (StreamWriter stream = new StreamWriter(fileDir))
            {
                string[] files = Directory.GetFiles(root, "*");
                //}

                //catch (UnauthorizedAccessException e)
                //{

                //    //log.Add(e.Message);
                //}

                //catch (System.IO.DirectoryNotFoundException e)
                //{
                //    Console.WriteLine(e.Message);
                //}

                //if (files != null)
                {
                    foreach (string fi in files)
                    {
                        stream.WriteLine(fi);
                        
                    }
                    
                    string[] subDirs = Directory.GetDirectories(root);
                    
                    foreach (string dirInfo in subDirs)
                    {
                        stream.WriteLine(dirInfo);
                        stream.Close();
                        DirTreesRekurs(dirInfo, fileDir);
                        

                    }
                    

                }
            }
        }
    }
}
