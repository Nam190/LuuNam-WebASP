using System;
using System.Collections.Generic;

namespace WebHangHoa.Model;

public partial class KhachHang
{
    public int CustomerId { get; set; }

    public string? HoTen { get; set; }

    public string TaiKhoan { get; set; } = null!;

    public string? MatKhau { get; set; }

    public string? DiaChi { get; set; }

    public string? DienThoai { get; set; }

    public string Email { get; set; } = null!;

    public DateTime? NgaySinh { get; set; }

    public DateTime? NgayCapNhat { get; set; }

    public byte? GioiTinh { get; set; }

    public int? TichDiem { get; set; }

    public byte? TrangThai { get; set; }

    public virtual ICollection<DonHang> DonHangs { get; set; } = new List<DonHang>();
}
