package org.me.atividadeclasseabstrata1;
public class Vendedor extends Funcionario{
    private String regiao;
    private double comissao;
    public Vendedor(String nome, double salario){
       super(nome, salario);
    }

    public String getRegiao() {
        return regiao;
    }

    public void setRegiao(String regiao) {
        this.regiao = regiao;
    }

    public double getComissao() {
        return comissao;
    }

    public void setComissao(double comissao) {
        this.comissao = comissao;
    }
    
    @Override
    public double reajuste(){
        salario+=salario*0.10;
        return salario;
    }
}
