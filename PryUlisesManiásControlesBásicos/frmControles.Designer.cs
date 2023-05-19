namespace PryUlisesManiásControlesBásicos
{
    partial class frmControles
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
            this.txtAlgo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.cmdIngresar = new System.Windows.Forms.Button();
            this.chkRed = new System.Windows.Forms.CheckBox();
            this.chkBlue = new System.Windows.Forms.CheckBox();
            this.lblSample = new System.Windows.Forms.Label();
            this.mrcAnashei = new System.Windows.Forms.GroupBox();
            this.chkMayonesa = new System.Windows.Forms.CheckBox();
            this.chkChimichurri = new System.Windows.Forms.CheckBox();
            this.chkKechu = new System.Windows.Forms.CheckBox();
            this.cboxCosas = new System.Windows.Forms.ComboBox();
            this.cmdIngresar2 = new System.Windows.Forms.Button();
            this.cmdQuitar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.mrcAnashei.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAlgo
            // 
            this.txtAlgo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtAlgo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlgo.ForeColor = System.Drawing.Color.Red;
            this.txtAlgo.Location = new System.Drawing.Point(3, 3);
            this.txtAlgo.Name = "txtAlgo";
            this.txtAlgo.Size = new System.Drawing.Size(239, 13);
            this.txtAlgo.TabIndex = 0;
            this.txtAlgo.TextChanged += new System.EventHandler(this.txtAlgo_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtAlgo);
            this.panel1.Location = new System.Drawing.Point(137, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 29);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 1);
            this.panel2.TabIndex = 1;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.ForeColor = System.Drawing.Color.Red;
            this.lblX.Location = new System.Drawing.Point(461, 41);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 13);
            this.lblX.TabIndex = 2;
            this.lblX.Text = "X";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.ForeColor = System.Drawing.Color.Red;
            this.lblY.Location = new System.Drawing.Point(461, 68);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(14, 13);
            this.lblY.TabIndex = 3;
            this.lblY.Text = "Y";
            // 
            // cmdIngresar
            // 
            this.cmdIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cmdIngresar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.cmdIngresar.FlatAppearance.BorderSize = 2;
            this.cmdIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.cmdIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.cmdIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdIngresar.ForeColor = System.Drawing.Color.Red;
            this.cmdIngresar.Location = new System.Drawing.Point(175, 113);
            this.cmdIngresar.Name = "cmdIngresar";
            this.cmdIngresar.Size = new System.Drawing.Size(168, 29);
            this.cmdIngresar.TabIndex = 4;
            this.cmdIngresar.Text = "&Ingresar";
            this.cmdIngresar.UseVisualStyleBackColor = false;
            this.cmdIngresar.Click += new System.EventHandler(this.cmdIngresar_Click);
            this.cmdIngresar.MouseEnter += new System.EventHandler(this.cmdIngresar_MouseEnter);
            this.cmdIngresar.MouseLeave += new System.EventHandler(this.cmdIngresar_MouseLeave);
            // 
            // chkRed
            // 
            this.chkRed.AutoSize = true;
            this.chkRed.ForeColor = System.Drawing.Color.Red;
            this.chkRed.Location = new System.Drawing.Point(137, 80);
            this.chkRed.Name = "chkRed";
            this.chkRed.Size = new System.Drawing.Size(48, 17);
            this.chkRed.TabIndex = 5;
            this.chkRed.Text = "Rojo";
            this.chkRed.UseVisualStyleBackColor = true;
            // 
            // chkBlue
            // 
            this.chkBlue.AutoSize = true;
            this.chkBlue.ForeColor = System.Drawing.Color.Blue;
            this.chkBlue.Location = new System.Drawing.Point(336, 80);
            this.chkBlue.Name = "chkBlue";
            this.chkBlue.Size = new System.Drawing.Size(46, 17);
            this.chkBlue.TabIndex = 6;
            this.chkBlue.Text = "Azul";
            this.chkBlue.UseVisualStyleBackColor = true;
            // 
            // lblSample
            // 
            this.lblSample.AutoSize = true;
            this.lblSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSample.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSample.Location = new System.Drawing.Point(178, 170);
            this.lblSample.Name = "lblSample";
            this.lblSample.Size = new System.Drawing.Size(165, 31);
            this.lblSample.TabIndex = 7;
            this.lblSample.Text = "Sample Text";
            // 
            // mrcAnashei
            // 
            this.mrcAnashei.Controls.Add(this.cboxCosas);
            this.mrcAnashei.Controls.Add(this.chkKechu);
            this.mrcAnashei.Controls.Add(this.chkChimichurri);
            this.mrcAnashei.Controls.Add(this.chkMayonesa);
            this.mrcAnashei.ForeColor = System.Drawing.Color.Red;
            this.mrcAnashei.Location = new System.Drawing.Point(42, 235);
            this.mrcAnashei.Name = "mrcAnashei";
            this.mrcAnashei.Size = new System.Drawing.Size(433, 124);
            this.mrcAnashei.TabIndex = 8;
            this.mrcAnashei.TabStop = false;
            this.mrcAnashei.Text = "Anashei";
            // 
            // chkMayonesa
            // 
            this.chkMayonesa.AutoSize = true;
            this.chkMayonesa.Location = new System.Drawing.Point(33, 29);
            this.chkMayonesa.Name = "chkMayonesa";
            this.chkMayonesa.Size = new System.Drawing.Size(75, 17);
            this.chkMayonesa.TabIndex = 0;
            this.chkMayonesa.Text = "Mayonesa";
            this.chkMayonesa.UseVisualStyleBackColor = true;
            // 
            // chkChimichurri
            // 
            this.chkChimichurri.AutoSize = true;
            this.chkChimichurri.Location = new System.Drawing.Point(33, 52);
            this.chkChimichurri.Name = "chkChimichurri";
            this.chkChimichurri.Size = new System.Drawing.Size(77, 17);
            this.chkChimichurri.TabIndex = 1;
            this.chkChimichurri.Text = "Chimichurri";
            this.chkChimichurri.UseVisualStyleBackColor = true;
            // 
            // chkKechu
            // 
            this.chkKechu.AutoSize = true;
            this.chkKechu.Location = new System.Drawing.Point(33, 75);
            this.chkKechu.Name = "chkKechu";
            this.chkKechu.Size = new System.Drawing.Size(57, 17);
            this.chkKechu.TabIndex = 2;
            this.chkKechu.Text = "Kechu";
            this.chkKechu.UseVisualStyleBackColor = true;
            // 
            // cboxCosas
            // 
            this.cboxCosas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCosas.FormattingEnabled = true;
            this.cboxCosas.Location = new System.Drawing.Point(227, 27);
            this.cboxCosas.Name = "cboxCosas";
            this.cboxCosas.Size = new System.Drawing.Size(184, 21);
            this.cboxCosas.TabIndex = 3;
            // 
            // cmdIngresar2
            // 
            this.cmdIngresar2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.cmdIngresar2.FlatAppearance.BorderSize = 2;
            this.cmdIngresar2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.cmdIngresar2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.cmdIngresar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdIngresar2.ForeColor = System.Drawing.Color.Red;
            this.cmdIngresar2.Location = new System.Drawing.Point(42, 365);
            this.cmdIngresar2.Name = "cmdIngresar2";
            this.cmdIngresar2.Size = new System.Drawing.Size(184, 32);
            this.cmdIngresar2.TabIndex = 4;
            this.cmdIngresar2.Text = "&Agregar";
            this.cmdIngresar2.UseVisualStyleBackColor = true;
            this.cmdIngresar2.Click += new System.EventHandler(this.cmdIngresar2_Click);
            this.cmdIngresar2.MouseEnter += new System.EventHandler(this.cmdIngresar2_MouseEnter);
            this.cmdIngresar2.MouseLeave += new System.EventHandler(this.cmdIngresar2_MouseLeave);
            // 
            // cmdQuitar
            // 
            this.cmdQuitar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.cmdQuitar.FlatAppearance.BorderSize = 2;
            this.cmdQuitar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.cmdQuitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.cmdQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdQuitar.ForeColor = System.Drawing.Color.Red;
            this.cmdQuitar.Location = new System.Drawing.Point(291, 365);
            this.cmdQuitar.Name = "cmdQuitar";
            this.cmdQuitar.Size = new System.Drawing.Size(184, 32);
            this.cmdQuitar.TabIndex = 5;
            this.cmdQuitar.Text = "&Quitar";
            this.cmdQuitar.UseVisualStyleBackColor = true;
            this.cmdQuitar.Click += new System.EventHandler(this.cmdQuitar_Click);
            this.cmdQuitar.MouseEnter += new System.EventHandler(this.cmdQuitar_MouseEnter);
            this.cmdQuitar.MouseLeave += new System.EventHandler(this.cmdQuitar_MouseLeave);
            // 
            // frmControles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(514, 410);
            this.Controls.Add(this.cmdIngresar2);
            this.Controls.Add(this.cmdQuitar);
            this.Controls.Add(this.mrcAnashei);
            this.Controls.Add(this.lblSample);
            this.Controls.Add(this.chkBlue);
            this.Controls.Add(this.chkRed);
            this.Controls.Add(this.cmdIngresar);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.panel1);
            this.Name = "frmControles";
            this.Text = "Controles Básicos";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmControles_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mrcAnashei.ResumeLayout(false);
            this.mrcAnashei.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAlgo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmdIngresar;
        private System.Windows.Forms.CheckBox chkRed;
        private System.Windows.Forms.CheckBox chkBlue;
        private System.Windows.Forms.Label lblSample;
        private System.Windows.Forms.GroupBox mrcAnashei;
        private System.Windows.Forms.Button cmdIngresar2;
        private System.Windows.Forms.ComboBox cboxCosas;
        private System.Windows.Forms.CheckBox chkKechu;
        private System.Windows.Forms.CheckBox chkChimichurri;
        private System.Windows.Forms.CheckBox chkMayonesa;
        private System.Windows.Forms.Button cmdQuitar;
    }
}

