using System;
using System.Collections.Generic;

namespace WebHangHoa.Model;

public partial class DonHang
{
    public int OrderId { get; set; }

    public int? CustomerId { get; set; }

    public DateTime? NgayDatHang { get; set; }

    public decimal? TongGia { get; set; }

    public byte? TrangThai { get; set; }

    public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; } = new List<ChiTietDonHang>();

    public virtual KhachHang? Customer { get; set; }
}
