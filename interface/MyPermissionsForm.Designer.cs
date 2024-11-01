namespace Kantot
{
    partial class MyPermissionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvOnayBekleyen = new DataGridView();
            izinturu = new DataGridViewTextBoxColumn();
            bastar = new DataGridViewTextBoxColumn();
            bittar = new DataGridViewTextBoxColumn();
            aciklama = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            dgvIzinGecmis = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            izindurumu = new DataGridViewTextBoxColumn();
            durumnot = new DataGridViewTextBoxColumn();
            timer = new System.Windows.Forms.Timer(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOnayBekleyen).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIzinGecmis).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1488, 837);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvOnayBekleyen);
            tabPage1.Location = new Point(4, 35);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1480, 798);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Onay Bekleyen İzin Talebim";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvOnayBekleyen
            // 
            dgvOnayBekleyen.AllowUserToAddRows = false;
            dgvOnayBekleyen.AllowUserToDeleteRows = false;
            dgvOnayBekleyen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOnayBekleyen.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvOnayBekleyen.BackgroundColor = Color.White;
            dgvOnayBekleyen.BorderStyle = BorderStyle.None;
            dgvOnayBekleyen.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgvOnayBekleyen.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle1.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ScrollBar;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvOnayBekleyen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvOnayBekleyen.ColumnHeadersHeight = 55;
            dgvOnayBekleyen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvOnayBekleyen.Columns.AddRange(new DataGridViewColumn[] { izinturu, bastar, bittar, aciklama });
            dgvOnayBekleyen.Dock = DockStyle.Fill;
            dgvOnayBekleyen.EnableHeadersVisualStyles = false;
            dgvOnayBekleyen.GridColor = Color.BlanchedAlmond;
            dgvOnayBekleyen.Location = new Point(3, 3);
            dgvOnayBekleyen.Margin = new Padding(0);
            dgvOnayBekleyen.MultiSelect = false;
            dgvOnayBekleyen.Name = "dgvOnayBekleyen";
            dgvOnayBekleyen.ReadOnly = true;
            dgvOnayBekleyen.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvOnayBekleyen.RowHeadersVisible = false;
            dgvOnayBekleyen.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            dgvOnayBekleyen.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvOnayBekleyen.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOnayBekleyen.Size = new Size(1474, 792);
            dgvOnayBekleyen.TabIndex = 3;
            dgvOnayBekleyen.TabStop = false;
            // 
            // izinturu
            // 
            izinturu.DataPropertyName = "izinturu";
            izinturu.FillWeight = 300F;
            izinturu.HeaderText = "İzin Türü";
            izinturu.Name = "izinturu";
            izinturu.ReadOnly = true;
            // 
            // bastar
            // 
            bastar.DataPropertyName = "bastar";
            bastar.FillWeight = 150F;
            bastar.HeaderText = "Başlangıç Tarihi";
            bastar.Name = "bastar";
            bastar.ReadOnly = true;
            // 
            // bittar
            // 
            bittar.DataPropertyName = "bittar";
            bittar.FillWeight = 150F;
            bittar.HeaderText = "Bitiş Tarihi";
            bittar.Name = "bittar";
            bittar.ReadOnly = true;
            // 
            // aciklama
            // 
            aciklama.DataPropertyName = "aciklama";
            aciklama.FillWeight = 500F;
            aciklama.HeaderText = "Açıklama";
            aciklama.Name = "aciklama";
            aciklama.ReadOnly = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvIzinGecmis);
            tabPage2.Location = new Point(4, 35);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1480, 798);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Geçmiş İzinlerim";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvIzinGecmis
            // 
            dgvIzinGecmis.AllowUserToAddRows = false;
            dgvIzinGecmis.AllowUserToDeleteRows = false;
            dgvIzinGecmis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIzinGecmis.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvIzinGecmis.BackgroundColor = Color.White;
            dgvIzinGecmis.BorderStyle = BorderStyle.None;
            dgvIzinGecmis.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgvIzinGecmis.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(32, 201, 151);
            dataGridViewCellStyle3.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(32, 201, 151);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvIzinGecmis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvIzinGecmis.ColumnHeadersHeight = 55;
            dgvIzinGecmis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvIzinGecmis.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, izindurumu, durumnot });
            dgvIzinGecmis.Dock = DockStyle.Fill;
            dgvIzinGecmis.EnableHeadersVisualStyles = false;
            dgvIzinGecmis.GridColor = Color.Black;
            dgvIzinGecmis.Location = new Point(3, 3);
            dgvIzinGecmis.Margin = new Padding(0);
            dgvIzinGecmis.MultiSelect = false;
            dgvIzinGecmis.Name = "dgvIzinGecmis";
            dgvIzinGecmis.ReadOnly = true;
            dgvIzinGecmis.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvIzinGecmis.RowHeadersVisible = false;
            dgvIzinGecmis.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            dgvIzinGecmis.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvIzinGecmis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIzinGecmis.Size = new Size(1474, 792);
            dgvIzinGecmis.TabIndex = 4;
            dgvIzinGecmis.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "izinturu";
            dataGridViewTextBoxColumn1.FillWeight = 300F;
            dataGridViewTextBoxColumn1.HeaderText = "İzin Türü";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "bastar";
            dataGridViewTextBoxColumn2.FillWeight = 150F;
            dataGridViewTextBoxColumn2.HeaderText = "Başlangıç Tarihi";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "bittar";
            dataGridViewTextBoxColumn3.FillWeight = 150F;
            dataGridViewTextBoxColumn3.HeaderText = "Bitiş Tarihi";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "aciklama";
            dataGridViewTextBoxColumn4.FillWeight = 500F;
            dataGridViewTextBoxColumn4.HeaderText = "Açıklama";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // izindurumu
            // 
            izindurumu.DataPropertyName = "izindurumu";
            izindurumu.HeaderText = "İzin Durumu";
            izindurumu.Name = "izindurumu";
            izindurumu.ReadOnly = true;
            // 
            // durumnot
            // 
            durumnot.DataPropertyName = "durumnot";
            durumnot.HeaderText = "Bilgi";
            durumnot.Name = "durumnot";
            durumnot.ReadOnly = true;
            // 
            // timer
            // 
            timer.Interval = 3000;
            timer.Tick += timer_Tick;
            // 
            // MyPermissionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1488, 837);
            ControlBox = false;
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MyPermissionsForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyPermissionsForm";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOnayBekleyen).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvIzinGecmis).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgvOnayBekleyen;
        private TabPage tabPage2;
        private DataGridViewTextBoxColumn izinturu;
        private DataGridViewTextBoxColumn bastar;
        private DataGridViewTextBoxColumn bittar;
        private DataGridViewTextBoxColumn aciklama;
        private DataGridView dgvIzinGecmis;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn izindurumu;
        private DataGridViewTextBoxColumn durumnot;
        private System.Windows.Forms.Timer timer;
    }
}