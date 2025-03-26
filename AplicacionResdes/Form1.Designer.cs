namespace AplicacionResdes
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
            this.lbIngresar = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAreaDeTexto = new System.Windows.Forms.TextBox();
            this.btnComsndoPing = new System.Windows.Forms.Button();
            this.btnComandoTracert = new System.Windows.Forms.Button();
            this.chkT = new System.Windows.Forms.CheckBox();
            this.chKL = new System.Windows.Forms.CheckBox();
            this.chkN = new System.Windows.Forms.CheckBox();
            this.chKping = new System.Windows.Forms.CheckBox();
            this.chkTracert = new System.Windows.Forms.CheckBox();
            this.txtNumN = new System.Windows.Forms.TextBox();
            this.txtNumL = new System.Windows.Forms.TextBox();
            this.lbIngersar2 = new System.Windows.Forms.Label();
            this.txtDireccion2 = new System.Windows.Forms.TextBox();
            this.chkD = new System.Windows.Forms.CheckBox();
            this.chkH = new System.Windows.Forms.CheckBox();
            this.txtNumH = new System.Windows.Forms.TextBox();
            this.chKIPV4 = new System.Windows.Forms.CheckBox();
            this.chKIPV6 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkA = new System.Windows.Forms.CheckBox();
            this.chkF = new System.Windows.Forms.CheckBox();
            this.chkI = new System.Windows.Forms.CheckBox();
            this.txtNumI = new System.Windows.Forms.TextBox();
            this.chkR = new System.Windows.Forms.CheckBox();
            this.txtNumR = new System.Windows.Forms.TextBox();
            this.chkS = new System.Windows.Forms.CheckBox();
            this.txtNumS = new System.Windows.Forms.TextBox();
            this.chkW = new System.Windows.Forms.CheckBox();
            this.txtNumW = new System.Windows.Forms.TextBox();
            this.chkRT = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbIngresar
            // 
            this.lbIngresar.AutoSize = true;
            this.lbIngresar.Location = new System.Drawing.Point(123, 184);
            this.lbIngresar.Name = "lbIngresar";
            this.lbIngresar.Size = new System.Drawing.Size(107, 13);
            this.lbIngresar.TabIndex = 0;
            this.lbIngresar.Text = "Ingresar Direccón IP:";
            this.lbIngresar.Visible = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(64, 213);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(226, 20);
            this.txtDireccion.TabIndex = 1;
            this.txtDireccion.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12.22642F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(364, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aplicación";
            // 
            // txtAreaDeTexto
            // 
            this.txtAreaDeTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAreaDeTexto.Enabled = false;
            this.txtAreaDeTexto.Location = new System.Drawing.Point(88, 320);
            this.txtAreaDeTexto.Multiline = true;
            this.txtAreaDeTexto.Name = "txtAreaDeTexto";
            this.txtAreaDeTexto.Size = new System.Drawing.Size(641, 377);
            this.txtAreaDeTexto.TabIndex = 5;
            // 
            // btnComsndoPing
            // 
            this.btnComsndoPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.792453F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComsndoPing.Location = new System.Drawing.Point(311, 213);
            this.btnComsndoPing.Name = "btnComsndoPing";
            this.btnComsndoPing.Size = new System.Drawing.Size(75, 23);
            this.btnComsndoPing.TabIndex = 6;
            this.btnComsndoPing.Text = "PING";
            this.btnComsndoPing.UseVisualStyleBackColor = true;
            this.btnComsndoPing.Visible = false;
            this.btnComsndoPing.Click += new System.EventHandler(this.btnComsndoPing_Click);
            // 
            // btnComandoTracert
            // 
            this.btnComandoTracert.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.792453F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComandoTracert.Location = new System.Drawing.Point(699, 210);
            this.btnComandoTracert.Name = "btnComandoTracert";
            this.btnComandoTracert.Size = new System.Drawing.Size(75, 23);
            this.btnComandoTracert.TabIndex = 7;
            this.btnComandoTracert.Text = "TRACERT";
            this.btnComandoTracert.UseVisualStyleBackColor = true;
            this.btnComandoTracert.Visible = false;
            this.btnComandoTracert.Click += new System.EventHandler(this.btnComandoTracert_Click);
            // 
            // chkT
            // 
            this.chkT.AutoSize = true;
            this.chkT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkT.Location = new System.Drawing.Point(132, 247);
            this.chkT.Name = "chkT";
            this.chkT.Size = new System.Drawing.Size(40, 24);
            this.chkT.TabIndex = 8;
            this.chkT.Text = "-t";
            this.chkT.UseVisualStyleBackColor = true;
            this.chkT.Visible = false;
            // 
            // chKL
            // 
            this.chKL.AutoSize = true;
            this.chKL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chKL.Location = new System.Drawing.Point(88, 247);
            this.chKL.Name = "chKL";
            this.chKL.Size = new System.Drawing.Size(38, 24);
            this.chKL.TabIndex = 9;
            this.chKL.Text = "-l";
            this.chKL.UseVisualStyleBackColor = true;
            this.chKL.Visible = false;
            this.chKL.CheckedChanged += new System.EventHandler(this.chKL_CheckedChanged);
            // 
            // chkN
            // 
            this.chkN.AutoSize = true;
            this.chkN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkN.Location = new System.Drawing.Point(41, 247);
            this.chkN.Name = "chkN";
            this.chkN.Size = new System.Drawing.Size(44, 24);
            this.chkN.TabIndex = 10;
            this.chkN.Text = "-n";
            this.chkN.UseVisualStyleBackColor = true;
            this.chkN.Visible = false;
            this.chkN.CheckedChanged += new System.EventHandler(this.chkN_CheckedChanged);
            // 
            // chKping
            // 
            this.chKping.AutoSize = true;
            this.chKping.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chKping.Location = new System.Drawing.Point(230, 133);
            this.chKping.Name = "chKping";
            this.chKping.Size = new System.Drawing.Size(71, 28);
            this.chKping.TabIndex = 11;
            this.chKping.Text = "Ping";
            this.chKping.UseVisualStyleBackColor = true;
            this.chKping.CheckedChanged += new System.EventHandler(this.chKping_CheckedChanged);
            // 
            // chkTracert
            // 
            this.chkTracert.AutoSize = true;
            this.chkTracert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTracert.Location = new System.Drawing.Point(519, 133);
            this.chkTracert.Name = "chkTracert";
            this.chkTracert.Size = new System.Drawing.Size(95, 28);
            this.chkTracert.TabIndex = 12;
            this.chkTracert.Text = "Tracert";
            this.chkTracert.UseVisualStyleBackColor = true;
            this.chkTracert.CheckedChanged += new System.EventHandler(this.chkTracert_CheckedChanged);
            // 
            // txtNumN
            // 
            this.txtNumN.Location = new System.Drawing.Point(41, 272);
            this.txtNumN.Name = "txtNumN";
            this.txtNumN.Size = new System.Drawing.Size(32, 20);
            this.txtNumN.TabIndex = 13;
            this.txtNumN.Visible = false;
            // 
            // txtNumL
            // 
            this.txtNumL.Location = new System.Drawing.Point(88, 272);
            this.txtNumL.Name = "txtNumL";
            this.txtNumL.Size = new System.Drawing.Size(32, 20);
            this.txtNumL.TabIndex = 14;
            this.txtNumL.Visible = false;
            // 
            // lbIngersar2
            // 
            this.lbIngersar2.AutoSize = true;
            this.lbIngersar2.Location = new System.Drawing.Point(516, 184);
            this.lbIngersar2.Name = "lbIngersar2";
            this.lbIngersar2.Size = new System.Drawing.Size(107, 13);
            this.lbIngersar2.TabIndex = 15;
            this.lbIngersar2.Text = "Ingresar Direccón IP:";
            this.lbIngersar2.Visible = false;
            // 
            // txtDireccion2
            // 
            this.txtDireccion2.Location = new System.Drawing.Point(458, 210);
            this.txtDireccion2.Name = "txtDireccion2";
            this.txtDireccion2.Size = new System.Drawing.Size(226, 20);
            this.txtDireccion2.TabIndex = 16;
            this.txtDireccion2.Visible = false;
            // 
            // chkD
            // 
            this.chkD.AutoSize = true;
            this.chkD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkD.Location = new System.Drawing.Point(449, 247);
            this.chkD.Name = "chkD";
            this.chkD.Size = new System.Drawing.Size(44, 24);
            this.chkD.TabIndex = 17;
            this.chkD.Text = "-d";
            this.chkD.UseVisualStyleBackColor = true;
            this.chkD.Visible = false;
            // 
            // chkH
            // 
            this.chkH.AutoSize = true;
            this.chkH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkH.Location = new System.Drawing.Point(500, 247);
            this.chkH.Name = "chkH";
            this.chkH.Size = new System.Drawing.Size(44, 24);
            this.chkH.TabIndex = 18;
            this.chkH.Text = "-h";
            this.chkH.UseVisualStyleBackColor = true;
            this.chkH.Visible = false;
            this.chkH.CheckedChanged += new System.EventHandler(this.chkH_CheckedChanged);
            // 
            // txtNumH
            // 
            this.txtNumH.Location = new System.Drawing.Point(500, 272);
            this.txtNumH.Name = "txtNumH";
            this.txtNumH.Size = new System.Drawing.Size(32, 20);
            this.txtNumH.TabIndex = 19;
            this.txtNumH.Visible = false;
            // 
            // chKIPV4
            // 
            this.chKIPV4.AutoSize = true;
            this.chKIPV4.Location = new System.Drawing.Point(495, 72);
            this.chKIPV4.Name = "chKIPV4";
            this.chKIPV4.Size = new System.Drawing.Size(49, 17);
            this.chKIPV4.TabIndex = 20;
            this.chKIPV4.Text = "IPV4";
            this.chKIPV4.UseVisualStyleBackColor = true;
            this.chKIPV4.CheckedChanged += new System.EventHandler(this.chKIPV4_CheckedChanged);
            // 
            // chKIPV6
            // 
            this.chKIPV6.AutoSize = true;
            this.chKIPV6.Location = new System.Drawing.Point(495, 95);
            this.chKIPV6.Name = "chKIPV6";
            this.chKIPV6.Size = new System.Drawing.Size(49, 17);
            this.chKIPV6.TabIndex = 21;
            this.chKIPV6.Text = "IPV6";
            this.chKIPV6.UseVisualStyleBackColor = true;
            this.chKIPV6.CheckedChanged += new System.EventHandler(this.chKIPV6_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Seleccionar el tipo de IP:";
            // 
            // chkA
            // 
            this.chkA.AutoSize = true;
            this.chkA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkA.Location = new System.Drawing.Point(168, 247);
            this.chkA.Name = "chkA";
            this.chkA.Size = new System.Drawing.Size(44, 24);
            this.chkA.TabIndex = 23;
            this.chkA.Text = "-a";
            this.chkA.UseVisualStyleBackColor = true;
            this.chkA.Visible = false;
            // 
            // chkF
            // 
            this.chkF.AutoSize = true;
            this.chkF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkF.Location = new System.Drawing.Point(218, 247);
            this.chkF.Name = "chkF";
            this.chkF.Size = new System.Drawing.Size(40, 24);
            this.chkF.TabIndex = 24;
            this.chkF.Text = "-f";
            this.chkF.UseVisualStyleBackColor = true;
            this.chkF.Visible = false;
            // 
            // chkI
            // 
            this.chkI.AutoSize = true;
            this.chkI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkI.Location = new System.Drawing.Point(261, 247);
            this.chkI.Name = "chkI";
            this.chkI.Size = new System.Drawing.Size(38, 24);
            this.chkI.TabIndex = 25;
            this.chkI.Text = "-i";
            this.chkI.UseVisualStyleBackColor = true;
            this.chkI.Visible = false;
            this.chkI.CheckedChanged += new System.EventHandler(this.chkI_CheckedChanged);
            // 
            // txtNumI
            // 
            this.txtNumI.Location = new System.Drawing.Point(258, 272);
            this.txtNumI.Name = "txtNumI";
            this.txtNumI.Size = new System.Drawing.Size(32, 20);
            this.txtNumI.TabIndex = 26;
            this.txtNumI.Visible = false;
            // 
            // chkR
            // 
            this.chkR.AutoSize = true;
            this.chkR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkR.Location = new System.Drawing.Point(305, 247);
            this.chkR.Name = "chkR";
            this.chkR.Size = new System.Drawing.Size(40, 24);
            this.chkR.TabIndex = 27;
            this.chkR.Text = "-r";
            this.chkR.UseVisualStyleBackColor = true;
            this.chkR.Visible = false;
            this.chkR.CheckedChanged += new System.EventHandler(this.chkR_CheckedChanged);
            // 
            // txtNumR
            // 
            this.txtNumR.Location = new System.Drawing.Point(305, 272);
            this.txtNumR.Name = "txtNumR";
            this.txtNumR.Size = new System.Drawing.Size(32, 20);
            this.txtNumR.TabIndex = 28;
            this.txtNumR.Visible = false;
            // 
            // chkS
            // 
            this.chkS.AutoSize = true;
            this.chkS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkS.Location = new System.Drawing.Point(351, 247);
            this.chkS.Name = "chkS";
            this.chkS.Size = new System.Drawing.Size(43, 24);
            this.chkS.TabIndex = 29;
            this.chkS.Text = "-s";
            this.chkS.UseVisualStyleBackColor = true;
            this.chkS.Visible = false;
            this.chkS.CheckedChanged += new System.EventHandler(this.chkS_CheckedChanged);
            // 
            // txtNumS
            // 
            this.txtNumS.Location = new System.Drawing.Point(351, 272);
            this.txtNumS.Name = "txtNumS";
            this.txtNumS.Size = new System.Drawing.Size(32, 20);
            this.txtNumS.TabIndex = 30;
            this.txtNumS.Visible = false;
            // 
            // chkW
            // 
            this.chkW.AutoSize = true;
            this.chkW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkW.Location = new System.Drawing.Point(550, 247);
            this.chkW.Name = "chkW";
            this.chkW.Size = new System.Drawing.Size(46, 24);
            this.chkW.TabIndex = 31;
            this.chkW.Text = "-w";
            this.chkW.UseVisualStyleBackColor = true;
            this.chkW.Visible = false;
            this.chkW.CheckedChanged += new System.EventHandler(this.chkW_CheckedChanged);
            // 
            // txtNumW
            // 
            this.txtNumW.Location = new System.Drawing.Point(550, 272);
            this.txtNumW.Name = "txtNumW";
            this.txtNumW.Size = new System.Drawing.Size(32, 20);
            this.txtNumW.TabIndex = 32;
            this.txtNumW.Visible = false;
            // 
            // chkRT
            // 
            this.chkRT.AutoSize = true;
            this.chkRT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRT.Location = new System.Drawing.Point(602, 247);
            this.chkRT.Name = "chkRT";
            this.chkRT.Size = new System.Drawing.Size(47, 24);
            this.chkRT.TabIndex = 33;
            this.chkRT.Text = "-R";
            this.chkRT.UseVisualStyleBackColor = true;
            this.chkRT.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(849, 709);
            this.Controls.Add(this.chkRT);
            this.Controls.Add(this.txtNumW);
            this.Controls.Add(this.chkW);
            this.Controls.Add(this.txtNumS);
            this.Controls.Add(this.chkS);
            this.Controls.Add(this.txtNumR);
            this.Controls.Add(this.chkR);
            this.Controls.Add(this.txtNumI);
            this.Controls.Add(this.chkI);
            this.Controls.Add(this.chkF);
            this.Controls.Add(this.chkA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chKIPV6);
            this.Controls.Add(this.chKIPV4);
            this.Controls.Add(this.txtNumH);
            this.Controls.Add(this.chkH);
            this.Controls.Add(this.chkD);
            this.Controls.Add(this.txtDireccion2);
            this.Controls.Add(this.lbIngersar2);
            this.Controls.Add(this.txtNumL);
            this.Controls.Add(this.txtNumN);
            this.Controls.Add(this.chkTracert);
            this.Controls.Add(this.chKping);
            this.Controls.Add(this.chkN);
            this.Controls.Add(this.chKL);
            this.Controls.Add(this.chkT);
            this.Controls.Add(this.btnComandoTracert);
            this.Controls.Add(this.btnComsndoPing);
            this.Controls.Add(this.txtAreaDeTexto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lbIngresar);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIngresar;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAreaDeTexto;
        private System.Windows.Forms.Button btnComsndoPing;
        private System.Windows.Forms.Button btnComandoTracert;
        private System.Windows.Forms.CheckBox chkT;
        private System.Windows.Forms.CheckBox chKL;
        private System.Windows.Forms.CheckBox chkN;
        private System.Windows.Forms.CheckBox chKping;
        private System.Windows.Forms.CheckBox chkTracert;
        private System.Windows.Forms.TextBox txtNumN;
        private System.Windows.Forms.TextBox txtNumL;
        private System.Windows.Forms.Label lbIngersar2;
        private System.Windows.Forms.TextBox txtDireccion2;
        private System.Windows.Forms.CheckBox chkD;
        private System.Windows.Forms.CheckBox chkH;
        private System.Windows.Forms.TextBox txtNumH;
        private System.Windows.Forms.CheckBox chKIPV4;
        private System.Windows.Forms.CheckBox chKIPV6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkA;
        private System.Windows.Forms.CheckBox chkF;
        private System.Windows.Forms.CheckBox chkI;
        private System.Windows.Forms.TextBox txtNumI;
        private System.Windows.Forms.CheckBox chkR;
        private System.Windows.Forms.TextBox txtNumR;
        private System.Windows.Forms.CheckBox chkS;
        private System.Windows.Forms.TextBox txtNumS;
        private System.Windows.Forms.CheckBox chkW;
        private System.Windows.Forms.TextBox txtNumW;
        private System.Windows.Forms.CheckBox chkRT;
    }
}

