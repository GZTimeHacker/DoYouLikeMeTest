using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TEST
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private int count = 0;
        private bool islike = false;

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            if (islike == false)
            {
                MessageBox.Show("关闭窗口也改变不了你喜欢我的事实！", "");
                e.Cancel = true;
            }
        }

        private void like_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("你果然还是喜欢我的！");
            islike = true;
            this.Close();
        }
        /*
        //deskPoint: 控件要移动到的位置 , ell :你要移动的空间 , space : 设置移动的时间片（关系到控件移动的速度）
        private void moveTo(Point deskPoint, Control ell, double space)
        {
            Point curPoint = new Point();
            curPoint.X = Canvas.GetLeft(ell);
            curPoint.Y = Canvas.GetTop(ell);

            Storyboard storyboard = new Storyboard();   //创建Storyboard对象

            double lxspeed = space, lyspeed = space; //设置X方向 / Y方向 移动时间片
                                                     //创建X轴方向动画 
            DoubleAnimation doubleAnimation = new DoubleAnimation(
       Canvas.GetLeft(ell),
       deskPoint.X,
       new Duration(TimeSpan.FromMilliseconds(lxspeed))
      );
            Storyboard.SetTarget(doubleAnimation, ell);
            Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath("(Canvas.Left)"));
            storyboard.Children.Add(doubleAnimation);


            //创建Y轴方向动画 


            doubleAnimation = new DoubleAnimation(
       Canvas.GetTop(ell),
       deskPoint.Y,
       new Duration(TimeSpan.FromMilliseconds(lyspeed))
      );
            Storyboard.SetTarget(doubleAnimation, ell);
            Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath("(Canvas.Top)"));
            storyboard.Children.Add(doubleAnimation);

            //动画播放 
            storyboard.Begin();
            storyboard.Remove(ell);
        }
        */
        private void dislike_MouseEnter(object sender, MouseEventArgs e)
        {
            switch (count)
            {
                case 0:
                    dislike.Margin = new Thickness(296,31,0,0);
                    break;
                case 1:
                    dislike.Margin = new Thickness(296, 98, 0, 0);
                    break;
                default:
                    Thickness margin = dislike.Margin;
                    dislike.Margin = like.Margin;
                    like.Margin = margin;
                    break;
            }
            count++;
        }

    }
}
