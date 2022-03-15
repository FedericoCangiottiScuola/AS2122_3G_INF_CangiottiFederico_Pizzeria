
namespace AS2122_3G_INF_CangiottiFederico_Pizzeria
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumPizze = new System.Windows.Forms.TextBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMargherita = new System.Windows.Forms.Label();
            this.lbl4Stagioni = new System.Windows.Forms.Label();
            this.lblVerdure = new System.Windows.Forms.Label();
            this.lstPizze = new System.Windows.Forms.ListBox();
            this.cmbPizze = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo di pizza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantità";
            // 
            // txtNumPizze
            // 
            this.txtNumPizze.Location = new System.Drawing.Point(173, 218);
            this.txtNumPizze.Name = "txtNumPizze";
            this.txtNumPizze.Size = new System.Drawing.Size(100, 23);
            this.txtNumPizze.TabIndex = 3;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(313, 70);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(79, 23);
            this.btnAggiungi.TabIndex = 4;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(586, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Riepilogo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Totale pizza margherita:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Totale pizza 4 stagioni:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(511, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Totale verdure:";
            // 
            // lblMargherita
            // 
            this.lblMargherita.AutoSize = true;
            this.lblMargherita.Location = new System.Drawing.Point(709, 264);
            this.lblMargherita.Name = "lblMargherita";
            this.lblMargherita.Size = new System.Drawing.Size(16, 15);
            this.lblMargherita.TabIndex = 9;
            this.lblMargherita.Text = "...";
            // 
            // lbl4Stagioni
            // 
            this.lbl4Stagioni.AutoSize = true;
            this.lbl4Stagioni.Location = new System.Drawing.Point(709, 310);
            this.lbl4Stagioni.Name = "lbl4Stagioni";
            this.lbl4Stagioni.Size = new System.Drawing.Size(16, 15);
            this.lbl4Stagioni.TabIndex = 10;
            this.lbl4Stagioni.Text = "...";
            // 
            // lblVerdure
            // 
            this.lblVerdure.AutoSize = true;
            this.lblVerdure.Location = new System.Drawing.Point(709, 350);
            this.lblVerdure.Name = "lblVerdure";
            this.lblVerdure.Size = new System.Drawing.Size(16, 15);
            this.lblVerdure.TabIndex = 11;
            this.lblVerdure.Text = "...";
            // 
            // lstPizze
            // 
            this.lstPizze.FormattingEnabled = true;
            this.lstPizze.ItemHeight = 15;
            this.lstPizze.Location = new System.Drawing.Point(471, 70);
            this.lstPizze.Name = "lstPizze";
            this.lstPizze.Size = new System.Drawing.Size(278, 154);
            this.lstPizze.TabIndex = 12;
            // 
            // cmbPizze
            // 
            this.cmbPizze.FormattingEnabled = true;
            this.cmbPizze.Items.AddRange(new object[] {
            "MARGHERITA",
            "4 STAGIONI",
            "VERDURE"});
            this.cmbPizze.Location = new System.Drawing.Point(173, 70);
            this.cmbPizze.Name = "cmbPizze";
            this.cmbPizze.Size = new System.Drawing.Size(121, 23);
            this.cmbPizze.TabIndex = 13;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 403);
            this.Controls.Add(this.cmbPizze);
            this.Controls.Add(this.lstPizze);
            this.Controls.Add(this.lblVerdure);
            this.Controls.Add(this.lbl4Stagioni);
            this.Controls.Add(this.lblMargherita);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.txtNumPizze);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Cangiotti Federico - 3G - Pizzeria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumPizze;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMargherita;
        private System.Windows.Forms.Label lbl4Stagioni;
        private System.Windows.Forms.Label lblVerdure;
        private System.Windows.Forms.ListBox lstPizze;
        private System.Windows.Forms.ComboBox cmbPizze;
    }
}

