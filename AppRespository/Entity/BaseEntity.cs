using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AppRespository
{
    public class BaseEntity
    {
        [Column("id", TypeName = "int(11)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("cts", TypeName = "timestamp")]
        public DateTime Cts { get; set; }

        [Column("uts", TypeName = "timestamp")]
        public DateTime Uts { get; set; }
    }
}
