using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
	public class SerieRepositorio : IRepositorio<Serie>
	{
        private List<Serie> listaSerie = new List<Serie>();
		public void Atualiza(int id, Serie objeto)
		{
			listaSerie[id] = objeto;
		}

		public void Exclui(int id) // Marcar como excluido
		{
			listaSerie[id].Excluir(); 
		}

		public void Insere(Serie objeto)
		{
			listaSerie.Add(objeto);
		}

		public List<Serie> Lista()
		{
			return listaSerie;
		}

		public int ProximoId() //n=n+1 
		{
			return listaSerie.Count; 
		}

		public Serie RetornaPorId(int id)
		{
			try
			{
				return listaSerie[id];
			}
			catch (System.Exception)
			{
					throw;
			}
		}
	}
}
