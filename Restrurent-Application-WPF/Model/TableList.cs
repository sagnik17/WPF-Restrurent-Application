using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restrurent_Application_WPF.Model
{
    public class TableList
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TableID { get; set; }
        
        public string TableName { get; set; }
        public string BookingStatus { get; set; }

    }
}
