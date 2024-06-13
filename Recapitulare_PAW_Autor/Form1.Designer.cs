namespace Recapitulare_PAW_Autor
{
    partial class Form1
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
            this.btn_CalculeazaPret = new System.Windows.Forms.Button();
            this.btn_adaugaCarte = new System.Windows.Forms.Button();
            this.lv_carti = new System.Windows.Forms.ListView();
            this.cl_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Denumire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_DataLansare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Pret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_CalculeazaPret
            // 
            this.btn_CalculeazaPret.Location = new System.Drawing.Point(39, 36);
            this.btn_CalculeazaPret.Name = "btn_CalculeazaPret";
            this.btn_CalculeazaPret.Size = new System.Drawing.Size(187, 51);
            this.btn_CalculeazaPret.TabIndex = 0;
            this.btn_CalculeazaPret.Text = "Calculeaza Pretul Total";
            this.btn_CalculeazaPret.UseVisualStyleBackColor = true;
            this.btn_CalculeazaPret.Click += new System.EventHandler(this.btn_CalculeazaPret_Click);
            // 
            // btn_adaugaCarte
            // 
            this.btn_adaugaCarte.Location = new System.Drawing.Point(39, 126);
            this.btn_adaugaCarte.Name = "btn_adaugaCarte";
            this.btn_adaugaCarte.Size = new System.Drawing.Size(187, 52);
            this.btn_adaugaCarte.TabIndex = 1;
            this.btn_adaugaCarte.Text = "Adauga Carte";
            this.btn_adaugaCarte.UseVisualStyleBackColor = true;
            this.btn_adaugaCarte.Click += new System.EventHandler(this.btn_adaugaCarte_Click);
            // 
            // lv_carti
            // 
            this.lv_carti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_Id,
            this.cl_Denumire,
            this.cl_DataLansare,
            this.cl_Pret});
            this.lv_carti.GridLines = true;
            this.lv_carti.HideSelection = false;
            this.lv_carti.Location = new System.Drawing.Point(287, 36);
            this.lv_carti.Name = "lv_carti";
            this.lv_carti.Size = new System.Drawing.Size(436, 123);
            this.lv_carti.TabIndex = 2;
            this.lv_carti.UseCompatibleStateImageBehavior = false;
            this.lv_carti.View = System.Windows.Forms.View.Details;
            // 
            // cl_Id
            // 
            this.cl_Id.Text = "Id";
            this.cl_Id.Width = 56;
            // 
            // cl_Denumire
            // 
            this.cl_Denumire.Text = "Denumire";
            this.cl_Denumire.Width = 88;
            // 
            // cl_DataLansare
            // 
            this.cl_DataLansare.Text = "Data Lansare";
            this.cl_DataLansare.Width = 114;
            // 
            // cl_Pret
            // 
            this.cl_Pret.Text = "Pret";
            this.cl_Pret.Width = 69;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(287, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(436, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(786, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializateToolStripMenuItem,
            this.deserializareToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // serializateToolStripMenuItem
            // 
            this.serializateToolStripMenuItem.Name = "serializateToolStripMenuItem";
            this.serializateToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.serializateToolStripMenuItem.Text = "Serializate";
            this.serializateToolStripMenuItem.Click += new System.EventHandler(this.serializateToolStripMenuItem_Click);
            // 
            // deserializareToolStripMenuItem
            // 
            this.deserializareToolStripMenuItem.Name = "deserializareToolStripMenuItem";
            this.deserializareToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deserializareToolStripMenuItem.Text = "Deserializare";
            this.deserializareToolStripMenuItem.Click += new System.EventHandler(this.deserializareToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 436);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lv_carti);
            this.Controls.Add(this.btn_adaugaCarte);
            this.Controls.Add(this.btn_CalculeazaPret);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CalculeazaPret;
        private System.Windows.Forms.Button btn_adaugaCarte;
        private System.Windows.Forms.ListView lv_carti;
        private System.Windows.Forms.ColumnHeader cl_Id;
        private System.Windows.Forms.ColumnHeader cl_Denumire;
        private System.Windows.Forms.ColumnHeader cl_DataLansare;
        private System.Windows.Forms.ColumnHeader cl_Pret;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializareToolStripMenuItem;
    }
}

