namespace Assessment.Library.Validations
{
    public interface INumberValidator
    {
        double Validate(string number, double limit);
    }
}