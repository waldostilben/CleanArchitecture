
namespace CleanArchitecture.Domain.Entities
{
    public sealed class User : BaseEntity //sealed não permite que a classe seja herdada
    {
        public string? Email { get; set; }
        public string? Name { get; set; }
    }
}