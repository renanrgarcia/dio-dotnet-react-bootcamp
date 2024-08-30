namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public bool IsEven(int num)
        {
            if (num % 2 == 0)
                return true;
            else
                return false;
        }
    }
}