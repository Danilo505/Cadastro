using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Form1 : Form
    {
        private List<Contato> contatos = new List<Contato>();
        private SubjectObservado subjectObservado = new SubjectObservado();
        private Stack<Erro> erros = new Stack<Erro>();

        public Form1()
        {
            InitializeComponent();
            IniciarView();
            ContagemUser();
            AdicionarObservador(new Observador());
        }

        private void btnSend_Click_1(object sender, EventArgs e)
        {
            try
            {
                string Name = textName.Text;
                string Surname = textSurname.Text;
                string Email = textEmail.Text;

                if (string.IsNullOrWhiteSpace(Name))
                {
                    throw new Exception("Please enter a name.");
                }
                if (string.IsNullOrWhiteSpace(Surname))
                {
                    throw new Exception("Please enter a surname.");
                }
                if (string.IsNullOrWhiteSpace(Email))
                {
                    throw new Exception("Please enter an email.");
                }
                if (!IsValidEmail(Email))
                {
                    throw new Exception("Please enter a valid email address.");
                }
                LogMessage($"Starting to add contact: {Name}, {Surname}, {Email}");

                Thread thread = new Thread(() =>
                {
                    Contato novoContato = new Contato(Name, Surname, Email);
                    contatos.Add(novoContato);

                    // Atualiza a interface do usuário na thread de UI principal
                    BeginInvoke((Action)AtualizarListView);
                    BeginInvoke((Action)ContagemUser);
                    subjectObservado.NotificarObservadores("New user added: " + Email);

                    LogMessage($"Contact added successfully: {Name}, {Surname}, {Email}");
                });         
                thread.Start();
            }
            catch (Exception ex)
            {
                LogMessage($"Error adding contact: {ex.Message}");
                erros.Push(new Erro(ex.Message, DateTime.Now));
                subjectObservado.NotificarObservadores("Error: " + ex.Message);
            }
        }
        private void LogMessage(string message)
        {
            Console.WriteLine(message);       
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public void AdicionarObservador(IObservador observador)
        {
            subjectObservado.AdicionarObservador(observador);
        }

        private void IniciarView()
        {
            listViewContatos.View = View.Details;
            listViewContatos.Columns.Add("Name:", 100, HorizontalAlignment.Center);
            listViewContatos.Columns.Add("Surname:", 150, HorizontalAlignment.Left);
            listViewContatos.Columns.Add("Email:", 200, HorizontalAlignment.Left);

            listViewContatos.View = View.Details;

            listViewContatos.FullRowSelect = true;
            listViewContatos.GridLines = true;
        }

        private void AtualizarListView()
        {
            listViewContatos.Items.Clear();
            string filtroEmail = textProcurar.Text.ToLower();

            foreach (Contato contato in contatos)
            {
                ListViewItem item = new ListViewItem(new[] { contato.Name, contato.Surname, contato.Email });
                listViewContatos.Items.Add(item);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listViewContatos.Items.Clear();
            var contatosFiltrados = contatos.Where(c => c.Email.ToLower().Contains(textProcurar.Text)).ToList();
            foreach (var contatos in contatosFiltrados)
            {
                ListViewItem item = new ListViewItem(new[] { contatos.Name, contatos.Surname, contatos.Email });
                listViewContatos.Items.Add(item);
                listViewContatos.Focus();
                item.Selected = true;
                listViewContatos.TopItem = item;
                break;
            }
        }

        private void btncCrescente_Click(object sender, EventArgs e)
        {
            listViewContatos.Items.Clear();
            var contatosFiltrados = contatos.OrderBy(c => c.Email).ToList();
            foreach (var contatos in contatosFiltrados)
            {
                ListViewItem item = new ListViewItem(new[] { contatos.Name, contatos.Surname, contatos.Email });
                listViewContatos.Items.Add(item);
            }
        }

        private void btnDecrecente_Click(object sender, EventArgs e)
        {
            listViewContatos.Items.Clear();
            var contatosFiltrados = contatos.OrderByDescending(c => c.Email).ToList();
            foreach (var contatos in contatosFiltrados)
            {
                ListViewItem item = new ListViewItem(new[] { contatos.Name, contatos.Surname, contatos.Email });
                listViewContatos.Items.Add(item);
            }
        }

        private void bntCalcel_Click(object sender, EventArgs e)
        {
            AtualizarListView();
            subjectObservado.NotificarObservadores("Cancellation operation carried out.");
        }

        private void btnMostrarErros_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Erro erro in erros)
            {
                sb.AppendLine($"[{erro.Horario}] {erro.Mensagem}");
            }
            MessageBox.Show(sb.ToString(), "Error Log", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ContagemUser()
        {
            lblContagemUsuarios.Text = $"Total users: {contatos.Count}";
        }
    }
}

public class Contato
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }

    public Contato(string name, string surname, string email)
    {
        Name = name;
        Surname = surname;
        Email = email;
    }
}

public class Erro
{
    public string Mensagem { get; set; }
    public DateTime Horario { get; set; }

    public Erro(string mensagem, DateTime horario)
    {
        Mensagem = mensagem;
        Horario = horario;
    }
}