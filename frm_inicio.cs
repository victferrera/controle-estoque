using System.Windows.Forms;

namespace EstoqueApp
{
    public partial class frm_inicio : Form
    {
        public frm_inicio()
        {
            InitializeComponent();
        }

        private void lbl_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                LinkLabel.LinkLabel_Actions.OpenLinkOnBrowser();
            }catch
            {
                MessageBox.Show("Não foi possível abrir o Link!");
            }
        }
    }
}
