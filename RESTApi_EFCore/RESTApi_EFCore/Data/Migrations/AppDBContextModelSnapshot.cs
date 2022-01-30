﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RESTApi_EFCore.Data;

namespace RESTApi_EFCore.Data.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("RESTApi_EFCore.Models.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("LibelleQuestion")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.HasKey("QuestionId");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            QuestionId = 1,
                            LibelleQuestion = "Question1"
                        },
                        new
                        {
                            QuestionId = 2,
                            LibelleQuestion = "Question2"
                        },
                        new
                        {
                            QuestionId = 3,
                            LibelleQuestion = "Question3"
                        },
                        new
                        {
                            QuestionId = 4,
                            LibelleQuestion = "Question4"
                        },
                        new
                        {
                            QuestionId = 5,
                            LibelleQuestion = "Question5"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
