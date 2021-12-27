using System;

namespace Deliveries.Dtos
{
    public class DeliveryDto
    {
        public Guid Id { get; set; }

        public string PhoneNumber { get; set; }

        public AddressDto From { get; set; }

        public AddressDto To { get; set; }
    }
}