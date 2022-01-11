using Microsoft.EntityFrameworkCore;
using WagonRepairDepot.Models;

namespace WagonRepairDepot.Contexts
{
    public partial class TrainContext : DbContext
    {
        public TrainContext()
        {
        }

        public TrainContext(DbContextOptions<TrainContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActualWagon> ActualWagons { get; set; } = null!;
        public virtual DbSet<ActualWork> ActualWorks { get; set; } = null!;
        public virtual DbSet<ActualWorkOrder> ActualWorkOrders { get; set; } = null!;
        public virtual DbSet<Brigade> Brigades { get; set; } = null!;
        public virtual DbSet<Brigadier> Brigadiers { get; set; } = null!;
        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<Inspector> Inspectors { get; set; } = null!;
        public virtual DbSet<Receptionist> Receptionists { get; set; } = null!;
        public virtual DbSet<Wagon> Wagons { get; set; } = null!;
        public virtual DbSet<WagonReceptionDoc> WagonReceptionDocs { get; set; } = null!;
        public virtual DbSet<WagonReturnDoc> WagonReturnDocs { get; set; } = null!;
        public virtual DbSet<Work> Works { get; set; } = null!;
        public virtual DbSet<WorkOrder> WorkOrders { get; set; } = null!;
        public virtual DbSet<WorkType> WorkTypes { get; set; } = null!;
        public virtual DbSet<Worker> Workers { get; set; } = null!;
        public virtual DbSet<WorkerBrigade> WorkerBrigades { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseLazyLoadingProxies();
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=35.187.102.235;Database=train;Username=postgres;Password=postgres");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActualWagon>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("actual_wagon");

                entity.Property(e => e.CreationYear)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("creation_year");

                entity.Property(e => e.Model).HasColumnName("model");

                entity.Property(e => e.SeatsNumber).HasColumnName("seats_number");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(10)
                    .HasColumnName("serial_number")
                    .IsFixedLength();

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.WagonId).HasColumnName("wagon_id");
            });

            modelBuilder.Entity<ActualWork>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("actual_work");

                entity.Property(e => e.ActualDeadline)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("actual_deadline");

                entity.Property(e => e.BrigadeId).HasColumnName("brigade_id");

                entity.Property(e => e.PlannedDeadline)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("planned_deadline");

                entity.Property(e => e.WorkId).HasColumnName("work_id");

                entity.Property(e => e.WorkOrderId).HasColumnName("work_order_id");

