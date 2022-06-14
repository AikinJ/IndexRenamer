using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndexRenamer
{
    public partial class ProgramForm : Form
    {
        public ProgramForm()
        {
            InitializeComponent();
        }

        private void btnOpenPicturesClicked(Object sender, EventArgs e)
        {
            Openfiles.Open();
        }

        private void RenameIndexes(Object sender, EventArgs e)
        {
            Renamer.RenameAsIndex(Openfiles.PicturesFilenames);
        }
    }
}
