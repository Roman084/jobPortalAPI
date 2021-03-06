// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using jobPortalAPI.Data;

#nullable disable

namespace jobPortalAPI.Migrations
{
    [DbContext(typeof(DataDbContext))]
    [Migration("20211124115213_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("jobPortalAPI.Data.Entities.ApplicantDocument", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ApplicantDocument");
                });

            modelBuilder.Entity("jobPortalAPI.Data.Entities.ApplicantLogo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ApplicantLogo");
                });

            modelBuilder.Entity("jobPortalAPI.Data.Entities.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyBusinessId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CompanyDocumentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CompanyLogoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProfileDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyDocumentId");

                    b.HasIndex("CompanyLogoId");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("jobPortalAPI.Data.Entities.CompanyAdditionalUsers", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("CompanyAdditionalUsers");
                });

            modelBuilder.Entity("jobPortalAPI.Data.Entities.CompanyDocument", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CompanyDocument");
                });

            modelBuilder.Entity("jobPortalAPI.Data.Entities.CompanyLogo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CompanyLogo");
                });

            modelBuilder.Entity("jobPortalAPI.Data.Entities.JobPost", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CampaignType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyBrandName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyBusinessId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyPageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComputerSkills")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComputerSkillsMoreInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactMember")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactMemberJob")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateOfApplication")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DurationOfEmployment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DurationOfEmploymentMoreInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InfoAboutLoad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IsNightShift")
                        .HasColumnType("int");

                    b.Property<int>("IsOpenedService")
                        .HasColumnType("int");

                    b.Property<int>("IsPartPlace")
                        .HasColumnType("int");

                    b.Property<int>("IsPermanentPlace")
                        .HasColumnType("int");

                    b.Property<int>("IsRemotelyWork")
                        .HasColumnType("int");

                    b.Property<int>("IsShift")
                        .HasColumnType("int");

                    b.Property<string>("JobDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("JobPostAddressId")
                        .HasColumnType("int");

                    b.Property<int>("JobPostCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("JobPostNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("JobPostTooleasumineId")
                        .HasColumnType("int");

                    b.Property<string>("LevelOfEducation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoreInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OneLanguageWillBeAccepted")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlaceCount")
                        .HasColumnType("int");

                    b.Property<string>("Requirements")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SalaryMoreInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleSpecification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalApplicants")
                        .HasColumnType("int");

                    b.Property<int>("TotalLikes")
                        .HasColumnType("int");

                    b.Property<int>("TotalViewed")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlToApplyJob")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WeOffer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkExperience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WorkingSalaryMax")
                        .HasColumnType("int");

                    b.Property<int?>("WorkingSalaryMin")
                        .HasColumnType("int");

                    b.Property<string>("WorkingTime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("JobPostAddressId");

                    b.HasIndex("JobPostCategoryId");

                    b.HasIndex("JobPostTooleasumineId");

                    b.ToTable("JobPost");
                });

            modelBuilder.Entity("jobPortalAPI.Data.Entities.JobPostAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoreInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ObjectId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("JobPostAddress");
                });

            modelBuilder.Entity("jobPortalAPI.Data.Entities.JobPostAmetitunnistus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("JobPostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Professional")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("JobPostId");

                    b.ToTable("JobPostAmetitunnistus");
                });

            modelBuilder.Entity("jobPortalAPI.Data.Entities.JobPostAsukohaAddress", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("JobPostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MoreInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ObjectId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("JobPostId");

                    b.ToTable("JobPostAsukohaAddress");
                });

            modelBuilder.Entity("jobPortalAPI.Data.Entities.JobPostCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("EeType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("JobPostCategory");
                });

            modelBuilder.Entity("jobPortalAPI.Data.Entities.JobPostDocuments", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Document")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("JobPostId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("JobPostId");

                    b.ToTable("JobPostDocuments");
                });

            modelBuilder.Entity("jobPortalAPI.Data.Entities.JobPostHaridus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AreaInCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("JobPostId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("JobPostId");

                    b.ToTable("JobPostHaridus");
                });

            modelBuilder.Entity("jobPortalAPI.Data.Entities.JobPostJuhiluba", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("JobPostId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("JobPostId");

                    b.ToTable("JobPostJuhiluba");
                });

            modelBuilder.Entity("jobPortalAPI.Data.Entities.JobPostKeeleoskus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("IsRequired")
                        .HasColumnType("int");

                    b.Property<Guid?>("JobPostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Speaking")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Writing")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("JobPostId");

                    b.ToTable("JobPostKeeleoskus");
                });

            modelBuilder.Entity("jobPortalAPI.Data.Entities.JobPostKutsetunnistused", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("JobPostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Professional")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("JobPostId");

                    b.ToTable("JobPostKutsetunnistus");
                });

            modelBuilder.Entity("jobPortalAPI.Data.Entities.JobPostTooleasumine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Day")
                        .HasColumnType("int");

                    b.Property<int>("IsFastRequired")
                        .HasColumnType("int");

                    b.Property<int?>("Month")
                        .HasColumnType("int");

                    b.Property<int?>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("JobPostTooleasumine");
                });

            modelBuilder.Entity("jobPortalAPI.Data.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("EmailUnsubscribe")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("UserType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId")
                        .IsUnique()
                        .HasFilter("[CompanyId] IS NOT NULL");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("jobPortalAPI.Data.Entities.Company", b =>
                {
                    b.HasOne("jobPortalAPI.Data.Entities.CompanyDocument", "CompanyDocument")
                        .WithMany()
                        .HasForeignKey("CompanyDocumentId");

                    b.HasOne("jobPortalAPI.Data.Entities.CompanyLogo", "CompanyLogo")
                        .WithMany()
                        .HasForeignKey("CompanyLogoId");

                    b.Navigation("CompanyDocument");

                    b.Navigation("CompanyLogo");
                });

            modelBuilder.Entity("jobPortalAPI.Data.Entities.CompanyAdditionalUsers", b =>
                {
                    b.HasOne("jobPortalAPI.Data.Entities.Company", "Company")
                        .WithMany("CompanyAdditionalUsers")
                        .HasForeignKey("CompanyId");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("jobPortalAPI.Data.Entities.JobPost", b =>
                {
                    b.HasOne("jobPortalAPI.Data.Entities.JobPostAddress", "JobPostAddress")
                        .WithMany()
                        .HasForeignKey("JobPostAddressId");

                    b.HasOne("jobPortalAPI.Data.Entities.JobPostCategory", "JobPostCategory")
                        .WithMany()
                        .HasForeignKey("JobPostCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("jobPortalAPI.Data.Entities.JobPostTooleasumine", "JobPostTooleasumine")
                        .WithMany()
                        .HasForeignKey("JobPostTooleasumineId");

                    b.Navigation("JobPostAddress");

                    b.Navigation("JobPostCategory");

                    b.Navigation("JobPostTooleasumine");
                });

            modelBuilder.Entity("jobPortalAPI.Data.Entities.JobPostAmetitunnistus", b =>
                {
                    b.HasOne("jobPortalAPI.Data.Entities.JobPost", "JobPost")
                        .WithMany("JobPostAmetitunnistus")
                        .HasForeignKey("JobPostId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("JobPost");
                });

            modelBuilder.Entity("jobPortalAPI.Data.Entities.JobPostAsukohaAddress", b =>
                {
                    b.HasOne("jobPortalAPI.Data.Entities.JobPost", "JobPost")
                        .WithMany("JobPostAsukohaAddress")
                        .HasForeignKey("JobPostId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("JobPost");
                });

            modelBuilder.Entity("jobPortalAPI.Data.Entities.JobPostDocuments", b =>
                {
                    b.HasOne("jobPortalAPI.Data.Entities.JobPost", "JobPost")
                        .WithMany("JobPostDocuments")
                        .HasForeignKey("JobPostId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("JobPost");
                });

            modelBuilder.Entity("jobPortalAPI.Data.Entities.JobPostHaridus", b =>
                {
                    b.HasOne("jobPortalAPI.Data.Entities.JobPost", "JobPost")
                        .WithMany("JobPostHaridus")
                        .HasForeignKey("JobPostId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("JobPost");
                });

            modelBuilder.Entity("jobPortalAPI.Data.Entities.JobPostJuhiluba", b =>
                {
                    b.HasOne("jobPortalAPI.Data.Entities.JobPost", "JobPost")
                        .WithMany("JobPostJuhiluba")
                        .HasForeignKey("JobPostId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("JobPost");
                });

            modelBuilder.Entity("jobPortalAPI.Data.Entities.JobPostKeeleoskus", b =>
                {
                    b.HasOne("jobPortalAPI.Data.Entities.JobPost", "JobPost")
                        .WithMany("JobPostKeeleoskus")
                        .HasForeignKey("JobPostId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("JobPost");
                });

            modelBuilder.Entity("jobPortalAPI.Data.Entities.JobPostKutsetunnistused", b =>
                {
                    b.HasOne("jobPortalAPI.Data.Entities.JobPost", "JobPost")
                        .WithMany("JobPostKutsetunnistused")
                        .HasForeignKey("JobPostId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("JobPost");
                });

            modelBuilder.Entity("jobPortalAPI.Data.Entities.User", b =>
                {
                    b.HasOne("jobPortalAPI.Data.Entities.Company", "Company")
                        .WithOne("User")
                        .HasForeignKey("jobPortalAPI.Data.Entities.User", "CompanyId");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("jobPortalAPI.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("jobPortalAPI.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("jobPortalAPI.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("jobPortalAPI.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("jobPortalAPI.Data.Entities.Company", b =>
                {
                    b.Navigation("CompanyAdditionalUsers");

                    b.Navigation("User");
                });

            modelBuilder.Entity("jobPortalAPI.Data.Entities.JobPost", b =>
                {
                    b.Navigation("JobPostAmetitunnistus");

                    b.Navigation("JobPostAsukohaAddress");

                    b.Navigation("JobPostDocuments");

                    b.Navigation("JobPostHaridus");

                    b.Navigation("JobPostJuhiluba");

                    b.Navigation("JobPostKeeleoskus");

                    b.Navigation("JobPostKutsetunnistused");
                });
#pragma warning restore 612, 618
        }
    }
}
