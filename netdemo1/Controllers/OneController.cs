using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using netdemo1.BLL;

namespace netdemo1.Controllers
{
    /// <summary>
    /// 第四步：创建控制器
    /// </summary>
    [Route("")]
    [ApiController]
    public class OneController : ControllerBase
    {
        /// <summary>
        /// 第十步：创建方法，UI->BLL>DAL 竟然还需要依赖注入？
        /// </summary>
        /// <returns>List<OneModel></returns>
        private readonly IOneBLL _oneBLL;

        public OneController(IOneBLL oneBLL)
        {
            _oneBLL = oneBLL;
        }

        [Route("")]
        [HttpGet]
        public async Task QueryAllOnes()
        {
            var result = await _oneBLL.QueryAllOnes();
            Console.WriteLine(result);
        }
    }
}
