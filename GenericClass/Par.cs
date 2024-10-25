
namespace GenericClass
{
    public class Par<T1, T2>
    {
        private readonly T1 _primerElemento;
        private readonly T2 _segundoElemento;

        public Par(T1 primerElemento, T2 segundoElemento)
        {
            _primerElemento = primerElemento;
            _segundoElemento = segundoElemento;
        }

        public override string ToString()
        {
            return ($"Primer elemento: {_primerElemento}, Segundo elemento: {_segundoElemento}");
        }

    }
}
