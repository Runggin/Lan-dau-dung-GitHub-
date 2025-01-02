public static class Calculator
{
    public static double Cong(double a, double b) => a + b;
    public static double Tru(double a, double b) => a - b;
    public static double Nhan(double a, double b) => a * b;
    public static double Chia(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Không thể chia cho 0!");
        }
        return a / b;
    }
}
