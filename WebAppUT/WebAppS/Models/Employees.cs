using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class Employees
    {
        public Employees()
        {
            AssignmentsCompleted = new HashSet<AssignmentsCompleted>();
            AuthorizedEmployees = new HashSet<AuthorizedEmployees>();
            CompetencyCompleted = new HashSet<CompetencyCompleted>();
            EmailDistributionUsers = new HashSet<EmailDistributionUsers>();
            EmployeeAdditionalInformation = new HashSet<EmployeeAdditionalInformation>();
            EmployeeFiles = new HashSet<EmployeeFiles>();
            EmployeeLog = new HashSet<EmployeeLog>();
            EmployeesFavoriteReports = new HashSet<EmployeesFavoriteReports>();
            EscalationHistory = new HashSet<EscalationHistory>();
            EventInvitations = new HashSet<EventInvitations>();
            ExternalLms = new HashSet<ExternalLms>();
            FavoriteListEmployees = new HashSet<FavoriteListEmployees>();
            FavoriteLists = new HashSet<FavoriteLists>();
            GroupTrainingEmployees = new HashSet<GroupTrainingEmployees>();
            LayoutSettingsNavigation = new HashSet<LayoutSettings>();
            Notifications = new HashSet<Notifications>();
            ReassignedTasks = new HashSet<ReassignedTasks>();
            ReportSavedParams = new HashSet<ReportSavedParams>();
            ReportsCustoms = new HashSet<ReportsCustoms>();
            RunPages = new HashSet<RunPages>();
            SetUserAssigneds = new HashSet<SetUserAssigneds>();
            Sets = new HashSet<Sets>();
            TrainingsCompleted = new HashSet<TrainingsCompleted>();
            UserAddresses = new HashSet<UserAddresses>();
            UserCertificates = new HashSet<UserCertificates>();
        }

        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int ProfileId { get; set; }
        public string Pin { get; set; }
        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public bool IsActive { get; set; }
        public int DefaultLanguageId { get; set; }
        public int? DefaultSkinId { get; set; }
        public int? CurrentTrainingId { get; set; }
        public int? CurrentFlowId { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public string LastLoginIp { get; set; }
        public int? ConnectionSpeed { get; set; }
        public string AdditionalNumber { get; set; }
        public int? SupervisorId { get; set; }
        public int? ManagerId { get; set; }
        public int? ReportingId { get; set; }
        public DateTime? LastRequestDate { get; set; }
        public bool NewFlag { get; set; }
        public DateTime? OutOfReceivingEmailDate { get; set; }
        public bool IsLicenseAccept { get; set; }
        public bool? IsLocked { get; set; }
        public bool? IsPendingChanges { get; set; }
        public bool? IsPasswordChangeRequired { get; set; }
        public DateTime? DateOfPasswordChange { get; set; }
        public int? RequirePasswordChangeFrequency { get; set; }
        public string DomainUserName { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public int? DefaultCategoryId { get; set; }
        public bool WhatsNew { get; set; }
        public string LayoutSettings { get; set; }
        public int? Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? MaritalStatus { get; set; }
        public DateTime? ImportDate { get; set; }
        public string PreferredFirstName { get; set; }
        public bool? ShowOnBoardingTasks { get; set; }
        public int? HubSpotId { get; set; }
        public string PictureBlobName { get; set; }
        public DateTimeOffset? CreateDate { get; set; }
        public string CompanyName { get; set; }
        public string DoctorName { get; set; }
        public int? PgclientId { get; set; }
        public int? FoundInfoId { get; set; }
        public string FoundInfoOther { get; set; }
        public string SalesPersonOther { get; set; }
        public string LoginToken { get; set; }

        public ICollection<AssignmentsCompleted> AssignmentsCompleted { get; set; }
        public ICollection<AuthorizedEmployees> AuthorizedEmployees { get; set; }
        public ICollection<CompetencyCompleted> CompetencyCompleted { get; set; }
        public ICollection<EmailDistributionUsers> EmailDistributionUsers { get; set; }
        public ICollection<EmployeeAdditionalInformation> EmployeeAdditionalInformation { get; set; }
        public ICollection<EmployeeFiles> EmployeeFiles { get; set; }
        public ICollection<EmployeeLog> EmployeeLog { get; set; }
        public ICollection<EmployeesFavoriteReports> EmployeesFavoriteReports { get; set; }
        public ICollection<EscalationHistory> EscalationHistory { get; set; }
        public ICollection<EventInvitations> EventInvitations { get; set; }
        public ICollection<ExternalLms> ExternalLms { get; set; }
        public ICollection<FavoriteListEmployees> FavoriteListEmployees { get; set; }
        public ICollection<FavoriteLists> FavoriteLists { get; set; }
        public ICollection<GroupTrainingEmployees> GroupTrainingEmployees { get; set; }
        public ICollection<LayoutSettings> LayoutSettingsNavigation { get; set; }
        public ICollection<Notifications> Notifications { get; set; }
        public ICollection<ReassignedTasks> ReassignedTasks { get; set; }
        public ICollection<ReportSavedParams> ReportSavedParams { get; set; }
        public ICollection<ReportsCustoms> ReportsCustoms { get; set; }
        public ICollection<RunPages> RunPages { get; set; }
        public ICollection<SetUserAssigneds> SetUserAssigneds { get; set; }
        public ICollection<Sets> Sets { get; set; }
        public ICollection<TrainingsCompleted> TrainingsCompleted { get; set; }
        public ICollection<UserAddresses> UserAddresses { get; set; }
        public ICollection<UserCertificates> UserCertificates { get; set; }
    }
}
