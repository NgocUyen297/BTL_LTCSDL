using System;
using System.Collections.Generic;
using CuaHangVatTu.Common.DAL;
using CuaHangVatTu.DAL.Models;
using System.Linq;

namespace CuaHangVatTu.DAL
{
    public class VattuRep : GenericRep<QLVTContext, Vattu>
    {
        public VattuRep()
        {
        }
        public List<Vattu> searchProduct(string keyword)
        {
            return All.Where(x => x.Tenvtu.Contains(keyword)).ToList();
        }

    }
}
