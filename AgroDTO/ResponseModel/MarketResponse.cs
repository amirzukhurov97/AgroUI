using AgroDTO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroDTO.ResponseModel
{
    public record MarketResponse : EntityBaseResponse
    {       
        public int nameProdID { get; set; }
        public double obemProducts { get; set; }
    }
}
