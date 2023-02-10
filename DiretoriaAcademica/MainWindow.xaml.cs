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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DiretoriaAcademica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Diretoria_click(object sender, RoutedEventArgs e)
        {
            DiretoriaWindow dw = new DiretoriaWindow();
            dw.ShowDialog();
        }

        private void Professor_click(object sender, RoutedEventArgs e)
        {
           ProfessorWindow pw = new ProfessorWindow();
            pw.ShowDialog();
        }
        private void Curso_click(object sender, RoutedEventArgs e)
        {
            CursoWindow cw = new CursoWindow();
            cw.ShowDialog();
        }

        private void RegistroP_click(object sender, RoutedEventArgs e)
        {
            Cad_Prof_DiretoriaWindow cpd = new Cad_Prof_DiretoriaWindow();
            cpd.ShowDialog();
        }

        private void RegistroC_click(object sender, RoutedEventArgs e)
        {
            Cad_Curso_DiretoriaWindow ccd = new Cad_Curso_DiretoriaWindow();
            ccd.ShowDialog();
        }

        private void ListaC_click(object sender, RoutedEventArgs e)
        {
            List_Curso_DiretoriaWindow lc = new List_Curso_DiretoriaWindow();
            lc.ShowDialog();
        }

        private void ListaP_click(object sender, RoutedEventArgs e)
        {
            List_Prof_DiretoriaWindow lp = new List_Prof_DiretoriaWindow();
            lp.ShowDialog();
        }
    }
}
