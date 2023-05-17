using System.IO;
using System.Reflection;
using System.Windows.Controls;

namespace PerfApp.RichEditModule {
    public partial class RichEditView : UserControl {
        public RichEditView() {
            InitializeComponent();
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "PerfApp.Data.FirstLook.docx";
            var stream = assembly.GetManifestResourceStream(resourceName);
            rich.LoadDocument(stream);
        }
    }
}
