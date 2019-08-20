using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBoxWithPicture
{
    //自定义组合框项
    public class ComboBoxItemWithImage
    {
        //项文本内容
        private String Text;

        //项图片
        public Image Img;

        //构造函数
        public ComboBoxItemWithImage(String text, Image img)
        {
            Text = text;
            Img = img;
        }

        //重写ToString函数，返回项文本
        public override string ToString()
        {
            return Text;
        }
    }
}
