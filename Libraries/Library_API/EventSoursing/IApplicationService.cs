using System.Threading.Tasks;

namespace Library_API.EventSoursing
{
    public interface IApplicationService
    {
        Task Handle(object command);
    }
}