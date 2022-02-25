using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace curso.api.Models.Usuarios
{
    public class LoginViewModelInput
    {
        private string login;
        private string senha;

        [Required(ErrorMessage = "O Login é obrigatório")]
        public string Login { get => login; set => login = value; }

        [Required(ErrorMessage = "A senha é obrigatória")]
        public string Senha { get => senha; set => senha = value; }
    }
}
