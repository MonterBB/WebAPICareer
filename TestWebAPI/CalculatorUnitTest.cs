using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Controllers;
using WebAPI;

namespace TestWebAPI
{
    /// <summary>
    /// Тест калькулятора.
    /// </summary>
    public class CalculatorUnitTest
    {
        /// <summary>
        /// Заглушка интерфейса калькулятора.
        /// </summary>
        private readonly Mock<ICalculator> _calculator;

        /// <summary>
        /// Создаёт экземпляр тестов калькулятора.
        /// </summary>
        public CalculatorUnitTest() 
        {
            _calculator = new Mock<ICalculator>();

            _calculator.Setup(calc => calc.Add(1, 2)).Returns(3);
            _calculator.Setup(calc => calc.Subtract(3, 2)).Returns(1);
            _calculator.Setup(calc => calc.Multiply(1, 2)).Returns(2);
            _calculator.Setup(calc => calc.Divide(1, 2)).Returns(0.5);
        }

        /// <summary>
        /// Тест операции добавления с заглушкой калькулятора.
        /// </summary>
        [Fact]
        public void CalculatorMock_Add_Success()
        {
            var calculator = _calculator.Object;

            var addResult = calculator.Add(1, 2);

            Assert.IsType<double>(addResult);
            Assert.Equal(3, addResult);
        }

        /// <summary>
        /// Тест операции вычитания с заглушкой калькулятора.
        /// </summary>
        [Fact]
        public void CalculatorMock_Subtract_Success()
        {
            var calculator = _calculator.Object;

            var addResult = calculator.Subtract(3, 2);

            Assert.IsType<double>(addResult);
            Assert.Equal(1, addResult);
        }

        /// <summary>
        /// Тест операции умножения с заглушкой калькулятора.
        /// </summary>
        [Fact]
        public void CalculatorMock_Multiply_Success()
        {
            var calculator = _calculator.Object;

            var addResult = calculator.Multiply(1, 2);

            Assert.IsType<double>(addResult);
            Assert.Equal(2, addResult);
        }

        /// <summary>
        /// Тест операции деления с заглушкой калькулятора.
        /// </summary>
        [Fact]
        public void CalculatorMock_Divide_Success()
        {
            var calculator = _calculator.Object;

            var addResult = calculator.Divide(1, 2);

            Assert.IsType<double>(addResult);
            Assert.Equal(0.5, addResult);
        }

        /// <summary>
        /// Тест операции добавления калькулятора.
        /// Тестовые данные:
        /// 1. Первое слагаемое
        /// 2. Второе слагаемое
        /// 3. Результат
        /// </summary>
        [Theory]
        [InlineData(10, 11, 21)]
        [InlineData(20, 21, 41)]
        [InlineData(30, 31, 61)]
        [InlineData(40, 41, 81)]
        [InlineData(80, 81, 161)]
        public void Calculator_Add_Success(double firstValue, double secondValue, double result)
        {
            var calculator = new Calculator();

            var addResult = calculator.Add(firstValue, secondValue);

            Assert.Equal(addResult, result);
        }

        /// <summary>
        /// Тест операции вычитания калькулятора.
        /// Тестовые данные:
        /// 1. Уменьшаемое
        /// 2. Вычитаемое
        /// 3. Результат
        /// </summary>
        [Theory]
        [InlineData(2, 3, -1)]
        [InlineData(20, 21, -1)]
        [InlineData(50, 31, 19)]
        [InlineData(44, 41, 3)]
        [InlineData(80, 80, 0)]
        public void Calculator_Subtract_Success(double firstValue, double secondValue, double result)
        {
            var calculator = new Calculator();

            var addResult = calculator.Subtract(firstValue, secondValue);

            Assert.Equal(addResult, result);
        }

        /// <summary>
        /// Тест операции умножения калькулятора.
        /// Тестовые данные:
        /// 1. Множитель
        /// 2. Множитель
        /// 3. Результат
        /// </summary>
        [Theory]
        [InlineData(10, 11, 110)]
        [InlineData(5, 4, 20)]
        [InlineData(30, 31, 930)]
        [InlineData(0.5, 2, 1)]
        [InlineData(4, 0.5, 2)]
        public void Calculator_Multiply_Success(double firstValue, double secondValue, double result)
        {
            var calculator = new Calculator();

            var addResult = calculator.Multiply(firstValue, secondValue);

            Assert.Equal(addResult, result);
        }

        /// <summary>
        /// Тест операции деления калькулятора.
        /// Тестовые данные:
        /// 1. Делимое
        /// 2. Делитель
        /// 3. Результат
        /// </summary>
        [Theory]
        [InlineData(10, 10, 1)]
        [InlineData(5, 10, 0.5)]
        [InlineData(-10, 4, -2.5)]
        [InlineData(100, 25, 4)]
        [InlineData(45, 3, 15)]
        public void Calculator_Divide_Success(double firstValue, double secondValue, double result)
        {
            var calculator = new Calculator();

            var addResult = calculator.Divide(firstValue, secondValue);

            Assert.Equal(addResult, result);
        }
    }

    public class Calculator : ICalculator
    {
        public double Add(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }

        public double Subtract(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }

        public double Multiply(double firstValue, double secondValue)
        {
            return firstValue * secondValue;
        }

        public double Divide(double firstValue, double secondValue)
        {
            return firstValue / secondValue;
        }
    }

    public interface ICalculator
    {
        double Add(double firstValue, double secondValue);

        double Subtract(double firstValue, double secondValue);

        double Multiply(double firstValue, double secondValue);

        double Divide(double firstValue, double secondValue);
    }
}
