﻿namespace minhaAppwebAPI.model
{
    public interface IEmployeeRepository
    {
        void Add(Employee employee);

        List<Employee> Get();

    }
}
