using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace darkest_dungeon_savegame.Logic
{
    public static class Config
    {
        public static string LoadString = "";
        public static string ConfigString = @".\config.json";
        public static string LocalSavesLocation = @".\saveGames";
        private static List<string> SavesLocation = new List<string>{ };

        public static void SetLoadString(string loadString)
        {
            LoadString = loadString;
        }
    }
}
