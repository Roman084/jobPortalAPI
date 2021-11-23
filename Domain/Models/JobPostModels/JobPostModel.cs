using System;
using System.Collections.Generic;

namespace jobPortalAPI.Domain.Models.JobPostModels
{
    public class JobPostModel
    {
        public Guid Id { get; set; }
        public string TOOPAKKUMINE_NUMBER { get; set; }
        public string URL { get; set; }
        public string ASUTUS_NIMI { get; set; }
        public string ASUTUS_REGISTRIKOOD { get; set; }
        public string ASUTUS_BRAND { get; set; }
        public string ASUTUS_KODULEHT { get; set; }
        public string ASUTUS_TUTVUSTUS { get; set; }
        public string LOGO { get; set; }
        public string KONTAKTISIK { get; set; }
        public string KONTAKTISIK_AMET { get; set; }
        public string TELEFON { get; set; }
        public string EMAIL { get; set; }
        public string NIMETUS { get; set; }
        public string AMETINIMETUS_TAPSUSTUS { get; set; }
        public string VALDKOND_NIMETUS { get; set; }
        public string VALDKOND_KOOD { get; set; }
        public int KOHTADE_ARV { get; set; }
        public string KANDIDEERIMISE_KP { get; set; }
        public int ON_AVALIK_TEENISTUS { get; set; }
        public int ON_TAISKOHAGA { get; set; }
        public int ON_OSAKOHAGA { get; set; }
        public string KOORMUS_TAPSUSTUS { get; set; }
        public int ON_VAHETUSTEGA { get; set; }
        public int ON_OOSITI { get; set; }
        public string TOOAEG_TAPSUSTUS { get; set; }
        public int? TOOTASU_ALATES { get; set; }
        public int? TOOTASU_KUNI { get; set; }
        public string TOOTASU_TAPSUSTUS { get; set; }
        public string TOOSUHTE_KESTUS { get; set; }
        public string TAHTAJA_TAPSUSTUS { get; set; }
        public int ON_KODUS_TOOTAMINE { get; set; }
        public string TOOYLESANDED { get; set; }
        public string OMALT_POOLT_PAKUME { get; set; }
        public string HARIDUS_TASE { get; set; }
        public string VARASEM_TOOKOGEMUS { get; set; }
        public int ON_NOUTUD_YKS_KEEL { get; set; }
        public string ARVUTIOSKUS { get; set; }
        public string ARVUTIOSKUS_TAPSUSTUS { get; set; }
        public string NOUDED { get; set; }
        public string LISAINFO { get; set; }
        public string LINK_KANDIDEERIMISE_KESKKONDA { get; set; }
    
        
        // Connection Properties
        public JobPostAddressModel ASUTUS_AADRESS { get; set; }
        public JobPostTooleasumineModel TOOLEASUMINE { get; set; }
        public ICollection<JobPostAsukohaAddressModel> TOO_ASUKOHA_AADRESSID { get; set; }
        public ICollection<JobPostHaridusModel> HARIDUS_VALDKONNAD { get; set; }
        public ICollection<JobPostAmetitunnistusModel> AMETITUNNISTUSED { get; set; }
        public ICollection<JobPostKutsetunnistusedModel> KUTSETUNNISTUSED { get; set; }
        public ICollection<JobPostKeeleoskusModel> KEELEOSKUS { get; set; }
        public ICollection<JobPostJuhilubaModel> JUHILUBA { get; set; }
        public ICollection<JobPostDocumentsModel> KANDIDEERIMISE_DOKUMENDID { get; set; }
    }
}