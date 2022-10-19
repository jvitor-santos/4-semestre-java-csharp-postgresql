package org.me.exemplosobrecarga;
public class sobrecarga {
    
    public void exibeMensagem(String texto){
        System.out.println("O texto informado foi " + texto);
    }
    
    public void exibeMensagem(int valor){
        System.out.println("O valor informado foi " + valor);
    }
    
    public void exibeMensagem(){
        System.out.println("Nada foi informado");
    }
}
