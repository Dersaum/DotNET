using System;

namespace VaporJogos
{
    public class Jogo : EntidadeBase
    {
		private string Titulo { get; set; }
		private Plataforma Plataforma { get; set; }
		private Genero Genero { get; set; }
		private Camera Camera { get; set; }
		private ModoJogo ModoJogo { get; set; }
		private int Ano { get; set; }
		private string Descricao { get; set; }
        private bool Desinstalado {get; set;}


		public Jogo(int id, string titulo, Plataforma plataforma, Genero genero, Camera camera, ModoJogo modojogo, int ano, string descricao)
		{
			this.Id = id;
			this.Titulo = titulo;
			this.Plataforma = plataforma;
			this.Genero = genero;
			this.Camera = camera;
			this.ModoJogo = modojogo;
			this.Ano = ano;
			this.Descricao = descricao;
            this.Desinstalado = false;
		}


        public override string ToString()
		{
            string retorno = "";
			retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Plataforma: " + this.Plataforma + Environment.NewLine;
			retorno += "Gênero: " + this.Genero + Environment.NewLine;
			retorno += "Estilo de câmera: " + this.Camera + Environment.NewLine;
			retorno += "Modo de jogo: " + this.ModoJogo + Environment.NewLine;
            retorno += "Ano de lançamento: " + this.Ano + Environment.NewLine;
			retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Desinstalado: " + this.Desinstalado;
			return retorno;
		}


        public string retornaTitulo()
		{
			return this.Titulo;
		}


		public int retornaId()
		{
			return this.Id;
		}


        public bool retornaDesinstalado()
		{
			return this.Desinstalado;
		}


        public void Desinstalar() {
            this.Desinstalado = true;
        }
    }
}