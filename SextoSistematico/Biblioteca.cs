namespace SextoSistematico
{
    public partial class frmMultiUsos : Form
    {
        public frmMultiUsos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Romance romance = new Romance();
            romance.TopLevel = false;
            romance.Show();
            romance.Dock = DockStyle.Fill;
            scDivididor.Panel2.Controls.Add(romance);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            btnRomance.BackColor = Color.Gray;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btnRomance.BackColor = Color.Silver;
        }

        private void btnFiccion_Click(object sender, EventArgs e)
        {

        }

        private void btnFiccion_MouseEnter(object sender, EventArgs e)
        {
            btnFiccion.BackColor = Color.Gray;
        }

        private void btnFiccion_MouseLeave(object sender, EventArgs e)
        {
            btnFiccion.BackColor = Color.Silver;
        }

        private void btnTerror_Click(object sender, EventArgs e)
        {

        }

        private void btnTerror_MouseEnter(object sender, EventArgs e)
        {
            btnTerror.BackColor = Color.Gray;
        }

        private void btnTerror_MouseLeave(object sender, EventArgs e)
        {
            btnTerror.BackColor = Color.Silver;
        }

        private void btnFantasia_Click(object sender, EventArgs e)
        {

        }

        private void btnFantasia_MouseEnter(object sender, EventArgs e)
        {
            btnFantasia.BackColor = Color.Gray;
        }

        private void btnFantasia_MouseLeave(object sender, EventArgs e)
        {
            btnFantasia.BackColor = Color.Silver;
        }

        private void btnEspirituales_Click(object sender, EventArgs e)
        {

        }

        private void btnEspirituales_MouseEnter(object sender, EventArgs e)
        {
            btnEspirituales.BackColor = Color.Gray;
        }

        private void btnEspirituales_MouseLeave(object sender, EventArgs e)
        {
            btnEspirituales.BackColor = Color.Silver;
        }

        private void btnThrillers_Click(object sender, EventArgs e)
        {

        }

        private void btnThrillers_MouseEnter(object sender, EventArgs e)
        {
            btnThrillers.BackColor = Color.Gray;
        }

        private void btnThrillers_MouseLeave(object sender, EventArgs e)
        {
            btnThrillers.BackColor = Color.Silver;
        }
    }
}