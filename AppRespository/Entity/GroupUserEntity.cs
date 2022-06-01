using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRespository
{
    [Table("tbl_group_user")]
    public class GroupUserEntity : BaseEntity
    {
        [Column("group_id", TypeName = "int(11)")]
        public string GroupId { get; set; }

        [Column("group_name", TypeName = "varchar(20)")]
        public string GroupName { get; set; }

        [Column("user_id", TypeName = "int(11)")]
        public string user_id { get; set; }
    }
}
