using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace IndexRenamer
{
    public static class Openfiles
    {

        public static List<string> PicturesFilenames = new List<string>();

        public static void Open()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            open.Multiselect = true;
            if (open.ShowDialog() == DialogResult.OK)
            {
                PicturesFilenames.Clear();
                int i = 0;
                foreach (string file in open.FileNames)
                {
                    PicturesFilenames.Add(open.FileNames[i]);
                    i++;
                }
            }
        }
    }
}
