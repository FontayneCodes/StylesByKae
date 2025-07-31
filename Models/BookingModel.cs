using System;
using System.ComponentModel.DataAnnotations;

namespace DemoHairSite.Models
    {
    public class BookingModel
        {
        public int Id
            {
            get; set;
            }

        [Required]
        public string? CustomerName
            {
            get; set;
            } = default!;

        [Required]
        [EmailAddress]
        public string Email
            {
            get; set;
            } = default!;

        [Required]
        public DateTime AppointmentDate
            {
            get; set;
            } = default!;

        [Required]
        public string ServiceName
            {
            get; set;
            } = default!;

        public string Notes
            {
            get; set;
            } = default!;
        }
    }
