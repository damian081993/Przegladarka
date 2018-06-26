namespace WindowsFormsApp2
{
    partial class Przegladarka
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.przejdzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wsteczToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńKarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.favoritesPanel = new System.Windows.Forms.Panel();
            this.linkBar = new System.Windows.Forms.ToolStrip();
            this.linkContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adresToolStripMenuItem,
            this.toolStripComboBox1,
            this.przejdzToolStripMenuItem,
            this.wsteczToolStripMenuItem,
            this.toolStripMenuItem1,
            this.dodajKarteToolStripMenuItem,
            this.usuńKarteToolStripMenuItem,
            this.dodajToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(810, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adresToolStripMenuItem
            // 
            this.adresToolStripMenuItem.Name = "adresToolStripMenuItem";
            this.adresToolStripMenuItem.Size = new System.Drawing.Size(49, 23);
            this.adresToolStripMenuItem.Text = "Adres";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(321, 23);
            // 
            // przejdzToolStripMenuItem
            // 
            this.przejdzToolStripMenuItem.Name = "przejdzToolStripMenuItem";
            this.przejdzToolStripMenuItem.Size = new System.Drawing.Size(56, 23);
            this.przejdzToolStripMenuItem.Text = "Przejdz";
            this.przejdzToolStripMenuItem.Click += new System.EventHandler(this.przejdzToolStripMenuItem_Click);
            // 
            // wsteczToolStripMenuItem
            // 
            this.wsteczToolStripMenuItem.Name = "wsteczToolStripMenuItem";
            this.wsteczToolStripMenuItem.Size = new System.Drawing.Size(43, 23);
            this.wsteczToolStripMenuItem.Text = "<<<";
            this.wsteczToolStripMenuItem.Click += new System.EventHandler(this.wsteczToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(43, 23);
            this.toolStripMenuItem1.Text = ">>>";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // dodajKarteToolStripMenuItem
            // 
            this.dodajKarteToolStripMenuItem.Name = "dodajKarteToolStripMenuItem";
            this.dodajKarteToolStripMenuItem.Size = new System.Drawing.Size(80, 23);
            this.dodajKarteToolStripMenuItem.Text = "Dodaj Karte";
            this.dodajKarteToolStripMenuItem.Click += new System.EventHandler(this.dodajKarteToolStripMenuItem_Click);
            // 
            // usuńKarteToolStripMenuItem
            // 
            this.usuńKarteToolStripMenuItem.Name = "usuńKarteToolStripMenuItem";
            this.usuńKarteToolStripMenuItem.Size = new System.Drawing.Size(76, 23);
            this.usuńKarteToolStripMenuItem.Text = "Usuń Karte";
            this.usuńKarteToolStripMenuItem.Click += new System.EventHandler(this.usuńKarteToolStripMenuItem_Click);
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(131, 23);
            this.dodajToolStripMenuItem.Text = "Dodaj do Ulubionych";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.dodajToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Location = new System.Drawing.Point(157, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(643, 385);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(13, 53);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(151, 385);
            this.tabControl2.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.treeView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(143, 359);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ulubione";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(-4, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(147, 385);
            this.treeView1.TabIndex = 0;
            // 
            // favoritesPanel
            // 
            this.favoritesPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.favoritesPanel.Location = new System.Drawing.Point(0, 87);
            this.favoritesPanel.Name = "favoritesPanel";
            this.favoritesPanel.Size = new System.Drawing.Size(148, 299);
            this.favoritesPanel.TabIndex = 4;
            // 
            // linkBar
            // 
            this.linkBar.Location = new System.Drawing.Point(0, 27);
            this.linkBar.Name = "linkBar";
            this.linkBar.Size = new System.Drawing.Size(810, 25);
            this.linkBar.TabIndex = 3;
            this.linkBar.Text = "toolStrip1";
            // 
            // linkContextMenu
            // 
            this.linkContextMenu.Name = "linkContextMenu";
            this.linkContextMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // imgList
            // 
            this.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgList.ImageSize = new System.Drawing.Size(16, 16);
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Przegladarka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.linkBar);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Przegladarka";
            this.Text = "Przegladarka";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adresToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem przejdzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wsteczToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dodajKarteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńKarteToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.Panel favoritesPanel;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip favContextMenu;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStrip linkBar;
        private System.Windows.Forms.ContextMenuStrip linkContextMenu;
        private System.Windows.Forms.ImageList imgList;
    }
}

