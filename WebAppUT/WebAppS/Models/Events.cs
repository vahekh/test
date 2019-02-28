using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class Events
    {
        public Events()
        {
            EventCourses = new HashSet<EventCourses>();
            EventInvitations = new HashSet<EventInvitations>();
            EventParticipants = new HashSet<EventParticipants>();
            EventProducts = new HashSet<EventProducts>();
            EventsAttachedFile = new HashSet<EventsAttachedFile>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string Speakers { get; set; }
        public string Description { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public DateTime? RegistrationFinishDate { get; set; }
        public int ParticipationMode { get; set; }
        public string InvitationPassword { get; set; }
        public bool IsSesameEventCoordinator { get; set; }
        public bool IsSeother { get; set; }
        public string OtherEmail { get; set; }
        public bool IsSectoParticipantIfCancelled { get; set; }
        public bool IsSectoManagerIfCancelled { get; set; }
        public bool IsSeconConfirmation { get; set; }
        public bool IsSeconRejection { get; set; }
        public bool IsSecreminder1WeekAhead { get; set; }
        public bool IsSecreminder3DaysAhead { get; set; }
        public bool IsSecreminder1DayAhead { get; set; }
        public bool IsSecwhenEventBegins { get; set; }
        public bool IsSecwhenEventFinishes { get; set; }
        public bool IsSeptoParticipantIfCancelled { get; set; }
        public bool IsSeptoManagerIfCancelled { get; set; }
        public bool IsSeponConfirmation { get; set; }
        public bool IsSeponRejection { get; set; }
        public bool IsSepreminder1WeekAhead { get; set; }
        public bool IsSepreminder3DaysAhead { get; set; }
        public bool IsSepreminder1DayAhead { get; set; }
        public bool IsSepwhenEventBegins { get; set; }
        public bool IsSepwhenEventFinishes { get; set; }
        public string EcfirstName { get; set; }
        public string EclastName { get; set; }
        public string Ecphone { get; set; }
        public string Ecemail { get; set; }
        public int ScoreType { get; set; }
        public string Percentage { get; set; }
        public string Note { get; set; }
        public bool IncludeGoogleMap { get; set; }
        public string WebSite { get; set; }
        public bool Finished { get; set; }
        public int? EventTypeId { get; set; }
        public string AttachFileType { get; set; }
        public string TimeZone { get; set; }
        public int? CertificationId { get; set; }
        public string Unit { get; set; }
        public string UnitType { get; set; }
        public bool IsCertificationEvent { get; set; }
        public bool IsSecpostEvent { get; set; }
        public bool IsSeppostEvent { get; set; }
        public bool AllowAllLocations { get; set; }
        public int MaximumParticipants { get; set; }
        public int NumberOfParticipantsRejected { get; set; }
        public bool? AllowTentativeParticipants { get; set; }
        public bool? IsCountMaybeParticipants { get; set; }
        public bool? IsWaitingList { get; set; }
        public bool? IsWaitingParticipantNotified { get; set; }
        public bool AllowAllDepartments { get; set; }
        public DateTime? RegistrationStartDate { get; set; }
        public DateTime? FinalizeDate { get; set; }
        public bool IzCoordinatorSameAsOwner { get; set; }
        public int? EventCreatorId { get; set; }
        public bool IsCoordinatorSameAsOwner { get; set; }
        public bool? IsActive { get; set; }
        public int? CancelledByClientId { get; set; }
        public int? CancelledByEmployeeId { get; set; }
        public DateTime? CancelledDateTime { get; set; }
        public string CancelledDescription { get; set; }
        public int NumberOfDeclinedWaitings { get; set; }
        public bool IsSeponAconfirmation { get; set; }
        public bool IsSeconAconfirmation { get; set; }
        public bool IsSeponTconfirmation { get; set; }
        public bool IsSeconTconfirmation { get; set; }
        public bool IsSepwaitingLadd { get; set; }
        public bool IsSecwaitingLadd { get; set; }
        public bool IsSecwaitingLdec { get; set; }
        public int? PercentageNew { get; set; }
        public int CourseType { get; set; }
        public int? CategoryId { get; set; }
        public int? CourseId { get; set; }
        public int? GroupId { get; set; }
        public bool? AllowAddToCalendar { get; set; }
        public decimal? ParticipationCost { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public int? LogoId { get; set; }
        public int? SubjectId { get; set; }
        public bool RequirePayment { get; set; }
        public DateTimeOffset DateUtc { get; set; }
        public bool SpeakerAsParticipant { get; set; }
        public double? CehourF { get; set; }

        public EventCertificates Certification { get; set; }
        public EventTypes EventType { get; set; }
        public EventsLogo Logo { get; set; }
        public Subject SubjectNavigation { get; set; }
        public ICollection<EventCourses> EventCourses { get; set; }
        public ICollection<EventInvitations> EventInvitations { get; set; }
        public ICollection<EventParticipants> EventParticipants { get; set; }
        public ICollection<EventProducts> EventProducts { get; set; }
        public ICollection<EventsAttachedFile> EventsAttachedFile { get; set; }
    }
}
