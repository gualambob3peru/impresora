namespace miForm
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCentro = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLinea = new System.Windows.Forms.TextBox();
            this.txtOrdenProceso = new System.Windows.Forms.TextBox();
            this.txtPlan = new System.Windows.Forms.TextBox();
            this.txtProd = new System.Windows.Forms.TextBox();
            this.txtMat = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtFechaVencimiento = new System.Windows.Forms.TextBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCajaPallet = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Centro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(280, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Línea";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Orden de Proceso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(49, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Plan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(280, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prod.";
            // 
            // txtCentro
            // 
            this.txtCentro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(49)))), ((int)(((byte)(122)))));
            this.txtCentro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCentro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCentro.ForeColor = System.Drawing.Color.White;
            this.txtCentro.Location = new System.Drawing.Point(119, 34);
            this.txtCentro.Name = "txtCentro";
            this.txtCentro.Size = new System.Drawing.Size(128, 26);
            this.txtCentro.TabIndex = 5;
            this.txtCentro.TextChanged += new System.EventHandler(this.txtCentro_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(534, 48);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Leer Orden";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 4;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(792, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 37);
            this.button2.TabIndex = 11;
            this.button2.Text = "Ingreso Producción";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(530, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mat.";
            // 
            // txtLinea
            // 
            this.txtLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(49)))), ((int)(((byte)(122)))));
            this.txtLinea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLinea.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinea.ForeColor = System.Drawing.Color.White;
            this.txtLinea.Location = new System.Drawing.Point(358, 34);
            this.txtLinea.Name = "txtLinea";
            this.txtLinea.Size = new System.Drawing.Size(128, 26);
            this.txtLinea.TabIndex = 13;
            this.txtLinea.Text = "120 PET";
            // 
            // txtOrdenProceso
            // 
            this.txtOrdenProceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(49)))), ((int)(((byte)(122)))));
            this.txtOrdenProceso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrdenProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrdenProceso.ForeColor = System.Drawing.Color.White;
            this.txtOrdenProceso.Location = new System.Drawing.Point(212, 83);
            this.txtOrdenProceso.Name = "txtOrdenProceso";
            this.txtOrdenProceso.Size = new System.Drawing.Size(274, 26);
            this.txtOrdenProceso.TabIndex = 14;
            // 
            // txtPlan
            // 
            this.txtPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(49)))), ((int)(((byte)(122)))));
            this.txtPlan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlan.ForeColor = System.Drawing.Color.White;
            this.txtPlan.Location = new System.Drawing.Point(119, 129);
            this.txtPlan.Name = "txtPlan";
            this.txtPlan.Size = new System.Drawing.Size(128, 26);
            this.txtPlan.TabIndex = 15;
            // 
            // txtProd
            // 
            this.txtProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(49)))), ((int)(((byte)(122)))));
            this.txtProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProd.ForeColor = System.Drawing.Color.White;
            this.txtProd.Location = new System.Drawing.Point(358, 129);
            this.txtProd.Name = "txtProd";
            this.txtProd.Size = new System.Drawing.Size(128, 26);
            this.txtProd.TabIndex = 16;
            // 
            // txtMat
            // 
            this.txtMat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(49)))), ((int)(((byte)(122)))));
            this.txtMat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMat.ForeColor = System.Drawing.Color.White;
            this.txtMat.Location = new System.Drawing.Point(605, 108);
            this.txtMat.Name = "txtMat";
            this.txtMat.Size = new System.Drawing.Size(128, 26);
            this.txtMat.TabIndex = 17;
            // 
            // txtProducto
            // 
            this.txtProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(49)))), ((int)(((byte)(122)))));
            this.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.ForeColor = System.Drawing.Color.White;
            this.txtProducto.Location = new System.Drawing.Point(535, 155);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(467, 26);
            this.txtProducto.TabIndex = 18;
            // 
            // txtFechaVencimiento
            // 
            this.txtFechaVencimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(49)))), ((int)(((byte)(122)))));
            this.txtFechaVencimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFechaVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaVencimiento.ForeColor = System.Drawing.Color.White;
            this.txtFechaVencimiento.Location = new System.Drawing.Point(845, 200);
            this.txtFechaVencimiento.Name = "txtFechaVencimiento";
            this.txtFechaVencimiento.Size = new System.Drawing.Size(157, 26);
            this.txtFechaVencimiento.TabIndex = 22;
            // 
            // txtDuracion
            // 
            this.txtDuracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(49)))), ((int)(((byte)(122)))));
            this.txtDuracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuracion.ForeColor = System.Drawing.Color.White;
            this.txtDuracion.Location = new System.Drawing.Point(593, 200);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(51, 26);
            this.txtDuracion.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(740, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "F. Venc.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(535, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Dur.";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(45, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = " Caja x Pallet";
            // 
            // txtCajaPallet
            // 
            this.txtCajaPallet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(49)))), ((int)(((byte)(122)))));
            this.txtCajaPallet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCajaPallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCajaPallet.ForeColor = System.Drawing.Color.White;
            this.txtCajaPallet.Location = new System.Drawing.Point(196, 185);
            this.txtCajaPallet.Name = "txtCajaPallet";
            this.txtCajaPallet.Size = new System.Drawing.Size(51, 26);
            this.txtCajaPallet.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 4;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(89, 239);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 37);
            this.button3.TabIndex = 25;
            this.button3.Text = "Teclado";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderSize = 4;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(285, 185);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 37);
            this.button4.TabIndex = 26;
            this.button4.Text = "Saldo";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.BorderSize = 4;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(285, 239);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(159, 37);
            this.button5.TabIndex = 27;
            this.button5.Text = "Re-Imprimir";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(531, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "#Etq.";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(49)))), ((int)(((byte)(122)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(593, 244);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(51, 26);
            this.textBox1.TabIndex = 29;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(656, 244);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(152, 24);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.Text = "Impresión Manual";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(119)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button6.FlatAppearance.BorderSize = 4;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(840, 239);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(159, 37);
            this.button6.TabIndex = 31;
            this.button6.Text = "Imprimir";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(56)))), ((int)(((byte)(116)))));
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button7.FlatAppearance.BorderSize = 4;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Location = new System.Drawing.Point(50, 411);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(436, 45);
            this.button7.TabIndex = 32;
            this.button7.Text = "Salir de la Aplicación";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button8.FlatAppearance.BorderSize = 4;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.Location = new System.Drawing.Point(535, 411);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(463, 45);
            this.button8.TabIndex = 33;
            this.button8.Text = "Configurar";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(49)))), ((int)(((byte)(122)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 295);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(948, 110);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(55)))), ((int)(((byte)(128)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1046, 485);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtCajaPallet);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFechaVencimiento);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtMat);
            this.Controls.Add(this.txtProd);
            this.Controls.Add(this.txtPlan);
            this.Controls.Add(this.txtOrdenProceso);
            this.Controls.Add(this.txtLinea);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCentro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Impresión en Línea de Producción";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCentro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLinea;
        private System.Windows.Forms.TextBox txtOrdenProceso;
        private System.Windows.Forms.TextBox txtPlan;
        private System.Windows.Forms.TextBox txtProd;
        private System.Windows.Forms.TextBox txtMat;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtFechaVencimiento;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCajaPallet;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

