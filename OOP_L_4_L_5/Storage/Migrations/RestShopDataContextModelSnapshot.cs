﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OOP_L_4_L_5.Storage;

namespace OOP_L_4_L_5.Storage.Migrations
{
    [DbContext(typeof(RestShopDataContext))]
    partial class RestShopDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OOP_L_4_L_5.Storage.Entity.Anime", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("gId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AnimeType")
                        .HasColumnName("enAnimeType")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnName("dtDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EpisodesCount")
                        .HasColumnName("intEpisodesCount")
                        .HasColumnType("int");

                    b.Property<int>("Genre")
                        .HasColumnName("enGenre")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("szName")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Studio")
                        .IsRequired()
                        .HasColumnName("szStudio")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("tblAnime");
                });

            modelBuilder.Entity("OOP_L_4_L_5.Storage.Entity.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("gId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnName("szAuthor")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("BookType")
                        .HasColumnName("enBookType")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnName("dtDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Genre")
                        .HasColumnName("enGenres")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("szName")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<int>("PageCount")
                        .HasColumnName("intPageCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("tblBook");
                });

            modelBuilder.Entity("OOP_L_4_L_5.Storage.Entity.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("gId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("szEmail")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("szName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnName("szTelephone")
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.HasKey("Id");

                    b.ToTable("tblClient");
                });

            modelBuilder.Entity("OOP_L_4_L_5.Storage.Entity.Figure", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("gId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("szName")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<int>("Scale")
                        .HasColumnName("intScale")
                        .HasColumnType("int");

                    b.Property<string>("Source")
                        .HasColumnName("szSource")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<int>("Weight")
                        .HasColumnName("intWeight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("tblFigure");
                });

            modelBuilder.Entity("OOP_L_4_L_5.Storage.Entity.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("gId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClientId")
                        .HasColumnName("gClientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfCompletion")
                        .HasColumnName("dtDateOfCompletion")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderStatus")
                        .HasColumnName("enOrderStatus")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("tblOrder");
                });

            modelBuilder.Entity("OOP_L_4_L_5.Storage.Entity.PaymentInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("gId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasColumnName("szCardNumber")
                        .HasColumnType("nvarchar(16)")
                        .HasMaxLength(16);

                    b.Property<Guid>("ClientId")
                        .HasColumnName("gClientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cvc")
                        .IsRequired()
                        .HasColumnName("szCvc")
                        .HasColumnType("nvarchar(3)")
                        .HasMaxLength(3);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("szName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("tblPaymentInfo");
                });

            modelBuilder.Entity("OOP_L_4_L_5.Storage.Entity.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("gId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AnimeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CountInStock")
                        .HasColumnName("intCountInStock")
                        .HasColumnType("int");

                    b.Property<Guid?>("FigureId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MatterId")
                        .HasColumnName("gMatterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Price")
                        .HasColumnName("intPrice")
                        .HasColumnType("int");

                    b.Property<int>("ProductType")
                        .HasColumnName("enProductType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AnimeId");

                    b.HasIndex("BookId");

                    b.HasIndex("FigureId");

                    b.ToTable("tblProduct");
                });

            modelBuilder.Entity("OOP_L_4_L_5.Storage.OrderProduct", b =>
                {
                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderProducts");
                });

            modelBuilder.Entity("OOP_L_4_L_5.Storage.Entity.Order", b =>
                {
                    b.HasOne("OOP_L_4_L_5.Storage.Entity.Client", "Client")
                        .WithMany("Orders")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OOP_L_4_L_5.Storage.Entity.PaymentInfo", b =>
                {
                    b.HasOne("OOP_L_4_L_5.Storage.Entity.Client", "Client")
                        .WithMany("PaymentInfos")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OOP_L_4_L_5.Storage.Entity.Product", b =>
                {
                    b.HasOne("OOP_L_4_L_5.Storage.Entity.Anime", "Anime")
                        .WithMany()
                        .HasForeignKey("AnimeId");

                    b.HasOne("OOP_L_4_L_5.Storage.Entity.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId");

                    b.HasOne("OOP_L_4_L_5.Storage.Entity.Figure", "Figure")
                        .WithMany()
                        .HasForeignKey("FigureId");
                });

            modelBuilder.Entity("OOP_L_4_L_5.Storage.OrderProduct", b =>
                {
                    b.HasOne("OOP_L_4_L_5.Storage.Entity.Order", "Order")
                        .WithMany("OrderProducts")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OOP_L_4_L_5.Storage.Entity.Product", "Product")
                        .WithMany("OrderProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
