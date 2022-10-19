package org.me.exemploclasseabstrata;
public class Medico extends Funcionario{
    
    protected int crm;
    
    public Medico(String nome, String email, int crm){
        super(nome, email);
        this.crm = crm;
    }
    
    @Override
    public void imprime(){
        System.out.println("Medico");
        System.out.println("nome: " + nome);
        System.out.println("E-mail: " + email);
        System.out.println("CRM: " + crm);
    }
    
}
