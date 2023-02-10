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
    /// Lógica interna para List_Curso_DiretoriaWindow.xaml
    /// </summary>
    public partial class List_Curso_DiretoriaWindow : Window
    {
        public List_Curso_DiretoriaWindow()
        {
            InitializeComponent();
        }

        private void buttonlist(object sender, RoutedEventArgs e)
        {
                if (listDiretoria.SelectedItem != null)
                {
                    Diretoria d = (Diretoria)listDiretoria.SelectedItem;
                    listCursos.ItemsSource = null;
                    listCursos.ItemsSource = nCurso.Listar(d);
                }
                else
                    MessageBox.Show("É preciso selecionar uma diretoria");
            }
        }
    }