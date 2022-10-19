package org.me.lista1exercicio3;
public class FuncionarioComissao extends Funcionario{
    private double venda_bruta, comissao;
    
    public FuncionarioComissao(String nome, String sobrenome, int cpf, double venda_bruta, double comissao){
        super(nome, sobrenome, cpf);
        this.venda_bruta=venda_bruta;
        this.comissao=comissao;
    }

    public double getVenda_bruta() {
        return venda_bruta;
    }

    public void setVenda_bruta(double venda_bruta) {
        this.venda_bruta = (venda_bruta < 0) ? 0 : venda_bruta;
    }

    public double getComissao() {
        return comissao;
    }

    public void setComissao(double comissao) {
        this.comissao = (comissao > 0 && comissao < 1) ? comissao : 0;
    }
    
    @Override
    public double calcula_salario(){
        setVenda_bruta(venda_bruta);
        setComissao(comissao);
        double salario_final = venda_bruta*comissao;
        return salario_final;
    }
    
    @Override
    public String toString(){
        return String.format("%sVenda Bruta: R$%.2f\nComissao: %.2f%%\n", super.toString(), venda_bruta, comissao);
    }
    
}