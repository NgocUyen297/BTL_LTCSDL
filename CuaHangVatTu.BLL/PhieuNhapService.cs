using CuaHangVatTu.DAL;
using CuaHangVatTu.Common.BLL;
using CuaHangVatTu.DAL.Models;
using CuaHangVatTu.Common.Response;
using CuaHangVatTu.Common.Request;
using System.Linq;

namespace CuaHangVatTu.BLL
{
    public class PhieuNhapService : GenericService<PhieuNhapRep, Phieunhap>
    {
        private PhieuNhapRep phieuNhapRep;
        public PhieuNhapService()
        {
            phieuNhapRep = new PhieuNhapRep();
        }
        public SingleResponse SearchPhieuNhapBySoPX(int Sopx)
        {
            var res = new SingleResponse();
            var phieuNhaps = phieuNhapRep.searchPhieuNhap(Sopx);
            res.Data = phieuNhaps;
            return res;

        }
    }
}
