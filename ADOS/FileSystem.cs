﻿using Cosmos.System;
using Cosmos.System.FileSystem;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sys = Cosmos.System;
using Console = System.Console;
using ConsoleX = ADOS.ConsoleUtilits;
using Power = ADOS.PowerControl;
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
                Directory.Move(file, newpath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void MoveFile(string file, string newpath)
        {
            try
            {
                File.Copy(file, newpath);
                File.Delete(file);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void CreateFile(string name) {
            try
            {
                fs.CreateFile(directory + name);
            }
            catch (Exception e) { ConsoleX.Cerror(e.ToString()); }
        }
        public static void CreateDir(string name)
        {
            fs.CreateDirectory(directory + name);
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
                path = newp;
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
                            Console.WriteLine("|file|      " + directoryEntry.mName);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (entry_type == Sys.FileSystem.Listing.DirectoryEntryTypeEnum.Directory)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("|directory| " + directoryEntry.mName);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error: Directory not found");
                        Console.WriteLine(e.ToString());
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static void Info(string file)
        {
            Console.WriteLine("name          : " + fs.GetFile(directory + file).mName);
            Console.WriteLine("size          : " + fs.GetFile(directory + file).mSize);
            //Console.WriteLine("creation time : " + File.GetCreationTime(directory + file));
            //Console.WriteLine("edit time     : " + File.GetLastWriteTime(directory + file));
        }

        public static string ReadFile(string path)
        {
            try
            {
                return File.ReadAllText(directory + path);
            }
            catch (Exception ex)
            {
                ConsoleX.Cerror(ex.ToString());
                return null;
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
    }
}