using System;

namespace Deliveries.Models
{
    public class Address
    {
        public Guid Id { get; set; }

        public string ZipCode { get; set; }

        public string Street { get; set; }

        public string City { get; set; }
    }
}