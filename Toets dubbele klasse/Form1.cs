namespace Toets_dubbele_klasse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDoelPunt_Click(object sender, EventArgs e)
        {
            if (lstSpeler.SelectedIndex != null)
            {

            }
            else
            {
                MessageBox.Show("Er ging iets mis.");
            }
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            if (lstSpeler.SelectedIndex != null)
            {

            }
            else
            {
                MessageBox.Show("Er ging iets mis.");
            }
        }

        private void btnPloegAanmaken_Click(object sender, EventArgs e)
        {
           
            if (txtNaamPloeg.Text != null)
            {
                List<Ploeg> objPloeg = new List<Ploeg>();
                
                txtNaamPloeg.Clear();

                
            }
            else
            {
                MessageBox.Show("Er ging iets mis.");
            }
        }

        private void btnSpelerAanmaken_Click(object sender, EventArgs e)
        {
            if (lstPloeg.SelectedIndex!=null)
            {
                
            }
            else
            {
                MessageBox.Show("Er ging iets mis.");
            }
        }
    }
}
