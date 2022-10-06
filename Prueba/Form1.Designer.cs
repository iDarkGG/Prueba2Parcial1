namespace Prueba
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxFiguras = new System.Windows.Forms.ComboBox();
            this.pctImagen = new System.Windows.Forms.PictureBox();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.lblDescription1 = new System.Windows.Forms.Label();
            this.lblDescription2 = new System.Windows.Forms.Label();
            this.lblREsultado1 = new System.Windows.Forms.Label();
            this.lblResultado2 = new System.Windows.Forms.Label();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.chkbxAlturaChecker = new System.Windows.Forms.CheckBox();
            this.lblActual2 = new System.Windows.Forms.Label();
            this.lblActualizar = new System.Windows.Forms.Label();
            this.lblResultado3 = new System.Windows.Forms.Label();
            this.lblDescription3 = new System.Windows.Forms.Label();
            this.chkbox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxFiguras
            // 
            this.cbxFiguras.FormattingEnabled = true;
            this.cbxFiguras.Location = new System.Drawing.Point(71, 147);
            this.cbxFiguras.Name = "cbxFiguras";
            this.cbxFiguras.Size = new System.Drawing.Size(136, 23);
            this.cbxFiguras.TabIndex = 2;
            this.cbxFiguras.Text = "SELECCIONE FIGURA";
            this.cbxFiguras.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pctImagen
            // 
            this.pctImagen.Location = new System.Drawing.Point(232, 67);
            this.pctImagen.Name = "pctImagen";
            this.pctImagen.Size = new System.Drawing.Size(121, 103);
            this.pctImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctImagen.TabIndex = 0;
            this.pctImagen.TabStop = false;
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Bidimensional",
            "Tridimensional"});
            this.cbxTipo.Location = new System.Drawing.Point(71, 83);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(121, 23);
            this.cbxTipo.TabIndex = 3;
            this.cbxTipo.Text = "SELECCIONE TIPO";
            this.cbxTipo.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lblDescription1
            // 
            this.lblDescription1.AutoSize = true;
            this.lblDescription1.Location = new System.Drawing.Point(237, 302);
            this.lblDescription1.Name = "lblDescription1";
            this.lblDescription1.Size = new System.Drawing.Size(38, 15);
            this.lblDescription1.TabIndex = 4;
            this.lblDescription1.Text = "label1";
            // 
            // lblDescription2
            // 
            this.lblDescription2.AutoSize = true;
            this.lblDescription2.Location = new System.Drawing.Point(237, 348);
            this.lblDescription2.Name = "lblDescription2";
            this.lblDescription2.Size = new System.Drawing.Size(38, 15);
            this.lblDescription2.TabIndex = 5;
            this.lblDescription2.Text = "label2";
            // 
            // lblREsultado1
            // 
            this.lblREsultado1.AutoSize = true;
            this.lblREsultado1.Location = new System.Drawing.Point(311, 302);
            this.lblREsultado1.Name = "lblREsultado1";
            this.lblREsultado1.Size = new System.Drawing.Size(38, 15);
            this.lblREsultado1.TabIndex = 6;
            this.lblREsultado1.Text = "label3";
            // 
            // lblResultado2
            // 
            this.lblResultado2.AutoSize = true;
            this.lblResultado2.Location = new System.Drawing.Point(315, 347);
            this.lblResultado2.Name = "lblResultado2";
            this.lblResultado2.Size = new System.Drawing.Size(38, 15);
            this.lblResultado2.TabIndex = 7;
            this.lblResultado2.Text = "label4";
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(232, 227);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(121, 23);
            this.txtValor1.TabIndex = 8;
            this.txtValor1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(232, 256);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(121, 23);
            this.txtValor2.TabIndex = 9;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(31, 272);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 10;
            this.btnProcesar.Text = "CALCULAR";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(31, 308);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(31, 346);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // chkbxAlturaChecker
            // 
            this.chkbxAlturaChecker.AutoSize = true;
            this.chkbxAlturaChecker.Location = new System.Drawing.Point(232, 191);
            this.chkbxAlturaChecker.Name = "chkbxAlturaChecker";
            this.chkbxAlturaChecker.Size = new System.Drawing.Size(114, 19);
            this.chkbxAlturaChecker.TabIndex = 13;
            this.chkbxAlturaChecker.Text = "¿Calcular Altura?";
            this.chkbxAlturaChecker.UseVisualStyleBackColor = true;
            this.chkbxAlturaChecker.CheckedChanged += new System.EventHandler(this.chkbxAlturaChecker_CheckedChanged);
            // 
            // lblActual2
            // 
            this.lblActual2.AutoSize = true;
            this.lblActual2.Location = new System.Drawing.Point(138, 259);
            this.lblActual2.Name = "lblActual2";
            this.lblActual2.Size = new System.Drawing.Size(38, 15);
            this.lblActual2.TabIndex = 15;
            this.lblActual2.Text = "label2";
            // 
            // lblActualizar
            // 
            this.lblActualizar.AutoSize = true;
            this.lblActualizar.Location = new System.Drawing.Point(138, 230);
            this.lblActualizar.Name = "lblActualizar";
            this.lblActualizar.Size = new System.Drawing.Size(54, 15);
            this.lblActualizar.TabIndex = 14;
            this.lblActualizar.Text = "lblActual";
            // 
            // lblResultado3
            // 
            this.lblResultado3.AutoSize = true;
            this.lblResultado3.Location = new System.Drawing.Point(315, 384);
            this.lblResultado3.Name = "lblResultado3";
            this.lblResultado3.Size = new System.Drawing.Size(38, 15);
            this.lblResultado3.TabIndex = 17;
            this.lblResultado3.Text = "label4";
            // 
            // lblDescription3
            // 
            this.lblDescription3.AutoSize = true;
            this.lblDescription3.Location = new System.Drawing.Point(237, 385);
            this.lblDescription3.Name = "lblDescription3";
            this.lblDescription3.Size = new System.Drawing.Size(38, 15);
            this.lblDescription3.TabIndex = 16;
            this.lblDescription3.Text = "label2";
            // 
            // chkbox2
            // 
            this.chkbox2.AutoSize = true;
            this.chkbox2.Location = new System.Drawing.Point(232, 191);
            this.chkbox2.Name = "chkbox2";
            this.chkbox2.Size = new System.Drawing.Size(134, 19);
            this.chkbox2.TabIndex = 18;
            this.chkbox2.Text = "¿Es con el Diametro?";
            this.chkbox2.UseVisualStyleBackColor = true;
            this.chkbox2.CheckedChanged += new System.EventHandler(this.chkbox2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 434);
            this.Controls.Add(this.chkbox2);
            this.Controls.Add(this.lblResultado3);
            this.Controls.Add(this.lblDescription3);
            this.Controls.Add(this.lblActual2);
            this.Controls.Add(this.lblActualizar);
            this.Controls.Add(this.chkbxAlturaChecker);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.lblResultado2);
            this.Controls.Add(this.lblREsultado1);
            this.Controls.Add(this.lblDescription2);
            this.Controls.Add(this.lblDescription1);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.cbxFiguras);
            this.Controls.Add(this.pctImagen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pctImagen;
        private ComboBox cbxFiguras;
        private ListBox listBox1;
        private ComboBox cbxTipo;
        private Label lblDescription1;
        private Label lblDescription2;
        private Label lblREsultado1;
        private Label lblResultado2;
        private TextBox txtValor1;
        private TextBox txtValor2;
        private Button btnProcesar;
        private Button btnLimpiar;
        private Button btnSalir;
        private CheckBox chkbxAlturaChecker;
        private Label lblActual2;
        private Label lblActualizar;
        private Label lblResultado3;
        private Label lblDescription3;
        private CheckBox chkbox2;
    }
}