using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IndexRenamer
{
    public static class Renamer
    {
        public static void RenameAsIndex(List<string> filenames)
        {
            int i =0;
            foreach(string file in filenames)
            {
                string workingfile = file;
                if (!File.Exists(workingfile)) continue;
                string newfilename = RenamePath(workingfile, i.ToString());
                //filenames[i] = newfilename;
                File.Move(workingfile, newfilename);
                i++;
            }
        }

        public static string RenamePath(string file, string newname)
        {
            string path = Path.GetDirectoryName(file);
            string extension = Path.GetExtension(file);
            string newfilepath =
                Path.GetDirectoryName(file) +
                Path.DirectorySeparatorChar +
                newname +
                extension;
            return newfilepath;
        }
    }
}
