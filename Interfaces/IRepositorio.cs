using System.Collections.Generic;

namespace serieCadastro
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        void Exclui(int Id);
        T RetornaPorID(int Id);
        void Insere(T entidade);
        void Atualiza(int id, T entidade);
        int ProximoId();
                 
    }
}