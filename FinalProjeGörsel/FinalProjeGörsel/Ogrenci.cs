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
    
    public partial class Ogrenci
    {
        public int Id { get; set; }
        public string Ad_Soyad { get; set; }
        public System.DateTime Kayıt_Tarihi { get; set; }
        public string Öğrenci_No { get; set; }
        public System.DateTime Doğum_Tarihi { get; set; }
        public string Bölümü { get; set; }
    
        public virtual OgrenciDer OgrenciDer { get; set; }
    }
}
