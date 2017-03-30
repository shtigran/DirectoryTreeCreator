# Directory Tree  Creator
# C#6.0  .NET FRAMEWORK 4.6

----
### Test and Result

![gif source](https://github.com/shtigran/TreeDirectoryCreator/blob/master/Tree%20Creator.gif)

This project allow You create the directory tree of the any directory.

----

### Purpose

The destination of this project ilustrate the given directory hierarchy of folders and files.

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
### Description of CreateTree class
In this class we implement the static method Scan, which take the path of directory and string of white space. After the method define all subdirectory i that directory and print the all files. And by recursion continue finding all files in the all subbdirectory.

### Program class implementation
```c#
static void Main(string[] args)
{
            Console.WriteLine("       ______Directory Tree Creator ______\n");
            Console.WriteLine("Please enter the location path of the folder,");
            Console.WriteLine("which Directory Tree Yoy want to create.");
            Console.Write("Location path format: C:\\Users\\User\\Desktop\\translate.txt): ");

            string path = Console.ReadLine();
            Console.WriteLine("\nThe directory tree of " + path + " is: \n");
            path.Scan("");
            string[] fi = Directory.GetFiles(path);
            foreach (string dir in fi)
            {
                Console.WriteLine("-" + dir);
            }
            Console.ReadKey();
        }

```
### Description of Program class
Here we print the welcome message with an explanation and please input the directory path, which tree must be created. And after cretae the tree of directory for that path.



