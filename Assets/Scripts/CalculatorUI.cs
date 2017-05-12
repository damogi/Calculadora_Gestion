using UnityEngine;
using UnityEngine.UI;

public class CalculatorUI: MonoBehaviour
{
    private string aNumber;
    private string bNumber;

    [SerializeField]
    private Text result;

    private Calculator calculator = new Calculator(new NumberParser());

    //Hidden
    private bool romanOutpout;

    public void Sum()
    {
        UpdateResultField(calculator.Sum(aNumber, bNumber, romanOutpout));
    }

    public void Substract()
    {
        UpdateResultField(calculator.Substract(aNumber, bNumber, romanOutpout));
    }

    public void ANumber(string aNumber)
    {
        this.aNumber = aNumber;
    }

    public void BNumber(string bNumber)
    {
        this.bNumber = bNumber;
    }

    public void RomanOutpout(bool romanOutpout)
    {
        this.romanOutpout = romanOutpout;
    }

    private void UpdateResultField(string resultValue)
    {
        result.text = resultValue;
    }
}
