namespace Recapitulare_PAW_Autor
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_denumire = new System.Windows.Forms.TextBox();
            this.dtp_dataLansare = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clb_Pret = new System.Windows.Forms.CheckedListBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(169, 59);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(200, 22);
            this.tb_id.TabIndex = 0;
            // 
            // tb_denumire
            // 
            this.tb_denumire.Location = new System.Drawing.Point(169, 116);
            this.tb_denumire.Name = "tb_denumire";
            this.tb_denumire.Size = new System.Drawing.Size(200, 22);
            this.tb_denumire.TabIndex = 1;
            // 
            // dtp_dataLansare
            // 
            this.dtp_dataLansare.Location = new System.Drawing.Point(169, 178);
            this.dtp_dataLansare.Name = "dtp_dataLansare";
            this.dtp_dataLansare.Size = new System.Drawing.Size(200, 22);
            this.dtp_dataLansare.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Denumire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data Lansare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pret";
            // 
            // clb_Pret
            // 
            this.clb_Pret.FormattingEnabled = true;
            this.clb_Pret.Items.AddRange(new object[] {
            "15",
            "20",
            "30"});
            this.clb_Pret.Location = new System.Drawing.Point(169, 243);
            this.clb_Pret.Name = "clb_Pret";
            this.clb_Pret.Size = new System.Drawing.Size(113, 72);
            this.clb_Pret.TabIndex = 8;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(40, 341);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(121, 38);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(248, 341);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(121, 38);
            this.btn_Cancel.TabIndex = 10;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 450);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.clb_Pret);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_dataLansare);
            this.Controls.Add(this.tb_denumire);
            this.Controls.Add(this.tb_id);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_denumire;
        private System.Windows.Forms.DateTimePicker dtp_dataLansare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox clb_Pret;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
    }
}