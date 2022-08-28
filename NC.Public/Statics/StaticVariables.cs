using MD.PersianDateTime;
using NC.Models.DBModels;
using NC.Public.Models;
using System;
using System.Configuration;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace NC.Public.Statics
{
    public static class StaticVariables
    {

        //  private static string ResourceStyle = "Black";


        //private static VMZUser _JVMUser = new VMZUser() { LogedUser = BLL.Z.ZUsers.Get("admin").Data };
        private static VMZUser _JVMUser = new VMZUser() { LogedUser = null };
        public static VMZUser JVMUser
        {
            get { return _JVMUser; }
            set { _JVMUser = value; }
        }


        //public static VMTabControlViewModel _JVMTabControlViewModel = new VMTabControlViewModel();
        //public static VMTabControlViewModel JVMTabControlViewModel
        //{
        //    get { return _JVMTabControlViewModel; }
        //    set { _JVMTabControlViewModel = value; }
        //}

        /// <summary>
        /// این متغییر با توجه به منوی برنامه سیستم انتخاب شده را در خود نگهداری میکند
        /// </summary>
        private static VSelectedSystem _SelectedSystem = new VSelectedSystem() { ZAppSelected = new ZApp() { Name = "هسته مرکزی", AppId = "" } };
        public static VSelectedSystem SelectedSystem
        {
            get { return _SelectedSystem; }
            set
            {
                _SelectedSystem = value;
            }
        }



        /// <summary>
        /// این متغییر با توجه به منوی برنامه سیستم انتخاب شده را در خود نگهداری میکند
        /// </summary>
        private static VSelectedDoreh _SelectedDoreh = new VSelectedDoreh() { CBasicInfoSelected = BLL.C.CBasicInfos.GetLast().Data };
        public static VSelectedDoreh SelectedDoreh { get { return _SelectedDoreh; } set { _SelectedDoreh = value; } }




        /// <summary>
        /// سیستم نقدینگ نوع سیستم تک کاربره یا مالتی کاربر 
        /// </summary>
        private static bool _SingleUserNaghdinegi = true;
        public static bool SingleUserNaghdinegi { get { return _SingleUserNaghdinegi; } set { _SingleUserNaghdinegi = value; } }



        public static bool TokenValidate()
        {
            try
            {
                var serial = NC.Models.Tools.StaticMethods.GetMachineserial();
                var AppToken = ConfigurationManager.AppSettings["AppToken"].ToString();
                var unlocktoken = NC.Models.Tools.StaticMethods.Decrypt(NC.Models.Tools.StaticMethods.ENCRYPTKEY, AppToken);
                unlocktoken = NC.Models.Tools.StaticMethods.Decrypt(serial, unlocktoken);
                if (!unlocktoken.Contains(NC.Models.Tools.StaticMethods.ENCRYPTKEY))
                    return false;
                var date = unlocktoken.Substring(0, 10);
                PersianDateTime PDExpire;
                if (!PersianDateTime.TryParse(date, out PDExpire))
                {
                    return false;
                }
                else
                {
                    if (PDExpire.ToShortDateInt() >= PersianDateTime.Now.ToShortDateInt())
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception)
            {
                return false;
            }

        }
        public static bool DBValidate()
        {
            try
            {

               
                var DBServer = NC.Models.Tools.StaticMethods.Decrypt(NC.Models.Tools.StaticMethods.ENCRYPTKEY, ConfigurationManager.AppSettings["DBServer"].ToString());
                var DBName = NC.Models.Tools.StaticMethods.Decrypt(NC.Models.Tools.StaticMethods.ENCRYPTKEY, ConfigurationManager.AppSettings["DBName"].ToString());
                var DBUser = NC.Models.Tools.StaticMethods.Decrypt(NC.Models.Tools.StaticMethods.ENCRYPTKEY, ConfigurationManager.AppSettings["DBUser"].ToString());
                var DBPassword = NC.Models.Tools.StaticMethods.Decrypt(NC.Models.Tools.StaticMethods.ENCRYPTKEY, ConfigurationManager.AppSettings["DBPassword"].ToString());

                string ConnectionString1 = $"Data Source={DBServer}; ";
                ConnectionString1 += $"Initial Catalog={DBName};";
                ConnectionString1 += $"User id ={DBUser};";
                ConnectionString1 += $"Password ={DBPassword};";
                ConnectionString1 += " Min Pool Size=50;Max Pool Size=100;Pooling=true;";

                using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConnectionString1))
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {

                return false;
            }
        }

        /// <summary>
        /// این سه متد به منظور کنترل دسترسی به یک فرم صدا زده میشود و مقدار فالس یا صحیح را بر میگرداند
        /// </summary>
        /// <param name="Rolastring"></param>
        /// <param name="Index"></param>
        /// <returns></returns>
        public static bool IsNoAccess(string Rolastring, int Index)
        {
            if (JVMUser.LogedUser == null)
                return true;
            try
            {
                if (!(NC.Models.Tools.StaticMethods.VISITOR + NC.Models.Tools.StaticMethods.FULLCONTROL).Contains(Rolastring.Substring(Index, 1)))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public static bool IsReadOnly(string Rolastring, int Index)
        {
            if (JVMUser.LogedUser == null)
                return true;
            try
            {
                if ((NC.Models.Tools.StaticMethods.VISITOR + NC.Models.Tools.StaticMethods.FULLCONTROL).Contains(Rolastring.Substring(Index, 1)))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public static bool IsFullControl(string Rolastring, int Index)
        {
            if (JVMUser.LogedUser == null)
                return false;
            try
            {

                if (NC.Models.Tools.StaticMethods.FULLCONTROL.Contains(Rolastring.Substring(Index, 1)))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {

                return false;
            }

        }

        /// <summary>
        /// این متد در صدا زدن یوزر کنترل ها و نصب آنها در کنترل تب مورد استفاده قرار میگیرد
        /// </summary>
        /// <param name="tabControl"></param>
        //public static void Loading(TabControlItem tabControl)
        //{

        //    NC.Public.Statics.StaticVariables.JVMTabControlViewModel.TabControlItems.Add(tabControl);
        //    NC.Public.Statics.StaticVariables.JVMTabControlViewModel.TabControlItemsView = CollectionViewSource.GetDefaultView(NC.Public.Statics.StaticVariables.JVMTabControlViewModel.TabControlItems);
        //    NC.Public.Statics.StaticVariables.JVMTabControlViewModel.TabControlItemsView.Refresh();
        //    TabControl tb = Application.Current.MainWindow.FindName("TabControlMain") as TabControl;
        //    if (NC.Public.Statics.StaticVariables.JVMTabControlViewModel.TabControlItemsView.MoveCurrentToLast())
        //        tb.SelectedIndex = NC.Public.Statics.StaticVariables.JVMTabControlViewModel.TabControlItemsView.CurrentPosition;
        //    //tabControl.TabContent.Focus();


        //}
        private static void TxtBox_MouseEnter(object sender, EventArgs e)
        {
            TextBox txbox = (TextBox)sender;
            //   this.Dispatcher.Thread.CurrentCulture.Name.ToString();
            InputLanguageManager.SetInputLanguage(txbox, CultureInfo.CreateSpecificCulture("fa"));
        }
        private static void TxtBox_MouseLeave(object sender, EventArgs e)
        {
            TextBox txbox = (TextBox)sender;
            //   this.Dispatcher.Thread.CurrentCulture.Name.ToString();
            InputLanguageManager.SetInputLanguage(txbox, CultureInfo.CreateSpecificCulture("en"));
        }






    }
}
