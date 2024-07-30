using imm2Virtual;
using System.Configuration;
using System.Management;


namespace Imm2Virtual
{
    public partial class I2VFrm : Form
    {
        string ImagePhysicalDisk = "";

        //Initialize form
        public I2VFrm()
        {
            InitializeComponent();

            //Logging
            logTxt.Text += "[" + DateTime.UtcNow.ToString("dd/MM/yyyy HH:mm:ss") + " UTC] - [" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "] - Application start" + System.Environment.NewLine;

            //Configure external apps path
            AIMPathTxt.Text = @Properties.Settings.Default.AIMPath;
            VBOXPathTxt.Text = @Properties.Settings.Default.VBOXPath;

            this.ExternalAppsControl();
        }

        //Select source image path
        private void SelectSourceImagePathButton_Click(object sender, EventArgs e)
        {
            //Selected source image
            if (SelectSourceImageFileDialog.ShowDialog() == DialogResult.OK)
            {
                //View source path
                SourceImagePathTxt.Text = SelectSourceImageFileDialog.FileName;

                //Logging
                logTxt.Text += "[" + DateTime.UtcNow.ToString("dd/MM/yyyy HH:mm:ss") + " UTC] - [" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "] - Source image path selected: " + SourceImagePathTxt.Text + System.Environment.NewLine;

                //View check
                KOSImg.Hide();
            }

            //Enable convert button
            if (SourceImagePathTxt.Text.Length > 0 && DestinationImagePathTxt.Text.Length > 0)
            {
                ConvertBtn.Enabled = true;
            }
        }

        //Start mounter thread
        private void MounterBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            //Call Arsenal to mount image
            string path = @AIMPathTxt.Text;
            string parameters = "--mount --readonly --filename=\"" + SourceImagePathTxt.Text + "\"";
            string output = ExternalApplicationHelper.LaunchExternalApplication(path, parameters);
        }

        //Select destination image path
        private void SelectDestinationImagePathBtn_Click(object sender, EventArgs e)
        {
            //Selected destination image
            if (SelectDestinationImageFileDialog.ShowDialog() == DialogResult.OK)
            {
                //View path
                DestinationImagePathTxt.Text = SelectDestinationImageFileDialog.FileName;

                //Logging
                logTxt.Text += "[" + DateTime.UtcNow.ToString("dd/MM/yyyy HH:mm:ss") + " UTC] - [" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "] - Destination image path selected: " + DestinationImagePathTxt.Text + System.Environment.NewLine;

                //View check
                KODImg.Hide();
            }

            //Enable convert button
            if (SourceImagePathTxt.Text.Length > 0 && DestinationImagePathTxt.Text.Length > 0)
            {
                ConvertBtn.Enabled = true;
            }
        }

