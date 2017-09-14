﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Restrurent_Application_WPF.Model
{
    public class Orders
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }
        public DateTime CreatedDate { get; set; }
        public double TotalPrice { get; set; }
        public string OrderStatus { get; set; }
        public int TableID { get; set; }
        [ForeignKey("TableID")]
        public virtual TableList TableList { get; set; }
    }
}
