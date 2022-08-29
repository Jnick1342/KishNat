
using NC.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace NC.Public.ModelView
{
    public partial class GlobalViewModel : WBaseViewModel
    {

        public Visibility LoginVisibility { get { return NC.Public.Statics.StaticVariables.JVMUser.LogedUser == null ? Visibility.Collapsed : Visibility.Visible; } }
        public Visibility LogoutVisibility { get { return NC.Public.Statics.StaticVariables.JVMUser.LogedUser == null ? Visibility.Visible : Visibility.Collapsed; } }
        public Visibility DatabaseVisibility { get { return (NC.Public.Statics.StaticVariables.JVMUser.LogedUser != null && NC.Public.Statics.StaticVariables.JVMUser.LogedUser.AccessToSystems.Contains("Z")) ? Visibility.Visible : Visibility.Collapsed; } }

        //public Visibility DefineDatabaseVisibility { get { return Visibility.Visible; } }
        public Visibility ActivationVisibility { get { return (NC.Public.Statics.StaticVariables.JVMUser.LogedUser != null && NC.Public.Statics.StaticVariables.JVMUser.LogedUser.AccessToSystems.Contains("Z")) ? Visibility.Visible : Visibility.Collapsed; } }
        public Visibility ZVisibility { get { return (NC.Public.Statics.StaticVariables.JVMUser.LogedUser != null && NC.Public.Statics.StaticVariables.JVMUser.LogedUser.AccessToSystems.Contains("Z")) ? Visibility.Visible : Visibility.Collapsed; } }
        public Visibility CVisibility { get { return (NC.Public.Statics.StaticVariables.JVMUser.LogedUser != null && NC.Public.Statics.StaticVariables.JVMUser.LogedUser.AccessToSystems.Contains("C")) ? Visibility.Visible : Visibility.Collapsed; } }
        public Visibility BVisibility { get { return (NC.Public.Statics.StaticVariables.JVMUser.LogedUser != null && NC.Public.Statics.StaticVariables.JVMUser.LogedUser.AccessToSystems.Contains("B")) ? Visibility.Visible : Visibility.Collapsed; } }
        public Visibility AVisibility { get { return (NC.Public.Statics.StaticVariables.JVMUser.LogedUser != null && NC.Public.Statics.StaticVariables.JVMUser.LogedUser.AccessToSystems.Contains("A")) ? Visibility.Visible : Visibility.Collapsed; } }
        public Visibility IVisibility { get { return (NC.Public.Statics.StaticVariables.JVMUser.LogedUser != null && NC.Public.Statics.StaticVariables.JVMUser.LogedUser.AccessToSystems.Contains("I")) ? Visibility.Visible : Visibility.Collapsed; } }
        public Visibility PVisibility { get { return (NC.Public.Statics.StaticVariables.JVMUser.LogedUser != null && NC.Public.Statics.StaticVariables.JVMUser.LogedUser.AccessToSystems.Contains("P")) ? Visibility.Visible : Visibility.Collapsed; } }
        public bool DBValidate { get { return NC.Public.Statics.StaticVariables.DBValidate() ? false : true; } }
        public bool TokenValidate { get { return NC.Public.Statics.StaticVariables.TokenValidate() ? false : true; } }
        public Style SelectedContentMenu
        {
            get
            {
                switch (NC.Public.Statics.StaticVariables.SelectedSystem.ZAppSelected.AppId)
                {
                    case "":
                        {
                            var style = Application.Current.TryFindResource("ContentMenu") as Style;
                            return style;
                        }
                    case "Z":
                        {
                            var style = Application.Current.TryFindResource("ContentMenuSecurity") as Style;
                            return style;
                        }
                    case "B":
                        {
                            var style = Application.Current.TryFindResource("ContentMenuNaghd") as Style;
                            return style;
                        }
                    case "C":
                        {
                            var style = Application.Current.TryFindResource("ContentMenuAcconting") as Style;
                            return style;
                        }
                    default:
                        {
                            var style = Application.Current.TryFindResource("ContentMenu") as Style;
                            return style;
                        }
                }
            }
        }



        public ICommand LoginCommand { get; set; }
        public ICommand LogoutCommand { get; set; }
        public ICommand ZSystemCommand { get; set; }
        public ICommand CSystemCommand { get; set; }
        public ICommand BSystemCommand { get; set; }
        public ICommand DBSetupCommand { get; set; }
        public ICommand ActivationSetupCommand { get; set; }

        #region Constructor
        public GlobalViewModel(Window window) : base(window)
        {


            LoginCommand = new RelayCommand(() =>
            {
                NC.Public.WinLogin win = new NC.Public.WinLogin();
                win.ShowDialog();
                OnPropertyChanged(nameof(LoginVisibility));
                OnPropertyChanged(nameof(LogoutVisibility));
                OnPropertyChanged(nameof(DatabaseVisibility));
                OnPropertyChanged(nameof(ActivationVisibility));
                OnPropertyChanged(nameof(ZVisibility));
                OnPropertyChanged(nameof(CVisibility));
                OnPropertyChanged(nameof(BVisibility));
                OnPropertyChanged(nameof(AVisibility));
                OnPropertyChanged(nameof(IVisibility));
                OnPropertyChanged(nameof(PVisibility));
                OnPropertyChanged(nameof(SelectedContentMenu));

            });

            LogoutCommand = new RelayCommand(() =>
            {

                NC.Public.WMessage win = new NC.Public.WMessage("خروج از سیستم ", "ایا مایل به خروج از سیستم هستید؟", Visibility.Collapsed);
                var result = win.ShowDialog();
                if (result == true)
                {
                    NC.Public.Statics.StaticVariables.JVMUser.LogedUser = null;
                    NC.Public.Statics.StaticVariables.SelectedSystem.ZAppSelected.AppId = "";
                    NC.Public.Statics.StaticVariables.SelectedSystem.ZAppSelected.Name = "هسته مرکزی";
                    OnPropertyChanged(nameof(LoginVisibility));
                    OnPropertyChanged(nameof(LogoutVisibility));
                    OnPropertyChanged(nameof(DatabaseVisibility));
                    OnPropertyChanged(nameof(ActivationVisibility));
                    OnPropertyChanged(nameof(ZVisibility));
                    OnPropertyChanged(nameof(CVisibility));
                    OnPropertyChanged(nameof(BVisibility));
                    OnPropertyChanged(nameof(AVisibility));
                    OnPropertyChanged(nameof(IVisibility));
                    OnPropertyChanged(nameof(PVisibility));
                    OnPropertyChanged(nameof(SelectedContentMenu));
                }
            });

            ZSystemCommand = new RelayCommand(() =>
            {
                Style style = new Style();
                try
                {
                    style = Application.Current.MainWindow.FindResource("ContentMenuSecurity") as Style;
                }
                catch
                {
                    var foo = new Uri("pack://application:,,,/NC.Security;component/Style/Menu.xaml", UriKind.RelativeOrAbsolute);
                    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary() { Source = foo });
                    style = Application.Current.MainWindow.FindResource("ContentMenuSecurity") as Style;
                }


                NC.Public.Statics.StaticVariables.SelectedSystem.ZAppSelected = new NC.Models.DBModels.ZApp() { AppId = "Z", Name = "سیستم حراست " };
                OnPropertyChanged(nameof(SelectedContentMenu));
                
            });
            CSystemCommand = new RelayCommand(() =>
            {
                Style style = new Style();
                try
                {
                    style = Application.Current.MainWindow.FindResource("ContentMenuAccounting") as Style;
                }
                catch
                {
                    var foo = new Uri("pack://application:,,,/NC.Accounting;component/Style/Menu.xaml", UriKind.RelativeOrAbsolute);
                    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary() { Source = foo });
                    style = Application.Current.MainWindow.FindResource("ContentMenuAccounting") as Style;
                }



                NC.Public.Statics.StaticVariables.SelectedSystem.ZAppSelected = new NC.Models.DBModels.ZApp() { AppId = "C", Name = "سیستم حسابداری " };
                OnPropertyChanged(nameof(SelectedContentMenu));
            });
            BSystemCommand = new RelayCommand(() =>
            {
                Style style = new Style();
                try
                {
                    style = Application.Current.MainWindow.FindResource("ContentMenuTreasury") as Style;
                }
                catch
                {
                    var foo = new Uri("pack://application:,,,/NC.Naghd;component/Style/Menu.xaml", UriKind.RelativeOrAbsolute);
                    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary() { Source = foo });
                    style = Application.Current.MainWindow.FindResource("ContentMenuTreasury") as Style;
                }

                NC.Public.Statics.StaticVariables.SelectedSystem.ZAppSelected = new NC.Models.DBModels.ZApp() { AppId = "B", Name = "سیستم نقدینگی و اسناد دریافتنی " };
                OnPropertyChanged(nameof(SelectedContentMenu));
            });

            DBSetupCommand = new RelayCommand(() =>
            {
                Style style = new Style();
                try
                {
                    style = Application.Current.MainWindow.FindResource("ContentDataBaseSetUp") as Style;
                }
                catch
                {
                    var foo = new Uri("pack://application:,,,/NC.Public;component/Style/DataBaseSetupStyle.xaml", UriKind.RelativeOrAbsolute);
                    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary() { Source = foo });
                    style = Application.Current.MainWindow.FindResource("ContentDataBaseSetUp") as Style;
                }

                WinDataBaseSetup win = new WinDataBaseSetup();
                win.ShowDialog();
            });
            ActivationSetupCommand = new RelayCommand(() =>
            {
                Style style = new Style();
                try
                {
                    style = Application.Current.MainWindow.FindResource("ContentActivationSetUp") as Style;
                }
                catch
                {
                    var foo = new Uri("pack://application:,,,/NC.Public;component/Style/ActivationSetupStyle.xaml", UriKind.RelativeOrAbsolute);
                    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary() { Source = foo });
                    style = Application.Current.MainWindow.FindResource("ContentActivationSetUp") as Style;
                }

                WinActivationSetup win = new WinActivationSetup();
                win.ShowDialog();
            });

            #endregion








        }
    }
}
