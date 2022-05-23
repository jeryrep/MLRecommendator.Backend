﻿// <auto-generated />
using MLRecommendator.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MLRecommendator.Database.Migrations
{
    [DbContext(typeof(MalContext))]
    partial class MalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("MLRecommendator.Database.Models.Anime", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Action")
                        .HasColumnType("REAL");

                    b.Property<float>("AdultCast")
                        .HasColumnType("REAL");

                    b.Property<float>("Adventure")
                        .HasColumnType("REAL");

                    b.Property<ushort>("AverageEpisodeDuration")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Comedy")
                        .HasColumnType("REAL");

                    b.Property<float>("Drama")
                        .HasColumnType("REAL");

                    b.Property<float>("Ecchi")
                        .HasColumnType("REAL");

                    b.Property<ushort>("EpisodeNumber")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Fantasy")
                        .HasColumnType("REAL");

                    b.Property<string>("Genres")
                        .HasColumnType("TEXT");

                    b.Property<float>("Historical")
                        .HasColumnType("REAL");

                    b.Property<float>("Isekai")
                        .HasColumnType("REAL");

                    b.Property<float>("Mean")
                        .HasColumnType("REAL");

                    b.Property<float>("Military")
                        .HasColumnType("REAL");

                    b.Property<float>("Mystery")
                        .HasColumnType("REAL");

                    b.Property<string>("Nsfw")
                        .HasColumnType("TEXT");

                    b.Property<uint>("Popularity")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Psychological")
                        .HasColumnType("REAL");

                    b.Property<uint>("Rank")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Rating")
                        .HasColumnType("TEXT");

                    b.Property<float>("Romance")
                        .HasColumnType("REAL");

                    b.Property<float>("School")
                        .HasColumnType("REAL");

                    b.Property<float>("SciFi")
                        .HasColumnType("REAL");

                    b.Property<float>("Seinen")
                        .HasColumnType("REAL");

                    b.Property<float>("Shounen")
                        .HasColumnType("REAL");

                    b.Property<float>("SliceOfLife")
                        .HasColumnType("REAL");

                    b.Property<string>("Source")
                        .HasColumnType("TEXT");

                    b.Property<float>("Space")
                        .HasColumnType("REAL");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.Property<string>("Studios")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<uint>("UsersNumber")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("UsersScoringNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Animes");
                });

            modelBuilder.Entity("MLRecommendator.Database.Models.UserSerie", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte>("Score")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("UserSeries");
                });
#pragma warning restore 612, 618
        }
    }
}
