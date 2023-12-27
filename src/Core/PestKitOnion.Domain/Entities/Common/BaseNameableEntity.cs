namespace PestKitOnion.Domain.Entities.Common
{
    public  class BaseNameableEntity:BaseEntity
    {
        public string Name { get; set; } = null!;
    }
}
