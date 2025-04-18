namespace mojpaint
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menu = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszplikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijprogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otworzplikToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.konwersjaObrazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skalaSzarosciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńNieboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rozmywanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wykrywanieHoryzontuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorPenzlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gruboscPedzlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(985, 526);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 36);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1009, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu,
            this.obrazToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1009, 36);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menu
            // 
            this.menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszplikToolStripMenuItem,
            this.zamknijprogramToolStripMenuItem,
            this.otworzplikToolStripMenuItem1,
            this.konwersjaObrazaToolStripMenuItem});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(73, 29);
            this.menu.Text = "Menu";
            // 
            // zapiszplikToolStripMenuItem
            // 
            this.zapiszplikToolStripMenuItem.Name = "zapiszplikToolStripMenuItem";
            this.zapiszplikToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.zapiszplikToolStripMenuItem.Size = new System.Drawing.Size(315, 34);
            this.zapiszplikToolStripMenuItem.Text = "Zapisz.plik";
            this.zapiszplikToolStripMenuItem.Click += new System.EventHandler(this.zapiszplikToolStripMenuItem_Click);
            // 
            // zamknijprogramToolStripMenuItem
            // 
            this.zamknijprogramToolStripMenuItem.Name = "zamknijprogramToolStripMenuItem";
            this.zamknijprogramToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.zamknijprogramToolStripMenuItem.Size = new System.Drawing.Size(315, 34);
            this.zamknijprogramToolStripMenuItem.Text = "Zamknij.program";
            this.zamknijprogramToolStripMenuItem.Click += new System.EventHandler(this.zamknijprogramToolStripMenuItem_Click);
            // 
            // otworzplikToolStripMenuItem1
            // 
            this.otworzplikToolStripMenuItem1.Name = "otworzplikToolStripMenuItem1";
            this.otworzplikToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.otworzplikToolStripMenuItem1.Size = new System.Drawing.Size(315, 34);
            this.otworzplikToolStripMenuItem1.Text = "Otworz.plik";
            this.otworzplikToolStripMenuItem1.Click += new System.EventHandler(this.otworzplikToolStripMenuItem1_Click);
            // 
            // konwersjaObrazaToolStripMenuItem
            // 
            this.konwersjaObrazaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.skalaSzarosciToolStripMenuItem,
            this.usuńNieboToolStripMenuItem,
            this.rozmywanieToolStripMenuItem,
            this.wykrywanieHoryzontuToolStripMenuItem});
            this.konwersjaObrazaToolStripMenuItem.Name = "konwersjaObrazaToolStripMenuItem";
            this.konwersjaObrazaToolStripMenuItem.Size = new System.Drawing.Size(315, 34);
            this.konwersjaObrazaToolStripMenuItem.Text = "Konwersja obraza";
            // 
            // skalaSzarosciToolStripMenuItem
            // 
            this.skalaSzarosciToolStripMenuItem.Name = "skalaSzarosciToolStripMenuItem";
            this.skalaSzarosciToolStripMenuItem.Size = new System.Drawing.Size(291, 34);
            this.skalaSzarosciToolStripMenuItem.Text = "skala szarosci";
            this.skalaSzarosciToolStripMenuItem.Click += new System.EventHandler(this.skalaSzarosciToolStripMenuItem_Click);
            // 
            // usuńNieboToolStripMenuItem
            // 
            this.usuńNieboToolStripMenuItem.Name = "usuńNieboToolStripMenuItem";
            this.usuńNieboToolStripMenuItem.Size = new System.Drawing.Size(291, 34);
            this.usuńNieboToolStripMenuItem.Text = "usuń niebo";
            this.usuńNieboToolStripMenuItem.Click += new System.EventHandler(this.usuńNieboToolStripMenuItem_Click);
            // 
            // rozmywanieToolStripMenuItem
            // 
            this.rozmywanieToolStripMenuItem.Name = "rozmywanieToolStripMenuItem";
            this.rozmywanieToolStripMenuItem.Size = new System.Drawing.Size(291, 34);
            this.rozmywanieToolStripMenuItem.Text = "rozmywanie";
            this.rozmywanieToolStripMenuItem.Click += new System.EventHandler(this.rozmywanieToolStripMenuItem_Click);
            // 
            // wykrywanieHoryzontuToolStripMenuItem
            // 
            this.wykrywanieHoryzontuToolStripMenuItem.Name = "wykrywanieHoryzontuToolStripMenuItem";
            this.wykrywanieHoryzontuToolStripMenuItem.Size = new System.Drawing.Size(291, 34);
            this.wykrywanieHoryzontuToolStripMenuItem.Text = "wykrywanie horyzontu";
            this.wykrywanieHoryzontuToolStripMenuItem.Click += new System.EventHandler(this.wykrywanieHoryzontuToolStripMenuItem_Click);
            // 
            // obrazToolStripMenuItem
            // 
            this.obrazToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kolorPenzlaToolStripMenuItem,
            this.gruboscPedzlaToolStripMenuItem});
            this.obrazToolStripMenuItem.Name = "obrazToolStripMenuItem";
            this.obrazToolStripMenuItem.Size = new System.Drawing.Size(76, 29);
            this.obrazToolStripMenuItem.Text = "Obraz";
            // 
            // kolorPenzlaToolStripMenuItem
            // 
            this.kolorPenzlaToolStripMenuItem.Name = "kolorPenzlaToolStripMenuItem";
            this.kolorPenzlaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.kolorPenzlaToolStripMenuItem.Size = new System.Drawing.Size(243, 34);
            this.kolorPenzlaToolStripMenuItem.Text = "Kolor penzla";
            this.kolorPenzlaToolStripMenuItem.Click += new System.EventHandler(this.kolorPenzlaToolStripMenuItem_Click);
            // 
            // gruboscPedzlaToolStripMenuItem
            // 
            this.gruboscPedzlaToolStripMenuItem.Name = "gruboscPedzlaToolStripMenuItem";
            this.gruboscPedzlaToolStripMenuItem.Size = new System.Drawing.Size(243, 34);
            this.gruboscPedzlaToolStripMenuItem.Text = "Grubosc pedzla";
            this.gruboscPedzlaToolStripMenuItem.Click += new System.EventHandler(this.gruboscPedzlaToolStripMenuItem_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(206, 7);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 601);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 601);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 592);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 38);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 596);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(612, 596);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(96, 38);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "kliknij";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(469, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(528, 40);
            this.textBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 645);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menu;
        private System.Windows.Forms.ToolStripMenuItem zapiszplikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijprogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otworzplikToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem obrazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolorPenzlaToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ToolStripMenuItem gruboscPedzlaToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem konwersjaObrazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skalaSzarosciToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem usuńNieboToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rozmywanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wykrywanieHoryzontuToolStripMenuItem;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

