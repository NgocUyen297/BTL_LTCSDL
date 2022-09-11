using Microsoft.AspNetCore.Mvc;
using CuaHangVatTu.BLL;
using CuaHangVatTu.Common.Request;
using CuaHangVatTu.Common.Response;


namespace CuaHangVatTu.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhaCCController : ControllerBase
    {
        private NhaCCService nhaCCService;
        public NhaCCController()
        {
            nhaCCService = new NhaCCService();
        }
        [HttpPost("Tim-nhaCC-by-maNhaCC")]
        public IActionResult SearchProduct([FromBody] SearchNhaCCRequest NhaCC)
        {
            var res = new SingleResponse();
            res = nhaCCService.SearchNhaCCByMaNCC(NhaCC);
            return Ok(res);
        }
    }
}
