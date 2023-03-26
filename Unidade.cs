namespace NumeroPorExtenso
{
    public class Unidade
    {
        public string UnidadePorExtenso(int numero)
        {
            if(numero==0)
                return "Zero";
            else if(numero==1)
                return "Um";
            else if(numero==2)
                return "Dois";
            else if(numero==3)
                return "Tres";
            else if(numero==4)
                return "Quatro";
            else if(numero==5)
                return "Cinco"; 
            else if(numero==6)
                return "Seis";
            else if(numero==7)
                return "Sete";
            else if(numero==8)
                return "Oito";
            else if(numero==9)
                return "Nove";
            else
                return "Numero Invalido";
        }
    }
    public class Dezena
    {
        public string DezenaPorExtenso(int numero)
        {
            string retorno = "";
            Unidade unidade = new Unidade();
            if(numero == 10)
                return "Dez";
            if(numero == 11)
                return "Onze";
            if(numero == 12)
                return "Doze";
            if(numero == 13)
                return "Treze";
            if(numero == 14)
                return "Quatorze";
            if(numero == 15)
                return "Quinze";
            if(numero == 16)
                return "Dezesseis";
            if(numero == 17)
                return "Dezessete";
            if(numero == 18)
                return "Dezoito";
            if(numero == 19)
                return "Dezenove";
            if(numero >= 20 && numero <= 29)
            {
                if(numero == 20)
                    retorno = "Vinte";
                else
                {
                    string und =numero.ToString().Substring(1,1);
                    retorno = "Vinte e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }
            }
                if(numero >= 30 && numero <= 39)
            {
                if(numero == 30)
                    retorno = "Trinta";
                else
                {
                    string und =numero.ToString().Substring(1,1);
                    retorno = "Trinta e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }
            }
            if(numero >= 40 && numero <= 49)
            {
                if(numero == 40)
                    retorno = "Quarenta";
                else
                {
                    string und =numero.ToString().Substring(1,1);
                    retorno = "Quarenta e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }
            }
            if(numero >= 50 && numero <= 59)
            {
                if(numero == 50)
                    retorno = "Cinquenta";
                else
                {
                    string und =numero.ToString().Substring(1,1);
                    retorno = "Cinquenta e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }
            } 
            if(numero >= 60 && numero <= 69)
            {
                if(numero == 60)
                    retorno = "Sessenta";
                else
                {
                    string und =numero.ToString().Substring(1,1);
                    retorno = "Sessenta e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }
            }
             if(numero >= 70 && numero <= 79)
            {
                if(numero == 70)
                    retorno = "Setenta";
                else
                {
                    string und =numero.ToString().Substring(1,1);
                    retorno = "Setenta e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }
            }    
             if(numero >= 80 && numero <= 89)
            {
                if(numero == 80)
                    retorno = "Oitenta";
                else
                {
                    string und =numero.ToString().Substring(1,1);
                    retorno = "Oitenta e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }
            } 
             if(numero >= 90 && numero <= 99)
            {
                if(numero == 90)
                    retorno = "Noventa";
                else
                {
                    string und =numero.ToString().Substring(1,1);
                    retorno = "Noventa e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }
            } 
        }
    }

    public class Centena
    {
        public string CentenaPorExtenso(int numero)
        {
           if(numero >= 100 && numero <= 109)
            {
                if(numero == 100)
                    retorno = "Cem";
                else
                {
                    string und =numero.ToString().Substring(1,1);
                    retorno = "cento e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }
            }  
            if(numero >= 110 && numero <= 199)
            {
                if(numero == 110)
                    retorno = "cento e dez";
                else
                {
                    string und =numero.ToString().Substring(1,1);
                    retorno = "cento e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
            }
             if(numero >= 200 && numero <= 209)
            {
                if(numero == 200)
                    retorno = "Duzentos";
                else
                {
                    string und =numero.ToString().Substring(1,1);
                    retorno = "Duzentos e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }
            }  
            if(numero >= 210 && numero <= 299)
            {
                if(numero == 210)
                    retorno = "Duzentos e dez";
                else
                {
                    string und =numero.ToString().Substring(1,1);
                    retorno = "Duzentos e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
            }
             if(numero >= 300 && numero <= 309)
            {
                if(numero == 300)
                    retorno = "Trezentos";
                else
                {
                    string und =numero.ToString().Substring(1,1);
                    retorno = "Trezentos e ";
                    retorno += unidade.UnidadePorExtenso(Convert.ToInt32(und));
                }
            }  
            if(numero >= 310 && numero <= 399)
            {
                if(numero == 310)
                    retorno = "Trezentos e dez";
                else
                {
                    string und =numero.ToString().Substring(1,1);
                    retorno = "Trezentos e ";
                    retorno += dezena.DezenaPorExtenso(Convert.ToInt32(und));
                }
            } 
        }
    }
}

