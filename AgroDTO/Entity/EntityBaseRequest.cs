using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroDTO.Entity
{
    public abstract record EntityBaseRequest
    {
        public int Id { get; set; }
    }
}
