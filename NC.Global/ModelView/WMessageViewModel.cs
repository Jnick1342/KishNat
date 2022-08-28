

using NC.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace NC.Global.ModelView
{
    public class WMessageViewModel : BaseViewModel
    {
        #region private
        private Window mWindow;
        private string mUserId = "";
        private string mPassword = "";
        #endregion
        #region public
        public string UserId { get { return mUserId; } set { mUserId = value; } }
        public string Password { get { return mPassword; } set { mPassword = value; } }
        #endregion
        #region Commands
        public ICommand ValidateUserCommand { get; set; }
       
        
        
        #endregion
        #region Constructor
        public WMessageViewModel(Window window)
        {
            mWindow = window;
            mWindow.StateChanged += (sender, e) =>
            {
                OnPropertyChanged(nameof(UserId));
                OnPropertyChanged(nameof(Password));
            };
            //LoginCommand = new RelayCommand(() => 
            //{
            //    // var p = Application.Current.MainWindow.FindName("ProgressBar") as ProgressBar;
            //    MessageBox.Show(UserId);




            //});
            //CloseCommand = new RelayCommand(() => mWindow.Close());
            ValidateUserCommand = new RelayCommand(() =>
            {
                MessageBox.Show("I am trying validate user");
            });
            
        }
        #endregion

    }
}
