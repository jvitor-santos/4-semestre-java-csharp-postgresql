package org.me.praticainteface;
public class Fatura implements Pagamento{
    private int numero, quantidade;
    private String descricao;
    private double preco_item;
    public Fatura (int numero, int quantidade, String descricao, double preco_item){
        this.numero = numero;
        setQuantidade(quantidade);
        this.descricao = descricao;
        setPreco_item( preco_item);
    }
    public void setQuantidade(int quantidade) {
        this.quantidade = (quantidade<0) ? 0 : quantidade;
    }
    public void setPreco_item(double preco_item) {
        this.preco_item = (preco_item<0)? 0 : preco_item;
    }
    public int getNumero() {
        return numero;
    }
    public int getQuantidade() {
        return quantidade;
    }
    public String getDescricao() {
        return descricao;
    }
    public double getPreco_item() {
        return preco_item;
    }
    @Override
    public String toString(){
        return String.format(
                "%s %d\n"
                + "%s %s\n"
                + "%s %d\n"
                + "%s %.2f",
                "Numero: ",getNumero(), 
                "Descrição: ",getDescricao(),
                "Quantidade: ",getQuantidade(),
                "Preço por item: R$ ",getPreco_item()
                );
    }
    @Override
    public double getValor_pagamento() {
        return getQuantidade() * getPreco_item();
    }
}