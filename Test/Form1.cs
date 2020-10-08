using System;
using System.IO;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //textBoxExcel
        private void textBoxExcel_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        private void textBoxImage_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        //textBoxDst
        private void textBoxDst_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            var profil = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = profil;
                openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|XLS files (*.xls)|*.xls";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    textBoxExcel.Text = filePath;
                }
            }
        }

        private void buttonImage_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                var profil = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                fbd.SelectedPath = profil;
                var result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    textBoxImage.Text = fbd.SelectedPath;
            }
        }

        private void buttonDst_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                var result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    textBoxDst.Text = fbd.SelectedPath;
            }
        }

        private void buttonValidation_Click(object sender, EventArgs e)
        {
            try
            {
                var ogen = new OutputGen(textBoxExcel.Text, textBoxImage.Text, textBoxDst.Text);
                ogen.run();

                const string message = "Génération des fichiers terminée";
                const string caption = "fin";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (FileNotFoundException err)
            {
                const string message = "fichier non trouvé";
                const string caption = "Erreur";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException err)
            {
                const string message = "fichier non trouvé";
                const string caption = "Erreur";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException err)
            {
                const string message = "Fichier Excel encore ouvert, veuillez fermer le fichier.";
                const string caption = "Erreur";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioBRef_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioBNumero_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}