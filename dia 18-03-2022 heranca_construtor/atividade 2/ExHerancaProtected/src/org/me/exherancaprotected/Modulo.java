package org.me.exherancaprotected;
public class Modulo extends Curso{
    protected String nome_modulo = "Herença";
    protected int duracao_modulo = 4;
    
    public void exibeMensagem(){
        System.out.println("Nome curso: "+ super.nomecurso);
        System.out.println("Duração curso: "+ super.duracao);
        System.out.println("Nome módulo: "+ nome_modulo);
        System.out.println("Duração módulo: "+ duracao_modulo);
    }
}
