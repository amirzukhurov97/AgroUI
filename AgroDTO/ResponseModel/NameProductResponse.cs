using AgroDTO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroDTO.ResponseModel
{
    public record NameProductResponse : EntityBaseResponse
    {        
        public string nameProduct { get; set; } = string.Empty;
    }
}
