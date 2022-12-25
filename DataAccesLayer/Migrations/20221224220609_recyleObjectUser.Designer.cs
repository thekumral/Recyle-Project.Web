﻿// <auto-generated />
using DataAccesLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataAccesLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20221224220609_recyleObjectUser")]
    partial class recyleObjectUser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EntityLayer.Concrete.CoinCollectionPoint", b =>
                {
                    b.Property<int>("CoinTotal")
                        .HasColumnType("integer");

                    b.Property<int>("NameId")
                        .HasColumnType("integer");

                    b.ToTable("coinCollectionPoints");
                });

            modelBuilder.Entity("EntityLayer.Concrete.RecyleObjects", b =>
                {
                    b.Property<int>("ObjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ObjectID"));

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ReName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ReValue")
                        .HasColumnType("integer");

                    b.Property<int>("RecyleObjectUser")
                        .HasColumnType("integer");

                    b.Property<string>("Reİnfo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TypeID")
                        .HasColumnType("integer");

                    b.Property<string>("quotes")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ObjectID");

                    b.HasIndex("TypeID");

                    b.ToTable("recyleObjects");
                });

            modelBuilder.Entity("EntityLayer.Concrete.RecyleTypes", b =>
                {
                    b.Property<int>("TypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TypeID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("TypeID");

                    b.ToTable("recyletypes");
                });

            modelBuilder.Entity("EntityLayer.Concrete.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserID"));

                    b.Property<string>("ProfileImage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ReValueWallet")
                        .HasColumnType("integer");

                    b.Property<string>("SendAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SendValue")
                        .HasColumnType("integer");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("phoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("walletAddress")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.HasKey("UserID");

                    b.ToTable("users");
                });

            modelBuilder.Entity("EntityLayer.Concrete.RecyleObjects", b =>
                {
                    b.HasOne("EntityLayer.Concrete.RecyleTypes", "Recyletype")
                        .WithMany()
                        .HasForeignKey("TypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recyletype");
                });
#pragma warning restore 612, 618
        }
    }
}
