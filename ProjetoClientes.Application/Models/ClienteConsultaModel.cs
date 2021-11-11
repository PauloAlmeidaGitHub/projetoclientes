using System;

namespace ProjetoClientes.Application.Models
{
    /// <summary>
    /// Modelo de dados para a ação de consulta de cliente.
    /// </summary>
    public class ClienteConsultaModel
    {
        public Guid IdCliente { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}