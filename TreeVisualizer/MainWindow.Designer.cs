
namespace TreeVisualizer
{
    partial class MainWindow
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.BinareTree = new System.Windows.Forms.TabPage();
            this.groupBox_Control = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.txt_Remove = new System.Windows.Forms.TextBox();
            this.txt_Insert = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.groupBox_Control.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.tabControl, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.groupBox_Control, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1481, 843);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.BinareTree);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(2, 2);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1477, 758);
            this.tabControl.TabIndex = 1;
            // 
            // BinareTree
            // 
            this.BinareTree.Location = new System.Drawing.Point(4, 22);
            this.BinareTree.Margin = new System.Windows.Forms.Padding(2);
            this.BinareTree.Name = "BinareTree";
            this.BinareTree.Padding = new System.Windows.Forms.Padding(2);
            this.BinareTree.Size = new System.Drawing.Size(1469, 732);
            this.BinareTree.TabIndex = 0;
            this.BinareTree.Text = "Бинарное дерево";
            this.BinareTree.UseVisualStyleBackColor = true;
            this.BinareTree.Click += new System.EventHandler(this.tabPage_BST_Click);
            // 
            // groupBox_Control
            // 
            this.groupBox_Control.Controls.Add(this.button1);
            this.groupBox_Control.Controls.Add(this.btn_Remove);
            this.groupBox_Control.Controls.Add(this.btn_Insert);
            this.groupBox_Control.Controls.Add(this.txt_Remove);
            this.groupBox_Control.Controls.Add(this.txt_Insert);
            this.groupBox_Control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Control.Location = new System.Drawing.Point(2, 764);
            this.groupBox_Control.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Control.Name = "groupBox_Control";
            this.groupBox_Control.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Control.Size = new System.Drawing.Size(1477, 77);
            this.groupBox_Control.TabIndex = 2;
            this.groupBox_Control.TabStop = false;
            this.groupBox_Control.Text = "Панель управления";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(591, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Четкие числа";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(199, 46);
            this.btn_Remove.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(112, 24);
            this.btn_Remove.TabIndex = 1;
            this.btn_Remove.Text = "Удалить число";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(199, 17);
            this.btn_Insert.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(112, 24);
            this.btn_Insert.TabIndex = 1;
            this.btn_Insert.Text = "Вставить числа";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // txt_Remove
            // 
            this.txt_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Remove.Location = new System.Drawing.Point(7, 45);
            this.txt_Remove.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Remove.Name = "txt_Remove";
            this.txt_Remove.Size = new System.Drawing.Size(188, 26);
            this.txt_Remove.TabIndex = 0;
            this.txt_Remove.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Insert
            // 
            this.txt_Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Insert.Location = new System.Drawing.Point(7, 17);
            this.txt_Insert.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Insert.Name = "txt_Insert";
            this.txt_Insert.Size = new System.Drawing.Size(188, 26);
            this.txt_Insert.TabIndex = 0;
            this.txt_Insert.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Insert.TextChanged += new System.EventHandler(this.txt_Insert_TextChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 843);
            this.Controls.Add(this.tableLayoutPanel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.groupBox_Control.ResumeLayout(false);
            this.groupBox_Control.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage BinareTree;
        private System.Windows.Forms.GroupBox groupBox_Control;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.TextBox txt_Remove;
        public System.Windows.Forms.TextBox txt_Insert;
        private System.Windows.Forms.Button button1;
    }
}