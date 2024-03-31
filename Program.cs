// See https://aka.ms/new-console-template for more information

// Exemplo: uma pessoa cuja renda foi 50000.00 e teve 2000.00 em gastos com saúde, o imposto 
// fica: (50000 * 25%) - (2000 * 50%) = 11500.00

using Contribuintes;
using System.Globalization;
//Individual individual = new Individual("Alex", 50000, 2000);
//System.Console.WriteLine($"{individual.Tax():C}");

//Company company = new Company("SoftTech", 400000, 25);
//System.Console.WriteLine($"{company.Tax():C}");


List<TaxPlayer> taxPlayers = new List<TaxPlayer>();
System.Console.WriteLine("Enter the number of tax payers:");
int numberOfTaxPlayers = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= numberOfTaxPlayers; i++)
{
  System.Console.WriteLine($"Tax payer {i}° data:");

  System.Console.Write("Individual or company (i/c)? ");
  char individualOrCompanyOption = Convert.ToChar(Console.ReadLine());

  System.Console.Write("Name: ");
  string name = Console.ReadLine();

  System.Console.Write("Anual income: ");
  double anualIncome = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

  if (individualOrCompanyOption == 'i')
  {
    System.Console.Write("Health expenditures: ");
    double healthExpenditures = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

    taxPlayers.Add(new Individual(name, anualIncome, healthExpenditures));

  }
  else
  {
    System.Console.Write("Number of employees: ");
    int numberOfEmployees = Convert.ToInt32(Console.ReadLine());

    taxPlayers.Add(new Company(name, anualIncome, numberOfEmployees));

  }

}
System.Console.WriteLine("TAXES PAID");
double totalTaxes = 0.0;
foreach (var taxPlayer in taxPlayers)
{
  System.Console.WriteLine($"{taxPlayer.Name}: {taxPlayer.Tax():C}");
  totalTaxes += taxPlayer.Tax();
}

System.Console.WriteLine($"Total taxes: {totalTaxes:C}");