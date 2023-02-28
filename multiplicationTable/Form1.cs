using System.Runtime.CompilerServices;

namespace multiplicationTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        private void btnHesapla_Click(object sender, EventArgs e)
        {
                     

            for(int x = 1; x <= sayilar.Length; x++) 
            {
                for (int y = 1; y <= sayilar.Length + 1; y++)
                {
                    int sonuc = x * y;
                    listBox.Items.Add(x + "x" + y +   "=" + sonuc);

                }
                


            }





        }
    }
}