﻿using FormAuthenticationEmpCRUD.Domain;

namespace FormAuthenticationEmpCRUD.DTOs
{
    public class DisplayAllDto
    {
        public int Count { get; set; }
        public string HeaderTitle { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
