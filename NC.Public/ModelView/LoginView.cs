

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

namespace NC.Public.ModelView
{
    public class LoginView : BaseViewModel
    {
        #region private
        private Window mWindow;
        private string mUserId = "admin";
        private string mPassword = "1234";
      
      
        #endregion
        #region public
        public string UserId { get => mUserId; set { mUserId = value; OnPropertyChanged(nameof(UserId)); } }
        public string Password { get => mPassword; set { mPassword = value; OnPropertyChanged(nameof(Password)); } }
      

        #endregion
        #region Commands
        public ICommand ValidateUserCommand { get; set; }
       
        
        
        #endregion
        #region Constructor
        public LoginView(Window window)
        {
            mWindow = window;
            mWindow.StateChanged += (sender, e) =>
            {
                OnPropertyChanged(nameof(UserId));
                OnPropertyChanged(nameof(Password));
                

            };
          
            ValidateUserCommand = new RelayCommand(() =>
            {
                try
                {
                    ZUser z = new ZUser() { UserId = UserId, Password = Password};
                    var result = BLL.Z.ZUsers.Validate(z);
                    if (result.Success)
                    {
                        z = result.Data;
                        if (z == null)
                        {

                            NC.Public.WMessage win = new WMessage( "خطا ", "کد کاربری یا رمز ورود معتبر نیست", Visibility.Collapsed);
                            win.ShowDialog();

                           
                            //    NC.Public.Windows.WMessageBox wMessage = new Public.Windows.WMessageBox("خطا", "کد کاربری یا رمز ورود معتبر نیست", Models.Tools.Enums.JEnumMessageBox.OK);
                            //        wMessage.ShowDialog();
                            //  this.DialogResult = false;
                          //  MessageBox.Show("کد کاربری یا رمز ورود معتبر نیست");
                        }
                        else
                        {

                            NC.Public.Statics.StaticVariables.JVMUser.LogedUser = z;
                            var result1 = NC.BLL.C.CMasks.GetCode("CAccMask");
                            if (result1.Success)
                            {
                                NC.Models.Tools.StaticMethods.ACCMASK = NC.BLL.C.CMasks.GetCode("CAccMask").Data.Mask;
                                NC.Models.Tools.StaticMethods.TAFSMASK = NC.BLL.C.CMasks.GetCode("CTafsMask").Data.Mask;
                                NC.Models.Tools.StaticMethods.MARMASK = NC.BLL.C.CMasks.GetCode("CMarMask").Data.Mask;
                                NC.Models.Tools.StaticMethods.BANKMASK = NC.BLL.C.CMasks.GetCode("BBankMask").Data.Mask;
                            }


                            mWindow.DialogResult = true;
                        }

                    }
                    else
                    {
                        //  NC.Public.Windows.WMessageBox wMessage = new Public.Windows.WMessageBox("خطا", result.ErrorMessage, Models.Tools.Enums.JEnumMessageBox.OK);
                        // wMessage.ShowDialog();
                        mWindow.DialogResult = false;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        });
            
        }
        #endregion

    }
}
