using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace BasicXAMLProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            CommandBinding copyCommand = new CommandBinding(ApplicationCommands.Copy);
            CommandBinding pasteCommand = new CommandBinding(ApplicationCommands.Paste);
            this.CommandBindings.Add(copyCommand);
            this.CommandBindings.Add(pasteCommand);
            copyCommand.Executed += new ExecutedRoutedEventHandler(copyCommand_Executed);
            pasteCommand.Executed += new ExecutedRoutedEventHandler(pasteCommand_Executed);
        }

        private void pasteCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Debug.WriteLine("Paste exceuted");
        }

        private void copyCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Debug.WriteLine("Copy exceuted");
        }
    }
}
