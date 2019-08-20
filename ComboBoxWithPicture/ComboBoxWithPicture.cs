using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxWithPicture
{
    public class ComboBoxWithPicture : ComboBox
    {
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);

            //鼠标选中在这个项上
            if ((e.State & DrawItemState.Selected) != 0)
            {
                //渐变画刷
                LinearGradientBrush brush = new LinearGradientBrush(e.Bounds, Color.FromArgb(255, 251, 237),
                                                 Color.FromArgb(255, 236, 181), LinearGradientMode.Vertical);
                //填充区域
                Rectangle borderRect = new Rectangle(3, e.Bounds.Y, e.Bounds.Width - 5, e.Bounds.Height - 2);

                e.Graphics.FillRectangle(brush, borderRect);

                //画边框
                Pen pen = new Pen(Color.FromArgb(229, 195, 101));
                e.Graphics.DrawRectangle(pen, borderRect);
            }
            else
            {
                SolidBrush brush = new SolidBrush(Color.FromArgb(255, 255, 255));
                e.Graphics.FillRectangle(brush, e.Bounds);
            }

            //获得项图片,绘制图片
            ComboBoxItemWithImage item = (ComboBoxItemWithImage)Items[e.Index];
            Image img = item.Img;

            //图片绘制的区域
            Rectangle imgRect = new Rectangle(6, e.Bounds.Y + 3, 45, 45);
            e.Graphics.DrawImage(img, imgRect);

            //文本内容显示区域
            Rectangle textRect =
                    new Rectangle(imgRect.Right + 2, imgRect.Y, e.Bounds.Width - imgRect.Width, e.Bounds.Height - 2);

            //获得项文本内容,绘制文本
            String itemText = Items[e.Index].ToString();

            //文本格式垂直居中
            StringFormat strFormat = new StringFormat();
            strFormat.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString(itemText, new Font("微软雅黑", 12), Brushes.Black, textRect, strFormat);
        }
    }
}
