using CuaHangVatTu.DAL;
using CuaHangVatTu.Common.BLL;
using CuaHangVatTu.DAL.Models;
using CuaHangVatTu.Common.Response;
using CuaHangVatTu.Common.Request;
using System.Linq;
namespace CuaHangVatTu.BLL
{
    public class TonKhoServicecs : GenericService<TonKhoRep, Tonkho>
    {
        private TonKhoRep tonKhoRep;
        public TonKhoServicecs()
        {
            tonKhoRep = new TonKhoRep();
        }
        public SingleResponse SearchSlTonKhoByMaVT(int maVatTu)
        {
            var res = new SingleResponse();
            var tonKho = tonKhoRep.searchSLTonKho(maVatTu);
            res.Data = tonKho;
            return res;

        }
    }
}
