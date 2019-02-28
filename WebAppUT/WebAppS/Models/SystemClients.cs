using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SystemClients
    {
        public SystemClients()
        {
            ActionPendings = new HashSet<ActionPendings>();
            ActionReminders = new HashSet<ActionReminders>();
            AssignmentQuestions = new HashSet<AssignmentQuestions>();
            AuthorizedEmployees = new HashSet<AuthorizedEmployees>();
            ClientPaymentMethods = new HashSet<ClientPaymentMethods>();
            ClientProducts = new HashSet<ClientProducts>();
            ClientTrainingLicenses = new HashSet<ClientTrainingLicenses>();
            ContactInfos = new HashSet<ContactInfos>();
            ContactPersonClients = new HashSet<ContactPersonClients>();
            DeliveryMethods = new HashSet<DeliveryMethods>();
            Documents = new HashSet<Documents>();
            EmailTemplates = new HashSet<EmailTemplates>();
            EmployeeAdditionalInformation = new HashSet<EmployeeAdditionalInformation>();
            EventCertificates = new HashSet<EventCertificates>();
            EventGroup = new HashSet<EventGroup>();
            EventProducts = new HashSet<EventProducts>();
            EventReminder = new HashSet<EventReminder>();
            EventTypes = new HashSet<EventTypes>();
            EventsAttachedFile = new HashSet<EventsAttachedFile>();
            EventsLogo = new HashSet<EventsLogo>();
            ExternalLms = new HashSet<ExternalLms>();
            FavoriteLists = new HashSet<FavoriteLists>();
            Files = new HashSet<Files>();
            GroupTrainingEmployees = new HashSet<GroupTrainingEmployees>();
            GroupTrainings = new HashSet<GroupTrainings>();
            GroupTranslation = new HashSet<GroupTranslation>();
            Invoices = new HashSet<Invoices>();
            LayoutSettings = new HashSet<LayoutSettings>();
            LicenseFiles = new HashSet<LicenseFiles>();
            NotificationSettings = new HashSet<NotificationSettings>();
            Notifications = new HashSet<Notifications>();
            OrderProducts = new HashSet<OrderProducts>();
            OrderRenewNotifications = new HashSet<OrderRenewNotifications>();
            Orders = new HashSet<Orders>();
            PaymentReminds = new HashSet<PaymentReminds>();
            Profiles = new HashSet<Profiles>();
            QuizLog = new HashSet<QuizLog>();
            ReassignedTasks = new HashSet<ReassignedTasks>();
            Regions = new HashSet<Regions>();
            ReportClients = new HashSet<ReportClients>();
            Reports = new HashSet<Reports>();
            ReportsCustoms = new HashSet<ReportsCustoms>();
            RunLog = new HashSet<RunLog>();
            SetAssigneds = new HashSet<SetAssigneds>();
            SetUserAssigneds = new HashSet<SetUserAssigneds>();
            Sets = new HashSet<Sets>();
            Subject = new HashSet<Subject>();
            SystemGroups = new HashSet<SystemGroups>();
            TextBases = new HashSet<TextBases>();
            TrainingsCompleted = new HashSet<TrainingsCompleted>();
            TrainingsOwners = new HashSet<TrainingsOwners>();
            Transactions = new HashSet<Transactions>();
            UserAddresses = new HashSet<UserAddresses>();
            UserCertificates = new HashSet<UserCertificates>();
            WalkThroughAssigns = new HashSet<WalkThroughAssigns>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string UniqueUrl { get; set; }
        public string Url { get; set; }
        public bool? IsActive { get; set; }
        public int WhiteLabelId { get; set; }
        public int GracePeriod { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public int? IndustryId { get; set; }
        public int RetryAttempts { get; set; }
        public int? ParentLevel { get; set; }
        public bool IsTestAccount { get; set; }
        public string BlobName { get; set; }
        public int? HubSpotId { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsRequireAcceptanceOfLicense { get; set; }
        public bool IsChangeToIsActiveUponLicense { get; set; }
        public string UponAcceptanceSendEmails { get; set; }
        public bool IsRequirUserAccept { get; set; }
        public int? LicenseFileId { get; set; }
        public int? UserLicenseFileId { get; set; }
        public DateTime? RequestNameChangeDate { get; set; }
        public int? RequestNameChangeCount { get; set; }
        public string UponUserAcceptanceSendEmails { get; set; }
        public bool IsAllowRosterInfo { get; set; }
        public bool RequireJobDescription { get; set; }
        public bool RequireDepartment { get; set; }
        public bool RequireLocation { get; set; }
        public int? PlanId { get; set; }

        public SubscriptionPlans Plan { get; set; }
        public ICollection<ActionPendings> ActionPendings { get; set; }
        public ICollection<ActionReminders> ActionReminders { get; set; }
        public ICollection<AssignmentQuestions> AssignmentQuestions { get; set; }
        public ICollection<AuthorizedEmployees> AuthorizedEmployees { get; set; }
        public ICollection<ClientPaymentMethods> ClientPaymentMethods { get; set; }
        public ICollection<ClientProducts> ClientProducts { get; set; }
        public ICollection<ClientTrainingLicenses> ClientTrainingLicenses { get; set; }
        public ICollection<ContactInfos> ContactInfos { get; set; }
        public ICollection<ContactPersonClients> ContactPersonClients { get; set; }
        public ICollection<DeliveryMethods> DeliveryMethods { get; set; }
        public ICollection<Documents> Documents { get; set; }
        public ICollection<EmailTemplates> EmailTemplates { get; set; }
        public ICollection<EmployeeAdditionalInformation> EmployeeAdditionalInformation { get; set; }
        public ICollection<EventCertificates> EventCertificates { get; set; }
        public ICollection<EventGroup> EventGroup { get; set; }
        public ICollection<EventProducts> EventProducts { get; set; }
        public ICollection<EventReminder> EventReminder { get; set; }
        public ICollection<EventTypes> EventTypes { get; set; }
        public ICollection<EventsAttachedFile> EventsAttachedFile { get; set; }
        public ICollection<EventsLogo> EventsLogo { get; set; }
        public ICollection<ExternalLms> ExternalLms { get; set; }
        public ICollection<FavoriteLists> FavoriteLists { get; set; }
        public ICollection<Files> Files { get; set; }
        public ICollection<GroupTrainingEmployees> GroupTrainingEmployees { get; set; }
        public ICollection<GroupTrainings> GroupTrainings { get; set; }
        public ICollection<GroupTranslation> GroupTranslation { get; set; }
        public ICollection<Invoices> Invoices { get; set; }
        public ICollection<LayoutSettings> LayoutSettings { get; set; }
        public ICollection<LicenseFiles> LicenseFiles { get; set; }
        public ICollection<NotificationSettings> NotificationSettings { get; set; }
        public ICollection<Notifications> Notifications { get; set; }
        public ICollection<OrderProducts> OrderProducts { get; set; }
        public ICollection<OrderRenewNotifications> OrderRenewNotifications { get; set; }
        public ICollection<Orders> Orders { get; set; }
        public ICollection<PaymentReminds> PaymentReminds { get; set; }
        public ICollection<Profiles> Profiles { get; set; }
        public ICollection<QuizLog> QuizLog { get; set; }
        public ICollection<ReassignedTasks> ReassignedTasks { get; set; }
        public ICollection<Regions> Regions { get; set; }
        public ICollection<ReportClients> ReportClients { get; set; }
        public ICollection<Reports> Reports { get; set; }
        public ICollection<ReportsCustoms> ReportsCustoms { get; set; }
        public ICollection<RunLog> RunLog { get; set; }
        public ICollection<SetAssigneds> SetAssigneds { get; set; }
        public ICollection<SetUserAssigneds> SetUserAssigneds { get; set; }
        public ICollection<Sets> Sets { get; set; }
        public ICollection<Subject> Subject { get; set; }
        public ICollection<SystemGroups> SystemGroups { get; set; }
        public ICollection<TextBases> TextBases { get; set; }
        public ICollection<TrainingsCompleted> TrainingsCompleted { get; set; }
        public ICollection<TrainingsOwners> TrainingsOwners { get; set; }
        public ICollection<Transactions> Transactions { get; set; }
        public ICollection<UserAddresses> UserAddresses { get; set; }
        public ICollection<UserCertificates> UserCertificates { get; set; }
        public ICollection<WalkThroughAssigns> WalkThroughAssigns { get; set; }
    }
}
