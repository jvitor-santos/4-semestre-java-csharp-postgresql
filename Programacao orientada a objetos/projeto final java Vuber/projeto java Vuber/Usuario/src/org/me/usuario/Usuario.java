package org.me.usuario;
public class Usuario {
    private int ID;
    private String cpf, data_nasc, senha, telefone, endereco, tipo_conta;
    
    public Usuario(int ID, String cpf, String data_nasc, String senha, String telefone, String endereco, String tipo_conta){
        this.ID = ID;
        this.cpf = cpf;
        this.data_nasc = data_nasc;
        this.senha = senha;
        this.telefone = telefone;
        this.endereco = endereco;
        this.tipo_conta = tipo_conta;
    }

    public int getID() {
        return ID;
    }

    public void setID(int ID) {
        this.ID = ID;
    }

    public String getCpf() {
        return cpf;
    }

    public void setCpf(String cpf) {
        this.cpf = cpf;
    }

    public String getData_nasc() {
        return data_nasc;
    }

    public void setData_nasc(String data_nasc) {
        this.data_nasc = data_nasc;
    }

    public String getSenha() {
        return senha;
    }

    public void setSenha(String senha1) {
        this.senha = senha;
    }


    public String getTelefone() {
        return telefone;
    }

    public void setTelefone(String telefone) {
        this.telefone = telefone;
    }

    public String getEndereco() {
        return endereco;
    }

    public void setEndereco(String endereco) {
        this.endereco = endereco;
    }

    public String getTipo_conta() {
        return tipo_conta;
    }

    public void setTipo_conta(String tipo_conta) {
        this.tipo_conta = tipo_conta;
    }
}
