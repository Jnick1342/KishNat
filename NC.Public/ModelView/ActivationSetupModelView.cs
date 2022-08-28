

using MD.PersianDateTime;
using NC.Models.DBModels;
 
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace NC.Public.ModelView
{
    public class ActivationSetupModelView : BaseViewModel
    {
        #region private
        private Window mWindow;
        private string mAppSerial = NC.Models.Tools.StaticMethods.GetMachineserial();
        private string mAppToken = "345345345";
        private string mPreAppToken = "";
        private string mCompany = "345345345";
        private bool mConfirmTest = false;

        private void SetAppSetring(string key, string value)
        {
            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings[key].Value = value;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        //private bool Unlocktoken(string serial)
        //{
        //    try
        //    {
        //        var unlocktoken = NC.Models.Tools.StaticMethods.Decrypt(NC.Models.Tools.StaticMethods.ENCRYPTKEY, AppToken);
        //        unlocktoken = NC.Models.Tools.StaticMethods.Decrypt(serial, unlocktoken);
        //        if (!unlocktoken.Contains(NC.Models.Tools.StaticMethods.ENCRYPTKEY))
        //            return false;
        //        var date = unlocktoken.Substring(0, 10);
        //        PersianDateTime PDExpire;
        //        if (!PersianDateTime.TryParse(date, out PDExpire))
        //        {
        //            return false;
        //        }
        //        else
        //        {
        //            if (PDExpire.ToShortDateInt() >= PersianDateTime.Now.ToShortDateInt())
        //                return true;
        //            else
        //                return false;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}
        #endregion
        #region public
        public string AppSerial { get => mAppSerial; set { mAppSerial = value; ConfirmTest = false; OnPropertyChanged(nameof(AppSerial)); } }
        public string AppToken { get => mAppToken; set { mAppToken = value; ConfirmTest = false; OnPropertyChanged(nameof(AppToken)); } }
        public string PreAppToken { get => mPreAppToken; set { mPreAppToken = value; ConfirmTest = false; OnPropertyChanged(nameof(PreAppToken)); } }
        public string Company { get => mCompany; set { mCompany = value; OnPropertyChanged(nameof(Company)); } }
        public bool ConfirmTest { get => mConfirmTest; set { mConfirmTest = value; OnPropertyChanged(nameof(ConfirmTest)); } }


        #endregion
        #region Commands
        public ICommand DBTestCommand { get; set; }
        public ICommand DBSaveCommand { get; set; }



        #endregion
        #region Constructor
        public ActivationSetupModelView(Window window)
        {
            AppSerial = NC.Models.Tools.StaticMethods.GetMachineserial();
            AppToken = ConfigurationManager.AppSettings["AppToken"].ToString();
            Company = ConfigurationManager.AppSettings["Company"].ToString();
            PreAppToken = NC.Models.Tools.StaticMethods.GetToken(AppSerial);
            mWindow = window;
            mWindow.StateChanged += (sender, e) =>
            {
                OnPropertyChanged(nameof(AppSerial));
                OnPropertyChanged(nameof(AppToken));
                OnPropertyChanged(nameof(PreAppToken));
                OnPropertyChanged(nameof(Company));
                OnPropertyChanged(nameof(ConfirmTest));
            };
            DBTestCommand = new RelayCommand(() =>
            {
                try
                {
                    if (PreAppToken == AppToken)
                    {
                        ConfirmTest = true;
                        NC.Public.WMessage win = new WMessage("تایید", "گذر واژه معتبر است ", Visibility.Collapsed);
                        win.ShowDialog();
                        OnPropertyChanged(nameof(ConfirmTest));
                    }
                    else
                    {
                        ConfirmTest = false;
                        NC.Public.WMessage win = new WMessage("خطا", "گذر واژه معتبر نیست !!! ", Visibility.Collapsed);
                        win.ShowDialog();
                        OnPropertyChanged(nameof(ConfirmTest));
                    }

                }


                catch (Exception ex)
                {
                    ConfirmTest = false;
                    NC.Public.WMessage win = new WMessage("خطا ", ex.Message, Visibility.Collapsed);
                    win.ShowDialog();
                    OnPropertyChanged(nameof(ConfirmTest));

                }


            });
            DBSaveCommand = new RelayCommand(() =>
            {
                try
                {
                    SetAppSetring("AppSerial", AppSerial);
                    SetAppSetring("AppToken", AppToken);
                    SetAppSetring("Company", Company);
                    
                    NC.Public.WMessage win = new WMessage("فعال سازی  ", ".اطلاعات ذخیره شد ", Visibility.Collapsed);
                    win.ShowDialog();
                    mWindow.DialogResult = true;
                }
                catch (Exception ex)
                {
                    NC.Public.WMessage win = new WMessage("خطا", ex.Message, Visibility.Collapsed);
                    win.ShowDialog();
                }
            });
            #endregion
        }
    }
}