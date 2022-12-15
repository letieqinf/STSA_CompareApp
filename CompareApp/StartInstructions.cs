using System.Windows.Forms;

namespace CompareApp
{
    public partial class StartInstructions : Form
    {
        private Start _startForm;
        
        public StartInstructions(Start startForm)
        {
            _startForm = startForm;
            _startForm.Enabled = false;
            
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
            => _startForm.Enabled = true;
    }
}