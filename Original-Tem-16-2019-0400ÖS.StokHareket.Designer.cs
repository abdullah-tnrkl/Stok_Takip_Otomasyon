namespace StajProjeStokTakip
{
    partial class StokHareket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokHareket));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxfis = new System.Windows.Forms.TextBox();
            this.textBoxbelge = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxfirma = new System.Windows.Forms.ComboBox();
            this.comboBoxdepo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxislem = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StokKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Renk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renkid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miktarı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acıklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxaciklama = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(50, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fiş  Kodu : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(50, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Belge No :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(78, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarih : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(378, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Firma : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(378, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Depo : ";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(179, 137);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(132, 23);
            this.dateTimePicker.TabIndex = 5;
            // 
            // textBoxfis
            // 
            this.textBoxfis.Location = new System.Drawing.Point(179, 59);
            this.textBoxfis.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxfis.Name = "textBoxfis";
            this.textBoxfis.Size = new System.Drawing.Size(132, 23);
            this.textBoxfis.TabIndex = 6;
            // 
            // textBoxbelge
            // 
            this.textBoxbelge.Location = new System.Drawing.Point(179, 96);
            this.textBoxbelge.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxbelge.Name = "textBoxbelge";
            this.textBoxbelge.Size = new System.Drawing.Size(132, 23);
            this.textBoxbelge.TabIndex = 7;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StokKodu,
            this.id,
            this.Renk,
            this.renkid,
            this.Birim,
            this.birimid,
            this.Miktarı,
            this.Acıklama});
            this.dataGridView2.GridColor = System.Drawing.Color.DimGray;
            this.dataGridView2.Location = new System.Drawing.Point(47, 394);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView2.Size = new System.Drawing.Size(612, 232);
            this.dataGridView2.TabIndex = 10;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView2.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            this.dataGridView2.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(689, 568);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 58);
            this.button1.TabIndex = 11;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxfirma
            // 
            this.comboBoxfirma.FormattingEnabled = true;
            this.comboBoxfirma.Location = new System.Drawing.Point(456, 26);
            this.comboBoxfirma.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxfirma.Name = "comboBoxfirma";
            this.comboBoxfirma.Size = new System.Drawing.Size(132, 24);
            this.comboBoxfirma.TabIndex = 13;
            this.comboBoxfirma.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxdepo
            // 
            this.comboBoxdepo.FormattingEnabled = true;
            this.comboBoxdepo.Location = new System.Drawing.Point(456, 71);
            this.comboBoxdepo.Name = "comboBoxdepo";
            this.comboBoxdepo.Size = new System.Drawing.Size(132, 24);
            this.comboBoxdepo.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(17, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "İşlem Seçiniz : ";
            // 
            // comboBoxislem
            // 
            this.comboBoxislem.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxislem.FormattingEnabled = true;
            this.comboBoxislem.Items.AddRange(new object[] {
            "Girdi",
            "Çıktı"});
            this.comboBoxislem.Location = new System.Drawing.Point(179, 23);
            this.comboBoxislem.Name = "comboBoxislem";
            this.comboBoxislem.Size = new System.Drawing.Size(132, 24);
            this.comboBoxislem.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(227, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(257, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "Stok Hareket Ekranı";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(708, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 33);
            this.button2.TabIndex = 18;
            this.button2.Text = "Fiş Ekranı";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panel1
            // 
            this.panel1.AccessibleName = "";
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBoxaciklama);
            this.panel1.Controls.Add(this.comboBoxislem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBoxdepo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBoxfirma);
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Controls.Add(this.textBoxfis);
            this.panel1.Controls.Add(this.textBoxbelge);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel1.Location = new System.Drawing.Point(47, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 297);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // StokKodu
            // 
            this.StokKodu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.StokKodu.DataPropertyName = "stokid";
            this.StokKodu.HeaderText = "StokKodu";
            this.StokKodu.Name = "StokKodu";
            this.StokKodu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // id
            // 
            this.id.HeaderText = "stokid";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // Renk
            // 
            this.Renk.DataPropertyName = "renkid";
            this.Renk.HeaderText = "Renk";
            this.Renk.Name = "Renk";
            this.Renk.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // renkid
            // 
            this.renkid.HeaderText = "renkid";
            this.renkid.Name = "renkid";
            this.renkid.Visible = false;
            // 
            // Birim
            // 
            this.Birim.DataPropertyName = "birimid";
            this.Birim.HeaderText = "birim";
            this.Birim.Name = "Birim";
            this.Birim.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // birimid
            // 
            this.birimid.HeaderText = "birimid";
            this.birimid.Name = "birimid";
            this.birimid.Visible = false;
            // 
            // Miktarı
            // 
            this.Miktarı.DataPropertyName = "miktar";
            this.Miktarı.HeaderText = "Miktarı";
            this.Miktarı.Name = "Miktarı";
            this.Miktarı.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Acıklama
            // 
            this.Acıklama.DataPropertyName = "aciklama";
            this.Acıklama.HeaderText = "Acıklama";
            this.Acıklama.Name = "Acıklama";
            this.Acıklama.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // textBoxaciklama
            // 
            this.textBoxaciklama.Location = new System.Drawing.Point(456, 116);
            this.textBoxaciklama.Name = "textBoxaciklama";
            this.textBoxaciklama.Size = new System.Drawing.Size(132, 23);
            this.textBoxaciklama.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(350, 119);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Açıklama : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(65, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "label9";
            // 
            // StokHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(881, 698);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StokHareket";
            this.Text = "StokHareket";
            this.Load += new System.EventHandler(this.StokHareket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBoxfis;
        private System.Windows.Forms.TextBox textBoxbelge;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxfirma;
        private System.Windows.Forms.ComboBox comboBoxdepo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxislem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Renk;
        private System.Windows.Forms.DataGridViewTextBoxColumn renkid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birim;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktarı;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acıklama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxaciklama;
        private System.Windows.Forms.Label label9;
    }
}