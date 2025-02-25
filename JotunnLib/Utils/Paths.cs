﻿using System.IO;

namespace Jotunn.Utils
{
    /// <summary>
    ///     Various Path constants used in Jötunn
    /// </summary>
    public static class Paths
    {
        public static string JotunnFolder
        {
            get
            {
                var saveDataPath = global::Utils.GetSaveDataPath();
                return Path.Combine(saveDataPath, Main.ModName);
            }
        }

        public static string CustomItemDataFolder => Path.Combine(JotunnFolder, "CustomItemData");

        public static string LanguageTranslationsFolder => BepInEx.Paths.PluginPath;
    }
}
