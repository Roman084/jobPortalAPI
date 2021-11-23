namespace jobPortalAPI.Domain.Models.JobPostModels
{
    public class JobPostAddressModel
    {
        public int Id { get; set; }
        public string RIIK_ISO_KOOD { get; set; }
        public string RIIK_NIMI { get; set; }
        public string ADRID { get; set; }
        public string ADOBID { get; set; }
        public string TEKST { get; set; }
        public string LISAINFO { get; set; }
        public string POSTIINDEKS { get; set; }
    }
}