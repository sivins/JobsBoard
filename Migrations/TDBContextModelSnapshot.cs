using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using reverseJobsBoard.Models;

namespace reverseJobsBoard.Migrations
{
    [DbContext(typeof(TDBContext))]
    partial class TDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("reverseJobsBoard.Models.User", b =>
                {
                    b.Property<Guid>("UserID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.Property<string>("email");

                    b.Property<string>("first_name");

                    b.Property<string>("last_name");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });
        }
    }
}
