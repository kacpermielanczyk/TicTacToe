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

namespace TicTacToe
{
    public partial class MainWindow : Window
    {
        bool player1Turn = true;
        int turn = 0;
        public MainWindow()
        {
            InitializeComponent();
            NewGame();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(turn == 9)
            {
                NewGame();
            }
            var button = sender as Button;

            if(button.Content == string.Empty)
            {
                if (player1Turn == true)
                {
                    button.Content = "X";
                    infoButton.Content = "Turn player 'O'";
                    player1Turn = false;
                    turn++;
                }
                else
                {
                    button.Content = "O";
                    infoButton.Content = "Turn player 'X'";
                    player1Turn = true;
                    turn++;
                }
            }

            if(CheckPlayerWin())
            {
                turn = 9;
            }
        }

        private void NewGame()
        {
            button0_0.Content = string.Empty;
            button1_0.Content = string.Empty;
            button2_0.Content = string.Empty;
            button0_1.Content = string.Empty;
            button1_1.Content = string.Empty;
            button2_1.Content = string.Empty;
            button0_2.Content = string.Empty;
            button1_2.Content = string.Empty;
            button2_2.Content = string.Empty;
            infoButton.Content = string.Empty;

            button0_0.Background = Brushes.AliceBlue;
            button1_0.Background = Brushes.AliceBlue;
            button2_0.Background = Brushes.AliceBlue;
            button0_1.Background = Brushes.AliceBlue;
            button1_1.Background = Brushes.AliceBlue;
            button2_1.Background = Brushes.AliceBlue;
            button0_2.Background = Brushes.AliceBlue;
            button1_2.Background = Brushes.AliceBlue;
            button2_2.Background = Brushes.AliceBlue;
            turn = 0;
        }

        private bool CheckPlayerWin()
        {
            if (button0_0.Content == button1_0.Content && button1_0.Content == button2_0.Content && button2_0.Content != string.Empty)
            {
                button0_0.Background = Brushes.LightGreen;
                button1_0.Background = Brushes.LightGreen;
                button2_0.Background = Brushes.LightGreen;
                if(button0_0.Content == "X")
                {
                    infoButton.Content = "Player 'X' win!!!";
                }
                else
                {
                    infoButton.Content = "Player 'O' win!!!";
                }
                return true;
            }
            else if (button0_1.Content == button1_1.Content && button1_1.Content == button2_1.Content && button2_1.Content != string.Empty)
            {
                button0_1.Background = Brushes.LightGreen;
                button1_1.Background = Brushes.LightGreen;
                button2_1.Background = Brushes.LightGreen;
                if (button0_1.Content == "X")
                {
                    infoButton.Content = "Player 'X' win!!!";
                }
                else
                {
                    infoButton.Content = "Player 'O' win!!!";
                }
                return true;
            }
            else if (button0_2.Content == button1_2.Content && button1_2.Content == button2_2.Content && button2_2.Content != string.Empty)
            {
                button0_2.Background = Brushes.LightGreen;
                button1_2.Background = Brushes.LightGreen;
                button2_2.Background = Brushes.LightGreen;
                if (button0_2.Content == "X")
                {
                    infoButton.Content = "Player 'X' win!!!";
                }
                else
                {
                    infoButton.Content = "Player 'O' win!!!";
                }
                return true;
            }
            else if (button0_0.Content == button0_1.Content && button0_1.Content == button0_2.Content && button0_0.Content != string.Empty)
            {
                button0_0.Background = Brushes.LightGreen;
                button0_1.Background = Brushes.LightGreen;
                button0_2.Background = Brushes.LightGreen;
                if (button0_0.Content == "X")
                {
                    infoButton.Content = "Player 'X' win!!!";
                }
                else
                {
                    infoButton.Content = "Player 'O' win!!!";
                }
                return true;
            }
            else if (button1_0.Content == button1_1.Content && button1_1.Content == button1_2.Content && button1_0.Content != string.Empty)
            {
                button1_0.Background = Brushes.LightGreen;
                button1_1.Background = Brushes.LightGreen;
                button1_2.Background = Brushes.LightGreen;
                if (button1_0.Content == "X")
                {
                    infoButton.Content = "Player 'X' win!!!";
                }
                else
                {
                    infoButton.Content = "Player 'O' win!!!";
                }
                return true;
            }
            else if (button2_0.Content == button2_1.Content && button2_1.Content == button2_2.Content &&  button2_0.Content != string.Empty)
            {
                button2_0.Background = Brushes.LightGreen;
                button2_1.Background = Brushes.LightGreen;
                button2_2.Background = Brushes.LightGreen;
                if (button2_0.Content == "X")
                {
                    infoButton.Content = "Player 'X' win!!!";
                }
                else
                {
                    infoButton.Content = "Player 'O' win!!!";
                }
                return true;
            }
            else if (button2_0.Content == button1_1.Content && button1_1.Content == button0_2.Content && button2_0.Content != string.Empty)
            {
                button2_0.Background = Brushes.LightGreen;
                button1_1.Background = Brushes.LightGreen;
                button0_2.Background = Brushes.LightGreen;
                if (button2_0.Content == "X")
                {
                    infoButton.Content = "Player 'X' win!!!";
                }
                else
                {
                    infoButton.Content = "Player 'O' win!!!";
                }
                return true;
            }
            else if (button0_0.Content == button1_1.Content && button1_1.Content == button2_2.Content && button2_2.Content != string.Empty)
            {
                button0_0.Background = Brushes.LightGreen;
                button1_1.Background = Brushes.LightGreen;
                button2_2.Background = Brushes.LightGreen;
                if (button0_0.Content == "X")
                {
                    infoButton.Content = "Player 'X' win!!!";
                }
                else
                {
                    infoButton.Content = "Player 'O' win!!!";
                }
                return true;
            }
            return false;
        }
    }
}
