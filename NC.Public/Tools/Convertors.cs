using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using static NC.Models.Tools.Enums;

namespace NC.Public.Tools
{
    public class SwitchVisibility : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((Visibility)value == Visibility.Visible)
                return Visibility.Collapsed;
            else
                return Visibility.Visible;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class EnumToArrayConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return Enum.GetValues(value.GetType());
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null; // I don't care about this
        }
    }




    public class BooleanToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var bvalue = (bool)value;
            if (bvalue)
            {
                return Visibility.Visible;
            }
            else
            {
                return Visibility.Collapsed;
            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null; // I don't care about this
        }
    }



    public class AccEndToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            LayerEnd bvalue = (LayerEnd)value;
            if (bvalue.Equals(LayerEnd.بلی))
            {
                return Visibility.Collapsed;
            }
            else
            {
                return Visibility.Visible;
            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null; // I don't care about this
        }
    }


    public class AccCodeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            LayerEnd bvalue = (LayerEnd)value;
            if (bvalue.Equals(LayerEnd.بلی))
            {
                return Visibility.Collapsed;
            }
            else
            {
                return Visibility.Visible;
            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null; // I don't care about this
        }
    }





    public class UserAccessVisibilityConvert : IValueConverter
    {


        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {

            string SystemCode = parameter.ToString();
            if (NC.Public.Statics.StaticVariables.JVMUser.LogedUser == null)
                return Visibility.Collapsed;
            else
                 if (NC.Public.Statics.StaticVariables.JVMUser.LogedUser.AccessToSystems.Contains(SystemCode))
                return Visibility.Visible;
            else
                return Visibility.Collapsed;
        }


        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }


    }

    public class UserVisibilityConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {

            string par = parameter.ToString();

            switch (par)
            {
                case "Login":
                    {
                        return NC.Public.Statics.StaticVariables.JVMUser.LogedUser == null ? Visibility.Visible : (object)Visibility.Collapsed;
                    }
                case "Logout":
                    {
                        return NC.Public.Statics.StaticVariables.JVMUser.LogedUser == null ? Visibility.Collapsed : (object)Visibility.Visible;
                    }
                case "A":
                    {

                        return NC.Public.Statics.StaticVariables.JVMUser.LogedUser == null
                            ? Visibility.Collapsed
                            : NC.Public.Statics.StaticVariables.JVMUser.LogedUser.AccessToSystems.Contains("A") ? Visibility.Visible : (object)Visibility.Collapsed;

                    }
                case "B":
                    {

                        return NC.Public.Statics.StaticVariables.JVMUser.LogedUser == null
                            ? Visibility.Collapsed
                            : NC.Public.Statics.StaticVariables.JVMUser.LogedUser.AccessToSystems.Contains("B") ? Visibility.Visible : (object)Visibility.Collapsed;

                    }
                case "C":
                    {

                        return NC.Public.Statics.StaticVariables.JVMUser.LogedUser == null
                            ? Visibility.Collapsed
                            : NC.Public.Statics.StaticVariables.JVMUser.LogedUser.AccessToSystems.Contains("C") ? Visibility.Visible : (object)Visibility.Collapsed;

                    }
                case "Z":
                    {

                        return NC.Public.Statics.StaticVariables.JVMUser.LogedUser == null
                            ? Visibility.Collapsed
                            : NC.Public.Statics.StaticVariables.JVMUser.LogedUser.AccessToSystems.Contains("Z") ? Visibility.Visible : (object)Visibility.Collapsed;

                    }
                default:
                    {

                        if (NC.Public.Statics.StaticVariables.JVMUser.LogedUser == null)
                            return Visibility.Collapsed;
                        else
                        {
                            string[] authorsList = Public.Statics.StaticVariables.JVMUser.LogedUser.RolesInSystemA.Split();
                            int Index = int.Parse(par);
                            UserAccessPriority u = (UserAccessPriority)int.Parse(authorsList[Index]);
                            switch (u)
                            {
                                case UserAccessPriority.عدم_دسترسی:
                                    return Visibility.Collapsed;
                                case UserAccessPriority.کنترل_کامل:
                                    return Visibility.Visible;
                                case UserAccessPriority.نمایش:
                                    return Visibility.Visible;
                                default:
                                    return Visibility.Collapsed;
                            }

                        }
                    }
            }

        }


        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }


    }


    public class UserAccessFullControlToBooleanConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            int Index = int.Parse(parameter.ToString());
            //string access = value.ToString();
            return NC.Public.Statics.StaticVariables.IsFullControl(value.ToString(), Index);
            //int par = int.Parse(parameter.ToString());

            //string access = value.ToString();
            //if (NC.Public.Statics.StaticVariables.JVMUser.LogedUser == null)
            //    return false;
            //else
            //{
            //    char[] authorsList = access.ToCharArray();
            //    UserAccessPriority u = (UserAccessPriority)int.Parse(authorsList[par].ToString());
            //    switch (u)
            //    {
            //        case UserAccessPriority.کنترل_کامل:
            //            return true;
            //    }
            //    return false;
            //}
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
    
 

    public class UserAccessReadOnlyToBooleanConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {

            int Index = int.Parse(parameter.ToString());
            //    string access = value.ToString();
            return NC.Public.Statics.StaticVariables.IsReadOnly(value.ToString(), Index);

            //if (NC.Public.Statics.StaticVariables.JVMUser.LogedUser == null)
            //    return false;
            //else
            //{
            //    char[] authorsList = access.ToCharArray();
            //    UserAccessPriority u = (UserAccessPriority)int.Parse(authorsList[par].ToString());
            //    switch (u)
            //    {
            //        case UserAccessPriority.نمایش:
            //            return true;
            //        case UserAccessPriority.کنترل_کامل:
            //            return true;
            //    }
            //    return false;
            //}
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }


    }

    public class UserAccessNoAccessToBooleanConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            int Index = int.Parse(parameter.ToString());
            //string access = value.ToString();
            return NC.Public.Statics.StaticVariables.IsNoAccess(value.ToString(), Index);


            //int par = int.Parse(parameter.ToString());
            //string access = value.ToString();

            //if (NC.Public.Statics.StaticVariables.JVMUser.LogedUser == null)
            //    return true;
            //else
            //{
            //    char[] authorsList = access.ToCharArray();
            //    UserAccessPriority u = (UserAccessPriority)int.Parse(authorsList[par].ToString());
            //    switch (u)
            //    {
            //        case UserAccessPriority.عدم_دسترسی :
            //            return false;
            //    }
            //    return true;
            // }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
