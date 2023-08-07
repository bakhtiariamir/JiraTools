using Jira.ReleaseNote.Core.Setting;
using Microsoft.Extensions.Options;

namespace Jira.ReleaseNote.Core.Implement
{
    public class Service
    {
        protected Atlassian.Jira.Jira _jira;

        public Service(IOptions<JiraServer> options)
        {
            var baseUrl = options.Value.BaseUrl;
            var username = options.Value.Username;
            var password = options.Value.Password;
            _jira = Atlassian.Jira.Jira.CreateRestClient(baseUrl, username, password);
        }
    }
}
