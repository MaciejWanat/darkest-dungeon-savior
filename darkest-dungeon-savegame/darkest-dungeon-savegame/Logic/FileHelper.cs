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
                Directory.CreateDirectory(dirPath.Replace(Config.LoadString, destinationPath));
            }
                
            foreach (string newPath in Directory.GetFiles(Config.LoadString, "*.*", SearchOption.AllDirectories))
            {
                File.Copy(newPath, newPath.Replace(Config.LoadString, destinationPath), true);
            }
                
        }
    }
}
