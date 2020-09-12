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
        DataSet ds = new DataSet();

        int fis_id;
        public StokHareket()
        {
            string x = @"Data Source=DESKTOP-8JH78OT\MSSQLSERVER01;Initial Catalog=StokTakip;Integrated Security=SSPI; " +
                "User ID = sa;Password=Apo23.44;";
            con = new SqlConnection(x);
            InitializeComponent();
        }

        #region XXXXXXXXXXXXXXXX  METODLAR  XXXXXXXXXXXXXXXX


        void comboboxdoldur()
        {



            //SqlCommand cmm = new SqlCommand();
            DataTable dtfirma = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("select a.id,a.aciklama from firma a", con);
            adp.Fill(dtfirma);

            comboBoxfirma.DisplayMember = "aciklama";
            comboBoxfirma.ValueMember = "id";
            comboBoxfirma.DataSource = dtfirma;

            DataTable dtdepo = new DataTable();
            SqlDataAdapter dadepo = new SqlDataAdapter("select a.id,a.aciklama from depo a", con);
            dadepo.Fill(dtdepo);

            comboBoxdepo.DisplayMember = "aciklama";
            comboBoxdepo.ValueMember = "id";
            comboBoxdepo.DataSource = dtdepo;



        }
        void fisdoldur()
        {
            con.Open();
            string sorgu = "SELECT top 1 fis_id FROM usttablo ORDER BY fis_id DESC";
            SqlCommand cmd = new SqlCommand(sorgu, con);
            int a = Convert.ToInt32(cmd.ExecuteScalar());
            if (a == null) { a = 1; }
            else { a++; }
            con.Close();
            textBox1.Text = sifirEkle(a);

        }
        public string sifirEkle(int x)
        {
            return
              (x.ToString().PadLeft(6, '0'));
        }
        public void alttablo()
        {
            komut.Connection = con;
            komut.CommandText = "select stokkodu=s.kodu ,stokid=s.id, renkkodu=r.kodu , renkid =r.id,birimkodu=b.kodu,birimid=b.id ,at.miktar,at.aciklama from alttablo at " +
           "left outer join stok s on s.id = at.stokid " +
           "left outer join renk r on r.id = at.renkid " +
           "left outer join birim b on b.id = at.birimid ";
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            dataGridView2.DataSource = dt;

        }
        public void üsttablokaydet()
        {


            con.Open();
            string sorgu = "SELECT top 1 fis_id FROM usttablo ORDER BY fis_id DESC";
            SqlCommand cmd = new SqlCommand(sorgu, con);
            int a = Convert.ToInt32(cmd.ExecuteScalar());
            if (a == null) { a = 1; }
            else { a++; }
            con.Close();

            

            con.Open();
            String Query = "insert into usttablo(id,islem_turu,belge_no ,tarih,firma,depo,aciklama,fis_id)values('" + a + "','" + this.comboBoxislem.SelectedIndex + "','" + this.textBoxbelge.Text + "','" + this.dateTimePicker.Text + "','" + this.comboBoxfirma.SelectedValue + "','" + this.comboBoxdepo.SelectedValue + "','" + this.textBoxaciklama.Text + "','" + this.textBox1.Text + "')";
            SqlCommand komut = new SqlCommand(Query, con);
            komut.ExecuteNonQuery();
            MessageBox.Show("başarılı");
            con.Close();
        }
        #endregion


        #region transaction 
//        string x = @"Data Source=DESKTOP-8JH78OT\MSSQLSERVER01;Initial Catalog=StokTakip;Integrated Security=SSPI; " +
//                "User ID = sa;Password=Apo23.44;";
//        con = new SqlConnection(x);
//        SqlTransaction islem = null; //Transaction değişkenimizi tanımlıyoruz
 
////SQL bağlantımızı oluşturuyoruz
//using (SqlConnection con = new SqlConnection(x))
//{
//    baglanti.Open();//SQL bağlantımızı açıyoruz
//    islem = baglanti.BeginTransaction();//SQL bağlantımız için Transaction işlemini başlatıyoruz
 
