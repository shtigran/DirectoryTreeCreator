# 
# Tree Directory Creator
# C#6.0  .NET FRAMEWORK 4.6

----

This project allow You to create the directory tree of the any directory.
----

### Purpose
The destination of this project ilustrate the given directory hierarchy of folders and files .
----
### CreateTree class implementation
```c#
public static class CreateTree
    {
        static string pathFile;

        public static void Scan(this string path, string punct)
        {
            DirectoryInfo direct = new DirectoryInfo(path);
            DirectoryInfo[] listOfDir = direct.GetDirectories(); 

            foreach (DirectoryInfo dd in listOfDir) 
            {

                if (dd.Attributes == FileAttributes.Directory) 
                {              
                    if (dd == listOfDir.Last())
                    {
                        Console.WriteLine(punct + "-" + dd);
                        try
                        {
                            pathFile = path + "\\" + dd;
                            string[] dirs = Directory.GetFiles(pathFile);
                            foreach (string dir in dirs)
                            {
                                Console.WriteLine(punct + "  -" + dir);
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("The process failed: {0}", e.ToString());
                        }

                    }
                    else
                    {
                        Console.WriteLine(punct + "-" + dd);
                        try
                        {
                            pathFile = path + "\\" + dd;
                            string[] dirs = Directory.GetFiles(pathFile);
                            foreach (string dir in dirs)
                            {
                                Console.WriteLine(punct + "  -" + dir);
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("The process failed: {0}", e.ToString());
                        }
                    }

                    try 
                    {
                        DirectoryInfo dir = new DirectoryInfo(path + "\\" + dd);
                        DirectoryInfo[] listOfDirs = dir.GetDirectories();
                        if (listOfDirs.Length > 0)
                        {

                            if (dd != listOfDir.Last())
                            {
                                Scan(path + "\\" + dd, punct + "  ");
                            }
                            else
                            {
                                Scan(path + "\\" + dd, punct + "  ");
                            }
                        }
                    }
                    catch { }               
                }
            }
        }
    }
```
