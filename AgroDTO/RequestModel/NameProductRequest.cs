using AgroDTO.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroDTO.RequestModel
{
    public record NameProductRequest : EntityBaseRequest
    {
        //[Required]
        //[StringLength(0,ErrorMessage="Введите наименование товара!")]
        public string nameProduct {  get; set; } = string.Empty;
    }
}
