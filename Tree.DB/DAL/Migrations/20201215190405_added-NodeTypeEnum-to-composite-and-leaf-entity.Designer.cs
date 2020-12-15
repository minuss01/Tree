﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tree.DB.DAL;

namespace Tree.DB.Migrations
{
    [DbContext(typeof(TreeContext))]
    [Migration("20201215190405_added-NodeTypeEnum-to-composite-and-leaf-entity")]
    partial class addedNodeTypeEnumtocompositeandleafentity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Tree.DB.Entities.Composite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompositeParentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompositeParentId");

                    b.ToTable("Composities");
                });

            modelBuilder.Entity("Tree.DB.Entities.Leaf", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompositeParentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompositeParentId");

                    b.ToTable("Leaves");
                });

            modelBuilder.Entity("Tree.DB.Entities.Composite", b =>
                {
                    b.HasOne("Tree.DB.Entities.Composite", "CompositeParent")
                        .WithMany("Composites")
                        .HasForeignKey("CompositeParentId");
                });

            modelBuilder.Entity("Tree.DB.Entities.Leaf", b =>
                {
                    b.HasOne("Tree.DB.Entities.Composite", "CompositeParent")
                        .WithMany("Leaves")
                        .HasForeignKey("CompositeParentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}