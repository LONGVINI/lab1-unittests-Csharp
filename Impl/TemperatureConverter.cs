// TemperatureConverter.cs
using System;

namespace Impl
{
    public class TemperatureConverter
    {
        /// <summary>
        /// Конвертує температуру з Цельсія у Фаренгейти.
        /// </summary>
        /// <param name="celsius">Температура у градусах Цельсія</param>
        /// <returns>Температура у Фаренгейтах</returns>
        public double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;  // Помилка: не враховуються крайні значення або типи даних
        }

        /// <summary>
        /// Конвертує температуру з Фаренгейтів у Цельсій.
        /// </summary>
        /// <param name="fahrenheit">Температура у Фаренгейтах</param>
        /// <returns>Температура у градусах Цельсія</returns>
        public double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        /// <summary>
        /// Конвертує температуру з Кельвінів у Цельсій.
        /// </summary>
        /// <param name="kelvin">Температура у Кельвінах</param>
        /// <returns>Температура у градусах Цельсія</returns>
        public double KelvinToCelsius(double kelvin)
        {
            // Помилка: не перевіряється, що температура не може бути нижче абсолютного нуля
            return kelvin - 273.15;
        }

        /// <summary>
        /// Конвертує температуру з Цельсія у Кельвіни.
        /// </summary>
        /// <param name="celsius">Температура у градусах Цельсія</param>
        /// <returns>Температура у Кельвінах</returns>
        public double CelsiusToKelvin(double celsius)
        {
            return celsius + 273.15;  // Помилка: неправильна формула може виникнути через типи
        }
    }
}