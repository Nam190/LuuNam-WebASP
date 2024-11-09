using System;
using System.Collections.Generic;

namespace WebHangHoa.Model;

public partial class QuanTri
{
    public string TaiKhoan { get; set; } = null!;

    public string? MatKhau { get; set; }

    public byte? TrangThai { get; set; }
}
