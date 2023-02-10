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
    /// Lógica interna para CursoWindow.xaml
    /// </summary>
    public partial class CursoWindow : Window
    {
        public CursoWindow()
        {
            InitializeComponent();
        }

        private void inserirclick(object sender, RoutedEventArgs e)
        {
            //Novo objeto com os dados da diretoria que será inserida
            int id = int.Parse(txtid.Text);
            string nome = txtnome.Text;
            string sigla = txtsigla.Text;
            Curso c = new Curso();
            c.id = int.Parse(txtid.Text);
            c.idDiretoria = int.Parse(txtiddiretoria.Text);
            c.nome = txtnome.Text;
            c.sigla = txtsigla.Text;
            //Inserir a diretoria na lista de diretorias
            nCurso.Inserir(c);
            //Lista a diretoria inserida
            listarclick(sender, e);
        }

        private void listarclick(object sender, RoutedEventArgs e)
        {
            listCursos.ItemsSource = null;
            listCursos.ItemsSource = nCurso.Listar();
        }

        private void attclick(object sender, RoutedEventArgs e)
        {
            Curso c = new Curso();
            c.id = int.Parse(txtid.Text);
            c.idDiretoria = int.Parse(txtiddiretoria.Text);
            c.nome = txtnome.Text;
            c.sigla = txtsigla.Text;
            //Inserir a diretoria na lista de diretorias
            nCurso.Atualizar(c);
            listarclick(sender, e);
        }

        private void excluirclick(object sender, RoutedEventArgs e)
        {
            //Novo objeto com os dados da diretoria que será inserida
            Curso c = new Curso();
            c.id = int.Parse(txtid.Text);
            c.idDiretoria = int.Parse(txtiddiretoria.Text);
            c.nome = txtnome.Text;
            c.sigla = txtsigla.Text;
            //Inserir a diretoria na lista de diretorias
            nCurso.Excluir(c);
            listarclick(sender, e);
        }
        private void listCursos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listCursos.SelectedItem != null)
            {
                Curso obj = (Curso)listCursos.SelectedItem;
                txtid.Text = obj.id.ToString();
                txtnome.Text = obj.nome;
                txtsigla.Text = obj.sigla;
            }
        }
    }
}
