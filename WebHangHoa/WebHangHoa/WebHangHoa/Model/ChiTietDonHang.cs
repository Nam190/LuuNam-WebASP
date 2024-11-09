using System;
using System.Collections.Generic;

namespace WebHangHoa.Model;

public partial class ChiTietDonHang
{
    public int OrderDetailId { get; set; }

    public int? OrderId { get; set; }

    public int? ProductId { get; set; }

    public int? SoLuong { get; set; }

    public decimal? Gia { get; set; }

    public virtual DonHang? Order { get; set; }

    public virtual SanPham? Product { get; set; }
}
