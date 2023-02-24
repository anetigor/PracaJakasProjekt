namespace ProjektWażnyMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void opisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            string[] Uno = File.ReadAllLines("pliczek.txt");
            Form2 form2 = new Form2();
            foreach (string Un in Uno)
            {
                string[] budu = Un.Split(';');
                if (listView1.SelectedItems.Count > 0)
                {                   
                    if (budu[0] == listView1.SelectedItems[0].Text)
                    {
                        danie danie = new danie(budu[0], budu[1], Convert.ToInt32(budu[2]), Convert.ToInt32(budu[3]), Convert.ToInt32(budu[4]), Convert.ToInt32(budu[5]));
                        form2.opiso = danie.info();
                        form2.ShowDialog();
                    }
                }
            }

        }

      
        public class danie
        {
            string nazwa { get; set; }
            string opis { get; set; }
            int cena { get; set; }
            int cenaZestaw { get; set; }
            int ocenaKlient { get; set; }
            int ocenaKrytyk { get; set; }

            public danie(string nazwa, string opis, int cena,int cenaZestaw, int ocenaKlient, int ocenaKrytyk)
            {
                this.nazwa = nazwa;
                this.opis = opis;
                this.cena = cena;
                this.cenaZestaw = cenaZestaw;
                this.ocenaKlient = ocenaKlient;
                this.ocenaKrytyk = ocenaKrytyk;
                
            }

            public string info()
            {
                return nazwa + ": Składa się ona z " + opis + ".\n Kosztuje ona " + cena + "zł  a w zestawie kosztuje  " + cenaZestaw  + "zł.\n Klienci oceniają ją na: " + ocenaKlient + " a krytycy na " + ocenaKrytyk;
            }
        }

        private void zamówToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form3 form3= new Form3();
            form3.ShowDialog();
        }
    }
}