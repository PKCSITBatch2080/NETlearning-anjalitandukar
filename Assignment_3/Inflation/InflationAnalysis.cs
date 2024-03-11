using System;
using System.Collections.Generic;
using System.Linq;

public class InflationAnalysis
{
    public List<Inflation> AsianPacificInflations { get; }

    public InflationAnalysis()
    {
        AsianPacificInflations = new List<Inflation>();
    }

    public void ReadCSV(string filename)
    {
        // Implement CSV reading logic
    }

    public List<Inflation> InflationRatesForYear(int year)
    {
        // Implement method to find inflation rates for a specific year
    }

    public int HighestInflationYearForNepal()
    {
        // Implement method to find the year with the highest inflation in Nepal
    }

    public List<KeyValuePair<string, double>> TopCountriesHighestInflation(int n = 10)
    {
        // Implement method to list top countries with highest inflation
    }

    public List<KeyValuePair<string, double>> TopSouthAsianCountriesLowestInflation(int year, int n = 3)
    {
        // Implement method to list top South Asian countries with lowest inflation for a specific year
    }
}