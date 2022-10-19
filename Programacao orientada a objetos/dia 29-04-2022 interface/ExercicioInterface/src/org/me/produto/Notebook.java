package org.me.produto;
public class Notebook extends Produto implements Venda{
    private String memoria,hd;
    
    public Notebook(int codigo, String descricao, double preco, String memoria, String hd){
        super(codigo, descricao, preco);
        this.memoria = memoria;
        this.hd = hd;
    }

    public String getMemoria() {
        return memoria;
    }

    public String getHd() {
        return hd;
    }
    
    @Override
    public double getValor_venda(){
        return getPreco()*1.20;
    }
    
    @Override
    public String toString(){
        return String.format("%s \nMemoria: %s \nHd: %s", super.toString(), getMemoria(), getHd());
    }
    
}
