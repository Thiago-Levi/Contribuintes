namespace Contribuintes;

public abstract class TaxPlayer
{
  public string Name { get; set; } = "";
  public double AnnualIncome { get; set; } = 0.0;


  public TaxPlayer(string name, double annualIncome)
  {
    Name = name;
    AnnualIncome = annualIncome;
  }
  public abstract double Tax();


}
