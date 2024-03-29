using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Malovani
{
    public partial class Form1 : Form
    {
        #region Deklarace proměnných
        Graphics g;
        Bitmap bmp;
        Point bod = new Point(-1, -1);
        bool pohyb = false;
        Pen tuzka = new Pen(Color.Black, 10);
        Funkce proces;
        #endregion

        public Form1()
        {
            InitializeComponent();
            VytvorPlatno(pictureBox.Width, pictureBox.Height);
            list_tloustka.SelectedIndex = 2;
            list_funkce.SelectedIndex = 0;
        }

        #region Pohyby myší

        // Zmačknutí tlačítka na myši
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pohyb = true;
            bod.X = e.X;
            bod.Y = e.Y;
        }

        // Pohyb myší
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pohyb && bod.X >= 0 && bod.Y >= 0)
            {
                switch (proces)
                {
                    case Funkce.Kresleni:
                        tuzka.Color = btn_barva.BackColor;
                        break;
                    case Funkce.Guma:
                        tuzka.Color = Color.White;
                        break;
                    default:
                        tuzka.Color = btn_barva.BackColor;
                        return;
                }
                g.DrawLine(tuzka, new Point(bod.X, bod.Y), e.Location);
                bod = new Point(e.X, e.Y);
                g = Graphics.FromImage(bmp);
                pictureBox.Image = bmp;
            }
        }

        // Odmačknutí tlačítka na myši
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            switch (proces)
            {
                case Funkce.Usecka:
                    g.DrawLine(tuzka, new Point(bod.X, bod.Y), e.Location);
                    break;
                case Funkce.Oval:
                    g.DrawEllipse(tuzka, VratObvod(e));
                    break;
                case Funkce.Ctverec:
                    g.DrawRectangle(tuzka, VratObvod(e));
                    break;
            }

            g = Graphics.FromImage(bmp);
            pictureBox.Image = bmp;

            pohyb = false;
            bod.X = -1;
            bod.Y = -1;
        }
        #endregion

        #region Soubor

        // Vytvoření nového plátna
        private void item_novy_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
            VytvorPlatno(pictureBox.Width, pictureBox.Height);
        }

        // Otevření nového obrázku
        private void item_otevrit_Click(object sender, EventArgs e)
        {
            bmp = Soubor.Otevri(pictureBox, bmp);
            if (bmp == null)
            {
                MessageBox.Show("Soubor nelze oteřít", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Uložení obrázku
        private void item_ulozit_Click(object sender, EventArgs e)
        {
            if (!Soubor.Uloz(bmp))
            {
                MessageBox.Show("Soubor nelze uložit", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Nastavovací módy

        // Barva
        private void btn_barva_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btn_barva.BackColor = colorDialog1.Color;
        }

        // Tloušťka
        private void list_tloustka_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (list_tloustka.SelectedIndex)
            {
                case 0:
                    tuzka = ZmenVelikost(1);
                    break;
                case 1:
                    tuzka = ZmenVelikost(3);
                    break;
                case 2:
                    tuzka = ZmenVelikost(5);
                    break;
                case 3:
                    tuzka = ZmenVelikost(10);
                    break;
                case 4:
                    tuzka = ZmenVelikost(20);
                    break;
            }
            tuzka.StartCap = tuzka.EndCap = LineCap.Round;
        }

        // Funkce
        private void list_funkce_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (list_funkce.SelectedIndex)
            {
                case 0:
                    proces = Funkce.Kresleni;
                    break;
                case 1:
                    proces = Funkce.Guma;
                    break;
                case 2:
                    proces = Funkce.Usecka;
                    break;
                case 3:
                    proces = Funkce.Oval;
                    break;
                case 4:
                    proces = Funkce.Ctverec;
                    break;
            }
        }
        #endregion

        #region Pomocné funkce
        private void VytvorPlatno(int width, int height)
        {
            g = pictureBox.CreateGraphics();
            bmp = new Bitmap(width, height, g);
            pictureBox.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
        }

        private Pen ZmenVelikost(int velikost)
        {
            return new Pen(btn_barva.BackColor, velikost);
        }

        private Rectangle VratObvod(MouseEventArgs e)
        {
            return new Rectangle(
                Math.Min(e.X, bod.X),
                Math.Min(e.Y, bod.Y),
                Math.Abs(e.X - bod.X),
                Math.Abs(e.Y - bod.Y));
        }
        #endregion
    }
}
