using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DiretoriaAcademica
{
    /// <summary>
    /// Lógica interna para DiretoriaWindow.xaml
    /// </summary>
    public partial class DiretoriaWindow : Window
    {
        public DiretoriaWindow()
        {
            InitializeComponent();
        }

        private void inserirclick(object sender, RoutedEventArgs e)
        {
            //Novo objeto com os dados da Diretoria que será inserida
            Diretoria t = new Diretoria();
            t.id = int.Parse(txtid.Text);
            t.nome = txtnome.Text;
            t.sigla = txtsigla.Text;
            //Inserir a Diretoria na lista de Diretorias
            nDiretoria.Inserir(t);
            //Lista a Diretoria inserida
            listarclick(sender, e);
        }

        private void listarclick(object sender, RoutedEventArgs e)
        {
            listDiretoria.ItemsSource = null;
            listDiretoria.ItemsSource = nDiretoria.Listar();
        }
        private void attclick(object sender, RoutedEventArgs e)
        {
            //Novo objeto com os dados da Diretoria que será inserida
            Diretoria t = new Diretoria();
            t.id = int.Parse(txtid.Text);
            t.nome = txtnome.Text;
            t.sigla = txtsigla.Text;
            //Inserir a Diretoria na lista de Diretorias
            nDiretoria.Atualizar(t);
            listarclick(sender, e);
        }

        private void excluirclick(object sender, RoutedEventArgs e)
        {

            //Novo objeto com os dados da Diretoria que será inserida
            Diretoria t = new Diretoria();
            t.id = int.Parse(txtid.Text);
            t.nome = txtnome.Text;
            t.sigla = txtsigla.Text;
            //Inserir a Diretoria na lista de Diretorias
            nDiretoria.Excluir(t);
            listarclick(sender, e);
        }
    }
}
