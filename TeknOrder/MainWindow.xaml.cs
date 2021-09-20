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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;

namespace TeknOrder
{
    public partial class MainWindow : Window
    {
        public int queue { get; set; } = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SendBtn_Clicked(object sender, RoutedEventArgs e)
        {
            if(sender is Button)
            {
                if (!String.IsNullOrWhiteSpace(txt_Message.Text))
                {
                    if (queue == 0)
                    {
                        MyMessage_Label1.Visibility = Visibility.Visible;
                        MyMessage_Label1.Content = txt_Message.Text;

                        HisMessage_Label1.Content = "Salam, Yaxsiyam. Sizde SSD Var?";
                        HisMessage_Label1.Visibility = Visibility.Visible;

                    }
                    else if (queue == 1)
                    {
                        MyMessage_Label2.Content = txt_Message.Text;
                        MyMessage_Label2.Visibility = Visibility.Visible;

                        HisMessage_Label2.Content = "Neceyedi ?";
                        HisMessage_Label2.Visibility = Visibility.Visible;
                    }
                    else if (queue == 2)
                    {
                        MyMessage_Label3.Content = txt_Message.Text;
                        MyMessage_Label3.Visibility = Visibility.Visible;

                        HisMessage_Label3.Content = "AxsamBazari Endirim Edesuz Belke ?";
                        HisMessage_Label3.Visibility = Visibility.Visible;
                    }
                    else if (queue == 3)
                    {
                        MyMessage_Label3.Content = txt_Message.Text;
                        MyMessage_Label3.Visibility = Visibility.Visible;

                        HisMessage_Label3.Content = "oldu aliram. Catdirilma Pulsuzdur?";
                        HisMessage_Label3.Visibility = Visibility.Visible;
                    }
                    else if (queue == 4)
                    {
                        MyMessage_Label3.Content = txt_Message.Text;
                        MyMessage_Label3.Visibility = Visibility.Visible;

                        HisMessage_Label3.Content = "Bes Hara Gelim?";
                        HisMessage_Label3.Visibility = Visibility.Visible;
                    }
                    else if (queue == 5)
                    {
                        MyMessage_Label3.Content = txt_Message.Text;
                        MyMessage_Label3.Visibility = Visibility.Visible;

                        HisMessage_Label3.Content = "Oldu Sagolun";
                        HisMessage_Label3.Visibility = Visibility.Visible;
                    }
                    queue++;
                    txt_Message.Text = "";
                    btn_Send.Visibility = Visibility.Hidden;
                }
            }
        }

        private void txt_Changed(object sender, TextChangedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txt_Message.Text))
            {
                btn_Send.Visibility = Visibility.Visible;
                lbl_WriteMessage.Visibility = Visibility.Hidden;
            }
            else
            {
                btn_Send.Visibility = Visibility.Hidden;
                lbl_WriteMessage.Visibility = Visibility.Visible;
            }

        }

        private void Btn_CloseApp(object sender, RoutedEventArgs e)
        {
            Close();
        }


    }
}
