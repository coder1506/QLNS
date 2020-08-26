using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using MODEL;
namespace BLL
{
    public class XuLiNV
    {
        public DataTable hienThiBangTt()
        {
            DataProviderForE dpe = new DataProviderForE();
            string sql = "SELECT * FROM TTCaNhan";
            return dpe.getDataTable(sql);
        }
        public DataTable hienThiBangCb()
        {
            DataProviderForE dpe = new DataProviderForE();
            string sql = "SELECT * FROM TTNVCoBan";
            return dpe.getDataTable(sql);
        }
        public DataTable HienThiTv()
        {
            DataProviderForE dpe = new DataProviderForE();
            string sql = "SELECT * FROM HoSoNVThuViec";
            return dpe.getDataTable(sql);
        }
        public DataTable hienThiPB()
        {
            DataProviderForE dpe = new DataProviderForE();
            string sql = "SELECT * FROM PhongBan";
            return dpe.getDataTable(sql);
        }
        public DataTable hienThiL()
        {
            DataProviderForE dpe = new DataProviderForE();
            string sql = "SELECT * FROM BangLuongCongTy";
            return dpe.getDataTable(sql);
        }
        public DataTable bangMaNVTt()
        {
            DataProviderForE dpe = new DataProviderForE();
            string sql = "SELECT MaNV FROM TTCanhan";
            return dpe.getDataTableManv(sql);
        }
        public DataTable bangMaNVCb()
        {
            DataProviderForE dpe = new DataProviderForE();
            string sql = "SELECT MaNV FROM TTNVCoBan";
            return dpe.getDataTableManv(sql);
        }
        public Boolean themNV(string maNV, string maPB, string hoTen, string maLuong, DateTime ngaySinh, string gioiTinh, string cmt, DateTime ngayCap, string noiCap, string chucVu, int thoiGianLamViec, DateTime ngayKy, DateTime ngayHetHan, string tinhTrangHD)
        {
            DataProviderForE dpe = new DataProviderForE();
            TTCoBan TT = new TTCoBan(maNV, maPB, hoTen, maLuong, ngaySinh, gioiTinh, cmt, ngayCap, noiCap, chucVu, thoiGianLamViec, ngayKy, ngayHetHan, tinhTrangHD);
            string sql = "INSERT INTO TTNVCoBan VALUES(@MaNV,@MaPB,@HoTen,@MaLuong,@NgaySinh,@gt,@cmt,@Ngc,@nc,@Cv,@TG,@Nk,@Nhh,@Tthd)";
            return dpe.insert(TT,sql);
        }
        public Boolean themNVTV(string maNV, string maPB, string hoTen, DateTime ngaySinh, string gioiTinh, string diaChi, string viTri, int soThang, DateTime ngayBatDau, DateTime ngayHetHan, string trinhDo)
        {
            DataProviderForE dpe = new DataProviderForE();
            NVThuViec TT = new NVThuViec( maNV,  maPB,  hoTen,  ngaySinh,  gioiTinh,  diaChi,  viTri,  soThang,  ngayBatDau,  ngayHetHan, trinhDo);
            string sql = "INSERT INTO HoSoNVThuViec VALUES(@maNV,@maPB,@hoTen,@gioiTinh,@ngaySinh,@diaChi,@viTri,@soThang,@ngayBatDau,@ngayHetHan,@trinhDo)";
            return dpe.insert(TT, sql);
        }

        public DataTable search(string manv)
        {
            DataProviderForE dpe = new DataProviderForE();
            string sql = "SELECT * FROM TTCanhan WHERE MaNV LIKE @MaNV";
            return dpe.getDataTableManv2(manv,sql);
        }
        public DataTable search1(string manv)
        {
            DataProviderForE dpe = new DataProviderForE();
            string sql = "SELECT * FROM TTNVCoBan WHERE MaNV LIKE @MaNV";
            return dpe.getDataTableManv2(manv, sql);
        }
        public DataTable search2(string manv)
        {
            DataProviderForE dpe = new DataProviderForE();
            string sql = "SELECT * FROM HoSoNVThuViec WHERE MaNVTV LIKE @MaNV";
            return dpe.getDataTableManv2(manv, sql);
        }
        
