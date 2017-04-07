namespace HotelWebApi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Booking")]
    public partial class Booking
    {
        [Key]
        public int Booking_ID { get; set; }

        public int Guest_ID { get; set; }

        public int Room_ID { get; set; }

        public DateTime Date_From { get; set; }

        public DateTime Date_To { get; set; }

        public virtual Guest Guest { get; set; }

        public virtual Room Room { get; set; }
    }
}
