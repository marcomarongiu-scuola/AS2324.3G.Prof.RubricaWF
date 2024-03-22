namespace AS2324._3G.Prof.RubricaWF
{
    public partial class Form1 : Form
    {
        const int nMaxContatti = 100;

        int nRecordInseriti = 0;


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
            lstElenco.Items.Clear();
            if (cmbRicerca.Text == "" || txtRicerca.Text == "" )
                MessageBox.Show("E' necessario definire il campo di ricerca.");
            string elenco;
            switch (cmbRicerca.Text )
            {
                case "Nome": 
                    for (int i = 0; i < nRecordInseriti; i++)
                    {
                        switch (cmbOpzioni.Text)
                        {
                            case "":
                                if (txtRicerca.Text == nome[i])
                                {
                                    elenco = $"nome: {nome[i]}; cognome: {cognome[i]}; nickname: {nickname[i]}; email: {email[i]}; annoNascita {annoNascita[i]}; simpatia: {simpatia[i]}";
                                    lstElenco.Items.Add(elenco);
                                }
                                break;
                            case "Inizia per":
                                if (nome[i].StartsWith(txtRicerca.Text))
                                {
                                    elenco = $"nome: {nome[i]}; cognome: {cognome[i]}; nickname: {nickname[i]}; email: {email[i]}; annoNascita {annoNascita[i]}; simpatia: {simpatia[i]}";
                                    lstElenco.Items.Add(elenco);
                                }
                                break;
                            case "Finisce per":
                                if (nome[i].EndsWith(txtRicerca.Text))
                                {
                                    elenco = $"nome: {nome[i]}; cognome: {cognome[i]}; nickname: {nickname[i]}; email: {email[i]}; annoNascita {annoNascita[i]}; simpatia: {simpatia[i]}";
                                    lstElenco.Items.Add(elenco);
                                }
                                break;
                            case "Contiene":
                                if (nome[i].Contains(txtRicerca.Text))
                                {
                                    elenco = $"nome: {nome[i]}; cognome: {cognome[i]}; nickname: {nickname[i]}; email: {email[i]}; annoNascita {annoNascita[i]}; simpatia: {simpatia[i]}";
                                    lstElenco.Items.Add(elenco);
                                }
                                break;
                            default:
                                break;
                        }
                        
                    }
                    break;
                case "Cognome":
                    for (int i = 0; i < nRecordInseriti; i++)
                    {
                        switch (cmbOpzioni.Text)
                        {
                            case "":
                                if (txtRicerca.Text == cognome[i])
                                {
                                    elenco = $"nome: {nome[i]}; cognome: {cognome[i]}; nickname: {nickname[i]}; email: {email[i]}; annoNascita {annoNascita[i]}; simpatia: {simpatia[i]}";
                                    lstElenco.Items.Add(elenco);
                                }
                                break;
                            case "Inizia per":
                                if (cognome[i].StartsWith(txtRicerca.Text))
                                {
                                    elenco = $"nome: {nome[i]}; cognome: {cognome[i]}; nickname: {nickname[i]}; email: {email[i]}; annoNascita {annoNascita[i]}; simpatia: {simpatia[i]}";
                                    lstElenco.Items.Add(elenco);
                                }
                                break;
                            case "Finisce per":
                                if (cognome[i].EndsWith(txtRicerca.Text))
                                {
                                    elenco = $"nome: {nome[i]}; cognome: {cognome[i]}; nickname: {nickname[i]}; email: {email[i]}; annoNascita {annoNascita[i]}; simpatia: {simpatia[i]}";
                                    lstElenco.Items.Add(elenco);
                                }
                                break;
                            case "Contiene":
                                if (cognome[i].Contains(txtRicerca.Text))
                                {
                                    elenco = $"nome: {nome[i]}; cognome: {cognome[i]}; nickname: {nickname[i]}; email: {email[i]}; annoNascita {annoNascita[i]}; simpatia: {simpatia[i]}";
                                    lstElenco.Items.Add(elenco);
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case "Nickname":
                    for (int i = 0; i < nRecordInseriti; i++)
                    {
                        switch (cmbOpzioni.Text)
                        {
                            case "":
                                if (txtRicerca.Text == nickname[i])
                                {
                                    elenco = $"nome: {nome[i]}; cognome: {cognome[i]}; nickname: {nickname[i]}; email: {email[i]}; annoNascita {annoNascita[i]}; simpatia: {simpatia[i]}";
                                    lstElenco.Items.Add(elenco);
                                }
                                break;
                            case "Inizia per":
                                if (nickname[i].StartsWith(txtRicerca.Text))
                                {
                                    elenco = $"nome: {nome[i]}; cognome: {cognome[i]}; nickname: {nickname[i]}; email: {email[i]}; annoNascita {annoNascita[i]}; simpatia: {simpatia[i]}";
                                    lstElenco.Items.Add(elenco);
                                }
                                break;
                            case "Finisce per":
                                if (nickname[i].EndsWith(txtRicerca.Text))
                                {
                                    elenco = $"nome: {nome[i]}; cognome: {cognome[i]}; nickname: {nickname[i]}; email: {email[i]}; annoNascita {annoNascita[i]}; simpatia: {simpatia[i]}";
                                    lstElenco.Items.Add(elenco);
                                }
                                break;
                            case "Contiene":
                                if (nickname[i].Contains(txtRicerca.Text))
                                {
                                    elenco = $"nome: {nome[i]}; cognome: {cognome[i]}; nickname: {nickname[i]}; email: {email[i]}; annoNascita {annoNascita[i]}; simpatia: {simpatia[i]}";
                                    lstElenco.Items.Add(elenco);
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    break;

                default:
                    break;
            }
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
                cognome[nRecordInseriti] = txtCognome.Text;
                controllo = true;
            }

            if (txtNome.Text == "")
            {
                MessageBox.Show("E' necessario definire il campo di ricerca.");
                controllo = false;
            }
            else
            {
                nome[nRecordInseriti] = txtNome.Text;
                controllo = true;
            }

            if (txtEmail.Text == "")
            {
                MessageBox.Show("E' necessario definire il campo di ricerca.");
                controllo = false;
            }
            else
            {
                email[nRecordInseriti] = txtEmail.Text;
                controllo = true;
            }

            if (txtNickName.Text == "")
            {
                MessageBox.Show("E' necessario definire il campo di ricerca.");
                controllo = false;
            }
            else
            {
                nickname[nRecordInseriti] = txtNickName.Text;
                controllo = true;
            }

            if (txtAnnoNascita.Text == "")
            {
                MessageBox.Show("E' necessario definire il campo di ricerca.");
                controllo = false;
            }
            else
            {
                annoNascita[nRecordInseriti] = Convert.ToInt32(txtAnnoNascita.Text);
                controllo = true;
            }

            if (cmbSimpatia.Text == "")
            {
                MessageBox.Show("E' necessario definire il campo di ricerca.");
                controllo = false;
            }
            else
            {
                simpatia[nRecordInseriti] = Convert.ToInt32(cmbSimpatia.Text);
                controllo = true;
            }

            if (controllo == true)
            {
                nRecordInseriti++;
                lblNRecord.Text = $"N. record inseriti : {nRecordInseriti}";
            }
        }

        private void btnElenca_Click(object sender, EventArgs e)
        {
            lstElenco.Items.Clear();
            string elenco;
            //ciclo per stampare l'elenco
            for (int i = 0; i < nRecordInseriti; i++)
            {
                elenco = $"nome: {nome[i]}; cognome: {cognome[i]}; nickname: {nickname[i]}; email: {email[i]}; annoNascita {annoNascita[i]}; simpatia: {simpatia[i]}";
                lstElenco.Items.Add(elenco);
            }

        }


    }
}
