using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace SupportDownloader
{
    class Config
    {
        public ObservableCollection<Program> programList;

        public Config()
        {
            programList = new ObservableCollection<Program>();
            programList.Add(new Program()
            {
                Name = "ВЭД-Декларант",
                URL = "https://ftp.ctm.ru/DCL/SFX/setup_dl.exe",
                Description = "Программа для заполнения таможенных деклараций",
                Type = 0,
                Checked = true,
                Icon = "/SupportDownloader;component/Img/dcl.png"
            });

            programList.Add(new Program()
            {
                Name = "ВЭД-Склад",
                URL = "https://ftp.ctm.ru/STS/SFX/setup_st.exe",
                Description = "Программа для заполнения отчетов СВХ",
                Type = 0,
                Checked = false,
                Icon = "/SupportDownloader;component/Img/sts.png"
            });

            programList.Add(new Program()
            {
                Name = "Монитор ЭД",
                URL = "https://ftp.ctm.ru/MONITOR_ED/SFX/setup_me.exe",
                Description = "Модуль программы ВЭД-Декларант для отправки данных в таможенные органы",
                Type = 0,
                Checked = true,
                Icon = "/SupportDownloader;component/Img/med.png"
            });

            programList.Add(new Program()
            {
                Name = "Крипто ПРО 4.0",
                URL = "https://ed2inteh.ru/files/CSPSetup40.exe",
                Description = "Крипто-провайдер",
                Type = 0,
                Checked = true,
                Icon = "/SupportDownloader;component/Img/csp4.png",
                Params= "-silent -noreboot"
            });

            programList.Add(new Program()
            {
                Name = "Крипто ПРО 5.0",
                URL = "https://ed2inteh.ru/files/CSPSetup50.exe",
                Description = "Крипто-провайдер",
                Type = 0,
                Checked = false,
                Icon = "/SupportDownloader;component/Img/csp5.png",
                Params = "-silent -noreboot"
            });

            programList.Add(new Program()
            {
                Name = "Сервер регистрации",
                URL =  "http://files.ctm.ru/INCOMING/REGSERV/setup_rs.exe",
                Description = "Сервер для сетевой регистрации программ СТМ",
                Type = 0,
                Checked = false,
                Icon = "/SupportDownloader;component/Img/regserv.png"
            });

            programList.Add(new Program()
            {
                Name = "Сервер подписей",
                URL = "http://ftp.ctm.ru/ctm/ED2/ctmsignsrv_setup.exe",
                Description = "Сервер подписей СТМ",
                Type = 0,
                Checked = false,
                Icon = "/SupportDownloader;component/Img/console.png"
            });



            programList.Add(new Program()
            {
                Name = "АммиАдмин",
                URL = "https://ed2inteh.ru/files/AmmyAdmin.exe",
                Description = "Программа удаленного доступа",
                Type = 1,
                Checked = false,
                Icon = "/SupportDownloader;component/Img/ammy.png"
            });


            programList.Add(new Program()
            {
                Name = "Team Viewer",
                URL = "https://ed2inteh.ru/files/TeamViewerQS.exe",
                Description = "Программа удаленного доступа",
                Type = 1,
                Checked = false,
                Icon = "/SupportDownloader;component/Img/team.png"
            });

            programList.Add(new Program()
            {
                Name = "ed2sender",
                URL = "http://ed2inteh.ru/app/ed2sender/setup.exe",
                Description = "Программа для передачи данных в систему ЭД через каталоги обмена",
                Type = 1,
                Checked = false,
                Icon = "/SupportDownloader;component/Img/ed2sender.png"
            });

            programList.Add(new Program()
            {
                Name = "cspKey",
                URL = "https://ed2inteh.ru/files/cspKey.exe",
                Description = "Просмотр серийного номера от КриптоПро",
                Type = 1,
                Checked = false,
                Icon = "/SupportDownloader;component/Img/cspkey.png"
            });


            programList.Add(new Program()
            {
                Name = "modifyMED",
                URL = "https://ed2inteh.ru/app/tools/modifyMED.exe",
                Description = "Утилита для выполнения технических операций с базами ВЭД-Декларант и Монитор ЭД",
                Type = 1,
                Checked = false,
                Icon = "/SupportDownloader;component/Img/console.png"
            });

            programList.Add(new Program()
            {
                Name = "CertificateMe",
                URL = "https://ed2inteh.ru/app/tools/CertificateMe.exe",
                Description = "Установщик корневых сертификатов",
                Type = 1,
                Checked = false,
                Icon = "/SupportDownloader;component/Img/certme.png"
            });

            


            

        }

        static Config config;
        public static Config ex()
        {
            if (config == null)
            {
                config = new Config();
            }
            return config;
        }
    }
}
