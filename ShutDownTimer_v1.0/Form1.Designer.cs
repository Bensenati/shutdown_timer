namespace ShutDownTimer_v1._0
{
    partial class MainFrame
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkMinuten = new System.Windows.Forms.RadioButton();
            this.checkUhrzeit = new System.Windows.Forms.RadioButton();
            this.eingabe = new System.Windows.Forms.TextBox();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sign = new System.Windows.Forms.Label();
            this.checkRahmen = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.checkMinuten);
            this.groupBox1.Controls.Add(this.checkUhrzeit);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(35, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bitte wählen Sie einen Eingabetyp: ";
            // 
            // checkMinuten
            // 
            this.checkMinuten.AutoSize = true;
            this.checkMinuten.Checked = true;
            this.checkMinuten.Location = new System.Drawing.Point(159, 19);
            this.checkMinuten.Name = "checkMinuten";
            this.checkMinuten.Size = new System.Drawing.Size(108, 17);
            this.checkMinuten.TabIndex = 1;
            this.checkMinuten.TabStop = true;
            this.checkMinuten.Text = "Minuten (z.B. 90 )";
            this.checkMinuten.UseVisualStyleBackColor = true;
            this.checkMinuten.CheckedChanged += new System.EventHandler(this.checkMinuten_CheckedChanged);
            // 
            // checkUhrzeit
            // 
            this.checkUhrzeit.AutoSize = true;
            this.checkUhrzeit.Location = new System.Drawing.Point(18, 19);
            this.checkUhrzeit.Name = "checkUhrzeit";
            this.checkUhrzeit.Size = new System.Drawing.Size(115, 17);
            this.checkUhrzeit.TabIndex = 0;
            this.checkUhrzeit.Text = "Uhrzeit (z.B. 13:48)";
            this.checkUhrzeit.UseVisualStyleBackColor = true;
            // 
            // eingabe
            // 
            this.eingabe.AccessibleDescription = "";
            this.eingabe.AccessibleName = "";
            this.eingabe.ForeColor = System.Drawing.Color.Gray;
            this.eingabe.Location = new System.Drawing.Point(35, 115);
            this.eingabe.MaxLength = 5;
            this.eingabe.Name = "eingabe";
            this.eingabe.Size = new System.Drawing.Size(105, 20);
            this.eingabe.TabIndex = 1;
            this.eingabe.Text = " Minuten eingeben";
            this.eingabe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.eingabe_MouseClick);
            this.eingabe.TextChanged += new System.EventHandler(this.eingabe_TextChanged);
            // 
            // btnShutdown
            // 
            this.btnShutdown.BackColor = System.Drawing.Color.Gainsboro;
            this.btnShutdown.Location = new System.Drawing.Point(146, 114);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(75, 23);
            this.btnShutdown.TabIndex = 2;
            this.btnShutdown.Text = "Shutdown";
            this.btnShutdown.UseVisualStyleBackColor = false;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAbbrechen.Location = new System.Drawing.Point(34, 143);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(187, 23);
            this.btnAbbrechen.TabIndex = 3;
            this.btnAbbrechen.Text = "Shutdown abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = false;
            this.btnAbbrechen.Click += new System.EventHandler(this.btnAbbrechen_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(317, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 21);
            this.button1.TabIndex = 4;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sign
            // 
            this.sign.AutoSize = true;
            this.sign.BackColor = System.Drawing.Color.Black;
            this.sign.ForeColor = System.Drawing.Color.DimGray;
            this.sign.Location = new System.Drawing.Point(16, 179);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(156, 13);
            this.sign.TabIndex = 5;
            this.sign.Text = "ShutDownTimer | v1.0 | Bensen";
            // 
            // checkRahmen
            // 
            this.checkRahmen.AutoSize = true;
            this.checkRahmen.BackColor = System.Drawing.Color.Transparent;
            this.checkRahmen.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.checkRahmen.Location = new System.Drawing.Point(173, 178);
            this.checkRahmen.Name = "checkRahmen";
            this.checkRahmen.Size = new System.Drawing.Size(121, 17);
            this.checkRahmen.TabIndex = 6;
            this.checkRahmen.Text = "Rahmen einblenden";
            this.checkRahmen.UseVisualStyleBackColor = false;
            this.checkRahmen.CheckedChanged += new System.EventHandler(this.checkRahmen_CheckedChanged);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ShutDownTimer_v1._0.Properties.Resources.backgroundSleeper;
            this.ClientSize = new System.Drawing.Size(349, 202);
            this.Controls.Add(this.checkRahmen);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.btnShutdown);
            this.Controls.Add(this.eingabe);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShutDownTimer v1.0";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainFrame_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton checkMinuten;
        private System.Windows.Forms.RadioButton checkUhrzeit;
        private System.Windows.Forms.TextBox eingabe;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label sign;
        private System.Windows.Forms.CheckBox checkRahmen;
    }
}

