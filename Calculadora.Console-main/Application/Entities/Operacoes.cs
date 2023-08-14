using Application.Data;
using Application.Services;

namespace Application.Entities
{
    public class Operacoes
    {
       
        public static float Somar(float n1, float n2)
        {
            var result = n1 + n2;
            return result;
        }
    }
}