using Jira.ReleaseNote.Core.Base;

namespace Jira.ReleaseNote.Worker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IProjectOperation _operation;

        public Worker(ILogger<Worker> logger, IProjectOperation operation)
        {
            _logger = logger;
            _operation = operation;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var projects = await _operation.Get();
            while (!stoppingToken.IsCancellationRequested)
            {


                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}