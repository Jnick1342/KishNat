using NC.Models.DBModels;

using NC.Public.Tools;
using System.Windows;

namespace NC.Public.Models
{


    public class VMZUser : BaseViewModel
    {

        public VMZUser()
        {
            LogedUser = new ZUser();
        }
        public ZUser _LogedUser;
        public ZUser LogedUser
        {
            get { return _LogedUser; }
            set
            {
                _LogedUser = value;

                //OnPropertyChanged("VisibilitySystem");
                //OnPropertyChanged("VisibilityASystem");
                //OnPropertyChanged("VisibilityBSystem");
                //OnPropertyChanged("VisibilityCSystem");
                //OnPropertyChanged("VisibilityZSystem");
                //OnPropertyChanged("VisibilityRelatedLogout");
                //OnPropertyChanged("VisibilityRelatedLogin");
                OnPropertyChanged("LogedUser");
            }

        }

        

      







        //public Visibility VisibilityASystem
        //{
        //    get
        //    {
        //        return LogedUser == null ? Visibility.Collapsed : LogedUser.AccessToSystems.Contains("A") ? Visibility.Visible : Visibility.Collapsed;
        //    }
        //}



        //public Visibility VisibilityBSystem
        //{
        //    get
        //    {
        //        return LogedUser == null ? Visibility.Collapsed : LogedUser.AccessToSystems.Contains("B") ? Visibility.Visible : Visibility.Collapsed;
        //    }
        //}


        //public Visibility VisibilityCSystem
        //{
        //    get
        //    {
        //        return LogedUser == null ? Visibility.Collapsed : LogedUser.AccessToSystems.Contains("C") ? Visibility.Visible : Visibility.Collapsed;
        //    }
        //}

        //public Visibility VisibilityZSystem
        //{
        //    get
        //    {
        //        return LogedUser == null ? Visibility.Collapsed : LogedUser.AccessToSystems.Contains("Z") ? Visibility.Visible : Visibility.Collapsed;
        //    }
        //}
        //public Visibility VisibilitySystem
        //{
        //    get
        //    {
        //        return LogedUser == null ? Visibility.Collapsed : Visibility.Visible;
        //    }

        //}

    }
}


