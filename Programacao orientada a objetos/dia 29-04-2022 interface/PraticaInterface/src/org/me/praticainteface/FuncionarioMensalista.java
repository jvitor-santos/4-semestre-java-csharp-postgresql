package org.me.praticainteface;
public class FuncionarioMensalista extends Funcionario implements Pagamento{
    private double salario_mensal;
    
    public FuncionarioMensalista(String nome, String sobrenome, int cpf, double salario_mensal){
        super(nome, sobrenome, cpf);
        this.salario_mensal = salario_mensal;
    }

    public double getSalario_mensal() {
        return salario_mensal;
    }
    
    public void setSalario_mensal(){
        this.salario_mensal = (salario_mensal < 0) ? 0 : salario_mensal;
    }
    
    @Override
    public String toString(){
        return String.format("%s"
                            +"\n%s %.2f",
                             super.toString(),
                             "Salario mensal: ",getSalario_mensal());
    }
    
    @Override
    public double getValor_pagamento(){
        return getSalario_mensal();
    }
}
