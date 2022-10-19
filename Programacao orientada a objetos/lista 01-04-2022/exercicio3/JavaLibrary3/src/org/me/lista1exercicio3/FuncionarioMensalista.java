package org.me.lista1exercicio3;
public class FuncionarioMensalista extends Funcionario{
    private double salario_mensal;


    public FuncionarioMensalista(String nome, String sobrenome, int cpf,double salario_mensal) {
        super(nome, sobrenome, cpf);
        this.salario_mensal = salario_mensal;
    }
    
    @Override
    public double calcula_salario() {
     setSalario_mensal(salario_mensal);
     return 0;
    }

    public double getSalario_mensal() {
        return salario_mensal;
    }

    public void setSalario_mensal(double salario_mensal) {
        this.salario_mensal = (salario_mensal < 0) ? 0 : salario_mensal;
    }
    
    @Override
    public String toString(){
        return String.format("%sSalario mensal: %.2f\n", super.toString(),salario_mensal);
    }
}
