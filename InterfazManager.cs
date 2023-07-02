using System.Xml.Linq;

namespace Tarea2
{
    public interface IManager<T>
    {
        void Registrar(T item);
        T[] GetTodos();
    }
}
