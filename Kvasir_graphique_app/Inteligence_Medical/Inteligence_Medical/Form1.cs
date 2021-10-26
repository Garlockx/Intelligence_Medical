using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Inteligence_Medical
{
    public partial class Form1 : Form
    {
        public string fileToPredict;
        public string modelChoosen;
        public string trainFilePath;
        public string dataSetPath;
        public string savePath;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_deploy_Click(object sender, EventArgs e)
        {
            if(fileToPredict != null && modelChoosen != null)
            {
                //string fileName = @"C:\workspace\deep_learning\Kvasir_app\deploy.py";
                string currentDir = Environment.CurrentDirectory;
                DirectoryInfo fileDirectory = new DirectoryInfo(Path.GetFullPath(Path.Combine(currentDir, @"..\deploy.py")));
                string fileName = fileDirectory.ToString();
                string[] args = new string[2] {
                    fileToPredict,
                    modelChoosen
                };
                string result = run_cmd(fileName, args);
                rtbx_result.Text = result;
            } else
            {
                MessageBox.Show("Vous devez choisir une image et un model", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Train_Click(object sender, EventArgs e)
        {
            if (dataSetPath != null && savePath != null && trainFilePath != null)
            {
                string fileName = trainFilePath;
                string[] args = new string[2]
                {
                    dataSetPath,
                    savePath
                };
                string result = run_cmd(fileName, args);
                rtbx_trainResult.Text = result;
            }
            else
            {
                MessageBox.Show("Vous devez choisir un fichier d'entraînement, un dataset et un chemin de sauvegarde", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string run_cmd(string fileName, string[] args)
        {
            string currentDir = Environment.CurrentDirectory;
            DirectoryInfo envDirectory = new DirectoryInfo(Path.GetFullPath(Path.Combine(currentDir, @"..\python_environment\python.exe")));
            string envPath = envDirectory.ToString();

            Process process = new Process();
            process.StartInfo = new ProcessStartInfo(envPath, fileName)
            {
                Arguments = string.Format("{0} {1} {2}", fileName, args[0], args[1]),
                RedirectStandardOutput = true,
                RedirectStandardInput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
            };
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            return output;
        }

        private void btn_chooseFile_Click(object sender, EventArgs e)
        {
            if(ofd_fileToPredict.ShowDialog() == DialogResult.OK)
            {
                fileToPredict = ofd_fileToPredict.FileName;
                pb_imageToPredict.Image = new Bitmap(ofd_fileToPredict.FileName);
            }
        }


        private void btn_trainPath_Click(object sender, EventArgs e)
        {
            if (ofd_trainPath.ShowDialog() == DialogResult.OK)
            {
                trainFilePath = ofd_trainPath.FileName;
                tbx_trainPath.Text = ofd_trainPath.FileName;
            }
        }

        private void btn_chooseModel_Click(object sender, EventArgs e)
        {
            ofd_modelChoosen.Filter = "Fichier h5 (*.h5)|*.h5|All files (*.*)|*.*";
            if (ofd_modelChoosen.ShowDialog() == DialogResult.OK)
            {
                modelChoosen = ofd_modelChoosen.FileName;
                string modelChoosenFileName = ofd_modelChoosen.SafeFileName;
                tbx_choosenModel.Text = modelChoosenFileName;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            sfd_saveDeploy.RestoreDirectory = true;
            string currentDir = Environment.CurrentDirectory;
            DirectoryInfo fileDirectory = new DirectoryInfo(Path.GetFullPath(Path.Combine(currentDir, @"..\save\")));
            sfd_saveDeploy.InitialDirectory = fileDirectory.ToString();
            sfd_saveDeploy.Filter = "Text Files (*.txt)|*.txt";
            sfd_saveDeploy.DefaultExt = "txt";
            sfd_saveDeploy.AddExtension = true;

            if (fileToPredict != null && modelChoosen != null)
            {
                if (sfd_saveDeploy.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder txtContent = new StringBuilder();
                    txtContent.AppendLine(fileToPredict + "," + modelChoosen);
                    string txtPath = sfd_saveDeploy.FileName;
                    File.WriteAllText(txtPath, txtContent.ToString());
                }
            }
            else
            {
                MessageBox.Show("Vous devez choisir une image et un model", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            ofd_loadSave.RestoreDirectory = true;
            string currentDir = Environment.CurrentDirectory;
            DirectoryInfo fileDirectory = new DirectoryInfo(Path.GetFullPath(Path.Combine(currentDir, @"..\save\")));
            ofd_loadSave.InitialDirectory = fileDirectory.ToString();
            ofd_loadSave.Filter = "Text Files (*.txt)|*.txt";
            if (ofd_loadSave.ShowDialog() == DialogResult.OK)
            {
                string saveChoosen = ofd_loadSave.FileName;
                string saveContent = File.ReadAllText(saveChoosen);
                string[] saveArgument = saveContent.Split(',');

                fileToPredict = Path.GetFullPath(saveArgument[0]);
                modelChoosen = Path.GetFullPath(saveArgument[1]);

                pb_imageToPredict.Image = new Bitmap(fileToPredict);
                tbx_choosenModel.Text = modelChoosen;
            }
        }


        private void btn_saveTrain_Click(object sender, EventArgs e)
        {
            sfd_saveDeploy.RestoreDirectory = true;
            string currentDir = Environment.CurrentDirectory;
            DirectoryInfo fileDirectory = new DirectoryInfo(Path.GetFullPath(Path.Combine(currentDir, @"..\save\")));
            sfd_saveDeploy.InitialDirectory = fileDirectory.ToString();
            sfd_saveDeploy.Filter = "Text Files (*.txt)|*.txt";
            sfd_saveDeploy.DefaultExt = "txt";
            sfd_saveDeploy.AddExtension = true;

            if (dataSetPath != null && trainFilePath != null)
            {
                if (sfd_saveDeploy.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder txtContent = new StringBuilder();
                    txtContent.AppendLine(dataSetPath + "," + trainFilePath);
                    string txtPath = sfd_saveDeploy.FileName;
                    File.WriteAllText(txtPath, txtContent.ToString());
                }
            }
            else
            {
                MessageBox.Show("Vous devez choisir un dataset et fichier d'entraînement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_loadTrain_Click(object sender, EventArgs e)
        {
            ofd_loadSave.RestoreDirectory = true;
            string currentDir = Environment.CurrentDirectory;
            DirectoryInfo fileDirectory = new DirectoryInfo(Path.GetFullPath(Path.Combine(currentDir, @"..\save\")));
            ofd_loadSave.InitialDirectory = fileDirectory.ToString();
            ofd_loadSave.Filter = "Text Files (*.txt)|*.txt";
            if (ofd_loadSave.ShowDialog() == DialogResult.OK)
            {
                string saveChoosen = ofd_loadSave.FileName;
                string saveContent = File.ReadAllText(saveChoosen);
                string[] saveArgument = saveContent.Split(',');

                dataSetPath = Path.GetFullPath(saveArgument[0]);
                trainFilePath = Path.GetFullPath(saveArgument[1]);

                tbx_DataSetPath.Text = dataSetPath;
                tbx_trainPath.Text = trainFilePath;
            }
        }

        private void btn_chooseDataSetPath_Click(object sender, EventArgs e)
        {
            if (fbd_DatasetPath.ShowDialog() == DialogResult.OK)
            {
                dataSetPath = fbd_DatasetPath.SelectedPath;
                tbx_DataSetPath.Text = fbd_DatasetPath.SelectedPath;
            }
        }


        private void btn_SavePath_Click(object sender, EventArgs e)
        {
            sfd_savePath.RestoreDirectory = true;
            string currentDir = Environment.CurrentDirectory;
            DirectoryInfo fileDirectory = new DirectoryInfo(Path.GetFullPath(Path.Combine(currentDir, @"..\model\")));
            sfd_savePath.InitialDirectory = fileDirectory.ToString();
            sfd_savePath.Filter = "Text Files (*.h5)|*.h5";
            sfd_savePath.DefaultExt = "h5";
            if (sfd_savePath.ShowDialog() == DialogResult.OK)
            {
                savePath = sfd_savePath.FileName;
                tbx_SavePath.Text = sfd_savePath.FileName;
            }
        }

        private void writeLog(string stringToLog)
        {
            StringBuilder txtContent = new StringBuilder();
            txtContent.AppendLine(fileToPredict + "," + modelChoosen);
            string txtPath = @"..\..\..\..\..\log\log.txt";
            File.AppendAllText(txtPath, "\n" + stringToLog.ToString());
        }

        private void ofd_fileToPredict_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void pb_imageToPredict_Click(object sender, EventArgs e)
        {

        }

        private void ofd_modelChoosen_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void tbx_choosenModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbx_result_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbx_result_TextChanged(object sender, EventArgs e)
        {

        }

        private void sfd_saveDeploy_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void ofd_loadSave_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void fbd_DatasetPath_HelpRequest(object sender, EventArgs e)
        {

        }

        private void fbd_SavePath_HelpRequest(object sender, EventArgs e)
        {

        }

        private void tbx_DataSetPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_SavePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbx_trainResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void sfd_savePath_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void tbx_trainPath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
