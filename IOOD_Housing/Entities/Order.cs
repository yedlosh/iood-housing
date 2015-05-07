using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IOOD_Housing.Entities
{
    class Order
    {

        public enum State { 
            Open,
            Submitted
        }

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int HouseId { get; set; }
        public DateTime OrderDate { get; set; }
        public State Status { get; set; }
        public bool Paid { get; set; }
        public DateTime FoundationReady { get; set; }
        public bool PlanPermission { get; set; }
        public bool ContractSigned { get; set; }
    }
}
