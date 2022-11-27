
namespace LecteurMp3
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
            this.changement_Etat = new System.Windows.Forms.Button();
            this.lecture_Click = new System.Windows.Forms.Button();
            this.choix_Click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.titreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artisteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anneeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mp3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mp3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // changement_Etat
            // 
            this.changement_Etat.Location = new System.Drawing.Point(66, 72);
            this.changement_Etat.Name = "changement_Etat";
            this.changement_Etat.Size = new System.Drawing.Size(163, 38);
            this.changement_Etat.TabIndex = 0;
            this.changement_Etat.Text = "Choix Repertoire";
            this.changement_Etat.UseVisualStyleBackColor = true;
            this.changement_Etat.Click += new System.EventHandler(this.changement_Etat_Click);
            // 
            // lecture_Click
            // 
            this.lecture_Click.Location = new System.Drawing.Point(305, 72);
            this.lecture_Click.Name = "lecture_Click";
            this.lecture_Click.Size = new System.Drawing.Size(127, 38);
            this.lecture_Click.TabIndex = 1;
            this.lecture_Click.Text = "Lecture";
            this.lecture_Click.UseVisualStyleBackColor = true;
            this.lecture_Click.Click += new System.EventHandler(this.lecture_Click_Click);
            // 
            // choix_Click
            // 
            this.choix_Click.Location = new System.Drawing.Point(521, 72);
            this.choix_Click.Name = "choix_Click";
            this.choix_Click.Size = new System.Drawing.Size(118, 38);
            this.choix_Click.TabIndex = 2;
            this.choix_Click.Text = "Liste Titre";
            this.choix_Click.UseVisualStyleBackColor = true;
            this.choix_Click.Click += new System.EventHandler(this.ListeTitre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Répertoire courant:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Titre :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titreDataGridViewTextBoxColumn,
            this.artisteDataGridViewTextBoxColumn,
            this.albumDataGridViewTextBoxColumn,
            this.anneeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mp3BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(66, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(777, 189);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 8;
            // 
            // titreDataGridViewTextBoxColumn
            // 
            this.titreDataGridViewTextBoxColumn.DataPropertyName = "Titre";
            this.titreDataGridViewTextBoxColumn.HeaderText = "Titre";
            this.titreDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.titreDataGridViewTextBoxColumn.Name = "titreDataGridViewTextBoxColumn";
            this.titreDataGridViewTextBoxColumn.Width = 150;
            // 
            // artisteDataGridViewTextBoxColumn
            // 
            this.artisteDataGridViewTextBoxColumn.DataPropertyName = "Artiste";
            this.artisteDataGridViewTextBoxColumn.HeaderText = "Artiste";
            this.artisteDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.artisteDataGridViewTextBoxColumn.Name = "artisteDataGridViewTextBoxColumn";
            this.artisteDataGridViewTextBoxColumn.Width = 150;
            // 
            // albumDataGridViewTextBoxColumn
            // 
            this.albumDataGridViewTextBoxColumn.DataPropertyName = "Album";
            this.albumDataGridViewTextBoxColumn.HeaderText = "Album";
            this.albumDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.albumDataGridViewTextBoxColumn.Name = "albumDataGridViewTextBoxColumn";
            this.albumDataGridViewTextBoxColumn.Width = 150;
            // 
            // anneeDataGridViewTextBoxColumn
            // 
            this.anneeDataGridViewTextBoxColumn.DataPropertyName = "Annee";
            this.anneeDataGridViewTextBoxColumn.HeaderText = "Annee";
            this.anneeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.anneeDataGridViewTextBoxColumn.Name = "anneeDataGridViewTextBoxColumn";
            this.anneeDataGridViewTextBoxColumn.Width = 150;
            // 
            // mp3BindingSource
            // 
            this.mp3BindingSource.DataSource = typeof(LecteurMp3.Mp3);
            this.mp3BindingSource.CurrentChanged += new System.EventHandler(this.mp3BindingSource_CurrentChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LecteurMp3.Properties.Resources.PictureSong;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1156, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.choix_Click);
            this.Controls.Add(this.lecture_Click);
            this.Controls.Add(this.changement_Etat);
            this.Name = "Form1";
            this.Text = "MP3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mp3BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changement_Etat;
        private System.Windows.Forms.Button lecture_Click;
        private System.Windows.Forms.Button choix_Click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artisteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anneeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mp3BindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

