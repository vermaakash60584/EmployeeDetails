﻿// <auto-generated />
using System;
using EmployeeDetails.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeDetails.Migrations
{
    [DbContext(typeof(EmployeeDetailsContext))]
    partial class EmployeeDetailsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployeeDetails.Models.Employee", b =>
                {
                    b.Property<int>("EId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EDOJ")
                        .HasColumnType("datetime2");

                    b.Property<string>("EDesignation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EId");

                    b.ToTable("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
