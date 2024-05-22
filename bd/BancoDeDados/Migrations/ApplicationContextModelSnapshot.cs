﻿// <auto-generated />
using System;
using BancoDeDados;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BancoDeDados.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.5");

            modelBuilder.Entity("Entities.Models.BancoDeSangue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Data")
                        .HasColumnType("TEXT");

                    b.Property<int>("IdDoacao")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdHemocentro")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("BancoDeSangues");
                });

            modelBuilder.Entity("Entities.Models.DadosMedico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("CRM")
                        .HasColumnType("REAL");

                    b.Property<string>("NomeCompleto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("DadosMedicos");
                });

            modelBuilder.Entity("Entities.Models.Doador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("HT")
                        .HasColumnType("REAL");

                    b.Property<double>("PressaoArterialDiastolica")
                        .HasColumnType("REAL");

                    b.Property<double>("PressaoArterialSistolica")
                        .HasColumnType("REAL");

                    b.Property<int>("Temperatura")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TipoDoacao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("VolumeColetar")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Doadores");
                });

            modelBuilder.Entity("Entities.Models.Hemocentro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("CEP")
                        .HasColumnType("REAL");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeHemocentro")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Referencia")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Telefone")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Hemocentros");
                });

            modelBuilder.Entity("Entities.Models.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ComponenteSanguineoSolicitado")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataDaTransfusao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Diagnostico")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("IdMedico")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsInternado")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MedicoSolicitanteId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ModalidadeDaTransfusao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeHospital")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("NumeroLeito")
                        .HasColumnType("REAL");

                    b.Property<int>("QuantidadeSolicitada")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("MedicoSolicitanteId");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("Entities.Models.ProcedimentoAfereseDoador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AnticoagulanteUsado")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("HoraDaColeta")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdDoador")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TipoComponenteSanguineo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("VolumeProduto")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("IdDoador");

                    b.ToTable("ProcedimentoAfereseDoadors");
                });

            modelBuilder.Entity("Entities.Models.ProcedimentoPaciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Diagnostico")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("IdPaciente")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProcedimentoTerapeutico")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoComponente")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TipoLiquido")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VolumeComponente")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VolumeExtracorporeoProcessado")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VolumeLiquido")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("IdPaciente");

                    b.ToTable("ProcedimentoPacientes");
                });

            modelBuilder.Entity("Entities.Models.SangueColetado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ComponenteSanguineo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataColeta")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataVencimento")
                        .HasColumnType("TEXT");

                    b.Property<bool>("FatorRh")
                        .HasColumnType("INTEGER");

                    b.Property<string>("GrupoABO")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("IdDoacao")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdHemocentro")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NomeAnticoagulantePreservativo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TemperaturaAdequada")
                        .HasColumnType("INTEGER");

                    b.Property<double>("VolumeComponenteSanguineo")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("IdDoacao");

                    b.HasIndex("IdHemocentro");

                    b.ToTable("SangueColetados");
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ABO")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("CEP")
                        .HasColumnType("REAL");

                    b.Property<double>("CPF")
                        .HasColumnType("REAL");

                    b.Property<double>("Celular")
                        .HasColumnType("REAL");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Emprego")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsNegativo")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsPositivo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nacionalidade")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Nascimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Naturalidade")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeDaMae")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeDoPai")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("OrgaoExpedidor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Entities.Models.Paciente", b =>
                {
                    b.HasOne("Entities.Models.DadosMedico", "MedicoSolicitante")
                        .WithMany()
                        .HasForeignKey("MedicoSolicitanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MedicoSolicitante");
                });

            modelBuilder.Entity("Entities.Models.ProcedimentoAfereseDoador", b =>
                {
                    b.HasOne("Entities.Models.Doador", "Doador")
                        .WithMany("ProcedimentosAferese")
                        .HasForeignKey("IdDoador")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doador");
                });

            modelBuilder.Entity("Entities.Models.ProcedimentoPaciente", b =>
                {
                    b.HasOne("Entities.Models.Paciente", "Paciente")
                        .WithMany("ProcedimentosPaciente")
                        .HasForeignKey("IdPaciente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("Entities.Models.SangueColetado", b =>
                {
                    b.HasOne("Entities.Models.Doador", "Doador")
                        .WithMany()
                        .HasForeignKey("IdDoacao")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.Hemocentro", "Hemocentro")
                        .WithMany()
                        .HasForeignKey("IdHemocentro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doador");

                    b.Navigation("Hemocentro");
                });

            modelBuilder.Entity("Entities.Models.Doador", b =>
                {
                    b.Navigation("ProcedimentosAferese");
                });

            modelBuilder.Entity("Entities.Models.Paciente", b =>
                {
                    b.Navigation("ProcedimentosPaciente");
                });
#pragma warning restore 612, 618
        }
    }
}
