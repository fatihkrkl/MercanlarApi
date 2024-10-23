﻿// <auto-generated />
using MercanlarApi.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MercanlarApi.Migrations
{
    [DbContext(typeof(MercanDb))]
    partial class MercanDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0-rc.2.24474.1");

            modelBuilder.Entity("MercanlarApi.Database.Entities.Arac", b =>
                {
                    b.Property<string>("Plaka")
                        .HasColumnType("TEXT");

                    b.Property<string>("Per")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Sofor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Sube")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Plaka");

                    b.ToTable("AracList");
                });
#pragma warning restore 612, 618
        }
    }
}
