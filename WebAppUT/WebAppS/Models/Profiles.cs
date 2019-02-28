using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class Profiles
    {
        public Profiles()
        {
            ProfileHelpPages = new HashSet<ProfileHelpPages>();
            ProfileReports = new HashSet<ProfileReports>();
            SetTopProfiles = new HashSet<SetTopProfiles>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool AddEmployee { get; set; }
        public bool EditEmployee { get; set; }
        public bool DeleteEmployee { get; set; }
        public bool ChangeEmployeePassword { get; set; }
        public bool AddTrainingAvailable { get; set; }
        public bool EditTrainingAvailable { get; set; }
        public bool DeleteTrainingAvailable { get; set; }
        public bool PrintCertificates { get; set; }
        public bool PrintOwnCertificate { get; set; }
        public bool AddDepartment { get; set; }
        public bool EditDepartment { get; set; }
        public bool DeleteDepartment { get; set; }
        public bool EnterGroupTestResults { get; set; }
        public bool AddGroup { get; set; }
        public bool EditGroup { get; set; }
        public bool DeleteGroup { get; set; }
        public bool AddHelp { get; set; }
        public bool EditHelp { get; set; }
        public bool AddLocation { get; set; }
        public bool EditLocation { get; set; }
        public bool DeleteLocation { get; set; }
        public bool EnterPracticalExamResults { get; set; }
        public bool DeletePracticalExamNeededEmployee { get; set; }
        public bool PrintTraining { get; set; }
        public bool PrintQuiz { get; set; }
        public bool PrintQuizAnswers { get; set; }
        public bool RunReport { get; set; }
        public bool StartTraining { get; set; }
        public bool ContinueTraining { get; set; }
        public bool RetakeTraining { get; set; }
        public bool EditTrainingByGroup { get; set; }
        public bool EditTrainingByLocation { get; set; }
        public bool AssignTrainingForGroup { get; set; }
        public bool AssignTrainingForLocation { get; set; }
        public bool AssignTrainingForDepartment { get; set; }
        public bool AssignTrainingForClient { get; set; }
        public bool AddProfile { get; set; }
        public bool EditProfile { get; set; }
        public bool DeleteProfile { get; set; }
        public bool AssignProfile { get; set; }
        public bool ViewCertificates { get; set; }
        public bool ViewGroups { get; set; }
        public bool ViewLocations { get; set; }
        public bool ViewDepartments { get; set; }
        public bool AssignTrainingForEmployee { get; set; }
        public bool ManageVendors { get; set; }
        public bool LocationsToBeManaged { get; set; }
        public bool DepartmentsToBeManaged { get; set; }
        public bool GroupsToBeManaged { get; set; }
        public bool AllTrainingsAvailable { get; set; }
        public bool MangerForAllGroups { get; set; }
        public bool MangerForAllLocations { get; set; }
        public bool MangerForAllDepartments { get; set; }
        public bool SendEmail { get; set; }
        public bool AllowUserToSelectTrainingVersion { get; set; }
        public bool ManageAssignment { get; set; }
        public bool UserCanApproveTheirOwnAssignments { get; set; }
        public bool UserCanApproveOtherUserAssignments { get; set; }
        public bool GlobalSearch { get; set; }
        public bool AllowToViewLicenses { get; set; }
        public bool ModifyAccount { get; set; }
        public bool MakePurchases { get; set; }
        public bool ViewPurchases { get; set; }
        public bool ManageDocument { get; set; }
        public bool? ViewTrainingList { get; set; }
        public bool? ViewDocumentList { get; set; }
        public bool? ViewChecklist { get; set; }
        public bool ForceExpireTraining { get; set; }
        public bool? AllowUserToSelectTrainingMode { get; set; }
        public bool LoginNameIsEmailAddress { get; set; }
        public bool LimitUserOptions { get; set; }
        public bool ManageEvents { get; set; }
        public bool AllowUserToUseBetaVersion { get; set; }
        public bool AllowUserToUseSandbox { get; set; }
        public bool AllowTasksToBeReassignedToSomeoneElse { get; set; }
        public bool ManageEmailDistributionList { get; set; }
        public bool ManageEscalationTracking { get; set; }
        public bool AllowSkipToQuiz { get; set; }
        public bool ManageEmailTemplates { get; set; }
        public bool AllowAllEventsToBeViewed { get; set; }
        public bool AllowAllEventsToBeManaged { get; set; }
        public bool ViewEvents { get; set; }
        public bool AllowAllUsersToBeInvited { get; set; }
        public bool LimitUserToGroupMode { get; set; }
        public bool ViewUser { get; set; }
        public bool ManageCategories { get; set; }
        public bool AllowSyncofProductionDatatoSandbox { get; set; }
        public bool GroupModeUser { get; set; }
        public bool AllowAssignByUser { get; set; }
        public bool CompetencyLevel { get; set; }
        public bool ManageHelpPages { get; set; }
        public bool ManagerForAllDocuments { get; set; }
        public bool DocumentsToBeManaged { get; set; }
        public bool RegisterMultipleUsers { get; set; }
        public bool AllowDataExport { get; set; }
        public bool ViewBlankRoster { get; set; }
        public bool ViewSalesperson { get; set; }
        public bool ManageSalesperson { get; set; }
        public bool WhatsNew { get; set; }
        public bool ManageMsdsheet { get; set; }
        public int ClientId { get; set; }
        public int TypeId { get; set; }
        public bool ManageCrm { get; set; }
        public bool ManageFactSheet { get; set; }
        public bool ManageWorkflow { get; set; }
        public bool ViewWorkflow { get; set; }
        public bool AddEditExternalCourses { get; set; }
        public bool ViewExternalCourses { get; set; }
        public bool AddEditTraining { get; set; }
        public bool ViewTrainings { get; set; }
        public bool ManageSets { get; set; }
        public bool ManageSyllabus { get; set; }
        public bool ManageGroupAttributes { get; set; }
        public bool BillingProfile { get; set; }

        public SystemClients Client { get; set; }
        public ICollection<ProfileHelpPages> ProfileHelpPages { get; set; }
        public ICollection<ProfileReports> ProfileReports { get; set; }
        public ICollection<SetTopProfiles> SetTopProfiles { get; set; }
    }
}
