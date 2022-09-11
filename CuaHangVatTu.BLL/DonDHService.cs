using CuaHangVatTu.DAL;
using CuaHangVatTu.Common.BLL;
using CuaHangVatTu.DAL.Models;
using CuaHangVatTu.Common.Response;
using CuaHangVatTu.Common.Request;
using System.Linq;
namespace CuaHangVatTu.BLL
{
    public class DonDHService : GenericService<DonDHRep, Dondh>
    {
        private DonDHRep donDHRep;
        public DonDHService()
        {
            donDHRep = new DonDHRep();
        }
        public SingleResponse SearchDonDHBySoDH(int Sopx)
        {
            var res = new SingleResponse();
            var donHangs = donDHRep.searchDonDH(Sopx);
            res.Data = donHangs;
            return res;

        }
    }
}
