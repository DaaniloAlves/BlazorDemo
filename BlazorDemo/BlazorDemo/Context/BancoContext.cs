using BlazorDemo.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorDemo.Context
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> o) : base(o)
        {

        }

        public DbSet<Time> Times { get; set; }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Time>().HasData(
                new Time
                {
                    Id = 1,
                    Nome = "Leviatan",
                    Pontos = 13,
                    Posicao = 1,
                    Regiao = "America"

                }, new Time
                {
                    Id = 2,
                    Nome = "G2 Esports",
                    Pontos = 13,
                    
                    Posicao = 2,
                    Regiao = "America"
                }, new Time
                {
                    Id = 3,
                    Nome = "KRU Esports",
                    Pontos = 13,
                    Posicao = 3,
                    Regiao = "America"
                }, new Time
                {
                    Id =4,
                    Nome = "Sentinels",
                    Pontos = 12,
                    Posicao = 4,
                    Regiao = "America"
                }, new Time
                {
                    Id =5,
                    Nome = "EDward Gaming",
                    Pontos = 13,
                    Posicao = 5,
                    Regiao = "China"
                }, new Time
                {
                    Id =6,
                    Nome = "FunPlus Phoenix",
                    Pontos = 13,
                    Posicao = 6,
                    Regiao = "China"
                }, new Time
                {
                    Id =7,
                    Nome = "Trace Esports",
                    Pontos = 13,
                    Posicao = 7,
                    Regiao = "China"
                }, new Time
                {
                    Id =8,
                    Nome = "Bilibili Gaming",
                    Pontos =6,
                    Posicao = 8,
                    Regiao = "China"
                }, new Time
                {
                    Id =9,
                    Nome = "Fnatic",
                    Pontos = 13,
                    Posicao = 9,
                    Regiao = "EMEA"
                }, new Time
                {
                    Id =10,
                    Nome = "Vitality",
                    Pontos = 13,
                    Posicao = 10,
                    Regiao = "EMEA"
                }, new Time
                {
                    Id =11,
                    Nome = "Team Heretics",
                    Pontos = 13,
                    Posicao = 11,
                    Regiao = "EMEA"
                }, new Time
                {
                    Id =12,
                    Nome = "FUT Esports",
                    Pontos = 11,
                    Posicao = 12,
                    Regiao = "EMEA"
                }, new Time
                {
                    Id = 13,
                    Nome = "Gen.G",
                    Pontos = 13,
                    Posicao = 13,
                    Regiao = "Pacifico"
                }, new Time
                {
                    Id = 14,
                    Nome = "DRX",
                    Pontos = 13,
                    Posicao = 14,
                    Regiao = "Pacifico"
                }, new Time
                {
                    Id =15,
                    Nome = "Paper Rex",
                    Pontos = 13,
                    Posicao = 15,
                    Regiao = "Pacifico"
                }, new Time
                {
                    Id=16,
                    Nome = "Talon Esports",
                    Pontos = 7,
                    Posicao = 16,
                    Regiao = "Pacifico"
                });
        } 


    }

}
