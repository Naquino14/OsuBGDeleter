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

        private string[] pngFiles;
        private string[] jpgFiles;
        public void init(TextBox _textbox, 
            ComboBox comboBox,
            Button delButton
            )
        {
            textBox = _textbox;
            imageComboBox = comboBox;
            deleteButton = delButton;
            deleteButton.Enabled = false;


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
                if (currentImgType == imgtype.both)
                {
                    pngFiles = Directory.GetFiles(path, "*.png");
                    jpgFiles = Directory.GetFiles(path, "*.jpg");
                    sum = pngFiles.Length + jpgFiles.Length;
                }
                if (currentImgType == imgtype.png)
                {
                    pngFiles = Directory.GetFiles(path, "*.png");
                    sum = pngFiles.Length;
                }
                if (currentImgType == imgtype.jpg)
                {
                    jpgFiles = Directory.GetFiles(path, "*.jpg");
                    sum = jpgFiles.Length;
                }
                    

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to permanently delete these files? There are " + sum + " files to be deleted.", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.No)
                    return;

                Delete();

                MessageBox.Show("No more anime lolololololololololololololol", "Rekt", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Delete()
        {
            try
            {
                if (currentImgType == imgtype.both)
                {
                    foreach (string file in pngFiles)
                        File.Delete(file);
                    foreach (string file in jpgFiles)
                        File.Delete(file);
                }
                if (currentImgType == imgtype.png)
                    foreach (string file in pngFiles)
                        File.Delete(file);
                if (currentImgType == imgtype.jpg)
                    foreach (string file in jpgFiles)
                        File.Delete(file);

            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
