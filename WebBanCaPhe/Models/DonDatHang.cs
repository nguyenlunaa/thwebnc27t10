//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBanCaPhe.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DonDatHang
    {
        public string MaDDH { get; set; }
        public Nullable<System.DateTime> NgayDat { get; set; }
        public string TinhTrangGiao { get; set; }
        public Nullable<System.DateTime> NgayGiao { get; set; }
        public string DaThanhToan { get; set; }
        public string MaKH { get; set; }
        public string MaGiamGia { get; set; }
    
        public virtual ChiTietDonHang ChiTietDonHang { get; set; }
        public virtual KhachHang KhachHang { get; set; }
    }
}