namespace Praktikum_Quiz_Panda_Elyora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //char satu = 'a';
            //char dua = 'b';
            //char tiga = 'c';
            //char empat = 'd';
            //char lima = 'e';
            //char enam = 'f';
            //char tujuh = 'g';
            //char delapan = 'h';
            //char sembilan = 'i';
            //char sepuluh = 'j';
            //char sebelas = 'k';
            //char duabelas = 'l';
            //char tigabelas = 'm';
            //char empatbelas = 'n';
            //char limabelas = 'o';
            //char enambelas = 'p';
            //char tujuhbelas = 'q';
            //char delapanbelas = 'r';
            //char sembilanbelas = 's';
            //char duapuluh = 't';
            //char duasatu = 'u';
            //char duadua = 'v';
            //char duatiga = 'w';
            //char duaempat = 'x';
            //char dualima = 'y';
            //char duaenam = 'z';



            
        }


        private void lblOutput_Click(object sender, EventArgs e)
        {
            
        }

        private void btnKonversi_Click(object sender, EventArgs e)
        {
            string huruf = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz";
            char[] abjad = huruf.ToUpper().ToCharArray();
            char[] awall = txtboxAwal.Text.ToCharArray();
            char coba = awall[0];
            
            char[] akhirr = txtboxAkhir.Text.ToCharArray();
            char cobas = akhirr[0];

            char [] input = txtboxKalimat.Text.ToUpper().ToCharArray();

            int selisih = cobas - coba;

            string result = "";
            int max = txtboxKalimat.Text.Length;

            if(selisih < 0)
            {
                selisih += 26;
            }

            for(int i = 0; i < max; i++)
            {
                if(input[i] == ' ')
                {
                    result += input[i];
                }
                for(int j = 0; j <= 25; j++)
                {
                    if(input[i] == abjad[j])
                    {
                        result += abjad[j + selisih];
                    }
                }
            }
            lblOutput.Text = result.ToUpper();

            
        }
    }
}