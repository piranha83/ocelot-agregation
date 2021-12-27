using System;

namespace Deliveries.Models
{
    public class Delivery
    {
        public Guid Id { get; set; }

        public Guid OrderId { get; set; }

        public string PhoneNumber { get; set; }

        public Address From { get; set; }

        public Address To { get; set; }
    }
}