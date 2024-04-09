﻿namespace trackingApp.Models
{
    public class Appointment
    {
        public long Id {  get; set; }
        public DateTime StartDate {  get; set; }
        public DateTime EndDate {  get; set; }
        public string? Notes { get; set; }
    }
}
