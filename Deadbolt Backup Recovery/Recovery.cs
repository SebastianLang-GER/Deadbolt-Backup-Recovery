using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shell;

namespace DeadboltBackupRecovery
{
    public partial class Recovery : Form
    {
        /// <summary>
        /// Constructor for Deadbolt Backup Recovery application GUI.
        /// </summary>
        public Recovery()
        {
            InitializeComponent();
        }

        #region GUI
        /// <summary>
        /// Form initialisation before it is displayed for the first time.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An object that contains no event data.</param>
        private void Recovery_Load(object sender, EventArgs e)
        {
            comboBox_DeleteEncryptedFiles.SelectedIndex = 1;
            comboBox_UnencryptedFilesExists.SelectedIndex = 1;
            comboBox_CopyMissingFiles.SelectedIndex = 1;
        }

        private void textBox_BackupFiles_DoubleClick(object sender, EventArgs e)
        {

        }

        private void button_BackupFiles_Click(object sender, EventArgs e)
        {

        }

        private void treeView_BackupFiles_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void textBox_EncryptedFiles_DoubleClick(object sender, EventArgs e)
        {

        }

        private void button_EncryptedFiles_Click(object sender, EventArgs e)
        {

        }

        private void treeView_EncryptedFiles_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void comboBox_DeleteEncryptedFiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_UnencryptedFilesExists_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_CopyMissingFiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Run_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton_ClearLog_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton_SaveLog_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton_AutoScroll_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton_AutoLineBreak_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Application

        #endregion
    }
}