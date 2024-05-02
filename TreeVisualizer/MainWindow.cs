using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TreeVisualizer
{
    public partial class MainWindow : Form
    {
        private DrawBox _bstDrawBox;

        private ITree<int> _binarSearchTree;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            _bstDrawBox = new DrawBox
            {
                Dock = DockStyle.Fill,
            };

            _binarSearchTree = new BinarySearchTree<int>(new TreeConfiguration(circleDiameter: 45, arrowAnchorSize: 5));
            BinareTree.Controls.Add(_bstDrawBox);
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            List<int> vs = new List<int>();
            string[] a = txt_Insert.Text.Split(' ');
            foreach(string Num in a)
            {
                if(Num != "")
                    vs.Add(int.Parse(Num));
            }
            foreach (int valve in vs)
            {
                if (string.IsNullOrEmpty(txt_Insert.Text))
                {
                    MessageBox.Show("Вы не ввели числа.");
                    return;
                }
                if (tabControl.SelectedTab == BinareTree)
                {          
                    _binarSearchTree.Insert(valve);
                    _bstDrawBox.Print<BinarySearchTree<int>>(_binarSearchTree);
                }
                
            }         
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Remove.Text))
            {
                MessageBox.Show("Вы не ввели число.");
                return;
            }
            if (!int.TryParse(txt_Remove.Text, out int value))
            {
                MessageBox.Show($"Ожидался формат {typeof(int)}", "Ошибка");
                return;
            }

            if (tabControl.SelectedTab == BinareTree)
            {
                _binarSearchTree.Remove(value);
                _bstDrawBox.Print<BinarySearchTree<int>>(_binarSearchTree);
            }
        }

        private void tabPage_BST_Click(object sender, EventArgs e)
        {

        }

        private void txt_Insert_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumberForm numberForm = new NumberForm();
            numberForm.Show();
        }
    }
}
