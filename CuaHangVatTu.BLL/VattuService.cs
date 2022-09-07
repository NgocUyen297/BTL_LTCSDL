using CuaHangVatTu.DAL;
using CuaHangVatTu.Common.BLL;
using CuaHangVatTu.DAL.Models;
using CuaHangVatTu.Common.Response;
using CuaHangVatTu.Common.Request;
using System.Linq;

namespace CuaHangVatTu.BLL
{
    public class VattuService: GenericService<VattuRep,Vattu>
    {

        private VattuRep vattuRep;
        public VattuService()
        {
            vattuRep = new VattuRep();
        }
        public SingleResponse SearchVatTuByName(SearchVatTuRequest s)
        {
            var res = new SingleResponse();
            var vatTus = vattuRep.searchProduct(s.Keyword);
            int vatTuCount = vatTus.Count;
            int totalPage, offsetSize;
            offsetSize = s.Size * (s.Page - 1);
            totalPage = (vatTuCount % s.Size) == 0 ? (vatTuCount / s.Size) : (vatTuCount / s.Size) + 1;
            var p = new
            {
                Data = vatTus.Skip(offsetSize).Take(s.Size).ToList(),
                Page = s.Page,
                Size = s.Size
            };
            res.Data = p;
            return res;
        }
    }



}
