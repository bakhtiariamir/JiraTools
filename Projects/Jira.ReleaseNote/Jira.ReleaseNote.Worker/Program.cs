using Jira.ReleaseNote.Worker;
using Jira.ReleaseNote.Core.Setting;
using Autofac.Extensions.DependencyInjection;
using Jira.ReleaseNote.Core.Base;
using Jira.ReleaseNote.Core.Implement;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, services) =>
    {
        IConfiguration configuration = hostContext.Configuration;
        services.Configure<JiraServer>(configuration.GetSection(nameof(JiraServer)));
        services.AddHostedService<Worker>();
        services.AddSingleton<IProjectOperation, ProjectOperation>();
    }).UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .Build();


await host.RunAsync();
