using netdemo1.DAL;
using netdemo1.Model;

namespace netdemo1.BLL
{
    /// <summary>
    /// 第三步：创建IBLL/BLL
    /// </summary>
    public class OneBLL:IOneBLL
    {
        /// <summary>
        /// 第九步：利用历来注入，把DAL注入到BLL
        /// 说实在的，真的好麻烦
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private readonly IOneDAL _oneDAL;
        public OneBLL(IOneDAL oneDAL) //注入的竟然是接口，我的妈妈
        {
            _oneDAL = oneDAL;
        }
        public int InsertOne(int id)
        {
            return 0;
        }
        public int UpdateOne(int id)
        {
            return 0;
        }
        public int DeleteOne(int id)
        {
            return 0;
        }
        public async Task<List<OneModel>> QueryAllOnes()
        {
            return await _oneDAL.GetOnes();
        }
        public OneModel GetOne()
        {
            return new OneModel();
        }
    }
}
