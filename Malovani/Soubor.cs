using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Malovani
{
    // zmena
    public static class Soubor
    {
        public static Bitmap Otevri(PictureBox picturebox, Bitmap bmp)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = @"Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;..." })
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        bmp = new Bitmap(openFileDialog.FileName);
                        picturebox.Image = bmp;             
                    }
                    return bmp;
                }
            }
            catch
            {
                return null; 
            }
        }

        public static bool Uloz(Bitmap bmp)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = @"Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;..." })
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        bmp.Save(saveFileDialog.FileName);
                    }
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
