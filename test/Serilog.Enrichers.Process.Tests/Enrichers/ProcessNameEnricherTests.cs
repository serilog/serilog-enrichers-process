using Serilog.Events;
using Serilog.Tests.Support;
using Xunit;

namespace Serilog.Enrichers.Process.Tests
{
    public class ProcessNameEnricherTests
    {
        [Fact]
        public void ProcessNameEnricherIsApplied()
        {
            LogEvent evt = null;
            var log = new LoggerConfiguration()
                .Enrich.WithProcessName()
                .WriteTo.Sink(new DelegatingSink(e => evt = e))
                .CreateLogger();

            log.Information(@"Has a ProcessName property");

            Assert.NotNull(evt);

            var processName = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
            Assert.Equal(processName, (string)evt.Properties["ProcessName"].LiteralValue());
        }
    }
}
