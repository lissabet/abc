//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EEBank.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserInf
    {
        public int UserInfID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string AccountNumber { get; set; }
        public string ECP { get; set; }
        public Nullable<int> UserID { get; set; }
    
        public virtual Users Users1 { get; set; }
    }
}
