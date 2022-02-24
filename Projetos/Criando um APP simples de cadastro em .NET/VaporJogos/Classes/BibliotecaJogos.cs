using System;
using System.Collections.Generic;
using VaporJogos.Interfaces;

namespace VaporJogos
{
	public class BibliotecaJogos : IBiblioteca<Jogo>
	{
        private List<Jogo> listaJogos = new List<Jogo>();


		public void Instala(Jogo objeto)
		{
			listaJogos.Add(objeto);
		}


		public void Atualiza(int id, Jogo objeto)
		{
			listaJogos[id] = objeto;
		}


		public void Desinstala(int id)
		{
			listaJogos[id].Desinstalar();
		}


		public List<Jogo> Lista()
		{
			return listaJogos;
		}


		public int ProximoId()
		{
			return listaJogos.Count;
		}



		public Jogo RetornaPorId(int id)
		{
			return listaJogos[id];
		}
	}
}