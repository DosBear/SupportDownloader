using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.IO;
using System.Threading;
using System.ComponentModel;

namespace SupportDownloader
{
    class MainViewModel : BaseViewModel
    {
        private BackgroundWorker _worker = new BackgroundWorker();
        private MainWindowModel _model;

        public MainViewModel()
        {
            _model = new MainWindowModel();
            _model.PercentageChanged += OnPercentageChanged;

            ProgramList = Config.ex().programList;

            _worker.DoWork += DoWork;
            _worker.ProgressChanged += ProgressChanged;
            _worker.WorkerReportsProgress = true;
            _worker.WorkerSupportsCancellation = true;

            IsOperaEnable = true;

        }

        private void OnPercentageChanged(object sender, EventArgs<string> e)
        {
            LocalProgress = int.Parse(e.Value);
        }


        private void ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            CurrentProgress = e.ProgressPercentage;
        }

        public ICommand NavigateCommand
        {
            get
            {
                return new DelegateCommand((obj) =>
                {


                });
            }
        }


        public ICommand DownloadCommand
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    if (ProgramList.Count<Program>(p => p.Checked) == 0) return;
                    try
                    {
                        if (!Directory.Exists(Const.PATH.SAVEPATH))
                            Directory.CreateDirectory(Const.PATH.SAVEPATH);
                    }
                    catch (Exception)
                    {
                        "Ошибка создания каталога {0}".ShowError(Const.PATH.SAVEPATH);
                    }

                    if ("Скачать и установить выделенные программы?".ShowQuestion() == false) return;
                    IsOperaEnable = false;
                    _worker.RunWorkerAsync();
                });
            }
        }


        string _downloadInfo;
        public string DownloadInfo
        {
            get { return _downloadInfo; }
            set
            {
                if (_downloadInfo != value)
                {
                    _downloadInfo = value;
                    OnPropertyChanged("DownloadInfo");
                }
            }
        }

        string _downloadUrl;
        public string DownloadUrl
        {
            get { return _downloadUrl; }
            set
            {
                if (_downloadUrl != value)
                {
                    _downloadUrl = value;
                    OnPropertyChanged("DownloadUrl");
                }
            }
        }

        private async void DoWork(object sender, DoWorkEventArgs e)
        {
            if (CurrentProgress >= 100)
            {
                CurrentProgress = 0;
            }
            var total = ProgramList.Count<Program>(p => p.Checked);
            var count = 0;
            foreach (var item in ProgramList.Where<Program>(p => p.Checked))
            {
                DownloadInfo = "Скачивание: ";
                DownloadUrl = item.URL;
                await _model.HttpGetForLargeFile(item.URL, Path.Combine(Const.PATH.SAVEPATH, item.FileName), new CancellationTokenSource().Token);
                CurrentProgress = 100 / (total - count);
                count++;
                if (ExecutProgram)
                {
                    if (item.Params == null)
                    {
                        System.Diagnostics.Process.Start(Path.Combine(Const.PATH.SAVEPATH, item.FileName));
                    }   
                    else
                    {
                        System.Diagnostics.Process.Start(Path.Combine(Const.PATH.SAVEPATH, item.FileName), item.Params);
                    }    
                }
            }
            IsOperaEnable = true;
        }

        ObservableCollection<Program> _ProgramList;
        public ObservableCollection<Program> ProgramList
        {
            get
            {
                return _ProgramList;
            }
            set
            {
                _ProgramList = value;
                OnPropertyChanged("ProgramList");
            }
        }

        int _CurrentProgress;
        public int CurrentProgress
        {
            get { return _CurrentProgress; }
            set
            {
                if (_CurrentProgress != value)
                {
                    _CurrentProgress = value;
                    OnPropertyChanged("CurrentProgress");
                }
            }
        }

        int _LocalProgress;
        public int LocalProgress
        {
            get { return _LocalProgress; }
            set
            {
                if (_LocalProgress != value)
                {
                    _LocalProgress = value;
                    OnPropertyChanged("LocalProgress");
                }
            }
        }

        bool _IsOperaEnable;
        public bool IsOperaEnable
        {
            get { return _IsOperaEnable; }
            set
            {
                if (_IsOperaEnable != value)
                {
                    _IsOperaEnable = value;
                    OnPropertyChanged("IsOperaEnable");
                }
            }
        }


        bool _ExecutProgram;
        public bool ExecutProgram
        {
            get { return _ExecutProgram; }
            set
            {
                if (_ExecutProgram != value)
                {
                    _ExecutProgram = value;
                    OnPropertyChanged("ExecutProgram");
                }
            }
        }

    }
}
