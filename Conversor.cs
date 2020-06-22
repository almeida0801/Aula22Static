namespace Aula22Static
{
    public static class Conversor
    {
        
        public static float CotacaoDolar = 5.24f;

        public static float ConveterDolarParaReal( float valor ){
            return valor * CotacaoDolar;
        }

        public static float ConveterRealParaDolar( float valor ){
            return valor / CotacaoDolar;
        }


        public static float CotacaoEuro = 5.91f;

        public static float ConveterEuroParaReal( float valor ){
            return valor * CotacaoEuro;
        }

        public static float ConveterRealParaEuro( float valor ){
            return valor / CotacaoEuro;
        }

    }
}