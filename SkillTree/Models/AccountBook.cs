//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SkillTree.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public partial class AccountBook
    {
        public System.Guid Id { get; set; }
        [Display(Name = "類型")]
        public int Categoryyy { get; set; }
        [Display(Name = "金額")]
        public int Amounttt { get; set; }
        [Display(Name = "日期")]
        public System.DateTime Dateee { get; set; }
        [Display(Name = "註記")]
        public string Remarkkk { get; set; }
    }
}
