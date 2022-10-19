package org.me.lista1exercicio1;
public class Livro extends Produto{
    private String autor, editora;
    private int isbn, ano;
    
    public Livro(int codigo,int preco, String descricao, String autor, String editora, int isbn, int ano){
        super(codigo, preco, descricao);
        this.autor=autor;
        this.editora=editora;
        this.isbn=isbn;
        this.ano=ano;
        
    }

    public String getAutor() {
        return autor;
    }

    public void setAutor(String autor) {
        this.autor = autor;
    }

    public String getEditora() {
        return editora;
    }

    public void setEditora(String editora) {
        this.editora = editora;
    }

    public int getIsbn() {
        return isbn;
    }

    public void setIsbn(int isbn) {
        this.isbn = isbn;
    }

    public int getAno() {
        return ano;
    }

    public void setAno(int ano) {
        this.ano = ano;
    }
}
