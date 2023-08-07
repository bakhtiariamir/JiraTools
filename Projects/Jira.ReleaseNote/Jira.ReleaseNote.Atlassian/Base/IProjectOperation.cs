using Atlassian.Jira;

namespace Jira.ReleaseNote.Core.Base
{
    public interface IProjectOperation : IOperation
    {
        Task<IEnumerable<Project>> Get();
    }
}
