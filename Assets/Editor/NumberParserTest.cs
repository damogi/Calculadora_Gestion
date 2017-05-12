using NUnit.Framework;

public class NumberParserTest 
{
    private NumberParser parser = new NumberParser();

    [TestCase(10, "X")]
    [TestCase(100, "C")]
    [TestCase(9, "IX")]
    [TestCase(1969, "MCMLXIX")]
    [TestCase(512, "DXII")]
    public void ParsesArabicNumber(int input, string result)
    {
        string outpout = parser.ArabicToRoman(input);

        Assert.AreEqual(result, outpout);
    }

    [TestCase("VI", 6)]
    [TestCase("MCDXIII", 1413)]
    [TestCase("DCII", 602)]
    [TestCase("LXVIII", 68)]
    [TestCase("CCCLXXXV", 385)]
    public void ParsesRomanNumber(string input, int result)
    {
        int outpout = parser.RomanToArabic(input);

        Assert.AreEqual(result, outpout);
    }
}
