using System.Collections.Generic;
using CuaHangVatTu.Common.DAL;
using CuaHangVatTu.DAL.Models;
using System.Linq;

namespace CuaHangVatTu.DAL
{
    public class DonDHRep : GenericRep<QLVTContext, Dondh>
    {
        public DonDHRep()
        {
        }
        public List<Dondh> searchDonDH(int idDonDH)
        {
            return All.Where(x => x.Sodh == idDonDH).ToList();
        }
    }
}
