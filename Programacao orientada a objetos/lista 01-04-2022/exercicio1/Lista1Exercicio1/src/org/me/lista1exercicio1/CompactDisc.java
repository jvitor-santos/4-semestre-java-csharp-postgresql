package org.me.lista1exercicio1;
public class CompactDisc extends Produto{
    private String nome_album, artista, gravadora;
    
    public CompactDisc(int codigo, int preco, String descricao, String nome_album, String artista, String gravadora){
        super(codigo, preco, descricao);
        this.nome_album=nome_album;
        this.artista=artista;
        this.gravadora=gravadora;
    }

    public String getNome_album() {
        return nome_album;
    }

    public void setNome_album(String nome_album) {
        this.nome_album = nome_album;
    }

    public String getArtista() {
        return artista;
    }

    public void setArtista(String artista) {
        this.artista = artista;
    }

    public String getGravadora() {
        return gravadora;
    }

    public void setGravadora(String gravadora) {
        this.gravadora = gravadora;
    }
    
}
