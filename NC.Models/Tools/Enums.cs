using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC.Models.Tools
{
        public class Enums
        {
            public enum KindsOfSanads { افتتاحیه, عملکرد, عادی, اختتامیه, تنتقالی };
            public enum Actions { Success, Error, Fatal };
            public enum LayerEnd { خیر, بلی };
            public enum JEnumMessageBox { OK, Confirm }
            public enum UserStatus { فعال, غیرفعال, حذف }

            public enum UpdateRecordStatus { Insert, Update, Delete, Readonly }
            public enum UserAccessPriority { عدم_دسترسی, نمایش, کنترل_کامل }

            public enum DorehMaliStatus { باز, بسته };

            public enum AsnadPardakhtaniStatus { Free, Void, Used };
            public enum GhabzDaryafts { DaryaftBank, PardakhtBank, PardakhtAsnad, DaryaftAsnad };
            public enum KartablStatus { Register, Waiting_For_Confirm, Denied, Confirm_For_print, Waiting_For_Accounting, Accountent, Close, Delete };
    }
}
