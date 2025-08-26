using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using OBAKPIWEBAPI.EF_Models;

namespace OBAKPIWEBAPI.Data;

public partial class AppraisalDbContext : DbContext
{
    public AppraisalDbContext()
    {
    }

    public AppraisalDbContext(DbContextOptions<AppraisalDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AiportTimeZone> AiportTimeZones { get; set; }

    public virtual DbSet<AirportCode> AirportCodes { get; set; }

    public virtual DbSet<AppError> AppErrors { get; set; }

    public virtual DbSet<AppLog> AppLogs { get; set; }

    public virtual DbSet<Appraisal> Appraisals { get; set; }

    public virtual DbSet<AppraisalQuestionAnswer> AppraisalQuestionAnswers { get; set; }

    public virtual DbSet<AppraisalSection> AppraisalSections { get; set; }

    public virtual DbSet<AppraisalSectionQuestion> AppraisalSectionQuestions { get; set; }

    public virtual DbSet<AppraisalTeamLead> AppraisalTeamLeads { get; set; }

    public virtual DbSet<BlockDeleteLog> BlockDeleteLogs { get; set; }

    public virtual DbSet<Bus> Buses { get; set; }

    public virtual DbSet<BusesAllocation> BusesAllocations { get; set; }

    public virtual DbSet<BusesDriver> BusesDrivers { get; set; }

    public virtual DbSet<CrewAccessIdAttachment> CrewAccessIdAttachments { get; set; }

    public virtual DbSet<CrewAppraisal> CrewAppraisals { get; set; }

    public virtual DbSet<CrewAppraisalEval> CrewAppraisalEvals { get; set; }

    public virtual DbSet<CrewAppreciation> CrewAppreciations { get; set; }

    public virtual DbSet<CrewCategory> CrewCategories { get; set; }

    public virtual DbSet<CrewCommendation> CrewCommendations { get; set; }

    public virtual DbSet<CrewDetail> CrewDetails { get; set; }

    public virtual DbSet<CrewDocumentApproverDetail> CrewDocumentApproverDetails { get; set; }

    public virtual DbSet<CrewDocumentCategory> CrewDocumentCategories { get; set; }

    public virtual DbSet<CrewDocumentStatusHistory> CrewDocumentStatusHistories { get; set; }

    public virtual DbSet<CrewEffectiveSeniority> CrewEffectiveSeniorities { get; set; }

    public virtual DbSet<CrewEffectiveSeniorityPeriod> CrewEffectiveSeniorityPeriods { get; set; }

    public virtual DbSet<CrewFlightForm> CrewFlightForms { get; set; }

    public virtual DbSet<CrewFlightFormAnswer> CrewFlightFormAnswers { get; set; }

    public virtual DbSet<CrewFlightFormSectionComment> CrewFlightFormSectionComments { get; set; }

    public virtual DbSet<CrewGrooming> CrewGroomings { get; set; }

    public virtual DbSet<CrewGroomingAttribute> CrewGroomingAttributes { get; set; }

    public virtual DbSet<CrewGroomingEyeColor> CrewGroomingEyeColors { get; set; }

    public virtual DbSet<CrewGroomingHairColor> CrewGroomingHairColors { get; set; }

    public virtual DbSet<CrewGroomingRemark> CrewGroomingRemarks { get; set; }

    public virtual DbSet<CrewGroomingWeightStatus> CrewGroomingWeightStatuses { get; set; }

    public virtual DbSet<CrewLeaveAnnouncement> CrewLeaveAnnouncements { get; set; }

    public virtual DbSet<CrewLeaveRequest> CrewLeaveRequests { get; set; }

    public virtual DbSet<CrewLeaveRosterPeriod> CrewLeaveRosterPeriods { get; set; }

    public virtual DbSet<CrewPhoto> CrewPhotos { get; set; }

    public virtual DbSet<CrewTeamAssignment> CrewTeamAssignments { get; set; }

    public virtual DbSet<CrewTransport> CrewTransports { get; set; }

    public virtual DbSet<CrewTransportCategory> CrewTransportCategories { get; set; }

    public virtual DbSet<CrewTransportRequest> CrewTransportRequests { get; set; }

    public virtual DbSet<CrewWarningLetter> CrewWarningLetters { get; set; }

    public virtual DbSet<CrewWeightDetailList> CrewWeightDetailLists { get; set; }

    public virtual DbSet<DepInfoSheet> DepInfoSheets { get; set; }

    public virtual DbSet<DocCategory> DocCategories { get; set; }

    public virtual DbSet<DocCrewLog> DocCrewLogs { get; set; }

    public virtual DbSet<DocFile> DocFiles { get; set; }

    public virtual DbSet<DocVersion> DocVersions { get; set; }

    public virtual DbSet<DocumentRejectReason> DocumentRejectReasons { get; set; }

    public virtual DbSet<DreversAccount> DreversAccounts { get; set; }

    public virtual DbSet<EmailSetting> EmailSettings { get; set; }

    public virtual DbSet<EvalSectionsComment> EvalSectionsComments { get; set; }

    public virtual DbSet<ExceptionLogTable> ExceptionLogTables { get; set; }

    public virtual DbSet<FamForm> FamForms { get; set; }

    public virtual DbSet<Fleet> Fleets { get; set; }

    public virtual DbSet<FleetCategory> FleetCategories { get; set; }

    public virtual DbSet<FlightForm> FlightForms { get; set; }

    public virtual DbSet<FlightFormSection> FlightFormSections { get; set; }

    public virtual DbSet<FlightFormSectionItem> FlightFormSectionItems { get; set; }

    public virtual DbSet<FlightMeal> FlightMeals { get; set; }

    public virtual DbSet<InactiveCrewList> InactiveCrewLists { get; set; }

    public virtual DbSet<InflightRestSheet> InflightRestSheets { get; set; }

    public virtual DbSet<LayoverBid> LayoverBids { get; set; }

    public virtual DbSet<LayoverCategory> LayoverCategories { get; set; }

    public virtual DbSet<LayoverPairing> LayoverPairings { get; set; }

    public virtual DbSet<MaximumBid> MaximumBids { get; set; }

    public virtual DbSet<MealsCount> MealsCounts { get; set; }

    public virtual DbSet<OcbAcPo> OcbAcPos { get; set; }

    public virtual DbSet<OcbAllocationScreen> OcbAllocationScreens { get; set; }

    public virtual DbSet<OcbBlock> OcbBlocks { get; set; }

    public virtual DbSet<OcbComment> OcbComments { get; set; }

    public virtual DbSet<OcbCrewPo> OcbCrewPos { get; set; }

    public virtual DbSet<OcbCrewPosHistory> OcbCrewPosHistories { get; set; }

    public virtual DbSet<OcbFlight> OcbFlights { get; set; }

    public virtual DbSet<OcbNotification> OcbNotifications { get; set; }

    public virtual DbSet<OcbUpcomingCrew> OcbUpcomingCrews { get; set; }

    public virtual DbSet<OtpFlightInfo> OtpFlightInfos { get; set; }

    public virtual DbSet<OtpFlightStatus> OtpFlightStatuses { get; set; }

    public virtual DbSet<OtpGatesdep> OtpGatesdeps { get; set; }

    public virtual DbSet<OtpPassengerDetail> OtpPassengerDetails { get; set; }

    public virtual DbSet<OutOfBase> OutOfBases { get; set; }

    public virtual DbSet<PairingCategory> PairingCategories { get; set; }

    public virtual DbSet<PickupDetail> PickupDetails { get; set; }

    public virtual DbSet<PilotCrewDetail> PilotCrewDetails { get; set; }

    public virtual DbSet<PilotCrewDocRejectReason> PilotCrewDocRejectReasons { get; set; }

    public virtual DbSet<PilotCrewDocument> PilotCrewDocuments { get; set; }

    public virtual DbSet<PilotCrewDocumentStatusHistory> PilotCrewDocumentStatusHistories { get; set; }

    public virtual DbSet<PilotDetail> PilotDetails { get; set; }

    public virtual DbSet<PotableWater> PotableWaters { get; set; }

    public virtual DbSet<PreBookedMeal> PreBookedMeals { get; set; }

    public virtual DbSet<PreFlightAnswer> PreFlightAnswers { get; set; }

    public virtual DbSet<PreFlightCategory> PreFlightCategories { get; set; }

    public virtual DbSet<PreFlightComment> PreFlightComments { get; set; }

    public virtual DbSet<PreFlightCrewTest> PreFlightCrewTests { get; set; }

    public virtual DbSet<PreFlightFailedComment> PreFlightFailedComments { get; set; }

    public virtual DbSet<PreFlightSetting> PreFlightSettings { get; set; }

    public virtual DbSet<PreFlightTestExlude> PreFlightTestExludes { get; set; }

    public virtual DbSet<PreFlightTestLog> PreFlightTestLogs { get; set; }

    public virtual DbSet<PreFlightTestQuestion> PreFlightTestQuestions { get; set; }

    public virtual DbSet<RosterDatum> RosterData { get; set; }

    public virtual DbSet<SeniorityPeriodDetail> SeniorityPeriodDetails { get; set; }

    public virtual DbSet<Setting> Settings { get; set; }

    public virtual DbSet<SharePointLog> SharePointLogs { get; set; }

    public virtual DbSet<SharePointLogsTable> SharePointLogsTables { get; set; }

    public virtual DbSet<SharepointFilePrefix> SharepointFilePrefixes { get; set; }

    public virtual DbSet<SpecialMeal> SpecialMeals { get; set; }

    public virtual DbSet<Ssr> Ssrs { get; set; }

    public virtual DbSet<SsrCount> SsrCounts { get; set; }

    public virtual DbSet<StationManager> StationManagers { get; set; }

    public virtual DbSet<TransportGroup> TransportGroups { get; set; }

    public virtual DbSet<VwRecency> VwRecencies { get; set; }

    public virtual DbSet<VwRecencySummary> VwRecencySummaries { get; set; }

    public virtual DbSet<WeightMinMaxSetting> WeightMinMaxSettings { get; set; }

    public virtual DbSet<WeightVarianceSetting> WeightVarianceSettings { get; set; }

    public virtual DbSet<Zone> Zones { get; set; }

    public virtual DbSet<ZoneArea> ZoneAreas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ebriefingdb.database.windows.net;Database=eBriefingDB;User ID=CSM;Password=Puzzle#888;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AiportTimeZone>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AiportTi__3214EC07C8AFC922");

            entity.Property(e => e.AirportCode)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AirportCode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AirportC__3214EC074C394D62");

            entity.Property(e => e.AirportName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AppError>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ApplicationName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Datetime)
                .HasColumnType("datetime")
                .HasColumnName("datetime");
            entity.Property(e => e.ErrorMessage).HasColumnType("text");
            entity.Property(e => e.FunctionName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LineNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PageName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StaffNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VersionNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AppLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AppLogs__3214EC07FD5D49BE");

            entity.Property(e => e.ActionDateTime).HasColumnType("datetime");
            entity.Property(e => e.ActionDesc).HasColumnType("text");
            entity.Property(e => e.ApplicationName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JobGuid)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Appraisal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Appraisa__3214EC07BC97A8DA");

            entity.Property(e => e.Guid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("guid");
            entity.Property(e => e.IsActive).HasColumnName("Is_Active");
            entity.Property(e => e.IsCrew).HasColumnName("Is_Crew");
            entity.Property(e => e.IsCsm).HasColumnName("Is_CSM");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.LastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("Last_Update");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AppraisalQuestionAnswer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Appraisa__3214EC0721395ED6");

            entity.Property(e => e.Answer).HasColumnType("text");
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.Guid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("guid");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.LastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("Last_Update");

            entity.HasOne(d => d.Question).WithMany(p => p.AppraisalQuestionAnswers)
                .HasForeignKey(d => d.QuestionId)
                .HasConstraintName("FK_AppraisalQuestionAnswers_AppraisalSectionQuestions");
        });

        modelBuilder.Entity<AppraisalSection>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Appraisa__3214EC070C3DCA07");

            entity.Property(e => e.Guid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("guid");
            entity.Property(e => e.IsCsm).HasColumnName("Is_Csm");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.LastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("Last_Update");
            entity.Property(e => e.Title)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Appraisal).WithMany(p => p.AppraisalSections)
                .HasForeignKey(d => d.AppraisalId)
                .HasConstraintName("FK_AppraisalSections_Appraisals");
        });

        modelBuilder.Entity<AppraisalSectionQuestion>(entity =>
        {
            entity.Property(e => e.Guid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("guid");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.LastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("Last_Update");
            entity.Property(e => e.Question)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.AppraisalSection).WithMany(p => p.AppraisalSectionQuestions)
                .HasForeignKey(d => d.AppraisalSectionId)
                .HasConstraintName("FK_AppraisalSectionQuestions_AppraisalSections");
        });

        modelBuilder.Entity<AppraisalTeamLead>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Appraisa__3214EC27D7A3269D");

            entity.ToTable("Appraisal_Team_Leads");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FullName).IsUnicode(false);
            entity.Property(e => e.StaffData).IsUnicode(false);
            entity.Property(e => e.StaffNumber).IsUnicode(false);
            entity.Property(e => e.TeamName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BlockDeleteLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BlockDel__3214EC07FA88FA50");

            entity.ToTable("BlockDeleteLog");

            entity.Property(e => e.BlockDate).HasColumnType("datetime");
            entity.Property(e => e.BlockNo).IsUnicode(false);
            entity.Property(e => e.DeleteIntervelSetting)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeleteTime).HasColumnType("datetime");
            entity.Property(e => e.StaffNumber).IsUnicode(false);
        });

        modelBuilder.Entity<Bus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Buses__3214EC07978709D4");

            entity.Property(e => e.BusCapacity).HasColumnName("Bus_Capacity");
            entity.Property(e => e.BusNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Bus_Number");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
        });

        modelBuilder.Entity<BusesAllocation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Buses_Al__3214EC072B94CCD2");

            entity.ToTable("Buses_Allocation");

            entity.Property(e => e.BusId).HasColumnName("Bus_Id");
            entity.Property(e => e.GroupId).HasColumnName("Group_Id");
            entity.Property(e => e.PickipDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Bus).WithMany(p => p.BusesAllocations)
                .HasForeignKey(d => d.BusId)
                .HasConstraintName("FK__Buses_All__Bus_I__42E1EEFE");

            entity.HasOne(d => d.Group).WithMany(p => p.BusesAllocations)
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("FK__Buses_All__Group__43D61337");
        });

        modelBuilder.Entity<BusesDriver>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Buses_Dr__3214EC074FFE036F");

            entity.ToTable("Buses_Drivers");

            entity.HasIndex(e => e.DriverId, "UQ__Buses_Dr__F4664EB84A2A89B5").IsUnique();

            entity.Property(e => e.BusId).HasColumnName("Bus_Id");
            entity.Property(e => e.DriverId).HasColumnName("Driver_Id");

            entity.HasOne(d => d.Bus).WithMany(p => p.BusesDrivers)
                .HasForeignKey(d => d.BusId)
                .HasConstraintName("FK__Buses_Dri__Bus_I__44CA3770");

            entity.HasOne(d => d.Driver).WithOne(p => p.BusesDriver)
                .HasForeignKey<BusesDriver>(d => d.DriverId)
                .HasConstraintName("FK__Buses_Dri__Drive__45BE5BA9");
        });

        modelBuilder.Entity<CrewAccessIdAttachment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CrewAcce__3214EC0741525D37");

            entity.Property(e => e.AttachmentPath).HasMaxLength(255);
            entity.Property(e => e.GeneratedAccessId)
                .IsUnicode(false)
                .HasColumnName("generatedAccessId");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.StaffNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SubmissionDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<CrewAppraisal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CrewAppr__3214EC078F806EE8");

            entity.Property(e => e.AppraiseeSignatureUrl)
                .IsUnicode(false)
                .HasColumnName("AppraiseeSignatureURL");
            entity.Property(e => e.AppraiserSignatureUrl)
                .IsUnicode(false)
                .HasColumnName("AppraiserSignatureURL");
            entity.Property(e => e.AppraiserStaffNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CrewComment)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.SubmittedDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Appraisal).WithMany(p => p.CrewAppraisals)
                .HasForeignKey(d => d.AppraisalId)
                .HasConstraintName("FK_CrewAppraisals_Appraisals");

            entity.HasOne(d => d.CrewPos).WithMany(p => p.CrewAppraisals)
                .HasForeignKey(d => d.CrewPosId)
                .HasConstraintName("FK_CrewAppraisals_OCB_CrewPos");
        });

        modelBuilder.Entity<CrewAppraisalEval>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CrewAppr__3214EC07440D9469");

            entity.Property(e => e.Comments).HasColumnType("text");
            entity.Property(e => e.Guid)
                .HasColumnType("text")
                .HasColumnName("guid");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.LastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("Last_Update");

            entity.HasOne(d => d.Answer).WithMany(p => p.CrewAppraisalEvals)
                .HasForeignKey(d => d.AnswerId)
                .HasConstraintName("FK_AnswerID");

            entity.HasOne(d => d.Section).WithMany(p => p.CrewAppraisalEvals)
                .HasForeignKey(d => d.SectionId)
                .HasConstraintName("FK_CrewAppraisalEval_AppraisalSections");
        });

        modelBuilder.Entity<CrewAppreciation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Crew_App__3214EC0706CA6C43");

            entity.ToTable("Crew_Appreciation");

            entity.Property(e => e.AppEntryDate).HasColumnType("datetime");
            entity.Property(e => e.AppEntryDesc).IsUnicode(false);
            entity.Property(e => e.AppEntrySubject).IsUnicode(false);
            entity.Property(e => e.AttachmentPath).IsUnicode(false);
            entity.Property(e => e.StaffName).IsUnicode(false);
            entity.Property(e => e.StaffNumber).IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .IsUnicode(false)
                .HasColumnName("Updated_By");
        });

        modelBuilder.Entity<CrewCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CrewCate__3214EC07E606E1BC");

            entity.ToTable("CrewCategory");

            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Guid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("guid");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.LastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("Last_Update");
        });

        modelBuilder.Entity<CrewCommendation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Crew_Com__3214EC07E5D442FB");

            entity.ToTable("Crew_Commendation");

            entity.Property(e => e.AttachmentPath).IsUnicode(false);
            entity.Property(e => e.CommEntryDate).HasColumnType("datetime");
            entity.Property(e => e.CommEntryDesc).IsUnicode(false);
            entity.Property(e => e.CommEntrySubject).IsUnicode(false);
            entity.Property(e => e.StaffName).IsUnicode(false);
            entity.Property(e => e.StaffNumber).IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .IsUnicode(false)
                .HasColumnName("Updated_By");
        });

        modelBuilder.Entity<CrewDetail>(entity =>
        {
            entity.HasKey(e => e.StaffNumber).HasName("PK__CrewDeta__F2BC669A9D3B9FB0");

            entity.ToTable("CrewDetail");

            entity.Property(e => e.StaffNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Address1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Address2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Address3)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lang1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lang2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lang3)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lang4)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PA");
            entity.Property(e => e.Sex)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CrewDocumentApproverDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CrewDocu__3214EC073D14F7B5");

            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.MailId)
                .IsUnicode(false)
                .HasColumnName("Mail_id");
            entity.Property(e => e.Name).IsUnicode(false);
        });

        modelBuilder.Entity<CrewDocumentCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CrewDocu__3214EC074035A592");

            entity.ToTable("CrewDocumentCategory");

            entity.Property(e => e.CategoryDescription).IsUnicode(false);
            entity.Property(e => e.CategoryName).IsUnicode(false);
            entity.Property(e => e.InsertedBy)
                .IsUnicode(false)
                .HasColumnName("Inserted_By");
            entity.Property(e => e.InsertionDt)
                .HasColumnType("datetime")
                .HasColumnName("Insertion_DT");
            entity.Property(e => e.UpdatedBy)
                .IsUnicode(false)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDt)
                .HasColumnType("datetime")
                .HasColumnName("Updated_DT");
        });

        modelBuilder.Entity<CrewDocumentStatusHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CrewDocu__3214EC072DEBB461");

            entity.ToTable("CrewDocumentStatusHistory");

            entity.Property(e => e.AttachmentPath)
                .IsUnicode(false)
                .HasColumnName("Attachment_Path");
            entity.Property(e => e.ChangeDt)
                .HasColumnType("datetime")
                .HasColumnName("Change_DT");
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.DocumentId).HasColumnName("Document_Id");
            entity.Property(e => e.StaffNumber).IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.HasOne(d => d.Document).WithMany(p => p.CrewDocumentStatusHistories)
                .HasForeignKey(d => d.DocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CrewDocum__Docum__06B7F65E");
        });

        modelBuilder.Entity<CrewEffectiveSeniority>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CrewEffe__3214EC277E789616");

            entity.ToTable("CrewEffectiveSeniority");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CrewId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fleet)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Crew).WithMany(p => p.CrewEffectiveSeniorities)
                .HasForeignKey(d => d.CrewId)
                .HasConstraintName("FK__CrewEffec__CrewI__1940BAED");
        });

        modelBuilder.Entity<CrewEffectiveSeniorityPeriod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CrewEffe__3214EC27F0912BE7");

            entity.ToTable("CrewEffectiveSeniorityPeriod");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cesid).HasColumnName("CESID");

            entity.HasOne(d => d.Ces).WithMany(p => p.CrewEffectiveSeniorityPeriods)
                .HasForeignKey(d => d.Cesid)
                .HasConstraintName("FK__CrewEffec__IsDel__00750D23");

            entity.HasOne(d => d.Period).WithMany(p => p.CrewEffectiveSeniorityPeriods)
                .HasForeignKey(d => d.PeriodId)
                .HasConstraintName("FK__CrewEffec__Perio__0169315C");
        });

        modelBuilder.Entity<CrewFlightForm>(entity =>
        {
            entity.Property(e => e.FlightFormId).HasColumnName("Flight_Form_Id");
            entity.Property(e => e.FlightId).HasColumnName("Flight_Id");
            entity.Property(e => e.StaffNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubmitDateAndTime)
                .HasColumnType("datetime")
                .HasColumnName("Submit_Date_and_Time");

            entity.HasOne(d => d.FlightForm).WithMany(p => p.CrewFlightForms)
                .HasForeignKey(d => d.FlightFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CrewFlightForms_FlightForms");

            entity.HasOne(d => d.Flight).WithMany(p => p.CrewFlightForms)
                .HasForeignKey(d => d.FlightId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CrewFlightForms_OCB_Flights");
        });

        modelBuilder.Entity<CrewFlightFormAnswer>(entity =>
        {
            entity.Property(e => e.Answer).HasMaxLength(100);
            entity.Property(e => e.CrewFlightFormId).HasColumnName("Crew_Flight_Form_Id");
            entity.Property(e => e.FlightFormSectionItemId).HasColumnName("Flight_Form_Section_Item_Id");

            entity.HasOne(d => d.CrewFlightForm).WithMany(p => p.CrewFlightFormAnswers)
                .HasForeignKey(d => d.CrewFlightFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CrewFlightFormAnswers_CrewFlightForms");

            entity.HasOne(d => d.FlightFormSectionItem).WithMany(p => p.CrewFlightFormAnswers)
                .HasForeignKey(d => d.FlightFormSectionItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CrewFlightFormAnswers_FlightFormSectionItems");
        });

        modelBuilder.Entity<CrewFlightFormSectionComment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CrewFlig__3214EC079C67A3C6");

            entity.Property(e => e.Comments).HasColumnType("text");
            entity.Property(e => e.CrewFlightFormId).HasColumnName("Crew_Flight_Form_Id");
            entity.Property(e => e.FlightFormSectionId).HasColumnName("Flight_Form_Section_Id");

            entity.HasOne(d => d.CrewFlightForm).WithMany(p => p.CrewFlightFormSectionComments)
                .HasForeignKey(d => d.CrewFlightFormId)
                .HasConstraintName("FK_CrewFlightFormSectionComments_CrewFlightForms");

            entity.HasOne(d => d.FlightFormSection).WithMany(p => p.CrewFlightFormSectionComments)
                .HasForeignKey(d => d.FlightFormSectionId)
                .HasConstraintName("FK_CrewFlightFormSectionComments_FlightFormSections");
        });

        modelBuilder.Entity<CrewGrooming>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Crew_Gro__3214EC07A45CFC83");

            entity.ToTable("Crew_Grooming");

            entity.Property(e => e.EyeColorCd).HasColumnName("Eye_Color_Cd");
            entity.Property(e => e.HairColorCd).HasColumnName("Hair_Color_Cd");
            entity.Property(e => e.Height).HasColumnType("decimal(4, 2)");
            entity.Property(e => e.MaximumWeight)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("Maximum_Weight");
            entity.Property(e => e.MinimumWeight)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("Minimum_Weight");
            entity.Property(e => e.Remarks).IsUnicode(false);
            entity.Property(e => e.StaffNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status).IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .IsUnicode(false)
                .HasColumnName("Updated_By");
            entity.Property(e => e.Weight).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.WeightEntryDate)
                .HasColumnType("datetime")
                .HasColumnName("Weight_Entry_Date");
            entity.Property(e => e.WeightStatusId).HasColumnName("Weight_Status_Id");

            entity.HasOne(d => d.EyeColorCdNavigation).WithMany(p => p.CrewGroomings)
                .HasForeignKey(d => d.EyeColorCd)
                .HasConstraintName("FK__Crew_Groo__Eye_C__3B95D2F1");

            entity.HasOne(d => d.HairColorCdNavigation).WithMany(p => p.CrewGroomings)
                .HasForeignKey(d => d.HairColorCd)
                .HasConstraintName("FK__Crew_Groo__Hair___3AA1AEB8");

            entity.HasOne(d => d.StaffNumberNavigation).WithMany(p => p.CrewGroomings)
                .HasForeignKey(d => d.StaffNumber)
                .HasConstraintName("FK__Crew_Groo__Staff__39AD8A7F");

            entity.HasOne(d => d.WeightStatus).WithMany(p => p.CrewGroomings)
                .HasForeignKey(d => d.WeightStatusId)
                .HasConstraintName("FK__Crew_Groo__Weigh__3C89F72A");
        });

        modelBuilder.Entity<CrewGroomingAttribute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CrewGroo__3214EC07C3200CB8");

            entity.Property(e => e.EmployeeName)
                .IsUnicode(false)
                .HasColumnName("Employee_Name");
            entity.Property(e => e.EmployeeNumber)
                .IsUnicode(false)
                .HasColumnName("Employee_Number");
            entity.Property(e => e.EyeColor)
                .IsUnicode(false)
                .HasColumnName("Eye_Color");
            entity.Property(e => e.EyeColorCd).HasColumnName("Eye_Color_Cd");
            entity.Property(e => e.Gender).IsUnicode(false);
            entity.Property(e => e.HairColor)
                .IsUnicode(false)
                .HasColumnName("Hair_Color");
            entity.Property(e => e.HairColorCd).HasColumnName("Hair_Color_Cd");
            entity.Property(e => e.Height).HasColumnType("decimal(4, 2)");
            entity.Property(e => e.Nationality).IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .IsUnicode(false)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Date");
        });

        modelBuilder.Entity<CrewGroomingEyeColor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Crew_Gro__3214EC275D72332F");

            entity.ToTable("Crew_Grooming_EyeColor");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EyeClr)
                .IsUnicode(false)
                .HasColumnName("Eye_Clr");
        });

        modelBuilder.Entity<CrewGroomingHairColor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Crew_Gro__3214EC275A5B5B68");

            entity.ToTable("Crew_Grooming_HairColor");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.HairClr)
                .IsUnicode(false)
                .HasColumnName("Hair_Clr");
        });

        modelBuilder.Entity<CrewGroomingRemark>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CrewGroo__3214EC079EB80D96");

            entity.Property(e => e.CreatedBy).IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.StaffNo).IsUnicode(false);
        });

        modelBuilder.Entity<CrewGroomingWeightStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Crew_Gro__3214EC274168A455");

            entity.ToTable("Crew_Grooming_WeightStatus");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.WeightStatus)
                .IsUnicode(false)
                .HasColumnName("Weight_Status");
        });

        modelBuilder.Entity<CrewLeaveAnnouncement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CrewLeav__3214EC07A3BA6B52");

            entity.Property(e => e.Announcement).IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .IsUnicode(false)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDt)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Dt");
        });

        modelBuilder.Entity<CrewLeaveRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CrewLeav__3214EC072248F000");

            entity.Property(e => e.AdminReason)
                .IsUnicode(false)
                .HasColumnName("ADMIN_REASON");
            entity.Property(e => e.FromDate)
                .HasColumnType("datetime")
                .HasColumnName("FROM_DATE");
            entity.Property(e => e.LeaveReason)
                .IsUnicode(false)
                .HasColumnName("LEAVE_REASON");
            entity.Property(e => e.StaffNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.SubmittedTime)
                .HasColumnType("datetime")
                .HasColumnName("SUBMITTED_TIME");
            entity.Property(e => e.ToDate)
                .HasColumnType("datetime")
                .HasColumnName("TO_DATE");
            entity.Property(e => e.UpdatedBy)
                .IsUnicode(false)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDt)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Dt");

            entity.HasOne(d => d.StaffNumberNavigation).WithMany(p => p.CrewLeaveRequests)
                .HasForeignKey(d => d.StaffNumber)
                .HasConstraintName("FK__CrewLeaveRequests__PilotCrewDetail");
        });

        modelBuilder.Entity<CrewLeaveRosterPeriod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CrewLeav__3214EC0720A539AD");

            entity.ToTable("CrewLeaveRosterPeriod");

            entity.Property(e => e.FromDate)
                .HasColumnType("datetime")
                .HasColumnName("FROM_DATE");
            entity.Property(e => e.ToDate)
                .HasColumnType("datetime")
                .HasColumnName("TO_DATE");
            entity.Property(e => e.UpdatedBy)
                .IsUnicode(false)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDt)
                .HasColumnType("datetime")
                .HasColumnName("Updated_DT");
        });

        modelBuilder.Entity<CrewPhoto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CrewPhot__3214EC0710AE7E11");

            entity.Property(e => e.AttachmentPath).IsUnicode(false);
            entity.Property(e => e.StaffNumber).IsUnicode(false);
        });

        modelBuilder.Entity<CrewTeamAssignment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CrewTeam__3214EC0758A9B490");

            entity.ToTable("CrewTeamAssignment");

            entity.Property(e => e.StaffNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .IsUnicode(false)
                .HasColumnName("Updated_By");

            entity.HasOne(d => d.StaffNumberNavigation).WithMany(p => p.CrewTeamAssignments)
                .HasForeignKey(d => d.StaffNumber)
                .HasConstraintName("FK__CrewTeamA__Staff__32CB82C6");

            entity.HasOne(d => d.Team).WithMany(p => p.CrewTeamAssignments)
                .HasForeignKey(d => d.TeamId)
                .HasConstraintName("FK__CrewTeamA__TeamI__33BFA6FF");
        });

        modelBuilder.Entity<CrewTransport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Crew_Tra__3214EC07C66FBC12");

            entity.ToTable("Crew_Transports");

            entity.Property(e => e.BusId).HasColumnName("Bus_Id");
            entity.Property(e => e.StaffNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ZoneId).HasColumnName("Zone_Id");

            entity.HasOne(d => d.Bus).WithMany(p => p.CrewTransports)
                .HasForeignKey(d => d.BusId)
                .HasConstraintName("FK__Crew_Tran__Bus_I__46B27FE2");

            entity.HasOne(d => d.StaffNumberNavigation).WithMany(p => p.CrewTransports)
                .HasForeignKey(d => d.StaffNumber)
                .HasConstraintName("FK__Crew_Tran__Staff__47A6A41B");

            entity.HasOne(d => d.Zone).WithMany(p => p.CrewTransports)
                .HasForeignKey(d => d.ZoneId)
                .HasConstraintName("FK__Crew_Tran__Zone___489AC854");
        });

        modelBuilder.Entity<CrewTransportCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CrewTran__3214EC071BE0955C");

            entity.ToTable("CrewTransportCategory");

            entity.Property(e => e.Category).IsUnicode(false);
            entity.Property(e => e.CategoryDesc)
                .IsUnicode(false)
                .HasColumnName("Category_Desc");
            entity.Property(e => e.IsActive).HasColumnName("Is_active");
            entity.Property(e => e.IsDeleted).HasColumnName("Is_deleted");
        });

        modelBuilder.Entity<CrewTransportRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CrewTran__3214EC0743DF3770");

            entity.ToTable("CrewTransportRequest");

            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.FlightDateTime).HasColumnType("datetime");
            entity.Property(e => e.FlightDetails).IsUnicode(false);
            entity.Property(e => e.FromAddress).IsUnicode(false);
            entity.Property(e => e.IsDeleted).HasColumnName("Is_deleted");
            entity.Property(e => e.StaffNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Time).HasColumnType("datetime");
            entity.Property(e => e.ToAddress).IsUnicode(false);

            entity.HasOne(d => d.StaffNumberNavigation).WithMany(p => p.CrewTransportRequests)
                .HasForeignKey(d => d.StaffNumber)
                .HasConstraintName("FK_CrewTransportRequest_PilotCrewDetail");

            entity.HasOne(d => d.TransportTypeNavigation).WithMany(p => p.CrewTransportRequests)
                .HasForeignKey(d => d.TransportType)
                .HasConstraintName("FK__CrewTrans__Trans__297722B6");
        });

        modelBuilder.Entity<CrewWarningLetter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Crew_War__3214EC075A81740E");

            entity.ToTable("Crew_WarningLetter");

            entity.Property(e => e.AttachmentPath).IsUnicode(false);
            entity.Property(e => e.ReportedBy)
                .IsUnicode(false)
                .HasColumnName("Reported_By");
            entity.Property(e => e.StaffName).IsUnicode(false);
            entity.Property(e => e.StaffNumber).IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .IsUnicode(false)
                .HasColumnName("Updated_By");
            entity.Property(e => e.WarnEntryDate).HasColumnType("datetime");
            entity.Property(e => e.WarnEntryDesc).IsUnicode(false);
            entity.Property(e => e.WarnEntrySubject).IsUnicode(false);
            entity.Property(e => e.WarnEntryType).IsUnicode(false);
        });

        modelBuilder.Entity<CrewWeightDetailList>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CrewWeig__3214EC0778389262");

            entity.ToTable("CrewWeightDetailList");

            entity.Property(e => e.DateFrom)
                .HasColumnType("datetime")
                .HasColumnName("Date_From");
            entity.Property(e => e.DateTo)
                .HasColumnType("datetime")
                .HasColumnName("Date_To");
            entity.Property(e => e.DateWeight)
                .HasColumnType("datetime")
                .HasColumnName("Date_Weight");
            entity.Property(e => e.EmployeeName)
                .IsUnicode(false)
                .HasColumnName("Employee_Name");
            entity.Property(e => e.EmployeeNumber)
                .IsUnicode(false)
                .HasColumnName("Employee_Number");
            entity.Property(e => e.GainLoss)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("Gain_Loss");
            entity.Property(e => e.IsDeleted).HasColumnName("Is_Deleted");
            entity.Property(e => e.Remarks).IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .IsUnicode(false)
                .HasColumnName("Updated_By");
            entity.Property(e => e.Weight).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.WeightStatusId).HasColumnName("Weight_Status_Id");

            entity.HasOne(d => d.WeightStatus).WithMany(p => p.CrewWeightDetailLists)
                .HasForeignKey(d => d.WeightStatusId)
                .HasConstraintName("FK__CrewWeigh__Weigh__40257DE4");
        });

        modelBuilder.Entity<DepInfoSheet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DepInfoS__3214EC07D4B29B43");

            entity.ToTable("DepInfoSheet");

            entity.Property(e => e.AdditionalComments).IsUnicode(false);
            entity.Property(e => e.Blnd).HasColumnName("BLND");
            entity.Property(e => e.BoardingDateTime)
                .HasColumnType("datetime")
                .HasColumnName("Boarding_DateTime");
            entity.Property(e => e.BoardingRemarks)
                .IsUnicode(false)
                .HasColumnName("Boarding_Remarks");
            entity.Property(e => e.BookedLoadJ).HasColumnName("Booked_Load_J");
            entity.Property(e => e.BookedLoadY).HasColumnName("Booked_Load_Y");
            entity.Property(e => e.CCrewBoardedDateTime)
                .HasColumnType("datetime")
                .HasColumnName("C_Crew_Boarded_DateTime");
            entity.Property(e => e.CCrewBoardedRemarks)
                .IsUnicode(false)
                .HasColumnName("C_Crew_Boarded_Remarks");
            entity.Property(e => e.CabinBaggageCompliant).HasColumnName("Cabin_Baggage_Compliant");
            entity.Property(e => e.CabinBaggageCompliantRemarks)
                .IsUnicode(false)
                .HasColumnName("Cabin_Baggage_Compliant_Remarks");
            entity.Property(e => e.CabinBaggageLabeled).HasColumnName("Cabin_Baggage_Labeled");
            entity.Property(e => e.CabinBaggageLabeledRemarks)
                .IsUnicode(false)
                .HasColumnName("Cabin_Baggage_Labeled_Remarks");
            entity.Property(e => e.CateredLoadJ).HasColumnName("Catered_Load_J");
            entity.Property(e => e.CateredLoadY).HasColumnName("Catered_Load_Y");
            entity.Property(e => e.CatererOffDateTime)
                .HasColumnType("datetime")
                .HasColumnName("Caterer_Off_DateTime");
            entity.Property(e => e.CatererOnDateTime)
                .HasColumnType("datetime")
                .HasColumnName("Caterer_On_DateTime");
            entity.Property(e => e.CatererRemarks)
                .IsUnicode(false)
                .HasColumnName("Caterer_Remarks");
            entity.Property(e => e.CleanersOffDateTime)
                .HasColumnType("datetime")
                .HasColumnName("Cleaners_Off_DateTime");
            entity.Property(e => e.CleanersOnDateTime)
                .HasColumnType("datetime")
                .HasColumnName("Cleaners_On_DateTime");
            entity.Property(e => e.CleanersRemarks)
                .IsUnicode(false)
                .HasColumnName("Cleaners_Remarks");
            entity.Property(e => e.CsmSign).HasColumnName("Csm_Sign");
            entity.Property(e => e.Deaf).HasColumnName("DEAF");
            entity.Property(e => e.Depa).HasColumnName("DEPA");
            entity.Property(e => e.Depu).HasColumnName("DEPU");
            entity.Property(e => e.DoorsClosedDateTime)
                .HasColumnType("datetime")
                .HasColumnName("Doors_Closed_DateTime");
            entity.Property(e => e.DoorsClosedRemarks)
                .IsUnicode(false)
                .HasColumnName("Doors_Closed_Remarks");
            entity.Property(e => e.FDBoardDateTime)
                .HasColumnType("datetime")
                .HasColumnName("F_D_Board_DateTime");
            entity.Property(e => e.FDBoardRemarks)
                .IsUnicode(false)
                .HasColumnName("F_D_Board_Remarks");
            entity.Property(e => e.FinalLoadJ).HasColumnName("Final_Load_J");
            entity.Property(e => e.FinalLoadY).HasColumnName("Final_Load_Y");
            entity.Property(e => e.FirstPassengerBoardedDateTime)
                .HasColumnType("datetime")
                .HasColumnName("First_Passenger_Boarded_DateTime");
            entity.Property(e => e.FirstPassengerBoardedRemarks)
                .IsUnicode(false)
                .HasColumnName("First_Passenger_Boarded_Remarks");
            entity.Property(e => e.GenDec).HasColumnName("GEN_DEC");
            entity.Property(e => e.GenDecRemarks)
                .IsUnicode(false)
                .HasColumnName("GEN_DEC_Remarks");
            entity.Property(e => e.GroundStaffcomments).HasColumnName("Ground_staffcomments");
            entity.Property(e => e.GroundStaffname)
                .IsUnicode(false)
                .HasColumnName("Ground_staffname");
            entity.Property(e => e.GroundStaffnum)
                .IsUnicode(false)
                .HasColumnName("Ground_staffnum");
            entity.Property(e => e.GroundStaffsign).HasColumnName("Ground_staffsign");
            entity.Property(e => e.GsimageUrl).IsUnicode(false);
            entity.Property(e => e.Inad).HasColumnName("INAD");
            entity.Property(e => e.LandingCardsProvided).HasColumnName("Landing_Cards_Provided");
            entity.Property(e => e.LandingCardsProvidedRemarks)
                .IsUnicode(false)
                .HasColumnName("Landing_Cards_Provided_Remarks");
            entity.Property(e => e.LastPassengerBoardedDateTime)
                .HasColumnType("datetime")
                .HasColumnName("Last_Passenger_Boarded_DateTime");
            entity.Property(e => e.LastPassengerBoardedRemarks)
                .IsUnicode(false)
                .HasColumnName("Last_Passenger_Boarded_Remarks");
            entity.Property(e => e.Maas).HasColumnName("MAAS");
            entity.Property(e => e.Meda).HasColumnName("MEDA");
            entity.Property(e => e.Other).HasColumnName("OTHER");
            entity.Property(e => e.PilProvided).HasColumnName("PIL_Provided");
            entity.Property(e => e.PilProvidedRemarks)
                .IsUnicode(false)
                .HasColumnName("PIL_Provided_Remarks");
            entity.Property(e => e.ShipsPapersOnBoard).HasColumnName("Ships_Papers_On_Board");
            entity.Property(e => e.ShipsPapersOnBoardRemarks)
                .IsUnicode(false)
                .HasColumnName("Ships_Papers_On_Board_Remarks");
            entity.Property(e => e.SpecialAssistance).HasColumnName("Special_Assistance");
            entity.Property(e => e.SpecialAssistanceRemarks)
                .IsUnicode(false)
                .HasColumnName("Special_Assistance_Remarks");
            entity.Property(e => e.Stcr).HasColumnName("STCR");
            entity.Property(e => e.Umnr).HasColumnName("UMNR");
            entity.Property(e => e.VipCip).HasColumnName("VIP_CIP");
            entity.Property(e => e.VipCipRemarks)
                .IsUnicode(false)
                .HasColumnName("VIP_CIP_Remarks");
            entity.Property(e => e.Wchc).HasColumnName("WCHC");
            entity.Property(e => e.Wchr).HasColumnName("WCHR");
            entity.Property(e => e.Wchs).HasColumnName("WCHS");

            entity.HasOne(d => d.Flight).WithMany(p => p.DepInfoSheets)
                .HasForeignKey(d => d.FlightId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DepInfoSheet_OCB_Flights");
        });

        modelBuilder.Entity<DocCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Doc_Cate__3214EC07D2FBF6CD");

            entity.ToTable("Doc_Category");

            entity.Property(e => e.FolderName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Title).IsUnicode(false);
        });

        modelBuilder.Entity<DocCrewLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Doc_Crew__3214EC07CDAC4A10");

            entity.ToTable("Doc_Crew_Log");

            entity.Property(e => e.AcknowledgementDateTime).HasColumnType("datetime");
            entity.Property(e => e.StaffNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DocFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Doc_File__3214EC07A39B715D");

            entity.ToTable("Doc_Files");

            entity.Property(e => e.DocUrl)
                .HasColumnType("text")
                .HasColumnName("Doc_Url");
            entity.Property(e => e.IsActive).HasColumnName("Is_Active");
            entity.Property(e => e.Title).IsUnicode(false);
            entity.Property(e => e.Version)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DocVersion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Doc_Vers__3214EC0746877ECB");

            entity.ToTable("Doc_Versions");

            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.RevFlightCrew).HasColumnType("datetime");
        });

        modelBuilder.Entity<DocumentRejectReason>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Document__3214EC071CAE906F");

            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
        });

        modelBuilder.Entity<DreversAccount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DreversA__3214EC0792EF806F");

            entity.ToTable("DreversAccount");

            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IsActive).HasColumnName("Is_Active");
            entity.Property(e => e.Password)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Salt)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("salt");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EmailSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EmailSet__3214EC07123587B0");

            entity.Property(e => e.EmailFrom)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmailFromPass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmailUsername)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Smtpport)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SMTPPort");
            entity.Property(e => e.Smtpserver)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SMTPServer");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EvalSectionsComment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EvalSect__3214EC07A69F2E4A");

            entity.ToTable("EvalSectionsComment");

            entity.Property(e => e.Comment).HasColumnType("text");
            entity.Property(e => e.Guid)
                .HasColumnType("text")
                .HasColumnName("guid");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.LastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("Last_Update");
        });

        modelBuilder.Entity<ExceptionLogTable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Exceptio__3214EC075E0231E8");

            entity.ToTable("Exception_Log_Table");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ExceptionThrown).HasColumnName("exceptionThrown");
            entity.Property(e => e.RunTimeDt).HasColumnName("RunTime_DT");
        });

        modelBuilder.Entity<FamForm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC0788B2E265");

            entity.ToTable("FAM_Form");

            entity.Property(e => e.AfterLanding).HasColumnName("after_Landing");
            entity.Property(e => e.CSmComments)
                .HasColumnType("text")
                .HasColumnName("cSM_Comments");
            entity.Property(e => e.CrewPosId).HasColumnName("Crew_Pos_Id");
            entity.Property(e => e.Cruise).HasColumnName("cruise");
            entity.Property(e => e.DepartureFromAc).HasColumnName("departure_From_AC");
            entity.Property(e => e.Desent).HasColumnName("desent");
            entity.Property(e => e.DoorArming).HasColumnName("door_Arming");
            entity.Property(e => e.DoorDisarming).HasColumnName("door_Disarming");
            entity.Property(e => e.DoorOpening).HasColumnName("door_Opening");
            entity.Property(e => e.DoorWarning).HasColumnName("door_Warning");
            entity.Property(e => e.ExitSeatsBriefingCheck).HasColumnName("exit_Seats_Briefing_Check");
            entity.Property(e => e.FlightId).HasColumnName("Flight_Id");
            entity.Property(e => e.LavatoryCruise).HasColumnName("lavatory_Cruise");
            entity.Property(e => e.LegalDocValidity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Legal_Doc_Validity");
            entity.Property(e => e.PassengerBoardingCheck).HasColumnName("passenger_Boarding_Check");
            entity.Property(e => e.PreFlightCheck).HasColumnName("pre_Flight_Check");
            entity.Property(e => e.PrePassengerBoardingCheck).HasColumnName("pre_Passenger_Boarding_Check");
            entity.Property(e => e.PreTakeOff).HasColumnName("pre_Take_Off");
            entity.Property(e => e.PreTaxi).HasColumnName("pre_Taxi");
            entity.Property(e => e.Rating)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SNyComments)
                .HasColumnType("text")
                .HasColumnName("sNY_Comments");
            entity.Property(e => e.StaffNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Staff_Number");
            entity.Property(e => e.TerminatingFlights).HasColumnName("terminating_Flights");

            entity.HasOne(d => d.CrewPos).WithMany(p => p.FamForms)
                .HasForeignKey(d => d.CrewPosId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAM_Form_OCB_CrewPos");

            entity.HasOne(d => d.Flight).WithMany(p => p.FamForms)
                .HasForeignKey(d => d.FlightId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FAM_Form_OCB_Flights");
        });

        modelBuilder.Entity<Fleet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Fleets__3214EC07FB58D9F4");

            entity.Property(e => e.Fleet1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Fleet");
        });

        modelBuilder.Entity<FleetCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Fleet_Ca__3214EC27EAF36BBF");

            entity.ToTable("Fleet_Category");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Fleet).IsUnicode(false);
        });

        modelBuilder.Entity<FlightForm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_FlightForm");

            entity.Property(e => e.FormName)
                .HasMaxLength(100)
                .HasColumnName("Form_Name");
        });

        modelBuilder.Entity<FlightFormSection>(entity =>
        {
            entity.Property(e => e.FlightFormId).HasColumnName("Flight_Form_Id");
            entity.Property(e => e.SectionTitle).HasMaxLength(100);

            entity.HasOne(d => d.FlightForm).WithMany(p => p.FlightFormSections)
                .HasForeignKey(d => d.FlightFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FlightForm_FlightFormSections");
        });

        modelBuilder.Entity<FlightFormSectionItem>(entity =>
        {
            entity.Property(e => e.FlightFormSectionId).HasColumnName("Flight_Form_Section_Id");

            entity.HasOne(d => d.FlightFormSection).WithMany(p => p.FlightFormSectionItems)
                .HasForeignKey(d => d.FlightFormSectionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FlightFormSectionItems_FlightFormSections");
        });

        modelBuilder.Entity<FlightMeal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FlightMe__3214EC07A56ED609");

            entity.Property(e => e.AircraftType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Aircraft_Type");
            entity.Property(e => e.Arrival)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Class)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departure)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Equipment)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Guid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("guid");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.LastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("Last_Update");
            entity.Property(e => e.MealCount)
                .HasDefaultValue(0)
                .HasColumnName("Meal_Count");

            entity.HasOne(d => d.Flight).WithMany(p => p.FlightMeals)
                .HasForeignKey(d => d.FlightId)
                .HasConstraintName("FK_FlightMeals_OCB_Flights");
        });

        modelBuilder.Entity<InactiveCrewList>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Inactive__3214EC0708411C95");

            entity.ToTable("InactiveCrewList");

            entity.Property(e => e.StaffNumber).IsUnicode(false);
        });

        modelBuilder.Entity<InflightRestSheet>(entity =>
        {
            entity.ToTable("InflightRestSheet");

            entity.Property(e => e.EndTime).HasColumnType("datetime");
            entity.Property(e => e.Location)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RestingStaff)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.StartTime).HasColumnType("datetime");
            entity.Property(e => e.TakingOverStaff)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TotalTime)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LayoverBid>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Layover___3214EC27395627DD");

            entity.ToTable("Layover_Bids");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CatId).HasColumnName("CAT_ID");
            entity.Property(e => e.CmBidlimit)
                .IsUnicode(false)
                .HasColumnName("CM_BIDLIMIT");
            entity.Property(e => e.CsBidlimit)
                .IsUnicode(false)
                .HasColumnName("CS_BIDLIMIT");
            entity.Property(e => e.FcAirbusBidlimit)
                .IsUnicode(false)
                .HasColumnName("FC_AIRBUS_BIDLIMIT");
            entity.Property(e => e.FcBoingBidlimit)
                .IsUnicode(false)
                .HasColumnName("FC_BOING_BIDLIMIT");
            entity.Property(e => e.FgFaBidlimit)
                .IsUnicode(false)
                .HasColumnName("FG_FA_BIDLIMIT");
            entity.Property(e => e.StnId).HasColumnName("STN_ID");

            entity.HasOne(d => d.Cat).WithMany(p => p.LayoverBids)
                .HasForeignKey(d => d.CatId)
                .HasConstraintName("FK__Layover_B__IsDel__08162EEB");

            entity.HasOne(d => d.Stn).WithMany(p => p.LayoverBids)
                .HasForeignKey(d => d.StnId)
                .HasConstraintName("FK__Layover_B__STN_I__090A5324");
        });

        modelBuilder.Entity<LayoverCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Layover___3214EC27ED8CD2E5");

            entity.ToTable("Layover_Category");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CategoryName).IsUnicode(false);
        });

        modelBuilder.Entity<LayoverPairing>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Layover___3214EC27AF624811");

            entity.ToTable("Layover_Pairing");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FleetId).HasColumnName("Fleet_Id");
            entity.Property(e => e.NextOperation)
                .HasColumnType("datetime")
                .HasColumnName("Next_Operation");
            entity.Property(e => e.OperationDate)
                .HasColumnType("datetime")
                .HasColumnName("Operation_Date");
            entity.Property(e => e.PairCatId).HasColumnName("Pair_Cat_ID");
            entity.Property(e => e.Pairing).IsUnicode(false);

            entity.HasOne(d => d.Fleet).WithMany(p => p.LayoverPairings)
                .HasForeignKey(d => d.FleetId)
                .HasConstraintName("FK__Layover_P__Fleet__1293BD5E");

            entity.HasOne(d => d.PairCat).WithMany(p => p.LayoverPairings)
                .HasForeignKey(d => d.PairCatId)
                .HasConstraintName("FK__Layover_P__Pairi__119F9925");
        });

        modelBuilder.Entity<MaximumBid>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Maximum___3214EC27E0024628");

            entity.ToTable("Maximum_Bids");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BidType)
                .IsUnicode(false)
                .HasColumnName("BID_TYPE");
            entity.Property(e => e.CmMax)
                .IsUnicode(false)
                .HasColumnName("CM_MAX");
            entity.Property(e => e.CsMax)
                .IsUnicode(false)
                .HasColumnName("CS_MAX");
            entity.Property(e => e.FcAirbusMax)
                .IsUnicode(false)
                .HasColumnName("FC_AIRBUS_MAX");
            entity.Property(e => e.FcBoingMax)
                .IsUnicode(false)
                .HasColumnName("FC_BOING_MAX");
            entity.Property(e => e.FgFaMax)
                .IsUnicode(false)
                .HasColumnName("FG_FA_MAX");
        });

        modelBuilder.Entity<MealsCount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MealsCou__3214EC0781FAB80A");

            entity.ToTable("MealsCount");

            entity.Property(e => e.Guid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("guid");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.LastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("Last_Update");

            entity.HasOne(d => d.Flight).WithMany(p => p.MealsCounts)
                .HasForeignKey(d => d.FlightId)
                .HasConstraintName("FK_MealsCount_OCB_Flights");
        });

        modelBuilder.Entity<OcbAcPo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OCB_AC_P__3214EC0766D174EB");

            entity.ToTable("OCB_AC_Pos");

            entity.Property(e => e.Door)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Eqp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EQP");
            entity.Property(e => e.Family)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PosCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PosDisc).HasColumnType("text");
        });

        modelBuilder.Entity<OcbAllocationScreen>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OCB_Allo__3214EC071A2E7BB4");

            entity.ToTable("OCB_AllocationScreen");

            entity.Property(e => e.Duty)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RoomNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Flight).WithMany(p => p.OcbAllocationScreens)
                .HasForeignKey(d => d.FlightId)
                .HasConstraintName("FK_OCB_AllocationScreen_OCB_Flights");
        });

        modelBuilder.Entity<OcbBlock>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OCB_Bloc__3214EC07EB5AA6A2");

            entity.ToTable("OCB_Blocks");

            entity.Property(e => e.BlockDate)
                .HasColumnType("datetime")
                .HasColumnName("Block_Date");
            entity.Property(e => e.BlockNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Block_No");
            entity.Property(e => e.DaysNo).HasColumnName("Days_No");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("End_Date");
            entity.Property(e => e.EndTime)
                .HasColumnType("datetime")
                .HasColumnName("End_Time");
            entity.Property(e => e.Eqp)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Guid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("guid");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.LastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("Last_Update");
            entity.Property(e => e.StartTime)
                .HasColumnType("datetime")
                .HasColumnName("Start_Time");
        });

        modelBuilder.Entity<OcbComment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OCB_Comm__3214EC079EB1F2EE");

            entity.ToTable("OCB_Comments");

            entity.Property(e => e.Comment).HasColumnType("text");
            entity.Property(e => e.DateTime).HasColumnType("datetime");
            entity.Property(e => e.Time)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.CrewPos).WithMany(p => p.OcbComments)
                .HasForeignKey(d => d.CrewPosId)
                .HasConstraintName("FK_OCB_Comments_OCB_CrewPos");
        });

        modelBuilder.Entity<OcbCrewPo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OCB_Crew__3214EC0760AE81E6");

            entity.ToTable("OCB_CrewPos");

            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Guid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("guid");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.LastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("Last_Update");
            entity.Property(e => e.Nurse)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StaffNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Block).WithMany(p => p.OcbCrewPos)
                .HasForeignKey(d => d.BlockId)
                .HasConstraintName("FK_OCB_CrewPos_OCB_Blocks");

            entity.HasOne(d => d.Pos).WithMany(p => p.OcbCrewPos)
                .HasForeignKey(d => d.PosId)
                .HasConstraintName("FK_OCB_CrewPos_OCB_AC_Pos");

            entity.HasOne(d => d.StaffNumberNavigation).WithMany(p => p.OcbCrewPos)
                .HasForeignKey(d => d.StaffNumber)
                .HasConstraintName("FK_OCB_CrewPos_CrewDetail");
        });

        modelBuilder.Entity<OcbCrewPosHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OCB_Crew__3214EC07CDEA3D53");

            entity.ToTable("OCB_Crew_Pos_History");

            entity.HasOne(d => d.CrewPos).WithMany(p => p.OcbCrewPosHistories)
                .HasForeignKey(d => d.CrewPosId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OCB_Crew_Pos_History_OCB_CrewPos");

            entity.HasOne(d => d.Pos).WithMany(p => p.OcbCrewPosHistories)
                .HasForeignKey(d => d.PosId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OCB_Crew_Pos_History_OCB_AC_Pos");
        });

        modelBuilder.Entity<OcbFlight>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OCB_Flig__3214EC079746B033");

            entity.ToTable("OCB_Flights");

            entity.Property(e => e.Dest)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Eqp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EQP");
            entity.Property(e => e.FlightDate)
                .HasColumnType("datetime")
                .HasColumnName("Flight_Date");
            entity.Property(e => e.FltNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Flt_No");
            entity.Property(e => e.Guid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("guid");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.LastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("Last_Update");
            entity.Property(e => e.Orig)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqLimit)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Block).WithMany(p => p.OcbFlights)
                .HasForeignKey(d => d.BlockId)
                .HasConstraintName("FK_OCB_Flights_OCB_Blocks");
        });

        modelBuilder.Entity<OcbNotification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OCB_Noti__3214EC07A42CE738");

            entity.ToTable("OCB_Notification");

            entity.Property(e => e.Comments).HasColumnType("text");
            entity.Property(e => e.Guid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("guid");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.LastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("Last_Update");

            entity.HasOne(d => d.Flight).WithMany(p => p.OcbNotifications)
                .HasForeignKey(d => d.FlightId)
                .HasConstraintName("FK_OCB_Notification_OCB_Flights");
        });

        modelBuilder.Entity<OcbUpcomingCrew>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OCB_Upco__3214EC07DEC3DCC7");

            entity.ToTable("OCB_Upcoming_Crew");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AircraftType).HasColumnName("aircraftType");
            entity.Property(e => e.BaseStn).HasColumnName("baseStn");
            entity.Property(e => e.FltDate).HasColumnName("fltDate");
            entity.Property(e => e.FltDest).HasColumnName("Flt_Dest");
            entity.Property(e => e.FltNo).HasColumnName("fltNo");
            entity.Property(e => e.FltOrgin).HasColumnName("Flt_Orgin");
            entity.Property(e => e.RecUniqueId).HasColumnName("Rec_Unique_Id");
            entity.Property(e => e.StaffFirstName).HasColumnName("Staff_FirstName");
            entity.Property(e => e.StaffFullName).HasColumnName("Staff_FullName");
            entity.Property(e => e.StaffLastName).HasColumnName("Staff_LastName");
            entity.Property(e => e.StaffNotified).HasColumnName("Staff_Notified");
            entity.Property(e => e.StaffPos).HasColumnName("Staff_Pos");
            entity.Property(e => e.StaffQualCat)
                .HasMaxLength(50)
                .HasColumnName("Staff_Qual_Cat");
            entity.Property(e => e.StaffRequest).HasColumnName("Staff_Request");
            entity.Property(e => e.StaffShortName).HasColumnName("Staff_ShortName");
        });

        modelBuilder.Entity<OtpFlightInfo>(entity =>
        {
            entity.HasKey(e => e.SequenceNumber).HasName("PK__tmp_ms_x__7625BE5C5BFCCE70");

            entity.ToTable("OtpFlightInfo");

            entity.Property(e => e.SequenceNumber)
                .ValueGeneratedNever()
                .HasColumnName("sequence_Number");
            entity.Property(e => e.ActualArrivalAirport)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("actual_Arrival_Airport");
            entity.Property(e => e.ActualArrivalDateTime)
                .HasColumnType("datetime")
                .HasColumnName("actual_Arrival_DateTime");
            entity.Property(e => e.ActualDepartureAirport)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("actual_Departure_Airport");
            entity.Property(e => e.ActualDepartureDateTime)
                .HasColumnType("datetime")
                .HasColumnName("actual_Departure_DateTime");
            entity.Property(e => e.CurrentStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("current_Status");
            entity.Property(e => e.FlightDate).HasColumnName("flight_Date");
            entity.Property(e => e.FlightNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("flight_Number");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.LegSequenceNumber).HasColumnName("Leg_Sequence_Number");
            entity.Property(e => e.PublishArrivalDateTime)
                .HasColumnType("datetime")
                .HasColumnName("publish_Arrival_DateTime");
            entity.Property(e => e.PublishDepartureDateTime)
                .HasColumnType("datetime")
                .HasColumnName("publish_Departure_DateTime");
            entity.Property(e => e.ScheduledArrivalDateTime)
                .HasColumnType("datetime")
                .HasColumnName("scheduled_Arrival_DateTime");
            entity.Property(e => e.ScheduledDepartureDateTime)
                .HasColumnType("datetime")
                .HasColumnName("scheduled_Departure_DateTime");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<OtpFlightStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OtpFligh__3214EC07025805AF");

            entity.ToTable("OtpFlightStatus");

            entity.Property(e => e.ActualAirborne).HasColumnType("datetime");
            entity.Property(e => e.ActualLanding).HasColumnType("datetime");
            entity.Property(e => e.ActualOffblocks).HasColumnType("datetime");
            entity.Property(e => e.ActualOnblocks).HasColumnType("datetime");
            entity.Property(e => e.CancelledTime)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CarrierCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CnclCd)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DepGates)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EstArvDt).HasColumnType("datetime");
            entity.Property(e => e.EstDepDt).HasColumnType("datetime");
            entity.Property(e => e.FltDt).HasColumnType("datetime");
            entity.Property(e => e.FltManipCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FltNr)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FltSeqNr)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GrdReturn)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LatestArvArpCd)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LatestArvDt).HasColumnType("datetime");
            entity.Property(e => e.LatestDepArpCd)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LatestDepDt).HasColumnType("datetime");
            entity.Property(e => e.LatestEqpCd)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LatestEqpCdType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LatestTailNr)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LegStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LocalRemarks)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.OpSuffix)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PreEndStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PreStartStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PubSchArvDt).HasColumnType("datetime");
            entity.Property(e => e.PubSchDepDt).HasColumnType("datetime");
            entity.Property(e => e.SchArvArpCd)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SchArvDt).HasColumnType("datetime");
            entity.Property(e => e.SchDepArpCd)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SchDepDt).HasColumnType("datetime");
            entity.Property(e => e.SchEqpCd)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SchTailNr)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SvcType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OtpGatesdep>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__otpGates__3214EC075BBF9192");

            entity.ToTable("otpGatesdep");

            entity.Property(e => e.Arr)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Bstpln).HasColumnType("datetime");
            entity.Property(e => e.Dep)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FltDt).HasColumnType("datetime");
            entity.Property(e => e.FltNr)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gat)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gclpln).HasColumnType("datetime");
        });

        modelBuilder.Entity<OtpPassengerDetail>(entity =>
        {
            entity.HasKey(e => e.FlightSequenceNumber);

            entity.Property(e => e.FlightSequenceNumber)
                .ValueGeneratedNever()
                .HasColumnName("flight_Sequence_Number");
            entity.Property(e => e.Adult).HasColumnName("adult");
            entity.Property(e => e.BookedJ).HasColumnName("bookedJ");
            entity.Property(e => e.BookedY).HasColumnName("bookedY");
            entity.Property(e => e.Business).HasColumnName("business");
            entity.Property(e => e.Child).HasColumnName("child");
            entity.Property(e => e.Coach).HasColumnName("coach");
            entity.Property(e => e.First).HasColumnName("first");
            entity.Property(e => e.Infant).HasColumnName("infant");
            entity.Property(e => e.JSeatConfig)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("jSeatConfig");
            entity.Property(e => e.SeatConfig)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("seatConfig");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.YSeatConfig)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ySeatConfig");

            entity.HasOne(d => d.FlightSequenceNumberNavigation).WithOne(p => p.OtpPassengerDetail)
                .HasForeignKey<OtpPassengerDetail>(d => d.FlightSequenceNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__OtpPassen__fligh__4865BE2A");
        });

        modelBuilder.Entity<OutOfBase>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OutOfBas__3214EC07D97AA389");

            entity.ToTable("OutOfBase");

            entity.Property(e => e.Comments).HasColumnType("text");
            entity.Property(e => e.DateFrom).HasColumnType("datetime");
            entity.Property(e => e.DateTo).HasColumnType("datetime");
            entity.Property(e => e.StaffNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.StaffNumberNavigation).WithMany(p => p.OutOfBases)
                .HasForeignKey(d => d.StaffNumber)
                .HasConstraintName("FK_CrewDetail_StaffNumber");
        });

        modelBuilder.Entity<PairingCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pairing___3214EC27CD0328B8");

            entity.ToTable("Pairing_Category");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CategoryName).IsUnicode(false);
            entity.Property(e => e.SeperationDay).HasColumnName("Seperation_Day");
        });

        modelBuilder.Entity<PickupDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PickupDe__3214EC07C3539CF5");

            entity.Property(e => e.BusId).HasColumnName("Bus_Id");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.FlightDateTime).HasColumnType("datetime");
            entity.Property(e => e.FlightDetails)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.From)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IsDeleted).HasColumnName("Is_deleted");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PickupDateTime).HasColumnType("datetime");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StaffNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Time).HasColumnType("datetime");
            entity.Property(e => e.To)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Zone)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Bus).WithMany(p => p.PickupDetails)
                .HasForeignKey(d => d.BusId)
                .HasConstraintName("FK__PickupDet__Bus_I__59C55456");

            entity.HasOne(d => d.Group).WithMany(p => p.PickupDetails)
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("FK__PickupDet__Group__5AB9788F");

            entity.HasOne(d => d.StaffNumberNavigation).WithMany(p => p.PickupDetails)
                .HasForeignKey(d => d.StaffNumber)
                .HasConstraintName("FK__PickupDet__Staff__5BAD9CC8");
        });

        modelBuilder.Entity<PilotCrewDetail>(entity =>
        {
            entity.HasKey(e => e.StaffNumber).HasName("PK__PilotCre__F2BC669A72262B9A");

            entity.ToTable("PilotCrewDetail");

            entity.Property(e => e.StaffNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Address1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Address2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Address3)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lang1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lang2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lang3)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lang4)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PA");
            entity.Property(e => e.Sex)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PilotCrewDocRejectReason>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PilotCre__3214EC07BE760F25");

            entity.Property(e => e.HistoryId).HasColumnName("History_Id");
            entity.Property(e => e.IsActive).HasDefaultValue(true);

            entity.HasOne(d => d.Doc).WithMany(p => p.PilotCrewDocRejectReasons)
                .HasForeignKey(d => d.DocId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CrewDocRejectReasons_PilotCrewDocument");

            entity.HasOne(d => d.History).WithMany(p => p.PilotCrewDocRejectReasons)
                .HasForeignKey(d => d.HistoryId)
                .HasConstraintName("FK_PilotCrewDocRejectReasons_StatusHistory");

            entity.HasOne(d => d.Reason).WithMany(p => p.PilotCrewDocRejectReasons)
                .HasForeignKey(d => d.ReasonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CrewDocRejectReasons_DocumentRejectReasons");
        });

        modelBuilder.Entity<PilotCrewDocument>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PilotCre__3214EC079E42A2F1");

            entity.ToTable("PilotCrewDocument");

            entity.Property(e => e.AdminReason)
                .IsUnicode(false)
                .HasColumnName("Admin_Reason");
            entity.Property(e => e.AttachmentPath)
                .IsUnicode(false)
                .HasColumnName("Attachment_Path");
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.DocumentType).HasColumnName("Document_Type");
            entity.Property(e => e.FileName)
                .IsUnicode(false)
                .HasColumnName("file_name");
            entity.Property(e => e.StaffNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.SubmitedDt)
                .HasColumnType("datetime")
                .HasColumnName("Submited_DT");
            entity.Property(e => e.UpdatedBy)
                .IsUnicode(false)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UpdatedDt)
                .HasColumnType("datetime")
                .HasColumnName("Updated_Dt");

            entity.HasOne(d => d.DocumentTypeNavigation).WithMany(p => p.PilotCrewDocuments)
                .HasForeignKey(d => d.DocumentType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PilotCrew__Docum__00FF1D08");

            entity.HasOne(d => d.StaffNumberNavigation).WithMany(p => p.PilotCrewDocuments)
                .HasForeignKey(d => d.StaffNumber)
                .HasConstraintName("FK__PilotCrew__Staff__000AF8CF");
        });

        modelBuilder.Entity<PilotCrewDocumentStatusHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PilotCre__3214EC07656C1827");

            entity.ToTable("PilotCrewDocumentStatusHistory");

            entity.Property(e => e.AttachmentPath)
                .IsUnicode(false)
                .HasColumnName("Attachment_Path");
            entity.Property(e => e.ChangeDt)
                .HasColumnType("datetime")
                .HasColumnName("Change_DT");
            entity.Property(e => e.Comments).IsUnicode(false);
            entity.Property(e => e.DocumentId).HasColumnName("Document_Id");
            entity.Property(e => e.StaffNumber).IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.HasOne(d => d.Document).WithMany(p => p.PilotCrewDocumentStatusHistories)
                .HasForeignKey(d => d.DocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PilotCrew__Docum__09946309");
        });

        modelBuilder.Entity<PilotDetail>(entity =>
        {
            entity.HasKey(e => e.StaffNumber).HasName("PK__PilotDet__F2BC669A4ED69CA8");

            entity.ToTable("PilotDetail");

            entity.Property(e => e.StaffNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Address1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Address2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Address3)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lang1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lang2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lang3)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lang4)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PA");
            entity.Property(e => e.Sex)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PotableWater>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PotableW__3214EC07D39727A0");

            entity.ToTable("PotableWater");

            entity.Property(e => e.Guid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("guid");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.LastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("Last_Update");
            entity.Property(e => e.Percentage).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.Flight).WithMany(p => p.PotableWaters)
                .HasForeignKey(d => d.FlightId)
                .HasConstraintName("FK_PotableWater_OCB_Flights");
        });

        modelBuilder.Entity<PreBookedMeal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC079607303F");

            entity.Property(e => e.AircraftType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Aircraft_Type");
            entity.Property(e => e.Arrival)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Class)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departure)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Equipment)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FltSeqNr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FLT_SEQ_NR");
            entity.Property(e => e.Guid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("guid");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.LastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("Last_Update");
            entity.Property(e => e.MealType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Meal_Type");
            entity.Property(e => e.PassengerName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Passenger_Name");
            entity.Property(e => e.Remarks).HasColumnType("text");

            entity.HasOne(d => d.Flight).WithMany(p => p.PreBookedMeals)
                .HasForeignKey(d => d.FlightId)
                .HasConstraintName("FK_PreBookedMeals_OCB_Flights");
        });

        modelBuilder.Entity<PreFlightAnswer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Answers");

            entity.ToTable("PreFlight_Answers");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AnswerText).HasColumnType("text");
            entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

            entity.HasOne(d => d.Question).WithMany(p => p.PreFlightAnswers)
                .HasForeignKey(d => d.QuestionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PreFlight_Answers_PreFlight_TestQuestions");
        });

        modelBuilder.Entity<PreFlightCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PreFligh__3214EC071EFF5E2B");

            entity.ToTable("PreFlight_Categories");

            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Fleet).WithMany(p => p.PreFlightCategories)
                .HasForeignKey(d => d.FleetId)
                .HasConstraintName("FK_PreFlight_Categories_Fleets");
        });

        modelBuilder.Entity<PreFlightComment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Comments");

            entity.ToTable("PreFlight_Comments");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Comments).HasColumnType("text");
            entity.Property(e => e.DelayTime)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.StaffNumber)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.CrewTest).WithMany(p => p.PreFlightComments)
                .HasForeignKey(d => d.CrewTestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PreFlight_Comments_PreFlight_CrewTest");
        });

        modelBuilder.Entity<PreFlightCrewTest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PreFligh__3214EC07C9B699CF");

            entity.ToTable("PreFlight_CrewTest");

            entity.Property(e => e.TestDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.CrewPos).WithMany(p => p.PreFlightCrewTests)
                .HasForeignKey(d => d.CrewPosId)
                .HasConstraintName("FK_PreFlight_CrewTest_OCB_CrewPos");

            entity.HasOne(d => d.Flight).WithMany(p => p.PreFlightCrewTests)
                .HasForeignKey(d => d.FlightId)
                .HasConstraintName("FK_PreFlight_CrewTest_OCB_Flights");
        });

        modelBuilder.Entity<PreFlightFailedComment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_FailedComments");

            entity.ToTable("PreFlight_FailedComments");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CommentDate).HasColumnType("datetime");
            entity.Property(e => e.Comments).HasColumnType("text");

            entity.HasOne(d => d.CrewTest).WithMany(p => p.PreFlightFailedComments)
                .HasForeignKey(d => d.CrewTestId)
                .HasConstraintName("FK_PreFlight_FailedComments_PreFlight_CrewTest");
        });

        modelBuilder.Entity<PreFlightSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Settings");

            entity.ToTable("PreFlight_Settings");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EmailSendFrom)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmailSendFromPassword)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.EmailSendTo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmailSmtp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EmailSMTP");
            entity.Property(e => e.EmailUsername)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PassPercentage)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PreFlightTestExlude>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TestExlude");

            entity.ToTable("PreFlight_TestExlude");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CommentDate).HasColumnType("datetime");
            entity.Property(e => e.Comments).HasColumnType("text");
            entity.Property(e => e.StaffNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.CrewPos).WithMany(p => p.PreFlightTestExludes)
                .HasForeignKey(d => d.CrewPosId)
                .HasConstraintName("FK_PreFlight_TestExlude_OCB_CrewPos");

            entity.HasOne(d => d.Flight).WithMany(p => p.PreFlightTestExludes)
                .HasForeignKey(d => d.FlightId)
                .HasConstraintName("FK_PreFlight_TestExlude_OCB_Flights");
        });

        modelBuilder.Entity<PreFlightTestLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TestLog");

            entity.ToTable("PreFlight_TestLog");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AnswerId).HasColumnName("AnswerID");

            entity.HasOne(d => d.Answer).WithMany(p => p.PreFlightTestLogs)
                .HasForeignKey(d => d.AnswerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PreFlight_TestLog_PreFlight_Answers");

            entity.HasOne(d => d.CrewTest).WithMany(p => p.PreFlightTestLogs)
                .HasForeignKey(d => d.CrewTestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PreFlight_TestLog_PreFlight_CrewTest");
        });

        modelBuilder.Entity<PreFlightTestQuestion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PreFligh__3214EC07B76E5831");

            entity.ToTable("PreFlight_TestQuestions");

            entity.Property(e => e.Question).HasColumnType("text");

            entity.HasOne(d => d.Category).WithMany(p => p.PreFlightTestQuestions)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_PreFlight_TestQuestions_PreFlight_Categories");
        });

        modelBuilder.Entity<RosterDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Roster_D__3214EC27D4A048B6");

            entity.ToTable("Roster_Data");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.HighSeniorityGroup)
                .IsUnicode(false)
                .HasColumnName("HIGH_SENIORITY_GROUP");
            entity.Property(e => e.RosterPubDate)
                .HasColumnType("datetime")
                .HasColumnName("ROSTER_PUB_DATE");
            entity.Property(e => e.Rostermonth)
                .IsUnicode(false)
                .HasColumnName("ROSTERMONTH");
            entity.Property(e => e.Rosteryear)
                .IsUnicode(false)
                .HasColumnName("ROSTERYEAR");
        });

        modelBuilder.Entity<SeniorityPeriodDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Seniorit__3214EC2776F3F6B3");

            entity.ToTable("Seniority_PeriodDetails");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<Setting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Settings__3214EC070F9EC81A");

            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TitleTextVal).IsUnicode(false);
            entity.Property(e => e.UpdatedBy).IsUnicode(false);
            entity.Property(e => e.UpdatedDt)
                .HasColumnType("datetime")
                .HasColumnName("UpdatedDT");
            entity.Property(e => e.Value)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SharePointLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SharePoi__3214EC07219002A5");

            entity.Property(e => e.CreationTime).HasColumnType("datetime");
            entity.Property(e => e.FileName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.LogId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Operation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SourceUrl)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SourceURL");
            entity.Property(e => e.StaffNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.StaffNumberNavigation).WithMany(p => p.SharePointLogs)
                .HasForeignKey(d => d.StaffNumber)
                .HasConstraintName("FK_SharePointLogs_CrewDetail");
        });

        modelBuilder.Entity<SharePointLogsTable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SharePoi__3214EC2722697509");

            entity.ToTable("SharePointLogsTable");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreationTime).HasColumnType("datetime");
            entity.Property(e => e.FileName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.LogId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Operation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SourceUrl)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SourceURL");
            entity.Property(e => e.StaffNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.StaffNumberNavigation).WithMany(p => p.SharePointLogsTables)
                .HasForeignKey(d => d.StaffNumber)
                .HasConstraintName("FK__SharePoin__Staff__414EAC47");
        });

        modelBuilder.Entity<SharepointFilePrefix>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Sharepoi__3213E83FDAE8FB06");

            entity.ToTable("SharepointFilePrefix");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FilePrefix)
                .IsUnicode(false)
                .HasColumnName("filePrefix");
            entity.Property(e => e.Isactive)
                .HasDefaultValue(true)
                .HasColumnName("isactive");
            entity.Property(e => e.Isdeleted)
                .HasDefaultValue(false)
                .HasColumnName("isdeleted");
        });

        modelBuilder.Entity<SpecialMeal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SpecialM__3214EC0780E26CD6");

            entity.Property(e => e.AircraftType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Aircraft_Type");
            entity.Property(e => e.Arrival)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Class)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Departure)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Equipment)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FltSeqNr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FLT_SEQ_NR");
            entity.Property(e => e.Guid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("guid");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.LastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("Last_Update");
            entity.Property(e => e.MealType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Meal_Type");
            entity.Property(e => e.PassengerName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Passenger_Name");

            entity.HasOne(d => d.Flight).WithMany(p => p.SpecialMeals)
                .HasForeignKey(d => d.FlightId)
                .HasConstraintName("FK_SpecialMeals_OCB_Flights");
        });

        modelBuilder.Entity<Ssr>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SSR__3214EC07033AE8C4");

            entity.ToTable("SSR");

            entity.Property(e => e.BookingClass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Booking_Class");
            entity.Property(e => e.Destination)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FltSeqNr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Flt_Seq_Nr");
            entity.Property(e => e.Guid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("guid");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.LastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("Last_Update");
            entity.Property(e => e.Origin)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaxName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Pax_Name");
            entity.Property(e => e.ReqType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Req_Type");

            entity.HasOne(d => d.Flight).WithMany(p => p.Ssrs)
                .HasForeignKey(d => d.FlightId)
                .HasConstraintName("FK_SSR_OCB_Flights");
        });

        modelBuilder.Entity<SsrCount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SSR_Coun__3214EC076CAA94B6");

            entity.ToTable("SSR_Count");

            entity.Property(e => e.Guid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("guid");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.LastUpdate)
                .HasColumnType("datetime")
                .HasColumnName("Last_Update");
            entity.Property(e => e.ReqType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Flight).WithMany(p => p.SsrCounts)
                .HasForeignKey(d => d.FlightId)
                .HasConstraintName("FK_SSR_Count_OCB_Flights");
        });

        modelBuilder.Entity<StationManager>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__StationM__3214EC074FB4DA55");

            entity.Property(e => e.AirportCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StaffNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TransportGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Transpor__3214EC07911804FD");

            entity.Property(e => e.GroupName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwRecency>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwRecency");

            entity.Property(e => e.BlockDate)
                .HasColumnType("datetime")
                .HasColumnName("Block_Date");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("Expiry_Date");
            entity.Property(e => e.Family)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PosCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Seqnum).HasColumnName("SEQNUM");
            entity.Property(e => e.StaffNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwRecencySummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwRecencySummary");

            entity.Property(e => e.BlockDate)
                .HasColumnType("datetime")
                .HasColumnName("Block_Date");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("Expiry_Date");
            entity.Property(e => e.Family)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StaffNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WeightMinMaxSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WeightMi__3213E83F746871C4");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("description");
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("gender");
            entity.Property(e => e.Height)
                .HasColumnType("decimal(3, 2)")
                .HasColumnName("height");
            entity.Property(e => e.Isactive)
                .HasDefaultValue(true)
                .HasColumnName("isactive");
            entity.Property(e => e.Isdeleted)
                .HasDefaultValue(false)
                .HasColumnName("isdeleted");
            entity.Property(e => e.MaxWeight)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("max_weight");
            entity.Property(e => e.MinWeight)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("min_weight");
            entity.Property(e => e.ModifiedAt)
                .HasColumnType("datetime")
                .HasColumnName("modified_at");
            entity.Property(e => e.ModifiedBy)
                .IsUnicode(false)
                .HasColumnName("modified_by");
            entity.Property(e => e.VarianceSettingsId).HasColumnName("variance_settings_id");

            entity.HasOne(d => d.VarianceSettings).WithMany(p => p.WeightMinMaxSettings)
                .HasForeignKey(d => d.VarianceSettingsId)
                .HasConstraintName("FK_WeightMinMax_WeightVariance");
        });

        modelBuilder.Entity<WeightVarianceSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WeightVa__3213E83FF24D0FB8");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("description");
            entity.Property(e => e.Isactive)
                .HasDefaultValue(true)
                .HasColumnName("isactive");
            entity.Property(e => e.Isdeleted)
                .HasDefaultValue(false)
                .HasColumnName("isdeleted");
            entity.Property(e => e.VariancePercentage)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("variance_percentage");
        });

        modelBuilder.Entity<Zone>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Zones__3214EC07E9CE5749");

            entity.Property(e => e.Governorates)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ZoneLetter)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Zone_Letter");
        });

        modelBuilder.Entity<ZoneArea>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ZoneArea__3214EC074FFBDE9E");

            entity.Property(e => e.Area)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ZoneId).HasColumnName("Zone_ID");

            entity.HasOne(d => d.Zone).WithMany(p => p.ZoneAreas)
                .HasForeignKey(d => d.ZoneId)
                .HasConstraintName("FK__ZoneAreas__Zone___6CD828CA");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
