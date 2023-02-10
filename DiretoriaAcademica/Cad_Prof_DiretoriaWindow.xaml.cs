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
    /// Lógica interna para Cad_Prof_DiretoriaWindow.xaml
    /// </summary>
    public partial class Cad_Prof_DiretoriaWindow : Window
    {
        public Cad_Prof_DiretoriaWindow()
        {
            InitializeComponent();
        }

        private void buttonlist(object sender, RoutedEventArgs e)
        {
            listProfessores.ItemsSource = null;
            listProfessores.ItemsSource = nProfessor.Listar();
            listDiretoria.ItemsSource = null;
            listDiretoria.ItemsSource = nDiretoria.Listar();
        }

        private void buttonmatric(object sender, RoutedEventArgs e)
        {
            if (listDiretoria.SelectedItem != null && listProfessores.SelectedItem != null)
            {
                Professor p = (Professor)listProfessores.SelectedItem;
                Diretoria d = (Diretoria)listDiretoria.SelectedItem;
                nProfessor.Matricular(p, d);
                buttonlist(sender, e);
            }
            else
            {
                MessageBox.Show("É preciso selecionar um Professor e uma diretoria");
            }
        }
    }
}