//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AsiaDrama_api.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comments
    {
        public int IdComments { get; set; }
        public int idUsers { get; set; }
        public int idKinoandSerial { get; set; }
        public string Comments1 { get; set; }
    
        public virtual KinoAndSerial KinoAndSerial { get; set; }
        public virtual Users Users { get; set; }
    }
}
