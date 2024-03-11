class InflationAnalysis
{
    List <Inflation> AsianPacificInflation;

    public InflationAnalysis()
    {
       AsianPacificInflation = new ();
    }

    public void ReadInflationData(string filePath)
{
    try
    {
        using (var reader = new StreamReader(filePath))
        {
            reader.ReadLine(); // Skip the header line

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] values = line.Split(',');

                if (int.TryParse(values[1], out int year) &&
                    double.TryParse(values[2].Replace("%", ""), out double inflationRate))
                {
                    Inflation inflationData = new Inflation
                    {
                        RegionalMember = values[0],
                        Year = year,
                        InflationRate = inflationRate,
                        UnitOfMeasurement = values[3],
                        Subregion = values[4],
                        CountryCode = values[5]
                    };

                    AsianPacificInflation.Add(inflationData);
                }
                else
                {
                    Console.WriteLine($"Error parsing data in line: {line}. Skipping this line.");
                }
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred while reading the CSV file: {ex.Message}");
    }
}


    public List<Inflation> GetInflationRatesForYear(int year)
    {
        return AsianPacificInflation.Where(inflation => inflation.Year == year).ToList();
    }

    public int GetYearWithHighestInflationForCountry(string countryName)
    {
        return AsianPacificInflation
            .Where(inflation => inflation.RegionalMember == countryName)
            .OrderByDescending(inflation => inflation.InflationRate)
            .Select(inflation => inflation.Year)
            .FirstOrDefault();
    }

    public List<Inflation> GetTop10RegionsWithHighestInflation()
    {
        return AsianPacificInflation
            .Where(inflation => !string.IsNullOrEmpty(inflation.CountryCode))
            .GroupBy(inflation => inflation.RegionalMember)
            .Select(group => new Inflation
            {
                RegionalMember = group.Key,
                InflationRate = group.Average(inflation => inflation.InflationRate)
            })
            .OrderByDescending(inflation => inflation.InflationRate)
            .Take(10)
            .ToList();
    }

    public List<Inflation> GetTop3SouthAsianCountriesWithLowestInflationForYear(int year)
    {
        return AsianPacificInflation
            .Where(inflation => inflation.Year == year && inflation.Subregion == "South Asia")
            .OrderBy(inflation => inflation.InflationRate)
            .Take(3)
            .ToList();
    }

}