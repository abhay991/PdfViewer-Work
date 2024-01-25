using System.Windows;
using Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.Filters;

namespace PDFViewer___Core6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        #region Default Constructor
        public MainWindow()
        {
            filter = new JpxDecoder();
            FiltersManager.RegisterFilter(filter);

            InitializeComponent();
        }
        #endregion

        #region Private Fields
        private JpxDecoder filter;
        #endregion
    }
}
