namespace Contribuintes;

public class Individual : TaxPlayer
{
  public double HealthExpenditures { get; set; } = 0.0;

  public Individual(string name, double annualIncome, double healthExpenditures) : base(name, annualIncome)
  {
    HealthExpenditures = healthExpenditures;
  }

  public override double Tax()
  {
    double taxation = AnnualIncome * 0.15;
    double taxationRebate = 0.0;

    if (AnnualIncome >= 20000.00)
    {
      taxation = AnnualIncome * 0.25;

    }

    if (HealthExpenditures > 0)
    {
      taxationRebate = HealthExpenditures / 2.0;
    }

    return taxation - taxationRebate;
  }

}

// Pessoa física: pessoas cuja renda foi abaixo de 20000.00 pagam 15% de imposto. Pessoas com 
// renda de 20000.00 em diante pagam 25% de imposto. Se a pessoa teve gastos com saúde, 50% 
// destes gastos são abatidos no imposto. 

