using System;

namespace jobPortalAPI.Domain.Models.JobPostModels
{
    public class JobPostKeeleoskusModel
    {
        public Guid Id { get; set; }
        public string KEEL { get; set; }
        public string KONE_TASE { get; set; }
        public string KIRJA_TASE { get; set; }
        public int ON_NOUTUD { get; set; }
    }
}