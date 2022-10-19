package org.me.produto;
public class produto {
    private String descricao;
    private double quantidade,preco;
    
    public void setDescricao(String descricao){
        this.descricao = descricao;
    }
    public String getDescricao(){
        return descricao;
    }
    
    public void setQuantidade(double quantidade){
        this.quantidade = quantidade;
    }
    public double getQuantidade(){
        return quantidade;
    }
  
    public void setPreco(double preco){
        this.preco=preco;
    }
    public double getPreco(){
        return preco;
    }
    
    public double calculaDesconto(){
        if(preco >= 100)
            return preco * 0.10;
        else
            return preco*0.05;
        }
    }
