using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OsuBGDeleter
{
    public partial class OsuBgDeleterMain : Form
    {
        FormBacker fb = new FormBacker();

        public OsuBgDeleterMain()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            dirTextbox.ReadOnly = true;
            fb.init(dirTextbox,
                comboBox1,
                deleteButton,
                checkboxSBFolders
                );
        }

        private void selectDir_Click(object sender, EventArgs e) => fb.SelectDirOnClick();
        private void deleteButton_Click(object sender, EventArgs e) => fb.DeleteOnClick();
        private void buttonSaveImgType_Click(object sender, EventArgs e) => fb.ImageTypeOnChange();
        private void checkboxSBFolders_CheckedChanged(object sender, EventArgs e) => fb.SBFolderOnUpdate();
    }
}
