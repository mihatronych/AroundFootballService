﻿// <auto-generated />
using System;
using AroundFootballService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AroundFootballService.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AroundFootballService.Data.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AdditionInformation")
                        .HasColumnType("text");

                    b.Property<int>("EventType")
                        .HasColumnType("integer");

                    b.Property<int>("GameId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDoneByHomeTeam")
                        .HasColumnType("boolean");

                    b.Property<int>("Minute")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("AroundFootballService.Data.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AwayTeamResult")
                        .HasColumnType("integer");

                    b.Property<int>("HomeTeamResult")
                        .HasColumnType("integer");

                    b.Property<bool>("IsStarted")
                        .HasColumnType("boolean");

                    b.Property<int>("ParticipantAwayId")
                        .HasColumnType("integer");

                    b.Property<int>("ParticipantHomeId")
                        .HasColumnType("integer");

                    b.Property<int>("Stage")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ParticipantAwayId");

                    b.HasIndex("ParticipantHomeId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("AroundFootballService.Data.Models.Participant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Group")
                        .HasColumnType("integer");

                    b.Property<int>("TeamId")
                        .HasColumnType("integer");

                    b.Property<int>("TournamentId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.HasIndex("TournamentId");

                    b.ToTable("Participants");
                });

            modelBuilder.Entity("AroundFootballService.Data.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Postiton")
                        .HasColumnType("integer");

                    b.Property<int>("TeamId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("AroundFootballService.Data.Models.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("AroundFootballService.Data.Models.StartingGrid", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CurrentPostion")
                        .HasColumnType("integer");

                    b.Property<int>("GamesId")
                        .HasColumnType("integer");

                    b.Property<int>("GridPostion")
                        .HasColumnType("integer");

                    b.Property<bool>("IsHomeTeam")
                        .HasColumnType("boolean");

                    b.Property<int>("PlayerId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("GamesId");

                    b.HasIndex("PlayerId");

                    b.ToTable("StartingGrids");
                });

            modelBuilder.Entity("AroundFootballService.Data.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryCode")
                        .HasColumnType("integer");

                    b.Property<string>("FlagUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RegionId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("AroundFootballService.Data.Models.Tournament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Tournaments");
                });

            modelBuilder.Entity("AroundFootballService.Data.Models.Event", b =>
                {
                    b.HasOne("AroundFootballService.Data.Models.Game", "Game")
                        .WithMany("Events")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("AroundFootballService.Data.Models.Game", b =>
                {
                    b.HasOne("AroundFootballService.Data.Models.Participant", "ParticipantAway")
                        .WithMany("AwayGames")
                        .HasForeignKey("ParticipantAwayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AroundFootballService.Data.Models.Participant", "ParticipantHome")
                        .WithMany("HomeGames")
                        .HasForeignKey("ParticipantHomeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ParticipantAway");

                    b.Navigation("ParticipantHome");
                });

            modelBuilder.Entity("AroundFootballService.Data.Models.Participant", b =>
                {
                    b.HasOne("AroundFootballService.Data.Models.Team", "Team")
                        .WithMany("Participants")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AroundFootballService.Data.Models.Tournament", "Tournament")
                        .WithMany("Participants")
                        .HasForeignKey("TournamentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");

                    b.Navigation("Tournament");
                });

            modelBuilder.Entity("AroundFootballService.Data.Models.Player", b =>
                {
                    b.HasOne("AroundFootballService.Data.Models.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("AroundFootballService.Data.Models.StartingGrid", b =>
                {
                    b.HasOne("AroundFootballService.Data.Models.Game", "Games")
                        .WithMany("StartingGrids")
                        .HasForeignKey("GamesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AroundFootballService.Data.Models.Player", "Player")
                        .WithMany("StartingGrids")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Games");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("AroundFootballService.Data.Models.Team", b =>
                {
                    b.HasOne("AroundFootballService.Data.Models.Region", "Region")
                        .WithMany("Teams")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Region");
                });

            modelBuilder.Entity("AroundFootballService.Data.Models.Game", b =>
                {
                    b.Navigation("Events");

                    b.Navigation("StartingGrids");
                });

            modelBuilder.Entity("AroundFootballService.Data.Models.Participant", b =>
                {
                    b.Navigation("AwayGames");

                    b.Navigation("HomeGames");
                });

            modelBuilder.Entity("AroundFootballService.Data.Models.Player", b =>
                {
                    b.Navigation("StartingGrids");
                });

            modelBuilder.Entity("AroundFootballService.Data.Models.Region", b =>
                {
                    b.Navigation("Teams");
                });

            modelBuilder.Entity("AroundFootballService.Data.Models.Team", b =>
                {
                    b.Navigation("Participants");

                    b.Navigation("Players");
                });

            modelBuilder.Entity("AroundFootballService.Data.Models.Tournament", b =>
                {
                    b.Navigation("Participants");
                });
#pragma warning restore 612, 618
        }
    }
}
