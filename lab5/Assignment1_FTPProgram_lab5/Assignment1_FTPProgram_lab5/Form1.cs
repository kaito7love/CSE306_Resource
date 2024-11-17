using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1_FTPProgram_lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //get a list of the drives
            string[] drives = Environment.GetLogicalDrives();

            foreach (string drive in drives)
            {
                DriveInfo di = new DriveInfo(drive);
                int driveImage;

                switch (di.DriveType)    //set the drive's icon
                {
                    case DriveType.CDRom:
                        driveImage = 3;
                        break;
                    case DriveType.Network:
                        driveImage = 6;
                        break;
                    case DriveType.NoRootDirectory:
                        driveImage = 8;
                        break;
                    case DriveType.Unknown:
                        driveImage = 8;
                        break;
                    default:
                        driveImage = 2;
                        break;
                }

                TreeNode node = new TreeNode(drive.Substring(0, 1), driveImage, driveImage);
                node.Tag = drive;

                if (di.IsReady == true)
                    node.Nodes.Add("...");

                treeView.Nodes.Add(node);
            }

        }

        private void treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count > 0)
            {
                if (e.Node.Nodes[0].Text == "..." && e.Node.Nodes[0].Tag == null)
                {
                    e.Node.Nodes.Clear();

                    //get the list of sub direcotires
                    string[] dirs = Directory.GetDirectories(e.Node.Tag.ToString());

                    foreach (string dir in dirs)
                    {
                        DirectoryInfo di = new DirectoryInfo(dir);
                        TreeNode node = new TreeNode(di.Name, 0, 1);

                        try
                        {
                            //keep the directory's full path in the tag for use later
                            node.Tag = dir;

                            //if the directory has sub directories add the place holder
                            if (di.GetDirectories().Count() > 0)
                                node.Nodes.Add(null, "...", 0, 0);
                        }
                        catch (UnauthorizedAccessException)
                        {
                            //display a locked folder icon
                            node.ImageIndex = 12;
                            node.SelectedImageIndex = 12;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "DirectoryLister",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            e.Node.Nodes.Add(node);
                        }
                    }
                }
            }
        }

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            listBoxFiles.Items.Clear();
            listBoxFolders.Items.Clear();
            txtPathClient.Text = e.Node.Tag.ToString();
            try
            {
                string[] fileEntries = Directory.GetFiles(e.Node.Tag.ToString());

                foreach (string fileName in fileEntries)
                {
                    int _temp = listBoxFiles.Items.Add(Path.GetFileName(fileName));
                }
                fileEntries = Directory.GetDirectories(e.Node.Tag.ToString());
                foreach (string fileName in fileEntries)
                    listBoxFolders.Items.Add(Path.GetFileName(fileName));
            }
            catch { }
        }

        private void listBoxFolders_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string s = listBoxFolders.SelectedItem.ToString();
            if (listBoxFolders.Items.Count > 0)
            {
                string _path = txtPathClient.Text + "\\" + listBoxFolders.SelectedItem.ToString();
                try
                {
                    listBoxFiles.Items.Clear();
                    listBoxFolders.Items.Clear();
                    string[] fileEntries = Directory.GetFiles(_path);

                    foreach (string fileName in fileEntries)
                        listBoxFiles.Items.Add(Path.GetFileName(fileName));

                    fileEntries = Directory.GetDirectories(_path);
                    foreach (string fileName in fileEntries)
                        listBoxFolders.Items.Add(Path.GetFileName(fileName));
                }
                catch { }
                txtPathClient.Text = _path;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            GetFilesAndFolder(txtServer.Text, txtUsername.Text, txtPassword.Text, txtPort.Text, "/");
        }

        private void lbFolders_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string path = txtPath.Text + lbFolders.SelectedItem.ToString() + "/";
            lbFiles.Items.Clear();
            GetFilesAndFolder(txtServer.Text, txtUsername.Text, txtPassword.Text, txtPort.Text, path);
        }
        private void GetFilesAndFolder(string _server, string _user, string _pass, string _port, string _path)
        {
            string path = _server + ":" + _port + _path;
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(path);
            NetworkCredential credential = new NetworkCredential(_user, _pass);
            request.Credentials = credential;
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string data = reader.ReadToEnd();
            txtStatus.Text = response.StatusDescription;
            reader.Close();
            response.Close();

            string[] dataArr = data.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            lbFolders.Items.Clear();
            lbFiles.Items.Clear();
            foreach (var item in dataArr)
            {
                if (!string.IsNullOrEmpty(item))
                    if (item.Contains("<DIR>"))
                    {
                        lbFolders.Items.Add(item.Substring(39));
                    }
                    else
                    {
                        lbFiles.Items.Add(item.Substring(39));
                    }
            }
            txtPath.Text = _path;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            string path = txtPath.Text.TrimEnd('/');
            int index = path.LastIndexOf("/");
            if (index > 0)
            {
                path = path.Substring(0, index) + "/";
            }
            else
            {
                path = "/";
            }
            GetFilesAndFolder(txtServer.Text, txtUsername.Text, txtPassword.Text, txtPort.Text, path);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedItem != null)
            {
                string filePath = txtPathClient.Text + @"\" + listBoxFiles.SelectedItem.ToString();
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(txtServer.Text + ":" + txtPort.Text + txtPath.Text + "/" + listBoxFiles.SelectedItem.ToString());
                NetworkCredential credential = new NetworkCredential(txtUsername.Text, txtPassword.Text);
                request.Credentials = credential;
                request.Method = WebRequestMethods.Ftp.UploadFile;
                byte[] data = File.ReadAllBytes(filePath);
                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                    stream.Close();
                }
                GetFilesAndFolder(txtServer.Text, txtUsername.Text, txtPassword.Text, txtPort.Text, txtPath.Text);
                MessageBox.Show("Uploaded");
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (lbFiles.SelectedItem != null)
            {
                string path = txtPath.Text + lbFiles.SelectedItem.ToString();
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(txtServer.Text + ":" + txtPort.Text + path);
                NetworkCredential credential = new NetworkCredential(txtUsername.Text, txtPassword.Text);
                request.Credentials = credential;
                request.UseBinary = true;
                request.UsePassive = true;
                request.KeepAlive = true;

                request.Method = WebRequestMethods.Ftp.DownloadFile;

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader sr = new StreamReader(stream);
                string clientFilePath = txtPathClient.Text + @"\" + lbFiles.SelectedItem.ToString();
                FileStream fs = new FileStream(clientFilePath, FileMode.Create);
                byte[] buffer = new byte[1024];
                int byteRead;
                while ((byteRead = stream.Read(buffer, 0, 1024)) > 0)
                {
                    fs.Write(buffer, 0, byteRead);
                }
                fs.Close();
                stream.Close();
                listBoxFiles.Items.Clear();
                string[] localFiles = Directory.GetFiles(txtPathClient.Text);
                foreach (var item in localFiles)
                {
                    listBoxFiles.Items.Add(Path.GetFileName(item));
                }
                MessageBox.Show("Downloaded");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbFiles.SelectedItem != null)
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(txtServer.Text + ":" + txtPort.Text + txtPath.Text + "/" + lbFiles.SelectedItem.ToString());
                NetworkCredential credential = new NetworkCredential(txtUsername.Text, txtPassword.Text);
                request.Credentials = credential;
                request.Method = WebRequestMethods.Ftp.DeleteFile;
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    MessageBox.Show("Deleted");
                }
                GetFilesAndFolder(txtServer.Text, txtUsername.Text, txtPassword.Text, txtPort.Text, txtPath.Text);
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            if (lbFiles.SelectedItem != null)
            {
                Rename rf = new Rename(lbFiles.SelectedItem.ToString());
                var result = rf.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var newName = rf.ReturnValue;
                    if (!newName.Equals(lbFiles.SelectedItem.ToString()))
                    {
                        string path = txtPath.Text + lbFiles.SelectedItem.ToString();
                        FtpWebRequest request = (FtpWebRequest)WebRequest.Create(txtServer.Text + ":" + txtPort.Text + path);
                        NetworkCredential credential = new NetworkCredential(txtUsername.Text, txtPassword.Text);
                        request.Credentials = credential;
                        request.Method = WebRequestMethods.Ftp.Rename;
                        request.RenameTo = newName;
                        using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                        {
                            MessageBox.Show("Rename successful");
                        }
                        GetFilesAndFolder(txtServer.Text, txtUsername.Text, txtPassword.Text, txtPort.Text, txtPath.Text);
                    }
                }
            }
        }

    
    }
}
