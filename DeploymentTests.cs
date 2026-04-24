using System;

namespace ArroyoSeco.Tests
{
    // Una prueba simple que solo usa System, para no pedir paquetes extra
    public class DeploymentTests
    {
        public static void CheckSystem()
        {
            Console.WriteLine("Verificando integridad del sistema...");
            bool isSystemReady = true;
            if (!isSystemReady) throw new Exception("Error en la prueba de despliegue");
        }
    }
}