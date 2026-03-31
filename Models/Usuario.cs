namespace MauiAppHotel.Models
{
    public class Usuario
    {
        string _nome = "";
        string _email = "";
        string _senha = "";
        public string Nome
        {
            get => _nome;
            set
            {
                if (value == null)
                {
                    throw new Exception("Informe seu nome");
                }
                _nome = value;
            }
        }
        public string Email
        {
            get => _email;
            set
            {
                if (value == null)
                {
                    throw new Exception("Informe seu e-mail");
                }
                _email = value;
            }
        }
        public string Senha
        {
            get => _senha;
            set
            {
                if (value == null)
                {
                    throw new Exception("Informe a senha");
                }
                _senha = value;
            }
        }
    }
}
