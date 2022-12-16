using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Front.Requests
{
    public class OrderPost
    {
        public string OfficeId { get; set; }
        public OrderPost(string officeId)
        {
            OfficeId = officeId;
        }
    }
}
