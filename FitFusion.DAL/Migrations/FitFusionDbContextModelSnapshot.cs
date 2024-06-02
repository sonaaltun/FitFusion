﻿// <auto-generated />
using System;
using FitFusion.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FitFusion.DAL.Migrations
{
    [DbContext(typeof(FitFusionDbContext))]
    partial class FitFusionDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FitFusion.Entity.NewEntity.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Statu")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("af1687df-c60e-4616-90ea-caef4ea70a68"),
                            CategoryName = "Çorbalar",
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Çorbalar, sağlıklı bir diyetin önemli bir parçasıdır. Sebzelerden yapılan çorbalar düşük kalorili, yüksek lifli ve besleyicidir. Ayrıca sindirimi kolaydır ve tokluk hissini artırabilir.",
                            Statu = 1
                        },
                        new
                        {
                            Id = new Guid("3dcfb7b0-c6bb-4926-b762-f0c60ae67755"),
                            CategoryName = "Salatalar",
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Salatalar, sağlıklı bir diyetin vazgeçilmez bir parçasıdır. Bol miktarda çeşitli sebzelerle hazırlanabilirler. Renkli sebzelerle yapılan salatalar, vitamin ve mineral bakımından zengindir ve düşük kalorilidir.",
                            Statu = 1
                        },
                        new
                        {
                            Id = new Guid("e5cdd13e-3ece-4b6c-bd95-787bea44f14a"),
                            CategoryName = "Protein Kaynakları",
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Protein kaynakları, kas gelişimi ve tamirinde önemli bir rol oynar. Tavuk, balık, hindi, yumurta, tofu, baklagiller gibi çeşitli protein kaynakları tercih edilebilir. Dengeli bir diyet için protein alımı önemlidir.",
                            Statu = 1
                        },
                        new
                        {
                            Id = new Guid("65ac7d6a-d757-4f6e-ad6a-0de0f48f4efa"),
                            CategoryName = "Tam Tahıllar",
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Tam tahıllar, lif, vitamin ve mineral bakımından zengin ve sindirimi yavaşlatır. Buğday, arpa, çavdar, yulaf gibi tam tahıllar, kan şekerini dengeler ve uzun süre tokluk sağlar.",
                            Statu = 1
                        },
                        new
                        {
                            Id = new Guid("59518bd3-01bb-48d9-8aba-b144a5bb4e5b"),
                            CategoryName = "Sebzeler",
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Sebzeler, düşük kalorili, lif bakımından zengin ve vitamin ile mineral deposudur. Renkli sebzeler, antioksidanlar açısından zengin olup bağışıklık sistemini güçlendirir. Her öğünde çeşitli sebzeler tüketmek önemlidir.",
                            Statu = 1
                        },
                        new
                        {
                            Id = new Guid("8b21e221-5e57-4f55-b364-9f438b1672d4"),
                            CategoryName = "Meyveler",
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Meyveler, doğal şeker ve lif kaynağıdır. Renkli meyveler, antioksidanlar içerir ve sindirimi kolaydır. Taze veya dondurulmuş meyveler, sağlıklı bir atıştırmalık veya tatlı alternatifi olarak tercih edilebilir.",
                            Statu = 1
                        },
                        new
                        {
                            Id = new Guid("7e095b2f-c0f9-40ad-939e-541fe9a82466"),
                            CategoryName = "Atıştırmalıklar",
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Sağlıklı atıştırmalıklar, açlık hissini bastırırken besin değerini artırır. Fındık, yoğurt, tam tahıllı krakerler, meyve dilimleri gibi besleyici atıştırmalıklar tercih edilmelidir.",
                            Statu = 1
                        });
                });

            modelBuilder.Entity("FitFusion.Entity.NewEntity.CategoryFood", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CaloriesPerServing")
                        .HasColumnType("int");

                    b.Property<double>("Carbonhydrat")
                        .HasColumnType("float");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Fat")
                        .HasColumnType("float");

                    b.Property<Guid>("FoodId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Protein")
                        .HasColumnType("float");

                    b.Property<int>("Statu")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("FoodId");

                    b.HasIndex("UserId");

                    b.ToTable("FoodCategories");
                });

            modelBuilder.Entity("FitFusion.Entity.NewEntity.Food", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CaloriesPerServing")
                        .HasColumnType("int");

                    b.Property<double>("Carbonhydrat")
                        .HasColumnType("float");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Fat")
                        .HasColumnType("float");

                    b.Property<byte[]>("ImageData")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Protein")
                        .HasColumnType("float");

                    b.Property<int>("Statu")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("FitFusion.Entity.NewEntity.Portion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PortionType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Statu")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Portions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("62320368-048f-4dcb-8e18-957a74e20d71"),
                            Amount = 400,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PortionType = "Kase",
                            Statu = 1
                        },
                        new
                        {
                            Id = new Guid("bf6c7395-0fe9-4984-81fe-92da5fc17e0d"),
                            Amount = 100,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PortionType = "100 gr",
                            Statu = 1
                        });
                });

            modelBuilder.Entity("FitFusion.Entity.NewEntity.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Statu")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UserDetailId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserDetailId")
                        .IsUnique()
                        .HasFilter("[UserDetailId] IS NOT NULL");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b4411e7a-618c-4400-be4d-a29075f2dc12"),
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "admin",
                            IsAdmin = true,
                            LastName = "admin",
                            Mail = "admin",
                            Password = " ",
                            Statu = 1
                        });
                });

            modelBuilder.Entity("FitFusion.Entity.NewEntity.UserDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<int>("Statu")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("UserDetails");
                });

            modelBuilder.Entity("FitFusion.Entity.NewEntity.UserFood", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("FoodId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PortionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Statu")
                        .HasColumnType("int");

                    b.Property<int>("TotalCalories")
                        .HasColumnType("int");

                    b.Property<double>("TotalCarbonhydrat")
                        .HasColumnType("float");

                    b.Property<double>("TotalFat")
                        .HasColumnType("float");

                    b.Property<double>("TotalProtein")
                        .HasColumnType("float");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserMealId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("FoodId");

                    b.HasIndex("PortionId");

                    b.HasIndex("UserMealId");

                    b.ToTable("UserFood");
                });

            modelBuilder.Entity("FitFusion.Entity.NewEntity.UserMeal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("MealTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("MealType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Statu")
                        .HasColumnType("int");

                    b.Property<int>("TotalCalories")
                        .HasColumnType("int");

                    b.Property<double>("TotalCarbonhydrat")
                        .HasColumnType("float");

                    b.Property<double>("TotalFat")
                        .HasColumnType("float");

                    b.Property<double>("TotalProtein")
                        .HasColumnType("float");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserMeals");
                });

            modelBuilder.Entity("FitFusion.Entity.NewEntity.CategoryFood", b =>
                {
                    b.HasOne("FitFusion.Entity.NewEntity.Category", "Category")
                        .WithMany("CategoryFoods")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitFusion.Entity.NewEntity.Food", "Food")
                        .WithMany("CategoryFood")
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitFusion.Entity.NewEntity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Category");

                    b.Navigation("Food");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FitFusion.Entity.NewEntity.User", b =>
                {
                    b.HasOne("FitFusion.Entity.NewEntity.UserDetail", "UserDetail")
                        .WithOne("User")
                        .HasForeignKey("FitFusion.Entity.NewEntity.User", "UserDetailId");

                    b.Navigation("UserDetail");
                });

            modelBuilder.Entity("FitFusion.Entity.NewEntity.UserFood", b =>
                {
                    b.HasOne("FitFusion.Entity.NewEntity.Food", "Food")
                        .WithMany()
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitFusion.Entity.NewEntity.Portion", "Portion")
                        .WithMany("UserFoods")
                        .HasForeignKey("PortionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitFusion.Entity.NewEntity.UserMeal", "UserMeal")
                        .WithMany("UserFoods")
                        .HasForeignKey("UserMealId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Food");

                    b.Navigation("Portion");

                    b.Navigation("UserMeal");
                });

            modelBuilder.Entity("FitFusion.Entity.NewEntity.UserMeal", b =>
                {
                    b.HasOne("FitFusion.Entity.NewEntity.User", "User")
                        .WithMany("UserMeals")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FitFusion.Entity.NewEntity.Category", b =>
                {
                    b.Navigation("CategoryFoods");
                });

            modelBuilder.Entity("FitFusion.Entity.NewEntity.Food", b =>
                {
                    b.Navigation("CategoryFood");
                });

            modelBuilder.Entity("FitFusion.Entity.NewEntity.Portion", b =>
                {
                    b.Navigation("UserFoods");
                });

            modelBuilder.Entity("FitFusion.Entity.NewEntity.User", b =>
                {
                    b.Navigation("UserMeals");
                });

            modelBuilder.Entity("FitFusion.Entity.NewEntity.UserDetail", b =>
                {
                    b.Navigation("User")
                        .IsRequired();
                });

            modelBuilder.Entity("FitFusion.Entity.NewEntity.UserMeal", b =>
                {
                    b.Navigation("UserFoods");
                });
#pragma warning restore 612, 618
        }
    }
}