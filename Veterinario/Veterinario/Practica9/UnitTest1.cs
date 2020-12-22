using ClínicaVeterinaria;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace Practica9
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestJugar()
        {
            Mascota m = new Mascota("Tobi", "12/12/2013");
            
            String juego = "pelota";
            
            Assert.AreEqual(true,m.Jugar(juego));
        }

        [TestMethod]
        public void TestYaVacunado()
        {
            Mascota m = new Mascota("Tobi", "12/12/2013");

            String vacuna = "antipulgas";

            Assert.AreEqual(false, m.YaVacunado(vacuna));
        }
        [TestMethod]
        public void TestYaVacunado_2()
        {
            Mascota m = new Mascota("Tobi", "12/12/2013");

            String vacuna = "antipulgas";
            m.Vacunas.Add(vacuna);

            Assert.AreEqual(true, m.YaVacunado(vacuna));
        }


        [TestMethod]
        public void TestSeRelaja()
        {
            Mascota m = new Mascota("Tobi", "12/12/2013");

            String premio = "pelota";

            Assert.AreEqual(true, m.SeRelaja(premio));
        }
        [TestMethod]
        public void TestSeRelaja_2()
        {
            Mascota m = new Mascota("Tobi", "12/12/2013");

            String premio = "juguete";

            Assert.AreEqual(false, m.SeRelaja(premio));
        }
        [TestMethod]
        public void TestVacunar()
        {
            Mascota m = new Mascota("Tobi", "12/12/2013");

            String vacuna = "antipulgas";

            try
            {
                m.Vacunar(vacuna);
                //para comprobar si todo ha ido bien simplemente
                Assert.IsTrue(true);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Ya ha sido vacunado de " + vacuna,e.Message);
            }
        }
        [TestMethod]
        public void TestAdoptar()
        {
            Cliente c = new Cliente("Pepe", "12345678A","Parra");
            Mascota m = new Mascota("Tobi", "12/12/2013");
            c.Adoptar(m);
            Assert.IsTrue(c.getMascotas().Contains(m));
        }
        [TestMethod]
        public void TestEjercitarMascota()
        {
            Cliente c = new Cliente("Pepe", "12345678A", "Parra");
            var mockMascota = new Mock<IMascota>();
            mockMascota.Setup(x => x.Jugar("saltar")).Returns(true);
            try
            {
                c.EjercitarMascota((IMascota)mockMascota.Object, "saltar");
                Assert.IsTrue(false);

            }catch(Exception e)
            {
                Assert.AreEqual("Se ha ejercitado", e.Message);
            }
        }
        [TestMethod]
        public void TestEjercitarMascota_2()
        {
            Cliente c = new Cliente("Pepe", "12345678A", "Parra");
            var mockMascota = new Mock<IMascota>();
            mockMascota.Setup(x => x.Jugar("saltar")).Returns(false);
            try
            {
                c.EjercitarMascota((IMascota)mockMascota.Object, "saltar");
                Assert.IsTrue(false);

            }
            catch (Exception e)
            {
                Assert.AreEqual("No se ha ejercitado", e.Message);
            }
        }
        [TestMethod]
        public void TestPremiar_veterinario()
        {
            Veterinario c = new Veterinario("Pepe");
            var mockMascota = new Mock<IMascota>();
            mockMascota.Setup(x => x.SeRelaja("juguete")).Returns(true);

            Assert.IsTrue(c.Premiar((IMascota)mockMascota.Object, "juguete"));
        }
        [TestMethod]
        public void TestPremiar_veterinario_2()
        {
            Veterinario c = new Veterinario("Pepe");
            var mockMascota = new Mock<IMascota>();
            mockMascota.Setup(x => x.SeRelaja("pelota")).Returns(true);

            Assert.IsTrue(c.Premiar((IMascota)mockMascota.Object, "pelota"));
        }

        [TestMethod]
        public void TestPremiar_cliente()
        {
            Cliente c = new Cliente("Pepe","1111111A","Parra");
            Mascota m = new Mascota("Tobi", "12/12/2013");
            String premio = "pelota";
            c.Premiar(m,premio);
            Assert.IsTrue(true);
        }





    }
}
