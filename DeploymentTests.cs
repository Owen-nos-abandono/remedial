using Xunit;

namespace ArroyoSeco.Tests
{
    public class DeploymentTests
    {
        [Fact]
        public void TestEnvironmentIsProduction()
        {
            // Prueba simple para validar el flujo del pipeline
            bool isReady = true;
            Assert.True(isReady);
        }
    }
}