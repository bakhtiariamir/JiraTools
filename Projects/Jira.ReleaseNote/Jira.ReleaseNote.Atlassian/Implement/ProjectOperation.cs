using Atlassian.Jira;
using Jira.ReleaseNote.Core.Base;
using Jira.ReleaseNote.Core.Setting;
using Microsoft.Extensions.Options;

namespace Jira.ReleaseNote.Core.Implement
{
    public class ProjectOperation : Service, IProjectOperation
    {
        public ProjectOperation(IOptions<JiraServer> options) : base(options)
        {
        }

        public async Task<IEnumerable<Project>> Get()
        {
            var projects = await _jira.Projects.GetProjectsAsync();
            return projects;
        }
    }
}
