using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace OsuBGDeleter
{
    public class FormBacker
    {
        public enum imgtype
        {
            both,
            png,
            jpg
        }
        private imgtype currentImgType;

        private FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        private string path;

        private TextBox textBox;
        private ComboBox imageComboBox;
        private Button deleteButton;
        private CheckBox ignoreSBcheckbox;

        private string[] pngFiles;
        private string[] jpgFiles;

        private bool includeMapSkins = false;

        public void init(TextBox _textbox, 
            ComboBox comboBox,
            Button delButton,
            CheckBox ignoreSB
            )
        {
            textBox = _textbox;
            imageComboBox = comboBox;
            deleteButton = delButton;
            deleteButton.Enabled = false;
            ignoreSBcheckbox = ignoreSB;

            int qInd = 0;
            switch (settings.Default.imgtype)
            {
                case 0:
                    currentImgType = imgtype.both;
                    qInd = 0;
                    break;
                case 1:
                    currentImgType = imgtype.png;
                    qInd = 1;
                    break;
                case 2:
                    currentImgType = imgtype.jpg;
                    qInd = 2;
                    break;
            }
            imageComboBox.SelectedIndex = qInd;
        }
        public void SelectDirOnClick()
        {
            try
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    path = folderBrowserDialog.SelectedPath;

                textBox.Text = path;
                deleteButton.Enabled = true;
            } catch (Exception ex){
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteOnClick()
        {
            try
            {
                int sum = 0;
                (string[] files, int sum) pngResult;
                (string[] files, int sum) jpgResult;

                pngFiles = Directory.GetFiles(path, "*.png", SearchOption.AllDirectories);
                jpgFiles = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories);

                if (!includeMapSkins)
                {
                    pngResult = DeleteSb(pngFiles);
                    jpgResult = DeleteSb(jpgFiles);
                    pngFiles = pngResult.files;
                    jpgFiles = jpgResult.files;
                    sum = pngResult.sum + jpgResult.sum;
                }
                if (includeMapSkins)
                {
                    if (currentImgType == imgtype.both)
                        sum = pngFiles.Length + jpgFiles.Length;
                    if (currentImgType == imgtype.png)
                        sum = pngFiles.Length;
                    if (currentImgType == imgtype.jpg)
                        sum = jpgFiles.Length;
                }

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to permanently delete these files? There are " + sum + " files to be deleted.", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.No)
                    return;
                
                if (currentImgType == imgtype.both)
                {
                    Delete(pngFiles);
                    Delete(jpgFiles);
                }
                if (currentImgType == imgtype.png)
                    Delete(pngFiles);
                if (currentImgType == imgtype.jpg)
                    Delete(jpgFiles);

                MessageBox.Show("Images successfully deleted.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ImageTypeOnChange()
        {
            int qInd = 0;
            switch (imageComboBox.SelectedIndex)
            {
                case 0:
                    currentImgType = imgtype.both;
                    qInd = 0;
                    break;
                case 1:
                    currentImgType = imgtype.png;
                    qInd = 1;
                    break;
                case 2:
                    currentImgType = imgtype.jpg;
                    qInd = 2;
                    break;
            }
            settings.Default.imgtype = qInd;
        }

        public void SBFolderOnUpdate()
        {
            if (!ignoreSBcheckbox.Checked)
                includeMapSkins = false;
            if (ignoreSBcheckbox.Checked)
                includeMapSkins = true;
        }

        private (string[] result, int sum) DeleteSb(String[] input)
        {
            string[] result = new string[input.Length];
            int index = 0;
            int sum = 0;
            foreach (string file in input)
            {
                if (file.Contains("\\sb\\") || file.Contains("\\SB\\"))
                    result[index] = "nul";
                else
                {
                    result[index] = input[index];
                    sum++;
                }
                index++;
            }
            return (result, sum);
        }

        private void Delete(String[] input)
        {
            try
            {
                foreach (string file in input)
                    if (!file.Contains("nul"))
                        File.Delete(file);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
