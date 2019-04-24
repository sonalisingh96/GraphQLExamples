﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Data;

namespace WebApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApi.Data.Models.Employee", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Company");

                    b.Property<string>("Email");

                    b.Property<string>("LongDescription");

                    b.Property<string>("Mobile");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("ShortDescription");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Address = "Bangalore",
                            Company = "Siemens",
                            Email = "sonalisingh7639@gmail.com",
                            LongDescription = "shutterstock_66842440.jpg",
                            Mobile = "8851490003",
                            Name = "Sonali singh",
                            ShortDescription = "Hi"
                        },
                        new
                        {
                            Id = 2L,
                            Address = "Bangalore1",
                            Company = "Siemens1",
                            Email = "sonalisingh7639@gmail.com1",
                            LongDescription = "shutterstock_66842440.jpg1",
                            Mobile = "88514900031",
                            Name = "Mountain Walkers",
                            ShortDescription = "Hi1"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
