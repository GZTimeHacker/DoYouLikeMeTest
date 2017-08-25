using System.Windows;
using System.Windows.Input;
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
