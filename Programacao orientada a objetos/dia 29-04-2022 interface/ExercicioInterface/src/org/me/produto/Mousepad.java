package org.me.produto;
public class Mousepad extends Produto implements Venda{
    private String cor, tamanho;
    
    public Mousepad(int codigo, String descricao, float preco, String cor, String tamanho){
        super(codigo, descricao, preco);
        this.cor = cor;
        this.tamanho = tamanho;
    }

    public String getCor() {
        return cor;
    }

    public String getTamanho() {
        return tamanho;
    }
    
    @Override
    public double getValor_venda(){
        return getPreco()*1.10;
    }
    
    @Override
    public String toString(){
        return String.format("%s \nCor: %s \nTamanho: %s", super.toString(), cor, tamanho);
    }
}
