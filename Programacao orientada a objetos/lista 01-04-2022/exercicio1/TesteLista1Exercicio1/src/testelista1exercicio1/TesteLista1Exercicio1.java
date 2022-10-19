package testelista1exercicio1;
import org.me.lista1exercicio1.CompactDisc;
import org.me.lista1exercicio1.Livro;

public class TesteLista1Exercicio1 {
    public static void main(String[] args) {
        Livro l1 = new Livro(31, 300,"Livro muito bom","Toloske","Julgadox projetos", 10569, 2022);
        CompactDisc c1 = new CompactDisc(666777,1000,"Excelente","Maquinha do tempo","Matue","30");
        
        System.out.println("Livro");
        System.out.println("Codigo: "+ l1.getCodigo());
        System.out.println("Preço: "+ l1.getPreco());
        System.out.println("Descrição: "+ l1.getDescricao());
        System.out.println("Autor: "+ l1.getAutor());
        System.out.println("Editora: "+ l1.getEditora());
        System.out.println("ISBN: "+ l1.getIsbn());
        System.out.println("Ano: "+l1.getAno());
        
        System.out.println("CD");
        System.out.println("Codigo: "+ c1.getCodigo());
        System.out.println("Preço: "+ c1.getPreco());
        System.out.println("Descrição: "+ c1.getDescricao());
        System.out.println("Nome do album: "+ c1.getNome_album());
        System.out.println("Artista: "+ c1.getArtista());
        System.out.println("Gravadora: "+ c1.getGravadora());
    }
    
}
