using System.Windows.Forms;

namespace CompareApp
{
    public partial class ExpertInstructions : Form
    {
        private ExpertConfiguring _experts;
        
        public ExpertInstructions(ExpertConfiguring experts)
        {
            _experts = experts;
            _experts.Enabled = false;
            
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
            => _experts.Enabled = true;
    }
}