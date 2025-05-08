namespace consumo_de_APIs
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
            txtNombre = new TextBox();
            lblpeso = new Label();
            lblHab = new Label();
            lblaltura = new Label();
            lblID = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnLimpiar = new Button();
            btnClima = new Button();
            txtCiudad = new TextBox();
            lblclima = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.Chartreuse;
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Location = new Point(298, 55);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(95, 23);
            txtNombre.TabIndex = 0;
            // 
            // lblpeso
            // 
            lblpeso.AutoSize = true;
            lblpeso.Location = new Point(299, 110);
            lblpeso.Name = "lblpeso";
            lblpeso.Size = new Size(35, 15);
            lblpeso.TabIndex = 1;
            lblpeso.Text = "Peso ";
            // 
            // lblHab
            // 
            lblHab.AutoSize = true;
            lblHab.Location = new Point(299, 152);
            lblHab.Name = "lblHab";
            lblHab.Size = new Size(99, 15);
            lblHab.TabIndex = 2;
            lblHab.Text = "Nivel de habildad";
            // 
            // lblaltura
            // 
            lblaltura.AutoSize = true;
            lblaltura.Location = new Point(299, 190);
            lblaltura.Name = "lblaltura";
            lblaltura.Size = new Size(39, 15);
            lblaltura.TabIndex = 3;
            lblaltura.Text = "Altura";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(299, 249);
            lblID.Name = "lblID";
            lblID.Size = new Size(94, 15);
            lblID.TabIndex = 4;
            lblID.Text = "ID del pokemon ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkGreen;
            pictureBox1.Location = new Point(537, 172);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 92);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.Cursor = Cursors.AppStarting;
            button1.Location = new Point(537, 20);
            button1.Name = "button1";
            button1.Size = new Size(159, 58);
            button1.TabIndex = 6;
            button1.Text = "Buscar Estadistica del pokemon";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Crimson;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(190, 15);
            label1.TabIndex = 7;
            label1.Text = "Nombres para pobrar el programa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 51);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 8;
            label2.Text = "-ekans";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 93);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 9;
            label3.Text = "-bulbasaur";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 136);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 10;
            label4.Text = "-emboar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 172);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 11;
            label5.Text = "-tirtouga";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Gold;
            label6.ForeColor = SystemColors.MenuText;
            label6.Location = new Point(299, 37);
            label6.Name = "label6";
            label6.Size = new Size(171, 15);
            label6.TabIndex = 16;
            label6.Text = "Nombre del pokemon a buscar";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Fuchsia;
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(537, 152);
            label7.Name = "label7";
            label7.Size = new Size(139, 15);
            label7.TabIndex = 17;
            label7.Text = "IMAGEN DEL POKEMON ";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.DarkRed;
            btnLimpiar.Cursor = Cursors.No;
            btnLimpiar.Font = new Font("Segoe UI", 15F);
            btnLimpiar.Location = new Point(436, 315);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(126, 64);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnClima
            // 
            btnClima.Location = new Point(81, 268);
            btnClima.Name = "btnClima";
            btnClima.Size = new Size(111, 57);
            btnClima.TabIndex = 19;
            btnClima.Text = "clima ciudad ";
            btnClima.UseVisualStyleBackColor = true;
            btnClima.Click += btnClima_Click;
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(75, 356);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(127, 23);
            txtCiudad.TabIndex = 20;
            // 
            // lblclima
            // 
            lblclima.AutoSize = true;
            lblclima.Location = new Point(230, 364);
            lblclima.Name = "lblclima";
            lblclima.Size = new Size(43, 15);
            lblclima.TabIndex = 21;
            lblclima.Text = "CLIMA";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CausesValidation = false;
            ClientSize = new Size(800, 450);
            Controls.Add(lblclima);
            Controls.Add(txtCiudad);
            Controls.Add(btnClima);
            Controls.Add(btnLimpiar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(lblID);
            Controls.Add(lblaltura);
            Controls.Add(lblHab);
            Controls.Add(lblpeso);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label lblpeso;
        private Label lblHab;
        private Label lblaltura;
        private Label lblID;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnLimpiar;
        private Button btnClima;
        private TextBox txtCiudad;
        private Label lblclima;
    }
}
