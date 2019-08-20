using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComboBoxWithPicture;

namespace ComboBoxWithPictureDemo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            //添加项
            myComboBox1.Items.Add(new ComboBoxItemWithImage("000000", Properties.Resources._01));
            myComboBox1.Items.Add(new ComboBoxItemWithImage("111111", Properties.Resources._02));
            myComboBox1.Items.Add(new ComboBoxItemWithImage("222222", Properties.Resources._03));
            myComboBox1.Items.Add(new ComboBoxItemWithImage("333333", Properties.Resources._04));

            //默认选中项索引
            myComboBox1.SelectedIndex = 0;
            //自绘组合框需要设置的一些属性
            myComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            myComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            myComboBox1.ItemHeight = 50;
            myComboBox1.Width = 200;
        }
    }
}
