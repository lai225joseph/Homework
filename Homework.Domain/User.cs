using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Domain
{
    /// <summary>
    /// 使用者
    /// </summary>
    public class User
    {
        /// <summary>
        /// 使用者ID
        /// </summary>
        public Guid UserID { get; set; }
        /// <summary>
        /// 使用者名稱
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 使用者密碼
        /// </summary>
        public string Passwork { get; set; }
        /// <summary>
        /// 使用者生日
        /// </summary>
        public DateTime Birthday { get; set; }
        /// <summary>
        /// 使用者帳號
        /// </summary>
        public string UserEmailAddress { get; set; }
    }
}
