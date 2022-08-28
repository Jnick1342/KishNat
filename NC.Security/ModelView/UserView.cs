

using NC.Models.DBModels;
using NC.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace NC.Security.ModelView
{
    public class UserView : BaseViewModel
    {
        #region private
        private Window mWindow;
        private string mUserId = "555555";
        private string mPassword = "345345345";


        #endregion
        #region public
        public string UserId { get => mUserId; set { mUserId = value; OnPropertyChanged(nameof(UserId)); } }
        public string Password { get => mPassword; set { mPassword = value; OnPropertyChanged(nameof(Password)); } }


        #endregion
        #region Commands
        public ICommand SaveCommand { get; set; }



        #endregion
        #region Constructor
        public UserView(Window window)
        {
            mWindow = window;
            mWindow.StateChanged += (sender, e) =>
            {
                OnPropertyChanged(nameof(UserId));
                OnPropertyChanged(nameof(Password));


            };

            SaveCommand = new RelayCommand(() =>
            {
                try
                {
                    mWindow.DialogResult = true;


                    //else
                    //{
                    //    //  NC.Public.Windows.WMessageBox wMessage = new Public.Windows.WMessageBox("خطا", result.ErrorMessage, Models.Tools.Enums.JEnumMessageBox.OK);
                    //    // wMessage.ShowDialog();
                    //    mWindow.DialogResult = false;
                    //}
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });

        }
        #endregion

    }
}
