using netdemo1.Model;

namespace netdemo1.BLL
{
    public interface IOneBLL
    {
        /// <summary>
        /// 第十一步：我发现报错了InvalidOperationException: Unable to resolve service for type...
        /// 网上说是依赖注入必须使用接口类而不能使用具体类，真的烦躁哦，这也太麻烦了
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int InsertOne(int id);
        public int UpdateOne(int id);
        public int DeleteOne(int id);
        public Task<List<OneModel>> QueryAllOnes();
        public OneModel GetOne();
    }
}
