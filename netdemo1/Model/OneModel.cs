using System.ComponentModel.DataAnnotations.Schema;

namespace netdemo1.Model
{
    /// <summary>
    /// 第一步：创建Model
    /// </summary>
    [Table("one")]
    public class OneModel
    {
        public Guid guid { get; set; }

        public string username { get; set; }

        public string password { get; set; }    
    }
}
