using System.Collections.Generic;
using CuaHangVatTu.Common.DAL;
using CuaHangVatTu.DAL.Models;
using System.Linq;
namespace CuaHangVatTu.DAL
{
    public class PhieuNhapRep : GenericRep<QLVTContext, Phieunhap>
    {
        public PhieuNhapRep()
        {
        }
        public List<Phieunhap> searchPhieuNhap(int idPhieuNhap)
        {
            return All.Where(x => x.Sopn == idPhieuNhap).ToList();
        }
    }
}
