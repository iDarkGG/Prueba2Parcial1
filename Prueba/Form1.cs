namespace Prueba
{
    public partial class Form1 : Form
    {
        int Var = 0;
        int globalValue = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            chkbxAlturaChecker.Visible = false;
            chkbox2.Visible = false;
            lblActualizar.Visible = false;
            lblActual2.Visible = false;
            lblDescription1.Visible = false;
            lblDescription2.Visible = false;
            lblDescription3.Visible = false;
            lblREsultado1.Visible = false;
            lblResultado2.Visible = false;
            lblResultado3.Visible = false;
            txtValor1.Visible = false;
            txtValor2.Visible = false;

            int itemnum = cbxFiguras.SelectedIndex;

            if (Var == 1)
            {
                switch (itemnum)
                {
                    case 0:
                        pctImagen.Image = Image.FromFile(Application.StartupPath +"\\"+ "circulo.png");
                        chkbox2.Visible = true;
                        lblActualizar.Visible = true;
                        lblDescription1.Visible = true;
                        lblDescription2.Visible = true;
                        lblREsultado1.Visible = true;
                        lblResultado2.Visible = true;
                        txtValor1.Visible = true;
                        lblActualizar.Text = "Radio";
                        lblDescription1.Text = "Area:";
                        lblDescription2.Text = "Perimetro:";
                        globalValue = 0;
                        break;
                        case 1:
                        pctImagen.Image = Image.FromFile(Application.StartupPath + "\\" + "cuadrado.png");
                        lblActualizar.Visible = true;
                        lblActual2.Visible = true;
                        lblDescription1.Visible = true;
                        lblDescription2.Visible = true;
                        lblREsultado1.Visible = true;
                        lblResultado2.Visible = true;
                        txtValor1.Visible = true;
                        lblDescription1.Text = "Area:";
                        lblDescription2.Text = "Perimetro:";
                        globalValue = 1;
                        break;

                    case 2:
                        pctImagen.Image = Image.FromFile(Application.StartupPath + "\\" + "triangulo.png");
                        chkbxAlturaChecker.Visible = true;
                        lblActualizar.Visible = true;
                        lblActual2.Visible = true;
                        lblDescription1.Visible = true;
                        lblDescription2.Visible = true;
                        lblREsultado1.Visible = true;
                        lblResultado2.Visible = true;
                        txtValor1.Visible = true;
                        txtValor2.Visible = true;
                        lblDescription1.Text = "Area:";
                        lblDescription2.Text = "Perimetro:";
                        globalValue = 2;
                        break;
                    
                }
            }
            else
            {
                if (Var == 2)
                {
                    switch (itemnum)
                    {
                        case 0:
                            pctImagen.Image = Image.FromFile(Application.StartupPath + "\\" + "cubo.png");
                            lblActualizar.Visible = true;
                            lblActual2.Visible = true;
                            lblDescription1.Visible = true;
                            lblDescription2.Visible = true;
                            lblDescription3.Visible = true;
                            lblREsultado1.Visible = true;
                            lblResultado2.Visible = true;
                            lblResultado3.Visible = true;
                            txtValor1.Visible = true;
                            txtValor2.Visible = true;
                            globalValue = 3;
                            break;
                        case 1:
                            pctImagen.Image = Image.FromFile(Application.StartupPath + "\\" + "esfera.png");
                            lblActualizar.Visible = true;
                            lblActual2.Visible = true;
                            lblDescription1.Visible = true;
                            lblDescription2.Visible = true;
                            lblDescription3.Visible = true;
                            lblREsultado1.Visible = true;
                            lblResultado2.Visible = true;
                            lblResultado3.Visible = true;
                            txtValor1.Visible = true;
                            txtValor2.Visible = true;
                            globalValue = 4;
                            break;

                        case 2:
                            pctImagen.Image = Image.FromFile(Application.StartupPath + "\\" + "tetraedro.png");
                            lblActualizar.Visible = true;
                            lblActual2.Visible = true;
                            lblDescription1.Visible = true;
                            lblDescription2.Visible = true;
                            lblDescription3.Visible = true;
                            lblREsultado1.Visible = true;
                            lblResultado2.Visible = true;
                            lblResultado3.Visible = true;
                            txtValor1.Visible = true;
                            txtValor2.Visible = true;
                            globalValue = 5;
                            break;

                    }
                }

            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chkbxAlturaChecker.Visible = false;
            chkbox2.Visible = false;
            lblActualizar.Visible = false;
            lblActual2.Visible = false;
            lblDescription1.Visible = false;
            lblDescription2.Visible = false;
            lblDescription3.Visible = false;
            lblREsultado1.Visible = false;
            lblResultado2.Visible = false;
            lblResultado3.Visible = false;
            txtValor1.Visible = false;
            txtValor2.Visible = false;
            

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxFiguras.Items.Clear();
            int itemnum2 = cbxTipo.SelectedIndex;

            switch (itemnum2)
            {
                case 0:
                    cbxFiguras.Items.Add("Circulo");
                    cbxFiguras.Items.Add("Cuadrado");
                    cbxFiguras.Items.Add("Triangulo");
                    Var = 1;
                    break;
                case 1:
                    cbxFiguras.Items.Add("Cubo");
                    cbxFiguras.Items.Add("Esfera");
                    cbxFiguras.Items.Add("Tetraedro");
                    Var = 2;
                    break;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Esta seguro que quiere salir?", "Calculadora", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                );

            if (d == DialogResult.Yes)
                this.Close();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            switch (globalValue)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
            }


            if (chkbxAlturaChecker.Checked == true)
            {
                lblActualizar.Text = "Lado Superior";
                lblActual2.Text = "Lado Inferior";
                lblActualizar.Visible = true;
                lblActual2.Visible = true;
            }
        }

        private void chkbox2_CheckedChanged(object sender, EventArgs e)
        {
            if(chkbox2.Checked == true)
            {
                lblActualizar.Text = "Diametro";
            }
        }

        private void chkbxAlturaChecker_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}