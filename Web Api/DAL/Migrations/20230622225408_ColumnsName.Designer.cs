﻿// <auto-generated />
using System;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(FoodyContext))]
    [Migration("20230622225408_ColumnsName")]
    partial class ColumnsName
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("Latin1_General_CI_AS")
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DAL.Models.AuthUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("id");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("address");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("email");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("DAL.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("ChefId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime")
                        .HasColumnName("delivery_date");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("location");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime")
                        .HasColumnName("order_date");

                    b.Property<int?>("PostAcceptedOrderId")
                        .HasColumnType("int");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int")
                        .HasColumnName("total_price");

                    b.Property<string>("UserMobile")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("user_mobile");

                    b.HasKey("Id");

                    b.HasIndex("ChefId");

                    b.HasIndex("PostAcceptedOrderId");

                    b.HasIndex("UserMobile");

                    b.ToTable("Cart", (string)null);
                });

            modelBuilder.Entity("DAL.Models.CartMenuItem", b =>
                {
                    b.Property<int>("MenuItemId")
                        .HasColumnType("int")
                        .HasColumnName("Menu_item_id");

                    b.Property<int>("CartId")
                        .HasColumnType("int")
                        .HasColumnName("Cart_id");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("TotalItemPrice")
                        .HasColumnType("int")
                        .HasColumnName("total_item_price");

                    b.HasKey("MenuItemId", "CartId");

                    b.HasIndex("CartId");

                    b.ToTable("Cart/MenuItems", (string)null);
                });

            modelBuilder.Entity("DAL.Models.Feedback", b =>
                {
                    b.Property<string>("UserId")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("user_id");

                    b.Property<string>("ChefId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("chef_id");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime")
                        .HasColumnName("date");

                    b.Property<double>("Rating")
                        .HasColumnType("float")
                        .HasColumnName("rating");

                    b.Property<string>("Review")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("review");

                    b.HasKey("UserId", "ChefId");

                    b.HasIndex("ChefId");

                    b.ToTable("feedback", (string)null);
                });

            modelBuilder.Entity("DAL.Models.MenuItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Availability")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("availability");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChefId")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("chef_id");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<int>("Likes")
                        .HasColumnType("int")
                        .HasColumnName("likes");

                    b.Property<string>("Media")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("media");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<int?>("PrepTimeMin")
                        .HasColumnType("int")
                        .HasColumnName("prep_time(min)");

                    b.Property<int>("UnitPriceLE")
                        .HasColumnType("int")
                        .HasColumnName("unit_price(L.E)");

                    b.HasKey("Id");

                    b.ToTable("Menu_item", (string)null);
                });

            modelBuilder.Entity("DAL.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("date")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Description")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("description");

                    b.Property<int?>("FromPrice")
                        .HasColumnType("int")
                        .HasColumnName("from_price");

                    b.Property<string>("Media")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("media");

                    b.Property<string>("PostState")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PrepTimeMin")
                        .HasColumnType("int")
                        .HasColumnName("prep_time_min");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.Property<string>("QuantityUnit")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("quantity_unit");

                    b.Property<int?>("ToPrice")
                        .HasColumnType("int")
                        .HasColumnName("to_price");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Post", (string)null);
                });

            modelBuilder.Entity("DAL.Models.PostAcceptedOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdditionalInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChefId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FinalPrice")
                        .HasColumnType("int");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<int>("PreparationTime_min")
                        .HasColumnType("int");

                    b.Property<int>("ProposalId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("QuantityUnit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ChefId")
                        .IsUnique();

                    b.HasIndex("PostId")
                        .IsUnique();

                    b.HasIndex("ProposalId")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("PostAcceptedOrder");
                });

            modelBuilder.Entity("DAL.Models.Proposal", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("ChefId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("chef_id");

                    b.Property<DateTime>("Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("date")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<string>("Media")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("media");

                    b.Property<int>("PostId")
                        .HasColumnType("int")
                        .HasColumnName("post_id");

                    b.Property<int>("PrepTimeMin")
                        .HasColumnType("int")
                        .HasColumnName("prep_time_min");

                    b.Property<int>("Price")
                        .HasColumnType("int")
                        .HasColumnName("price");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.HasIndex("ChefId");

                    b.HasIndex("PostId");

                    b.ToTable("Proposal", (string)null);
                });

            modelBuilder.Entity("MenuItemUser", b =>
                {
                    b.Property<int>("LikedMenuItemId")
                        .HasColumnType("int");

                    b.Property<string>("UserLikingItId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LikedMenuItemId", "UserLikingItId");

                    b.HasIndex("UserLikingItId");

                    b.ToTable("MenuItemUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("DAL.Models.Chef", b =>
                {
                    b.HasBaseType("DAL.Models.AuthUser");

                    b.Property<string>("Media")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("media");

                    b.Property<decimal?>("Rating")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("rating");

                    b.ToTable("Chef", (string)null);
                });

            modelBuilder.Entity("DAL.Models.User", b =>
                {
                    b.HasBaseType("DAL.Models.AuthUser");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("gender");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("DAL.Models.Cart", b =>
                {
                    b.HasOne("DAL.Models.Chef", "Chef")
                        .WithMany("Carts")
                        .HasForeignKey("ChefId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired()
                        .HasConstraintName("FK_Cart_Chef");

                    b.HasOne("DAL.Models.PostAcceptedOrder", "PostAcceptedOrder")
                        .WithMany()
                        .HasForeignKey("PostAcceptedOrderId");

                    b.HasOne("DAL.Models.User", "UserMobileNavigation")
                        .WithMany("Carts")
                        .HasForeignKey("UserMobile")
                        .IsRequired()
                        .HasConstraintName("FK_Cart_User");

                    b.Navigation("Chef");

                    b.Navigation("PostAcceptedOrder");

                    b.Navigation("UserMobileNavigation");
                });

            modelBuilder.Entity("DAL.Models.CartMenuItem", b =>
                {
                    b.HasOne("DAL.Models.Cart", "Cart")
                        .WithMany("CartMenuItems")
                        .HasForeignKey("CartId")
                        .IsRequired()
                        .HasConstraintName("FK_Cart/MenuItems_Cart");

                    b.HasOne("DAL.Models.MenuItem", "MenuItem")
                        .WithMany("CartMenuItems")
                        .HasForeignKey("MenuItemId")
                        .IsRequired()
                        .HasConstraintName("FK_Cart/MenuItems_Menu_item");

                    b.Navigation("Cart");

                    b.Navigation("MenuItem");
                });

            modelBuilder.Entity("DAL.Models.Feedback", b =>
                {
                    b.HasOne("DAL.Models.Chef", "Chef")
                        .WithMany("Feedbacks")
                        .HasForeignKey("ChefId")
                        .IsRequired()
                        .HasConstraintName("FK_feedback_Chef");

                    b.HasOne("DAL.Models.User", "User")
                        .WithMany("Feedbacks")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_feedback_User");

                    b.Navigation("Chef");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAL.Models.Post", b =>
                {
                    b.HasOne("DAL.Models.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Post_User");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAL.Models.PostAcceptedOrder", b =>
                {
                    b.HasOne("DAL.Models.Chef", "Chef")
                        .WithOne("PostAcceptedOrder")
                        .HasForeignKey("DAL.Models.PostAcceptedOrder", "ChefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Models.Post", "Post")
                        .WithOne("PostAcceptedOrder")
                        .HasForeignKey("DAL.Models.PostAcceptedOrder", "PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Models.Proposal", "Proposal")
                        .WithOne("PostAcceptedOrder")
                        .HasForeignKey("DAL.Models.PostAcceptedOrder", "ProposalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Models.User", "User")
                        .WithOne("PostAcceptedOrder")
                        .HasForeignKey("DAL.Models.PostAcceptedOrder", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chef");

                    b.Navigation("Post");

                    b.Navigation("Proposal");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAL.Models.Proposal", b =>
                {
                    b.HasOne("DAL.Models.Chef", "Chef")
                        .WithMany("Proposals")
                        .HasForeignKey("ChefId")
                        .IsRequired()
                        .HasConstraintName("FK_Proposal_Chef");

                    b.HasOne("DAL.Models.Post", "Post")
                        .WithMany("Proposals")
                        .HasForeignKey("PostId")
                        .IsRequired()
                        .HasConstraintName("FK_Proposal_Post");

                    b.Navigation("Chef");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("MenuItemUser", b =>
                {
                    b.HasOne("DAL.Models.MenuItem", null)
                        .WithMany()
                        .HasForeignKey("LikedMenuItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserLikingItId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DAL.Models.AuthUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DAL.Models.AuthUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Models.AuthUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DAL.Models.AuthUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.Models.Chef", b =>
                {
                    b.HasOne("DAL.Models.AuthUser", null)
                        .WithOne()
                        .HasForeignKey("DAL.Models.Chef", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.Models.User", b =>
                {
                    b.HasOne("DAL.Models.AuthUser", null)
                        .WithOne()
                        .HasForeignKey("DAL.Models.User", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.Models.Cart", b =>
                {
                    b.Navigation("CartMenuItems");
                });

            modelBuilder.Entity("DAL.Models.MenuItem", b =>
                {
                    b.Navigation("CartMenuItems");
                });

            modelBuilder.Entity("DAL.Models.Post", b =>
                {
                    b.Navigation("PostAcceptedOrder")
                        .IsRequired();

                    b.Navigation("Proposals");
                });

            modelBuilder.Entity("DAL.Models.Proposal", b =>
                {
                    b.Navigation("PostAcceptedOrder")
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.Models.Chef", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Feedbacks");

                    b.Navigation("PostAcceptedOrder")
                        .IsRequired();

                    b.Navigation("Proposals");
                });

            modelBuilder.Entity("DAL.Models.User", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Feedbacks");

                    b.Navigation("PostAcceptedOrder")
                        .IsRequired();

                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
