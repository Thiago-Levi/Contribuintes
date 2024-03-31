namespace Contribuintes;

public class Company : TaxPlayer
{
  public int NumberOfEmployees { get; set; }

  public Company(string name, double annualIncome, int numberOfEmployees) : base(name, annualIncome)
  {
    NumberOfEmployees = numberOfEmployees;
  }

  public override double Tax()
  {
    double taxation = AnnualIncome * 0.16;

    if (NumberOfEmployees > 10)
    {
      taxation = AnnualIncome * 0.14;
    }


    return taxation;
  }

}

// Pessoa jurídica: pessoas jurídicas pagam 16% de imposto. Porém, se a empresa possuir mais de 10 
// funcionários, ela paga 14% de imposto. 

