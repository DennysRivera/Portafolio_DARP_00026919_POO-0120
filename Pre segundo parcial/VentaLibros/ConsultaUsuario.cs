using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace VentaLibros
{
    public static class ConsultaUsuario
    {
        public static List<Usuario> usuariosRegistrados()
        {
            var dt = Conexion.ExecuteQuery($"SELECT * FROM USUARIO");
            List<Usuario> usuariosRegis = new List<Usuario>();

            foreach (DataRow n in dt.Rows)
            {
                Usuario u = new Usuario();
                u.nombre = n[1].ToString();
                u.usuario = n[2].ToString();
                u.contrasena = n[3].ToString();
                u.admin = Convert.ToBoolean(n[4].ToString());
                u.activo = Convert.ToBoolean(n[5].ToString());
                usuariosRegis.Add(u);
            }

            return usuariosRegis;    
        }
        
        public static void registrarUsuario(Usuario nuevo)
        {
            Conexion.ExecuteNonQuery($"INSERT INTO USUARIO(nombre, usuario, contrasena, administrador, activo) " +
                                     $"VALUES('{nuevo.nombre}'," +
                                     $" '{nuevo.usuario}'," +
                                     $"'{nuevo.contrasena}'," +
                                     $"{nuevo.admin}," +
                                     $"{nuevo.activo})");
            
            MessageBox.Show("Registro completo");
        }

        public static void cambiarContrasena(string usuario, string nuevaPass)
        {
            Conexion.ExecuteNonQuery($"UPDATE USUARIO SET contrasena = '{nuevaPass}'" +
                                     $"WHERE usuario = '{usuario}'");
        }
        public static void eliminarUsuario(string userName)
        {
            Conexion.ExecuteNonQuery($"DELETE FROM PEDIDO WHERE nombre_usuario = '{userName}'" +
                                     $"DELETE FROM USUARIO WHERE usuario = '{userName}'");

            MessageBox.Show("Usuario eliminado");
        }

        public static void actualizarUsuario(string usuario, bool admin, bool activo)
        {
            Conexion.ExecuteNonQuery($"UPDATE USUARIO administrador = {admin}, activo = {activo}" +
                                     $"WHERE usuario = '{usuario}'");
        }
    }
}