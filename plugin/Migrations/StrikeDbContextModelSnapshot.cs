﻿// <auto-generated />
using System;
using BTCPayServer.Plugins.Strike.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BTCPayServer.Plugins.Strike.Migrations
{
    [DbContext(typeof(StrikeDbContext))]
    partial class StrikeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("BTCPayServer.Plugins.Strike")
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BTCPayServer.Plugins.Strike.Persistence.StrikePayment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTimeOffset?>("CompletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal?>("ConversionRate")
                        .HasColumnType("numeric");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal?>("FeeAmount")
                        .HasColumnType("numeric");

                    b.Property<string>("FeeCurrency")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("LightningInvoice")
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<string>("PaymentHash")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<string>("PaymentId")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<decimal>("RealBtcFeeAmount")
                        .HasColumnType("numeric");

                    b.Property<decimal>("RequestedBtcAmount")
                        .HasColumnType("numeric");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<decimal>("TargetAmount")
                        .HasColumnType("numeric");

                    b.Property<string>("TargetCurrency")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("TenantId")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.HasKey("Id");

                    b.ToTable("Payments", "BTCPayServer.Plugins.Strike");
                });

            modelBuilder.Entity("BTCPayServer.Plugins.Strike.Persistence.StrikeQuote", b =>
                {
                    b.Property<string>("InvoiceId")
                        .HasMaxLength(36)
                        .HasColumnType("character varying(36)");

                    b.Property<decimal>("ConversionRate")
                        .HasColumnType("numeric");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<DateTimeOffset>("ExpiresAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("LightningInvoice")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<bool>("Observed")
                        .HasColumnType("boolean");

                    b.Property<bool>("Paid")
                        .HasColumnType("boolean");

                    b.Property<string>("PaidConvertTo")
                        .HasColumnType("text");

                    b.Property<string>("PaymentHash")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<decimal>("RealBtcAmount")
                        .HasColumnType("numeric");

                    b.Property<decimal>("RequestedBtcAmount")
                        .HasColumnType("numeric");

                    b.Property<decimal>("TargetAmount")
                        .HasColumnType("numeric");

                    b.Property<string>("TargetCurrency")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("TenantId")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.HasKey("InvoiceId");

                    b.ToTable("Quotes", "BTCPayServer.Plugins.Strike");
                });
#pragma warning restore 612, 618
        }
    }
}
