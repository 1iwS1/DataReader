﻿// <auto-generated />
using System;
using DataReader.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataReader.DataAccess.Migrations
{
    [DbContext(typeof(DataAzureContext))]
    [Migration("20240813112647_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataReader.DataAccess.Models.Log", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastSyncTime")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SyncResult")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id")
                        .HasName("PK_Logs_Id");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("DataReader.DataAccess.Models.Project", b =>
                {
                    b.Property<Guid>("ProjectSk")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ProjectSK");

                    b.Property<string>("AnalyticsUpdatedDate")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid?>("ProjectId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ProjectID");

                    b.Property<string>("ProjectName")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("ProjectVisibility")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ProjectSk")
                        .HasName("PK_Projects_Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("DataReader.DataAccess.Models.User", b =>
                {
                    b.Property<Guid>("UserSk")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("UserSK");

                    b.Property<string>("AnalyticsUpdatedDate")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("GitHubUserId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("UserName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UserType")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("UserSk")
                        .HasName("PK_Users_Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DataReader.DataAccess.Models.WorkItem", b =>
                {
                    b.Property<int>("WorkItemId")
                        .HasColumnType("int");

                    b.Property<Guid?>("ActivatedByUserSk")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ActivatedByUserSK");

                    b.Property<string>("ActivatedDate")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ActivatedDateSk")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("ActivatedDateSK");

                    b.Property<string>("AnalyticsUpdatedDate")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid?>("AreaSk")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("AreaSK");

                    b.Property<Guid?>("AssignedToUserSk")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("AssignedToUserSK");

                    b.Property<Guid?>("ChangedByUserSk")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ChangedByUserSK");

                    b.Property<string>("ChangedDate")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ChangedDateSk")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("ChangedDateSK");

                    b.Property<Guid?>("ClosedByUserSk")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ClosedByUserSK");

                    b.Property<string>("ClosedDate")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ClosedDateSk")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("ClosedDateSK");

                    b.Property<string>("CompletedDate")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CompletedDateSk")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("CompletedDateSK");

                    b.Property<decimal?>("CompletedWork")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<Guid?>("CreatedByUserSk")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CreatedByUserSK");

                    b.Property<string>("CreatedDate")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CreatedDateSk")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("CreatedDateSK");

                    b.Property<string>("Custom719f69f1002df7d0002d4baa002db6ce002de77ad5dfcdf3")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .HasColumnName("Custom_719f69f1__002Df7d0__002D4baa__002Db6ce__002De77ad5dfcdf3");

                    b.Property<string>("CustomCompany")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Custom_Company");

                    b.Property<string>("CustomEksternareferenca")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .HasColumnName("Custom_Eksternareferenca");

                    b.Property<string>("CustomItserviceorApplication")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .HasColumnName("Custom_ITServiceorApplication");

                    b.Property<string>("CustomStatusprojekta")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .HasColumnName("Custom_Statusprojekta");

                    b.Property<string>("CustomTicketNo")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Custom_TicketNo");

                    b.Property<string>("Effort")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("FinishDate")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("InProgressDate")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("InProgressDateSk")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("InProgressDateSK");

                    b.Property<Guid?>("IterationSk")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IterationSK");

                    b.Property<string>("OriginalEstimate")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("ParentWorkItemId")
                        .HasColumnType("int");

                    b.Property<int?>("Priority")
                        .HasColumnType("int");

                    b.Property<Guid?>("ProjectSk")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ProjectSK");

                    b.Property<string>("RemainingWork")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid?>("ResolvedByUserSk")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ResolvedByUserSK");

                    b.Property<string>("ResolvedDate")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ResolvedDateSk")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("ResolvedDateSK");

                    b.Property<string>("StartDate")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("State")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("StateChangeDate")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("StateChangeDateSk")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("StateChangeDateSK");

                    b.Property<string>("StoryPoints")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TagNames")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TargetDate")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("WorkItemRevisionSk")
                        .HasColumnType("int")
                        .HasColumnName("WorkItemRevisionSK");

                    b.Property<string>("WorkItemType")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("WorkItemId")
                        .HasName("PK_WorkItems_Id");

                    b.HasIndex("ActivatedByUserSk");

                    b.HasIndex("AssignedToUserSk");

                    b.HasIndex("ChangedByUserSk");

                    b.HasIndex("ClosedByUserSk");

                    b.HasIndex("CreatedByUserSk");

                    b.HasIndex("ProjectSk");

                    b.HasIndex("ResolvedByUserSk");

                    b.ToTable("WorkItems");
                });

            modelBuilder.Entity("DataReader.DataAccess.Models.WorkItem", b =>
                {
                    b.HasOne("DataReader.DataAccess.Models.User", "ActivatedByUserSkNavigation")
                        .WithMany("WorkItemActivatedByUserSkNavigations")
                        .HasForeignKey("ActivatedByUserSk")
                        .HasConstraintName("FK_WorkItems_ActivatedByUserSK");

                    b.HasOne("DataReader.DataAccess.Models.User", "AssignedToUserSkNavigation")
                        .WithMany("WorkItemAssignedToUserSkNavigations")
                        .HasForeignKey("AssignedToUserSk")
                        .HasConstraintName("FK_WorkItems_AssignedToUserSK");

                    b.HasOne("DataReader.DataAccess.Models.User", "ChangedByUserSkNavigation")
                        .WithMany("WorkItemChangedByUserSkNavigations")
                        .HasForeignKey("ChangedByUserSk")
                        .HasConstraintName("FK_WorkItems_ChangedByUserSK");

                    b.HasOne("DataReader.DataAccess.Models.User", "ClosedByUserSkNavigation")
                        .WithMany("WorkItemClosedByUserSkNavigations")
                        .HasForeignKey("ClosedByUserSk")
                        .HasConstraintName("FK_WorkItems_ClosedByUserSK");

                    b.HasOne("DataReader.DataAccess.Models.User", "CreatedByUserSkNavigation")
                        .WithMany("WorkItemCreatedByUserSkNavigations")
                        .HasForeignKey("CreatedByUserSk")
                        .HasConstraintName("FK_WorkItems_CreatedByUserSK");

                    b.HasOne("DataReader.DataAccess.Models.Project", "ProjectSkNavigation")
                        .WithMany("WorkItems")
                        .HasForeignKey("ProjectSk")
                        .HasConstraintName("FK_WorkItems_ProjectSK");

                    b.HasOne("DataReader.DataAccess.Models.User", "ResolvedByUserSkNavigation")
                        .WithMany("WorkItemResolvedByUserSkNavigations")
                        .HasForeignKey("ResolvedByUserSk")
                        .HasConstraintName("FK_WorkItems_ResolvedByUserSK");

                    b.Navigation("ActivatedByUserSkNavigation");

                    b.Navigation("AssignedToUserSkNavigation");

                    b.Navigation("ChangedByUserSkNavigation");

                    b.Navigation("ClosedByUserSkNavigation");

                    b.Navigation("CreatedByUserSkNavigation");

                    b.Navigation("ProjectSkNavigation");

                    b.Navigation("ResolvedByUserSkNavigation");
                });

            modelBuilder.Entity("DataReader.DataAccess.Models.Project", b =>
                {
                    b.Navigation("WorkItems");
                });

            modelBuilder.Entity("DataReader.DataAccess.Models.User", b =>
                {
                    b.Navigation("WorkItemActivatedByUserSkNavigations");

                    b.Navigation("WorkItemAssignedToUserSkNavigations");

                    b.Navigation("WorkItemChangedByUserSkNavigations");

                    b.Navigation("WorkItemClosedByUserSkNavigations");

                    b.Navigation("WorkItemCreatedByUserSkNavigations");

                    b.Navigation("WorkItemResolvedByUserSkNavigations");
                });
#pragma warning restore 612, 618
        }
    }
}
