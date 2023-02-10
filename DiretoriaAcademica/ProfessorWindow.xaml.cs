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
    /// Lógica interna para ProfessorWindow.xaml
    /// </summary>
    public partial class ProfessorWindow : Window
    {
        public ProfessorWindow()
        {
            InitializeComponent();
        }
        private void inserirclick(object sender, RoutedEventArgs e)
        {
            //Novo objeto com os dados da diretoria que será inserida
            int id = int.Parse(txtid.Text);
            string nome = txtnome.Text;
            string mat = txtmatricula.Text;
            Professor c = new Professor();
            c.id = int.Parse(txtid.Text);
            c.idDiretoria = int.Parse(txtiddiretoria.Text);
            c.nome = txtnome.Text;
            c.matricula = txtmatricula.Text;
            //Inserir a diretoria na lista de diretorias
            nProfessor.Inserir(c);
            //Lista a diretoria inserida
            listarclick(sender, e);
        }

        private void listarclick(object sender, RoutedEventArgs e)
        {
            listProfessores.ItemsSource = null;
            listProfessores.ItemsSource = nProfessor.Listar();
        }

        private void attclick(object sender, RoutedEventArgs e)
        {
            Professor c = new Professor();
            c.id = int.Parse(txtid.Text);
            c.idDiretoria = int.Parse(txtiddiretoria.Text);
            c.nome = txtnome.Text;
            c.matricula = txtmatricula.Text;
            //Inserir a diretoria na lista de diretorias
            nProfessor.Atualizar(c);
            listarclick(sender, e);
        }

        private void excluirclick(object sender, RoutedEventArgs e)
        {
            //Novo objeto com os dados da diretoria que será inserida
            Professor c = new Professor();
            c.id = int.Parse(txtid.Text);
            c.idDiretoria = int.Parse(txtiddiretoria.Text);
            c.nome = txtnome.Text;
            c.matricula = txtmatricula.Text;
            //Inserir a diretoria na lista de diretorias
            nProfessor.Excluir(c);
            listarclick(sender, e);
        }
        private void listProfessores_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listProfessores.SelectedItem != null)
            {
                Professor obj = (Professor)listProfessores.SelectedItem;
                txtid.Text = obj.id.ToString();
                txtnome.Text = obj.nome;
                txtmatricula.Text = obj.matricula;
                txtiddiretoria.Text = obj.idDiretoria.ToString();
            }
        }
    }
}