                entity.Property(e => e.WorkTypeId).HasColumnName("work_type_id");
            });

            modelBuilder.Entity<ActualWorkOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("actual_work_order");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("creation_date");

                entity.Property(e => e.InspectorId).HasColumnName("inspector_id");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.WagonId).HasColumnName("wagon_id");

                entity.Property(e => e.WorkOrderId).HasColumnName("work_order_id");
            });

            modelBuilder.Entity<Brigade>(entity =>
            {
                entity.ToTable("brigade");

                entity.HasIndex(e => e.BrigadierId, "IX_brigadier_brigade");

                entity.Property(e => e.BrigadeId).HasColumnName("brigade_id");

                entity.Property(e => e.BrigadierId).HasColumnName("brigadier_id");

                entity.HasOne(d => d.Brigadier)
                    .WithMany(p => p.Brigades)
                    .HasForeignKey(d => d.BrigadierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("brigadier_brigade");
            });

            modelBuilder.Entity<Brigadier>(entity =>
            {
                entity.ToTable("brigadier");

                entity.Property(e => e.BrigadierId).HasColumnName("brigadier_id");

                entity.Property(e => e.DismissalDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dismissal_date");

                entity.Property(e => e.HiringDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("hiring_date");

                entity.Property(e => e.Middlename).HasColumnName("middlename");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Sex).HasColumnName("sex");

                entity.Property(e => e.Surname).HasColumnName("surname");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("client");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Middlename).HasColumnName("middlename");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Sex).HasColumnName("sex");

                entity.Property(e => e.Surname).HasColumnName("surname");
            });

            modelBuilder.Entity<Inspector>(entity =>
            {
                entity.ToTable("inspector");

                entity.Property(e => e.InspectorId).HasColumnName("inspector_id");

                entity.Property(e => e.DismissalDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dismissal_date");

                entity.Property(e => e.HiringDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("hiring_date");

                entity.Property(e => e.Middlename).HasColumnName("middlename");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Sex).HasColumnName("sex");

                entity.Property(e => e.Surname).HasColumnName("surname");
            });

            modelBuilder.Entity<Receptionist>(entity =>
            {
                entity.ToTable("receptionist");

                entity.Property(e => e.ReceptionistId).HasColumnName("receptionist_id");

                entity.Property(e => e.DismissalDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dismissal_date");

                entity.Property(e => e.HiringDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("hiring_date");

                entity.Property(e => e.Middlename).HasColumnName("middlename");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Sex).HasColumnName("sex");

                entity.Property(e => e.Surname).HasColumnName("surname");
            });

            modelBuilder.Entity<Wagon>(entity =>
            {
                entity.ToTable("wagon");

                entity.Property(e => e.WagonId).HasColumnName("wagon_id");

                entity.Property(e => e.CreationYear)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("creation_year");

                entity.Property(e => e.Model).HasColumnName("model");

                entity.Property(e => e.SeatsNumber).HasColumnName("seats_number");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(10)
                    .HasColumnName("serial_number")
                    .IsFixedLength();

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<WagonReceptionDoc>(entity =>
            {
                entity.HasKey(e => e.RecDocId)
                    .HasName("Unique_Identifier10");

                entity.ToTable("wagon_reception_doc");

                entity.HasIndex(e => e.ReceptionistId, "IX_receptionist_wagon_reception_doc");

                entity.HasIndex(e => e.ClientId, "IX_client_wagon_reception_doc");

                entity.HasIndex(e => e.WagonId, "IX_wagon_wagon_reception_doc");

                entity.Property(e => e.ApproxRepairDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("approx_repair_date");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("creation_date");

                entity.Property(e => e.Defect).HasColumnName("defect");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.RecDocId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("rec_doc_id");

                entity.Property(e => e.ReceptionDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("reception_date");

                entity.Property(e => e.ReceptionistId).HasColumnName("receptionist_id");

                entity.Property(e => e.WagonId).HasColumnName("wagon_id");
            });

            modelBuilder.Entity<WagonReturnDoc>(entity =>
            {
                entity.HasKey(e => e.ReturnDocId)
                    .HasName("Unique_Identifier11");

                entity.ToTable("wagon_return_doc");

                entity.HasIndex(e => e.BrigadierId, "IX_brigadier_wagon_return_doc");

                entity.HasIndex(e => e.ClientId, "IX_client_wagon_return_doc");

                entity.HasIndex(e => e.WagonId, "IX_wagon_wagon_return_doc");

                entity.Property(e => e.ReturnDocId).HasColumnName("return_doc_id");

                entity.Property(e => e.BrigadierId).HasColumnName("brigadier_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("creation_date");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.ReturnDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("return_date");

                entity.Property(e => e.WagonId).HasColumnName("wagon_id");

                entity.HasOne(d => d.Brigadier)
                    .WithMany(p => p.WagonReturnDocs)
                    .HasForeignKey(d => d.BrigadierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("brigadier_wagon_return_doc");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.WagonReturnDocs)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("client_wagon_return_doc");

                entity.HasOne(d => d.Wagon)
                    .WithMany(p => p.WagonReturnDocs)
                    .HasForeignKey(d => d.WagonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("wagon_wagon_return_doc");
            });

            modelBuilder.Entity<Work>(entity =>
            {
                entity.HasKey(e => new { e.WorkId, e.WorkOrderId })
                    .HasName("Unique_Identifier16");

                entity.ToTable("work");

                entity.HasIndex(e => e.BrigadeId, "IX_brigade_work");

                entity.HasIndex(e => e.WorkTypeId, "IX_work_type_work");

                entity.Property(e => e.WorkId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("work_id");

                entity.Property(e => e.WorkOrderId).HasColumnName("work_order_id");

                entity.Property(e => e.ActualDeadline)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("actual_deadline");

                entity.Property(e => e.BrigadeId).HasColumnName("brigade_id");

                entity.Property(e => e.PlannedDeadline)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("planned_deadline");

                entity.Property(e => e.WorkTypeId).HasColumnName("work_type_id");

                entity.HasOne(d => d.Brigade)
                    .WithMany(p => p.Works)
                    .HasForeignKey(d => d.BrigadeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("brigade_work");

                entity.HasOne(d => d.WorkOrder)
                    .WithMany(p => p.Works)
                    .HasForeignKey(d => d.WorkOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("work_order_work");

                entity.HasOne(d => d.WorkType)
                    .WithMany(p => p.Works)
                    .HasForeignKey(d => d.WorkTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("work_type_work");
            });

            modelBuilder.Entity<WorkOrder>(entity =>
            {
                entity.ToTable("work_order");

                entity.HasIndex(e => e.InspectorId, "IX_inspector_work_order");

                entity.HasIndex(e => e.WagonId, "IX_wagon_work_order");

                entity.Property(e => e.WorkOrderId).HasColumnName("work_order_id");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("creation_date");

                entity.Property(e => e.InspectorId).HasColumnName("inspector_id");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.WagonId).HasColumnName("wagon_id");

                entity.HasOne(d => d.Inspector)
                    .WithMany(p => p.WorkOrders)
                    .HasForeignKey(d => d.InspectorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("inspector_work_order");

                entity.HasOne(d => d.Wagon)
                    .WithMany(p => p.WorkOrders)
                    .HasForeignKey(d => d.WagonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("wagon_work_order");
            });

            modelBuilder.Entity<WorkType>(entity =>
            {
                entity.ToTable("work_type");

                entity.Property(e => e.WorkTypeId).HasColumnName("work_type_id");

                entity.Property(e => e.Name).HasColumnName("name");
            });

            modelBuilder.Entity<Worker>(entity =>
            {
                entity.ToTable("worker");

                entity.Property(e => e.WorkerId).HasColumnName("worker_id");

                entity.Property(e => e.DismissalDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dismissal_date");

                entity.Property(e => e.HiringDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("hiring_date");

                entity.Property(e => e.Middlename).HasColumnName("middlename");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Sex).HasColumnName("sex");

                entity.Property(e => e.Surname).HasColumnName("surname");
            });

            modelBuilder.Entity<WorkerBrigade>(entity =>
            {
                entity.HasKey(e => new { e.WorkerBrigadeId, e.WorkerId, e.BrigadeId })
                    .HasName("Unique_Identifier15");

                entity.ToTable("worker_brigade");

                entity.Property(e => e.WorkerBrigadeId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("worker_brigade_id");

                entity.Property(e => e.WorkerId).HasColumnName("worker_id");

                entity.Property(e => e.BrigadeId).HasColumnName("brigade_id");

                entity.HasOne(d => d.Brigade)
                    .WithMany(p => p.WorkerBrigades)
                    .HasForeignKey(d => d.BrigadeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("brigade_worker_brigade");

                entity.HasOne(d => d.Worker)
                    .WithMany(p => p.WorkerBrigades)
                    .HasForeignKey(d => d.WorkerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("worker_worker_brigade");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
