using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebHangHoa.Model;

public partial class SanPham
{
    public int ProductId { get; set; }

    public string? TenSanPham { get; set; }

    public string? MoTa { get; set; }

    public decimal? Gia { get; set; }

    public int? SoLuongTonKho { get; set; }

    public int? CategoryId { get; set; }

    public string? Anh { get; set; }

    public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; } = new List<ChiTietDonHang>();

    [NotMapped]
    public IFormFile ImageFile { get; set; }
}
