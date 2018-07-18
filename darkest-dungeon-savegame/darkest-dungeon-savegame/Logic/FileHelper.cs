using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace darkest_dungeon_savegame.Logic
{
    static class FileHelper
    {
        public static void CopySaveGames(string destinationPath)
        {
            foreach (string dirPath in Directory.GetDirectories(Config.LoadString, "*", SearchOption.AllDirectories))
            {
                if (dirPath.Contains("profile_"))
                    Directory.CreateDirectory(dirPath.Replace(Config.LoadString, destinationPath));
            }
               
            foreach (string newPath in Directory.GetFiles(Config.LoadString, "*.*", SearchOption.AllDirectories))
            {
                if (newPath.Contains("profile_"))
                    File.Copy(newPath, newPath.Replace(Config.LoadString, destinationPath), true);
            }             
        }

        public static void LoadSaveGames(string sourcePath)
        {
            foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
            {
                if (dirPath.Contains("profile_"))
                    Directory.CreateDirectory(dirPath.Replace(sourcePath, Config.LoadString));
            }
            
            foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
            {
                if (newPath.Contains("profile_"))
                    File.Copy(newPath, newPath.Replace(sourcePath, Config.LoadString), true);
            }            
        }

        public static bool ValidatePath(string path)
        {
            //var files = Directory.GetFiles(path);
            var directories = Directory.GetDirectories(path);

            if(directories.Count() != 0)
            {
                foreach(var dir in directories)
                {
                    if(dir.Contains("profile_"))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
