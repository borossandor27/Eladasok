namespace Eladasok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_Maganszemely = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_Vasarlasok = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Listahozad = new System.Windows.Forms.Button();
            this.button_Kiir_fajlba = new System.Windows.Forms.Button();
            this.button_Beolvas_fajlbol = new System.Windows.Forms.Button();
            this.textBox_Vevo_neve = new System.Windows.Forms.TextBox();
            this.textBox_Adoazonosito = new System.Windows.Forms.TextBox();
            this.numeric_Vasarlas_osszege = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_Szuletett = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Listabol_torol = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Vasarlas_osszege)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adóazonosító";
            // 
            // checkBox_Maganszemely
            // 
            this.checkBox_Maganszemely.AutoSize = true;
            this.checkBox_Maganszemely.Location = new System.Drawing.Point(34, 81);
            this.checkBox_Maganszemely.Name = "checkBox_Maganszemely";
            this.checkBox_Maganszemely.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_Maganszemely.Size = new System.Drawing.Size(134, 24);
            this.checkBox_Maganszemely.TabIndex = 1;
            this.checkBox_Maganszemely.Text = "Magánszemély";
            this.checkBox_Maganszemely.UseVisualStyleBackColor = true;
            this.checkBox_Maganszemely.CheckedChanged += new System.EventHandler(this.checkBox_Maganszemely_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vevő neve:";
            // 
            // listBox_Vasarlasok
            // 
            this.listBox_Vasarlasok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Vasarlasok.FormattingEnabled = true;
            this.listBox_Vasarlasok.ItemHeight = 20;
            this.listBox_Vasarlasok.Location = new System.Drawing.Point(3, 22);
            this.listBox_Vasarlasok.Name = "listBox_Vasarlasok";
            this.listBox_Vasarlasok.Size = new System.Drawing.Size(256, 354);
            this.listBox_Vasarlasok.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox_Vasarlasok);
            this.groupBox1.Location = new System.Drawing.Point(423, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 379);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vásárlások";
            // 
            // button_Listahozad
            // 
            this.button_Listahozad.Location = new System.Drawing.Point(68, 314);
            this.button_Listahozad.Name = "button_Listahozad";
            this.button_Listahozad.Size = new System.Drawing.Size(313, 35);
            this.button_Listahozad.TabIndex = 4;
            this.button_Listahozad.Text = "Hozzáadás listához";
            this.button_Listahozad.UseVisualStyleBackColor = true;
            this.button_Listahozad.Click += new System.EventHandler(this.button_Listahozad_Click);
            // 
            // button_Kiir_fajlba
            // 
            this.button_Kiir_fajlba.Location = new System.Drawing.Point(68, 370);
            this.button_Kiir_fajlba.Name = "button_Kiir_fajlba";
            this.button_Kiir_fajlba.Size = new System.Drawing.Size(313, 35);
            this.button_Kiir_fajlba.TabIndex = 4;
            this.button_Kiir_fajlba.Text = "Kiírja fájlba";
            this.button_Kiir_fajlba.UseVisualStyleBackColor = true;
            this.button_Kiir_fajlba.Click += new System.EventHandler(this.button_Kiir_fajlba_Click);
            // 
            // button_Beolvas_fajlbol
            // 
            this.button_Beolvas_fajlbol.Location = new System.Drawing.Point(68, 425);
            this.button_Beolvas_fajlbol.Name = "button_Beolvas_fajlbol";
            this.button_Beolvas_fajlbol.Size = new System.Drawing.Size(313, 35);
            this.button_Beolvas_fajlbol.TabIndex = 4;
            this.button_Beolvas_fajlbol.Text = "Beolvassa fájlból";
            this.button_Beolvas_fajlbol.UseVisualStyleBackColor = true;
            this.button_Beolvas_fajlbol.Click += new System.EventHandler(this.button_Beolvas_fajlbol_Click);
            // 
            // textBox_Vevo_neve
            // 
            this.textBox_Vevo_neve.Location = new System.Drawing.Point(153, 24);
            this.textBox_Vevo_neve.Name = "textBox_Vevo_neve";
            this.textBox_Vevo_neve.Size = new System.Drawing.Size(228, 26);
            this.textBox_Vevo_neve.TabIndex = 5;
            // 
            // textBox_Adoazonosito
            // 
            this.textBox_Adoazonosito.Location = new System.Drawing.Point(153, 190);
            this.textBox_Adoazonosito.Name = "textBox_Adoazonosito";
            this.textBox_Adoazonosito.Size = new System.Drawing.Size(228, 26);
            this.textBox_Adoazonosito.TabIndex = 5;
            this.textBox_Adoazonosito.TextChanged += new System.EventHandler(this.textBox_Adoazonosito_TextChanged);
            // 
            // numeric_Vasarlas_osszege
            // 
            this.numeric_Vasarlas_osszege.Location = new System.Drawing.Point(175, 245);
            this.numeric_Vasarlas_osszege.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.numeric_Vasarlas_osszege.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numeric_Vasarlas_osszege.Name = "numeric_Vasarlas_osszege";
            this.numeric_Vasarlas_osszege.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numeric_Vasarlas_osszege.Size = new System.Drawing.Size(176, 26);
            this.numeric_Vasarlas_osszege.TabIndex = 6;
            this.numeric_Vasarlas_osszege.ThousandsSeparator = true;
            this.numeric_Vasarlas_osszege.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numeric_Vasarlas_osszege.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vásárlás összege";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ft";
            // 
            // dateTimePicker_Szuletett
            // 
            this.dateTimePicker_Szuletett.Enabled = false;
            this.dateTimePicker_Szuletett.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Szuletett.Location = new System.Drawing.Point(151, 134);
            this.dateTimePicker_Szuletett.Name = "dateTimePicker_Szuletett";
            this.dateTimePicker_Szuletett.Size = new System.Drawing.Size(230, 26);
            this.dateTimePicker_Szuletett.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Született";
            // 
            // button_Listabol_torol
            // 
            this.button_Listabol_torol.Location = new System.Drawing.Point(423, 425);
            this.button_Listabol_torol.Name = "button_Listabol_torol";
            this.button_Listabol_torol.Size = new System.Drawing.Size(259, 35);
            this.button_Listabol_torol.TabIndex = 10;
            this.button_Listabol_torol.Text = "Kijelölt törlése";
            this.button_Listabol_torol.UseVisualStyleBackColor = true;
            this.button_Listabol_torol.Click += new System.EventHandler(this.button_Listabol_torol_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 496);
            this.Controls.Add(this.button_Listabol_torol);
            this.Controls.Add(this.dateTimePicker_Szuletett);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numeric_Vasarlas_osszege);
            this.Controls.Add(this.textBox_Adoazonosito);
            this.Controls.Add(this.textBox_Vevo_neve);
            this.Controls.Add(this.button_Beolvas_fajlbol);
            this.Controls.Add(this.button_Kiir_fajlba);
            this.Controls.Add(this.button_Listahozad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox_Maganszemely);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Eladások";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Vasarlas_osszege)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_Maganszemely;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_Vasarlasok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Listahozad;
        private System.Windows.Forms.Button button_Kiir_fajlba;
        private System.Windows.Forms.Button button_Beolvas_fajlbol;
        private System.Windows.Forms.TextBox textBox_Vevo_neve;
        private System.Windows.Forms.TextBox textBox_Adoazonosito;
        private System.Windows.Forms.NumericUpDown numeric_Vasarlas_osszege;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Szuletett;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Listabol_torol;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

