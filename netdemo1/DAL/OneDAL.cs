using Microsoft.EntityFrameworkCore;
using netdemo1.Data;
using netdemo1.Model;

namespace netdemo1.DAL
{
    /// <summary>
    /// 第二步：创建IDAL/DAL
    /// public class OneDAL: IOneDAL这里我去掉了impl层，太复杂了，影响工作进度
    /// </summary>
    public class OneDAL:IOneDAL
    {
        /// <summary>
        /// 第七步：创建上下文
        /// </summary>
        private readonly AppDbContext _context;
        /// <summary>
        /// 第八步：利用依赖注入赋值context
        /// </summary>
        /// <param name="context"></param>
        public OneDAL(AppDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// 增
        /// </summary>
        /// <returns>int</returns>
        public int InsertOne(int id)
        {
            return 0;
        }
        /// <summary>
        /// 删
        /// </summary>
        /// <returns>int</returns>
        public int DeleteOne(int id)
        {
            return 0;
        }
        /// <summary>
        /// 改
        /// </summary>
        /// <returns>int</returns>
        public int UpdateOne(int id)
        {
            return 0;
        }
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <returns>List<OneModel></returns>
        public async Task<List<OneModel>> GetOnes()
        {
            return await _context.OneModels.ToListAsync();
        }
        /// <summary>
        /// 查询单条
        /// </summary>
        /// <returns>OneModel</returns>
        public OneModel GetOne(int id)
        {
            return new OneModel();
        }

    }
}
