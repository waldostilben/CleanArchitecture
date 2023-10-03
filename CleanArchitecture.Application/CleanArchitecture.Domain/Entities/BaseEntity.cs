
namespace CleanArchitecture.Domain.Entities
{
    public abstract class BaseEntity //classe destinada a ser herdada por outras classes
    {
        public Guid Id { get; set; } //estrutura que representa um identificador de 128 bits
        public DateTimeOffset DateCreated { get; set; } //DateTimeOffset é um DateTime universal UTC
        public DateTimeOffset? DateUpdated { get; set; }
        public DateTimeOffset? DateDeleted { get; set; }
    }
}