        //Convert image process
        private void ConvertBtn_Click(object sender, EventArgs e)
        {

            //Call backgroung worker to mount image
            MounterBackgroundWorker.RunWorkerAsync(e);

            //Info
            MessageBox.Show("Mounting image...", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Logging
            logTxt.Text += "[" + DateTime.UtcNow.ToString("dd/MM/yyyy HH:mm:ss") + " UTC] - [" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "] - Mounting selected image" + System.Environment.NewLine;

            //Find mounted image physical disk
            var query = new WqlObjectQuery("SELECT * FROM Win32_DiskDrive");
            ManagementObjectSearcher MOSearcher = new ManagementObjectSearcher(query);
            using (ManagementObjectCollection MOCollection = MOSearcher.Get())
            {
                foreach (ManagementObject PhysicalVolume in MOCollection)
                {
                    if (PhysicalVolume["Model"].ToString() == "Arsenal Virtual SCSI Disk Device")
                    {
                        ImagePhysicalDisk = PhysicalVolume["DeviceID"].ToString();
                    }
                }
            }

            //Info
            if (ImagePhysicalDisk != null && ImagePhysicalDisk.Length > 0)
            {
                //OK
                //Info
                MessageBox.Show("Image mounted as " + ImagePhysicalDisk, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Logging
                logTxt.Text += "[" + DateTime.UtcNow.ToString("dd/MM/yyyy HH:mm:ss") + " UTC] - [" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "] - Image mounted as: " + ImagePhysicalDisk + System.Environment.NewLine;

                //View check
                KOMImg.Hide();
            }
            else
            {
                //KO
                //Info
                MessageBox.Show("Error mounting image", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Logging
                logTxt.Text += "[" + DateTime.UtcNow.ToString("dd/MM/yyyy HH:mm:ss") + " UTC] - [" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "] - Error mounting image" + System.Environment.NewLine;
            }

            if (ImagePhysicalDisk != null && ImagePhysicalDisk.Length > 0)
            {
                //Info
                MessageBox.Show("Converting " + ImagePhysicalDisk, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Logging
                logTxt.Text += "[" + DateTime.UtcNow.ToString("dd/MM/yyyy HH:mm:ss") + " UTC] - [" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "] - Converting " + ImagePhysicalDisk + System.Environment.NewLine;

                //Call VirtualBox to convert image
                string path = VBOXPathTxt.Text;
                string parameters = "internalcommands createrawvmdk -filename \"" + DestinationImagePathTxt.Text + "\" -rawdisk " + ImagePhysicalDisk;
                string output = ExternalApplicationHelper.LaunchExternalApplication(path, parameters);

                //Logging
                logTxt.Text += "[" + DateTime.UtcNow.ToString("dd/MM/yyyy HH:mm:ss") + " UTC] - [" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "] - VirtualBox returns: " + output;

                if (output.Contains("successfully."))
                {
                    //OK
                    //Info
                    MessageBox.Show("Converted " + ImagePhysicalDisk, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Logging
                    logTxt.Text += "[" + DateTime.UtcNow.ToString("dd/MM/yyyy HH:mm:ss") + " UTC] - [" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "] - Converted " + ImagePhysicalDisk + System.Environment.NewLine;

                    //View check
                    KOCImg.Hide();
                }
                else
                {
                    //KO
                    //Info
                    MessageBox.Show("Converted " + ImagePhysicalDisk, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //Logging
                    logTxt.Text += "[" + DateTime.UtcNow.ToString("dd/MM/yyyy HH:mm:ss") + " UTC] - [" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "] - Error converting " + ImagePhysicalDisk + System.Environment.NewLine;
                }
            }

        }

        //Closing form
        private void I2VFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Dismount all images eventually mounted
            if (AIMPathTxt.Text.Contains("aim_cli.exe") && File.Exists(AIMPathTxt.Text))
            {
                this.DismountAllImages();
            }

            //Close Mounter thread
            MounterBackgroundWorker.CancelAsync();
        }

        //Dismount all images eventually mounted
        private void DismountAllImages()
        {
            //Dismount all images eventually mounted
            string path = @AIMPathTxt.Text;
            string parameters = "--dismount";
            string output = ExternalApplicationHelper.LaunchExternalApplication(path, parameters);

            if (output == null || output.Length == 0)
            {
                output = "Nothing to dismount" + System.Environment.NewLine;
            }

            //Logging
            logTxt.Text += "[" + DateTime.UtcNow.ToString("dd/MM/yyyy HH:mm:ss") + " UTC] - [" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "] - Trying to dismount all images eventually mounted..." + System.Environment.NewLine;
            logTxt.Text += "[" + DateTime.UtcNow.ToString("dd/MM/yyyy HH:mm:ss") + " UTC] - [" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "] - Arsenal image mounter returns: " + output;
        }

        //Control for external apps
        private void ExternalAppsControl()
        {
            if (AIMPathTxt.Text.Contains("aim_cli.exe") && File.Exists(AIMPathTxt.Text))
            {
                //OK
                //Logging
                logTxt.Text += "[" + DateTime.UtcNow.ToString("dd/MM/yyyy HH:mm:ss") + " UTC] - [" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "] - Arsenal Image Mounter found" + System.Environment.NewLine;

                //View check
                KOAIMImg.Hide();

                //Dismount all images eventually mounted
                this.DismountAllImages();
            }
            else
            {
                //KO
                //Logging
                logTxt.Text += "[" + DateTime.UtcNow.ToString("dd/MM/yyyy HH:mm:ss") + " UTC] - [" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "] - Arsenal Image Mounter not found" + System.Environment.NewLine;

                //View check
                KOAIMImg.Show();

                //Info
                MessageBox.Show("Arsenal Image Mounter not found, check configuration tab", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);

                SelectDestinationImagePathBtn.Enabled = false;
                SelectSourceImagePathBtn.Enabled = false;
            }

            if (VBOXPathTxt.Text.Contains("VBoxManage.exe") && File.Exists(VBOXPathTxt.Text))
            {
                //OK
                //Logging
                logTxt.Text += "[" + DateTime.UtcNow.ToString("dd/MM/yyyy HH:mm:ss") + " UTC] - [" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "] - VirtualBox found" + System.Environment.NewLine;

                //View check
                KOVBOXImg.Hide();
            }
            else
            {
                //KO
                //Logging
                logTxt.Text += "[" + DateTime.UtcNow.ToString("dd/MM/yyyy HH:mm:ss") + " UTC] - [" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "] - VirtualBox not found" + System.Environment.NewLine;

                //View check
                KOVBOXImg.Show();

                //Info
                MessageBox.Show("VirtualBox not found, check configuration tab", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);

                SelectDestinationImagePathBtn.Enabled = false;
                SelectSourceImagePathBtn.Enabled = false;
            }

            //Enable images select buttons
            if (AIMPathTxt.Text.Contains("aim_cli.exe") && File.Exists(AIMPathTxt.Text) && VBOXPathTxt.Text.Contains("VBoxManage.exe") && File.Exists(VBOXPathTxt.Text))
            {
                SelectDestinationImagePathBtn.Enabled = true;
                SelectSourceImagePathBtn.Enabled = true;
            }
        }

        //Select Arsenal Image Mounter Path
        private void SelectAIMPathBtn_Click(object sender, EventArgs e)
        {
            if (SelectAIMFileDialog.ShowDialog() == DialogResult.OK)
            {
                AIMPathTxt.Text = SelectAIMFileDialog.FileName;
                Properties.Settings.Default.AIMPath = AIMPathTxt.Text;
                Properties.Settings.Default.Save();

                this.ExternalAppsControl();
            }
        }

        //Select Virtua Box Path
        private void SelectVBOXPathBtn_Click(object sender, EventArgs e)
        {
            if (SelectVBOXFileDialog.ShowDialog() == DialogResult.OK)
            {
                VBOXPathTxt.Text = SelectVBOXFileDialog.FileName;
                Properties.Settings.Default.VBOXPath = VBOXPathTxt.Text;
                Properties.Settings.Default.Save();

                this.ExternalAppsControl();
            }
        }
    }
}
