using System;
using System.Collections.Generic;
using System.Text;
using MascotaVirtual;
using Xunit;

namespace MascotaVirtual.Test
{
    public class MascotaTest
    {
        [Fact]
        public void Comer_ComioAntesYNoFueAlBaño_DeberiaArrojarExcepcion()
        {
            // Arrange
            var mascota = new Mascota();

            // Act
            mascota.Comer();


            // Assert
            Assert.Throws<Exception>(() => mascota.Comer());
        }
        [Fact]
        public void Comer_ComioAntesYFueAlBaño_DeberiaArrojarComiendo()
        {
            // Arrange
            var mascota = new Mascota();

            // Act
            mascota.Comer();
            mascota.IrAlBaño();

            mascota.Comer();

            // Assert
            Assert.Equal("Comiendo", mascota.Estado);
        }

        [Fact]
        public void RealizarUnaAccion_Dormido_DeberiaArrojarExcepcionEnTodasMenosEnDespertarse()
        {
            // Arrange
            var mascota = new Mascota();

            // Act
            mascota.Dormir();
            

            // Assert
            Assert.Throws<Exception>(() => mascota.Comer());
            Assert.Throws<Exception>(() => mascota.IrAlBaño());
            Assert.Throws<Exception>(() => mascota.Jugar());
            Assert.Throws<Exception>(() => mascota.Dormir());

            mascota.Despertar();
            
            Assert.Equal("Despertando", mascota.Estado);
        }

        [Fact]
        public void Despertarse_NoEstaDurmiendo_DeberiaArrojarExcepcion()
        {
            // Arrange
            var mascota = new Mascota();

            // Act

            // Assert
            Assert.Throws<Exception>(() => mascota.Despertar());
        }

        [Fact]
        public void Jugar_SinHaberComidoAntes_DeberiaArrojarExcepcion()
        {
            // Arrange
            var mascota = new Mascota();

            // Act

            // Assert
            Assert.Throws<Exception>(() => mascota.Jugar());
        }

        [Fact]
        public void Jugar_ComidoAntes_DeberiaArrojarJugando()
        {
            // Arrange
            var mascota = new Mascota();

            // Act
            mascota.Comer();
            mascota.Jugar();

            // Assert
            Assert.Equal("Jugando", mascota.Estado);
        }
        [Fact]
        public void IrAlBaño_SinHaberComido_DeberiaArrojarExcepcion()
        {
            // Arrange
            var mascota = new Mascota();

            // Act

            // Assert
            Assert.Throws<Exception>(() => mascota.IrAlBaño());
        }

    }
}
