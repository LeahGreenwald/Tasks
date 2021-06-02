using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RealTimeTasks.Data;

namespace RealTimeTasks.Web.ViewModels
{
    public class UpdateStatusViewModel
    {
        public int TaskId { get; set; }
        public Status Status { get; set; }
        public int UserId { get; set; }
        public string TaskTitle { get; set; }
    }
}
