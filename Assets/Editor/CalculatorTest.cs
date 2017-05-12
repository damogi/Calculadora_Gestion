using NUnit.Framework;

public class CalculatorTest
{
    private Calculator calculator = new Calculator(new NumberParser());

    [TestCase("1", "2", false, "3")]
    [TestCase("999", "DXC", false, "1589")]
    [TestCase("55", "1352", true, "MCDVII")]
    [TestCase("856", "5", true, "DCCCLXI")]
    public void ApplicateSum(string a, string b, bool romanOutpout, string result)
    {
        string outpout = calculator.Sum(a, b, romanOutpout);

        Assert.AreEqual(result, outpout);
    }

    [TestCase("3", "2", false, "1")]
    [TestCase("14", "32", false, "-18")]
    [TestCase("82", "66", true, "XVI")]
    [TestCase("1321", "LXVI", true, "MCCLV")]
    public void AplicateSubstract(string a, string b, bool romanOutpout, string result)
    {
        string outpout = calculator.Substract(a, b, romanOutpout);

        Assert.AreEqual(result, outpout);
    }
}
