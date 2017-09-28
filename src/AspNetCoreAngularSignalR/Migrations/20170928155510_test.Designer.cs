﻿// <auto-generated />
using AspNetCoreAngularSignalR.Providers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace AspNetCoreAngularSignalR.Migrations
{
    [DbContext(typeof(NewsContext))]
    [Migration("20170928155510_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("AspNetCoreAngularSignalR.Providers.NewsItemEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<string>("Header");

                    b.Property<string>("NewsGroup");

                    b.Property<string>("NewsText");

                    b.HasKey("Id");

                    b.ToTable("NewsItemEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
