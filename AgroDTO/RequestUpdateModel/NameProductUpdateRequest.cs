using AgroDTO.Entity;

namespace AgroDTO.RequestUpdateModel
{
    public record NameProductUpdateRequest : EntityBaseUpdateRequest
    {
        public string nameProduct {  get; set; } = string.Empty;
    }
}
