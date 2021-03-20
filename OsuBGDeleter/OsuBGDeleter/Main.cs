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
            InitializeComponent();
            dirTextbox.ReadOnly = true;
            fb.init(dirTextbox,
                comboBox1,
                deleteButton
                );
        }

        private void selectDir_Click(object sender, EventArgs e) => fb.SelectDirOnClick();
        private void deleteButton_Click(object sender, EventArgs e) => fb.DeleteOnClick();

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // unused
        }
        private void buttonSaveImgType_Click(object sender, EventArgs e) => fb.ImageTypeOnChange();
    }
}
