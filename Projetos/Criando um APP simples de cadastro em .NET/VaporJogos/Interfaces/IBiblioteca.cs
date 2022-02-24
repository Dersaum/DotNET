using System.Collections.Generic;

namespace VaporJogos.Interfaces
{
    public interface IBiblioteca<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);
        void Instala(T entidade);
        void Atualiza(int id, T entidade);
        void Desinstala(int id);
        int ProximoId();
    }
}