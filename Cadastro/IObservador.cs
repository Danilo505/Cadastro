using System.Collections.Generic;
using System.Windows.Forms;


namespace Cadastro
{
    public class IObservador
    {
       public void Update(string mensagem)
        {
            MessageBox.Show(mensagem);
        }
    }
}
namespace Cadastro
{
    public class SubjectObservado
    {
        private List<IObservador> observadores = new List<IObservador>();

        public void AdicionarObservador(IObservador observador)
        {
            observadores.Add(observador);
        }

        public void NotificarObservadores(string mensagem)
        {
            foreach (var observador in observadores)
            {
                observador.Update(mensagem);
            }
        }
    }
}