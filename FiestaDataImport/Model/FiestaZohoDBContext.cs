using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FiestaDataImport.Model
{
    public partial class FiestaZohoDBContext : DbContext
    {
        public FiestaZohoDBContext()
        {
        }

        public FiestaZohoDBContext(DbContextOptions<FiestaZohoDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<FiestaArtable> FiestaArtable { get; set; }
        public virtual DbSet<FiestaArtableDup> FiestaArtableDup { get; set; }
        public virtual DbSet<FiestaCommissionTable> FiestaCommissionTable { get; set; }
        public virtual DbSet<FiestaCommissionTableDup> FiestaCommissionTableDup { get; set; }
        public virtual DbSet<FiestaDdtable> FiestaDdtable { get; set; }
        public virtual DbSet<FiestaDdtableDup> FiestaDdtableDup { get; set; }
        public virtual DbSet<FiestaEfttable> FiestaEfttable { get; set; }
        public virtual DbSet<FiestaEfttableDup> FiestaEfttableDup { get; set; }
        public virtual DbSet<FiestaEfttableTemp> FiestaEfttableTemp { get; set; }
        public virtual DbSet<FiestaEmployee> FiestaEmployee { get; set; }
        public virtual DbSet<FiestaEmpStates> FiestaEmpStates { get; set; }
        public virtual DbSet<FiestaEmpStore> FiestaEmpStore { get; set; }
        public virtual DbSet<FiestaEmpStoreReport> FiestaEmpStoreReport { get; set; }
        public virtual DbSet<FiestaEodtable> FiestaEodtable { get; set; }
        public virtual DbSet<FiestaEodtableDup> FiestaEodtableDup { get; set; }
        public virtual DbSet<FiestaExcelCompare> FiestaExcelCompare { get; set; }
        public virtual DbSet<FiestaReconTable> FiestaReconTable { get; set; }
        public virtual DbSet<FiestaReconTableDup> FiestaReconTableDup { get; set; }
        public virtual DbSet<FiestaReport> FiestaReport { get; set; }
        public virtual DbSet<FiestaRole> FiestaRole { get; set; }
        public virtual DbSet<FiestaRptable> FiestaRptable { get; set; }
        public virtual DbSet<FiestaRptableDup> FiestaRptableDup { get; set; }
        public virtual DbSet<FiestaState> FiestaState { get; set; }
        public virtual DbSet<FiestaStore> FiestaStore { get; set; }
        public virtual DbSet<ReportFileUploads> ReportFileUploads { get; set; }
        public virtual DbSet<Table1> Table1 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=POG_DEVELOPMENT\\DEV;Database=FiestaZohoDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FiestaArtable>(entity =>
            {
                entity.ToTable("Fiesta_ARTable");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Duple)
                    .HasColumnName("duple")
                    .HasMaxLength(910)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(((((([storeNo]+[reconType])+CONVERT([varchar],[transactionDate],(20)))+[internalReference])+[narrative])+[externalReference])+CONVERT([varchar],[amount],(0)))");

                entity.Property(e => e.Email1)
                    .HasColumnName("email1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email2)
                    .HasColumnName("email2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email3)
                    .HasColumnName("email3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email4)
                    .HasColumnName("email4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email5)
                    .HasColumnName("email5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email6)
                    .HasColumnName("email6")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalReference)
                    .IsRequired()
                    .HasColumnName("externalReference")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InternalReference)
                    .IsRequired()
                    .HasColumnName("internalReference")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Narrative)
                    .IsRequired()
                    .HasColumnName("narrative")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReconType)
                    .IsRequired()
                    .HasColumnName("reconType")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReportMonth)
                    .HasColumnName("reportMonth")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StoreNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate)
                    .HasColumnName("transactionDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<FiestaArtableDup>(entity =>
            {
                entity.ToTable("Fiesta_ARTableDUP");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Duple)
                    .HasColumnName("duple")
                    .HasMaxLength(910)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(((((([storeNo]+[reconType])+CONVERT([varchar],[transactionDate],(20)))+[internalReference])+[narrative])+[externalReference])+CONVERT([varchar],[amount],(0)))");

                entity.Property(e => e.Email1)
                    .HasColumnName("email1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email2)
                    .HasColumnName("email2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email3)
                    .HasColumnName("email3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email4)
                    .HasColumnName("email4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email5)
                    .HasColumnName("email5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email6)
                    .HasColumnName("email6")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalReference)
                    .IsRequired()
                    .HasColumnName("externalReference")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InternalReference)
                    .IsRequired()
                    .HasColumnName("internalReference")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Narrative)
                    .IsRequired()
                    .HasColumnName("narrative")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReconType)
                    .IsRequired()
                    .HasColumnName("reconType")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReportMonth)
                    .HasColumnName("reportMonth")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StoreNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate)
                    .HasColumnName("transactionDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<FiestaCommissionTable>(entity =>
            {
                entity.ToTable("Fiesta_CommissionTable");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Balance)
                    .HasColumnName("balance")
                    .HasColumnType("numeric(19, 2)")
                    .HasComputedColumnSql("([credit]-[debit])");

                entity.Property(e => e.Credit)
                    .HasColumnName("credit")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DateCt)
                    .HasColumnName("date_CT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Debit)
                    .HasColumnName("debit")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Duple)
                    .HasColumnName("duple")
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(((([storeNo]+CONVERT([varchar],[date_CT],(20)))+[Name])+CONVERT([varchar],[credit],(0)))+CONVERT([varchar],[debit],(0)))");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email2)
                    .HasColumnName("email2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email3)
                    .HasColumnName("email3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email4)
                    .HasColumnName("email4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email5)
                    .HasColumnName("email5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StoreNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCt)
                    .IsRequired()
                    .HasColumnName("typeCT")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FiestaCommissionTableDup>(entity =>
            {
                entity.ToTable("Fiesta_CommissionTableDup");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Balance)
                    .HasColumnName("balance")
                    .HasColumnType("numeric(19, 2)")
                    .HasComputedColumnSql("([credit]-[debit])");

                entity.Property(e => e.Credit)
                    .HasColumnName("credit")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DateCt)
                    .HasColumnName("date_CT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Debit)
                    .HasColumnName("debit")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Duple)
                    .HasColumnName("duple")
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(((([storeNo]+CONVERT([varchar],[date_CT],(20)))+[Name])+CONVERT([varchar],[credit],(0)))+CONVERT([varchar],[debit],(0)))");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email2)
                    .HasColumnName("email2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email3)
                    .HasColumnName("email3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email4)
                    .HasColumnName("email4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email5)
                    .HasColumnName("email5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StoreNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCt)
                    .HasColumnName("typeCT")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FiestaDdtable>(entity =>
            {
                entity.HasKey(e => new { e.StoreNo, e.ReportDate });

                entity.ToTable("Fiesta_DDTable");

                entity.Property(e => e.StoreNo)
                    .HasColumnName("storeNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReportDate)
                    .HasColumnName("reportDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ActualCreditCards)
                    .HasColumnName("actualCreditCards")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ActualDeposit)
                    .HasColumnName("actualDeposit")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ArviolationFees)
                    .HasColumnName("ARViolationFees")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DepositDate)
                    .HasColumnName("depositDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepositOver)
                    .HasColumnName("depositOver")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DepositViolationFees)
                    .HasColumnName("depositViolationFees")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Duple)
                    .HasColumnName("duple")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasComputedColumnSql("([storeNo]+CONVERT([varchar],[ReportDate],(20)))");

                entity.Property(e => e.Email1)
                    .HasColumnName("email1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email2)
                    .HasColumnName("email2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email3)
                    .HasColumnName("email3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email4)
                    .HasColumnName("email4")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email5)
                    .HasColumnName("email5")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email6)
                    .HasColumnName("email6")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailStore)
                    .HasColumnName("emailStore")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EodcreditCards)
                    .HasColumnName("EODCreditCards")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Eoddeposit)
                    .HasColumnName("EODDeposit")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MonthNumber).HasColumnName("monthNumber");

                entity.Property(e => e.OverCreditCards)
                    .HasColumnName("overCreditCards")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PayoutCheck)
                    .HasColumnName("payoutCheck")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PayoutTo)
                    .HasColumnName("payoutTo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReportMonth)
                    .HasColumnName("reportMonth")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScanningViolationFees)
                    .HasColumnName("scanningViolationFees")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ViolationFeesTotal)
                    .HasColumnName("violationFeesTotal")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VoidCredits)
                    .HasColumnName("voidCredits")
                    .HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<FiestaDdtableDup>(entity =>
            {
                entity.ToTable("Fiesta_DDTableDUP");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActualCreditCards)
                    .HasColumnName("actualCreditCards")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ActualDeposit)
                    .HasColumnName("actualDeposit")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ArviolationFees)
                    .HasColumnName("ARViolationFees")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DepositDate)
                    .HasColumnName("depositDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepositOver)
                    .HasColumnName("depositOver")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DepositViolationFees)
                    .HasColumnName("depositViolationFees")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Duple)
                    .HasColumnName("duple")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasComputedColumnSql("([storeNo]+CONVERT([varchar],[ReportDate],(20)))");

                entity.Property(e => e.Email1)
                    .HasColumnName("email1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email2)
                    .HasColumnName("email2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email3)
                    .HasColumnName("email3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email4)
                    .HasColumnName("email4")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email5)
                    .HasColumnName("email5")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email6)
                    .HasColumnName("email6")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailStore)
                    .HasColumnName("emailStore")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EodcreditCards)
                    .HasColumnName("EODCreditCards")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Eoddeposit)
                    .HasColumnName("EODDeposit")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MonthNumber).HasColumnName("monthNumber");

                entity.Property(e => e.OverCreditCards)
                    .HasColumnName("overCreditCards")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PayoutCheck)
                    .HasColumnName("payoutCheck")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PayoutTo)
                    .HasColumnName("payoutTo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReportDate)
                    .HasColumnName("reportDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReportMonth)
                    .HasColumnName("reportMonth")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScanningViolationFees)
                    .HasColumnName("scanningViolationFees")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.StoreNo)
                    .IsRequired()
                    .HasColumnName("storeNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ViolationFeesTotal)
                    .HasColumnName("violationFeesTotal")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VoidCredits)
                    .HasColumnName("voidCredits")
                    .HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<FiestaEfttable>(entity =>
            {
                entity.HasKey(e => new { e.StoreNo, e.DateOfReceipt, e.PolicyNumber, e.Premium });

                entity.ToTable("Fiesta_EFTTable");

                entity.Property(e => e.StoreNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfReceipt)
                    .HasColumnName("dateOfReceipt")
                    .HasColumnType("datetime");

                entity.Property(e => e.PolicyNumber)
                    .HasColumnName("policyNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Premium)
                    .HasColumnName("premium")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Duple)
                    .HasColumnName("duple")
                    .HasMaxLength(160)
                    .IsUnicode(false)
                    .HasComputedColumnSql("((([storeNo]+CONVERT([varchar],[dateOfReceipt],(20)))+[policynumber])+CONVERT([varchar],[premium],(0)))");

                entity.Property(e => e.Email1)
                    .HasColumnName("email1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email2)
                    .HasColumnName("email2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email3)
                    .HasColumnName("email3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email4)
                    .HasColumnName("email4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email5)
                    .HasColumnName("email5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email6)
                    .HasColumnName("email6")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InsuranceCompany)
                    .HasColumnName("insuranceCompany")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NameOfCustomer)
                    .HasColumnName("nameOfCustomer")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FiestaEfttableDup>(entity =>
            {
                entity.ToTable("Fiesta_EFTTableDUP");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateOfReceipt)
                    .HasColumnName("dateOfReceipt")
                    .HasColumnType("datetime");

                entity.Property(e => e.Duple)
                    .HasColumnName("duple")
                    .HasMaxLength(160)
                    .IsUnicode(false)
                    .HasComputedColumnSql("((([storeNo]+CONVERT([varchar],[dateOfReceipt],(20)))+[policynumber])+CONVERT([varchar],[premium],(0)))");

                entity.Property(e => e.Email1)
                    .HasColumnName("email1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email2)
                    .HasColumnName("email2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email3)
                    .HasColumnName("email3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email4)
                    .HasColumnName("email4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email5)
                    .HasColumnName("email5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email6)
                    .HasColumnName("email6")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsuranceCompany)
                    .HasColumnName("insuranceCompany")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NameOfCustomer)
                    .HasColumnName("nameOfCustomer")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyNumber)
                    .HasColumnName("policyNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Premium)
                    .HasColumnName("premium")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.StoreNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FiestaEfttableTemp>(entity =>
            {
                entity.ToTable("Fiesta_EFTTableTEMP");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateOfReceipt)
                    .HasColumnName("dateOfReceipt")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email1)
                    .HasColumnName("email1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email2)
                    .HasColumnName("email2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email3)
                    .HasColumnName("email3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email4)
                    .HasColumnName("email4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email5)
                    .HasColumnName("email5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email6)
                    .HasColumnName("email6")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsuranceCompany)
                    .HasColumnName("insuranceCompany")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NameOfCustomer)
                    .HasColumnName("nameOfCustomer")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyNumber)
                    .HasColumnName("policyNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Premium)
                    .HasColumnName("premium")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.StoreNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FiestaEmployee>(entity =>
            {
                entity.HasKey(e => e.EmpId);

                entity.ToTable("Fiesta_Employee");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FiestaEmpStates>(entity =>
            {
                entity.ToTable("Fiesta_EmpStates");

                entity.Property(e => e.AssignDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<FiestaEmpStore>(entity =>
            {
                entity.ToTable("Fiesta_EmpStore");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AssignDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StoreNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FiestaEmpStoreReport>(entity =>
            {
                entity.ToTable("Fiesta_EmpStoreReport");

                entity.Property(e => e.AssignDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StoreNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FiestaEodtable>(entity =>
            {
                entity.HasKey(e => new { e.StoreNo, e.ReportDate });

                entity.ToTable("Fiesta_EODTable");

                entity.Property(e => e.StoreNo)
                    .HasColumnName("storeNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReportDate).HasColumnType("datetime");

                entity.Property(e => e.Duple)
                    .HasColumnName("duple")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasComputedColumnSql("([storeNo]+CONVERT([varchar],[ReportDate],(20)))");

                entity.Property(e => e.EndOfTheDayDeposit).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<FiestaEodtableDup>(entity =>
            {
                entity.ToTable("Fiesta_EODTableDUP");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Duple)
                    .HasColumnName("duple")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasComputedColumnSql("([storeNo]+CONVERT([varchar],[ReportDate],(20)))");

                entity.Property(e => e.EndOfTheDayDeposit).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ReportDate).HasColumnType("datetime");

                entity.Property(e => e.StoreNo)
                    .IsRequired()
                    .HasColumnName("storeNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FiestaExcelCompare>(entity =>
            {
                entity.ToTable("Fiesta_ExcelCompare");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Datatype)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DbColName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExcelColName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FiestaReconTable>(entity =>
            {
                entity.HasKey(e => new { e.StoreNo, e.DateRt });

                entity.ToTable("Fiesta_ReconTable");

                entity.Property(e => e.StoreNo)
                    .HasColumnName("storeNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateRt)
                    .HasColumnName("dateRT")
                    .HasColumnType("datetime");

                entity.Property(e => e.AccountingViolationPenalty)
                    .HasColumnName("accountingViolationPenalty")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Advertising)
                    .HasColumnName("advertising")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BadDebts)
                    .HasColumnName("badDebts")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BalanceDueToOrFromFranchise)
                    .HasColumnName("balanceDueToOrFromFranchise")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BonusAndCommisions)
                    .HasColumnName("bonusAndCommisions")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BuildingOrOffice)
                    .HasColumnName("buildingOrOffice")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CamCharges)
                    .HasColumnName("camCharges")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Cellphone)
                    .HasColumnName("cellphone")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CommisionsTier2)
                    .HasColumnName("commisionsTier2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CommissionsPercentTier1)
                    .HasColumnName("commissionsPercentTier1")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.CommissionsPercentTier2)
                    .HasColumnName("commissionsPercentTier2")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.CommissionsTier1)
                    .HasColumnName("commissionsTier1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DandSmembership)
                    .HasColumnName("DAndSMembership")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DepositViolationPenalty)
                    .HasColumnName("depositViolationPenalty")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DoiappointmentFee)
                    .HasColumnName("DOIAppointmentFee")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DoilicenseFee)
                    .HasColumnName("DOILicenseFee")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Duple)
                    .HasColumnName("duple")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComputedColumnSql("([storeNo]+CONVERT([varchar],[dateRT],(20)))");

                entity.Property(e => e.EandOinsurance)
                    .HasColumnName("EAndOInsurance")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Electricity)
                    .HasColumnName("electricity")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Email1)
                    .HasColumnName("email1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email2)
                    .HasColumnName("email2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email3)
                    .HasColumnName("email3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email4)
                    .HasColumnName("email4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email5)
                    .HasColumnName("email5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntrepreneurMagazine)
                    .HasColumnName("entrepreneurMagazine")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FranchiseGratorLeads)
                    .HasColumnName("franchiseGratorLeads")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FranchiseGuideSupplies)
                    .HasColumnName("franchiseGuideSupplies")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FranchiseTimeMagazine)
                    .HasColumnName("franchiseTimeMagazine")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Gas)
                    .HasColumnName("gas")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.GrossCommisions)
                    .HasColumnName("grossCommisions")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.HourlyWages)
                    .HasColumnName("hourlyWages")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Incentive)
                    .HasColumnName("incentive")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Internet)
                    .HasColumnName("internet")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Leads)
                    .HasColumnName("leads")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.LegalFee)
                    .HasColumnName("legalFee")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.LicensesAndPermit)
                    .HasColumnName("licensesAndPermit")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.LicensesAndPermits)
                    .HasColumnName("Licenses_and_Permits")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.LicensesPermits)
                    .HasColumnName("Licenses_Permits")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.LoanDueFromFranchisee)
                    .HasColumnName("loanDueFromFranchisee")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MaxShield)
                    .HasColumnName("maxShield")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MinimumRoyaltyFee)
                    .HasColumnName("minimumRoyaltyFee")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MotorVehicleReport)
                    .HasColumnName("motorVehicleReport")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.NetTaxRevenue)
                    .HasColumnName("netTaxRevenue")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Notes)
                    .HasColumnName("notes")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NumberOfTaxReturns).HasColumnName("numberOfTaxReturns");

                entity.Property(e => e.OnHoldRecording)
                    .HasColumnName("onHoldRecording")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.OtherTransactions)
                    .HasColumnName("otherTransactions")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Overtime)
                    .HasColumnName("overtime")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PayrollProcessingFee)
                    .HasColumnName("payrollProcessingFee")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PayrollTaxesEr)
                    .HasColumnName("payrollTaxes_ER")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PolicyManager)
                    .HasColumnName("policyManager")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Postage)
                    .HasColumnName("postage")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PreviousUnpaidBalanace)
                    .HasColumnName("previousUnpaidBalanace")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PrintRt)
                    .HasColumnName("printRT")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RatingSoftware)
                    .HasColumnName("ratingSoftware")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ReferralFee)
                    .HasColumnName("referralFee")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ReimbursedFeeOther)
                    .HasColumnName("reimbursedFeeOther")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RenewalFee)
                    .HasColumnName("renewalFee")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rent)
                    .HasColumnName("rent")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RoyaltyPerReturn)
                    .HasColumnName("royaltyPerReturn")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ScanningViolationPenalty)
                    .HasColumnName("scanningViolationPenalty")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SecurityRt)
                    .HasColumnName("securityRT")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Seo)
                    .HasColumnName("SEO")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ServicingFee)
                    .HasColumnName("servicingFee")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SignInstallment)
                    .HasColumnName("signInstallment")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SignaturePad)
                    .HasColumnName("signaturePad")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SmallEquipPurchases)
                    .HasColumnName("smallEquipPurchases")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SmallFfandE)
                    .HasColumnName("smallFFAndE")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Supplies)
                    .HasColumnName("supplies")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TaxPrepRevenue)
                    .HasColumnName("taxPrepRevenue")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TaxRoyalties)
                    .HasColumnName("taxRoyalties")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TaxSoftwareServices)
                    .HasColumnName("taxSoftwareServices")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Telephone)
                    .HasColumnName("telephone")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TelevisionRadio)
                    .HasColumnName("televisionRadio")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TotalCommisions)
                    .HasColumnName("totalCommisions")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TotalDeductions)
                    .HasColumnName("totalDeductions")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TotalRevenue)
                    .HasColumnName("totalRevenue")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TradeShows)
                    .HasColumnName("tradeShows")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TrustAccountingAr)
                    .HasColumnName("trustAccountingAR")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TrustAcctShortageOverage)
                    .HasColumnName("trustAcctShortageOverage")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.WorkersCompInsurance)
                    .HasColumnName("workersCompInsurance")
                    .HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<FiestaReconTableDup>(entity =>
            {
                entity.ToTable("Fiesta_ReconTableDup");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountingViolationPenalty)
                    .HasColumnName("accountingViolationPenalty")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Advertising)
                    .HasColumnName("advertising")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BadDebts)
                    .HasColumnName("badDebts")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BalanceDueToOrFromFranchise)
                    .HasColumnName("balanceDueToOrFromFranchise")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BonusAndCommisions)
                    .HasColumnName("bonusAndCommisions")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BuildingOrOffice)
                    .HasColumnName("buildingOrOffice")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CamCharges)
                    .HasColumnName("camCharges")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Cellphone)
                    .HasColumnName("cellphone")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CommisionsTier2)
                    .HasColumnName("commisionsTier2")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CommissionsPercentTier1)
                    .HasColumnName("commissionsPercentTier1")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.CommissionsPercentTier2)
                    .HasColumnName("commissionsPercentTier2")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.CommissionsTier1)
                    .HasColumnName("commissionsTier1")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DandSmembership)
                    .HasColumnName("DAndSMembership")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DateRt)
                    .HasColumnName("dateRT")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepositViolationPenalty)
                    .HasColumnName("depositViolationPenalty")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DoiappointmentFee)
                    .HasColumnName("DOIAppointmentFee")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DoilicenseFee)
                    .HasColumnName("DOILicenseFee")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Duple)
                    .HasColumnName("duple")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComputedColumnSql("([storeNo]+CONVERT([varchar],[dateRT],(20)))");

                entity.Property(e => e.EandOinsurance)
                    .HasColumnName("EAndOInsurance")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Electricity)
                    .HasColumnName("electricity")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Email1)
                    .HasColumnName("email1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email2)
                    .HasColumnName("email2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email3)
                    .HasColumnName("email3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email4)
                    .HasColumnName("email4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email5)
                    .HasColumnName("email5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntrepreneurMagazine)
                    .HasColumnName("entrepreneurMagazine")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FranchiseGratorLeads)
                    .HasColumnName("franchiseGratorLeads")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FranchiseGuideSupplies)
                    .HasColumnName("franchiseGuideSupplies")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FranchiseTimeMagazine)
                    .HasColumnName("franchiseTimeMagazine")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Gas)
                    .HasColumnName("gas")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.GrossCommisions)
                    .HasColumnName("grossCommisions")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.HourlyWages)
                    .HasColumnName("hourlyWages")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Incentive)
                    .HasColumnName("incentive")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Internet)
                    .HasColumnName("internet")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Leads)
                    .HasColumnName("leads")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.LegalFee)
                    .HasColumnName("legalFee")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.LicensesAndPermit)
                    .HasColumnName("licensesAndPermit")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.LicensesAndPermits)
                    .HasColumnName("Licenses_and_Permits")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.LicensesPermits)
                    .HasColumnName("Licenses_Permits")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.LoanDueFromFranchisee)
                    .HasColumnName("loanDueFromFranchisee")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MaxShield)
                    .HasColumnName("maxShield")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MinimumRoyaltyFee)
                    .HasColumnName("minimumRoyaltyFee")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MotorVehicleReport)
                    .HasColumnName("motorVehicleReport")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.NetTaxRevenue)
                    .HasColumnName("netTaxRevenue")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Notes)
                    .HasColumnName("notes")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NumberOfTaxReturns).HasColumnName("numberOfTaxReturns");

                entity.Property(e => e.OnHoldRecording)
                    .HasColumnName("onHoldRecording")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.OtherTransactions)
                    .HasColumnName("otherTransactions")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Overtime)
                    .HasColumnName("overtime")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PayrollProcessingFee)
                    .HasColumnName("payrollProcessingFee")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PayrollTaxesEr)
                    .HasColumnName("payrollTaxes_ER")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PolicyManager)
                    .HasColumnName("policyManager")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Postage)
                    .HasColumnName("postage")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PreviousUnpaidBalanace)
                    .HasColumnName("previousUnpaidBalanace")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PrintRt)
                    .HasColumnName("printRT")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RatingSoftware)
                    .HasColumnName("ratingSoftware")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ReferralFee)
                    .HasColumnName("referralFee")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ReimbursedFeeOther)
                    .HasColumnName("reimbursedFeeOther")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RenewalFee)
                    .HasColumnName("renewalFee")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rent)
                    .HasColumnName("rent")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RoyaltyPerReturn)
                    .HasColumnName("royaltyPerReturn")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ScanningViolationPenalty)
                    .HasColumnName("scanningViolationPenalty")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SecurityRt)
                    .HasColumnName("securityRT")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Seo)
                    .HasColumnName("SEO")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ServicingFee)
                    .HasColumnName("servicingFee")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SignInstallment)
                    .HasColumnName("signInstallment")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SignaturePad)
                    .HasColumnName("signaturePad")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SmallEquipPurchases)
                    .HasColumnName("smallEquipPurchases")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SmallFfandE)
                    .HasColumnName("smallFFAndE")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.StoreNo)
                    .IsRequired()
                    .HasColumnName("storeNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Supplies)
                    .HasColumnName("supplies")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TaxPrepRevenue)
                    .HasColumnName("taxPrepRevenue")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TaxRoyalties)
                    .HasColumnName("taxRoyalties")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TaxSoftwareServices)
                    .HasColumnName("taxSoftwareServices")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Telephone)
                    .HasColumnName("telephone")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TelevisionRadio)
                    .HasColumnName("televisionRadio")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TotalCommisions)
                    .HasColumnName("totalCommisions")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TotalDeductions)
                    .HasColumnName("totalDeductions")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TotalRevenue)
                    .HasColumnName("totalRevenue")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TradeShows)
                    .HasColumnName("tradeShows")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TrustAccountingAr)
                    .HasColumnName("trustAccountingAR")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TrustAcctShortageOverage)
                    .HasColumnName("trustAcctShortageOverage")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.WorkersCompInsurance)
                    .HasColumnName("workersCompInsurance")
                    .HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<FiestaReport>(entity =>
            {
                entity.HasKey(e => e.ReportId);

                entity.ToTable("Fiesta_Report");

                entity.Property(e => e.ReportName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FiestaRole>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.ToTable("Fiesta_Role");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FiestaRptable>(entity =>
            {
                entity.HasKey(e => new { e.StoreNo, e.DateRp, e.PolicyNumber, e.Narrative, e.CheckIssuedDate });

                entity.ToTable("Fiesta_RPTable");

                entity.Property(e => e.StoreNo)
                    .HasColumnName("storeNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateRp)
                    .HasColumnName("dateRP")
                    .HasColumnType("datetime");

                entity.Property(e => e.PolicyNumber)
                    .HasColumnName("policyNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Narrative)
                    .HasColumnName("narrative")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CheckIssuedDate)
                    .HasColumnName("checkIssuedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Duple)
                    .HasColumnName("duple")
                    .HasMaxLength(230)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(((([storeNo]+CONVERT([varchar],[dateRP],(20)))+[policyNumber])+[narrative])+CONVERT([varchar],[checkIssuedDate],(20)))");

                entity.Property(e => e.Email1)
                    .HasColumnName("email1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email2)
                    .HasColumnName("email2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email3)
                    .HasColumnName("email3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email4)
                    .HasColumnName("email4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email5)
                    .HasColumnName("email5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email6)
                    .HasColumnName("email6")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Insured)
                    .HasColumnName("insured")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Payments)
                    .HasColumnName("payments")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ReportMonth)
                    .HasColumnName("reportMonth")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReportNumber).HasColumnName("reportNumber");
            });

            modelBuilder.Entity<FiestaRptableDup>(entity =>
            {
                entity.ToTable("Fiesta_RPTableDUP");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CheckIssuedDate)
                    .HasColumnName("checkIssuedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateRp)
                    .HasColumnName("dateRP")
                    .HasColumnType("datetime");

                entity.Property(e => e.Duple)
                    .HasColumnName("duple")
                    .HasMaxLength(230)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(((([storeNo]+CONVERT([varchar],[dateRP],(20)))+[policyNumber])+[narrative])+CONVERT([varchar],[checkIssuedDate],(20)))");

                entity.Property(e => e.Email1)
                    .HasColumnName("email1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email2)
                    .HasColumnName("email2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email3)
                    .HasColumnName("email3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email4)
                    .HasColumnName("email4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email5)
                    .HasColumnName("email5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email6)
                    .HasColumnName("email6")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Insured)
                    .HasColumnName("insured")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Narrative)
                    .HasColumnName("narrative")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Payments)
                    .HasColumnName("payments")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PolicyNumber)
                    .HasColumnName("policyNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReportMonth)
                    .HasColumnName("reportMonth")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReportNumber).HasColumnName("reportNumber");

                entity.Property(e => e.StoreNo)
                    .IsRequired()
                    .HasColumnName("storeNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FiestaState>(entity =>
            {
                entity.HasKey(e => e.StateId);

                entity.ToTable("Fiesta_State");

                entity.Property(e => e.StateCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.StateName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FiestaStore>(entity =>
            {
                entity.HasKey(e => e.StoreNo);

                entity.ToTable("Fiesta_Store");

                entity.Property(e => e.StoreNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Street)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Zipcode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReportFileUploads>(entity =>
            {
                entity.HasKey(e => e.FileId);

                entity.Property(e => e.FileGuid).HasColumnName("FileGUID");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ReportName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UploadDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UploadedBy)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Table1>(entity =>
            {
                entity.ToTable("table1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Log1)
                    .HasColumnName("log1")
                    .IsUnicode(false);

                entity.Property(e => e.Log2)
                    .HasColumnName("log2")
                    .IsUnicode(false);

                entity.Property(e => e.Log3)
                    .HasColumnName("log3")
                    .IsUnicode(false);
            });
        }
    }
}
