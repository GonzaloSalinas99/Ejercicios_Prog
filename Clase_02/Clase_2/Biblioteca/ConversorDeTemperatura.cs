using System;

namespace Biblioteca
{
    public static class ConversorDeTemperatura
    {
        private const float ceroAboluto = 273.15f;


        /// <summary>
        /// Convierte la temperatura Celsius a Kelvin
        /// </summary>
        /// <param name="temperaturaCelsius">Temperatura en grados celsius</param>
        /// <returns>Temperatura Kelvin dependiendo el grado Celsius que recibi por parametro</returns>
        public static float ConvertirCelsiusAKelvin(float temperaturaCelsius)
        {
            float temperaturaKelvin = temperaturaCelsius + ceroAboluto;

            return temperaturaKelvin;
        }

        public static float ConvertirKelvinACelsius(float temperaturaKelvin)
        {
            float temperaturaCelsius = temperaturaKelvin - ceroAboluto;

            return temperaturaCelsius;
        }

    }
}
