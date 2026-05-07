using PROYECTO_1.BASE;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PROYECTO_1.CLASES
{
    public class Cliente
    {
        public List<object> listado()
        {
            using (FOTOEntities2 db = new FOTOEntities2())
            {
                var lista = (from d in db.CLIENTES
                             join s in db.SERVICIOS on d.ID_C equals s.ID_S
                             select new
                             {
                                 d.NOMBRE,
                                 d.CI,
                                 d.TELEFONO,
                                 s.TIPO,
                                 s.CANTIDAD,
                                 s.PRECIO,
                                 s.TOTAL,
                             }).ToList();

                return lista.Cast<object>().ToList();
            }
        }

        public void Guardar(CLIENTES clientes)
        {
            using (FOTOEntities2 db = new FOTOEntities2())
            {
                db.CLIENTES.Add(clientes);
                db.SaveChanges();
            }
        }

        public void Guardar(SERVICIOS servicios)
        {
            using (FOTOEntities2 db = new FOTOEntities2())
            {
                db.SERVICIOS.Add(servicios);
                db.SaveChanges();
            }
        }

        public List<object> BuscarCarnet(int carnet)
        {
            using (FOTOEntities2 db = new FOTOEntities2())
            {
                return db.CLIENTES
                    .Where(x => x.CI == carnet)
                    .Select(x => new
                    {
                        x.NOMBRE,
                        x.CI,
                        x.TELEFONO,
                    }).ToList<object>();
            }
        }

    }
}