        public Boolean capNhat(string manv, string txtBc, string txtDctamc, string txtDctc, string txtDt, string txtht, string txtNs, string txtQt, string txtSdt, string txtTg, string ns, string gt)
        {
            DataProviderForE dpe = new DataProviderForE();
            string sql = "UPDATE TTCaNhan Set MaNV = @MaNV,HoTen= @ht,NgaySinh = @Ngs,GioiTinh = @gt," +
                    "NoiSinh = @ns,Dctamtru = @dctt,DCThuongChu = @dctht,DanToc = @dt ,TonGiao = @tg,QuocTich =@qt,BangCap = @bc,SDT = @sdt Where  MaNV = @MaNV";
            string sqlCheck = "SELECT MaNV FROM TTCanhan WHERE MaNV = @MaNV";
            if (dpe.getDataTableManv1(manv, sqlCheck).Rows.Count > 0)
                return dpe.update(new TTCaNhan(manv, txtht,DateTime.Parse(ns), gt, txtNs, txtDctamc, txtDctc, txtDt, txtTg, txtQt, txtBc, txtSdt),sql);
            else return false;
        }
        public Boolean themTTCN(string manv, string txtBc, string txtDctamc, string txtDctc, string txtDt, string txtht, string txtNs, string txtQt, string txtSdt, string txtTg, string ns, string gt)
        {
            DataProviderForE dpe = new DataProviderForE();
            string sql = "INSERT INTO TTCaNhan VALUES(@MaNV,@ht,@Ngs,@gt,@ns,@dctt,@dctht,@dt,@tg,@qt,@bc,@sdt)";
            string sqlCheck = "SELECT MaNV FROM TTCanhan WHERE MaNV = @MaNV";
            return dpe.update(new TTCaNhan(manv, txtht, DateTime.Parse(ns), gt, txtNs, txtDctamc, txtDctc, txtDt, txtTg, txtQt, txtBc, txtSdt), sql);
        }
        public Boolean capNhat1(string maNV, string maPB, string hoTen, DateTime ngaySinh, string gioiTinh, string diaChi, string viTri, int soThang, DateTime ngayBatDau, DateTime ngayHetHan, string trinhDo)
        {
            DataProviderForE dpe = new DataProviderForE();
            string sql = "UPDATE HoSoNVThuViec Set MaPB= @maPB,HoTen = @hoTen,GioiTinh = @gioiTinh," +
                    "NgaySinh = @NgaySinh,DiaChi = @diaChi,viTriTV = @viTri,SoThangTV = @soThang,NgayBatDau = @ngayBatDau ,NgayHetHan = @ngayHetHan,TrinhDo =@trinhDo WHERE MaNVTV = @MaNV";
            string sqlCheck = "SELECT * FROM HoSoNVThuViec WHERE MaNVTV = @MaNV";
            if (dpe.getDataTableManv1(maNV, sqlCheck).Rows.Count > 0)
                return dpe.update(new NVThuViec( maNV,  maPB,  hoTen,  ngaySinh,  gioiTinh,  diaChi,  viTri,  soThang,  ngayBatDau,  ngayHetHan, trinhDo), sql);
            else return false;
        }

        public Boolean xoa(string manv)
        {
            DataProviderForE dpe = new DataProviderForE();
            string sqlCheck = "SELECT MaNV FROM TTCanhan WHERE MaNV = @MaNV";
            string sqlStr = "DELETE FROM TTCaNhan WHERE MaNV = @key";
            if (dpe.getDataTableManv1(manv, sqlCheck).Rows.Count > 0) return dpe.delete(manv, sqlStr);
            else return false;
        }
        public Boolean xoa2(string manv)
        {
            DataProviderForE dpe = new DataProviderForE();
            string sqlCheck = "SELECT * FROM HoSoNVThuViec WHERE MaNVTV = @MaNV";
            string sqlStr = "DELETE FROM HoSoNVThuViec WHERE MaNVTV = @key";
            if (dpe.getDataTableManv1(manv, sqlCheck).Rows.Count > 0) return dpe.delete(manv, sqlStr);
            else return false;
        }
        public Boolean xoa1(string manv)
        {
            DataProviderForE dpe = new DataProviderForE();
            string sqlCheck = "SELECT * FROM TTNVCoBan WHERE MaNV = @MaNV";
            string sqlStr = "DELETE FROM TTNVCoBan WHERE MaNV = @key";
            if (dpe.getDataTableManv1(manv, sqlCheck).Rows.Count > 0) return dpe.delete(manv, sqlStr);
            else return false;
        }
        public Boolean Sua(string maNV, string maPB, string hoTen, string maLuong, DateTime ngaySinh, string gioiTinh, string cmt, DateTime ngayCap, string noiCap, string chucVu, int thoiGianLamViec, DateTime ngayKy, DateTime ngayHetHan, string tinhTrangHD)
        {
            DataProviderForE dpe = new DataProviderForE();
            string sqlCheck = "SELECT MaNV FROM TTNVCoBan WHERE MaNV = @MaNV";
            string sqlStr = "UPDATE TTNVCoBan SET HoTen = @ht,NgaySinh = @ngs,GioiTinh = @gt,CMTND = @cmt,NgayCap =@ngc,NoiCap = @nc,ChucVu = @cv,ThoiGianLamViec = @tg,NgayKy = @nk,NgayHetHan = @nhh,TinhTrangHD = @tthd WHERE MaNV = @MaNV";
            if (dpe.getDataTableManv1(maNV, sqlCheck).Rows.Count > 0) return dpe.update(new TTCoBan(maNV, maPB, hoTen, maLuong, ngaySinh, gioiTinh, cmt, ngayCap, noiCap, chucVu, thoiGianLamViec, ngayKy, ngayHetHan, tinhTrangHD), sqlStr);
            else return false;
        }
    }
}
