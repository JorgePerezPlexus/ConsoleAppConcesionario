using ConsoleAppConcesionario.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppConcesionario
{
    class Program
    {
        static void Main(string[] args)
        {

            using (dboConcesionariosEntities db = new dboConcesionariosEntities())
            {
                var vehiculos = db.Vehiculos.ToList();
                foreach (var  v in vehiculos)
                {
                    Console.WriteLine(v.ToString());
                }

                if (db.Vehiculos.Where(x => x.modelo.Equals("A3")) == null)
                {
                    Vehiculos nuevo = new Vehiculos();
                    nuevo.marca = "Audi";
                    nuevo.modelo = "A3";
                    nuevo.km = 1000;
                    nuevo.vendido = "s";

                    db.Vehiculos.Add(nuevo);

                    db.Entry(nuevo).State = System.Data.Entity.EntityState.Added;

                    db.SaveChanges();
                }

                Vehiculos modificar = db.Vehiculos.Find(4);
                if (modificar != null)
                {
                    modificar.km = 20000;

                    db.Entry(modificar).State = System.Data.Entity.EntityState.Modified;

                    db.SaveChanges();
                }
                

                Vehiculos borrar = db.Vehiculos.Find(4);
                if (borrar != null)
                {
                    db.Vehiculos.Remove(borrar);

                    db.Entry(modificar).State = System.Data.Entity.EntityState.Deleted;

                    db.SaveChanges();
                }
                


            }
        }
    }
}
