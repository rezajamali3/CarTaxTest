using System.Threading.Tasks;

namespace Library_Domain.Interface
{
    public interface IApplicationService
    {
        Task Handle(object command);
    }
}