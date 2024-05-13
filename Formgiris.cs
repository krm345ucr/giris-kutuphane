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
				SqlCommand sqlkomut = new SqlCommand("SELECT sifre FROM kutuphaneyoneticileri WHERE kullan�c�ad�=@p1",baglanti);
				sqlkomut.Parameters.AddWithValue("@P1",textBox1.Text);
				SqlDataReader sqlDataReader = sqlkomut.ExecuteReader();

				

				
				while (sqlDataReader.Read())
				{
					sifre = sqlDataReader[0].ToString();
				}
				//label3.Text = sifre;

				if(sifre==textBox2.Text) {
					label3.Text = "�ifre do�ru";
					formkitaplar=new formkitaplar();
					formkitaplar.Show();
					
				}
				else
				{
					MessageBox.Show("kullan�c� ad� hatal� veya sifre hatal�");
					textBox1.Text = " ";
					textBox2.Text = " ";	
				}

			}
			catch(Exception ex){
				MessageBox.Show("ba�lant� hatas�"+ ex.Message);
			
			}
			finally
			{
				baglanti.Close();

			}
		}
	}
}