//    SqlCommand komut1 = new SqlCommand("insert into SiparisTablosu (siparisID, siparisAciklamasi) values(1, 'TestSiparis')", baglanti);//İlk parça insert işlemini SQL'e gönderecek komutu yazıyoruz
//    SqlCommand komut2 = new SqlCommand("insert into SiparisAyrintiTablosu (SiparisID, SatirNO, SatirAciklamasi) values(1, 1, 'Test Satiri')", baglanti);//İkinci parça insert işlemimizi de SQL'e  gönderecek komutu yazıyoruz
//    try
//    {
//        //try catch bloğu içinde komutlarımızı SQL'e gönderiyoruz
//        komut1.ExecuteNonQuery();
//        komut2.ExecuteNonQuery(); 
 
//        //İki işlemimizde işlenirken bir hata gerçekleşmez ise Transaction işlemini onaylıyoruz
//        islem.Commit();
//    }
//    catch (Exception hataMesaji)
//    {
//        //Bu blok çalışırsa try bloğu içinde herhangi bir yerde hata oluşmuş demektir ki o zaman SQL'e yazılan verileri geri alıyoruz
//        islem.Rollback();
//        //Verilen hatayı bir mesaj kutusunda programa gönderiyoruz
//        MessageBox.Show(hataMesaji.ToString());
//    }
//    finally
//    {
//        //İşlem başarılı da olsa hatalı da olsa sonuç olarak SQL bağlantımızı kapatıyoruz
//        baglanti.Close();
//    }
//}
        #endregion


        #region kaydet butonu
        private void button1_Click(object sender, EventArgs e)
        {




            //label9.Text = (sayi.ToString());    
            üsttablokaydet();

            //alttablokaydet();
            //alttablo();
            


        }

        #endregion


        #region ALTTABLO KAYIT
        public void alttablokaydet()
        {
    
            con.Open();
            string sorgu = "SELECT top 1 fis_id FROM alttablo ORDER BY fis_id DESC";
            SqlCommand cmd = new SqlCommand(sorgu, con);
            int a = Convert.ToInt32(cmd.ExecuteScalar());
            if (a == null)
            {
                a = 1;
            }
            else
            {
                a = a + 1;

            }
            

            SqlCommand cmm = new SqlCommand();
            cmm.Connection = con;
            //cmm.Connection.Open();
            cmm.Parameters.Clear();





            for (int i = 1; i < dataGridView2.Rows.Count; i++)
            {

                var val1 = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                var val2 = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                var val3 = dataGridView2.CurrentRow.Cells[5].Value.ToString();
                var val4 = dataGridView2.CurrentRow.Cells[6].Value.ToString();
                var val5 = dataGridView2.CurrentRow.Cells[7].Value.ToString();



                cmm.Connection = con;
                cmm.CommandText = "INSERT INTO alttablo (stokid, renkid,birimid,miktar,aciklama,fis_id) VALUES ('" + val1 + "' , '" + val2 + "' , '" + val3 + "','" + val4 + "','" + val5 + "','" + sifirEkle(a) + "')";
                cmm.ExecuteNonQuery();
                MessageBox.Show("Eklendi");
                dataGridView2.DataSource = null;
                con.Close();

            }




            //komut.CommandText = "insert into alttablo (stokid, birimid,renkid,miktar,aciklama,fis_id) values('" +dataGridView2.CurrentRow.+"', '"+txtSoyad.Text+"','"+txtAdres.Text +"')";

            //komut.Connection = con;

            //komut.ExecuteNonQuery();



            // komut.CommandText = "select stokkodu=s.kodu ,stokid=s.id, renkkodu=r.kodu , renkid =r.id,birimkodu=b.kodu,birimid=b.id ,at.miktar,at.aciklama from alttablo at " +
            //"left outer join stok s on s.id = at.stokid " +
            //"left outer join renk r on r.id = at.renkid " +
            //"left outer join birim b on b.id = at.birimid ";
            // SqlDataAdapter da = new SqlDataAdapter(komut);
            // da.Fill(dt);



            //foreach (DataRow r in dt.Rows)
            //{
            //    cmm.Parameters.Clear();
            //    switch (r.RowState)
            //    {
            //        case DataRowState.Added:
            //            MessageBox.Show("başarılı");

            //            cmm.CommandText = "insert into alttablo (stokid, birimid,renkid,miktar,aciklama,fis_id) values(@stokid,@birimid,@renkid,@miktar, @aciklama,@fis_id)";
            //            cmm.Parameters.AddWithValue("@stokid", r["stokid"]);
            //            cmm.Parameters.AddWithValue("@birimid", r["birimid"]);
            //            cmm.Parameters.AddWithValue("@renkid", r["renkid"]);
            //            cmm.Parameters.AddWithValue("@miktar", r["miktar"]);
            //            cmm.Parameters.AddWithValue("@aciklama", r["aciklama"].ToString());
            //            cmm.Parameters.AddWithValue("@fis_id", sifirEkle(a));
            //            cmm.ExecuteNonQuery();

            //            break;


            //        case DataRowState.Deleted:
            //            DialogResult silme = MessageBox.Show("Veri silinsin mi ? ", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //            if (silme == DialogResult.Yes)
            //            {
            //                var rowid = r["id", DataRowVersion.Original];
            //                cmm.CommandText = "delete from alttablo where id='" + rowid + "'";
            //                cmm.ExecuteNonQuery();
            //                break;
            //            }
            //            else { break; }

            //        case DataRowState.Modified:
            //            {
            //                var rowid = r["id"];
            //                cmm.CommandText = "update alttablo set kodu='" + r["kodu"].ToString() + "' ,aciklama='" + r["aciklama"].ToString() + "' where id='" + r[0].ToString() + "'";
            //                cmm.ExecuteNonQuery();
            //                break;
            //            }

            //    }
            //}
            //cmm.Connection.Close();
            //dt.AcceptChanges();
        }
        #endregion


      
        #region LOAD


        private void StokHareket_Load(object sender, EventArgs e)
        {
            comboboxdoldur();
            fisdoldur();
          
            //comboBoxfirma.Items.Clear();
            //SqlDataReader oku;
            //con.Open();
            //komut.Connection = con;
            //komut.CommandText = "select * from firma ";
            //oku = komut.ExecuteReader();
            //while (oku.Read())
            //{
            //    comboBoxfirma.Items.Add(oku[2].ToString());


            //}
            //con.Close();
            //comboBoxdepo.Items.Clear();
            //SqlDataReader oku1;
            //con.Open();
            //komut.Connection = con;
            //komut.CommandText = "select * from depo ";
            //oku1 = komut.ExecuteReader();
            //while (oku1.Read())
            //{
            //    comboBoxdepo.Items.Add(oku1[2].ToString());
            // }
            //con.Close();
        }
        #endregion


        #region PASİF
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {


        }
        private void comboBoxislem_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int id = (comboBoxislem.SelectedItem as ).KategoriID;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxfirma.Text = "Lütfen seçiniz...";
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
        private void comboBoxdepo_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxdepo.Text = "Lütfen seçiniz...";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            fis f = new fis(); f.Show(); Close();
        }

        #endregion


        #region ÇİTF KLİK
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tanımlarveri tv = new tanımlarveri();
            DataTable dt = new DataTable();

            if (e.ColumnIndex==0)
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
                    dataGridView2.CurrentRow.Cells[0].Value = tv.GetKodu;
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
                    dataGridView2.CurrentRow.Cells[2].Value = tv.GetKodu;
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
                    dataGridView2.CurrentRow.Cells[4].Value = tv.GetKodu;
                    dataGridView2.CurrentRow.Cells[5].Value = tv.GetId;
                }

            }


            }



        #endregion

       
    }
    }


