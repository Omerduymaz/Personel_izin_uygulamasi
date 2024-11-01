namespace Kantot
{
    partial class AThoseOnLeaveForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            timerSearchAutoDeactive = new System.Windows.Forms.Timer(components);
            toolStripSeparator6 = new ToolStripSeparator();
            btnSearchActive = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            btnDuzenle = new ToolStripButton();
            tsTopBar = new ToolStrip();
            tbSearch = new ToolStripTextBox();
            dgvProducts = new DataGridView();
            sicilno = new DataGridViewTextBoxColumn();
            adisoyadi = new DataGridViewTextBoxColumn();
            departman = new DataGridViewTextBoxColumn();
            turadi = new DataGridViewTextBoxColumn();
            bastar = new DataGridViewTextBoxColumn();
            bittar = new DataGridViewTextBoxColumn();
            aciklama = new DataGridViewTextBoxColumn();
            btnMainMenu = new ToolStripButton();
            tsTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // timerSearchAutoDeactive
            // 
            timerSearchAutoDeactive.Interval = 180000;
            timerSearchAutoDeactive.Tick += timerSearchAutoDeactive_Tick;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 105);
            // 
            // btnSearchActive
            // 
            btnSearchActive.Alignment = ToolStripItemAlignment.Right;
            btnSearchActive.AutoSize = false;
            btnSearchActive.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnSearchActive.Image = Properties.Resources.productstockupdate;
            btnSearchActive.ImageAlign = ContentAlignment.MiddleRight;
            btnSearchActive.ImageScaling = ToolStripItemImageScaling.None;
            btnSearchActive.ImageTransparentColor = Color.Magenta;
            btnSearchActive.Name = "btnSearchActive";
            btnSearchActive.Size = new Size(70, 70);
            btnSearchActive.TextAlign = ContentAlignment.BottomCenter;
            btnSearchActive.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSearchActive.Click += btnSearchActive_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 105);
            // 
            // btnDuzenle
            // 
            btnDuzenle.AutoSize = false;
            btnDuzenle.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnDuzenle.ForeColor = Color.White;
            btnDuzenle.Image = Properties.Resources.productupdate;
            btnDuzenle.ImageScaling = ToolStripItemImageScaling.None;
            btnDuzenle.ImageTransparentColor = Color.Magenta;
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(101, 87);
            btnDuzenle.Text = "Düzenle";
            btnDuzenle.TextAlign = ContentAlignment.BottomCenter;
            btnDuzenle.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // tsTopBar
            // 
            tsTopBar.AutoSize = false;
            tsTopBar.BackColor = Color.FromArgb(0, 0, 64);
            tsTopBar.GripMargin = new Padding(0);
            tsTopBar.GripStyle = ToolStripGripStyle.Hidden;
            tsTopBar.Items.AddRange(new ToolStripItem[] { btnDuzenle, toolStripSeparator4, btnMainMenu, tbSearch, btnSearchActive, toolStripSeparator6 });
            tsTopBar.Location = new Point(0, 0);
            tsTopBar.Name = "tsTopBar";
            tsTopBar.Padding = new Padding(10, 0, 10, 0);
            tsTopBar.Size = new Size(1488, 105);
            tsTopBar.TabIndex = 3;
            // 
            // tbSearch
            // 
            tbSearch.Alignment = ToolStripItemAlignment.Right;
            tbSearch.BorderStyle = BorderStyle.FixedSingle;
            tbSearch.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(300, 105);
            tbSearch.Visible = false;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.BorderStyle = BorderStyle.None;
            dgvProducts.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgvProducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle1.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ScrollBar;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.ColumnHeadersHeight = 55;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { sicilno, adisoyadi, departman, turadi, bastar, bittar, aciklama });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle3;
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.GridColor = Color.White;
            dgvProducts.Location = new Point(0, 105);
            dgvProducts.Margin = new Padding(0);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(1488, 732);
            dgvProducts.TabIndex = 4;
            dgvProducts.TabStop = false;
            // 
            // sicilno
            // 
            sicilno.DataPropertyName = "sicilno";
            sicilno.FillWeight = 75F;
            sicilno.HeaderText = "SİCİL NO";
            sicilno.Name = "sicilno";
            sicilno.ReadOnly = true;
            // 
            // adisoyadi
            // 
            adisoyadi.DataPropertyName = "adisoyadi";
            adisoyadi.HeaderText = "Adı Soyadı";
            adisoyadi.Name = "adisoyadi";
            adisoyadi.ReadOnly = true;
            // 
            // departman
            // 
            departman.DataPropertyName = "departman";
            departman.HeaderText = "Departman";
            departman.Name = "departman";
            departman.ReadOnly = true;
            // 
            // turadi
            // 
            turadi.DataPropertyName = "turadi";
            turadi.FillWeight = 150F;
            turadi.HeaderText = "İzin Türü";
            turadi.Name = "turadi";
            turadi.ReadOnly = true;
            // 
            // bastar
            // 
            bastar.DataPropertyName = "bastar";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            bastar.DefaultCellStyle = dataGridViewCellStyle2;
            bastar.HeaderText = "Başlangıç Tarihi";
            bastar.Name = "bastar";
            bastar.ReadOnly = true;
            // 
            // bittar
            // 
            bittar.DataPropertyName = "bittar";
            bittar.HeaderText = "Bitiş Tarihi";
            bittar.Name = "bittar";
            bittar.ReadOnly = true;
            // 
            // aciklama
            // 
            aciklama.DataPropertyName = "aciklama";
            aciklama.FillWeight = 200F;
            aciklama.HeaderText = "Açıklama";
            aciklama.Name = "aciklama";
            aciklama.ReadOnly = true;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Alignment = ToolStripItemAlignment.Right;
            btnMainMenu.AutoSize = false;
            btnMainMenu.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnMainMenu.ForeColor = Color.White;
            btnMainMenu.Image = Properties.Resources.mainmenu;
            btnMainMenu.ImageScaling = ToolStripItemImageScaling.None;
            btnMainMenu.ImageTransparentColor = Color.Magenta;
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(85, 87);
            btnMainMenu.Tag = "";
            btnMainMenu.Text = "Ana Menü";
            btnMainMenu.TextAlign = ContentAlignment.BottomCenter;
            btnMainMenu.TextImageRelation = TextImageRelation.ImageAboveText;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // AThoseOnLeaveForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1488, 837);
            ControlBox = false;
            Controls.Add(tsTopBar);
            Controls.Add(dgvProducts);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AThoseOnLeaveForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ThoseOnLeaveForm";
            tsTopBar.ResumeLayout(false);
            tsTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timerSearchAutoDeactive;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton btnSearchActive;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton btnDuzenle;
        private ToolStrip tsTopBar;
        private ToolStripTextBox tbSearch;
        private DataGridView dgvProducts;
        private DataGridViewTextBoxColumn sicilno;
        private DataGridViewTextBoxColumn adisoyadi;
        private DataGridViewTextBoxColumn departman;
        private DataGridViewTextBoxColumn turadi;
        private DataGridViewTextBoxColumn bastar;
        private DataGridViewTextBoxColumn bittar;
        private DataGridViewTextBoxColumn aciklama;
        private ToolStripButton btnMainMenu;
    }
}