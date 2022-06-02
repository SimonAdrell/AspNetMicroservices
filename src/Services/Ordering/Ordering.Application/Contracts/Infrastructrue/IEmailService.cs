using Ordering.Application.Models;
using System.Threading.Tasks;

namespace Ordering.Application.Contracts.Infrastructrue
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
