namespace QuanLySanPham
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CongCuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanlyUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanlySanPhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchSảnPhâmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themSanphamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CongCuToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1206, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CongCuToolStripMenuItem
            // 
            this.CongCuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanlyUserToolStripMenuItem,
            this.quanlySanPhamToolStripMenuItem});
            this.CongCuToolStripMenuItem.Name = "CongCuToolStripMenuItem";
            this.CongCuToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.CongCuToolStripMenuItem.Text = "Công Cụ";
            // 
            // quanlyUserToolStripMenuItem
            // 
            this.quanlyUserToolStripMenuItem.Name = "quanlyUserToolStripMenuItem";
            this.quanlyUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quanlyUserToolStripMenuItem.Text = "Quản Lý User";
            // 
            // quanlySanPhamToolStripMenuItem
            // 
            this.quanlySanPhamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchSảnPhâmToolStripMenuItem,
            this.themSanphamToolStripMenuItem});
            this.quanlySanPhamToolStripMenuItem.Name = "quanlySanPhamToolStripMenuItem";
            this.quanlySanPhamToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quanlySanPhamToolStripMenuItem.Text = "Quản Lý Sàn Phẩm";
            this.quanlySanPhamToolStripMenuItem.Click += new System.EventHandler(this.quanlySanPhamToolStripMenuItem_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // danhSáchSảnPhâmToolStripMenuItem
            // 
            this.danhSáchSảnPhâmToolStripMenuItem.Name = "danhSáchSảnPhâmToolStripMenuItem";
            this.danhSáchSảnPhâmToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.danhSáchSảnPhâmToolStripMenuItem.Text = "Danh Sách Sản Phâm";
            this.danhSáchSảnPhâmToolStripMenuItem.Click += new System.EventHandler(this.danhSáchSảnPhâmToolStripMenuItem_Click);
            // 
            // themSanphamToolStripMenuItem
            // 
            this.themSanphamToolStripMenuItem.Name = "themSanphamToolStripMenuItem";
            this.themSanphamToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.themSanphamToolStripMenuItem.Text = "Thêm Sản Phẩm";
            this.themSanphamToolStripMenuItem.Click += new System.EventHandler(this.themSanphamToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 516);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CongCuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanlyUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanlySanPhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchSảnPhâmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themSanphamToolStripMenuItem;
    }
}

