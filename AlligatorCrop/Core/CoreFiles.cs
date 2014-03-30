using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlligatorCrop.Core
{
    public static class CoreFiles
    {
        public static string[] OpenFiles()
        {
            OpenFileDialog fileSearch = new OpenFileDialog();

            fileSearch.Multiselect = true;

            fileSearch.ShowDialog();

            return fileSearch.SafeFileNames;
        }
    }
}
