using AgroDTO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroDTO.RequestModel
{
    public record MarketRequest : EntityBaseRequest
    {
        public int nameProdID { get; set; }
        public double obemProducts { get; set; }
    }
}
