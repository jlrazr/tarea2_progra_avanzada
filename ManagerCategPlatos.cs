﻿using System.Xml.Linq;

namespace Tarea2
{
    public class ManagerCategPlatos : IManager<CategoriaPlato>
    {
        private CategoriaPlato[] _categPlatos = new CategoriaPlato[20];
        private int _cuentaCategPlatos = 0;

        public void Registrar(CategoriaPlato categoriaPlato)
        {
            if (_cuentaCategPlatos < 20)
            {
                _categPlatos[_cuentaCategPlatos++] = categoriaPlato;
                Console.WriteLine("La categoría fue registrada con éxito.");
            } else
            {
                Console.WriteLine("El número máximo de categorías (20) ya se ha alcanzado.");
            }
        }

        public CategoriaPlato[] GetTodos()
        {
            return _categPlatos;
        }

        public CategoriaPlato GetPorId(int id)
        {
            foreach (var categ in _categPlatos)
            {
                if (categ != null && categ.Id == id)
                {
                    return categ;
                }
            }

            return null;
        }
    }
}
