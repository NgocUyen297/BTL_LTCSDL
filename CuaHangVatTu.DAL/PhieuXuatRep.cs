using System.Collections.Generic;
using CuaHangVatTu.Common.DAL;
using CuaHangVatTu.DAL.Models;
using System.Linq;

namespace CuaHangVatTu.DAL
{
    public class PhieuXuatRep : GenericRep<QLVTContext, Phieuxuat>
    {
        public PhieuXuatRep()
        {
        }
        public List<Phieuxuat> searchPhieuXuat(int idPhieuXuat)
        {

            return All.Where(x => x.Sopx == idPhieuXuat).ToList();
        }
    }
}
