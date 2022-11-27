using Confluent.Kafka;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LecteurMp3
{
    public partial class Form1 : Form
    {
        
        List<Mp3> listMP3 = new List<Mp3>();
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void changement_Etat_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                label3.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }

        private void mp3BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void lecture_Click_Click(object sender, EventArgs e)
        {
            if (label3.Text != "")
            {
                Lecteur leson = new Lecteur();
                Mp3 lesonplay = new Mp3();
                listMP3 = (List<Mp3>)mp3BindingSource.DataSource;
                lesonplay = leson.Joue(listMP3);
                label4.Text = lesonplay.Titre;
                WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

                wplayer.URL = lesonplay.Repertoire;
                wplayer.controls.play();
            }
            else{
                MessageBox.Show("Veuillez choisir un repertoire");
            }
        }

        private void ListeTitre_Click(object sender, EventArgs e)
        {
            if (label3.Text != "")
            {
                listMP3.Clear();
                string[] dirs = Directory.GetFiles(label3.Text, "*.mp3");
                foreach (string dir in dirs)
                {
                    TagLib.File tagFile = TagLib.File.Create(dir);
                    Mp3 musique = new Mp3(tagFile.Tag.Title, tagFile.Tag.FirstAlbumArtist, tagFile.Tag.Album, tagFile.Tag.Year.ToString(), dir);
                    listMP3.Add(musique);
                }

                Lecteur lec = new Lecteur(listMP3);
                mp3BindingSource.DataSource = listMP3;
                dataGridView1.Visible = true;
            }
            else
            {
                MessageBox.Show("Veuillez choisir un repertoire");
            }
        }
    }
}
