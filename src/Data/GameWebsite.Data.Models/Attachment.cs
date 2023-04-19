using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWebsite.Data.Models
{
    public class Attachment : BaseEntity
    {
        public string FileUrl { get; set; }
        public string FileName { get; set; }
    }
}
