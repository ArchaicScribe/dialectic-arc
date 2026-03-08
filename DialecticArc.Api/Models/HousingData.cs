namespace DialecticArc.Api.Models;

public record HousingData(
    int Year,
    string Generation,
    string Region,
    decimal MedianHomePrice,
    decimal MedianHouseholdIncome
);