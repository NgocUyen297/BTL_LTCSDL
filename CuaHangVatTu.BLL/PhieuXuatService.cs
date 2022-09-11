using CuaHangVatTu.DAL;
using CuaHangVatTu.Common.BLL;
using CuaHangVatTu.DAL.Models;
using CuaHangVatTu.Common.Response;
using CuaHangVatTu.Common.Request;
using System.Linq;
namespace CuaHangVatTu.BLL
{
    public class PhieuXuatService : GenericService<PhieuXuatRep, Phieuxuat>
    {
        private PhieuXuatRep phieuXuatRep;
        public PhieuXuatService()
        {
            phieuXuatRep = new PhieuXuatRep();
        }
        public SingleResponse SearchPhieuXuatBySoPX(SearchPhieuXuatRequest Sopx)
        {
            var res = new SingleResponse();
            var phieuxuats = phieuXuatRep.searchPhieuXuat(Sopx.SoPx);
            res.Data = phieuxuats;
            return res;

        }
    }
}
