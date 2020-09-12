using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace StajProjeStokTakip
{
    public partial class StokHareket : Form
    {
        SqlConnection con;
        SqlCommandBuilder builder = new SqlCommandBuilder();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand komut = new SqlCommand();
        int fis_id;

        public void verial()
        {




        }
        public StokHareket()
        {
            string x = @"Data Source=DESKTOP-8JH78OT\MSSQLSERVER01;Initial Catalog=StokTakip;Integrated Security=SSPI; " +
                "User ID = sa;Password=Apo23.44;";
            con = new SqlConnection(x);



            InitializeComponent();
        }
        






        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int islemturu;

            if (comboBoxislem.SelectedIndex == 0)
            {

                islemturu = 6;
                label9.Text = (islemturu.ToString());

            }
            else if (comboBoxislem.SelectedIndex == 1)
            {
                islemturu = 0;
                label9.Text = (islemturu.ToString());
            }
            //alttablokaydet();
            //üsttablokaydet();





            fis_id = 0;
            string www = fis_id.ToString("000000");
            int sayi = Convert.ToInt32(www);
            for (sayi = 0; sayi<1000000;sayi++)
            {

            }

            


            //if (MessageBox.Show("Kaydetmek istediğinizden emin misiniz ?","Open paint ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{

            //}

        }
        public void üsttablokaydet()
        {
            




            fis_id = 0;
            string www = fis_id.ToString("000000");
            int sayi = Convert.ToInt32(www);
            for (sayi = 0; sayi < 1000000; sayi++)
            {
                con.Open();
                String Query = "insert into usttablo(islemturu,belge_no ,tarih,firma,depo,aciklama,fis_id)values('" + this.comboBoxislem.Text + "','" + this.textBoxbelge.Text + "','" + this.dateTimePicker.Text + "','" + this.comboBoxfirma.Text + "','" + this.comboBoxdepo.Text + "','" + this.textBoxaciklama.Text + "','" + sayi.ToString() + "); ";
                SqlCommand komut = new SqlCommand(Query, con);
                komut.ExecuteNonQuery();
                MessageBox.Show("başarılı");
                con.Close();

            }
            

        }



        public void alttablokaydet()
        {
          
            SqlCommand cmm = new SqlCommand();
            cmm.Connection = con;
            cmm.Connection.Open();
            cmm.Parameters.Clear();
            fis_id = 0;

            foreach (DataRow r in dt.Rows)
            {
                cmm.Parameters.Clear();
                switch (r.RowState)
                {
                    case DataRowState.Added:
                        MessageBox.Show("başarılı");

                        cmm.CommandText = "insert into alttablo (stokid, birimid,renkid,miktar,aciklama,fis_id) values(@stokid,@birimid,@renkid,@miktar, @aciklama,)";
                        cmm.Parameters.AddWithValue("@stokid", r["stokid"].ToString());
                        cmm.Parameters.AddWithValue("@birimid", r["birimid"].ToString());
                        cmm.Parameters.AddWithValue("@renkid" , r["renkid"].ToString());
                        cmm.Parameters.AddWithValue("@miktar", r["miktar"].ToString());
                        cmm.Parameters.AddWithValue("@aciklama", r["aciklama"].ToString());
                        cmm.Parameters.AddWithValue("@fis_id", r[this.fis_id].ToString());
                        cmm.ExecuteNonQuery();
                        
                        break;


                    case DataRowState.Deleted:
                        DialogResult silme = MessageBox.Show("Veri silinsin mi ? ", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (silme == DialogResult.Yes)
                        {
                            var rowid = r["id", DataRowVersion.Original];
                            cmm.CommandText = "delete from alttablo where id='" + rowid + "'";
                            cmm.ExecuteNonQuery();
                            break;
                        }
                        else { break; }



                    case DataRowState.Modified:
                        {
                            var rowid = r["id"];
                            cmm.CommandText = "update alttablo set kodu='" + r["kodu"].ToString() + "' ,aciklama='" + r["aciklama"].ToString() + "' where id='" + r[0].ToString() + "'";
                            cmm.ExecuteNonQuery();
                            break;
                        }

                }

            


        

            }
            cmm.Connection.Close();
            dt.AcceptChanges();
        }
        





        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


       



        private void StokHareket_Load(object sender, EventArgs e)
        {

            komut.Connection = con;
            komut.CommandText = "select * from alttablo";
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            dataGridView2.DataSource = dt;


            comboBoxfirma.Items.Clear();
            SqlDataReader oku;
            con.Open();
            komut.Connection = con;
            komut.CommandText = "select * from firma ";
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBoxfirma.Items.Add(oku[2].ToString());


            }
            con.Close();
            comboBoxdepo.Items.Clear();
            SqlDataReader oku1;
            con.Open();
            komut.Connection = con;
            komut.CommandText = "select * from depo ";
            oku1 = komut.ExecuteReader();
            while (oku1.Read())
            {
                comboBoxdepo.Items.Add(oku1[2].ToString());


            }
            con.Close();




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {






        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {




        }

        private void button2_Click_1(object sender, EventArgs e)
        {



            fis f = new fis();
            f.Show();
            Close();
        }




        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//tablo çift klik
        {
            tanımlarveri tv = new tanımlarveri();
            DataTable dt = new DataTable();

            if (e.ColumnIndex == 0)
            {

                con.Open();
                komut = new SqlCommand("select s.id, s.kodu, s.aciklama from stok s", con);
                da = new SqlDataAdapter(komut);
                da.Fill(dt);
                tv.dataGridView5.DataSource = dt;
                komut.ExecuteNonQuery();
                con.Close();

                if (tv.ShowDialog() == DialogResult.OK)
                {
                    dataGridView2.CurrentRow.Cells[0].Value = tv.GetAciklamalar;
                    dataGridView2.CurrentRow.Cells[1].Value = tv.GetId;
                }




            }
            else if (e.ColumnIndex == 2)
            {
                con.Open();
                komut = new SqlCommand("select s.id, s.kodu, s.aciklama from renk s", con);
                da = new SqlDataAdapter(komut);
                da.Fill(dt);
                tv.dataGridView5.DataSource = dt;
                komut.ExecuteNonQuery();
                con.Close();

                if (tv.ShowDialog() == DialogResult.OK)
                {
                    dataGridView2.CurrentRow.Cells[2].Value = tv.GetAciklamalar;
                    dataGridView2.CurrentRow.Cells[3].Value = tv.GetId;
                }
            }
            else if (e.ColumnIndex == 4)
            {
                con.Open();
                komut = new SqlCommand("select s.id, s.kodu, s.aciklama from birim s", con);
                da = new SqlDataAdapter(komut);
                da.Fill(dt);
                tv.dataGridView5.DataSource = dt;
                komut.ExecuteNonQuery();
                con.Close();

                if (tv.ShowDialog() == DialogResult.OK)
                {
                    dataGridView2.CurrentRow.Cells[4].Value = tv.GetAciklamalar;
                    dataGridView2.CurrentRow.Cells[5].Value = tv.GetId;
                }

            }


            }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }


