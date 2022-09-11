using System.Collections.Generic;
using CuaHangVatTu.Common.DAL;
using CuaHangVatTu.DAL.Models;
using System.Linq;

namespace CuaHangVatTu.DAL
{
   public class NhaCCRep : GenericRep<QLVTContext, Nhacungcap>
    {
        public NhaCCRep()
        {
        }
        public List<Nhacungcap> searchNhaCC(string TenNhaCC)
        {
            return All.Where(x => x.Tennhacc.Contains(TenNhaCC)).ToList();
        }
    }
}
