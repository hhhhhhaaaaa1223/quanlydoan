//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyDeAn.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SinhVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SinhVien()
        {
            this.TienDoes = new HashSet<TienDo>();
        }
    
        public int IDSinhVien { get; set; }
        public string HoTen { get; set; }
        public string MSSV { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public string GioiTinh { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public Nullable<int> IDNhom { get; set; }
        public Nullable<int> status { get; set; }
    
        public virtual Nhom Nhom { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TienDo> TienDoes { get; set; }
    }
}
