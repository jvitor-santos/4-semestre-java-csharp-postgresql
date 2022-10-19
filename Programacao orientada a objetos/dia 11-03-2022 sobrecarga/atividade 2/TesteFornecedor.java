
package testefornecedor;

import org.me.fornecedor.Fornecedor;


public class TesteFornecedor {

   
    public static void main(String[] args) {
       Fornecedor f1 = new Fornecedor("Fatec", "Siqueira campos", 55002, "Toloske");
       //String empresa, String endereco, int inscricao, String nome//
       Fornecedor f2 = new Fornecedor("Etec", "Cel fernando prestes", 970, "Julgadox");
       
       System.out.println("Os dados do fornecedores sao 1 Empresa: " + f1.getEmpresa() + " Endereço: " + f1.getEndereco() + " Inscriçao: " + f1.getInscricao()+ " Nome: " + f1.getNome());
       System.out.println("Os dados do fornecedores sao 2 Empresa: " + f2.getEmpresa() + " Endereço: " + f2.getEndereco() + " Inscriçao: " + f2.getInscricao()+ " Nome: " + f2.getNome());
    }
    
}
