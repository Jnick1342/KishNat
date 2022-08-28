

using NC.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace NC.Public.ModelView
{
    public class WMessageViewModel : BaseViewModel
    {
        #region private
        private Window mWindow;
        private Visibility mConfirmButton = Visibility.Collapsed;
        private bool mFeedBackDialogResult = false;
        private string mMessage = "";
        #endregion
        #region public
        public string Message { get { return mMessage; } set { mMessage = value; } }
        public Visibility ConfirmButton { get { return mConfirmButton; } set { mConfirmButton = value; } }
        public bool FeedBackDialogResult { get { return mFeedBackDialogResult; } set { mFeedBackDialogResult = value; } }

        #endregion
        #region Commands
        public ICommand OkCommand { get; set; }
        public ICommand CancelCommand { get; set; }



        #endregion
        #region Constructor
        public WMessageViewModel(Window window)
        {
            mWindow = window;
            mWindow.StateChanged += (sender, e) =>
            {
              
                OnPropertyChanged(nameof(mMessage));
                OnPropertyChanged(nameof(mConfirmButton));

            };




            OkCommand = new RelayCommand(() =>
            {
                //FeedBackDialogResult = true;
                //OnPropertyChanged(nameof(FeedBackDialogResult));
                mWindow.DialogResult = true;


            });
            CancelCommand = new RelayCommand(() =>
            {
                //FeedBackDialogResult = false;
                //OnPropertyChanged(nameof(FeedBackDialogResult));
                mWindow.DialogResult = false;

            });
            //     CancelCommand = new RelayCommand(() => mWindow.Close());


        }
        #endregion

    }
}
