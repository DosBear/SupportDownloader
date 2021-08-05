using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SupportDownloader
{
    class Const
    {

        public struct APP
        {
            public const string VERSION = "0.01";
        }

        public struct PATH
        {
            public static string APPPATH = AppDomain.CurrentDomain.BaseDirectory;
            public static string SAVEPATH = Path.Combine(APPPATH, "Support");
        }
    }
}
