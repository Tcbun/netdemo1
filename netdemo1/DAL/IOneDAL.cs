using netdemo1.Model;

namespace netdemo1.DAL
{
    public interface IOneDAL
    {

        public int InsertOne(int id);

        public int DeleteOne(int id);

        public int UpdateOne(int id);

        public Task<List<OneModel>> GetOnes();

        public OneModel GetOne(int id);
    }
}
