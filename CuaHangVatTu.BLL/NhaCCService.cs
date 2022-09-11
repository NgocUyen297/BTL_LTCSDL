using CuaHangVatTu.DAL;
using CuaHangVatTu.Common.BLL;
using CuaHangVatTu.DAL.Models;
using CuaHangVatTu.Common.Response;
using CuaHangVatTu.Common.Request;
using System.Linq;

namespace CuaHangVatTu.BLL
{
    public class NhaCCService : GenericService<NhaCCRep, Nhacungcap>
    {
        private NhaCCRep nhaCCRep;
        public NhaCCService()
        {
            nhaCCRep = new NhaCCRep();
        }
        public SingleResponse SearchNhaCCByMaNCC(SearchNhaCCRequest NhaCC)
        {
            var res = new SingleResponse();
            var nhaCCs = nhaCCRep.searchNhaCC(NhaCC.Keyword);
            int NhaccCount = nhaCCs.Count;
            int totalPage, offsetSize;
            offsetSize = NhaCC.Size * (NhaCC.Page - 1);
            totalPage = (NhaccCount % NhaCC.Size) == 0 ? (NhaccCount / NhaCC.Size) : (NhaccCount / NhaCC.Size) + 1;
            var p = new
            {
                Data = nhaCCs.Skip(offsetSize).Take(NhaCC.Size).ToList(),
                Page = NhaCC.Page,
                Size = NhaCC.Size
            };
            res.Data = p;
            return res;
        }
    }
}
