package org.me.lista1exercicio1;
public class Produto {
    private int codigo, preco;
    private String descricao;
    
    public Produto( int codigo, int preco, String descricao){
        this.codigo=codigo;
        this.preco=preco;
        this.descricao=descricao;
    }

    public int getCodigo() {
        return codigo;
    }

    public void setCodigo(int codigo) {
        this.codigo = codigo;
    }

    public int getPreco() {
        return preco;
    }

    public void setPreco(int preco) {
        this.preco = preco;
    }

    public String getDescricao() {
        return descricao;
    }

    public void setDescricao(String descricao) {
        this.descricao = descricao;
    }
}
