using NC.Models.DBModels;

using NC.Public.Tools;

namespace NC.Public.Models
{
    public class VSelectedSystem: BaseViewModel
    {

        public VSelectedSystem()
        {
            ZAppSelected = new ZApp();
        }
        public ZApp _ZAppSelected;
        public ZApp ZAppSelected
        {
            get { return _ZAppSelected; }
            set
            {
                _ZAppSelected = value;

                //OnPropertyChanged("VisibilitySystem");
                //OnPropertyChanged("VisibilityASystem");
                //OnPropertyChanged("VisibilityBSystem");
                //OnPropertyChanged("VisibilityCSystem");
                //OnPropertyChanged("VisibilityZSystem");
                //OnPropertyChanged("VisibilityRelatedLogout");
                //OnPropertyChanged("VisibilityRelatedLogin");
                OnPropertyChanged("ZAppSelected");
            }

        }



        //public Visibility VisibilityRelatedLogin
        //{
        //    get
        //    {
        //        return LogedUser == null ? Visibility.Collapsed : Visibility.Visible;
        //    }
        //}





        //public Visibility VisibilityRelatedLogout
        //{
        //    get
        //    {
        //        return LogedUser == null ? Visibility.Visible : Visibility.Collapsed;
        //    }
        //}




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


