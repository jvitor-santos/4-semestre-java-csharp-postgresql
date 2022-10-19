package org.me.usuario;

import java.sql.*;
import java.util.*;
import javax.swing.JOptionPane;

public class UsuarioConecta {
private static final String URL = "jdbc:derby://localhost:1527/VUBER";
private static final String USERNAME = "VUBER";
private static final String PASSWORD = "vuber";
private Connection connection = null;
private PreparedStatement insertNovoUsuario = null;
private PreparedStatement selecionaUsuario = null;
public UsuarioConecta () throws ClassNotFoundException{
 try
 {
 Class.forName("org.apache.derby.jdbc.ClientDriver");
 connection = DriverManager.getConnection (URL, USERNAME, PASSWORD);
 insertNovoUsuario = connection.prepareStatement ("INSERT INTO VUBER.DADOS " + "(CPF, DATA_NASC, SENHA, TELEFONE, ENDERECO, TIPO_CONTA) " + "VALUES (?, ?, ?, ?, ?, ?)");
 selecionaUsuario = connection.prepareStatement("SELECT CPF, SENHA, TIPO_CONTA FROM VUBER.DADOS WHERE CPF = ?" );

 }
 catch (SQLException sqlException)
 {
 sqlException.printStackTrace();
 System.exit(1);
 }
}
public int adicionaUsuario(
 String pcpf, String pdata_nasc, String psenha, String ptelefone, String pendereco, String ptipo_conta )
 {
 int result = 0;
try{
 insertNovoUsuario.setString(1, pcpf);
 insertNovoUsuario.setString(2, pdata_nasc);
 insertNovoUsuario.setString(3, psenha);
 insertNovoUsuario.setString(4, ptelefone);
 insertNovoUsuario.setString(5, pendereco);
 insertNovoUsuario.setString(6, ptipo_conta);
 
 result = insertNovoUsuario.executeUpdate();
 }
catch (SQLException sqlException)
{
 sqlException.printStackTrace();
 close();
}
 return result;
 }

public List<UsuarioLogin>getCpfUsuarioLogin(String cpf){
    List<UsuarioLogin>resultados = null;
    ResultSet resultSet = null;
    try{
        selecionaUsuario.setString(1, cpf);
        resultSet = selecionaUsuario.executeQuery();
        resultados = new ArrayList<UsuarioLogin>();
        while (resultSet.next()){
            resultados.add(new UsuarioLogin(
            resultSet.getString("Cpf"),
            resultSet.getString("Senha"),
            resultSet.getString("Tipo_conta")));
        }
    }catch (SQLException sqlException){
        sqlException.printStackTrace();
        close();
    }
    return resultados;
}


public void close (){
 try
 {
 connection.close();
 }
 catch (SQLException sqlException)
{
 sqlException.printStackTrace();
}
}
}