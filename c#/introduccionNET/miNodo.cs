namespace introduccionNET
{
    class miNodo
    {
        int valor = 126;
        public int Valor { get => valor; private set => valor = value; }

        public miNodo(int Valor){
            this.valor = Valor;
        }

        private int haceralgo(int valor){
            return valor;
        }

    }
}

