﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StarkFamily.Data;

namespace StarkFamily.Migrations
{
    [DbContext(typeof(FamilyContext))]
    partial class FamilyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StarkFamily.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeathDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FatherId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MotherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FatherId");

                    b.HasIndex("MotherId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("StarkFamily.Models.Person", b =>
                {
                    b.HasOne("StarkFamily.Models.Person", "Father")
                        .WithMany("FatherChildren")
                        .HasForeignKey("FatherId");

                    b.HasOne("StarkFamily.Models.Person", "Mother")
                        .WithMany("MotherChildren")
                        .HasForeignKey("MotherId");

                    b.Navigation("Father");

                    b.Navigation("Mother");
                });

            modelBuilder.Entity("StarkFamily.Models.Person", b =>
                {
                    b.Navigation("FatherChildren");

                    b.Navigation("MotherChildren");
                });
#pragma warning restore 612, 618
        }
    }
}
