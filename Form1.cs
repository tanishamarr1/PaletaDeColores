namespace PaletaDeColores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Rojo_Click(object sender, EventArgs e)
        {
            Paleta.BackColor = Color.Red;
            paletaText.Text = Rojo.Name;
            paletaText.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Paleta.BackColor = Color.Aqua;
            paletaText.Text = "Aqua";
            paletaText.Visible = true;
        }

        private void Azul_Click(object sender, EventArgs e)
        {
            Paleta.BackColor = Color.Blue;
            paletaText.Text = Azul.Name;
            paletaText.Visible = true;
        }

        private void Pink_Click(object sender, EventArgs e)
        {
            Paleta.BackColor = Color.Pink;
            paletaText.Text = Pink.Name;
            paletaText.Visible = true;
        }

        private void Purple_Click(object sender, EventArgs e)
        {
            Paleta.BackColor = Color.Purple;
            paletaText.Text = Purple.Name;
            paletaText.Visible = true;
        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            Paleta.BackColor = Color.Yellow;
            paletaText.Text = Yellow.Name;
            paletaText.Visible = true;
        }

        private void Gray_Click(object sender, EventArgs e)
        {
            Paleta.BackColor = Color.Gray;
            paletaText.Text = Gray.Name;
            paletaText.Visible = true;
        }

        private void Orange_Click(object sender, EventArgs e)
        {
            Paleta.BackColor = Color.Orange;
            paletaText.Text = Orange.Name;
            paletaText.Visible = true;
        }

        private void Black_Click(object sender, EventArgs e)
        {
            Paleta.BackColor = Color.Black;
            paletaText.Text = Black.Name;
            paletaText.Visible = true;
        }

        private void Lime_Click(object sender, EventArgs e)
        {
            Paleta.BackColor = Color.Lime;
            paletaText.Text = Lime.Name;
            paletaText.Visible = true;
        }

        private void Green_Click(object sender, EventArgs e)
        {
            Paleta.BackColor = Color.Green;
            paletaText.Text = Green.Name;
            paletaText.Visible = true;
        }

        private void GreenYellow_Click(object sender, EventArgs e)
        {
            Paleta.BackColor = Color.GreenYellow;
            paletaText.Text = "G. Yellow";
            paletaText.Visible = true;
        }

      

        private void limpiarPaleta_Click(object sender, EventArgs e)
        {
            Paleta.BackColor = Color.White;
            paletaText.Visible = false;
        }

        private void Paleta_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
