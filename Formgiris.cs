using System.Data.SqlClient;

namespace WinFormsApp16
{
	public partial class Formgiris : Form
	{
		public Formgiris()
		{
			InitializeComponent();
		}

		SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=dbkutuphane;Integrated Security=True");


		
		private void button1_Click(object sender, EventArgs e)
		{
			formkitaplar formkitaplar;
			string sifre="";
			try
			{
				baglanti.Open();
				SqlCommand sqlkomut = new SqlCommand("SELECT sifre FROM kutuphaneyoneticileri WHERE kullanýcýadý=@p1",baglanti);
				sqlkomut.Parameters.AddWithValue("@P1",textBox1.Text);
				SqlDataReader sqlDataReader = sqlkomut.ExecuteReader();

				

				
				while (sqlDataReader.Read())
				{
					sifre = sqlDataReader[0].ToString();
				}
				//label3.Text = sifre;

				if(sifre==textBox2.Text) {
					label3.Text = "þifre doðru";
					formkitaplar=new formkitaplar();
					formkitaplar.Show();
					
				}
				else
				{
					MessageBox.Show("kullanýcý adý hatalý veya sifre hatalý");
					textBox1.Text = " ";
					textBox2.Text = " ";	
				}

			}
			catch(Exception ex){
				MessageBox.Show("baðlantý hatasý"+ ex.Message);
			
			}
			finally
			{
				baglanti.Close();

			}
		}
	}
}
