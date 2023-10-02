﻿using System;
using Freelancer.Abstract;
using Freelancer.Common;

namespace Freelancer.Entities
{
    
    internal class Customer : Person<Guid>, ICsvConvertible
    {
        public string PhoneNumber { get; set; }


        public string GetValuesCSV()
        {
            return $"{Id},{CreatedOn},{FirstName},{LastName},{PhoneNumber}";
        }

        public void SetValueCSV(string csvLine)
        {
            string[] data = csvLine.Split(',');

            Id = Guid.Parse(data[0]);
            CreatedOn = DateTimeOffset.Parse(data[1]);
            FirstName = data[2];
            LastName = data[3];
            PhoneNumber = data[4];

        }

    }


}