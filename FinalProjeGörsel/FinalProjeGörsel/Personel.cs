//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalProjeGörsel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Personel
    {
        public int Id { get; set; }
        public string Ad_Soyad { get; set; }
        public string Görevi { get; set; }
        public int Yönetim_Tipi { get; set; }
    
        public virtual Der Der { get; set; }
    }
}
