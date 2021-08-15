using Serilog.Events;
using Serilog.Tests.Support;
using Xunit;

namespace Serilog.Enrichers.Process.Tests
{
    public class ProcessIdEnricherTests
    {
        [Fact]
        public void ProcessIdEnricherIsApplied()
        {
            LogEvent evt = null;
            var log = new LoggerConfiguration()
                .Enrich.WithProcessId()
                .WriteTo.Sink(new DelegatingSink(e => evt = e))
                .CreateLogger();

            log.Information(@"Has a ProcessId property");

            Assert.NotNull(evt);

            var processId = System.Diagnostics.Process.GetCurrentProcess().Id;
            Assert.Equal(processId, (int)evt.Properties["ProcessId"].LiteralValue());
        }
    }
}
