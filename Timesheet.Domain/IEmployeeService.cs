﻿using Timesheet.Domain.Models;

namespace Timesheet.Domain
{
    public interface IEmployeeService
    {
        bool AddEmployee(StaffEmployee staffEmployee);
    }
}
