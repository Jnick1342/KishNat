using NC.Models.DBModels;

using System;
using System.IO;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace NC.Models.Tools
{
    public static class StaticMethods
    {

        public static string ACCMASK;
        public static string TAFSMASK;
        public static string MARMASK;
        public static string BANKMASK="xxx";

        public static string ENCRYPTKEY = "Nickooie";
        public static string GROUPSANAD = "10";

        public static string SUPERVISOR = "admin";
        public static string FULLCONTROL = "2";
        public static string VISITOR = "1";
        public static string NOACCESS = "0";

        public static int Z0 = 0;


        public static int C0 = 0;
        public static int C1 = 1;
        public static int C2 = 2;
        public static int C3 = 3;
        public static int C4 = 4;
        public static int C5 = 5;
        public static int C6 = 6;
        public static int C7 = 7;
        public static int C8 = 8;
        public static int C9 = 9;
        public static int C10 = 10;
        public static int C11 = 11;
        public static int C12 = 12;


        public static int A0 = 0;

        public static int B0 = 0;
        public static int B1 = 1;
        public static int B2 = 2;
        public static int B3 = 3;
        public static int B4 = 4;
        public static int B5 = 5;
        public static int B6 = 6;

        public static int B13 = 7;
        public static int B14 = 8;
        public static int B15 = 9;
        public static int B16 = 10;

        public static int B23 = 11;
        public static int B24 = 12;
        public static int B25 = 13;
        public static int B26 = 14;

        public static int B7 = 15;
        

        public static string GetCPUId()
        {
            string cpuInfo = string.Empty;
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();

            foreach (ManagementObject mo in moc)
            {
                cpuInfo = mo.Properties["processorID"].Value.ToString();
                break;
            }
            return cpuInfo;
        }
        public static string GetHDDId()
        {
            string drive = "C";
            ManagementObject dsk = new ManagementObject(
                @"win32_logicaldisk.deviceid=""" + drive + @":""");
            dsk.Get();
            string volumeSerial = dsk["VolumeSerialNumber"].ToString();
            return volumeSerial;
        }

        public static string Encrypt(string key, string plaintext)
        {
            try
            {
                string textToEncrypt = plaintext;
                string ToReturn = "";
                string publickey = NC.Models.Tools.StaticMethods.ENCRYPTKEY;
                string secretkey = key;
                byte[] secretkeyByte = { };
                secretkeyByte = System.Text.Encoding.UTF8.GetBytes(secretkey);
                byte[] publickeybyte = { };
                publickeybyte = System.Text.Encoding.UTF8.GetBytes(publickey);
                MemoryStream ms = null;
                CryptoStream cs = null;
                byte[] inputbyteArray = System.Text.Encoding.UTF8.GetBytes(textToEncrypt);
                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {
                    ms = new MemoryStream();
                    cs = new CryptoStream(ms, des.CreateEncryptor(publickeybyte, secretkeyByte), CryptoStreamMode.Write);
                    cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cs.FlushFinalBlock();
                    ToReturn = Convert.ToBase64String(ms.ToArray());
                }
                return ToReturn;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        public static string Decrypt(string key, string plaintext)
        {
            if (string.IsNullOrEmpty(plaintext))
                return "";
            try
            {
                string textToDecrypt = plaintext;
                string ToReturn = "";
                string publickey = NC.Models.Tools.StaticMethods.ENCRYPTKEY;
                string privatekey = key;
                byte[] privatekeyByte = { };
                privatekeyByte = System.Text.Encoding.UTF8.GetBytes(privatekey);
                byte[] publickeybyte = { };
                publickeybyte = System.Text.Encoding.UTF8.GetBytes(publickey);
                MemoryStream ms = null;
                CryptoStream cs = null;
                byte[] inputbyteArray = new byte[textToDecrypt.Replace(" ", "+").Length];
                inputbyteArray = Convert.FromBase64String(textToDecrypt.Replace(" ", "+"));
                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {
                    ms = new MemoryStream();
                    cs = new CryptoStream(ms, des.CreateDecryptor(publickeybyte, privatekeyByte), CryptoStreamMode.Write);
                    cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cs.FlushFinalBlock();
                    Encoding encoding = Encoding.UTF8;
                    ToReturn = encoding.GetString(ms.ToArray());
                }
                return ToReturn;
            }
            catch (Exception ae)
            {
                throw new Exception(ae.Message, ae.InnerException);
            }
        }



        public static void CbasicinfoMap(CBasicInfo cBasicInfo1, CBasicInfo cBasicInfo2)
        {
            cBasicInfo1.Id = cBasicInfo2.Id;
            cBasicInfo1.Name = cBasicInfo2.Name;
            cBasicInfo1.Status = cBasicInfo2.Status;

            cBasicInfo1.DConfirmEnd = cBasicInfo2.DConfirmEnd;
            cBasicInfo1.DConfirmStart = cBasicInfo2.DConfirmStart;
            cBasicInfo1.DEnd = cBasicInfo2.DEnd;
            cBasicInfo1.DStart = cBasicInfo2.DStart;
            cBasicInfo1.DOperationEnd = cBasicInfo2.DOperationEnd;
            cBasicInfo1.DOperationStart = cBasicInfo2.DOperationStart;
        }


        public static void ZUserMap(ZUser item1, ZUser item2)
        {
            item1.UserId = item2.UserId;
            item1.Name = item2.Name;
            item1.Position = item2.Position;
            item1.IsActive = item2.IsActive;
            item1.Password = item2.Password;
            item1.RolesInSystemA = item2.RolesInSystemA;
            item1.RolesInSystemB = item2.RolesInSystemB;
            item1.RolesInSystemC = item2.RolesInSystemC;
            item1.RolesInSystemZ = item2.RolesInSystemZ;
            item1.AccessToSystems = item2.AccessToSystems;
        }

    }
}


