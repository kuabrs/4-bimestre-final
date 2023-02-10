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
    /// Lógica interna para Cad_Curso_DiretoriaWindow.xaml
    /// </summary>
    public partial class Cad_Curso_DiretoriaWindow : Window
    {
        public Cad_Curso_DiretoriaWindow()
        {
            InitializeComponent();
            listDiretoria.ItemsSource = nDiretoria.Listar();
        }

        private void buttonlist(object sender, RoutedEventArgs e)
        {
            listCursos.ItemsSource = null;
            listCursos.ItemsSource = nCurso.Listar();
            listDiretoria.ItemsSource = null;
            listDiretoria.ItemsSource = nDiretoria.Listar();
        }

        private void buttonmatric(object sender, RoutedEventArgs e)
        {
            if (listDiretoria.SelectedItem != null && listCursos.SelectedItem != null)
            {
                Curso c = (Curso)listCursos.SelectedItem;
                Diretoria d = (Diretoria)listDiretoria.SelectedItem;
                nCurso.Matricular(c, d);
                buttonlist(sender, e);
            }
            else
            {
                MessageBox.Show("É preciso selecionar um curso e uma diretoria");
            }
        }
    }
}
