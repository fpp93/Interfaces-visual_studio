using System;
using System.Collections.Generic;
using ExamenWPF;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCancelarPaquete()
        {
            //Creamos el cliente y el objeto simulado
            ICliente cliente = (ICliente)new Cliente("Nombre","Apellido","88888888R","600900900",new List<IPaquete>(),new List<IPaquete>());
            var mockPaquete = new Mock<IPaquete>();

            //Definimos el comportamiento del mock
            mockPaquete.Setup(x => x.Nombre).Returns("Paquete 1");

            //Añadimos el mock a la lista de paquetes (reservados)
            cliente.PaquetesReservados.Add((IPaquete)mockPaquete.Object);

            //Método que queremos probar
            cliente.cancelarPaquete((IPaquete)mockPaquete.Object);

            //Comprobación
            Assert.IsFalse(cliente.PaquetesReservados.Contains((IPaquete)mockPaquete.Object));

        }

        [TestMethod]
        public void TestReservarPaquete()
        {
            //Creamos el cliente y el objeto simulado
            ICliente cliente = (ICliente)new Cliente("Nombre", "Apellido", "88888888R", "600900900", new List<IPaquete>(), new List<IPaquete>());
            var mockPaquete = new Mock<IPaquete>();

            //Definimos el comportamiento del mock
            mockPaquete.Setup(x => x.Nombre).Returns("Paquete 1");

            //Añadimos el mock a la lista de paquetes (reservados)
            cliente.reservarPaquete((IPaquete)mockPaquete.Object);

            //Comprobación
            Assert.IsTrue(cliente.PaquetesReservados.Contains((IPaquete)mockPaquete.Object));

        }
    }
}
