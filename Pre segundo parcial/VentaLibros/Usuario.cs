namespace VentaLibros
{
    public class Usuario
    {
        public int id_usuario { get; set; }
        public string nombre { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public bool admin { get; set; }
        
        public Usuario(){ }
        
        public Usuario(int uId, string uNombre, string uUsuario, string uContrasena)
        {
            id_usuario = uId;
            nombre = uNombre;
            usuario = uUsuario;
            contraseña = uContrasena;
            admin = false;
        }
    }
}