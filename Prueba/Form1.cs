namespace Prueba
{
    public partial class Form1 : Form
    {
        int Var = 0;
        int globalValue = 0;
        int radCirculo = 0;
        int Diametro = 0;
        Circulo c = new Circulo();
        Cuadrado cu = new Cuadrado();
        Triangulo tr = new Triangulo();
        Cubo cub = new Cubo();
        Esfera es = new Esfera();
        Tetraedro te = new Tetraedro();
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
            txtValor1.Clear();
            txtValor2.Clear();
            lblREsultado1.Text = "";
            lblResultado2.Text = "";
            lblResultado3.Text = "";

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
                        lblDescription1.Visible = true;
                        lblDescription2.Visible = true;
                        lblREsultado1.Visible = true;
                        lblResultado2.Visible = true;
                        txtValor1.Visible = true;
                        lblActualizar.Text = "Lado";
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
                        lblActualizar.Text = "Base";
                        lblActual2.Text = "Altura";
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
                            lblDescription1.Visible = true;
                            lblDescription2.Visible = true;
                            lblREsultado1.Visible = true;
                            lblResultado2.Visible = true;
                            txtValor1.Visible = true;
                            lblActualizar.Text = "Lado";
                            lblDescription1.Text = "Area:";
                            lblDescription2.Text = "Volumen:";
                            globalValue = 3;
                            break;
                        case 1:
                            pctImagen.Image = Image.FromFile(Application.StartupPath + "\\" + "esfera.png");
                            lblActualizar.Visible = true;
                            lblDescription1.Visible = true;
                            lblDescription2.Visible = true;
                            lblREsultado1.Visible = true;
                            lblResultado2.Visible = true;
                            txtValor1.Visible = true;
                            lblActualizar.Text = "Radio";
                            lblDescription1.Text = "Area:";
                            lblDescription2.Text = "Volumen:";
                            globalValue = 4;
                            break;

                        case 2:
                            pctImagen.Image = Image.FromFile(Application.StartupPath + "\\" + "tetraedro.png");
                            lblActualizar.Visible = true;
                            lblDescription1.Visible = true;
                            lblDescription2.Visible = true;
                            lblREsultado1.Visible = true;
                            lblResultado2.Visible = true;
                            txtValor1.Visible = true;
                            lblActualizar.Text = "Lado";
                            lblActual2.Text = "Volumen";
                            lblDescription1.Text = "Area:";
                            lblDescription2.Text = "Volumen:";
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
                    radCirculo = int.Parse(txtValor1.Text);
                    if (chkbox2.Checked == true)
                    {
                        c.CalcularArea(radCirculo / 2);
                        c.CalcularPerimetro(radCirculo / 2);
                    }
                    else
                    {
                        c.CalcularArea(radCirculo);
                        c.CalcularPerimetro(radCirculo);
                    }
                    lblREsultado1.Text = Convert.ToString(c.Area);
                    lblResultado2.Text = Convert.ToString(c.Perimetro);
                    break;
                case 1:
                    double lado = double.Parse(txtValor1.Text);
                    cu.CalcularArea(lado);
                    cu.CalcularPerimetro(lado);
                    lblREsultado1.Text = Convert.ToString(cu.Area);
                    lblResultado2.Text = Convert.ToString(cu.Perimetro);
                    break;
                case 2:
                    if(chkbxAlturaChecker.Checked == true)
                    {
                        double LadoArriba = Convert.ToDouble(txtValor1.Text);
                        double LadoAbajo = Convert.ToDouble(txtValor2.Text);
                        tr.CalcularAltura(LadoArriba, LadoAbajo);
                        tr.CalcularArea(LadoAbajo, tr.Altura);
                        tr.CalcularPerimetro(LadoAbajo);
                    }
                    else
                    {
                        double Base = Convert.ToDouble(txtValor1.Text);
                        double Altura = Convert.ToDouble(txtValor2.Text);
                        tr.CalcularArea(Base, Altura);
                        tr.CalcularPerimetro(Base);
                    }
                    
                    lblREsultado1.Text = Convert.ToString(tr.Area);
                    lblResultado2.Text = Convert.ToString(tr.Perimetro);
                    break;
                case 3:
                    double Lado = Convert.ToDouble(txtValor1.Text);
                    cub.CalcularArea(Lado);
                    cub.CalcularVolumen(Lado);
                    lblREsultado1.Text = Convert.ToString(cub.Area);
                    lblResultado2.Text = Convert.ToString(cub.Volume);
                    break;
                case 4:
                    double radio = Convert.ToDouble(txtValor1.Text);
                    es.CalcularArea(radio);
                    es.CalcularVolumen(radio);
                    lblREsultado1.Text = Convert.ToString(es.Area);
                    lblResultado2.Text = Convert.ToString(es.Volume);
                    break;
                case 5:
                    double lado2 = Convert.ToDouble(txtValor1.Text);
                    te.CalcularArea(lado2);
                    te.CalcularVolumen(lado2);
                    lblREsultado1.Text = Convert.ToString(te.Area);
                    lblResultado2.Text = Convert.ToString(te.Volume);
                    break;
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
            if(chkbxAlturaChecker.Checked == true)
            {
                lblActualizar.Text = "Lado Superior";
                lblActual2.Text = "Lado Inferior";
                lblDescription3.Visible = true;
                lblDescription3.Text = "Altura:";
                lblResultado3.Visible = true;

            }
            else
            {

            }
        }
    }
}