using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StokEkstre
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Server=.;Database=Test;Trusted_Connection=True;");

        private void Urunler()
        {
            try
            {               
                con.Open();
                string kayit = "sp_StokUrunler";
                SqlCommand komut = new SqlCommand(kayit, con);
                komut.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "MalAdi";
                comboBox1.ValueMember = "MalKodu";
                con.Close();
            }
            catch
            {

                MessageBox.Show("Veri yükleme sırasında hata oluştu");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Urunler();
            dateTimePickerBas.Format = DateTimePickerFormat.Short;
            dateTimePickerBas.Visible = false;

            // Takvimi MaskedTextBox'ın altına konumla
            dateTimePickerBas.Location = new Point(maskedTextBoxBas.Left, maskedTextBoxBas.Bottom + 2);

            dateTimePickerBit.Format = DateTimePickerFormat.Short;
            dateTimePickerBit.Visible = false;

            // Takvimi MaskedTextBox'ın altına konumla
            dateTimePickerBit.Location = new Point(maskedTextBoxBit.Left, maskedTextBoxBit.Bottom + 2);

     

        }

        private void dateTimePickerBas_CloseUp(object sender, EventArgs e)
        {
            maskedTextBoxBas.Text = dateTimePickerBas.Value.ToString("dd/MM/yyyy");
            dateTimePickerBas.Visible = false;
        }

        private void dateTimePickerBit_CloseUp(object sender, EventArgs e)
        {
            maskedTextBoxBit.Text = dateTimePickerBit.Value.ToString("dd/MM/yyyy");
            dateTimePickerBit.Visible = false;
        }

        private void buttonGetir_Click(object sender, EventArgs e)
        {
            StokEkstre();
        }

        private void StokEkstre()
        {
            try
            {
                if (comboBox1.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen bir ürün seçin!");
                    return;
                }
                con.Open();
                string kayit = "sp_StokEkstre";
                SqlCommand komut = new SqlCommand(kayit, con);
                komut.CommandType = CommandType.StoredProcedure;
                DateTime bastrh = Convert.ToDateTime(maskedTextBoxBas.Text);
                DateTime bittrh = Convert.ToDateTime(maskedTextBoxBit.Text);
                int bastrhInt = (int)Math.Floor(bastrh.AddDays(-2).ToOADate()) + 2;
                int bittrhInt = (int)Math.Floor(bittrh.ToOADate()) + 2;
                SqlDataAdapter da = new SqlDataAdapter(komut);
                string urun = comboBox1.SelectedValue?.ToString();
                da.SelectCommand.Parameters.AddWithValue("@malkodu", urun);
                da.SelectCommand.Parameters.AddWithValue("@bastrh", bastrhInt);
                da.SelectCommand.Parameters.AddWithValue("@bittrh", bittrhInt);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dt.Columns.Add("StokMiktar", typeof(int));
                var stok = 0;
                foreach (DataRow row in dt.Rows)
                {
                    int giris = Convert.ToInt32(row["GirisMiktar"]);
                    int cikis = Convert.ToInt32(row["CikisMiktar"]);
                    string islemTuru = row["IslemTuru"].ToString().Trim();
                    if (islemTuru == "Giriş")
                    {
                        stok += giris;
                    }
                    else if (islemTuru == "Çıkış")
                    {
                        stok -= cikis;
                    }
               
                    row["StokMiktar"] = stok;
                }

                dataGridView1.DataSource = dt;
                dataGridView1.Columns["GirisMiktar"].DefaultCellStyle.Format = "N0";
                dataGridView1.Columns["CikisMiktar"].DefaultCellStyle.Format = "N0";
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Veri yükleme sırasında hata oluştu");
                con.Close();
            }

        }

        private void buttonBas_Click(object sender, EventArgs e)
        {
            dateTimePickerBas.Visible = true;
            dateTimePickerBas.BringToFront(); // Üste gelsin
            dateTimePickerBas.Focus();
        }

        private void buttonBit_Click(object sender, EventArgs e)
        {
            dateTimePickerBit.Visible = true;
            dateTimePickerBit.BringToFront(); // Üste gelsin
            dateTimePickerBit.Focus();
        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {

        }
    }
}
