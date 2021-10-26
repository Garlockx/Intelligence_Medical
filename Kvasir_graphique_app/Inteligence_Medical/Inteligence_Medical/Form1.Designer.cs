namespace Inteligence_Medical
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rtbx_result = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_chooseFile = new System.Windows.Forms.Button();
            this.pb_imageToPredict = new System.Windows.Forms.PictureBox();
            this.btn_deploy = new System.Windows.Forms.Button();
            this.btn_chooseModel = new System.Windows.Forms.Button();
            this.tbx_choosenModel = new System.Windows.Forms.TextBox();
            this.ofd_fileToPredict = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tb_deploy = new System.Windows.Forms.TabPage();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.tb_train = new System.Windows.Forms.TabPage();
            this.btn_loadTrain = new System.Windows.Forms.Button();
            this.btn_saveTrain = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Train = new System.Windows.Forms.Button();
            this.rtbx_trainResult = new System.Windows.Forms.RichTextBox();
            this.tbx_SavePath = new System.Windows.Forms.TextBox();
            this.btn_SavePath = new System.Windows.Forms.Button();
            this.btn_chooseDataSetPath = new System.Windows.Forms.Button();
            this.tbx_DataSetPath = new System.Windows.Forms.TextBox();
            this.btn_trainPath = new System.Windows.Forms.Button();
            this.tbx_trainPath = new System.Windows.Forms.TextBox();
            this.ofd_modelChoosen = new System.Windows.Forms.OpenFileDialog();
            this.sfd_saveDeploy = new System.Windows.Forms.SaveFileDialog();
            this.ofd_loadSave = new System.Windows.Forms.OpenFileDialog();
            this.fbd_DatasetPath = new System.Windows.Forms.FolderBrowserDialog();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sfd_savePath = new System.Windows.Forms.SaveFileDialog();
            this.ofd_trainPath = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imageToPredict)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tb_deploy.SuspendLayout();
            this.tb_train.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbx_result
            // 
            this.rtbx_result.AccessibleDescription = "Result text";
            this.rtbx_result.AccessibleName = "rtbx_result";
            this.rtbx_result.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbx_result.Location = new System.Drawing.Point(827, 242);
            this.rtbx_result.Name = "rtbx_result";
            this.rtbx_result.ReadOnly = true;
            this.rtbx_result.Size = new System.Drawing.Size(167, 98);
            this.rtbx_result.TabIndex = 1;
            this.rtbx_result.Text = "";
            this.rtbx_result.TextChanged += new System.EventHandler(this.rtbx_result_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.90216F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.09784F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel1.Controls.Add(this.btn_chooseFile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pb_imageToPredict, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_deploy, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.rtbx_result, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_chooseModel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbx_choosenModel, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.84615F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.15385F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1031, 452);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btn_chooseFile
            // 
            this.btn_chooseFile.AccessibleName = "btn_chooseFile";
            this.btn_chooseFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_chooseFile.Location = new System.Drawing.Point(157, 53);
            this.btn_chooseFile.Name = "btn_chooseFile";
            this.btn_chooseFile.Size = new System.Drawing.Size(103, 23);
            this.btn_chooseFile.TabIndex = 2;
            this.btn_chooseFile.Text = "Choose Image";
            this.btn_chooseFile.UseVisualStyleBackColor = true;
            this.btn_chooseFile.Click += new System.EventHandler(this.btn_chooseFile_Click);
            // 
            // pb_imageToPredict
            // 
            this.pb_imageToPredict.AccessibleDescription = "Image to Predict";
            this.pb_imageToPredict.AccessibleName = "pb_imageToPredict";
            this.pb_imageToPredict.Location = new System.Drawing.Point(3, 133);
            this.pb_imageToPredict.Name = "pb_imageToPredict";
            this.pb_imageToPredict.Size = new System.Drawing.Size(389, 316);
            this.pb_imageToPredict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_imageToPredict.TabIndex = 3;
            this.pb_imageToPredict.TabStop = false;
            this.pb_imageToPredict.Click += new System.EventHandler(this.pb_imageToPredict_Click);
            // 
            // btn_deploy
            // 
            this.btn_deploy.AccessibleDescription = "Bouton de déploiement";
            this.btn_deploy.AccessibleName = "btn_deploy";
            this.btn_deploy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_deploy.Location = new System.Drawing.Point(821, 54);
            this.btn_deploy.Name = "btn_deploy";
            this.btn_deploy.Size = new System.Drawing.Size(178, 22);
            this.btn_deploy.TabIndex = 1;
            this.btn_deploy.Text = "Predict";
            this.btn_deploy.UseVisualStyleBackColor = true;
            this.btn_deploy.Click += new System.EventHandler(this.btn_deploy_Click);
            // 
            // btn_chooseModel
            // 
            this.btn_chooseModel.AccessibleName = "btn_chooseModel";
            this.btn_chooseModel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_chooseModel.Location = new System.Drawing.Point(544, 53);
            this.btn_chooseModel.Name = "btn_chooseModel";
            this.btn_chooseModel.Size = new System.Drawing.Size(119, 23);
            this.btn_chooseModel.TabIndex = 4;
            this.btn_chooseModel.Text = "Choose Model";
            this.btn_chooseModel.UseVisualStyleBackColor = true;
            this.btn_chooseModel.Click += new System.EventHandler(this.btn_chooseModel_Click);
            // 
            // tbx_choosenModel
            // 
            this.tbx_choosenModel.AccessibleName = "tbx_choosenModel";
            this.tbx_choosenModel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_choosenModel.Location = new System.Drawing.Point(439, 269);
            this.tbx_choosenModel.Multiline = true;
            this.tbx_choosenModel.Name = "tbx_choosenModel";
            this.tbx_choosenModel.ReadOnly = true;
            this.tbx_choosenModel.Size = new System.Drawing.Size(330, 43);
            this.tbx_choosenModel.TabIndex = 5;
            this.tbx_choosenModel.TextChanged += new System.EventHandler(this.tbx_choosenModel_TextChanged);
            // 
            // ofd_fileToPredict
            // 
            this.ofd_fileToPredict.FileName = "ofd_fileToPredict";
            this.ofd_fileToPredict.FileOk += new System.ComponentModel.CancelEventHandler(this.ofd_fileToPredict_FileOk);
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleDescription = "";
            this.tabControl1.AccessibleName = "";
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tb_deploy);
            this.tabControl1.Controls.Add(this.tb_train);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1051, 522);
            this.tabControl1.TabIndex = 3;
            // 
            // tb_deploy
            // 
            this.tb_deploy.AccessibleName = "tb_deploy";
            this.tb_deploy.Controls.Add(this.btn_load);
            this.tb_deploy.Controls.Add(this.btn_save);
            this.tb_deploy.Controls.Add(this.tableLayoutPanel1);
            this.tb_deploy.Location = new System.Drawing.Point(4, 22);
            this.tb_deploy.Name = "tb_deploy";
            this.tb_deploy.Padding = new System.Windows.Forms.Padding(3);
            this.tb_deploy.Size = new System.Drawing.Size(1043, 496);
            this.tb_deploy.TabIndex = 0;
            this.tb_deploy.Text = "Deploy";
            this.tb_deploy.UseVisualStyleBackColor = true;
            // 
            // btn_load
            // 
            this.btn_load.AccessibleDescription = "Bouton Chargement";
            this.btn_load.AccessibleName = "btn_load";
            this.btn_load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_load.Location = new System.Drawing.Point(860, 464);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(121, 22);
            this.btn_load.TabIndex = 4;
            this.btn_load.Text = "Charger";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_save
            // 
            this.btn_save.AccessibleDescription = "Boutton de Sauvegarde";
            this.btn_save.AccessibleName = "btn_save";
            this.btn_save.Location = new System.Drawing.Point(751, 464);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(103, 22);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Sauvegarder";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tb_train
            // 
            this.tb_train.AccessibleName = "tb_train";
            this.tb_train.Controls.Add(this.btn_loadTrain);
            this.tb_train.Controls.Add(this.btn_saveTrain);
            this.tb_train.Controls.Add(this.tableLayoutPanel2);
            this.tb_train.Location = new System.Drawing.Point(4, 22);
            this.tb_train.Name = "tb_train";
            this.tb_train.Padding = new System.Windows.Forms.Padding(3);
            this.tb_train.Size = new System.Drawing.Size(1043, 496);
            this.tb_train.TabIndex = 1;
            this.tb_train.Text = "Train";
            this.tb_train.UseVisualStyleBackColor = true;
            // 
            // btn_loadTrain
            // 
            this.btn_loadTrain.AccessibleDescription = "btn_loadTrain";
            this.btn_loadTrain.AccessibleName = "btn_loadTrain";
            this.btn_loadTrain.Location = new System.Drawing.Point(869, 457);
            this.btn_loadTrain.Name = "btn_loadTrain";
            this.btn_loadTrain.Size = new System.Drawing.Size(117, 23);
            this.btn_loadTrain.TabIndex = 2;
            this.btn_loadTrain.Text = "Charger";
            this.btn_loadTrain.UseVisualStyleBackColor = true;
            this.btn_loadTrain.Click += new System.EventHandler(this.btn_loadTrain_Click);
            // 
            // btn_saveTrain
            // 
            this.btn_saveTrain.AccessibleDescription = "btn_saveTrain";
            this.btn_saveTrain.AccessibleName = "btn_saveTrain";
            this.btn_saveTrain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_saveTrain.Location = new System.Drawing.Point(743, 457);
            this.btn_saveTrain.Name = "btn_saveTrain";
            this.btn_saveTrain.Size = new System.Drawing.Size(109, 23);
            this.btn_saveTrain.TabIndex = 1;
            this.btn_saveTrain.Text = "Savegarder";
            this.btn_saveTrain.UseVisualStyleBackColor = true;
            this.btn_saveTrain.Click += new System.EventHandler(this.btn_saveTrain_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btn_Train, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.rtbx_trainResult, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbx_SavePath, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_SavePath, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_chooseDataSetPath, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbx_DataSetPath, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_trainPath, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbx_trainPath, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1031, 445);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btn_Train
            // 
            this.btn_Train.AccessibleDescription = "btn_Train";
            this.btn_Train.AccessibleName = "btn_Train";
            this.btn_Train.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Train.Location = new System.Drawing.Point(863, 99);
            this.btn_Train.Name = "btn_Train";
            this.btn_Train.Size = new System.Drawing.Size(75, 23);
            this.btn_Train.TabIndex = 2;
            this.btn_Train.Text = "Train";
            this.btn_Train.UseVisualStyleBackColor = true;
            this.btn_Train.Click += new System.EventHandler(this.btn_Train_Click);
            // 
            // rtbx_trainResult
            // 
            this.rtbx_trainResult.AccessibleDescription = "rtbx_trainResult";
            this.rtbx_trainResult.AccessibleName = "rtbx_trainResult";
            this.rtbx_trainResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbx_trainResult.Location = new System.Drawing.Point(821, 257);
            this.rtbx_trainResult.Name = "rtbx_trainResult";
            this.rtbx_trainResult.Size = new System.Drawing.Size(159, 152);
            this.rtbx_trainResult.TabIndex = 5;
            this.rtbx_trainResult.Text = "";
            this.rtbx_trainResult.TextChanged += new System.EventHandler(this.rtbx_trainResult_TextChanged);
            // 
            // tbx_SavePath
            // 
            this.tbx_SavePath.AccessibleDescription = "tbx_SavePath";
            this.tbx_SavePath.AccessibleName = "tbx_SavePath";
            this.tbx_SavePath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_SavePath.Location = new System.Drawing.Point(528, 323);
            this.tbx_SavePath.Name = "tbx_SavePath";
            this.tbx_SavePath.Size = new System.Drawing.Size(229, 20);
            this.tbx_SavePath.TabIndex = 4;
            this.tbx_SavePath.TextChanged += new System.EventHandler(this.tbx_SavePath_TextChanged);
            // 
            // btn_SavePath
            // 
            this.btn_SavePath.AccessibleDescription = "btn_SavePath";
            this.btn_SavePath.AccessibleName = "btn_SavePath";
            this.btn_SavePath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SavePath.Location = new System.Drawing.Point(574, 99);
            this.btn_SavePath.Name = "btn_SavePath";
            this.btn_SavePath.Size = new System.Drawing.Size(137, 23);
            this.btn_SavePath.TabIndex = 1;
            this.btn_SavePath.Text = "Sauvegarde du model";
            this.btn_SavePath.UseVisualStyleBackColor = true;
            this.btn_SavePath.Click += new System.EventHandler(this.btn_SavePath_Click);
            // 
            // btn_chooseDataSetPath
            // 
            this.btn_chooseDataSetPath.AccessibleDescription = "btn_chooseDataSetPath";
            this.btn_chooseDataSetPath.AccessibleName = "btn_chooseDataSetPath";
            this.btn_chooseDataSetPath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_chooseDataSetPath.Location = new System.Drawing.Point(333, 99);
            this.btn_chooseDataSetPath.Name = "btn_chooseDataSetPath";
            this.btn_chooseDataSetPath.Size = new System.Drawing.Size(105, 23);
            this.btn_chooseDataSetPath.TabIndex = 0;
            this.btn_chooseDataSetPath.Text = "Chemin Dataset";
            this.btn_chooseDataSetPath.UseVisualStyleBackColor = true;
            this.btn_chooseDataSetPath.Click += new System.EventHandler(this.btn_chooseDataSetPath_Click);
            // 
            // tbx_DataSetPath
            // 
            this.tbx_DataSetPath.AccessibleDescription = "tbx_DataSetPath";
            this.tbx_DataSetPath.AccessibleName = "tbx_DataSetPath";
            this.tbx_DataSetPath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_DataSetPath.Location = new System.Drawing.Point(275, 323);
            this.tbx_DataSetPath.Name = "tbx_DataSetPath";
            this.tbx_DataSetPath.Size = new System.Drawing.Size(221, 20);
            this.tbx_DataSetPath.TabIndex = 3;
            this.tbx_DataSetPath.TextChanged += new System.EventHandler(this.tbx_DataSetPath_TextChanged);
            // 
            // btn_trainPath
            // 
            this.btn_trainPath.AccessibleDescription = "btn_trainPath";
            this.btn_trainPath.AccessibleName = "btn_trainPath";
            this.btn_trainPath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_trainPath.Location = new System.Drawing.Point(63, 99);
            this.btn_trainPath.Name = "btn_trainPath";
            this.btn_trainPath.Size = new System.Drawing.Size(130, 23);
            this.btn_trainPath.TabIndex = 6;
            this.btn_trainPath.Text = "Fichier entraînement";
            this.btn_trainPath.UseVisualStyleBackColor = true;
            this.btn_trainPath.Click += new System.EventHandler(this.btn_trainPath_Click);
            // 
            // tbx_trainPath
            // 
            this.tbx_trainPath.AccessibleDescription = "tbx_trainPath";
            this.tbx_trainPath.AccessibleName = "tbx_trainPath";
            this.tbx_trainPath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_trainPath.Location = new System.Drawing.Point(33, 323);
            this.tbx_trainPath.Name = "tbx_trainPath";
            this.tbx_trainPath.Size = new System.Drawing.Size(191, 20);
            this.tbx_trainPath.TabIndex = 7;
            this.tbx_trainPath.TextChanged += new System.EventHandler(this.tbx_trainPath_TextChanged);
            // 
            // ofd_modelChoosen
            // 
            this.ofd_modelChoosen.FileName = "ofd_modelChoosen";
            this.ofd_modelChoosen.FileOk += new System.ComponentModel.CancelEventHandler(this.ofd_modelChoosen_FileOk);
            // 
            // sfd_saveDeploy
            // 
            this.sfd_saveDeploy.FileName = "save_deploy";
            this.sfd_saveDeploy.Title = "Sauvegarder Deploiement";
            this.sfd_saveDeploy.FileOk += new System.ComponentModel.CancelEventHandler(this.sfd_saveDeploy_FileOk);
            // 
            // ofd_loadSave
            // 
            this.ofd_loadSave.FileName = "ofd_loadSave";
            this.ofd_loadSave.FileOk += new System.ComponentModel.CancelEventHandler(this.ofd_loadSave_FileOk);
            // 
            // fbd_DatasetPath
            // 
            this.fbd_DatasetPath.HelpRequest += new System.EventHandler(this.fbd_DatasetPath_HelpRequest);
            // 
            // sfd_savePath
            // 
            this.sfd_savePath.Title = "sfd_savePath";
            this.sfd_savePath.FileOk += new System.ComponentModel.CancelEventHandler(this.sfd_savePath_FileOk);
            // 
            // ofd_trainPath
            // 
            this.ofd_trainPath.FileName = "ofd_trainPath";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 546);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intelligence Médical";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imageToPredict)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tb_deploy.ResumeLayout(false);
            this.tb_train.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbx_result;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_deploy;
        private System.Windows.Forms.Button btn_chooseFile;
        private System.Windows.Forms.OpenFileDialog ofd_fileToPredict;
        private System.Windows.Forms.PictureBox pb_imageToPredict;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tb_deploy;
        private System.Windows.Forms.TabPage tb_train;
        private System.Windows.Forms.Button btn_chooseModel;
        private System.Windows.Forms.TextBox tbx_choosenModel;
        private System.Windows.Forms.OpenFileDialog ofd_modelChoosen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.SaveFileDialog sfd_saveDeploy;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.OpenFileDialog ofd_loadSave;
        private System.Windows.Forms.Button btn_chooseDataSetPath;
        private System.Windows.Forms.Button btn_SavePath;
        private System.Windows.Forms.Button btn_Train;
        private System.Windows.Forms.FolderBrowserDialog fbd_DatasetPath;
        private System.Windows.Forms.TextBox tbx_DataSetPath;
        private System.Windows.Forms.TextBox tbx_SavePath;
        private System.Windows.Forms.RichTextBox rtbx_trainResult;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.SaveFileDialog sfd_savePath;
        private System.Windows.Forms.Button btn_trainPath;
        private System.Windows.Forms.TextBox tbx_trainPath;
        private System.Windows.Forms.OpenFileDialog ofd_trainPath;
        private System.Windows.Forms.Button btn_saveTrain;
        private System.Windows.Forms.Button btn_loadTrain;
    }
}

