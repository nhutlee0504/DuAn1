//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyShopDongHo
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietSanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChiTietSanPham()
        {
            this.DonHangs = new HashSet<DonHang>();
        }
    
        public string LoaiSP { get; set; }
        public string TenLoai { get; set; }
        public int MaSP { get; set; }
        public double GiaBan { get; set; }
        public Nullable<double> KhuyenMai { get; set; }
        public string MoTa { get; set; }
    
        public virtual SanPham SanPham { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonHang> DonHangs { get; set; }
    }
}