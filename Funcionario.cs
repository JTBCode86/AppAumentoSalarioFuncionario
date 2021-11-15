using System.Globalization;

namespace AppAumentoSalarioFuncionario
{
    class Funcionario
    {
        public string nome;
        public double salarioBruto;
        public double imposto;

        public double salarioLiquido() 
        {
            return salarioBruto - imposto;
        }       

        public void aumentarSalario(double percentual) 
        {
            salarioBruto = salarioBruto + (salarioBruto * percentual / 100.0);
        }

        public override string ToString()
        {
            return
                nome
                + ", R$ "
                + salarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
