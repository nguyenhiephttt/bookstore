//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace doanmonhocweb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CTDATHANG
    {
        public int SoHD { get; set; }
        public int MaHangHoa { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<decimal> DonGia { get; set; }
        public Nullable<decimal> ThanhTien { get; set; }
    
        public virtual Sach Sach { get; set; }
        public virtual DATHANG DATHANG { get; set; }
    }
}
