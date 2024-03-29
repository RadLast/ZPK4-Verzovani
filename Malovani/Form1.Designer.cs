namespace Malovani
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_barva = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.item_novy = new System.Windows.Forms.ToolStripMenuItem();
            this.item_otevrit = new System.Windows.Forms.ToolStripMenuItem();
            this.item_ulozit = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.list_tloustka = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.list_funkce = new System.Windows.Forms.ListBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_barva
            // 
            this.btn_barva.BackColor = System.Drawing.Color.Black;
            this.btn_barva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_barva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_barva.Location = new System.Drawing.Point(3, 16);
            this.btn_barva.Name = "btn_barva";
            this.btn_barva.Size = new System.Drawing.Size(65, 64);
            this.btn_barva.TabIndex = 2;
            this.btn_barva.UseVisualStyleBackColor = false;
            this.btn_barva.Click += new System.EventHandler(this.btn_barva_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.FullOpen = true;
            this.colorDialog1.Tag = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1103, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_novy,
            this.item_otevrit,
            this.item_ulozit});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.toolStripMenuItem1.Text = "Soubor";
            // 
            // item_novy
            // 
            this.item_novy.Name = "item_novy";
            this.item_novy.Size = new System.Drawing.Size(110, 22);
            this.item_novy.Text = "Nový";
            this.item_novy.Click += new System.EventHandler(this.item_novy_Click);
            // 
            // item_otevrit
            // 
            this.item_otevrit.Name = "item_otevrit";
            this.item_otevrit.Size = new System.Drawing.Size(110, 22);
            this.item_otevrit.Text = "Otevřít";
            this.item_otevrit.Click += new System.EventHandler(this.item_otevrit_Click);
            // 
            // item_ulozit
            // 
            this.item_ulozit.Name = "item_ulozit";
            this.item_ulozit.Size = new System.Drawing.Size(110, 22);
            this.item_ulozit.Text = "Uložit";
            this.item_ulozit.Click += new System.EventHandler(this.item_ulozit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_barva);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(71, 83);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Barva";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.list_tloustka);
            this.groupBox3.Location = new System.Drawing.Point(89, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(71, 83);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tloušťka";
            // 
            // list_tloustka
            // 
            this.list_tloustka.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_tloustka.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.list_tloustka.FormattingEnabled = true;
            this.list_tloustka.ItemHeight = 12;
            this.list_tloustka.Items.AddRange(new object[] {
            "1 px",
            "3 px",
            "5 px",
            "10 px",
            "20 px"});
            this.list_tloustka.Location = new System.Drawing.Point(3, 16);
            this.list_tloustka.Name = "list_tloustka";
            this.list_tloustka.Size = new System.Drawing.Size(65, 64);
            this.list_tloustka.TabIndex = 8;
            this.list_tloustka.SelectedIndexChanged += new System.EventHandler(this.list_tloustka_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.list_funkce);
            this.groupBox4.Location = new System.Drawing.Point(163, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(71, 83);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Funkce";
            // 
            // list_funkce
            // 
            this.list_funkce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_funkce.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.list_funkce.FormattingEnabled = true;
            this.list_funkce.ItemHeight = 12;
            this.list_funkce.Items.AddRange(new object[] {
            "Kreslení",
            "Guma",
            "Úsečka",
            "Ovál",
            "Čtverec"});
            this.list_funkce.Location = new System.Drawing.Point(3, 16);
            this.list_funkce.Name = "list_funkce";
            this.list_funkce.Size = new System.Drawing.Size(65, 64);
            this.list_funkce.TabIndex = 8;
            this.list_funkce.SelectedIndexChanged += new System.EventHandler(this.list_funkce_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(0, 116);
            this.pictureBox.Name = "pictureBox1";
            this.pictureBox.Size = new System.Drawing.Size(1100, 843);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 961);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1000, 1000);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btn_barva;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem item_novy;
        private System.Windows.Forms.ToolStripMenuItem item_otevrit;
        private System.Windows.Forms.ToolStripMenuItem item_ulozit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox list_tloustka;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox list_funkce;
    }
}

