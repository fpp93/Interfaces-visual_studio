using Microsoft.VisualStudio.TestTools.UnitTesting;
using pruebasUnitarias1;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //crear lo necesario.
        IPersona persona = (IPersona)new Persona("Juan", "Sin Miedo", 27);

        [TestMethod]
        public void Test_getNombre()
        {
            
            //ejecutamos el metodo del objeto real
            string nombre = persona.getNombre();

            //comprobamos
            Assert.AreEqual("Juan", nombre);
        }
        [TestMethod]
        public void Test_getApellido()
        {

            //ejecutamos el metodo del objeto real
            string apellido = persona.getApellido();

            //comprobamos
            Assert.AreEqual("Sin Miedo", apellido);
        }
        [TestMethod]
        public void Test_getEdad()
        {

            //ejecutamos el metodo del objeto real
            int edad = persona.getEdad();

            //comprobamos
            Assert.AreEqual(27, edad);
        }
        [TestMethod]
        public void Test_setNombre()
        {
            IPersona persona1 = (IPersona)new Persona("Juan", "Sin Miedo", 27);
            //ejecutamos el metodo del objeto real
            persona1.setNombre("Maria");

            //comprobamos
            Assert.AreEqual("Maria",persona1.getNombre());
        }
        [TestMethod]
        public void Test_setApellido()
        {
            IPersona persona1 = (IPersona)new Persona("Juan", "Sin Miedo", 27);
            //ejecutamos el metodo del objeto real
            persona1.setApellido("Con Miedo");

            //comprobamos
            Assert.AreEqual("Con Miedo", persona1.getApellido());
        }
        [TestMethod]
        public void Test_setEdad()
        {
            IPersona persona1 = (IPersona)new Persona("Juan", "Sin Miedo", 27);
            //ejecutamos el metodo del objeto real
            persona1.setEdad(23);

            //comprobamos
            Assert.AreEqual(23, persona1.getEdad());
        }
        [TestMethod]
        public void Test_copiaPersona()
        {
            IPersona persona1 = (IPersona)new Persona("Juan", "Sin Miedo", 27);
        }
    }
}
