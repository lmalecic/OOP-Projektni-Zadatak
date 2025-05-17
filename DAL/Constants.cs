using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using DAL;

namespace DAL
{
    public static class Constants
    {
        public static string REPO_FILE_PATH = "worldcup.sfg.io";
        public static string MEN_FILE_PATH = Path.Combine(REPO_FILE_PATH, "men");
        public static string WOMEN_FILE_PATH = Path.Combine(REPO_FILE_PATH, "women");

        public static string CONFIG_PATH = "config.json";

        public static string REPO_API_PATH = "https://worldcup-vua.nullbit.hr";
        public static string MEN_API_PATH = $"{REPO_API_PATH}/men";
        public static string WOMEN_API_PATH = $"{REPO_API_PATH}/women";
    }
}
