

using NC.Models.DBModels;
using NC.Public;
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
    public class DataBaseSetupModelView : BaseViewModel
    {
        #region private
        private Window mWindow;
        private string mDBUser = "admin";
        private string mDBPassword = "345345345";
        private string mDBServer = "555555";
        private string mDBName = "345345345";
        private string mDBConnectionString = "345345345";
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
        private void ModifyConnectionString(string name, string connectionString)
        {
            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var section = (ConnectionStringsSection)config.GetSection("connectionStrings");
                section.ConnectionStrings[name].ConnectionString = connectionString;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("connectionStrings");
            }
            catch (Exception ex)
            {

                throw ex;
            }
         
        }

        #endregion
        #region public
        public string DBUser { get => mDBUser; set { mDBUser = value; ConfirmTest = false; OnPropertyChanged(nameof(DBUser)); } }
        public string DBPassword { get => mDBPassword; set { mDBPassword = value; ConfirmTest = false; OnPropertyChanged(nameof(DBPassword)); } }
        public string DBName { get => mDBName; set { mDBName = value; ConfirmTest = false; OnPropertyChanged(nameof(DBName)); } }
        public string DBServer { get => mDBServer; set { mDBServer = value; ConfirmTest = false;  OnPropertyChanged(nameof(DBServer)); } }
        public string DBConnectionString { get => mDBConnectionString; set { mDBConnectionString = value; OnPropertyChanged(nameof(DBConnectionString)); } }
        public bool ConfirmTest { get => mConfirmTest; set { mConfirmTest = value; OnPropertyChanged(nameof(ConfirmTest)); } }


        #endregion
        #region Commands
        public ICommand DBTestCommand { get; set; }
        public ICommand DBSaveCommand { get; set; }



        #endregion
        #region Constructor
        public DataBaseSetupModelView(Window window)
        {
           
            
            var r = ConfigurationManager.AppSettings["DBServer"].ToString();
            DBServer = NC.Models.Tools.StaticMethods.Decrypt(NC.Models.Tools.StaticMethods.ENCRYPTKEY, r);
            DBName = NC.Models.Tools.StaticMethods.Decrypt(NC.Models.Tools.StaticMethods.ENCRYPTKEY, ConfigurationManager.AppSettings["DBName"].ToString());
            DBUser = NC.Models.Tools.StaticMethods.Decrypt(NC.Models.Tools.StaticMethods.ENCRYPTKEY, ConfigurationManager.AppSettings["DBUser"].ToString());
            DBPassword = NC.Models.Tools.StaticMethods.Decrypt(NC.Models.Tools.StaticMethods.ENCRYPTKEY, ConfigurationManager.AppSettings["DBPassword"].ToString());

            mWindow = window;
            mWindow.StateChanged += (sender, e) =>
            {
                OnPropertyChanged(nameof(DBUser));
                OnPropertyChanged(nameof(DBPassword));
                OnPropertyChanged(nameof(DBName));
                OnPropertyChanged(nameof(DBServer));
                OnPropertyChanged(nameof(DBConnectionString));
                OnPropertyChanged(nameof(ConfirmTest));


            };
          
            DBTestCommand = new RelayCommand(() =>
            {

                string ConnectionString = $"Data Source={DBServer}; ";
                ConnectionString += (string.IsNullOrEmpty(DBUser) ? "" : string.Format("User id={0}; ", DBUser));
                ConnectionString += (string.IsNullOrEmpty(DBPassword) ? "" : string.Format("Password={0}; ", DBPassword));
                ConnectionString += " Min Pool Size=50;Max Pool Size=100;Pooling=true;Connect Timeout=5";
                using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConnectionString))
                {
                    try
                    {
                      
                        conn.Open();
                        ConfirmTest = true;
                        NC.Public.WMessage win = new WMessage("تایید","ارتباط با سرور با موفقیت انجام شد ",  Visibility.Collapsed);
                        win.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        ConfirmTest = false;
                        NC.Public.WMessage win = new WMessage("خطا ", ex.Message, Visibility.Collapsed);
                        win.ShowDialog();

                    }
                    
                }
                OnPropertyChanged(nameof(ConnectionString));
            });
            DBSaveCommand = new RelayCommand(() =>
            {
                try
                {
                    

                    string ConnectionString = $"Data Source={DBServer}; " + $"Initial Catalog={DBName}; ";
                    ConnectionString += (string.IsNullOrEmpty(DBUser) ? "" : string.Format("User id={0}; ", DBUser));
                    ConnectionString += (string.IsNullOrEmpty(DBPassword) ? "" : string.Format("Password={0}; ", DBPassword));
                    ConnectionString += " Min Pool Size=20;Max Pool Size=100;Pooling=true;";
                   
                    SetAppSetring("DBServer", NC.Models.Tools.StaticMethods.Encrypt(NC.Models.Tools.StaticMethods.ENCRYPTKEY, DBServer));
                    SetAppSetring("DBName", NC.Models.Tools.StaticMethods.Encrypt(NC.Models.Tools.StaticMethods.ENCRYPTKEY, DBName));
                    SetAppSetring("DBUser", NC.Models.Tools.StaticMethods.Encrypt(NC.Models.Tools.StaticMethods.ENCRYPTKEY, DBUser));
                    SetAppSetring("DbPassword", NC.Models.Tools.StaticMethods.Encrypt(NC.Models.Tools.StaticMethods.ENCRYPTKEY, DBPassword));

                    ModifyConnectionString("DBConnectionTotalSystem", NC.Models.Tools.StaticMethods.Encrypt(NC.Models.Tools.StaticMethods.ENCRYPTKEY, ConnectionString));
                    NC.Public.WMessage win = new WMessage("بانک اطلاعاتی", ".اطلاعات ذخیره شد ", Visibility.Collapsed);
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