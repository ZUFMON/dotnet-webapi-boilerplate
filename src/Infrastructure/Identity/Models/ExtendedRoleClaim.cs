using DN.WebApi.Domain.Contracts;
using Microsoft.AspNetCore.Identity;

namespace DN.WebApi.Infrastructure.Identity.Models
{
    public class ExtendedRoleClaim : IdentityRoleClaim<string>
    {
        public string Description { get; set; }
        public string TenantId { get; set; }
    }
}