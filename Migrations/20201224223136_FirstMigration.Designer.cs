﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using onnxModel;

namespace onnxModel.Migrations
{
    [DbContext(typeof(MyResultContext))]
    [Migration("20201224223136_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("onnxModel.ImgDetail", b =>
                {
                    b.Property<int>("ImgDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("RawImg")
                        .HasColumnType("BLOB");

                    b.HasKey("ImgDetailId");

                    b.ToTable("ImgDetails");
                });

            modelBuilder.Entity("onnxModel.Result", b =>
                {
                    b.Property<int>("ResultId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Confidence")
                        .HasColumnType("REAL");

                    b.Property<int>("CountReffered")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("DetailImgDetailId")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("Hash")
                        .HasColumnType("BLOB");

                    b.Property<string>("Label")
                        .HasColumnType("TEXT");

                    b.Property<string>("Path")
                        .HasColumnType("TEXT");

                    b.HasKey("ResultId");

                    b.HasIndex("DetailImgDetailId");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("onnxModel.Result", b =>
                {
                    b.HasOne("onnxModel.ImgDetail", "Detail")
                        .WithMany()
                        .HasForeignKey("DetailImgDetailId");

                    b.Navigation("Detail");
                });
#pragma warning restore 612, 618
        }
    }
}