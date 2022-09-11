using System;
using System.Collections.Generic;
using CuaHangVatTu.Common.DAL;
using CuaHangVatTu.DAL.Models;
using System.Linq;
namespace CuaHangVatTu.DAL
{
    public class TonKhoRep : GenericRep<QLVTContext, Tonkho>
    {
        public TonKhoRep()
        {
        }
        public List<Tonkho> searchSLTonKho(int maVatTu)
        {
            return All.Where(x => x.Mavtu == maVatTu).ToList();
        }
    }
}
