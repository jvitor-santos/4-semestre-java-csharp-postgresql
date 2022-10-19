package org.me.usuario;
public class UsuarioLogin {
    private String cpf, senha, tipo_conta;
    
    public UsuarioLogin(String cpf, String senha, String tipo_conta){
        this.cpf = cpf;
        this.senha = senha;
        this.tipo_conta = tipo_conta;
    }

    public String getCpf() {
        return cpf;
    }

    public void setCpf(String cpf) {
        this.cpf = cpf;
    }

    public String getSenha() {
        return senha;
    }

    public void setSenha(String senha) {
        this.senha = senha;
    }

    public String getTipo_conta() {
        return tipo_conta;
    }

    public void setTipo_conta(String tipo_conta) {
        this.tipo_conta = tipo_conta;
    }
}
