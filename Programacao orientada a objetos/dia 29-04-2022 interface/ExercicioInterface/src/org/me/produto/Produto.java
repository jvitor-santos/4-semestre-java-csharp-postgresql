package org.me.produto;
public class Produto {
    private int codigo;
    private String descricao;
    private double preco;
    
    public Produto (int codigo, String descricao, double preco){
        this.codigo = codigo;
        this.descricao = descricao;
        this.preco = preco;
    }

    public int getCodigo() {
        return codigo;
    }

    public String getDescricao() {
        return descricao;
    }

    public double getPreco() {
        return preco;
    }
    
    @Override
    public String toString(){
        return String.format("Codigo: %s \nPreço: %s \nDescrição: %s", getCodigo(), getPreco(), getDescricao());
    }
}
