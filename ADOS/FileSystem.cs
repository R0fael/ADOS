using Cosmos.System;
using Cosmos.System.FileSystem;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sys = Cosmos.System;
using Console = System.Console;
using ConsoleX = ADOS.Tools.ConsoleX;
using Power = ADOS.Tools.PowerControl;
using System.Security.Cryptography.X509Certificates;

namespace ADOS
{
    public static class FileSystem
    {
        public static string directory = @"0:\";

        public static CosmosVFS fs;
        public static void MoveDir(string file, string newpath)
        {
            try
            {
                Directory.Move(directory + file, newpath);
            }
            catch (Exception e)
            {
                ConsoleX.Cerror(e.ToString());
            }
        }

        public static void MoveFile(string file, string newpath)
        {
            try
            {
                File.Copy(directory+file, newpath);
                File.Delete(file);
            }
            catch (Exception e)
            {
                ConsoleX.Cerror(e.ToString());
            }
        }

        public static void CreateFile(string name) {
            try
            {
                if (!DoesExist(directory + name))
                {
                    fs.CreateFile(directory + name);
                }
                else { ConsoleX.Cerror("File Already Exist"); }
            }
            catch (Exception e) { ConsoleX.Cerror(e.ToString()); }
        }
        public static void CreateDir(string name)
        {
            try
            {
                if (!DoesExist(directory + name))
                {
                    fs.CreateDirectory(directory + name);
                }
                else { ConsoleX.Cerror("Directory Already Exist"); }
            }
            catch (Exception e) { ConsoleX.Cerror(e.ToString()); }
        }

        public static void DeleteFile(string name)
        {
            try
            {
                File.Delete(directory + name);
            }
            catch
            {
                ConsoleX.Cerror("File not found");
            }
            
        }
        public static void DeleteDir(string name)
        {
            try
            {
                Directory.Delete(directory + name + @"\");
            }
            catch {
                ConsoleX.Cerror("Directory not found");
            }
        }
        public static void CD(string path)
        {
            if(path == "..")
            {
                string newp = "";
                string[] a = directory.Split();
                a.SetValue("", a.Length);

                foreach(string s in a)
                {
                    newp += s+@"\";
                }
                directory = newp;
            }
            else
            {
                directory = path;
            }
        }

        public static void Dir()
        {
            try
            {
                var directory_list = Sys.FileSystem.VFS.VFSManager.GetDirectoryListing(directory);
                foreach (var directoryEntry in directory_list)
                {
                    try
                    {
                        var entry_type = directoryEntry.mEntryType;
                        if (entry_type == Sys.FileSystem.Listing.DirectoryEntryTypeEnum.File)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            ConsoleX.Print("|file|      " + directoryEntry.mName);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (entry_type == Sys.FileSystem.Listing.DirectoryEntryTypeEnum.Directory)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            ConsoleX.Print("|directory| " + directoryEntry.mName);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    catch (Exception e)
                    {
                        ConsoleX.Cerror("Directory not found");
                    }

                }
            }
            catch (Exception ex)
            {
                ConsoleX.Cerror(ex.ToString());
            }
        }

        public static void Info(string file)
        {
            ConsoleX.Print("name          : " + fs.GetFile(directory + file).mName);
            ConsoleX.Print("size          : " + fs.GetFile(directory + file).mSize);
            //Console.WriteLine("creation time : " + File.GetCreationTime(directory + file));
            //Console.WriteLine("edit time     : " + File.GetLastWriteTime(directory + file));
        }

        public static string ReadFile(string path,bool error = false)
        {
            try
            {
                return File.ReadAllText(directory + path);
            }
            catch (Exception ex)
            {
                if (!error)
                {
                    ConsoleX.Cerror(ex.ToString());
                    return null;
                }
                else
                {
                    throw new Exception("Random Error");
                }
            }
        }

        public static void WriteFile(string name, string data)
        {
            try
            {
                File.WriteAllText(directory + name, data);
            }
            catch (Exception ex)
            {
                ConsoleX.Cerror(ex.ToString());
            }
        }

        public static void GetFreeSpace(string disk)
        {
            fs.GetAvailableFreeSpace(disk);
        }
        public static void GetSpace(string disk)
        {
            fs.GetVolume(disk);
        }

        public static bool DoesExist(string path)
        {
            try
            {
                ReadFile(path,true);
                return true;
            }
            catch { return false; }
        }
    }
}
