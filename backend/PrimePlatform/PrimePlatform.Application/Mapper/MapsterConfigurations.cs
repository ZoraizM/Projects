using Mapster;
using PrimePlatform.Application.DTOs;
using PrimePlatform.Domain.Entities;


namespace PrimePlatform.Application.Mapper
{
    public class MapsterConfigurations
    {
        public static void RegisterMappings()
        {
            RegisterDepartmentMappings();
            RegisterEmployeeMappings();
        }

        private static void RegisterDepartmentMappings()
        {
            TypeAdapterConfig<Department, DepartmentDto>
                .NewConfig()
                .Map(dest => dest.EmployeeCount,
                     src => src.Employees.Count);

            TypeAdapterConfig<CreateDepartmentDto, Department>
                .NewConfig();

            TypeAdapterConfig<UpdateDepartmentDto, Department>
                .NewConfig();
        }

        private static void RegisterEmployeeMappings()
        {
            TypeAdapterConfig<Employee, EmployeeDto>
                .NewConfig()
                .Map(dest => dest.DepartmentName,
                     src => src.Department.Name);

            TypeAdapterConfig<CreateEmployeeDto, Employee>
                .NewConfig();

            TypeAdapterConfig<UpdateEmployeeDto, Employee>
                .NewConfig();
        }
    }
}
