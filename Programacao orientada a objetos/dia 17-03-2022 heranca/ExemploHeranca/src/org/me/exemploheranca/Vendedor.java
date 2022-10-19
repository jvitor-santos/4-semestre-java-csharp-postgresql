package org.me.exemploheranca;

public class Vendedor extends Funcionario {
    private String cidades;
    
    public void setCidades (String cidades){
        this.cidades= cidades;
    }
    
    public String getCidades(){
        return cidades;
    }
}
