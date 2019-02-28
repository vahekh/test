using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAppS.Models
{
    public partial class STC_1Context : DbContext
    {
        public STC_1Context()
        {
        }

        public STC_1Context(DbContextOptions<STC_1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Accountants> Accountants { get; set; }
        public virtual DbSet<ActionFilter> ActionFilter { get; set; }
        public virtual DbSet<ActionLogs> ActionLogs { get; set; }
        public virtual DbSet<ActionPendings> ActionPendings { get; set; }
        public virtual DbSet<ActionPermissions> ActionPermissions { get; set; }
        public virtual DbSet<ActionReminders> ActionReminders { get; set; }
        public virtual DbSet<AdCampaigns> AdCampaigns { get; set; }
        public virtual DbSet<AdTrackings> AdTrackings { get; set; }
        public virtual DbSet<AssignmentAnswers> AssignmentAnswers { get; set; }
        public virtual DbSet<AssignmentQuestions> AssignmentQuestions { get; set; }
        public virtual DbSet<AssignmentsCompleted> AssignmentsCompleted { get; set; }
        public virtual DbSet<AuthorizedEmployees> AuthorizedEmployees { get; set; }
        public virtual DbSet<Cehours> Cehours { get; set; }
        public virtual DbSet<CertificateForms> CertificateForms { get; set; }
        public virtual DbSet<CertificatePrintLog> CertificatePrintLog { get; set; }
        public virtual DbSet<CertificateTrainings> CertificateTrainings { get; set; }
        public virtual DbSet<Cfrs> Cfrs { get; set; }
        public virtual DbSet<ClientActions> ClientActions { get; set; }
        public virtual DbSet<ClientActionTypes> ClientActionTypes { get; set; }
        public virtual DbSet<ClientAssignments> ClientAssignments { get; set; }
        public virtual DbSet<ClientAssignmentsRegenererated> ClientAssignmentsRegenererated { get; set; }
        public virtual DbSet<ClientLogs> ClientLogs { get; set; }
        public virtual DbSet<ClientMedias> ClientMedias { get; set; }
        public virtual DbSet<ClientPaymentMethods> ClientPaymentMethods { get; set; }
        public virtual DbSet<ClientProducts> ClientProducts { get; set; }
        public virtual DbSet<ClientsReports> ClientsReports { get; set; }
        public virtual DbSet<ClientTimeZones> ClientTimeZones { get; set; }
        public virtual DbSet<ClientTrainingFiles> ClientTrainingFiles { get; set; }
        public virtual DbSet<ClientTrainingLicenseLogs> ClientTrainingLicenseLogs { get; set; }
        public virtual DbSet<ClientTrainingLicenses> ClientTrainingLicenses { get; set; }
        public virtual DbSet<ClientTrainings> ClientTrainings { get; set; }
        public virtual DbSet<ClientUsers> ClientUsers { get; set; }
        public virtual DbSet<CommissionGroupAssignments> CommissionGroupAssignments { get; set; }
        public virtual DbSet<CommissionGroups> CommissionGroups { get; set; }
        public virtual DbSet<CommissionScheduleGroups> CommissionScheduleGroups { get; set; }
        public virtual DbSet<CommissionSchedules> CommissionSchedules { get; set; }
        public virtual DbSet<CompetencyCompleted> CompetencyCompleted { get; set; }
        public virtual DbSet<CompetencyLevels> CompetencyLevels { get; set; }
        public virtual DbSet<CompetencyLevelTrainings> CompetencyLevelTrainings { get; set; }
        public virtual DbSet<ContactInfos> ContactInfos { get; set; }
        public virtual DbSet<ContactPersonAddresses> ContactPersonAddresses { get; set; }
        public virtual DbSet<ContactPersonClients> ContactPersonClients { get; set; }
        public virtual DbSet<ContactPersons> ContactPersons { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<CustomFields> CustomFields { get; set; }
        public virtual DbSet<DashboardUsers> DashboardUsers { get; set; }
        public virtual DbSet<DeliveryMethods> DeliveryMethods { get; set; }
        public virtual DbSet<DiscountPrices> DiscountPrices { get; set; }
        public virtual DbSet<DiscountProducts> DiscountProducts { get; set; }
        public virtual DbSet<Discounts> Discounts { get; set; }
        public virtual DbSet<DiscountTypes> DiscountTypes { get; set; }
        public virtual DbSet<Documents> Documents { get; set; }
        public virtual DbSet<EmailDistributionList> EmailDistributionList { get; set; }
        public virtual DbSet<EmailDistributionUsers> EmailDistributionUsers { get; set; }
        public virtual DbSet<EmailTemplates> EmailTemplates { get; set; }
        public virtual DbSet<EmailTemplateTypes> EmailTemplateTypes { get; set; }
        public virtual DbSet<EmployeeActiveStatus> EmployeeActiveStatus { get; set; }
        public virtual DbSet<EmployeeAdditionalInformation> EmployeeAdditionalInformation { get; set; }
        public virtual DbSet<EmployeeFiles> EmployeeFiles { get; set; }
        public virtual DbSet<EmployeeImages> EmployeeImages { get; set; }
        public virtual DbSet<EmployeeLog> EmployeeLog { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<EmployeesFavoriteReports> EmployeesFavoriteReports { get; set; }
        public virtual DbSet<Escalation> Escalation { get; set; }
        public virtual DbSet<EscalationHistory> EscalationHistory { get; set; }
        public virtual DbSet<EscalationNotify> EscalationNotify { get; set; }
        public virtual DbSet<EventCertificates> EventCertificates { get; set; }
        public virtual DbSet<EventCourses> EventCourses { get; set; }
        public virtual DbSet<EventFiles> EventFiles { get; set; }
        public virtual DbSet<EventGroup> EventGroup { get; set; }
        public virtual DbSet<EventInvitations> EventInvitations { get; set; }
        public virtual DbSet<EventParticipants> EventParticipants { get; set; }
        public virtual DbSet<EventParticipantScore> EventParticipantScore { get; set; }
        public virtual DbSet<EventProducts> EventProducts { get; set; }
        public virtual DbSet<EventReminder> EventReminder { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<EventsAttachedFile> EventsAttachedFile { get; set; }
        public virtual DbSet<EventsLogo> EventsLogo { get; set; }
        public virtual DbSet<EventTemplates> EventTemplates { get; set; }
        public virtual DbSet<EventTypes> EventTypes { get; set; }
        public virtual DbSet<ExternalLms> ExternalLms { get; set; }
        public virtual DbSet<FavoriteListEmployees> FavoriteListEmployees { get; set; }
        public virtual DbSet<FavoriteLists> FavoriteLists { get; set; }
        public virtual DbSet<Files> Files { get; set; }
        public virtual DbSet<Folders> Folders { get; set; }
        public virtual DbSet<FoundInfos> FoundInfos { get; set; }
        public virtual DbSet<GroupTrainingEmployees> GroupTrainingEmployees { get; set; }
        public virtual DbSet<GroupTrainingFiles> GroupTrainingFiles { get; set; }
        public virtual DbSet<GroupTrainings> GroupTrainings { get; set; }
        public virtual DbSet<GroupTranslation> GroupTranslation { get; set; }
        public virtual DbSet<H5answers> H5answers { get; set; }
        public virtual DbSet<H5chapters> H5chapters { get; set; }
        public virtual DbSet<H5flow> H5flow { get; set; }
        public virtual DbSet<H5links> H5links { get; set; }
        public virtual DbSet<H5pages> H5pages { get; set; }
        public virtual DbSet<H5questions> H5questions { get; set; }
        public virtual DbSet<H5quizzes> H5quizzes { get; set; }
        public virtual DbSet<H5sources> H5sources { get; set; }
        public virtual DbSet<H5surveys> H5surveys { get; set; }
        public virtual DbSet<HelpPageFolders> HelpPageFolders { get; set; }
        public virtual DbSet<HelpPages> HelpPages { get; set; }
        public virtual DbSet<ImportDetails> ImportDetails { get; set; }
        public virtual DbSet<Industries> Industries { get; set; }
        public virtual DbSet<IndustryActions> IndustryActions { get; set; }
        public virtual DbSet<IndustryActionTypes> IndustryActionTypes { get; set; }
        public virtual DbSet<Invoices> Invoices { get; set; }
        public virtual DbSet<KeyIndicator> KeyIndicator { get; set; }
        public virtual DbSet<KeyIndicatorValues> KeyIndicatorValues { get; set; }
        public virtual DbSet<Languages> Languages { get; set; }
        public virtual DbSet<LayoutSettings> LayoutSettings { get; set; }
        public virtual DbSet<LicenseFiles> LicenseFiles { get; set; }
        public virtual DbSet<LicenseLog> LicenseLog { get; set; }
        public virtual DbSet<Links> Links { get; set; }
        public virtual DbSet<MailingAttachments> MailingAttachments { get; set; }
        public virtual DbSet<Mailings> Mailings { get; set; }
        public virtual DbSet<MailingViews> MailingViews { get; set; }
        public virtual DbSet<Notifications> Notifications { get; set; }
        public virtual DbSet<NotificationSettings> NotificationSettings { get; set; }
        public virtual DbSet<OrderChannelPartners> OrderChannelPartners { get; set; }
        public virtual DbSet<OrderProducts> OrderProducts { get; set; }
        public virtual DbSet<OrderProductSets> OrderProductSets { get; set; }
        public virtual DbSet<OrderRenewNotifications> OrderRenewNotifications { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<ParticipantsWaitingList> ParticipantsWaitingList { get; set; }
        public virtual DbSet<PaymentReminds> PaymentReminds { get; set; }
        public virtual DbSet<Payments> Payments { get; set; }
        public virtual DbSet<PracticalExam> PracticalExam { get; set; }
        public virtual DbSet<PracticalExamEmployees> PracticalExamEmployees { get; set; }
        public virtual DbSet<ProcessorPaymentsGatewayDetails> ProcessorPaymentsGatewayDetails { get; set; }
        public virtual DbSet<ProcessorPaymentsGatewayTransactions> ProcessorPaymentsGatewayTransactions { get; set; }
        public virtual DbSet<ProductActions> ProductActions { get; set; }
        public virtual DbSet<ProductBlockPrices> ProductBlockPrices { get; set; }
        public virtual DbSet<ProductIndustries> ProductIndustries { get; set; }
        public virtual DbSet<ProductLicenseFiles> ProductLicenseFiles { get; set; }
        public virtual DbSet<ProductLicenseFilesLogs> ProductLicenseFilesLogs { get; set; }
        public virtual DbSet<ProductOptions> ProductOptions { get; set; }
        public virtual DbSet<ProductReportingGroupProducts> ProductReportingGroupProducts { get; set; }
        public virtual DbSet<ProductReportingGroups> ProductReportingGroups { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<ProductTrainings> ProductTrainings { get; set; }
        public virtual DbSet<ProfileHelpPages> ProfileHelpPages { get; set; }
        public virtual DbSet<ProfileReports> ProfileReports { get; set; }
        public virtual DbSet<Profiles> Profiles { get; set; }
        public virtual DbSet<QuizLog> QuizLog { get; set; }
        public virtual DbSet<ReassignedTasks> ReassignedTasks { get; set; }
        public virtual DbSet<ReassignHistory> ReassignHistory { get; set; }
        public virtual DbSet<Regions> Regions { get; set; }
        public virtual DbSet<ReportClients> ReportClients { get; set; }
        public virtual DbSet<ReportFiles> ReportFiles { get; set; }
        public virtual DbSet<ReportFilterTypes> ReportFilterTypes { get; set; }
        public virtual DbSet<ReportParams> ReportParams { get; set; }
        public virtual DbSet<ReportParamsCustoms> ReportParamsCustoms { get; set; }
        public virtual DbSet<Reports> Reports { get; set; }
        public virtual DbSet<ReportSavedParams> ReportSavedParams { get; set; }
        public virtual DbSet<ReportSavedParamValues> ReportSavedParamValues { get; set; }
        public virtual DbSet<ReportsCustoms> ReportsCustoms { get; set; }
        public virtual DbSet<ResponseLog> ResponseLog { get; set; }
        public virtual DbSet<RunLog> RunLog { get; set; }
        public virtual DbSet<RunLogQuiz> RunLogQuiz { get; set; }
        public virtual DbSet<RunPages> RunPages { get; set; }
        public virtual DbSet<SalesPersonClients> SalesPersonClients { get; set; }
        public virtual DbSet<SalesPersonGroups> SalesPersonGroups { get; set; }
        public virtual DbSet<SalesPersons> SalesPersons { get; set; }
        public virtual DbSet<ScormVars> ScormVars { get; set; }
        public virtual DbSet<ServiceLogs> ServiceLogs { get; set; }
        public virtual DbSet<SetAssigneds> SetAssigneds { get; set; }
        public virtual DbSet<SetDetails> SetDetails { get; set; }
        public virtual DbSet<SetRegions> SetRegions { get; set; }
        public virtual DbSet<Sets> Sets { get; set; }
        public virtual DbSet<SetTopProfiles> SetTopProfiles { get; set; }
        public virtual DbSet<SetTops> SetTops { get; set; }
        public virtual DbSet<SetUserAssigneds> SetUserAssigneds { get; set; }
        public virtual DbSet<SetUserManaged> SetUserManaged { get; set; }
        public virtual DbSet<ShoppingCartCache> ShoppingCartCache { get; set; }
        public virtual DbSet<Slanswers> Slanswers { get; set; }
        public virtual DbSet<Slchapters> Slchapters { get; set; }
        public virtual DbSet<Slconfiguration> Slconfiguration { get; set; }
        public virtual DbSet<SlconfigurationForLanguages> SlconfigurationForLanguages { get; set; }
        public virtual DbSet<Sldocuments> Sldocuments { get; set; }
        public virtual DbSet<Slmedia> Slmedia { get; set; }
        public virtual DbSet<Slpages> Slpages { get; set; }
        public virtual DbSet<Slquestions> Slquestions { get; set; }
        public virtual DbSet<SlquestionsRelated> SlquestionsRelated { get; set; }
        public virtual DbSet<Slquizzes> Slquizzes { get; set; }
        public virtual DbSet<SltrainingFlow> SltrainingFlow { get; set; }
        public virtual DbSet<States> States { get; set; }
        public virtual DbSet<StreportColumns> StreportColumns { get; set; }
        public virtual DbSet<Streports> Streports { get; set; }
        public virtual DbSet<StreportsCustoms> StreportsCustoms { get; set; }
        public virtual DbSet<Subject> Subject { get; set; }
        public virtual DbSet<SubscriptionPlans> SubscriptionPlans { get; set; }
        public virtual DbSet<SurveyAnswerQuestionDetails> SurveyAnswerQuestionDetails { get; set; }
        public virtual DbSet<SurveyAnswerQuestions> SurveyAnswerQuestions { get; set; }
        public virtual DbSet<SurveyAnswers> SurveyAnswers { get; set; }
        public virtual DbSet<SurveyDocumentResults> SurveyDocumentResults { get; set; }
        public virtual DbSet<SurveyDocuments> SurveyDocuments { get; set; }
        public virtual DbSet<SurveyMissingQuestions> SurveyMissingQuestions { get; set; }
        public virtual DbSet<SurveyPredefinedAnswers> SurveyPredefinedAnswers { get; set; }
        public virtual DbSet<SurveyQuestionColumns> SurveyQuestionColumns { get; set; }
        public virtual DbSet<SurveyQuestionRates> SurveyQuestionRates { get; set; }
        public virtual DbSet<SurveyQuestionRows> SurveyQuestionRows { get; set; }
        public virtual DbSet<SurveyQuestions> SurveyQuestions { get; set; }
        public virtual DbSet<Surveys> Surveys { get; set; }
        public virtual DbSet<SurveySdssheets> SurveySdssheets { get; set; }
        public virtual DbSet<SurveyUsers> SurveyUsers { get; set; }
        public virtual DbSet<SurveyUsersSettings> SurveyUsersSettings { get; set; }
        public virtual DbSet<SyllabusAssignments> SyllabusAssignments { get; set; }
        public virtual DbSet<SyllabusNames> SyllabusNames { get; set; }
        public virtual DbSet<SystemActionFilters> SystemActionFilters { get; set; }
        public virtual DbSet<SystemActions> SystemActions { get; set; }
        public virtual DbSet<SystemActionTypes> SystemActionTypes { get; set; }
        public virtual DbSet<SystemActionWffilters> SystemActionWffilters { get; set; }
        public virtual DbSet<SystemActionWfs> SystemActionWfs { get; set; }
        public virtual DbSet<SystemAdmins> SystemAdmins { get; set; }
        public virtual DbSet<SystemCertificateForms> SystemCertificateForms { get; set; }
        public virtual DbSet<SystemCertificateTrainings> SystemCertificateTrainings { get; set; }
        public virtual DbSet<SystemClients> SystemClients { get; set; }
        public virtual DbSet<SystemEmailTemplateDefaults> SystemEmailTemplateDefaults { get; set; }
        public virtual DbSet<SystemEmailTemplates> SystemEmailTemplates { get; set; }
        public virtual DbSet<SystemGroups> SystemGroups { get; set; }
        public virtual DbSet<SystemMedia> SystemMedia { get; set; }
        public virtual DbSet<SystemNotificationList> SystemNotificationList { get; set; }
        public virtual DbSet<SystemSettings> SystemSettings { get; set; }
        public virtual DbSet<TempTransactions> TempTransactions { get; set; }
        public virtual DbSet<TextBases> TextBases { get; set; }
        public virtual DbSet<TrainingLanguageVersions> TrainingLanguageVersions { get; set; }
        public virtual DbSet<Trainings> Trainings { get; set; }
        public virtual DbSet<TrainingsCompleted> TrainingsCompleted { get; set; }
        public virtual DbSet<TrainingsOwners> TrainingsOwners { get; set; }
        public virtual DbSet<Transactions> Transactions { get; set; }
        public virtual DbSet<TransactionTypes> TransactionTypes { get; set; }
        public virtual DbSet<UserAddresses> UserAddresses { get; set; }
        public virtual DbSet<UserCertificates> UserCertificates { get; set; }
        public virtual DbSet<WalkThroughAssigns> WalkThroughAssigns { get; set; }
        public virtual DbSet<WalkThroughProfiles> WalkThroughProfiles { get; set; }
        public virtual DbSet<WalkThroughs> WalkThroughs { get; set; }
        public virtual DbSet<WalkThroughSteps> WalkThroughSteps { get; set; }
        public virtual DbSet<WfclientTasks> WfclientTasks { get; set; }
        public virtual DbSet<Wfsteps> Wfsteps { get; set; }
        public virtual DbSet<WfstepsDiagram> WfstepsDiagram { get; set; }
        public virtual DbSet<WfstepsParameters> WfstepsParameters { get; set; }
        public virtual DbSet<WfstepTemplates> WfstepTemplates { get; set; }
        public virtual DbSet<WhiteLabelHosts> WhiteLabelHosts { get; set; }
        public virtual DbSet<WhiteLabelLinks> WhiteLabelLinks { get; set; }
        public virtual DbSet<WhiteLabels> WhiteLabels { get; set; }
        public virtual DbSet<WorkfFlow> WorkfFlow { get; set; }

        // Unable to generate entity type for table 'so.DBQueryLogs'. Please see the warning messages.
        // Unable to generate entity type for table 'so.DiscountChannelPartners'. Please see the warning messages.
        // Unable to generate entity type for table 'so.FoundInfoChannelPartners'. Please see the warning messages.
        // Unable to generate entity type for table 'so.ProductChannelPartners'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=s5;Initial Catalog=STC_1;User ID=sa;Password=sa.123;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accountants>(entity =>
            {
                entity.ToTable("Accountants", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<ActionFilter>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TemplateDefaultId).HasColumnName("TemplateDefaultID");

                entity.HasOne(d => d.TemplateDefault)
                    .WithMany(p => p.ActionFilter)
                    .HasForeignKey(d => d.TemplateDefaultId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ActionFilter_EmailTemplateTypes");
            });

            modelBuilder.Entity<ActionLogs>(entity =>
            {
                entity.ToTable("ActionLogs", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ParameterId).HasColumnName("ParameterID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.ActionLogs)
                    .HasForeignKey(d => d.ActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ActionLogs_SystemActions");
            });

            modelBuilder.Entity<ActionPendings>(entity =>
            {
                entity.ToTable("ActionPendings", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.Cc).HasColumnName("CC");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Domain).IsRequired();

                entity.Property(e => e.ParameterId).HasColumnName("ParameterID");

                entity.Property(e => e.ParameterIds).HasColumnName("ParameterIDs");

                entity.Property(e => e.PhoneNumber).HasMaxLength(200);

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.SenderClientId).HasColumnName("SenderClientID");

                entity.Property(e => e.SenderEmployeeId).HasColumnName("SenderEmployeeID");

                entity.Property(e => e.SessionId).HasMaxLength(88);

                entity.Property(e => e.TemplateId).HasColumnName("TemplateID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ActionPendings)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_ActionPending_SystemClients");
            });

            modelBuilder.Entity<ActionPermissions>(entity =>
            {
                entity.HasIndex(e => new { e.ClientId, e.ActionId, e.GroupType, e.GroupTypeId })
                    .HasName("IX_ActionPermissions_ClientID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.GroupTypeId).HasColumnName("GroupTypeID");
            });

            modelBuilder.Entity<ActionReminders>(entity =>
            {
                entity.ToTable("ActionReminders", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.FailActionId).HasColumnName("FailActionID");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.SuccessActionId).HasColumnName("SuccessActionID");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.ActionReminders)
                    .HasForeignKey(d => d.ActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ActionReminders_SystemActions");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ActionReminders)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_ActionReminders_SystemClients");
            });

            modelBuilder.Entity<AdCampaigns>(entity =>
            {
                entity.ToTable("AdCampaigns", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<AdTrackings>(entity =>
            {
                entity.ToTable("AdTrackings", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Browser)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CampaignId).HasColumnName("CampaignID");

                entity.Property(e => e.GasessionId)
                    .HasColumnName("GASessionID")
                    .HasMaxLength(200);

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("IP")
                    .HasMaxLength(200);

                entity.Property(e => e.ReferringUrl)
                    .HasColumnName("ReferringURL")
                    .HasMaxLength(200);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("URL")
                    .HasMaxLength(200);

                entity.HasOne(d => d.Campaign)
                    .WithMany(p => p.AdTrackings)
                    .HasForeignKey(d => d.CampaignId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AdTracking_AdCampaigns");
            });

            modelBuilder.Entity<AssignmentAnswers>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AssignmentId).HasColumnName("AssignmentID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CompletedId).HasColumnName("CompletedID");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");
            });

            modelBuilder.Entity<AssignmentQuestions>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AssignmentId).HasColumnName("AssignmentID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.QuestionText).IsRequired();

                entity.Property(e => e.QuestionTypeId).HasColumnName("QuestionTypeID");

                entity.HasOne(d => d.Assignment)
                    .WithMany(p => p.AssignmentQuestions)
                    .HasForeignKey(d => d.AssignmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssignmentQuestions_ClientAssignments");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.AssignmentQuestions)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssignmentQuestions_SystemClients");
            });

            modelBuilder.Entity<AssignmentsCompleted>(entity =>
            {
                entity.HasIndex(e => new { e.EmployeeId, e.AssignmentId, e.ClientId, e.Status })
                    .HasName("IX_AssignmentsCompleted_ClientID_Status");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AssignmentFinishDate).HasColumnType("datetime");

                entity.Property(e => e.AssignmentId).HasColumnName("AssignmentID");

                entity.Property(e => e.AssignmentPracticalFinishDate).HasColumnType("datetime");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.GroupTrainingId).HasColumnName("GroupTrainingID");

                entity.Property(e => e.IsExempt).HasDefaultValueSql("((0))");

                entity.Property(e => e.PracticalExamId).HasColumnName("PracticalExamID");

                entity.Property(e => e.ReassignedClientId).HasColumnName("ReassignedClientID");

                entity.Property(e => e.ReassignedEmployeeId).HasColumnName("ReassignedEmployeeID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Assignment)
                    .WithMany(p => p.AssignmentsCompleted)
                    .HasForeignKey(d => d.AssignmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssignmentsCompleted_ClientAssignments");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.AssignmentsCompleted)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssignmentsCompleted_Employees");
            });

            modelBuilder.Entity<AuthorizedEmployees>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .HasDefaultValueSql("((8))");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.AuthorizedEmployees)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AuthorizedEmployees_SystemClients");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.AuthorizedEmployees)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AuthorizedEmployees_Employees");
            });

            modelBuilder.Entity<Cehours>(entity =>
            {
                entity.ToTable("CEHours", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CehourF).HasColumnName("CEHourF");

                entity.Property(e => e.Cehours1).HasColumnName("CEHours");

                entity.Property(e => e.TrainingId).HasColumnName("TrainingID");
            });

            modelBuilder.Entity<CertificateForms>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ContentType).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateOfLastEdit).HasColumnType("datetime");

                entity.Property(e => e.FormContent).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.TrainingId).HasColumnName("TrainingID");
            });

            modelBuilder.Entity<CertificatePrintLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CertificateFormId).HasColumnName("CertificateFormID");

                entity.Property(e => e.CertificateFormTypeId).HasColumnName("CertificateFormTypeID");

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .HasDefaultValueSql("((8))");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.TrainingCompletedId).HasColumnName("TrainingCompletedID");

                entity.Property(e => e.VerifyId).HasColumnName("VerifyID");
            });

            modelBuilder.Entity<CertificateTrainings>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CertificateFormId).HasColumnName("CertificateFormID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.TrainingId).HasColumnName("TrainingID");

                entity.HasOne(d => d.CertificateForm)
                    .WithMany(p => p.CertificateTrainings)
                    .HasForeignKey(d => d.CertificateFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CertificateTrainings_CertificateForms");
            });

            modelBuilder.Entity<Cfrs>(entity =>
            {
                entity.ToTable("CFRs", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cfrnumber)
                    .IsRequired()
                    .HasColumnName("CFRNumber")
                    .HasMaxLength(500);

                entity.Property(e => e.Cfrversion).HasColumnName("CFRVersion");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.TrainingId).HasColumnName("TrainingID");

                entity.HasOne(d => d.Training)
                    .WithMany(p => p.Cfrs)
                    .HasForeignKey(d => d.TrainingId)
                    .HasConstraintName("FK_CFRs_Trainings");
            });

            modelBuilder.Entity<ClientActions>(entity =>
            {
                entity.HasIndex(e => e.ClientId);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");
            });

            modelBuilder.Entity<ClientActionTypes>(entity =>
            {
                entity.HasIndex(e => new { e.ClientId, e.ActionTypeId })
                    .HasName("IX_ClientActionTypes_ClientID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionTypeId).HasColumnName("ActionTypeID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");
            });

            modelBuilder.Entity<ClientAssignments>(entity =>
            {
                entity.HasIndex(e => new { e.ClientId, e.StartDate, e.EndDate })
                    .HasName("IX_ClientAssignments_ClientID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CertificationId).HasColumnName("CertificationID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Cost).HasColumnType("money");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ExpireType).HasDefaultValueSql("((1))");

                entity.Property(e => e.ImportDate).HasColumnType("datetime");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.OrderProductId).HasColumnName("OrderProductID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.TaskCreatorClientId).HasColumnName("TaskCreatorClientID");

                entity.Property(e => e.TaskInfoClientId).HasColumnName("TaskInfoClientID");

                entity.Property(e => e.WfstepId).HasColumnName("WFStepID");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.ClientAssignments)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_ClientAssignments_Subject");
            });

            modelBuilder.Entity<ClientAssignmentsRegenererated>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientAssignmentId).HasColumnName("ClientAssignmentID");

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .HasDefaultValueSql("((8))");

                entity.Property(e => e.CompletedAssignmentId).HasColumnName("CompletedAssignmentID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.HasOne(d => d.ClientAssignment)
                    .WithMany(p => p.ClientAssignmentsRegenererated)
                    .HasForeignKey(d => d.ClientAssignmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientAssignmentsRegenererated_ClientAssignments");

                entity.HasOne(d => d.CompletedAssignment)
                    .WithMany(p => p.ClientAssignmentsRegenererated)
                    .HasForeignKey(d => d.CompletedAssignmentId)
                    .HasConstraintName("FK_ClientAssignmentsRegenererated_AssignmentsCompleted");
            });

            modelBuilder.Entity<ClientLogs>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("IP");

                entity.Property(e => e.NewValue).IsRequired();

                entity.Property(e => e.Notes).IsRequired();

                entity.Property(e => e.OldValue).IsRequired();

                entity.Property(e => e.TableKey).IsRequired();

                entity.Property(e => e.TableName).IsRequired();
            });

            modelBuilder.Entity<ClientMedias>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.MediaType).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<ClientPaymentMethods>(entity =>
            {
                entity.ToTable("ClientPaymentMethods", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CardNumber).HasMaxLength(20);

                entity.Property(e => e.CardType).HasMaxLength(20);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ContactPersonAddressId).HasColumnName("ContactPersonAddressID");

                entity.Property(e => e.ContactPersonId).HasColumnName("ContactPersonID");

                entity.Property(e => e.PaymentMethodId).HasColumnName("PaymentMethodID");

                entity.Property(e => e.PgclientId).HasColumnName("PGClientID");

                entity.Property(e => e.UserAddressId).HasColumnName("UserAddressID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientPaymentMethods)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientPaymentMethods_SystemClients");

                entity.HasOne(d => d.UserAddress)
                    .WithMany(p => p.ClientPaymentMethods)
                    .HasForeignKey(d => d.UserAddressId)
                    .HasConstraintName("FK_ClientPaymentMethods_UserAddresses");
            });

            modelBuilder.Entity<ClientProducts>(entity =>
            {
                entity.ToTable("ClientProducts", "so");

                entity.HasIndex(e => e.OrderProductId);

                entity.HasIndex(e => new { e.ClientId, e.ProductId, e.IsAgreementAccepted })
                    .HasName("IX_ClientProducts");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.FeatureId).HasColumnName("FeatureID");

                entity.Property(e => e.OrderProductId).HasColumnName("OrderProductID");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientProducts)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientProducts_SystemClients");

                entity.HasOne(d => d.OrderProduct)
                    .WithMany(p => p.ClientProducts)
                    .HasForeignKey(d => d.OrderProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientProducts_OrderProducts");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.ClientProducts)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_ClientProducts_Payments");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ClientProducts)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientProducts_Products");
            });

            modelBuilder.Entity<ClientsReports>(entity =>
            {
                entity.ToTable("ClientsReports", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");
            });

            modelBuilder.Entity<ClientTimeZones>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.TimeZone).IsRequired();
            });

            modelBuilder.Entity<ClientTrainingFiles>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .HasDefaultValueSql("((39))");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.TrainingId).HasColumnName("TrainingID");

                entity.Property(e => e.Type).IsRequired();

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.ClientTrainingFiles)
                    .HasForeignKey(d => d.DocumentId)
                    .HasConstraintName("FK_ClientTrainingFiles_Documents");
            });

            modelBuilder.Entity<ClientTrainingLicenseLogs>(entity =>
            {
                entity.ToTable("ClientTrainingLicenseLogs", "so");

                entity.HasIndex(e => new { e.ClientId, e.UserId, e.TrainingId, e.ExpirationDate })
                    .HasName("IX_ClientTrainingLicenseLogs");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientTrainingLicenseId).HasColumnName("ClientTrainingLicenseID");

                entity.Property(e => e.TrainingId).HasColumnName("TrainingID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<ClientTrainingLicenses>(entity =>
            {
                entity.ToTable("ClientTrainingLicenses", "so");

                entity.HasIndex(e => new { e.ClientId, e.TrainingId, e.RemainingLicenseCount })
                    .HasName("IX_ClientTrainingLicenses");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientProductId).HasColumnName("ClientProductID");

                entity.Property(e => e.TrainingId).HasColumnName("TrainingID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientTrainingLicenses)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientTrainingLicenses_SystemClients");

                entity.HasOne(d => d.ClientProduct)
                    .WithMany(p => p.ClientTrainingLicenses)
                    .HasForeignKey(d => d.ClientProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientTrainingLicenses_ClientProducts");
            });

            modelBuilder.Entity<ClientTrainings>(entity =>
            {
                entity.HasIndex(e => new { e.ClientId, e.TrainingId })
                    .HasName("IX_ClientTrainings");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CehoursF).HasColumnName("CEHoursF");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CompletionDate).HasColumnType("datetime");

                entity.Property(e => e.Cost).HasColumnType("money");

                entity.Property(e => e.DeliveryMethodId).HasColumnName("DeliveryMethodID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.IsPracticalExamRequired).HasDefaultValueSql("((0))");

                entity.Property(e => e.Navigation).HasDefaultValueSql("((1))");

                entity.Property(e => e.ScoreType).HasDefaultValueSql("((2))");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.SyllabusId).HasColumnName("SyllabusID");

                entity.Property(e => e.TrainingId).HasColumnName("TrainingID");

                entity.Property(e => e.Version).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.ClientTrainings)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_ClientTrainings_Subject");
            });

            modelBuilder.Entity<ClientUsers>(entity =>
            {
                entity.ToTable("ClientUsers", "so");

                entity.HasIndex(e => e.LoginToken);

                entity.HasIndex(e => new { e.ClientId, e.UserId });

                entity.HasIndex(e => new { e.Login, e.Email })
                    .HasName("IX_ClientUsers_Login");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.FirstName).HasMaxLength(200);

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastName).HasMaxLength(200);

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.LoginToken).HasMaxLength(200);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.PreferredFirstName).HasMaxLength(200);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<CommissionGroupAssignments>(entity =>
            {
                entity.ToTable("CommissionGroupAssignments", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CommissionGroupId).HasColumnName("CommissionGroupID");

                entity.Property(e => e.ProductGroupId).HasColumnName("ProductGroupID");

                entity.Property(e => e.SalesPersonGroupId).HasColumnName("SalesPersonGroupID");

                entity.Property(e => e.WhiteLabelId).HasColumnName("WhiteLabelID");

                entity.HasOne(d => d.WhiteLabel)
                    .WithMany(p => p.CommissionGroupAssignments)
                    .HasForeignKey(d => d.WhiteLabelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommissionGroupAssignments_WhiteLabels");
            });

            modelBuilder.Entity<CommissionGroups>(entity =>
            {
                entity.ToTable("CommissionGroups", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IndustryId).HasColumnName("IndustryID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.WhiteLabelId).HasColumnName("WhiteLabelID");

                entity.HasOne(d => d.Industry)
                    .WithMany(p => p.CommissionGroups)
                    .HasForeignKey(d => d.IndustryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommissionGroups_Industries");

                entity.HasOne(d => d.WhiteLabel)
                    .WithMany(p => p.CommissionGroups)
                    .HasForeignKey(d => d.WhiteLabelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommissionGroups_WhiteLabels");
            });

            modelBuilder.Entity<CommissionScheduleGroups>(entity =>
            {
                entity.ToTable("CommissionScheduleGroups", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CommissionGroupId).HasColumnName("CommissionGroupID");

                entity.Property(e => e.CommissionScheduleId).HasColumnName("CommissionScheduleID");

                entity.HasOne(d => d.CommissionGroup)
                    .WithMany(p => p.CommissionScheduleGroups)
                    .HasForeignKey(d => d.CommissionGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommissionScheduleGroups_CommissionGroups");

                entity.HasOne(d => d.CommissionSchedule)
                    .WithMany(p => p.CommissionScheduleGroups)
                    .HasForeignKey(d => d.CommissionScheduleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommissionScheduleGroups_CommissionSchedules");
            });

            modelBuilder.Entity<CommissionSchedules>(entity =>
            {
                entity.ToTable("CommissionSchedules", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(80);

                entity.Property(e => e.Initial).HasColumnType("money");

                entity.Property(e => e.IsIncludePaid)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.PayAfterCfd).HasColumnName("PayAfterCFD");

                entity.Property(e => e.Renewal).HasColumnType("money");

                entity.Property(e => e.WhiteLabelId).HasColumnName("WhiteLabelID");

                entity.HasOne(d => d.WhiteLabel)
                    .WithMany(p => p.CommissionSchedules)
                    .HasForeignKey(d => d.WhiteLabelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommissionSchedules_WhiteLabels");
            });

            modelBuilder.Entity<CompetencyCompleted>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CompetencyLevelId).HasColumnName("CompetencyLevelID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.HasOne(d => d.CompetencyLevel)
                    .WithMany(p => p.CompetencyCompleted)
                    .HasForeignKey(d => d.CompetencyLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompetencyCompleted_CompetencyLevels");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.CompetencyCompleted)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompetencyCompleted_Employees");
            });

            modelBuilder.Entity<CompetencyLevels>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<CompetencyLevelTrainings>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompetencyLevelId).HasColumnName("CompetencyLevelID");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.TrainingId).HasColumnName("TrainingID");

                entity.HasOne(d => d.CompetencyLevel)
                    .WithMany(p => p.CompetencyLevelTrainings)
                    .HasForeignKey(d => d.CompetencyLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompetencyLevelTrainings_CompetencyLevels");
            });

            modelBuilder.Entity<ContactInfos>(entity =>
            {
                entity.ToTable("ContactInfos", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.FirstName).IsRequired();

                entity.Property(e => e.LastName).IsRequired();

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ContactInfos)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContactInfos_SystemClients");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ContactInfos)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ContactInfos_Products");
            });

            modelBuilder.Entity<ContactPersonAddresses>(entity =>
            {
                entity.ToTable("ContactPersonAddresses", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address).IsRequired();

                entity.Property(e => e.City).IsRequired();

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ContactPersonId).HasColumnName("ContactPersonID");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.PhoneNumber).IsRequired();

                entity.Property(e => e.State).IsRequired();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Zip).IsRequired();
            });

            modelBuilder.Entity<ContactPersonClients>(entity =>
            {
                entity.ToTable("ContactPersonClients", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ContactPersonId).HasColumnName("ContactPersonID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ContactPersonClients)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContactPersonClients_SystemClients");

                entity.HasOne(d => d.ContactPerson)
                    .WithMany(p => p.ContactPersonClients)
                    .HasForeignKey(d => d.ContactPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContactPersonClients_ContactPersons");
            });

            modelBuilder.Entity<ContactPersons>(entity =>
            {
                entity.ToTable("ContactPersons", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdditionalId).HasColumnName("AdditionalID");

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.FoundInfoId).HasColumnName("FoundInfoID");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Password).IsRequired();

                entity.Property(e => e.PgclientId).HasColumnName("PGClientID");

                entity.Property(e => e.WhiteLabelId).HasColumnName("WhiteLabelID");

                entity.HasOne(d => d.WhiteLabel)
                    .WithMany(p => p.ContactPersons)
                    .HasForeignKey(d => d.WhiteLabelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContactPersons_WhiteLabels");
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.HasKey(e => e.Abbreviation);

                entity.ToTable("Countries", "so");

                entity.Property(e => e.Abbreviation)
                    .HasMaxLength(2)
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<CustomFields>(entity =>
            {
                entity.ToTable("CustomFields", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DisplayName).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.WhiteLabelId).HasColumnName("WhiteLabelID");

                entity.HasOne(d => d.WhiteLabel)
                    .WithMany(p => p.CustomFields)
                    .HasForeignKey(d => d.WhiteLabelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomFields_WhiteLabels");
            });

            modelBuilder.Entity<DashboardUsers>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.DashboardId).HasColumnName("DashboardID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<DeliveryMethods>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .HasDefaultValueSql("((8))");

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.DeliveryMethods)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DeliveryMethods_SystemClients");
            });

            modelBuilder.Entity<DiscountPrices>(entity =>
            {
                entity.ToTable("DiscountPrices", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DiscountId).HasColumnName("DiscountID");

                entity.Property(e => e.Initial).HasColumnType("money");

                entity.Property(e => e.Renewal).HasColumnType("money");

                entity.Property(e => e.SetupFee).HasColumnType("money");

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.DiscountPrices)
                    .HasForeignKey(d => d.DiscountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DiscountPrices_Discounts");
            });

            modelBuilder.Entity<DiscountProducts>(entity =>
            {
                entity.ToTable("DiscountProducts", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DiscountId).HasColumnName("DiscountID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.DiscountProducts)
                    .HasForeignKey(d => d.DiscountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DiscountProducts_Discounts");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DiscountProducts)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DiscountProducts_Products");
            });

            modelBuilder.Entity<Discounts>(entity =>
            {
                entity.ToTable("Discounts", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DiscountCode).IsRequired();

                entity.Property(e => e.MaxAllowedDiscount).HasColumnType("money");

                entity.Property(e => e.WhiteLabelId).HasColumnName("WhiteLabelID");

                entity.HasOne(d => d.DiscountTypeNavigation)
                    .WithMany(p => p.Discounts)
                    .HasForeignKey(d => d.DiscountType)
                    .HasConstraintName("FK_Discounts_DiscountTypes");

                entity.HasOne(d => d.WhiteLabel)
                    .WithMany(p => p.Discounts)
                    .HasForeignKey(d => d.WhiteLabelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Discounts_WhiteLabels");
            });

            modelBuilder.Entity<DiscountTypes>(entity =>
            {
                entity.ToTable("DiscountTypes", "so");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Question1).IsRequired();
            });

            modelBuilder.Entity<Documents>(entity =>
            {
                entity.HasIndex(e => new { e.ClientId, e.FolderId })
                    .HasName("IX_Documents_ClientID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.FactSheetReportId).HasColumnName("FactSheetReportID");

                entity.Property(e => e.FileType).IsRequired();

                entity.Property(e => e.FolderId).HasColumnName("FolderID");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.UploadedDate).HasColumnType("datetime");

                entity.Property(e => e.UploadedEmployeeId).HasColumnName("UploadedEmployeeID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Documents_SystemClients");

                entity.HasOne(d => d.Folder)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.FolderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Documents_Folders");
            });

            modelBuilder.Entity<EmailDistributionList>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.PermissionTypeId).HasColumnName("PermissionTypeID");

                entity.Property(e => e.SetId).HasColumnName("SetID");

                entity.HasOne(d => d.Set)
                    .WithMany(p => p.EmailDistributionList)
                    .HasForeignKey(d => d.SetId)
                    .HasConstraintName("FK_EmailDistributionList_Sets");
            });

            modelBuilder.Entity<EmailDistributionUsers>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EmailDistributionListId).HasColumnName("EmailDistributionListID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.EmailDistributionList)
                    .WithMany(p => p.EmailDistributionUsers)
                    .HasForeignKey(d => d.EmailDistributionListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmailDistributionUsers_EmailDistributionList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.EmailDistributionUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmailDistributionUsers_Employees");
            });

            modelBuilder.Entity<EmailTemplates>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .HasDefaultValueSql("((8))");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Template).IsRequired();

                entity.Property(e => e.Type).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.EmailTemplates)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmailTemplates_SystemClients");
            });

            modelBuilder.Entity<EmailTemplateTypes>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .HasDefaultValueSql("((8))");

                entity.Property(e => e.CustomTemplateId).HasColumnName("CustomTemplateID");

                entity.Property(e => e.NotificationListId).HasColumnName("NotificationListID");

                entity.Property(e => e.NotificationListType).HasDefaultValueSql("((1))");

                entity.Property(e => e.TemplateId).HasColumnName("TemplateID");
            });

            modelBuilder.Entity<EmployeeActiveStatus>(entity =>
            {
                entity.HasIndex(e => new { e.ClientId, e.EmployeeId })
                    .HasName("IX_EmployeeActiveStatus_EmployeeID");

                entity.HasIndex(e => new { e.ClientId, e.StatusDate })
                    .HasName("IX_EmployeeActiveStatus_ClientID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.StatusDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EmployeeAdditionalInformation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChangedByClientId).HasColumnName("ChangedByClientID");

                entity.Property(e => e.ChangedByEmployeeId).HasColumnName("ChangedByEmployeeID");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.InfoDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.EmployeeAdditionalInformation)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeAdditionalInformation_SystemClients");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeAdditionalInformation)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeAdditionalInformation_Employees");
            });

            modelBuilder.Entity<EmployeeFiles>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Type).IsRequired();

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeFiles)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeFiles_Employees");
            });

            modelBuilder.Entity<EmployeeImages>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.ImageName).IsRequired();
            });

            modelBuilder.Entity<EmployeeLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AssignmentId).HasColumnName("AssignmentID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Ipaddress).HasColumnName("IPAddress");

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");

                entity.Property(e => e.TrainingId).HasColumnName("TrainingID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeLog)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_EmployeeLog_Employees");
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.Email);

                entity.HasIndex(e => e.Login);

                entity.HasIndex(e => new { e.LoginToken, e.LastLoginDate });

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CurrentFlowId).HasColumnName("CurrentFlowID");

                entity.Property(e => e.CurrentTrainingId).HasColumnName("CurrentTrainingID");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.DateOfPasswordChange).HasColumnType("datetime");

                entity.Property(e => e.DefaultCategoryId).HasColumnName("DefaultCategoryID");

                entity.Property(e => e.DefaultLanguageId).HasColumnName("DefaultLanguageID");

                entity.Property(e => e.DefaultSkinId).HasColumnName("DefaultSkinID");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.FirstName).IsRequired();

                entity.Property(e => e.FoundInfoId).HasColumnName("FoundInfoID");

                entity.Property(e => e.HubSpotId).HasColumnName("HubSpotID");

                entity.Property(e => e.ImportDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginIp).HasColumnName("LastLoginIP");

                entity.Property(e => e.LastName).IsRequired();

                entity.Property(e => e.LastRequestDate).HasColumnType("datetime");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.LoginToken).HasMaxLength(200);

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.NewFlag).HasColumnName("newFlag");

                entity.Property(e => e.OutOfReceivingEmailDate).HasColumnType("datetime");

                entity.Property(e => e.Password).IsRequired();

                entity.Property(e => e.PgclientId).HasColumnName("PGClientID");

                entity.Property(e => e.Pin)
                    .IsRequired()
                    .HasColumnName("PIN");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.ReportingId).HasColumnName("ReportingID");

                entity.Property(e => e.ShowOnBoardingTasks)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SupervisorId).HasColumnName("SupervisorID");
            });

            modelBuilder.Entity<EmployeesFavoriteReports>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeesFavoriteReports)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeesFavoriteReports_Employees");
            });

            modelBuilder.Entity<Escalation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.EmailDistributionListId).HasColumnName("EmailDistributionListID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.EmailDistributionList)
                    .WithMany(p => p.Escalation)
                    .HasForeignKey(d => d.EmailDistributionListId)
                    .HasConstraintName("FK_Escalation_EmailDistributionList");
            });

            modelBuilder.Entity<EscalationHistory>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .HasDefaultValueSql("((8))");

                entity.Property(e => e.EmailDistributionListId).HasColumnName("EmailDistributionListID");

                entity.Property(e => e.EscalationType).HasDefaultValueSql("((1))");

                entity.Property(e => e.NotificationListType).HasDefaultValueSql("((1))");

                entity.Property(e => e.SetAssignedId).HasColumnName("SetAssignedID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.EscalationHistory)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EscalationHistory_SetAssigneds");
            });

            modelBuilder.Entity<EscalationNotify>(entity =>
            {
                entity.HasIndex(e => new { e.ClientId, e.IsDeleted })
                    .HasName("IX_EscalationNotify_ClientID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .HasDefaultValueSql("((8))");

                entity.Property(e => e.EmailDistributionListId).HasColumnName("EmailDistributionListID");

                entity.Property(e => e.EscalationId).HasColumnName("EscalationID");

                entity.Property(e => e.EscalationType).HasDefaultValueSql("((1))");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.NotificationListType).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<EventCertificates>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .HasDefaultValueSql("((8))");

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.EventCertificates)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventCertificates_SystemClients");
            });

            modelBuilder.Entity<EventCourses>(entity =>
            {
                entity.HasIndex(e => new { e.CourseId, e.SetType, e.ScoreType, e.CreditHours, e.EventId })
                    .HasName("IX_EventCourses_EventID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.CreditHours).HasColumnType("nvarchar(max)");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.EventCourses)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventCourses_Events");
            });

            modelBuilder.Entity<EventFiles>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.PageId).HasColumnName("PageID");

                entity.Property(e => e.Type).IsRequired();
            });

            modelBuilder.Entity<EventGroup>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .HasDefaultValueSql("((8))");

                entity.Property(e => e.GroupName).IsRequired();

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.EventGroup)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventGroup_SystemClients");
            });

            modelBuilder.Entity<EventInvitations>(entity =>
            {
                entity.HasIndex(e => e.EventId);

                entity.HasIndex(e => new { e.EventId, e.Guid, e.EmployeeId, e.Status })
                    .HasName("IX_EventInvitations_EmployeeID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Company).IsRequired();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.FirstName).IsRequired();

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasColumnName("GUID")
                    .HasMaxLength(200);

                entity.Property(e => e.LastName).IsRequired();

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EventInvitations)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_EventInvitations_Employees");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.EventInvitations)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventInvitations_Events");
            });

            modelBuilder.Entity<EventParticipants>(entity =>
            {
                entity.HasIndex(e => new { e.Id, e.EmployeeId, e.FirstName, e.LastName, e.EventId })
                    .HasName("IX_EventParticipants");

                entity.HasIndex(e => new { e.InvitationId, e.FinishTime, e.CreditHours, e.EmployeeId, e.EventId })
                    .HasName("IX_EventParticipants_EventID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CehourF).HasColumnName("CEHourF");

                entity.Property(e => e.Company).IsRequired();

                entity.Property(e => e.CreditHours).HasColumnType("nvarchar(max)");

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.FinishTime).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.InvitationId).HasColumnName("InvitationID");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.RegistrationTime).HasColumnType("datetime");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.EventParticipants)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventParticipants_Events");

                entity.HasOne(d => d.Invitation)
                    .WithMany(p => p.EventParticipants)
                    .HasForeignKey(d => d.InvitationId)
                    .HasConstraintName("FK_EventParticipants_EventInvitations");
            });

            modelBuilder.Entity<EventParticipantScore>(entity =>
            {
                entity.HasIndex(e => new { e.Id, e.Score, e.EventParticipantId, e.CourseId, e.SetType })
                    .HasName("IX_EventParticipantScore_EventParticipantID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.EventParticipantId).HasColumnName("EventParticipantID");

                entity.Property(e => e.Score).HasColumnType("nvarchar(max)");

                entity.HasOne(d => d.EventParticipant)
                    .WithMany(p => p.EventParticipantScore)
                    .HasForeignKey(d => d.EventParticipantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventParticipantScore_EventParticipants");
            });

            modelBuilder.Entity<EventProducts>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.EventProducts)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventProducts_SystemClients");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.EventProducts)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventProducts_Events");
            });

            modelBuilder.Entity<EventReminder>(entity =>
            {
                entity.HasIndex(e => new { e.EventId, e.InvitationId, e.TypeOfReminder, e.EventStartDate, e.ClientId })
                    .HasName("IX_EventReminder_ClientID");

                entity.HasIndex(e => new { e.InvitationId, e.TypeOfReminder, e.EventStartDate, e.ClientId, e.EventId })
                    .HasName("IX_EventReminder_ClientID_EventID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .HasDefaultValueSql("((8))");

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.EmailCc).HasColumnName("EmailCC");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.EventStartDate).HasColumnType("datetime");

                entity.Property(e => e.InvitationId).HasColumnName("InvitationID");

                entity.Property(e => e.SendDate).HasColumnType("datetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.EventReminder)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventReminder_SystemClients");
            });

            modelBuilder.Entity<Events>(entity =>
            {
                entity.HasIndex(e => new { e.Id, e.ClientId, e.Date })
                    .HasName("IX_Events_ClientID");

                entity.HasIndex(e => new { e.Id, e.Date, e.ClientId, e.IsActive, e.Finished, e.ExpirationDate })
                    .HasName("IX_Events_ClientID_IsActive");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AllowAddToCalendar)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AllowTentativeParticipants)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CancelledByClientId).HasColumnName("CancelledByClientID");

                entity.Property(e => e.CancelledByEmployeeId).HasColumnName("CancelledByEmployeeID");

                entity.Property(e => e.CancelledDateTime).HasColumnType("datetime");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CehourF).HasColumnName("CEHourF");

                entity.Property(e => e.CertificationId).HasColumnName("CertificationID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateUtc)
                    .HasColumnName("DateUTC")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Ecemail).HasColumnName("ECEmail");

                entity.Property(e => e.EcfirstName).HasColumnName("ECFirstName");

                entity.Property(e => e.EclastName).HasColumnName("ECLastName");

                entity.Property(e => e.Ecphone).HasColumnName("ECPhone");

                entity.Property(e => e.EventCreatorId).HasColumnName("EventCreatorID");

                entity.Property(e => e.EventTypeId).HasColumnName("EventTypeID");

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.FinalizeDate).HasColumnType("datetime");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsCountMaybeParticipants)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsSeconAconfirmation).HasColumnName("IsSECOnAConfirmation");

                entity.Property(e => e.IsSeconConfirmation).HasColumnName("IsSECOnConfirmation");

                entity.Property(e => e.IsSeconRejection).HasColumnName("IsSECOnRejection");

                entity.Property(e => e.IsSeconTconfirmation).HasColumnName("IsSECOnTConfirmation");

                entity.Property(e => e.IsSecpostEvent).HasColumnName("IsSECPostEvent");

                entity.Property(e => e.IsSecreminder1DayAhead).HasColumnName("IsSECReminder1DayAhead");

                entity.Property(e => e.IsSecreminder1WeekAhead).HasColumnName("IsSECReminder1WeekAhead");

                entity.Property(e => e.IsSecreminder3DaysAhead).HasColumnName("IsSECReminder3DaysAhead");

                entity.Property(e => e.IsSectoManagerIfCancelled).HasColumnName("IsSECToManagerIfCancelled");

                entity.Property(e => e.IsSectoParticipantIfCancelled).HasColumnName("IsSECToParticipantIfCancelled");

                entity.Property(e => e.IsSecwaitingLadd).HasColumnName("IsSECWaitingLAdd");

                entity.Property(e => e.IsSecwaitingLdec).HasColumnName("IsSECWaitingLDec");

                entity.Property(e => e.IsSecwhenEventBegins).HasColumnName("IsSECWhenEventBegins");

                entity.Property(e => e.IsSecwhenEventFinishes).HasColumnName("IsSECWhenEventFinishes");

                entity.Property(e => e.IsSeother).HasColumnName("IsSEOther");

                entity.Property(e => e.IsSeponAconfirmation).HasColumnName("IsSEPOnAConfirmation");

                entity.Property(e => e.IsSeponConfirmation).HasColumnName("IsSEPOnConfirmation");

                entity.Property(e => e.IsSeponRejection).HasColumnName("IsSEPOnRejection");

                entity.Property(e => e.IsSeponTconfirmation).HasColumnName("IsSEPOnTConfirmation");

                entity.Property(e => e.IsSeppostEvent).HasColumnName("IsSEPPostEvent");

                entity.Property(e => e.IsSepreminder1DayAhead).HasColumnName("IsSEPReminder1DayAhead");

                entity.Property(e => e.IsSepreminder1WeekAhead).HasColumnName("IsSEPReminder1WeekAhead");

                entity.Property(e => e.IsSepreminder3DaysAhead).HasColumnName("IsSEPReminder3DaysAhead");

                entity.Property(e => e.IsSeptoManagerIfCancelled).HasColumnName("IsSEPToManagerIfCancelled");

                entity.Property(e => e.IsSeptoParticipantIfCancelled).HasColumnName("IsSEPToParticipantIfCancelled");

                entity.Property(e => e.IsSepwaitingLadd).HasColumnName("IsSEPWaitingLAdd");

                entity.Property(e => e.IsSepwhenEventBegins).HasColumnName("IsSEPWhenEventBegins");

                entity.Property(e => e.IsSepwhenEventFinishes).HasColumnName("IsSEPWhenEventFinishes");

                entity.Property(e => e.IsSesameEventCoordinator).HasColumnName("IsSESameEventCoordinator");

                entity.Property(e => e.IsWaitingList)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsWaitingParticipantNotified)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.LogoId).HasColumnName("LogoID");

                entity.Property(e => e.ParticipationCost).HasColumnType("money");

                entity.Property(e => e.RegistrationFinishDate).HasColumnType("datetime");

                entity.Property(e => e.RegistrationStartDate).HasColumnType("datetime");

                entity.Property(e => e.Subject).IsRequired();

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.Title).IsRequired();

                entity.HasOne(d => d.Certification)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.CertificationId)
                    .HasConstraintName("FK_Events_EventCertificates");

                entity.HasOne(d => d.EventType)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.EventTypeId)
                    .HasConstraintName("FK_Events_EventTypes");

                entity.HasOne(d => d.Logo)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.LogoId)
                    .HasConstraintName("FK_Events_EventsLogo");

                entity.HasOne(d => d.SubjectNavigation)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_Events_Subject");
            });

            modelBuilder.Entity<EventsAttachedFile>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .HasDefaultValueSql("((8))");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasColumnName("GUID");

                entity.Property(e => e.MimeType).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.EventsAttachedFile)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventsAttachedFile_SystemClients");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.EventsAttachedFile)
                    .HasForeignKey(d => d.EventId)
                    .HasConstraintName("FK_EventsAttachedFile_Events");
            });

            modelBuilder.Entity<EventsLogo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .HasDefaultValueSql("((8))");

                entity.Property(e => e.MimeType).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.EventsLogo)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventsLogo_SystemClients");
            });

            modelBuilder.Entity<EventTemplates>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AttachmenId).HasColumnName("AttachmenID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.FromDate).HasDefaultValueSql("(CONVERT([datetimeoffset](7),'2000-01-01 00:00:00 -06:00',0))");

                entity.Property(e => e.SetId).HasColumnName("SetID");

                entity.Property(e => e.Subject).HasMaxLength(400);

                entity.Property(e => e.ToDate).HasDefaultValueSql("(CONVERT([datetimeoffset](7),'2199-12-31 23:59:59',0))");

                entity.Property(e => e.Topic)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.HasOne(d => d.Attachmen)
                    .WithMany(p => p.EventTemplates)
                    .HasForeignKey(d => d.AttachmenId)
                    .HasConstraintName("FK_EventTemplates_EventsAttachedFile");

                entity.HasOne(d => d.Set)
                    .WithMany(p => p.EventTemplates)
                    .HasForeignKey(d => d.SetId)
                    .HasConstraintName("FK_EventTemplates_Sets");
            });

            modelBuilder.Entity<EventTypes>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .HasDefaultValueSql("((8))");

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.EventTypes)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventTypes_SystemClients");
            });

            modelBuilder.Entity<ExternalLms>(entity =>
            {
                entity.ToTable("ExternalLMS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Lmsid).HasColumnName("LMSID");

                entity.Property(e => e.Lmsother).HasColumnName("LMSOther");

                entity.Property(e => e.LmsreturnCode).HasColumnName("LMSReturnCode");

                entity.Property(e => e.LmsreturnUrl).HasColumnName("LMSReturnURL");

                entity.Property(e => e.TrainingsCompletedId).HasColumnName("TrainingsCompletedID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ExternalLms)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternalLMS_SystemClients");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.ExternalLms)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternalLMS_Employees");

                entity.HasOne(d => d.TrainingsCompleted)
                    .WithMany(p => p.ExternalLms)
                    .HasForeignKey(d => d.TrainingsCompletedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExternalLMS_TrainingsCompleted");
            });

            modelBuilder.Entity<FavoriteListEmployees>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.FavoriteListId).HasColumnName("FavoriteListID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.FavoriteListEmployees)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FavoriteListEmployees_Employees");

                entity.HasOne(d => d.FavoriteList)
                    .WithMany(p => p.FavoriteListEmployees)
                    .HasForeignKey(d => d.FavoriteListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FavoriteListEmployees_FavoriteLists");
            });

            modelBuilder.Entity<FavoriteLists>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .HasDefaultValueSql("((8))");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.FavoriteLists)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FavoriteLists_SystemClients");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.FavoriteLists)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FavoriteLists_Employees");
            });

            modelBuilder.Entity<Files>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AssignmentId).HasColumnName("AssignmentID");

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .HasDefaultValueSql("((8))");

                entity.Property(e => e.CompletedId).HasColumnName("CompletedID");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Type).IsRequired();

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Files)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Files_SystemClients");
            });

            modelBuilder.Entity<Folders>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .HasDefaultValueSql("((8))");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Folders_Folders");
            });

            modelBuilder.Entity<FoundInfos>(entity =>
            {
                entity.ToTable("FoundInfos", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.WhiteLabelId).HasColumnName("WhiteLabelID");

                entity.HasOne(d => d.WhiteLabel)
                    .WithMany(p => p.FoundInfos)
                    .HasForeignKey(d => d.WhiteLabelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FoundInfos_WhiteLabels");
            });

            modelBuilder.Entity<GroupTrainingEmployees>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.GroupTrainingId).HasColumnName("GroupTrainingID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.GroupTrainingEmployees)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupTrainingEmployees_SystemClients");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.GroupTrainingEmployees)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_GroupTrainingEmployees_Employees");

                entity.HasOne(d => d.GroupTraining)
                    .WithMany(p => p.GroupTrainingEmployees)
                    .HasForeignKey(d => d.GroupTrainingId)
                    .HasConstraintName("FK_GroupTrainingEmployees_GroupTrainings");
            });

            modelBuilder.Entity<GroupTrainingFiles>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GroupTrainingId).HasColumnName("GroupTrainingID");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Type).IsRequired();
            });

            modelBuilder.Entity<GroupTrainings>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CourseType).HasDefaultValueSql("((1))");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EvaluatorName)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.EvaluatorPhone)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ImportDate).HasColumnType("datetime");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RecordCreatedByClientId).HasColumnName("RecordCreatedByClientID");

                entity.Property(e => e.RecordCreatedByEmployeeId).HasColumnName("RecordCreatedByEmployeeID");

                entity.Property(e => e.RecordCreatedDate).HasColumnType("datetime");

                entity.Property(e => e.TrainingId).HasColumnName("TrainingID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.GroupTrainings)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupTrainings_SystemClients");
            });

            modelBuilder.Entity<GroupTranslation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.GroupName).IsRequired();

                entity.Property(e => e.LastTranslationDate).HasColumnType("date");

                entity.Property(e => e.MainGroupName).IsRequired();

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.GroupTranslation)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupTranslation_SystemClients");
            });

            modelBuilder.Entity<H5answers>(entity =>
            {
                entity.ToTable("H5Answers", "mo");

                entity.HasIndex(e => new { e.IsRight, e.ModuleId, e.QuestionId })
                    .HasName("IX_H5Answers_ModuleID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.HtmlText).IsRequired();

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.PictureId).HasColumnName("PictureID");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.HasOne(d => d.Picture)
                    .WithMany(p => p.H5answers)
                    .HasForeignKey(d => d.PictureId)
                    .HasConstraintName("FK_H5Answers_H5Sources");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.H5answers)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Answers_Questions");
            });

            modelBuilder.Entity<H5chapters>(entity =>
            {
                entity.ToTable("H5Chapters", "mo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.Title).IsRequired();
            });

            modelBuilder.Entity<H5flow>(entity =>
            {
                entity.ToTable("H5Flow", "mo");

                entity.HasIndex(e => e.ModuleId);

                entity.HasIndex(e => new { e.ModuleId, e.Version, e.Language, e.Chapter })
                    .HasName("IX_H5Flow_ModuleID_Version");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.NextPageFlowId).HasColumnName("NextPageFlowID");

                entity.Property(e => e.PageId).HasColumnName("PageID");

                entity.Property(e => e.QuizId).HasColumnName("QuizID");

                entity.Property(e => e.SlideId).HasColumnName("SlideID");

                entity.Property(e => e.SurveyId).HasColumnName("SurveyID");

                entity.HasOne(d => d.NextPageFlow)
                    .WithMany(p => p.InverseNextPageFlow)
                    .HasForeignKey(d => d.NextPageFlowId)
                    .HasConstraintName("FK_H5Flow_H5Flow1");

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.H5flow)
                    .HasForeignKey(d => d.PageId)
                    .HasConstraintName("FK_Flow_Pages");

                entity.HasOne(d => d.Quiz)
                    .WithMany(p => p.H5flow)
                    .HasForeignKey(d => d.QuizId)
                    .HasConstraintName("FK_Flow_Quizzes");

                entity.HasOne(d => d.Survey)
                    .WithMany(p => p.H5flow)
                    .HasForeignKey(d => d.SurveyId)
                    .HasConstraintName("FK_H5Flow_H5Surveys");
            });

            modelBuilder.Entity<H5links>(entity =>
            {
                entity.ToTable("H5Links", "mo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ExternalUrl).HasColumnName("ExternalURL");

                entity.Property(e => e.FlowId).HasColumnName("FlowID");

                entity.Property(e => e.Height).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.HrefFlowId).HasColumnName("HrefFlowID");

                entity.Property(e => e.LeftPosition).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.TopPosition).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Width).HasColumnType("decimal(8, 4)");

                entity.HasOne(d => d.Flow)
                    .WithMany(p => p.H5links)
                    .HasForeignKey(d => d.FlowId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Links_Flow");
            });

            modelBuilder.Entity<H5pages>(entity =>
            {
                entity.ToTable("H5Pages", "mo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AudioId).HasColumnName("AudioID");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.SlideId).HasColumnName("SlideID");

                entity.Property(e => e.SourceAudioId).HasColumnName("SourceAudioID");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.HasOne(d => d.Source)
                    .WithMany(p => p.H5pages)
                    .HasForeignKey(d => d.SourceId)
                    .HasConstraintName("FK_Pages_Sources");
            });

            modelBuilder.Entity<H5questions>(entity =>
            {
                entity.ToTable("H5Questions", "mo");

                entity.HasIndex(e => new { e.ModuleId, e.QuizId })
                    .HasName("IX_H5Questions_ModuleID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AudioId).HasColumnName("AudioID");

                entity.Property(e => e.HtmlText).IsRequired();

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.PictureId).HasColumnName("PictureID");

                entity.Property(e => e.QuizId).HasColumnName("QuizID");

                entity.HasOne(d => d.Audio)
                    .WithMany(p => p.H5questions)
                    .HasForeignKey(d => d.AudioId)
                    .HasConstraintName("FK_H5Questions_H5Sources");

                entity.HasOne(d => d.Quiz)
                    .WithMany(p => p.H5questions)
                    .HasForeignKey(d => d.QuizId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Questions_Quizzes");
            });

            modelBuilder.Entity<H5quizzes>(entity =>
            {
                entity.ToTable("H5Quizzes", "mo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            });

            modelBuilder.Entity<H5sources>(entity =>
            {
                entity.ToTable("H5Sources", "mo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasColumnName("GUID");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.Type).IsRequired();
            });

            modelBuilder.Entity<H5surveys>(entity =>
            {
                entity.ToTable("H5Surveys", "mo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.SurveyId).HasColumnName("SurveyID");
            });

            modelBuilder.Entity<HelpPageFolders>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .HasDefaultValueSql("((8))");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.ParentId).HasColumnName("ParentID");
            });

            modelBuilder.Entity<HelpPages>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .HasDefaultValueSql("((8))");

                entity.Property(e => e.FileType).IsRequired();

                entity.Property(e => e.FolderId).HasColumnName("FolderID");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.UploadedDate).HasColumnType("datetime");

                entity.Property(e => e.UploadedEmployeeId).HasColumnName("UploadedEmployeeID");
            });

            modelBuilder.Entity<ImportDetails>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.DateLastSeen).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");
            });

            modelBuilder.Entity<Industries>(entity =>
            {
                entity.ToTable("Industries", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.TemplateClientId).HasColumnName("TemplateClientID");

                entity.Property(e => e.WhiteLabelId).HasColumnName("WhiteLabelID");

                entity.HasOne(d => d.WhiteLabel)
                    .WithMany(p => p.Industries)
                    .HasForeignKey(d => d.WhiteLabelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Industries_WhiteLabels");
            });

            modelBuilder.Entity<IndustryActions>(entity =>
            {
                entity.ToTable("IndustryActions", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.IndustryId).HasColumnName("IndustryID");
            });

            modelBuilder.Entity<IndustryActionTypes>(entity =>
            {
                entity.ToTable("IndustryActionTypes", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionTypeId).HasColumnName("ActionTypeID");

                entity.Property(e => e.IndustryId).HasColumnName("IndustryID");
            });

            modelBuilder.Entity<Invoices>(entity =>
            {
                entity.ToTable("Invoices", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ContactPersonId).HasColumnName("ContactPersonID");

                entity.Property(e => e.HashCode).IsRequired();

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PaymentMethodId).HasColumnName("PaymentMethodID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UtcTime).IsRequired();

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Invoices_SystemClients");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_Invoices_Orders");
            });

            modelBuilder.Entity<KeyIndicator>(entity =>
            {
                entity.ToTable("KeyIndicator", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<KeyIndicatorValues>(entity =>
            {
                entity.ToTable("KeyIndicatorValues", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.KeyIndicatorId).HasColumnName("KeyIndicatorID");

                entity.Property(e => e.SalesPersonId).HasColumnName("SalesPersonID");

                entity.HasOne(d => d.KeyIndicator)
                    .WithMany(p => p.KeyIndicatorValues)
                    .HasForeignKey(d => d.KeyIndicatorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KeyIndicatorValues_KeyIndicator");

                entity.HasOne(d => d.SalesPerson)
                    .WithMany(p => p.KeyIndicatorValues)
                    .HasForeignKey(d => d.SalesPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KeyIndicatorValues_SalesPersons");
            });

            modelBuilder.Entity<Languages>(entity =>
            {
                entity.ToTable("Languages", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Abbreviation)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<LayoutSettings>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.LayoutSettings)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LayoutSettings_ToTable");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.LayoutSettingsNavigation)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LayoutSettings_ToTable_1");
            });

            modelBuilder.Entity<LicenseFiles>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.FileName).IsRequired();

                entity.Property(e => e.FileType).IsRequired();

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.LicenseFiles)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LicenseFiles_SystemClients");
            });

            modelBuilder.Entity<LicenseLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .HasDefaultValueSql("((8))");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.LicenseId).HasColumnName("LicenseID");

                entity.Property(e => e.LicenseLevel).HasDefaultValueSql("((2))");

                entity.Property(e => e.Pdf).HasColumnName("PDF");

                entity.Property(e => e.Time).IsRequired();

                entity.Property(e => e.VendorClientId).HasColumnName("VendorClientID");
            });

            modelBuilder.Entity<Links>(entity =>
            {
                entity.ToTable("Links", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Path).IsRequired();
            });

            modelBuilder.Entity<MailingAttachments>(entity =>
            {
                entity.ToTable("MailingAttachments", "so");

                entity.HasIndex(e => new { e.MailingId, e.ActionPendingId })
                    .HasName("IX_MailingAttachments_MailingID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionPendingId).HasColumnName("ActionPendingID");

                entity.Property(e => e.MailingId).HasColumnName("MailingID");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Type).IsRequired();

                entity.HasOne(d => d.Mailing)
                    .WithMany(p => p.MailingAttachments)
                    .HasForeignKey(d => d.MailingId)
                    .HasConstraintName("FK_MailingAttachments_Mailings");
            });

            modelBuilder.Entity<Mailings>(entity =>
            {
                entity.ToTable("Mailings", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.Cc).HasColumnName("CC");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.PhoneNumber).HasMaxLength(200);

                entity.Property(e => e.Priority).HasDefaultValueSql("((20))");

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.SenderClientId).HasColumnName("SenderClientID");

                entity.Property(e => e.SenderEmployeeId).HasColumnName("SenderEmployeeID");

                entity.Property(e => e.SentDate).HasColumnType("datetime");

                entity.Property(e => e.TemplateId).HasColumnName("TemplateID");
            });

            modelBuilder.Entity<MailingViews>(entity =>
            {
                entity.ToTable("MailingViews", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Ip).HasColumnName("IP");

                entity.Property(e => e.MailingId).HasColumnName("MailingID");

                entity.HasOne(d => d.Mailing)
                    .WithMany(p => p.MailingViews)
                    .HasForeignKey(d => d.MailingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MailingViews_Mailings");
            });

            modelBuilder.Entity<Notifications>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.PhoneNumber).HasMaxLength(200);

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Notifications_SystemClients");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Notifications_Employees");
            });

            modelBuilder.Entity<NotificationSettings>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.NotificationTypeId).HasColumnName("NotificationTypeID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.NotificationSettings)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotificationSettings_SystemClients");
            });

            modelBuilder.Entity<OrderChannelPartners>(entity =>
            {
                entity.ToTable("OrderChannelPartners", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.SalesPersonId).HasColumnName("SalesPersonID");
            });

            modelBuilder.Entity<OrderProducts>(entity =>
            {
                entity.ToTable("OrderProducts", "so");

                entity.HasIndex(e => new { e.ClientId, e.Status })
                    .HasName("IX_OrderProducts_ClientID");

                entity.HasIndex(e => new { e.Id, e.PreviousId })
                    .HasName("IX_OrderProducts_PreviousID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccessInterval).HasDefaultValueSql("((1))");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CombinedDiscountId).HasColumnName("CombinedDiscountID");

                entity.Property(e => e.DiscountId).HasColumnName("DiscountID");

                entity.Property(e => e.ExpeditePrice).HasColumnType("money");

                entity.Property(e => e.ExpirationDate).HasDefaultValueSql("('2100-01-01')");

                entity.Property(e => e.HubSpotId).HasColumnName("HubSpotID");

                entity.Property(e => e.OldProductId).HasColumnName("OldProductID");

                entity.Property(e => e.OptionId).HasColumnName("OptionID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OriginalSetUpFee).HasColumnType("money");

                entity.Property(e => e.PaidPrice).HasColumnType("money");

                entity.Property(e => e.PreviousId).HasColumnName("PreviousID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.RenewDiscountId).HasColumnName("RenewDiscountID");

                entity.Property(e => e.SetUpFee).HasColumnType("money");

                entity.Property(e => e.TotalPrice).HasColumnType("money");

                entity.Property(e => e.UnitPrice).HasColumnType("money");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.OrderProducts)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderProducts_SystemClients");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderProducts)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderProducts_Orders");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderProducts)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderProducts_Products");
            });

            modelBuilder.Entity<OrderProductSets>(entity =>
            {
                entity.ToTable("OrderProductSets", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OrderProductId).HasColumnName("OrderProductID");

                entity.Property(e => e.SetId).HasColumnName("SetID");

                entity.HasOne(d => d.OrderProduct)
                    .WithMany(p => p.OrderProductSets)
                    .HasForeignKey(d => d.OrderProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderProductSets_OrderProducts");
            });

            modelBuilder.Entity<OrderRenewNotifications>(entity =>
            {
                entity.ToTable("OrderRenewNotifications", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.OrderProductId).HasColumnName("OrderProductID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.OrderRenewNotifications)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderRenewNotifications_SystemClients");

                entity.HasOne(d => d.OrderProduct)
                    .WithMany(p => p.OrderRenewNotifications)
                    .HasForeignKey(d => d.OrderProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderRenewNotifications_OrderProducts");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.ToTable("Orders", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ContactPersonId).HasColumnName("ContactPersonID");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PaymentMethodId).HasColumnName("PaymentMethodID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.WhiteLabelId).HasColumnName("WhiteLabelID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_SystemClients");

                entity.HasOne(d => d.WhiteLabel)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.WhiteLabelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_WhiteLabels");
            });

            modelBuilder.Entity<ParticipantsWaitingList>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.FirstName).IsRequired();

                entity.Property(e => e.LastName).IsRequired();

                entity.Property(e => e.NotifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.WaitingDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<PaymentReminds>(entity =>
            {
                entity.ToTable("PaymentReminds", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionReminderId).HasColumnName("ActionReminderID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.OrderProductId).HasColumnName("OrderProductID");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.HasOne(d => d.ActionReminder)
                    .WithMany(p => p.PaymentReminds)
                    .HasForeignKey(d => d.ActionReminderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentReminds_ActionReminders");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.PaymentReminds)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentReminds_SystemClients");

                entity.HasOne(d => d.OrderProduct)
                    .WithMany(p => p.PaymentReminds)
                    .HasForeignKey(d => d.OrderProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentReminds_OrderProducts");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.PaymentReminds)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_PaymentReminds_Payments");
            });

            modelBuilder.Entity<Payments>(entity =>
            {
                entity.ToTable("Payments", "so");

                entity.HasIndex(e => e.OrderProductId);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OrderProductId).HasColumnName("OrderProductID");

                entity.Property(e => e.PgscheduleItemId).HasColumnName("PGScheduleItemID");

                entity.Property(e => e.PlanId).HasColumnName("PlanID");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.InvoiceId)
                    .HasConstraintName("FK_Payments_Invoices");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payments_Orders");

                entity.HasOne(d => d.OrderProduct)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.OrderProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payments_OrderProducts");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.PlanId)
                    .HasConstraintName("FK_Payments_SubscriptionPlans");
            });

            modelBuilder.Entity<PracticalExam>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EvaluatorName).IsRequired();

                entity.Property(e => e.EvaluatorPhone).IsRequired();

                entity.Property(e => e.RecordCreatedByClientId).HasColumnName("RecordCreatedByClientID");

                entity.Property(e => e.RecordCreatedByEmployeeId).HasColumnName("RecordCreatedByEmployeeID");

                entity.Property(e => e.RecordCreatedDate).HasColumnType("datetime");

                entity.Property(e => e.TrainingId).HasColumnName("TrainingID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<PracticalExamEmployees>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClassRoomDate).HasColumnType("datetime");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.PracticalExamId).HasColumnName("PracticalExamID");

                entity.HasOne(d => d.PracticalExam)
                    .WithMany(p => p.PracticalExamEmployees)
                    .HasForeignKey(d => d.PracticalExamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PracticalExamEmployees_PracticalExam");
            });

            modelBuilder.Entity<ProcessorPaymentsGatewayDetails>(entity =>
            {
                entity.ToTable("ProcessorPaymentsGatewayDetails", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DebitorCredit)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OriginationDate).HasColumnType("datetime");

                entity.Property(e => e.PgclientId).HasColumnName("PGClientID");

                entity.Property(e => e.ResponseCode).HasMaxLength(20);

                entity.Property(e => e.ResponseDescription).HasMaxLength(80);

                entity.Property(e => e.ResponseType).HasMaxLength(4);

                entity.Property(e => e.SettleDate).HasColumnType("datetime");

                entity.Property(e => e.SettledResponseCode).HasMaxLength(4);

                entity.Property(e => e.Status).HasMaxLength(80);

                entity.Property(e => e.Stignore).HasColumnName("STIgnore");

                entity.Property(e => e.Stvalidated)
                    .HasColumnName("STValidated")
                    .HasColumnType("datetime");

                entity.Property(e => e.TotalAmount).HasColumnType("money");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(80);
            });

            modelBuilder.Entity<ProcessorPaymentsGatewayTransactions>(entity =>
            {
                entity.ToTable("ProcessorPaymentsGatewayTransactions", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasMaxLength(40);

                entity.Property(e => e.AuthCode).HasMaxLength(40);

                entity.Property(e => e.BillToCompanyName).HasMaxLength(80);

                entity.Property(e => e.BillToFirstName).HasMaxLength(80);

                entity.Property(e => e.BillToLastName).HasMaxLength(80);

                entity.Property(e => e.CardType).HasMaxLength(40);

                entity.Property(e => e.ConsumerId)
                    .HasColumnName("ConsumerID")
                    .HasMaxLength(40);

                entity.Property(e => e.ConsumerOrderId)
                    .HasColumnName("ConsumerOrderID")
                    .HasMaxLength(40);

                entity.Property(e => e.ConvenienceFeePrincipal).HasMaxLength(40);

                entity.Property(e => e.DebitCredit).HasMaxLength(40);

                entity.Property(e => e.EnteredBy).HasMaxLength(40);

                entity.Property(e => e.Last4).HasMaxLength(10);

                entity.Property(e => e.MerchantClientId)
                    .HasColumnName("MerchantClientID")
                    .HasMaxLength(40);

                entity.Property(e => e.MerchantId)
                    .HasColumnName("MerchantID")
                    .HasMaxLength(40);

                entity.Property(e => e.ResponseCode).HasMaxLength(40);

                entity.Property(e => e.ServiceFeePrincipal).HasMaxLength(40);

                entity.Property(e => e.Status).HasMaxLength(80);

                entity.Property(e => e.TotalAmount).HasMaxLength(40);

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasMaxLength(80);

                entity.Property(e => e.TransactionType).HasMaxLength(40);

                entity.Property(e => e.TsCreated).HasMaxLength(40);

                entity.Property(e => e.WalletId)
                    .HasColumnName("WalletID")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<ProductActions>(entity =>
            {
                entity.ToTable("ProductActions", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.ProductActions)
                    .HasForeignKey(d => d.ActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductActions_SystemActions");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductActions)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductActions_Products");
            });

            modelBuilder.Entity<ProductBlockPrices>(entity =>
            {
                entity.ToTable("ProductBlockPrices", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Initial).HasColumnType("money");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Renewal).HasColumnType("money");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductBlockPrices)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductBlockPrices_Products");
            });

            modelBuilder.Entity<ProductIndustries>(entity =>
            {
                entity.ToTable("ProductIndustries", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IndustryId).HasColumnName("IndustryID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Industry)
                    .WithMany(p => p.ProductIndustries)
                    .HasForeignKey(d => d.IndustryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductIndustries_Industries");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductIndustries)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductIndustries_Products");
            });

            modelBuilder.Entity<ProductLicenseFiles>(entity =>
            {
                entity.ToTable("ProductLicenseFiles", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FileName).IsRequired();

                entity.Property(e => e.FileType).IsRequired();
            });

            modelBuilder.Entity<ProductLicenseFilesLogs>(entity =>
            {
                entity.ToTable("ProductLicenseFilesLogs", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ContactPersonId).HasColumnName("ContactPersonID");

                entity.Property(e => e.LicenseId).HasColumnName("LicenseID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<ProductOptions>(entity =>
            {
                entity.ToTable("ProductOptions", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.RenewalPrice).HasColumnType("money");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductOptions)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductOptions_Products");
            });

            modelBuilder.Entity<ProductReportingGroupProducts>(entity =>
            {
                entity.ToTable("ProductReportingGroupProducts", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductReportingGroupId).HasColumnName("ProductReportingGroupID");
            });

            modelBuilder.Entity<ProductReportingGroups>(entity =>
            {
                entity.ToTable("ProductReportingGroups", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.WhiteLabelId).HasColumnName("WhiteLabelID");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.ToTable("Products", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ExpeditePrice).HasColumnType("money");

                entity.Property(e => e.FeatureId).HasColumnName("FeatureID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.LicenseFileId).HasColumnName("LicenseFileID");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ProductGroupId).HasColumnName("ProductGroupID");

                entity.Property(e => e.RelatedProductId).HasColumnName("RelatedProductID");

                entity.Property(e => e.RenewalPrice).HasColumnType("money");

                entity.Property(e => e.ReplacementId).HasColumnName("ReplacementID");

                entity.Property(e => e.SetUpFee).HasColumnType("money");

                entity.Property(e => e.ShortDetails).IsRequired();

                entity.Property(e => e.ShowAsProduct)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Title).IsRequired();

                entity.Property(e => e.Urlname).HasColumnName("URLName");

                entity.Property(e => e.VariationId).HasColumnName("VariationID");

                entity.Property(e => e.WhiteLabelId).HasColumnName("WhiteLabelID");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_Products_CommissionGroups");

                entity.HasOne(d => d.LicenseFile)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.LicenseFileId)
                    .HasConstraintName("FK_Products_LicenseFile");

                entity.HasOne(d => d.WhiteLabel)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.WhiteLabelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Products_WhiteLabels");
            });

            modelBuilder.Entity<ProductTrainings>(entity =>
            {
                entity.ToTable("ProductTrainings", "so");

                entity.HasIndex(e => new { e.ProductId, e.TrainingId })
                    .HasName("IX_ProductTrainings");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.TrainingId).HasColumnName("TrainingID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductTrainings)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductTrainings_Products");
            });

            modelBuilder.Entity<ProfileHelpPages>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .HasDefaultValueSql("((8))");

                entity.Property(e => e.HelpPageId).HasColumnName("HelpPageID");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.HasOne(d => d.HelpPage)
                    .WithMany(p => p.ProfileHelpPages)
                    .HasForeignKey(d => d.HelpPageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfileHelpPages_HelpPages");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.ProfileHelpPages)
                    .HasForeignKey(d => d.ProfileId)
                    .HasConstraintName("FK_ProfileHelpPages_Profiles");
            });

            modelBuilder.Entity<ProfileReports>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.TypeId)
                    .HasColumnName("TypeID")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.ProfileReports)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfileReport_Profiles");
            });

            modelBuilder.Entity<Profiles>(entity =>
            {
                entity.HasIndex(e => e.ClientId);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AllowUserToSelectTrainingMode)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .HasDefaultValueSql("((8))");

                entity.Property(e => e.ManageCrm).HasColumnName("ManageCRM");

                entity.Property(e => e.ManageMsdsheet).HasColumnName("ManageMSDSheet");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.ViewChecklist)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ViewDocumentList)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ViewTrainingList)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Profiles)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Profiles_SystemClients");
            });

            modelBuilder.Entity<QuizLog>(entity =>
            {
                entity.HasIndex(e => new { e.ClientId, e.RunLogQuizId, e.IsAnswerRight })
                    .HasName("IX_QuizLog_ClientID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Answers).IsRequired();

                entity.Property(e => e.Chapter).HasDefaultValueSql("((1))");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.RunLogQuizId).HasColumnName("RunLogQuizID");

                entity.Property(e => e.TrainingId).HasColumnName("TrainingID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.QuizLog)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuizLog_SystemClients");

                entity.HasOne(d => d.RunLogQuiz)
                    .WithMany(p => p.QuizLog)
                    .HasForeignKey(d => d.RunLogQuizId)
                    .HasConstraintName("FK_QuizLog_RunLogQuiz");
            });

            modelBuilder.Entity<ReassignedTasks>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.ReassignedClientId).HasColumnName("ReassignedClientID");

                entity.Property(e => e.ReassignedEmployeeId).HasColumnName("ReassignedEmployeeID");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ReassignedTasks)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReassignedTasks_SystemClients");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.ReassignedTasks)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReassignedTasks_Employees");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.ReassignedTasks)
                    .HasForeignKey(d => d.TaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReassignedTasks_ClientAssignments");
            });

            modelBuilder.Entity<ReassignHistory>(entity =>
            {
                entity.HasIndex(e => new { e.ClientId, e.SetType, e.ProcessDate })
                    .HasName("IX_ReassignHistory_ClientID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AssignedId).HasColumnName("AssignedID");

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .HasDefaultValueSql("((8))");

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Regions>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.RegionName).IsRequired();

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Regions)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Regions_SystemClients");
            });

            modelBuilder.Entity<ReportClients>(entity =>
            {
                entity.ToTable("ReportClients", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ReportClients)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportClients_SystemClients");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.ReportClients)
                    .HasForeignKey(d => d.ReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportClients_Reports");
            });

            modelBuilder.Entity<ReportFiles>(entity =>
            {
                entity.ToTable("ReportFiles", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<ReportFilterTypes>(entity =>
            {
                entity.ToTable("ReportFilterTypes", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FilterTypeId).HasColumnName("FilterTypeID");

                entity.Property(e => e.ReportTypeId).HasColumnName("ReportTypeID");
            });

            modelBuilder.Entity<ReportParams>(entity =>
            {
                entity.ToTable("ReportParams", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.SpdisplayName).HasColumnName("SPDisplayName");

                entity.Property(e => e.SpparamName).HasColumnName("SPParamName");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.ReportParams)
                    .HasForeignKey(d => d.ReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportParams_Reports");
            });

            modelBuilder.Entity<ReportParamsCustoms>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.ReportParamsCustoms)
                    .HasForeignKey(d => d.ReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportParamsCustoms_ReportsCustoms");
            });

            modelBuilder.Entity<Reports>(entity =>
            {
                entity.ToTable("Reports", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Spname).HasColumnName("SPName");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_Reports_SystemClients");
            });

            modelBuilder.Entity<ReportSavedParams>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.SaveTypeId).HasColumnName("SaveTypeID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.ReportSavedParams)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportSavedParams_Employees");
            });

            modelBuilder.Entity<ReportSavedParamValues>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ReportSavedParamId).HasColumnName("ReportSavedParamID");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.HasOne(d => d.ReportSavedParam)
                    .WithMany(p => p.ReportSavedParamValues)
                    .HasForeignKey(d => d.ReportSavedParamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportSavedParamValues_ReportSavedParams");
            });

            modelBuilder.Entity<ReportsCustoms>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ReportsCustoms)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportsCustoms_SystemClients");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.ReportsCustoms)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportsCustoms_Employees");
            });

            modelBuilder.Entity<ResponseLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.DateOfResponse).HasColumnType("datetime");

                entity.Property(e => e.FlowId).HasColumnName("FlowID");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.RunLogId).HasColumnName("RunLogID");

                entity.Property(e => e.TrainingId).HasColumnName("TrainingID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<RunLog>(entity =>
            {
                entity.HasIndex(e => new { e.Id, e.TrainingId, e.FlowId, e.LastRequestDate, e.ClientId, e.EmployeeId, e.Status })
                    .HasName("IX_RunLog_ClientID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BrowserType).IsRequired();

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.FlowId).HasColumnName("FlowID");

                entity.Property(e => e.Ipv4).HasColumnName("IPv4");

                entity.Property(e => e.LastRequestDate).HasColumnType("datetime");

                entity.Property(e => e.TrainingId).HasColumnName("TrainingID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.RunLog)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RunLog_SystemClients");
            });

            modelBuilder.Entity<RunLogQuiz>(entity =>
            {
                entity.HasIndex(e => new { e.RunLogId, e.QuizId, e.IsPass })
                    .HasName("IX_RunLogQuiz_RunLogID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.QuizId).HasColumnName("QuizID");

                entity.Property(e => e.QuizPassingDate).HasColumnType("datetime");

                entity.Property(e => e.RunLogId).HasColumnName("RunLogID");

                entity.HasOne(d => d.RunLog)
                    .WithMany(p => p.RunLogQuiz)
                    .HasForeignKey(d => d.RunLogId)
                    .HasConstraintName("FK_RunLogQuiz_RunLog");
            });

            modelBuilder.Entity<RunPages>(entity =>
            {
                entity.HasIndex(e => new { e.IsActive, e.IsDeleted, e.FlowId, e.RunLogId, e.Seq, e.ClientId, e.EmployeeId })
                    .HasName("IX_RunPages_ClientID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.FlowId).HasColumnName("FlowID");

                entity.Property(e => e.LastTimeAccessed).HasColumnType("datetime");

                entity.Property(e => e.RunLogId).HasColumnName("RunLogID");

                entity.Property(e => e.TrainingId).HasColumnName("TrainingID");

                entity.Property(e => e.TrainingStarted).HasColumnType("datetime");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.RunPages)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_RunPages_Employees");
            });

            modelBuilder.Entity<SalesPersonClients>(entity =>
            {
                entity.ToTable("SalesPersonClients", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.SalesPersonId).HasColumnName("SalesPersonID");

                entity.HasOne(d => d.SalesPerson)
                    .WithMany(p => p.SalesPersonClients)
                    .HasForeignKey(d => d.SalesPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesPersonClients_SalesPersons");
            });

            modelBuilder.Entity<SalesPersonGroups>(entity =>
            {
                entity.ToTable("SalesPersonGroups", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CommissionGroupId).HasColumnName("CommissionGroupID");

                entity.Property(e => e.SalesPersonId).HasColumnName("SalesPersonID");

                entity.HasOne(d => d.CommissionGroup)
                    .WithMany(p => p.SalesPersonGroups)
                    .HasForeignKey(d => d.CommissionGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesPersonGroups_CommissionGroups");

                entity.HasOne(d => d.SalesPerson)
                    .WithMany(p => p.SalesPersonGroups)
                    .HasForeignKey(d => d.SalesPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesPersonGroups_SalesPersons");
            });

            modelBuilder.Entity<SalesPersons>(entity =>
            {
                entity.ToTable("SalesPersons", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.HubSpotOwnerId).HasColumnName("HubSpotOwnerID");

                entity.Property(e => e.IndustryId).HasColumnName("IndustryID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.WhiteLabelId).HasColumnName("WhiteLabelID");

                entity.HasOne(d => d.Industry)
                    .WithMany(p => p.SalesPersons)
                    .HasForeignKey(d => d.IndustryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesPersons_Industries");

                entity.HasOne(d => d.WhiteLabel)
                    .WithMany(p => p.SalesPersons)
                    .HasForeignKey(d => d.WhiteLabelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesPersons_WhiteLabels");
            });

            modelBuilder.Entity<ScormVars>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.TrainingId).HasColumnName("TrainingID");

                entity.Property(e => e.VarName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.VarValue).IsRequired();
            });

            modelBuilder.Entity<ServiceLogs>(entity =>
            {
                entity.ToTable("ServiceLogs", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");
            });

            modelBuilder.Entity<SetAssigneds>(entity =>
            {
                entity.HasIndex(e => new { e.ClientId, e.EmployeeId })
                    .HasName("IX_SetAssigneds_ClientID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionAfterCd).HasColumnName("ActionAfterCD");

                entity.Property(e => e.AssignedDate).HasColumnType("datetime");

                entity.Property(e => e.AssignedId).HasColumnName("AssignedID");

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .HasDefaultValueSql("((8))");

                entity.Property(e => e.CompletionDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EscalationsId).HasColumnName("EscalationsID");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.SetId).HasColumnName("SetID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.SetAssigneds)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SetAssigneds_SystemClients");

                entity.HasOne(d => d.Set)
                    .WithMany(p => p.SetAssigneds)
                    .HasForeignKey(d => d.SetId)
                    .HasConstraintName("FK_SetAssigneds_Sets");
            });

            modelBuilder.Entity<SetDetails>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CountryId)
                    .HasColumnName("CountryID")
                    .HasMaxLength(2);

                entity.Property(e => e.SetId).HasColumnName("SetID");

                entity.Property(e => e.Zip)
                    .HasColumnName("ZIP")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Set)
                    .WithMany(p => p.SetDetails)
                    .HasForeignKey(d => d.SetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SetDetails_Sets");
            });

            modelBuilder.Entity<SetRegions>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.SetId).HasColumnName("SetID");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.SetRegions)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SetRegions_Regions");

                entity.HasOne(d => d.Set)
                    .WithMany(p => p.SetRegions)
                    .HasForeignKey(d => d.SetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SetRegions_Sets");
            });

            modelBuilder.Entity<Sets>(entity =>
            {
                entity.HasIndex(e => e.ClientId);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .HasDefaultValueSql("((8))");

                entity.Property(e => e.ImportDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PreviousId).HasColumnName("PreviousID");

                entity.Property(e => e.ReportingId).HasColumnName("ReportingID");

                entity.Property(e => e.SetTopId).HasColumnName("SetTopID");

                entity.Property(e => e.SupervisorId).HasColumnName("SupervisorID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Sets)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sets_SystemClients");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Sets_Sets");

                entity.HasOne(d => d.SetTop)
                    .WithMany(p => p.Sets)
                    .HasForeignKey(d => d.SetTopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sets_SetTops");

                entity.HasOne(d => d.Supervisor)
                    .WithMany(p => p.Sets)
                    .HasForeignKey(d => d.SupervisorId)
                    .HasConstraintName("FK_Sets_Employees");
            });

            modelBuilder.Entity<SetTopProfiles>(entity =>
            {
                entity.HasIndex(e => e.ProfileId);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AllowAssign)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AllowManageGroup)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AllowManageSelected)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AllowModify)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.SetTopId).HasColumnName("SetTopID");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.SetTopProfiles)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SetTopProfiles_Profiles");

                entity.HasOne(d => d.SetTop)
                    .WithMany(p => p.SetTopProfiles)
                    .HasForeignKey(d => d.SetTopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SetTopProfiles_SetTops");
            });

            modelBuilder.Entity<SetTops>(entity =>
            {
                entity.HasIndex(e => e.ClientId);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<SetUserAssigneds>(entity =>
            {
                entity.HasIndex(e => new { e.Id, e.SetId, e.EmployeeId, e.AssignedDate, e.ImportDate, e.ClientId })
                    .HasName("IX_SetUserAssigneds_ClientID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AssignedDate).HasColumnType("datetime");

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .HasDefaultValueSql("((8))");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.ImportDate).HasColumnType("datetime");

                entity.Property(e => e.SetId).HasColumnName("SetID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.SetUserAssigneds)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SetUserAssigneds_SystemClients");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.SetUserAssigneds)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SetUserAssigneds_Employees");

                entity.HasOne(d => d.Set)
                    .WithMany(p => p.SetUserAssigneds)
                    .HasForeignKey(d => d.SetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SetUserAssigneds_Sets");
            });

            modelBuilder.Entity<SetUserManaged>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.SetId).HasColumnName("SetID");

                entity.HasOne(d => d.Set)
                    .WithMany(p => p.SetUserManaged)
                    .HasForeignKey(d => d.SetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SetUserManaged_Sets");
            });

            modelBuilder.Entity<ShoppingCartCache>(entity =>
            {
                entity.ToTable("ShoppingCartCache", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccessInterval).HasDefaultValueSql("((1))");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CombinedDiscountId).HasColumnName("CombinedDiscountID");

                entity.Property(e => e.ContactPersonId).HasColumnName("ContactPersonID");

                entity.Property(e => e.DiscountId).HasColumnName("DiscountID");

                entity.Property(e => e.ExpeditePrice).HasColumnType("money");

                entity.Property(e => e.IndustryId).HasColumnName("IndustryID");

                entity.Property(e => e.OptionId).HasColumnName("OptionID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.WhiteLabelId).HasColumnName("WhiteLabelID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ShoppingCartCache)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShoppingCartCache_Products");

                entity.HasOne(d => d.WhiteLabel)
                    .WithMany(p => p.ShoppingCartCache)
                    .HasForeignKey(d => d.WhiteLabelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShoppingCartCache_WhiteLabels");
            });

            modelBuilder.Entity<Slanswers>(entity =>
            {
                entity.ToTable("SLAnswers", "smo");

                entity.HasIndex(e => e.QuestionId)
                    .HasName("IX_Answers_QuestionID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AnswerXaml)
                    .IsRequired()
                    .HasColumnName("AnswerXAML");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.PictureId).HasColumnName("PictureID");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Slanswers)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK_Answers_Questions");
            });

            modelBuilder.Entity<Slchapters>(entity =>
            {
                entity.ToTable("SLChapters", "smo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.Title).IsRequired();
            });

            modelBuilder.Entity<Slconfiguration>(entity =>
            {
                entity.ToTable("SLConfiguration", "smo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Comments).IsRequired();

                entity.Property(e => e.DateOfLastEdit)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            });

            modelBuilder.Entity<SlconfigurationForLanguages>(entity =>
            {
                entity.ToTable("SLConfigurationForLanguages", "smo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Comments).IsRequired();

                entity.Property(e => e.DateOfLastEdit)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.QuizIsRandomized)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Sldocuments>(entity =>
            {
                entity.ToTable("SLDocuments", "smo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DocData).IsRequired();

                entity.Property(e => e.DocDateOfLastEdit).HasColumnType("datetime");

                entity.Property(e => e.DocName).IsRequired();

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            });

            modelBuilder.Entity<Slmedia>(entity =>
            {
                entity.ToTable("SLMedia", "smo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.LowQualityId).HasColumnName("LowQualityID");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            });

            modelBuilder.Entity<Slpages>(entity =>
            {
                entity.ToTable("SLPages", "smo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.PageDll).HasColumnName("PageDLL");

                entity.Property(e => e.PageXaml)
                    .IsRequired()
                    .HasColumnName("PageXAML");
            });

            modelBuilder.Entity<Slquestions>(entity =>
            {
                entity.ToTable("SLQuestions", "smo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AudioId).HasColumnName("AudioID");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.PictureId).HasColumnName("PictureID");

                entity.Property(e => e.QuestionTypeId).HasColumnName("QuestionTypeID");

                entity.Property(e => e.QuizId).HasColumnName("QuizID");

                entity.Property(e => e.Xaml)
                    .IsRequired()
                    .HasColumnName("XAML");

                entity.HasOne(d => d.Audio)
                    .WithMany(p => p.Slquestions)
                    .HasForeignKey(d => d.AudioId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Questions_Media");

                entity.HasOne(d => d.Quiz)
                    .WithMany(p => p.Slquestions)
                    .HasForeignKey(d => d.QuizId)
                    .HasConstraintName("FK_Questions_Quizzes");
            });

            modelBuilder.Entity<SlquestionsRelated>(entity =>
            {
                entity.ToTable("SLQuestionsRelated", "smo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.PageId).HasColumnName("PageID");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.SlquestionsRelated)
                    .HasForeignKey(d => d.PageId)
                    .HasConstraintName("FK_QuestionsRelated_Pages");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.SlquestionsRelated)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK_QuestionsRelated_Questions");
            });

            modelBuilder.Entity<Slquizzes>(entity =>
            {
                entity.ToTable("SLQuizzes", "smo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            });

            modelBuilder.Entity<SltrainingFlow>(entity =>
            {
                entity.ToTable("SLTrainingFlow", "smo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.PageId).HasColumnName("PageID");

                entity.Property(e => e.QuizId).HasColumnName("QuizID");

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.SltrainingFlow)
                    .HasForeignKey(d => d.PageId)
                    .HasConstraintName("FK_TrainingFlow_Pages");

                entity.HasOne(d => d.Quiz)
                    .WithMany(p => p.SltrainingFlow)
                    .HasForeignKey(d => d.QuizId)
                    .HasConstraintName("FK_TrainingFlow_Quizzes");
            });

            modelBuilder.Entity<States>(entity =>
            {
                entity.ToTable("States", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Abbreviation).IsRequired();

                entity.Property(e => e.CountryId)
                    .IsRequired()
                    .HasColumnName("CountryID")
                    .HasMaxLength(2)
                    .HasDefaultValueSql("('US')");

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.States)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_States_Countries");
            });

            modelBuilder.Entity<StreportColumns>(entity =>
            {
                entity.ToTable("STReportColumns", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ColumnName).IsRequired();

                entity.Property(e => e.RelationalId).HasColumnName("RelationalID");

                entity.Property(e => e.StreportId).HasColumnName("STReportID");

                entity.HasOne(d => d.Streport)
                    .WithMany(p => p.StreportColumns)
                    .HasForeignKey(d => d.StreportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STReportColumns_STReportColumns");
            });

            modelBuilder.Entity<Streports>(entity =>
            {
                entity.ToTable("STReports", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TableName).IsRequired();
            });

            modelBuilder.Entity<StreportsCustoms>(entity =>
            {
                entity.ToTable("STReportsCustoms");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Layout).IsRequired();

                entity.Property(e => e.ReportName).IsRequired();

                entity.Property(e => e.StreportsId).HasColumnName("STReportsID");
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .HasDefaultValueSql("((8))");

                entity.Property(e => e.ImportDate).HasColumnType("datetime");

                entity.Property(e => e.SubjectName).IsRequired();

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Subject)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Subject_SystemClients");
            });

            modelBuilder.Entity<SubscriptionPlans>(entity =>
            {
                entity.ToTable("SubscriptionPlans", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.WhiteLabelId).HasColumnName("WhiteLabelID");
            });

            modelBuilder.Entity<SurveyAnswerQuestionDetails>(entity =>
            {
                entity.ToTable("SurveyAnswerQuestionDetails", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AnswerQuestionId).HasColumnName("AnswerQuestionID");

                entity.Property(e => e.ColumnId).HasColumnName("ColumnID");

                entity.Property(e => e.Fid).HasColumnName("FID");

                entity.Property(e => e.GroupId)
                    .HasColumnName("GroupID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PredefinedAnswerId).HasColumnName("PredefinedAnswerID");

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.SdssheetId).HasColumnName("SDSSheetID");

                entity.HasOne(d => d.AnswerQuestion)
                    .WithMany(p => p.SurveyAnswerQuestionDetails)
                    .HasForeignKey(d => d.AnswerQuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SurveyAnswerQuestionDetails_SurveyAnswerQuestions");
            });

            modelBuilder.Entity<SurveyAnswerQuestions>(entity =>
            {
                entity.ToTable("SurveyAnswerQuestions", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AnswerId).HasColumnName("AnswerID");

                entity.Property(e => e.Fid).HasColumnName("FID");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.HasOne(d => d.Answer)
                    .WithMany(p => p.SurveyAnswerQuestions)
                    .HasForeignKey(d => d.AnswerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SurveyAnswerQuestions_SurveyAnswers");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.SurveyAnswerQuestions)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SurveyAnswerQuestions_SurveyQuestions");
            });

            modelBuilder.Entity<SurveyAnswers>(entity =>
            {
                entity.ToTable("SurveyAnswers", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CopyToDocuments)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Fid).HasColumnName("FID");

                entity.Property(e => e.FilledByClientId).HasColumnName("FilledByClientID");

                entity.Property(e => e.FilledByUserId).HasColumnName("FilledByUserID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.RunLogId).HasColumnName("RunLogID");

                entity.Property(e => e.SurveyClientId).HasColumnName("SurveyClientID");

                entity.Property(e => e.SurveyId).HasColumnName("SurveyID");

                entity.Property(e => e.TrainingId).HasColumnName("TrainingID");

                entity.HasOne(d => d.Survey)
                    .WithMany(p => p.SurveyAnswers)
                    .HasForeignKey(d => d.SurveyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SurveyAnswers_Surveys");
            });

            modelBuilder.Entity<SurveyDocumentResults>(entity =>
            {
                entity.ToTable("SurveyDocumentResults", "so");

                entity.HasIndex(e => new { e.Id, e.SurveyAnswerId })
                    .HasName("IX_SurveyDocumentResults_ClientID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Fid).HasColumnName("FID");

                entity.Property(e => e.FileName).IsRequired();

                entity.Property(e => e.SurveyAnswerId).HasColumnName("SurveyAnswerID");

                entity.Property(e => e.SurveyDocumentId).HasColumnName("SurveyDocumentID");

                entity.HasOne(d => d.SurveyAnswer)
                    .WithMany(p => p.SurveyDocumentResults)
                    .HasForeignKey(d => d.SurveyAnswerId)
                    .HasConstraintName("FK_SurveyDocumentResults_SurveyAnswers");
            });

            modelBuilder.Entity<SurveyDocuments>(entity =>
            {
                entity.ToTable("SurveyDocuments", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Fid).HasColumnName("FID");

                entity.Property(e => e.FileName).IsRequired();

                entity.Property(e => e.Marked)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.SurveyId).HasColumnName("SurveyID");

                entity.HasOne(d => d.Survey)
                    .WithMany(p => p.SurveyDocuments)
                    .HasForeignKey(d => d.SurveyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SurveyDocuments_Surveys");
            });

            modelBuilder.Entity<SurveyMissingQuestions>(entity =>
            {
                entity.ToTable("SurveyMissingQuestions", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AnswerId).HasColumnName("AnswerID");

                entity.Property(e => e.ColumnId).HasColumnName("ColumnID");

                entity.Property(e => e.Fid).HasColumnName("FID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.PredefinedAnswerId).HasColumnName("PredefinedAnswerID");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.SdssheetId).HasColumnName("SDSSheetID");
            });

            modelBuilder.Entity<SurveyPredefinedAnswers>(entity =>
            {
                entity.ToTable("SurveyPredefinedAnswers", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ColumnId).HasColumnName("ColumnID");

                entity.Property(e => e.Fid).HasColumnName("FID");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.Text).IsRequired();

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.SurveyPredefinedAnswers)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SurveyPredefinedAnswers_SurveyQuestions");
            });

            modelBuilder.Entity<SurveyQuestionColumns>(entity =>
            {
                entity.ToTable("SurveyQuestionColumns", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AnswerId).HasColumnName("AnswerID");

                entity.Property(e => e.Fid).HasColumnName("FID");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.Text).IsRequired();

                entity.HasOne(d => d.Answer)
                    .WithMany(p => p.SurveyQuestionColumns)
                    .HasForeignKey(d => d.AnswerId)
                    .HasConstraintName("FK_SurveyQuestionColumns_SurveyAnswers");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.SurveyQuestionColumns)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SurveyQuestionColumns_SurveyQuestions");
            });

            modelBuilder.Entity<SurveyQuestionRates>(entity =>
            {
                entity.ToTable("SurveyQuestionRates", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.SurveyQuestionRates)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SurveyQuestionRates_SurveyQuestions");
            });

            modelBuilder.Entity<SurveyQuestionRows>(entity =>
            {
                entity.ToTable("SurveyQuestionRows", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AnswerId).HasColumnName("AnswerID");

                entity.Property(e => e.Fid).HasColumnName("FID");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.Text).IsRequired();

                entity.HasOne(d => d.Answer)
                    .WithMany(p => p.SurveyQuestionRows)
                    .HasForeignKey(d => d.AnswerId)
                    .HasConstraintName("FK_SurveyQuestionRows_SurveyAnswers");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.SurveyQuestionRows)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SurveyQuestionRows_SurveyQuestions");
            });

            modelBuilder.Entity<SurveyQuestions>(entity =>
            {
                entity.ToTable("SurveyQuestions", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Fid).HasColumnName("FID");

                entity.Property(e => e.RelatedQuestionId).HasColumnName("RelatedQuestionID");

                entity.Property(e => e.RelatedRowId).HasColumnName("RelatedRowID");

                entity.Property(e => e.SurveyId).HasColumnName("SurveyID");

                entity.Property(e => e.Text).IsRequired();

                entity.HasOne(d => d.Survey)
                    .WithMany(p => p.SurveyQuestions)
                    .HasForeignKey(d => d.SurveyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SurveyQuestions_Surveys");
            });

            modelBuilder.Entity<Surveys>(entity =>
            {
                entity.ToTable("Surveys", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedByClientId).HasColumnName("CreatedByClientID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.Fid).HasColumnName("FID");

                entity.Property(e => e.IsAllowedEditAnswer)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Title).IsRequired();

                entity.Property(e => e.Urlparameter)
                    .IsRequired()
                    .HasColumnName("URLParameter")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<SurveySdssheets>(entity =>
            {
                entity.ToTable("SurveySDSSheets", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Fid).HasColumnName("FID");

                entity.Property(e => e.FileName).IsRequired();

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<SurveyUsers>(entity =>
            {
                entity.ToTable("SurveyUsers", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Fid).HasColumnName("FID");

                entity.Property(e => e.SurveyId).HasColumnName("SurveyID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Survey)
                    .WithMany(p => p.SurveyUsers)
                    .HasForeignKey(d => d.SurveyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SurveyUsers_Surveys");
            });

            modelBuilder.Entity<SurveyUsersSettings>(entity =>
            {
                entity.ToTable("SurveyUsersSettings", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.SurveyId).HasColumnName("SurveyID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Survey)
                    .WithMany(p => p.SurveyUsersSettings)
                    .HasForeignKey(d => d.SurveyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SurveyUsersSettings_Surveys");
            });

            modelBuilder.Entity<SyllabusAssignments>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AssignedId).HasColumnName("AssignedID");

                entity.Property(e => e.SyllabusId).HasColumnName("SyllabusID");

                entity.HasOne(d => d.Syllabus)
                    .WithMany(p => p.SyllabusAssignments)
                    .HasForeignKey(d => d.SyllabusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SyllabusAssignments_SyllabusNames");
            });

            modelBuilder.Entity<SyllabusNames>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SystemActionFilters>(entity =>
            {
                entity.ToTable("SystemActionFilters", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TemplateDefaultId).HasColumnName("TemplateDefaultID");
            });

            modelBuilder.Entity<SystemActions>(entity =>
            {
                entity.ToTable("SystemActions", "so");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActionTypeId).HasColumnName("ActionTypeID");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Priority).HasDefaultValueSql("((20))");

                entity.Property(e => e.WorkFlowId).HasColumnName("WorkFlowID");

                entity.HasOne(d => d.ActionType)
                    .WithMany(p => p.SystemActions)
                    .HasForeignKey(d => d.ActionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SystemActions_SystemActionTypes");
            });

            modelBuilder.Entity<SystemActionTypes>(entity =>
            {
                entity.ToTable("SystemActionTypes", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<SystemActionWffilters>(entity =>
            {
                entity.ToTable("SystemActionWFFilters", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionWfid).HasColumnName("ActionWFID");

                entity.HasOne(d => d.ActionWf)
                    .WithMany(p => p.SystemActionWffilters)
                    .HasForeignKey(d => d.ActionWfid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SystemActionWFFilters_SystemActionWFs");
            });

            modelBuilder.Entity<SystemActionWfs>(entity =>
            {
                entity.ToTable("SystemActionWFs", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.IndustryId).HasColumnName("IndustryID");

                entity.Property(e => e.WorkfFlowId).HasColumnName("WorkfFlowID");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.SystemActionWfs)
                    .HasForeignKey(d => d.ActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SystemActionWFs_SystemActions");

                entity.HasOne(d => d.WorkfFlow)
                    .WithMany(p => p.SystemActionWfs)
                    .HasForeignKey(d => d.WorkfFlowId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SystemActionWFs_WorkfFlow");
            });

            modelBuilder.Entity<SystemAdmins>(entity =>
            {
                entity.ToTable("SystemAdmins", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.SubClientId).HasColumnName("SubClientID");

                entity.Property(e => e.Wlpid).HasColumnName("WLPID");
            });

            modelBuilder.Entity<SystemCertificateForms>(entity =>
            {
                entity.ToTable("SystemCertificateForms", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContentType).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateOfLastEdit).HasColumnType("datetime");

                entity.Property(e => e.FormContent).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.TrainingId).HasColumnName("TrainingID");
            });

            modelBuilder.Entity<SystemCertificateTrainings>(entity =>
            {
                entity.ToTable("SystemCertificateTrainings", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CertificateFormId).HasColumnName("CertificateFormID");

                entity.Property(e => e.TrainingId).HasColumnName("TrainingID");

                entity.HasOne(d => d.CertificateForm)
                    .WithMany(p => p.SystemCertificateTrainings)
                    .HasForeignKey(d => d.CertificateFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SystemCertificateTrainings_SystemCertificateForms");
            });

            modelBuilder.Entity<SystemClients>(entity =>
            {
                entity.ToTable("SystemClients", "so");

                entity.HasIndex(e => new { e.Id, e.UniqueUrl, e.Name, e.IsActive, e.WhiteLabelId, e.IndustryId })
                    .HasName("IX_SystemClients_IsActive");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("('2016-01-01')");

                entity.Property(e => e.GracePeriod).HasDefaultValueSql("((1))");

                entity.Property(e => e.HubSpotId).HasColumnName("HubSpotID");

                entity.Property(e => e.IndustryId).HasColumnName("IndustryID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LicenseFileId).HasColumnName("LicenseFileID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ParentLevel).HasDefaultValueSql("((1))");

                entity.Property(e => e.PlanId).HasColumnName("PlanID");

                entity.Property(e => e.RequestNameChangeDate).HasColumnType("datetime");

                entity.Property(e => e.RetryAttempts).HasDefaultValueSql("((3))");

                entity.Property(e => e.UniqueUrl)
                    .HasColumnName("UniqueURL")
                    .HasMaxLength(100);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("URL");

                entity.Property(e => e.UserLicenseFileId).HasColumnName("UserLicenseFileID");

                entity.Property(e => e.WhiteLabelId)
                    .HasColumnName("WhiteLabelID")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.SystemClients)
                    .HasForeignKey(d => d.PlanId)
                    .HasConstraintName("FK_SystemClients_SubscriptionPlans");
            });

            modelBuilder.Entity<SystemEmailTemplateDefaults>(entity =>
            {
                entity.ToTable("SystemEmailTemplateDefaults", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EnumTemplateId).HasColumnName("EnumTemplateID");

                entity.Property(e => e.IndustryId).HasColumnName("IndustryID");

                entity.Property(e => e.NotificationListId).HasColumnName("NotificationListID");

                entity.Property(e => e.SystemTemplateId).HasColumnName("SystemTemplateID");

                entity.HasOne(d => d.NotificationList)
                    .WithMany(p => p.SystemEmailTemplateDefaults)
                    .HasForeignKey(d => d.NotificationListId)
                    .HasConstraintName("FK_SystemEmailTemplateDefaults_SystemNotificationList");
            });

            modelBuilder.Entity<SystemEmailTemplates>(entity =>
            {
                entity.ToTable("SystemEmailTemplates", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Template).IsRequired();
            });

            modelBuilder.Entity<SystemGroups>(entity =>
            {
                entity.ToTable("SystemGroups", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MasterClientId).HasColumnName("MasterClientID");

                entity.Property(e => e.MasterGroupName).IsRequired();

                entity.Property(e => e.VendorClientId).HasColumnName("VendorClientID");

                entity.Property(e => e.VendorGroupId).HasColumnName("VendorGroupID");

                entity.HasOne(d => d.VendorClient)
                    .WithMany(p => p.SystemGroups)
                    .HasForeignKey(d => d.VendorClientId)
                    .HasConstraintName("FK_SystemGroups_SystemClients");
            });

            modelBuilder.Entity<SystemMedia>(entity =>
            {
                entity.ToTable("SystemMedia", "so");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<SystemNotificationList>(entity =>
            {
                entity.ToTable("SystemNotificationList", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.PermissionTypeId).HasColumnName("PermissionTypeID");
            });

            modelBuilder.Entity<SystemSettings>(entity =>
            {
                entity.ToTable("SystemSettings", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.KeyName).IsRequired();

                entity.Property(e => e.WhiteLabelId).HasColumnName("WhiteLabelID");
            });

            modelBuilder.Entity<TempTransactions>(entity =>
            {
                entity.ToTable("TempTransactions", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Action).HasColumnName("action");

                entity.Property(e => e.AuthorizationAmount).HasColumnName("authorization_amount");

                entity.Property(e => e.AuthorizationCode).HasColumnName("authorization_code");

                entity.Property(e => e.BillingaddressCompanyName).HasColumnName("Billingaddress_company_name");

                entity.Property(e => e.BillingaddressFirstName).HasColumnName("Billingaddress_first_name");

                entity.Property(e => e.BillingaddressLastName).HasColumnName("Billingaddress_last_name");

                entity.Property(e => e.CardCardType).HasColumnName("Card_card_type");

                entity.Property(e => e.CardMaskedAccountNumber).HasColumnName("Card_masked_account_number");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ContacPersonId).HasColumnName("ContacPersonID");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.CustomerToken).HasColumnName("customer_token");

                entity.Property(e => e.EnteredBy).HasColumnName("entered_by");

                entity.Property(e => e.IsMultiple)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LinkSelf).HasColumnName("Link_self");

                entity.Property(e => e.LinkSettlements).HasColumnName("Link_settlements");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.OrderNumber).HasColumnName("order_number");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_id");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasDefaultValueSql("((137))");

                entity.Property(e => e.ReceivedDate)
                    .HasColumnName("received_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReferenceId).HasColumnName("reference_id");

                entity.Property(e => e.ResponseResponseCode).HasColumnName("Response_response_code");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<TextBases>(entity =>
            {
                entity.ToTable("TextBases", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Value).IsRequired();

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.TextBases)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_TextBases_SystemClients");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.TextBases)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FK_TextBases_Languages");
            });

            modelBuilder.Entity<TrainingLanguageVersions>(entity =>
            {
                entity.ToTable("TrainingLanguageVersions", "so");

                entity.HasIndex(e => new { e.TrainingId, e.LanguageId, e.Status, e.IsHtml5, e.Deleted })
                    .HasName("IX_TrainingLanguageVersions_ModuleID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.LastChangeDate).HasColumnType("datetime");

                entity.Property(e => e.TrainingId).HasColumnName("TrainingID");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.TrainingLanguageVersions)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TrainingLanguageVersions_Languages");

                entity.HasOne(d => d.Training)
                    .WithMany(p => p.TrainingLanguageVersions)
                    .HasForeignKey(d => d.TrainingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TrainingLanguageVersions_Trainings");
            });

            modelBuilder.Entity<Trainings>(entity =>
            {
                entity.ToTable("Trainings", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ExternalCourseId).HasColumnName("ExternalCourseID");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ReplacementId).HasColumnName("ReplacementID");

                entity.Property(e => e.ScoreType).HasDefaultValueSql("((2))");

                entity.Property(e => e.ScormStartPage).HasMaxLength(200);
            });

            modelBuilder.Entity<TrainingsCompleted>(entity =>
            {
                entity.HasIndex(e => e.TrainingId);

                entity.HasIndex(e => new { e.ClientId, e.EmployeeId })
                    .HasName("IX_TrainingsCompleted_EmployeeID");

                entity.HasIndex(e => new { e.ClientId, e.Status })
                    .HasName("IX_TrainingsCompleted_ClientID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CehourF).HasColumnName("CEHourF");

                entity.Property(e => e.Cehours).HasColumnName("CEHours");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.GroupTrainingId).HasColumnName("GroupTrainingID");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.PracticalExamId).HasColumnName("PracticalExamID");

                entity.Property(e => e.RunLogId).HasColumnName("RunLogID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.TrainingFinishDate).HasColumnType("datetime");

                entity.Property(e => e.TrainingFinishDateForClassroom).HasColumnType("datetime");

                entity.Property(e => e.TrainingId).HasColumnName("TrainingID");

                entity.Property(e => e.TrainingStartDate).HasColumnType("datetime");

                entity.Property(e => e.TrainingVersionLanguageId).HasColumnName("TrainingVersionLanguageID");

                entity.Property(e => e.VersionDateofLastChange)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('01-01-2011')");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.TrainingsCompleted)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TrainingsCompleted_SystemClients");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TrainingsCompleted)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TrainingsCompleted_Employees");

                entity.HasOne(d => d.RunLog)
                    .WithMany(p => p.TrainingsCompleted)
                    .HasForeignKey(d => d.RunLogId)
                    .HasConstraintName("FK_TrainingsCompleted_RunLog");
            });

            modelBuilder.Entity<TrainingsOwners>(entity =>
            {
                entity.ToTable("TrainingsOwners", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OwnerId).HasColumnName("OwnerID");

                entity.Property(e => e.TrainingId).HasColumnName("TrainingID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.TrainingsOwners)
                    .HasForeignKey(d => d.OwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TrainingsOwners_SystemClients");

                entity.HasOne(d => d.Training)
                    .WithMany(p => p.TrainingsOwners)
                    .HasForeignKey(d => d.TrainingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TrainingsOwners_Trainings");
            });

            modelBuilder.Entity<Transactions>(entity =>
            {
                entity.ToTable("Transactions", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CommissionGroupAssignmentId).HasColumnName("CommissionGroupAssignmentID");

                entity.Property(e => e.CommissionScheduleId).HasColumnName("CommissionScheduleID");

                entity.Property(e => e.GroupId)
                    .IsRequired()
                    .HasColumnName("GroupID");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.IsNew)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ProcessDate).HasDefaultValueSql("('2016-01-01')");

                entity.Property(e => e.SalesPersonId).HasColumnName("SalesPersonID");

                entity.Property(e => e.TransactionTypeId).HasColumnName("TransactionTypeID");

                entity.Property(e => e.WhiteLabelId).HasColumnName("WhiteLabelID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_Transactions_SystemClients");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.InvoiceId)
                    .HasConstraintName("FK_Transactions_Invoices");

                entity.HasOne(d => d.SalesPerson)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.SalesPersonId)
                    .HasConstraintName("FK_Transactions_SalesPersons");

                entity.HasOne(d => d.TransactionType)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.TransactionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transactions_TransactionTypes");

                entity.HasOne(d => d.WhiteLabel)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.WhiteLabelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transactions_WhiteLabels");
            });

            modelBuilder.Entity<TransactionTypes>(entity =>
            {
                entity.ToTable("TransactionTypes", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<UserAddresses>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address).IsRequired();

                entity.Property(e => e.City).IsRequired();

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CountryId)
                    .IsRequired()
                    .HasColumnName("CountryID")
                    .HasMaxLength(2)
                    .HasDefaultValueSql("('US')");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.PhoneNumber).IsRequired();

                entity.Property(e => e.State).IsRequired();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Zip).IsRequired();

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.UserAddresses)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserAddresses_SystemClients");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.UserAddresses)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserAddresses_Countries1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserAddresses)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserAddresses_Employees");
            });

            modelBuilder.Entity<UserCertificates>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CertificateFormId).HasColumnName("CertificateFormID");

                entity.Property(e => e.CertificateId)
                    .HasColumnName("CertificateID")
                    .HasMaxLength(100);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Pin)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.TrainingCompletedId).HasColumnName("TrainingCompletedID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.UserCertificates)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserCertificates_SystemClients");

                entity.HasOne(d => d.TrainingCompleted)
                    .WithMany(p => p.UserCertificates)
                    .HasForeignKey(d => d.TrainingCompletedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserCertificates_TrainingsCompleted");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserCertificates)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserCertificates_Employees");
            });

            modelBuilder.Entity<WalkThroughAssigns>(entity =>
            {
                entity.ToTable("WalkThroughAssigns", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.IndustryId).HasColumnName("IndustryID");

                entity.Property(e => e.WalkThroughId).HasColumnName("WalkThroughID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.WalkThroughAssigns)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_WalkThroughAssigns_SystemClients");

                entity.HasOne(d => d.Industry)
                    .WithMany(p => p.WalkThroughAssigns)
                    .HasForeignKey(d => d.IndustryId)
                    .HasConstraintName("FK_WalkThroughAssigns_Industries");

                entity.HasOne(d => d.WalkThrough)
                    .WithMany(p => p.WalkThroughAssigns)
                    .HasForeignKey(d => d.WalkThroughId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WalkThroughAssigns_WalkThroughs");
            });

            modelBuilder.Entity<WalkThroughProfiles>(entity =>
            {
                entity.ToTable("WalkThroughProfiles", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PermissionTypeId).HasColumnName("PermissionTypeID");

                entity.Property(e => e.WalkThroughId).HasColumnName("WalkThroughID");

                entity.HasOne(d => d.WalkThrough)
                    .WithMany(p => p.WalkThroughProfiles)
                    .HasForeignKey(d => d.WalkThroughId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WalkThroughProfiles_WalkThroughs");
            });

            modelBuilder.Entity<WalkThroughs>(entity =>
            {
                entity.ToTable("WalkThroughs", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<WalkThroughSteps>(entity =>
            {
                entity.ToTable("WalkThroughSteps", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ElementId)
                    .IsRequired()
                    .HasColumnName("ElementID");

                entity.Property(e => e.PageUrl)
                    .IsRequired()
                    .HasColumnName("PageURL");

                entity.Property(e => e.Placement)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.WalkthroughId).HasColumnName("WalkthroughID");

                entity.HasOne(d => d.Walkthrough)
                    .WithMany(p => p.WalkThroughSteps)
                    .HasForeignKey(d => d.WalkthroughId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WalkThroughSteps_WalkThroughs");
            });

            modelBuilder.Entity<WfclientTasks>(entity =>
            {
                entity.ToTable("WFClientTasks", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.ActionLogId).HasColumnName("ActionLogID");

                entity.Property(e => e.AssignClientId).HasColumnName("AssignClientID");

                entity.Property(e => e.AssignEmployeeSetId).HasColumnName("AssignEmployeeSetID");

                entity.Property(e => e.ClientAssignmentId).HasColumnName("ClientAssignmentID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ParameterId).HasColumnName("ParameterID");

                entity.Property(e => e.ParentWfclientTaskId).HasColumnName("ParentWFClientTaskID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.SetAssignId).HasColumnName("SetAssignID");

                entity.Property(e => e.WfstepId).HasColumnName("WFStepID");

                entity.Property(e => e.WfstepTemplateId).HasColumnName("WFStepTemplateID");

                entity.HasOne(d => d.ActionLog)
                    .WithMany(p => p.WfclientTasks)
                    .HasForeignKey(d => d.ActionLogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WFClientTasks_ActionLogs");

                entity.HasOne(d => d.WfstepTemplate)
                    .WithMany(p => p.WfclientTasks)
                    .HasForeignKey(d => d.WfstepTemplateId)
                    .HasConstraintName("FK_WFClientTasks_WFStepTemplates");
            });

            modelBuilder.Entity<Wfsteps>(entity =>
            {
                entity.ToTable("WFSteps", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.ParameterId).HasColumnName("ParameterID");

                entity.Property(e => e.WorkFlowId).HasColumnName("WorkFlowID");

                entity.HasOne(d => d.WorkFlow)
                    .WithMany(p => p.Wfsteps)
                    .HasForeignKey(d => d.WorkFlowId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WFSteps_WorkfFlow");
            });

            modelBuilder.Entity<WfstepsDiagram>(entity =>
            {
                entity.ToTable("WFStepsDiagram", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.WfedgeType)
                    .HasColumnName("WFEdgeType")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.WfparentStepId).HasColumnName("WFParentStepID");

                entity.Property(e => e.WfstepId).HasColumnName("WFStepID");

                entity.HasOne(d => d.Wfstep)
                    .WithMany(p => p.WfstepsDiagram)
                    .HasForeignKey(d => d.WfstepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WFStepsDiagram_WFSteps");
            });

            modelBuilder.Entity<WfstepsParameters>(entity =>
            {
                entity.ToTable("WFStepsParameters", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ParameterId).HasColumnName("ParameterID");

                entity.Property(e => e.WfstepId).HasColumnName("WFStepID");

                entity.HasOne(d => d.Wfstep)
                    .WithMany(p => p.WfstepsParameters)
                    .HasForeignKey(d => d.WfstepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WFStepsParameters_WFSteps");
            });

            modelBuilder.Entity<WfstepTemplates>(entity =>
            {
                entity.ToTable("WFStepTemplates", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TaskInfoSet).HasDefaultValueSql("((1))");

                entity.Property(e => e.TemplateType).HasDefaultValueSql("((1))");

                entity.Property(e => e.WfstepId).HasColumnName("WFStepID");

                entity.HasOne(d => d.Wfstep)
                    .WithMany(p => p.WfstepTemplates)
                    .HasForeignKey(d => d.WfstepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WFStepTemplates_WFSteps");
            });

            modelBuilder.Entity<WhiteLabelHosts>(entity =>
            {
                entity.ToTable("WhiteLabelHosts", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.HostType).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.WhiteLabelId).HasColumnName("WhiteLabelID");

                entity.HasOne(d => d.WhiteLabel)
                    .WithMany(p => p.WhiteLabelHosts)
                    .HasForeignKey(d => d.WhiteLabelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WhiteLabelHosts_WhiteLabels");
            });

            modelBuilder.Entity<WhiteLabelLinks>(entity =>
            {
                entity.ToTable("WhiteLabelLinks", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DisplayName).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Value).IsRequired();

                entity.Property(e => e.WhiteLabelId).HasColumnName("WhiteLabelID");

                entity.Property(e => e.WhitelabelHostId).HasColumnName("WhitelabelHostID");

                entity.HasOne(d => d.WhiteLabel)
                    .WithMany(p => p.WhiteLabelLinks)
                    .HasForeignKey(d => d.WhiteLabelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WhiteLabelLinks_WhiteLabels");

                entity.HasOne(d => d.WhitelabelHost)
                    .WithMany(p => p.WhiteLabelLinks)
                    .HasForeignKey(d => d.WhitelabelHostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WhiteLabelLinks_WhiteLabelHosts");
            });

            modelBuilder.Entity<WhiteLabels>(entity =>
            {
                entity.ToTable("WhiteLabels", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DefaultSalesPersonId).HasColumnName("DefaultSalesPersonID");

                entity.Property(e => e.PartnerClientId)
                    .HasColumnName("PartnerClientID")
                    .HasDefaultValueSql("((606))");
            });

            modelBuilder.Entity<WorkfFlow>(entity =>
            {
                entity.ToTable("WorkfFlow", "so");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .HasDefaultValueSql("((8))");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).IsRequired();
            });
        }
    }
}
