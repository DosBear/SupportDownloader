using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SupportDownloader
{
    class Program
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public int Type { get; set; }  //0 - install app, 1 - Portable
        public string TypeName
        {
            get
            {
                switch (Type)
                {
                   case 0: return "Приложения";
                   case 1:  return "Утилиты";
                   default:  return "";
                }
            }
        }
        public string FileName {
            get
            {
                return URL.Substring(URL.LastIndexOf("/")+1);
            }
        }
        public bool Checked { get; set; }
        public string Icon { get; set; }
        public string Params { get; set; } //need for silence install
    }
}
