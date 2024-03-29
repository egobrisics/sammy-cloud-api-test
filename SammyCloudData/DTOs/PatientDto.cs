﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SammyCloudData.DTOs
{
    public class PatientDto
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Gender { get; set; } // just enum???
    }
}
