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
    
    public partial class Der
    {
        public int Id { get; set; }
        public string Ders_Adı { get; set; }
        public int Ders_Kredisi { get; set; }
        public int Okul_Yönetim_Id { get; set; }
        public int Ders_Rengi { get; set; }
    
        public virtual OgrenciDer OgrenciDer { get; set; }
        public virtual Personel Personel { get; set; }
    }
}
