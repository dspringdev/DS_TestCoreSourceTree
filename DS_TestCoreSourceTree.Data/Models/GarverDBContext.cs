using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DS_TestCoreSourceTree.Data.Models
{
    public partial class GarverDBContext : DbContext
    {
        public GarverDBContext()
        {
        }

        public GarverDBContext(DbContextOptions<GarverDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Pr> Pr { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=GSQLVISION.garverinc.local;Initial Catalog=GarverDB;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pr>(entity =>
            {
                entity.HasKey(e => new { e.Wbs1, e.Wbs2, e.Wbs3 })
                    .HasName("PRPK")
                    .IsClustered(false);

                entity.ToTable("PR", "dbo");

                entity.HasIndex(e => e.OpportunityId)
                    .HasName("PROpportunityIDIDX");

                entity.HasIndex(e => e.Org)
                    .HasName("PROrgIDX");

                entity.HasIndex(e => e.Principal)
                    .HasName("PRPrincipalIDX");

                entity.HasIndex(e => e.ProjMgr)
                    .HasName("PRProjMgrIDX");

                entity.HasIndex(e => new { e.BillingClientId, e.BillingContactId, e.Wbs1 })
                    .HasName("PRWBS1IDX");

                entity.HasIndex(e => new { e.Org, e.Wbs1, e.Wbs2, e.Wbs3, e.RestrictChargeCompanies })
                    .HasName("PROrgRestrictChargeCompaniesIDX");

                entity.Property(e => e.Wbs1)
                    .HasColumnName("WBS1")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Wbs2)
                    .HasColumnName("WBS2")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Wbs3)
                    .HasColumnName("WBS3")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ActCompletionDate).HasColumnType("datetime");

                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AjeraBilledConsultant).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.AjeraBilledLabor).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.AjeraBilledReimbursable).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.AjeraCostConsultant).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.AjeraCostLabor).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.AjeraCostReimbursable).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.AjeraReceivedConsultant).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.AjeraReceivedLabor).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.AjeraReceivedReimbursable).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.AjeraSpentConsultant).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.AjeraSpentLabor).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.AjeraSpentReimbursable).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.AjeraSync)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AjeraWipconsultant)
                    .HasColumnName("AjeraWIPConsultant")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.AjeraWiplabor)
                    .HasColumnName("AjeraWIPLabor")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.AjeraWipreimbursable)
                    .HasColumnName("AjeraWIPReimbursable")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.AvailableForCrm)
                    .IsRequired()
                    .HasColumnName("AvailableForCRM")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AwardType)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.BidDate).HasColumnType("datetime");

                entity.Property(e => e.BillByDefault)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BillByDefaultConsultants)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BillByDefaultOrtable).HasColumnName("BillByDefaultORTable");

                entity.Property(e => e.BillByDefaultOtherExp)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BillWbs1)
                    .HasColumnName("BillWBS1")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BillWbs2)
                    .HasColumnName("BillWBS2")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.BillWbs3)
                    .HasColumnName("BillWBS3")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.BillableWarning)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Biller)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BillingClientId)
                    .HasColumnName("BillingClientID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.BillingContactId)
                    .HasColumnName("BillingContactID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCurrencyCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.BillingExchangeRate).HasColumnType("decimal(19, 10)");

                entity.Property(e => e.BudOhrate)
                    .HasColumnName("BudOHRate")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.BudgetLevel)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetSource)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetedFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetedLevels)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Claddress)
                    .HasColumnName("CLAddress")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClbillingAddr)
                    .HasColumnName("CLBillingAddr")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClientAlias)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientConfidential)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CompetitionType)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ComplDateComment)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ConstComplDate).HasColumnType("datetime");

                entity.Property(e => e.ConsultFee).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ConsultFeeBillingCurrency).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ConsultFeeFunctionalCurrency).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ContactId)
                    .HasColumnName("ContactID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ContractDate).HasColumnType("datetime");

                entity.Property(e => e.ContractTypeGovCon)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.County)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Duration)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.EstCompletionDate).HasColumnType("datetime");

                entity.Property(e => e.ExpPctComp).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Fax)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.FaxFormat)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.FeaddlExpenses)
                    .HasColumnName("FEAddlExpenses")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.FeaddlExpensesPct)
                    .HasColumnName("FEAddlExpensesPct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.FederalInd)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Fee).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.FeeBillingCurrency).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.FeeDirExp).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.FeeDirExpBillingCurrency).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.FeeDirExpFunctionalCurrency).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.FeeDirLab).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.FeeDirLabBillingCurrency).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.FeeDirLabFunctionalCurrency).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.FeeFunctionalCurrency).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Feother)
                    .HasColumnName("FEOther")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.FeotherPct)
                    .HasColumnName("FEOtherPct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Fesurcharge)
                    .HasColumnName("FESurcharge")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.FesurchargePct)
                    .HasColumnName("FESurchargePct")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.FirmCost).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.FirmCostComment)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IcbillingExp)
                    .IsRequired()
                    .HasColumnName("ICBillingExp")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IcbillingExpMethod).HasColumnName("ICBillingExpMethod");

                entity.Property(e => e.IcbillingExpMult)
                    .HasColumnName("ICBillingExpMult")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.IcbillingExpTableNo).HasColumnName("ICBillingExpTableNo");

                entity.Property(e => e.IcbillingLab)
                    .IsRequired()
                    .HasColumnName("ICBillingLab")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IcbillingLabMethod).HasColumnName("ICBillingLabMethod");

                entity.Property(e => e.IcbillingLabMult)
                    .HasColumnName("ICBillingLabMult")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.IcbillingLabTableNo).HasColumnName("ICBillingLabTableNo");

                entity.Property(e => e.LabPctComp).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LineItemApproval)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LineItemApprovalEk)
                    .IsRequired()
                    .HasColumnName("LineItemApprovalEK")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Locale)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LongName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MasterContract)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).IsUnicode(false);

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.ModUser)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MultAmt).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Naics)
                    .HasColumnName("NAICS")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.OpportunityId)
                    .HasColumnName("OpportunityID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Org)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OurRole)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PctComp).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Phone)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneFormat)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Pimid)
                    .HasColumnName("PIMID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PlanId)
                    .HasColumnName("PlanID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Pocnsrate)
                    .HasColumnName("POCNSRate")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Pormbrate)
                    .HasColumnName("PORMBRate")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Principal)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProfServicesComplDate).HasColumnType("datetime");

                entity.Property(e => e.ProjMgr)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectCurrencyCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectExchangeRate).HasColumnType("decimal(19, 10)");

                entity.Property(e => e.ProjectTemplate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProposalWbs1)
                    .HasColumnName("ProposalWBS1")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReadyForApproval)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReadyForProcessing)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Referable)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReimbAllow).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ReimbAllowBillingCurrency).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ReimbAllowCons).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ReimbAllowConsBillingCurrency).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ReimbAllowConsFunctionalCurrency).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ReimbAllowExp).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ReimbAllowExpBillingCurrency).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ReimbAllowExpFunctionalCurrency).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ReimbAllowFunctionalCurrency).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.RequireComments)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Responsibility)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RestrictChargeCompanies)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RevType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RevType2)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RevType3)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RevType4)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RevType5)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RevUpsetIncludeComp)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RevUpsetIncludeCompDirExp)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RevUpsetIncludeCons)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RevUpsetIncludeReimb)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RevUpsetIncludeReimbCons)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RevUpsetLimits)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RevUpsetWbs2)
                    .HasColumnName("RevUpsetWBS2")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RevUpsetWbs3)
                    .HasColumnName("RevUpsetWBS3")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RevenueMethod)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ServProCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Solicitation)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.State)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SubLevel)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Supervisor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TkcheckRpdate)
                    .IsRequired()
                    .HasColumnName("TKCheckRPDate")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TkcheckRpplannedHrs)
                    .IsRequired()
                    .HasColumnName("TKCheckRPPlannedHrs")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TlchargeBandExternalCode)
                    .HasColumnName("TLChargeBandExternalCode")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.TlchargeBandInternalKey)
                    .HasColumnName("TLChargeBandInternalKey")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TlinternalKey)
                    .HasColumnName("TLInternalKey")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TlprojectId)
                    .HasColumnName("TLProjectID")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TlprojectName)
                    .HasColumnName("TLProjectName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TlsyncModDate)
                    .HasColumnName("TLSyncModDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TotalCostComment)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TotalProjectCost).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.UnitTable)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.Xcharge)
                    .IsRequired()
                    .HasColumnName("XCharge")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.XchargeMethod).HasColumnName("XChargeMethod");

                entity.Property(e => e.XchargeMult)
                    .HasColumnName("XChargeMult")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Zip)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
