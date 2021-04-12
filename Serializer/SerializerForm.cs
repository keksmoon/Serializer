using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Text.Json;
using System.Threading;

namespace Serializer {
    public partial class serializerForm : Form {
        public bool ThreadJob = false;
        public serializerForm() => InitializeComponent();
        
        #region Output of Folder Information on the Form
        public static int fCnt = 0; //Количество файлов
        public static int folCnt = 1; //Количество папок
        public void WriteDirectoryDescription(DirectoryDescription directory, string tab) {
            infoDirectoryTextBox.Items.Add(tab + "Name of directory: " + directory.Name);
            infoDirectoryTextBox.Items.Add(tab + "Volume of directory: " + directory.Volume);
            infoDirectoryTextBox.Items.Add(tab + "Last write time folder: " + directory.LastWriteTime.ToString());
            infoDirectoryTextBox.Items.Add(tab + "Attributes: " + directory.Attributes);
            if (directory.Files.Count() != 0) {
                infoDirectoryTextBox.Items.Add(tab + "Files: ");
                foreach (var file in directory.Files) {
                    infoDirectoryTextBox.Items.Add(tab + "====================================================");
                    infoDirectoryTextBox.Items.Add(tab + "Name of file: " + file.Name);
                    infoDirectoryTextBox.Items.Add(tab + "Volume of file: " + file.Volume);
                    infoDirectoryTextBox.Items.Add(tab + "Hashcode of file-data: " + file.Data);
                    infoDirectoryTextBox.Items.Add(tab + "Attributes: " + file.Attributes);
                    infoDirectoryTextBox.Items.Add(tab + "Last write time file: " + file.LastWriteTime.ToString());
                    fCnt++;
                }
            }
            if (directory.SubFolders.Count() != 0) {
                infoDirectoryTextBox.Items.Add(tab + "Subfolders: ");
                foreach (var subfolder in directory.SubFolders) {
                    WriteDirectoryDescription(subfolder, tab + "\t");
                    folCnt++;
                }
            }
        }
        #endregion

        #region Save as binary
        private void serializeToolStripMenuItem_Click(object sender, EventArgs e) {
            if (ThreadJob) {
                MessageBox.Show("Wait for the serialization process to complete!");
                return;
            }
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK) {
                string pathToFolder = folderBrowserDialog.SelectedPath;

                SerializeThread getFileStructure = new SerializeThread(pathToFolder, AddToProgress, EndOfThread);
                progress.Maximum = getFileStructure.cntFiles;
                Thread thread = new Thread(new ThreadStart(getFileStructure.StartProcessBinary));
                thread.Start();
                ThreadJob = true;
            }
        }
      
        #endregion 

