using System.Windows.Controls;

namespace YüzKişiyeSorduk
{
    /// <summary>
    /// Interaction logic for SoruView.xaml
    /// </summary>
    public partial class SoruView : UserControl
    {
        public SoruView()
        {
            InitializeComponent();
            DataContext = new SoruViewModel();
        }
    }
}