using System;
using Orders.Models;

namespace Orders.Dtos
{
    public class OrderDto
    {
        public Guid Id { get; set; }
        public OrderStates State { get; set; }
        public string StateName { get => State.ToString(); }
    }
}