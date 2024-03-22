namespace AS2324._3G.Prof.RubricaWF
{
    public partial class Form1 : Form
    {
        const int nMaxContatti = 100;

        int nRecordInseriti = 0;

        int cont = 0;

        // definizione array paralleli
        string[] cognome = new string[nMaxContatti];
        string[] nome = new string[nMaxContatti];
        string[] email = new string[nMaxContatti];
        string[] nickname = new string[nMaxContatti];
        int[] simpatia = new int[nMaxContatti];
        int[] annoNascita = new int[nMaxContatti];
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRicerca_Click(object sender, EventArgs e)
        {
            if (cmbRicerca.Text == "")
                MessageBox.Show("E' necessario definire il campo di ricerca.");
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            bool controllo = false;

            if (txtCognome.Text == "")
            {
                MessageBox.Show("E' necessario definire il campo di ricerca.");
                controllo = false;
            }
            else
            {
                cognome[cont] = txtCognome.Text;
                controllo = true;
            }

            if (txtNome.Text == "")
            {
                MessageBox.Show("E' necessario definire il campo di ricerca.");
                controllo = false;
            }
            else
            {
                nome[cont] = txtNome.Text;
                controllo = true;
            }

            if (txtEmail.Text == "")
            {
                MessageBox.Show("E' necessario definire il campo di ricerca.");
                controllo = false;
            }
            else
            {
                email[cont] = txtEmail.Text;
                controllo = true;
            }

            if (txtNickName.Text == "")
            {
                MessageBox.Show("E' necessario definire il campo di ricerca.");
                controllo = false;
            }
            else
            {
                nickname[cont] = txtNickName.Text;
                controllo = true;
            }

            if (txtAnnoNascita.Text == "")
            {
                MessageBox.Show("E' necessario definire il campo di ricerca.");
                controllo = false;
            }
            else
            {
                annoNascita[cont] = Convert.ToInt32(txtAnnoNascita.Text);
                controllo = true;
            }

            if (cmbSimpatia.Text == "")
            {
                MessageBox.Show("E' necessario definire il campo di ricerca.");
                controllo = false;
            }
            else
            {
                simpatia[cont] = Convert.ToInt32(cmbSimpatia.Text);
                controllo = true;
            }

            if (controllo == true)  
            {
                cont++;
                nRecordInseriti++;
                lblNRecord.Text = $"N. record inseriti : {nRecordInseriti}";
            }
        }

        private void btnElenca_Click(object sender, EventArgs e)
        {
            lstElenco.Items.Clear();
            string elenco;
            //ciclo per stampare l'elenco
            for(int i = 0; i < nRecordInseriti; i++)
            {
                elenco = $"nome: {nome[i]}; cognome: {cognome[i]}; nickname: {nickname[i]}; email: {email[i]}; annoNascita {annoNascita[i]}; simpatia: {simpatia[i]}";
                lstElenco.Items.Add(elenco);
            }
            
        }
    }
}
