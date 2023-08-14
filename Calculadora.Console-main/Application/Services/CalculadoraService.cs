using System;
using Application.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Entities;

namespace Application.Services
{
    public class CalculadoraService
    {
        private readonly AppDbContext _db;
       
        public CalculadoraService(AppDbContext db)
        {

            _db = db;

        }

        public float Somar(float n1, float n2)
        {
            var result = n1 + n2;
            var hist = new HistOperation()
            {
                Name = "Soma",
                Result = result,
                Date = DateTime.Now
            };

            _db.HistOperations.Add(hist);
            _db.SaveChanges();
            return result;
        }
        public float Subtrair(float n1, float n2)
        {
            var result = n1 - n2;
            var hist = new HistOperation()
            {
                Name = "Subtracao",
                Result = result,
                Date = DateTime.Now
            };

            _db.HistOperations.Add(hist);
            _db.SaveChanges();
            return result;
        }
        public float Multiplicar(float n1, float n2)
        {
            var result = n1 * n2;
            var hist = new HistOperation()
            {
                Name = "Multiplicacao",
                Result = result,
                Date = DateTime.Now
            };

            

            _db.HistOperations.Add(hist);
            _db.SaveChanges();
            return result;
        }
        public float Dividir(float n1, float n2)
        {
            var result = n1/n2;
            var hist = new HistOperation()
            {
                Name = "Divisao",
                Result = result,
                Date = DateTime.Now
            };

            _db.HistOperations.Add(hist);
            _db.SaveChanges();
            return result;
        }
    }
}
