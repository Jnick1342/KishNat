using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace NC.Global
{
    public class BaseViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        protected virtual void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class WBaseViewModel : BaseViewModel
    {
        #region private Member
        private Window mWindow;
        private int mOuterMarginSize = 4;
        private int mWindowRedius = 4;
        #endregion
        #region public Properties
        public int ResizeBorder { get; set; } = 4;
        public Thickness ResizeBorderThickness { get { return new Thickness(ResizeBorder + OuterMarginSize); } }
        public Thickness OuterMarginSizeThickness { get { return new Thickness(ResizeBorder + OuterMarginSize); } }
        public int OuterMarginSize
        {
            get { return mWindow.WindowState == WindowState.Maximized ? 0 : mOuterMarginSize; }
            set { mOuterMarginSize = value; }
        }
        public int WindowRedius
        {
            get { return mWindow.WindowState == WindowState.Maximized ? 0 : mWindowRedius; }
            set { mWindowRedius = value; }
        }
        public CornerRadius WindowCornerRedius
        {
            get { return new CornerRadius(WindowRedius); }
        }
        public GridLength TitleHeightGridLength
        {
            get { return new GridLength(TitleHeight + ResizeBorder); }
        }
        public int TitleHeight { get; set; } = 32;
        public string Title { get; set; } = "عنوان صفحه نمایش";
        public bool IsIndeterminate { get; set; } = true;
        #endregion

        #region Commands
        public ICommand MinimizeCommand { get; set; }
        public ICommand MaximizeCommand { get; set; }
        public ICommand CloseCommand { get; set; }
        public ICommand MenuCommand { get; set; }

        #endregion

        #region Constructor
        public WBaseViewModel(Window window)
        {
            mWindow = window;
            Title = mWindow.Title;
            mWindow.StateChanged += (sender, e) =>
            {
                OnPropertyChanged(nameof(ResizeBorderThickness));
                OnPropertyChanged(nameof(OuterMarginSize));
                OnPropertyChanged(nameof(OuterMarginSizeThickness));
                OnPropertyChanged(nameof(WindowRedius));
                OnPropertyChanged(nameof(WindowCornerRedius));
                OnPropertyChanged(nameof(Title));
            };
            MinimizeCommand = new RelayCommand(() => mWindow.WindowState = WindowState.Minimized);
            MaximizeCommand = new RelayCommand(() => mWindow.WindowState = WindowState.Maximized);
            CloseCommand = new RelayCommand(() => mWindow.Close());
            MenuCommand = new RelayCommand(() => SystemCommands.ShowSystemMenu(mWindow, new Point(0, 0)));

        }
        #endregion

    }
}
