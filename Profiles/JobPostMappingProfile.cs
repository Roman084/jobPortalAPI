using AutoMapper;
using jobPortalAPI.Data.Entities;
using jobPortalAPI.Domain.Models.JobPostModels;

namespace jobPortalAPI.Profiles
{
    public class JobPostMappingProfile : Profile
    {
        public JobPostMappingProfile()
        {
            CreateMap<JobPostModel, JobPost>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(dest => dest.Id))
                .ForMember(dest => dest.JobPostNumber, opt => opt.MapFrom(dest => dest.TOOPAKKUMINE_NUMBER))
                .ForMember(dest => dest.Url, opt => opt.MapFrom(dest => dest.URL))
                .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(dest => dest.ASUTUS_NIMI))
                .ForMember(dest => dest.CompanyBusinessId, opt => opt.MapFrom(dest => dest.ASUTUS_REGISTRIKOOD))
                .ForMember(dest => dest.CompanyBrandName, opt => opt.MapFrom(dest => dest.ASUTUS_BRAND))
                .ForMember(dest => dest.CompanyPageUrl, opt => opt.MapFrom(dest => dest.ASUTUS_KODULEHT))
                .ForMember(dest => dest.CompanyDescription, opt => opt.MapFrom(dest => dest.ASUTUS_TUTVUSTUS))
                .ForMember(dest => dest.Logo, opt => opt.MapFrom(dest => dest.LOGO))
                .ForMember(dest => dest.ContactMember, opt => opt.MapFrom(dest => dest.KONTAKTISIK))
                .ForMember(dest => dest.ContactMemberJob, opt => opt.MapFrom(dest => dest.KONTAKTISIK_AMET))
                .ForMember(dest => dest.Phone, opt => opt.MapFrom(dest => dest.TELEFON))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(dest => dest.EMAIL))
                .ForMember(dest => dest.JobName, opt => opt.MapFrom(dest => dest.NIMETUS))
                .ForMember(dest => dest.TitleSpecification, opt => opt.MapFrom(dest => dest.AMETINIMETUS_TAPSUSTUS))
                .ForMember(dest => dest.PlaceCount, opt => opt.MapFrom(dest => dest.KOHTADE_ARV))
                .ForMember(dest => dest.DateOfApplication, opt => opt.MapFrom(dest => dest.KANDIDEERIMISE_KP))
                .ForMember(dest => dest.IsOpenedService, opt => opt.MapFrom(dest => dest.ON_AVALIK_TEENISTUS))
                .ForMember(dest => dest.IsPermanentPlace, opt => opt.MapFrom(dest => dest.ON_TAISKOHAGA))
                .ForMember(dest => dest.IsPartPlace, opt => opt.MapFrom(dest => dest.ON_OSAKOHAGA))
                .ForMember(dest => dest.InfoAboutLoad, opt => opt.MapFrom(dest => dest.KOORMUS_TAPSUSTUS))
                .ForMember(dest => dest.IsShift, opt => opt.MapFrom(dest => dest.ON_VAHETUSTEGA))
                .ForMember(dest => dest.IsNightShift, opt => opt.MapFrom(dest => dest.ON_OOSITI))
                .ForMember(dest => dest.WorkingTime, opt => opt.MapFrom(dest => dest.TOOAEG_TAPSUSTUS))
                .ForMember(dest => dest.WorkingSalaryMin, opt => opt.MapFrom(dest => dest.TOOTASU_ALATES))
                .ForMember(dest => dest.WorkingSalaryMax, opt => opt.MapFrom(dest => dest.TOOTASU_KUNI))
                .ForMember(dest => dest.SalaryMoreInfo, opt => opt.MapFrom(dest => dest.TOOTASU_TAPSUSTUS))
                .ForMember(dest => dest.DurationOfEmployment, opt => opt.MapFrom(dest => dest.TOOSUHTE_KESTUS))
                .ForMember(dest => dest.DurationOfEmploymentMoreInfo, opt => opt.MapFrom(dest => dest.TAHTAJA_TAPSUSTUS))
                .ForMember(dest => dest.IsRemotelyWork, opt => opt.MapFrom(dest => dest.ON_KODUS_TOOTAMINE))
                .ForMember(dest => dest.JobDescription, opt => opt.MapFrom(dest => dest.TOOYLESANDED))
                .ForMember(dest => dest.WeOffer, opt => opt.MapFrom(dest => dest.OMALT_POOLT_PAKUME))
                .ForMember(dest => dest.LevelOfEducation, opt => opt.MapFrom(dest => dest.HARIDUS_TASE))
                .ForMember(dest => dest.WorkExperience, opt => opt.MapFrom(dest => dest.VARASEM_TOOKOGEMUS))
                .ForMember(dest => dest.OneLanguageWillBeAccepted, opt => opt.MapFrom(dest => dest.ON_NOUTUD_YKS_KEEL))
                .ForMember(dest => dest.ComputerSkills, opt => opt.MapFrom(dest => dest.ARVUTIOSKUS))
                .ForMember(dest => dest.ComputerSkillsMoreInfo, opt => opt.MapFrom(dest => dest.ARVUTIOSKUS_TAPSUSTUS))
                .ForMember(dest => dest.Requirements, opt => opt.MapFrom(dest => dest.NOUDED))
                .ForMember(dest => dest.MoreInfo, opt => opt.MapFrom(dest => dest.LISAINFO))
                .ForMember(dest => dest.UrlToApplyJob, opt => opt.MapFrom(dest => dest.LINK_KANDIDEERIMISE_KESKKONDA))
                .ForPath(dest => dest.JobPostAddress, opt => opt.MapFrom(src => src.ASUTUS_AADRESS))
                .ForPath(dest => dest.JobPostTooleasumine, opt => opt.MapFrom(src => src.TOOLEASUMINE))
                .ForPath(dest => dest.JobPostAsukohaAddress, opt => opt.MapFrom(src => src.TOO_ASUKOHA_AADRESSID))
                .ForPath(dest => dest.JobPostHaridus, opt => opt.MapFrom(src => src.HARIDUS_VALDKONNAD))
                .ForPath(dest => dest.JobPostAmetitunnistus, opt => opt.MapFrom(src => src.AMETITUNNISTUSED))
                .ForPath(dest => dest.JobPostKutsetunnistused, opt => opt.MapFrom(src => src.KUTSETUNNISTUSED))
                .ForPath(dest => dest.JobPostKeeleoskus, opt => opt.MapFrom(src => src.KEELEOSKUS))
                .ForPath(dest => dest.JobPostJuhiluba, opt => opt.MapFrom(src => src.JUHILUBA))
                .ForPath(dest => dest.JobPostDocuments, opt => opt.MapFrom(src => src.KANDIDEERIMISE_DOKUMENDID))
                .ForMember(dest => dest.JobPostCategory, opt => opt.Ignore())
                ;

            CreateMap<JobPostAddressModel, JobPostAddress>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(dest => dest.Id))
                .ForMember(dest => dest.CountryCode, opt => opt.MapFrom(dest => dest.RIIK_ISO_KOOD))
                .ForMember(dest => dest.CountryName, opt => opt.MapFrom(dest => dest.RIIK_NIMI))
                .ForMember(dest => dest.AddressId, opt => opt.MapFrom(dest => dest.ADRID))
                .ForMember(dest => dest.ObjectId, opt => opt.MapFrom(dest => dest.ADOBID))
                .ForMember(dest => dest.Address, opt => opt.MapFrom(dest => dest.TEKST))
                .ForMember(dest => dest.MoreInfo, opt => opt.MapFrom(dest => dest.LISAINFO))
                .ForMember(dest => dest.ZipCode, opt => opt.MapFrom(dest => dest.POSTIINDEKS))
                ;

            CreateMap<JobPostAmetitunnistusModel, JobPostAmetitunnistus>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(dest => dest.Id))
                .ForMember(dest => dest.Professional, opt => opt.MapFrom(dest => dest.AMETITUNNISTUS))
                ;

            CreateMap<JobPostAsukohaAddressModel, JobPostAsukohaAddress>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(dest => dest.Id))
                .ForMember(dest => dest.CountryCode, opt => opt.MapFrom(dest => dest.RIIK_ISO_KOOD))
                .ForMember(dest => dest.CountryName, opt => opt.MapFrom(dest => dest.RIIK_NIMI))
                .ForMember(dest => dest.AddressId, opt => opt.MapFrom(dest => dest.ADRID))
                .ForMember(dest => dest.ObjectId, opt => opt.MapFrom(dest => dest.ADOBID))
                .ForMember(dest => dest.Address, opt => opt.MapFrom(dest => dest.TEKST))
                .ForMember(dest => dest.MoreInfo, opt => opt.MapFrom(dest => dest.LISAINFO))
                .ForMember(dest => dest.ZipCode, opt => opt.MapFrom(dest => dest.POSTIINDEKS))
                ;
            
            CreateMap<JobPostDocumentsModel, JobPostDocuments>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(dest => dest.Id))
                .ForMember(dest => dest.Document, opt => opt.MapFrom(dest => dest.DOKUMENT))
                ;
            
            CreateMap<JobPostHaridusModel, JobPostHaridus>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(dest => dest.Id))
                .ForMember(dest => dest.AreaInCountry, opt => opt.MapFrom(dest => dest.VALDKOND))
                ;
            
            CreateMap<JobPostJuhilubaModel, JobPostJuhiluba>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(dest => dest.Id))
                .ForMember(dest => dest.Category, opt => opt.MapFrom(dest => dest.KATEGOORIA))
                ;
            
            CreateMap<JobPostKeeleoskusModel, JobPostKeeleoskus>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(dest => dest.Id))
                .ForMember(dest => dest.Language, opt => opt.MapFrom(dest => dest.KEEL))
                .ForMember(dest => dest.Speaking, opt => opt.MapFrom(dest => dest.KONE_TASE))
                .ForMember(dest => dest.Writing, opt => opt.MapFrom(dest => dest.KIRJA_TASE))
                .ForMember(dest => dest.IsRequired, opt => opt.MapFrom(dest => dest.ON_NOUTUD))
                ;
            
            CreateMap<JobPostKutsetunnistusedModel, JobPostKutsetunnistused>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(dest => dest.Id))
                .ForMember(dest => dest.Professional, opt => opt.MapFrom(dest => dest.KUTSETUNNISTUS))
                ;
            
            CreateMap<JobPostTooleasumineModel, JobPostTooleasumine>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(dest => dest.Id))
                .ForMember(dest => dest.IsFastRequired, opt => opt.MapFrom(dest => dest.ON_KIIRESTI_VAJA))
                .ForMember(dest => dest.Year, opt => opt.MapFrom(dest => dest.AASTA))
                .ForMember(dest => dest.Month, opt => opt.MapFrom(dest => dest.KUU))
                .ForMember(dest => dest.Day, opt => opt.MapFrom(dest => dest.PAEV))
                ;
            
            CreateMap<JobPost, JobPostCategory>()
                .ForMember(dest => dest.Type, opt => opt.MapFrom(dest => dest.JobPostCategory.Type))
                .ForMember(dest => dest.EeType, opt => opt.MapFrom(dest => dest.JobPostCategory.EeType))
                ;
            
            
            CreateMap<JobPostCategoryModel, JobPostCategory>();
            CreateMap<JobPostCategory, JobPostCategoryModel>();
            
        }
    }
}