        #region Load from binary
        private void deserializeToolStripMenuItem_Click(object sender, EventArgs e) {
            infoDirectoryTextBox.Items.Clear();
            cntFilesInfo.Text = "0";
            cntFoldersInfo.Text = "0";

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Binary files(*.bin)|*.bin";

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                try {
                    var directoryDescription = LoadFromBinaryFile(openFileDialog.FileName);
                    WriteDirectoryDescription(directoryDescription, "");
                    cntFilesInfo.Text = fCnt.ToString(); fCnt = 0;
                    cntFoldersInfo.Text = folCnt.ToString(); folCnt = 0;
                }
                catch (Exception) {
                    MessageBox.Show("Error! Attempt to upload an invalid binary file.");
                    infoDirectoryTextBox.Text = "Invalid binary file.";
                }
            }
        }
        static DirectoryDescription LoadFromBinaryFile(string fileName) {
            BinaryFormatter binFormat = new BinaryFormatter();

            using (Stream fStream = File.OpenRead(fileName)) {
                DirectoryDescription directoryDescriptionFromDisk =
                  (DirectoryDescription)binFormat.Deserialize(fStream);
                return directoryDescriptionFromDisk;
            }
        }
        #endregion

        #region Save as XML
        private void serializeToolStripMenuItem1_Click(object sender, EventArgs e) {
            if (ThreadJob) {
                MessageBox.Show("Wait for the serialization process to complete!");
                return;
            }
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK) {
                string pathToFolder = folderBrowserDialog.SelectedPath;

                SerializeThread getFileStructure = new SerializeThread(pathToFolder, AddToProgress, EndOfThread);
                progress.Maximum = getFileStructure.cntFiles;
                Thread thread = new Thread(new ThreadStart(getFileStructure.StartProcessXML));
                thread.Start();
                ThreadJob = true;
            }
        }
        #endregion

        #region Load from XML
        private void deserializeToolStripMenuItem1_Click(object sender, EventArgs e) {
            infoDirectoryTextBox.Items.Clear();
            cntFilesInfo.Text = "0";
            cntFoldersInfo.Text = "0";

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML files(*.xml)|*.xml";

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                try {
                    var directoryDescription = LoadFromXMLFile(openFileDialog.FileName);
                    WriteDirectoryDescription(directoryDescription, "");
                    cntFilesInfo.Text = fCnt.ToString(); fCnt = 0;
                    cntFoldersInfo.Text = folCnt.ToString(); folCnt = 0;
                }
                catch (Exception) {
                    MessageBox.Show("Error! Attempt to upload an invalid XML file.");
                    infoDirectoryTextBox.Text = "Invalid XML file.";
                }
            }
        }
        static DirectoryDescription LoadFromXMLFile(string fileName) {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(DirectoryDescription));

            using (Stream fStream = File.OpenRead(fileName)) {
                DirectoryDescription directoryDescriptionFromDisk =
                      (DirectoryDescription)xmlFormat.Deserialize(fStream);
                return directoryDescriptionFromDisk;
            }
        }
        #endregion

        #region Save as JSON
        private void serializeToolStripMenuItem2_Click(object sender, EventArgs e) {
            if (ThreadJob) {
                MessageBox.Show("Wait for the serialization process to complete!");
                return;
            }
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK) {
                string pathToFolder = folderBrowserDialog.SelectedPath;

                SerializeThread getFileStructure = new SerializeThread(pathToFolder, AddToProgress, EndOfThread);
                progress.Maximum = getFileStructure.cntFiles;
                Thread thread = new Thread(new ThreadStart(getFileStructure.StartProcessJson));
                thread.Start();
                ThreadJob = true;
            }
        }
        #endregion

        #region Load from JSON
        private void deserializeToolStripMenuItem2_Click(object sender, EventArgs e) {
            infoDirectoryTextBox.Items.Clear();
            cntFilesInfo.Text = "0";
            cntFoldersInfo.Text = "0";

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files(*.json)|*.json";

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                try {
                    var directoryDescription = LoadFromJson(openFileDialog.FileName);
                    WriteDirectoryDescription(directoryDescription, "");
                    cntFilesInfo.Text = fCnt.ToString(); fCnt = 0;
                    cntFoldersInfo.Text = folCnt.ToString(); folCnt = 0;
                }
                catch (Exception) {
                    MessageBox.Show("Error! Attempt to upload an invalid JSON file.");
                    infoDirectoryTextBox.Text = "Invalid JSON file.";
                }
            }
        }
        static DirectoryDescription LoadFromJson(string fileName) {
            using (StreamReader fStream = new StreamReader(fileName)) {
                DirectoryDescription restoredDirectoryDescription = JsonSerializer.Deserialize<DirectoryDescription>(fStream.ReadToEnd());
                return restoredDirectoryDescription;
            }
        }
        #endregion

        #region Format text
        private void fontToolStripMenuItem_Click(object sender, EventArgs e) {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = infoDirectoryTextBox.Font;

            if (fontDialog.ShowDialog() == DialogResult.OK) {
                infoDirectoryTextBox.Font = fontDialog.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e) {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = infoDirectoryTextBox.BackColor;

            if (colorDialog.ShowDialog() == DialogResult.OK) {
                infoDirectoryTextBox.BackColor = colorDialog.Color;
            }
        }

        private void textColorToolStripMenuItem_Click(object sender, EventArgs e) {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = infoDirectoryTextBox.ForeColor;

            if (colorDialog.ShowDialog() == DialogResult.OK) {
                infoDirectoryTextBox.ForeColor = colorDialog.Color;
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e) {
            infoDirectoryTextBox.Items.Clear();
            cntFilesInfo.Text = "0";
            cntFoldersInfo.Text = "0";
        }
        #endregion

        public void AddToProgress() {
            if (InvokeRequired) {
                Invoke((Action)AddToProgress);
            }
            else {
                progress.Value++;
            }

        }

        public void EndOfThread() {
            if (InvokeRequired) {
                Invoke((Action)EndOfThread);
            }
            else {
                ThreadJob = false;
                progress.Value = 0;
            }
        }
    }

    public class SerializeThread {
        string path;
        Action AddToProgress;
        Action EndOfThread;
        public int cntFiles { get; private set; }
        public SerializeThread(string path, Action AddToProgress, Action EndOfThread) {
            this.path = path;
            var dirInfo = new DirectoryInfo(path);
            cntFiles = dirInfo.GetFiles("*", SearchOption.AllDirectories).Count();
            
            this.AddToProgress = AddToProgress;
            this.EndOfThread = EndOfThread;
        }
        
        #region Serilize Methods
        public void StartProcessBinary() {
            MessageBox.Show("Binary serialization started!");
            var dirDescriprions = GetDirectory();

            BinaryFormatter binFormat = new BinaryFormatter();

            string nameFile = $"data/result-{dirDescriprions.Name}-{DateTime.Now.Day}-{DateTime.Now.Month}-{DateTime.Now.Year}-{DateTime.Now.Hour}-{DateTime.Now.Minute}-{DateTime.Now.Millisecond}.bin";
            using (Stream fStream = new FileStream(nameFile,
                  FileMode.Create, FileAccess.Write, FileShare.None)) {
                binFormat.Serialize(fStream, dirDescriprions);
            }

            MessageBox.Show($"Folder \"{dirDescriprions.Name}\" is serialized!");
            EndOfThread();
        }
        public void StartProcessXML() {
            MessageBox.Show("XML serialization started!");
            var dirDescriprions = GetDirectory();

            XmlSerializer xmlFormat = new XmlSerializer(typeof(DirectoryDescription));

            string nameFile = $"data/result-{dirDescriprions.Name}-{DateTime.Now.Day}-{DateTime.Now.Month}-{DateTime.Now.Year}-{DateTime.Now.Hour}-{DateTime.Now.Minute}-{DateTime.Now.Millisecond}.xml";
            using (Stream fStream = new FileStream(nameFile,
              FileMode.Create, FileAccess.Write, FileShare.None)) {
                xmlFormat.Serialize(fStream, dirDescriprions);
            }

            MessageBox.Show($"Folder \"{dirDescriprions.Name}\" is serialized!");
            EndOfThread();
        }
        public void StartProcessJson() {
            MessageBox.Show("JSON serialization started!");
            var dirDescriprions = GetDirectory();

            string nameFile = $"data/result-{dirDescriprions.Name}-{DateTime.Now.Day}-{DateTime.Now.Month}-{DateTime.Now.Year}-{DateTime.Now.Hour}-{DateTime.Now.Minute}-{DateTime.Now.Millisecond}.json";
            using (StreamWriter fStream = new StreamWriter(nameFile)) {
                string json = JsonSerializer.Serialize(dirDescriprions);
                fStream.Write(json);
            }

            MessageBox.Show($"Folder \"{dirDescriprions.Name}\" is serialized!");
            EndOfThread();
        }
        #endregion

        #region Get Directories Methods
        // GetDirectory возвращает объект DirectoryDescription, который описывает
        // всю структуру каталога, его подпапок и файлов, и который сохраняется при сериализации
        // Этот метод необходим для получения описания корневого каталога и начала сканирования всех подкаталогов
        // и их структуры
        public DirectoryDescription GetDirectory() {
            var dirInfo = new DirectoryInfo(path);
            return new DirectoryDescription {
                Name = dirInfo.Name,
                LastWriteTime = dirInfo.LastWriteTime,
                SubFolders = GetDirectoryDescriptions(path).ToList(),
                Files = GetFileDescriptions(path).ToList(),
                Volume = dirInfo.EnumerateFiles("*", SearchOption.AllDirectories).Sum(file => file.Length),
                Attributes = dirInfo.Attributes,
            };
        }
        // GetDirectoryDescriptions возвращает набор описаний вложенных в корневую папку подкаталогов DirectoryDescription
        // которые так же описываются за счет рекурсивного вызова этого метода
        public IEnumerable<DirectoryDescription> GetDirectoryDescriptions(string path) {
            foreach (var dir in Directory.GetDirectories(path)) {
                var dirInfo = new DirectoryInfo(dir);
                var directory = new DirectoryDescription {
                    Name = dirInfo.Name,
                    LastWriteTime = dirInfo.LastWriteTime,
                    SubFolders = GetDirectoryDescriptions(dir).ToList(),
                    Files = GetFileDescriptions(dir).ToList(),
                    Volume = dirInfo.EnumerateFiles("*", SearchOption.AllDirectories).Sum(file => file.Length),
                    Attributes = dirInfo.Attributes,
                };
                yield return directory;
            }
        }
        // GetFileDescriptions возвращает набор описаний вложенных в каталог файлов 
        public IEnumerable<FileDescription> GetFileDescriptions(string path) {
            foreach (var file in Directory.GetFiles(path)) {
                AddToProgress();
                var fileInfo = new FileInfo(file);
                var fileDescription = new FileDescription {
                    Data = File.ReadAllBytes(file).GetHashCode(),
                    Name = fileInfo.Name,
                    LastWriteTime = fileInfo.LastWriteTime,
                    Volume = fileInfo.Length,
                    Attributes = fileInfo.Attributes,
                };
                yield return fileDescription;
            }
        }
        #endregion
    }

}
