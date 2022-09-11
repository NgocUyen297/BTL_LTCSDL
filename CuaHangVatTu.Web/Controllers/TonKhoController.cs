using Microsoft.AspNetCore.Mvc;
using CuaHangVatTu.BLL;
using CuaHangVatTu.Common.Request;
using CuaHangVatTu.Common.Response;

namespace CuaHangVatTu.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TonKhoController : ControllerBase
    {
        private TonKhoServicecs tonKhoServicecs;
        public TonKhoController()
        {
            tonKhoServicecs = new TonKhoServicecs();
        }
        [HttpPost("Tim-TonKho-by-MaVatTu")]
        public IActionResult SearchProduct([FromBody] int maVatTu)
        {
            var res = new SingleResponse();
            res = tonKhoServicecs.SearchSlTonKhoByMaVT(maVatTu);
            return Ok(res);
        }
    }
}
