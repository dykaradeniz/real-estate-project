using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SiteEmlakProgrami
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        SqlConnection connection = new SqlConnection("Server=TRN00352;Initial Catalog=Siteler; Integrated Security=True");

        private void ShowData()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Select * from SiteBilgi", connection);
            SqlDataReader reader = command.ExecuteReader();

            listView1.Items.Clear();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = reader["Id"].ToString();
                item.SubItems.Add(reader["Site"].ToString());
                item.SubItems.Add(reader["SatKira"].ToString());
                item.SubItems.Add(reader["Oda"].ToString());
                item.SubItems.Add(reader["Metre"].ToString());
                item.SubItems.Add(reader["Fiyat"].ToString());
                item.SubItems.Add(reader["Blok"].ToString());
                item.SubItems.Add(reader["No"].ToString());
                item.SubItems.Add(reader["AdSoyad"].ToString());
                item.SubItems.Add(reader["Telefon"].ToString());
                item.SubItems.Add(reader["Notlar"].ToString());
                listView1.Items.Add(item);

            }
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }


        }
        private void Save()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand command = new SqlCommand("Insert into SiteBilgi (Site,SatKira,Oda,Metre,Fiyat,Blok,No,AdSoyad,Telefon,Notlar) Values ('" + cbxSite.Text + "','" + cbxSatisDurum.Text + "','" + cbxOda.Text + "','" + tbxMetre.Text + "','" + tbxFiyat.Text + "','" + cbxBlok.Text + "','" + tbxDaire.Text + "','" + tbxAdSoyad.Text + "','" + tbxTelefon.Text + "','" + tbxNotlar.Text + "')", connection);
            command.ExecuteNonQuery();

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            ShowData();
        }

        int Id;
        private void Delete()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand command = new SqlCommand("Delete from SiteBilgi where Id=("+Id+")",connection);
            command.ExecuteNonQuery();

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            ShowData();
        }

        private void Update()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Update SiteBilgi set Site='"+cbxSite.Text+"',SatKira='"+cbxSatisDurum.Text+"',Oda='"+cbxOda.Text+"',Metre='"+tbxMetre.Text+"',Fiyat='"+tbxFiyat.Text+"',Blok='"+cbxBlok.Text+"',No='"+tbxDaire.Text+"',AdSoyad='"+tbxAdSoyad.Text+"',Telefon='"+tbxTelefon.Text+"',Notlar='"+tbxNotlar.Text+"'where Id=("+Id+")",connection);
            command.ExecuteNonQuery();
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            ShowData();
        }

        private void Clear()
        {
            tbxAdSoyad.Clear();
            tbxFiyat.Clear();
            tbxMetre.Clear();
            tbxNotlar.Clear();
            tbxTelefon.Clear();
            tbxDaire.Clear();
            cbxBlok.Text = " ";
            cbxOda.Text = " ";
            cbxSatisDurum.Text = " ";
            cbxSite.Text = " ";
        }

        private void cbxSite_SelectedIndexChanged(object sender, EventArgs e)
        {
           Nerede();
        }
        
        private void Nerede()
        {
            if (cbxSite.Text == "Zambak Sitesi")
            {
                btnZambak.BackColor = Color.Magenta;
                btnGul.BackColor = Color.Thistle;
                btnMenekse.BackColor = Color.Thistle;
                btnPapatya.BackColor = Color.Thistle;
            }
            else if (cbxSite.Text == "Gül Sitesi")
            {
                btnZambak.BackColor = Color.Thistle;
                btnGul.BackColor = Color.Magenta;
                btnMenekse.BackColor = Color.Thistle;
                btnPapatya.BackColor = Color.Thistle;
            }
            else if (cbxSite.Text == "Menekşe Sitesi")
            {
                btnZambak.BackColor = Color.Thistle;
                btnGul.BackColor = Color.Thistle;
                btnMenekse.BackColor = Color.Magenta;
                btnPapatya.BackColor = Color.Thistle;
            }
            else if (cbxSite.Text == "Papatya Sitesi")
            {
                btnZambak.BackColor = Color.Thistle;
                btnGul.BackColor = Color.Thistle;
                btnMenekse.BackColor = Color.Thistle;
                btnPapatya.BackColor = Color.Magenta;
            }
            

        }

        private void SiteClear()
        {
            btnZambak.BackColor = Color.Thistle;
            btnGul.BackColor = Color.Thistle;
            btnMenekse.BackColor = Color.Thistle;
            btnPapatya.BackColor = Color.Thistle;
        }
        private void btnGoster_Click(object sender, EventArgs e)
        {
            ShowData();
            SiteClear();
            Clear();
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Save();
            Clear();
            SiteClear();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Delete();
            SiteClear();
            Clear();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            

            Id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            cbxSite.Text = listView1.SelectedItems[0].SubItems[1].Text;

            Nerede();


            cbxSatisDurum.Text = listView1.SelectedItems[0].SubItems[2].Text;
            cbxOda.Text = listView1.SelectedItems[0].SubItems[3].Text;
            tbxMetre.Text = listView1.SelectedItems[0].SubItems[4].Text;
            tbxFiyat.Text = listView1.SelectedItems[0].SubItems[5].Text;
            cbxBlok.Text = listView1.SelectedItems[0].SubItems[6].Text;
            tbxDaire.Text = listView1.SelectedItems[0].SubItems[7].Text;
            tbxAdSoyad.Text = listView1.SelectedItems[0].SubItems[8].Text;
            tbxTelefon.Text = listView1.SelectedItems[0].SubItems[9].Text;
            tbxNotlar.Text = listView1.SelectedItems[0].SubItems[10].Text;
 
           
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            Id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            Update();
            
            //Clear();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
