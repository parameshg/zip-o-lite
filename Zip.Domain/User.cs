﻿using System;

namespace Zip.Domain
{
    public class User
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public float Salary { get; set; }

        public float Expense { get; set; }
    }
}