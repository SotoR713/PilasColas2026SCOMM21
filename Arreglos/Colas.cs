namespace arregloColas
{
    internal class Colas
    {
        private string[] _arregloCola;
        private int _Max;
        private int _inicio;
        private int _final;
        public Colas(int elementos)
        {
            _arregloCola = new string[elementos];
            _Max = _arregloCola.Length;
            _inicio = 0;
            _final = 0;
        }

        public void Agregar(string elemento)
        {
            if (string.IsNullOrWhiteSpace(elemento))
            {
                throw new Exception("No se ha especificado valor a agregar.");
            }


            if (_final == _Max )
            { _final = 0; }


            if (_final + 1 == _inicio || _final != 0 && _inicio != 0 )
            {
                throw new Exception("Cola llena");
            }

            _arregloCola[_final] = elemento;
            _final++;

        }


        public void Eliminar()
        {
            if (_inicio == _final)
            {
                throw new Exception("Cola vacia");
            }



            _arregloCola[_inicio] = "";
            _inicio++;

            if (_inicio == _Max)
            { _inicio = 0; }

        }

        public string ObtenerDatos()
        {
            string datos = string.Empty;


            for (int i = _inicio; i != _final; i++)

            {
                if (i == _Max)
                { i = 0; }
                


                datos += _arregloCola[i];   // datos = datos + _arregloCola[i] funciona igual
                if (i < (_final - 1))
                {
                    datos += ",";       //mejorarlo con interpolacion de texto
                }

            }


            return datos;
        }


    }
}
