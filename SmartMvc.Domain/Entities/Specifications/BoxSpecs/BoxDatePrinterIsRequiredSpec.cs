using SmartMvc.Domain.Interfaces.Specification;

namespace SmartMvc.Domain.Entities.Specifications.BoxSpecs
{
    public class BoxDatePrinterIsRequiredSpec : ISpecification<Box>
    {
        public bool IsSatisfiedBy(Box box)
        {
            return box.DatePrinter.Day > 0;
        }
    }
}
