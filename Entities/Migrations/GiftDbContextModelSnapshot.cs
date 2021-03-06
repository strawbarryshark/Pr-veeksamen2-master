﻿// <auto-generated />
using System;
using Entities.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Entities.Migrations
{
    [DbContext(typeof(GiftDbContext))]
    partial class GiftDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Gift", b =>
                {
                    b.Property<Guid>("GiftNumber")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("BoyGift");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<bool>("GirlGift");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("GiftNumber");

                    b.ToTable("Gifts");
                });
#pragma warning restore 612, 618
        }
    }
}
