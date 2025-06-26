using System.Windows.Forms;

namespace StokEkstre
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonGetir = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxBas = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxBit = new System.Windows.Forms.MaskedTextBox();
            this.buttonBas = new System.Windows.Forms.Button();
            this.buttonBit = new System.Windows.Forms.Button();
            this.dateTimePickerBas = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBit = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ürün";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Başlangıç";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(659, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bitiş";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(937, 390);
            this.dataGridView1.TabIndex = 6;
            // 
            // buttonGetir
            // 
            this.buttonGetir.Location = new System.Drawing.Point(856, 15);
            this.buttonGetir.Name = "buttonGetir";
            this.buttonGetir.Size = new System.Drawing.Size(96, 23);
            this.buttonGetir.TabIndex = 7;
            this.buttonGetir.Text = "Getir";
            this.buttonGetir.UseVisualStyleBackColor = true;
            this.buttonGetir.Click += new System.EventHandler(this.buttonGetir_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(53, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(313, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // maskedTextBoxBas
            // 
            this.maskedTextBoxBas.Location = new System.Drawing.Point(469, 16);
            this.maskedTextBoxBas.Mask = "00/00/0000";
            this.maskedTextBoxBas.Name = "maskedTextBoxBas";
            this.maskedTextBoxBas.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBoxBas.TabIndex = 11;
            this.maskedTextBoxBas.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxBit
            // 
            this.maskedTextBoxBit.Location = new System.Drawing.Point(697, 16);
            this.maskedTextBoxBit.Mask = "00/00/0000";
            this.maskedTextBoxBit.Name = "maskedTextBoxBit";
            this.maskedTextBoxBit.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBoxBit.TabIndex = 12;
            this.maskedTextBoxBit.ValidatingType = typeof(System.DateTime);
            // 
            // buttonBas
            // 
            this.buttonBas.Location = new System.Drawing.Point(575, 15);
            this.buttonBas.Name = "buttonBas";
            this.buttonBas.Size = new System.Drawing.Size(21, 23);
            this.buttonBas.TabIndex = 13;
            this.buttonBas.Text = "📅";
            this.buttonBas.UseVisualStyleBackColor = true;
            this.buttonBas.Click += new System.EventHandler(this.buttonBas_Click);
            // 
            // buttonBit
            // 
            this.buttonBit.Location = new System.Drawing.Point(803, 15);
            this.buttonBit.Name = "buttonBit";
            this.buttonBit.Size = new System.Drawing.Size(23, 23);
            this.buttonBit.TabIndex = 14;
            this.buttonBit.Text = "📅";
            this.buttonBit.UseVisualStyleBackColor = true;
            this.buttonBit.Click += new System.EventHandler(this.buttonBit_Click);
            // 
            // dateTimePickerBas
            // 
            this.dateTimePickerBas.Location = new System.Drawing.Point(418, 275);
            this.dateTimePickerBas.Name = "dateTimePickerBas";
            this.dateTimePickerBas.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerBas.TabIndex = 15;
            this.dateTimePickerBas.Visible = false;
            this.dateTimePickerBas.CloseUp += new System.EventHandler(this.dateTimePickerBas_CloseUp);
            // 
            // dateTimePickerBit
            // 
            this.dateTimePickerBit.Location = new System.Drawing.Point(418, 332);
            this.dateTimePickerBit.Name = "dateTimePickerBit";
            this.dateTimePickerBit.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerBit.TabIndex = 16;
            this.dateTimePickerBit.Visible = false;
            this.dateTimePickerBit.CloseUp += new System.EventHandler(this.dateTimePickerBit_CloseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 450);
            this.Controls.Add(this.dateTimePickerBit);
            this.Controls.Add(this.dateTimePickerBas);
            this.Controls.Add(this.buttonBit);
            this.Controls.Add(this.buttonBas);
            this.Controls.Add(this.maskedTextBoxBit);
            this.Controls.Add(this.maskedTextBoxBas);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonGetir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Stok Ekstre";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonGetir;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxBas;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxBit;
        private System.Windows.Forms.Button buttonBas;
        private System.Windows.Forms.Button buttonBit;
        private System.Windows.Forms.DateTimePicker dateTimePickerBas;
        private System.Windows.Forms.DateTimePicker dateTimePickerBit;
    }
}

