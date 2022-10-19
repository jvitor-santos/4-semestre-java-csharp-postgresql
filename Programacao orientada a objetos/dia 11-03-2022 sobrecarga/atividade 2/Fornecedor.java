
package org.me.fornecedor;

public class Fornecedor {
    private String empresa;
    private String endereco;
    private int inscricao;
    private String nome;
    


    public Fornecedor(String empresa, String endereco, int inscricao, String nome) {
        this.empresa = empresa;
        this.endereco = endereco;
        this.inscricao = inscricao;
        this.nome = nome;
     
    }
 
    public String getEmpresa() {
        return empresa;
    }

    
    public void setEmpresa(String empresa) {
        this.empresa = empresa;
    }

    public String getEndereco() {
        return endereco;
    }

   
    public void setEndereco(String endereco) {
        this.endereco = endereco;
    }

   
    public int getInscricao() {
        return inscricao;
    }

   
    public void setInscricao(int inscricao) {
        this.inscricao = inscricao;
    }

    public String getNome() {
        return nome;
    }

   
    public void setNome(String nome) {
        this.nome = nome;
    }
    
}
