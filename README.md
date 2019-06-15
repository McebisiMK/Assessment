# Project dependencies
    * Dotnet Core >= 2.1
    * Nunit >= 3

# Build a project
    * Navigate to project root folder
    * Run 'dotnet build'

# Run tests
    * Run 'dotnet test'

# Run project
    * Run 'dotnet run'

# Project behavior and assumptions
    * Requires 'Decimal symbol' to be '.' on your PC regional settings.
    * Can accommodate other limit beside 5 as default: eg can say difference to 10
        //var numberDifferenceCalculator = new NumberDifferenceCalculator(limit);
        * Change limit on console app and pass it when newing up a service. 
    * Custom exception handling
        * Negatives are not allowed
        * Does not allowed non-numeric and input out of range

# Decimal numbers are allowed
    
