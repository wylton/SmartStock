using SmartMvc.Domain.Interfaces.Specification;

namespace SmartMvc.Domain.Entities.Specifications.DepartmentSpecs
{
    public class DepartmentNameIsRequiredSpec : ISpecification<Department>
    {
        public bool IsSatisfiedBy(Department department)
        {
            return department.Name.Length > 0;
        }
    }
}