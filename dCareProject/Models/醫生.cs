//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace dCareProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class 醫生
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 醫生()
        {
            this.預約表 = new HashSet<預約表>();
        }
    
        public int ID { get; set; }
        public string 帳號 { get; set; }
        public string 密碼 { get; set; }
        public string 姓名 { get; set; }
        public string 電話 { get; set; }
        public string 科別 { get; set; }
        public string 診所名稱 { get; set; }
        public string 診所地址 { get; set; }
        public string 服務時段 { get; set; }
        public string 圖片 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<預約表> 預約表 { get; set; }
    }
}
