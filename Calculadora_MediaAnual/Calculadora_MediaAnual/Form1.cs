namespace Calculadora_MediaAnual
{
    public partial class Form1 : Form
    {
        double nota1, nota2, nota3, nota4, mediaAnual;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularMedia_Click(object sender, EventArgs e)
        {


            nota1 = Convert.ToDouble(txtnota1.Text);
            nota2 = Convert.ToDouble(txtnota2.Text);
            nota3 = Convert.ToDouble(txtnota3.Text);
            nota4 = Convert.ToDouble(txtnota4.Text);

            mediaAnual = (nota1 + nota2 + nota3 + nota4) / 4;

            if (mediaAnual >= 7)
            {
                MessageBox.Show("Aprovado! Sua nota é: " + mediaAnual, "Aprovado!");
            }

            else
            {
                MessageBox.Show("Reprovado, realizar exame! Sua média é: " + mediaAnual, "Reprovado!");
                grpExame.Visible = true;
                txtnotaExame.Focus();
                txtnota1.Focus();
            }

            txtmediaAnual.Text = mediaAnual.ToString();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {



        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            DialogResult txt = MessageBox.Show("Deseja sair da aplicação?", "Atenção", MessageBoxButtons.YesNo);

            if (txt == DialogResult.Yes)
            {
                Close();
            }

            else if (txt == DialogResult.No)
            {
                txtnota1.Clear();
                txtnota2.Clear();
                txtnota3.Clear();
                txtnota4.Clear();
                txtmediaAnual.Clear();

                grpExame.Visible = false;
                txtnotaExame.Focus();
                txtnota1.Focus();

            }


        }

        private void btnmediaFinal_Click(object sender, EventArgs e)
        {
            double mediaFinal, notaExame;

            notaExame = Convert.ToDouble(txtnotaExame.Text);

            mediaFinal = (mediaAnual + notaExame) / 2;


            if (mediaFinal >= 7)
            {
                MessageBox.Show("Aprovado! Sua nota final é: " + mediaFinal, "Aprovado!");
            }

            else
            {
                MessageBox.Show("Reprovado! Sua nota final é: " + mediaFinal, "Reprovado!");

            }

        }

        private void btnSair1_Click(object sender, EventArgs e)
        {
            DialogResult txt = MessageBox.Show("Deseja sair da aplicação?", "Atenção", MessageBoxButtons.YesNo);

            if (txt == DialogResult.Yes)
            {
                Close();
            }

            else if (txt == DialogResult.No)
            {
                txtnota1.Clear();
                txtnota2.Clear();
                txtnota3.Clear();
                txtnota4.Clear();
                txtmediaAnual.Clear();
                txtnotaExame.Focus();
                txtnota1.Focus();

            }
        }
    }
}