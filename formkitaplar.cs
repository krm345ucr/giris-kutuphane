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

namespace WinFormsApp16
{
	public partial class formkitaplar : Form
	{

		SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=dbkutuphane;Integrated Security=True");

		public formkitaplar()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				baglanti.Open();
				SqlCommand sqlCommand = new SqlCommand("INSERT INTO kitaplar (kitapadı,yazaradı,yazarsoyadı,ısbn,kitapturkodu)VALUES (@P1,@P2,@P3,@P4,@P5) ", baglanti);
				sqlCommand.Parameters.AddWithValue("@p1", textBoxkitapadi.Text);
				sqlCommand.Parameters.AddWithValue("@p2", textBoxyazaradi.Text);
				sqlCommand.Parameters.AddWithValue("@p3", textBoxyazarsoyadı.Text);
				sqlCommand.Parameters.AddWithValue("@p4", textBoxısen.Text);
			
				sqlCommand.Parameters.AddWithValue("@p5", textBoxkitapturkodu);

				sqlCommand.ExecuteNonQuery();


			}
			catch (Exception ex)
			{
				MessageBox.Show("kitap eklenirken hata oluştu!"+ex.Message);
			}
			finally
			{
				baglanti.Close();
			}

			verilerigoster();









		}
		private void verilerigoster()
		{
			string q = "SELECT * FROM kitaplar";
			SqlDataAdapter da = new SqlDataAdapter(q, baglanti);
			DataTable dt = new DataTable();
			da.Fill(dt);

			if (dt.Rows.Count > 0)
			{
				dataGridView1.DataSource = dt;

			}
		}
		private void formkitaplar_Load(object sender, EventArgs e)
		{

			verilerigoster();

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
