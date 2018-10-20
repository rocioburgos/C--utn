using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntidadesAbstractas;
using Clases.Instanciables;
using Excepciones;

namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DNInegativo()
        {
            try
            {
                Alumno unaPersona = new Alumno(15, "Nahuel", "Suarez", "-15", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            }
            catch
            {
                throw new DniInvalidoException("El dni no puede ser negativo");
            }
        }


        [TestMethod]
        public void ObjetoNulo()
        {
            
            Alumno alum=new Alumno();
            Assert.IsNotNull(alum.Apellido);
          
        }

    }
}
