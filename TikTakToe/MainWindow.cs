using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TikTakToe
{
    public partial class MainWindow : Form
    {

        Button[,] matrix_x_btns = new Button[3, 3];

        Button[,] matrix_O_btns = new Button[3, 3];

        Label[,] matrix_labels = new Label[3, 3];

        int[,] matrix_x_o = new int[3, 3];

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnx_Click(object sender, EventArgs e)
        {
            // who was clicked?
            int row_clicked = 0;
            int col_clicked = 0;
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (matrix_x_btns[row, col] == sender)
                    {
                        row_clicked = row;
                        col_clicked = col;
                        break;
                    }
                }
            }

            // change elements 
            matrix_labels[row_clicked, col_clicked].Text = "X";
            matrix_x_btns[row_clicked, col_clicked].Enabled = false;
            matrix_O_btns[row_clicked, col_clicked].Enabled = false;
            matrix_x_o[row_clicked, col_clicked] = 1;

            // calculate
            Calculate();
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            // who was clicked?
            int row_clicked = 0;
            int col_clicked = 0;
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (matrix_O_btns[row, col] == sender)
                    {
                        row_clicked = row;
                        col_clicked = col;
                        break;
                    }
                }
            }

            // change elements 
            matrix_labels[row_clicked, col_clicked].Text = "O";
            matrix_x_btns[row_clicked, col_clicked].Enabled = false;
            matrix_O_btns[row_clicked, col_clicked].Enabled = false;
            matrix_x_o[row_clicked, col_clicked] = 2;

            // calculate
            Calculate();
        }

        private int CheckWinning(int value1, int value2, int value3)
        {
            if (value1 == value2 && value2 == value3)
            {
                return value1;
            }
            return 0;
        }

        private void NewGame()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    matrix_x_btns[row, col].Enabled = true;
                    matrix_O_btns[row, col].Enabled = true;
                    matrix_labels[row, col].Text = "?";
                    matrix_x_o[row, col] = 0;
                }
            }
        }

        private void Calculate()
        {
            // is there a winning ?
            // check if there is a winning in rows...
            for (int i = 0; i < 3; i++)
            {
                int result = CheckWinning(matrix_x_o[i, 0], matrix_x_o[i, 1], matrix_x_o[i, 2]);
                if (result == 0)
                {
                    result = CheckWinning(matrix_x_o[0, i], matrix_x_o[1, i], matrix_x_o[2, i]);
                }
                if (result > 0)
                {
                    if (result == 1)
                        MessageBox.Show("X won!");
                    if (result == 2)
                        MessageBox.Show("O won!");

                    NewGame();

                    return;
                }
            }

            int result_diag = CheckWinning(matrix_x_o[0, 0], matrix_x_o[1, 1], matrix_x_o[2, 2]);
            if (result_diag == 0)
            {
                result_diag = CheckWinning(matrix_x_o[0, 2], matrix_x_o[1, 1], matrix_x_o[2, 0]);
            }
            if (result_diag > 0)
            {
                if (result_diag == 1)
                    MessageBox.Show("X won!");
                if (result_diag == 2)
                    MessageBox.Show("O won!");

                NewGame();

                return;
            }

            // is game over because all elements are taken ...
            bool game_over = true;
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (matrix_x_o[row, col] == 0)
                    {
                        game_over = false;
                        break;
                    }
                }
            }

            if (game_over)
            {
                MessageBox.Show("Game over");
                NewGame();
            }

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            matrix_x_btns[0, 0] = btnx00;
            matrix_x_btns[0, 1] = btnx01;
            matrix_x_btns[0, 2] = btnx02;
            matrix_x_btns[1, 0] = btnx10;
            matrix_x_btns[1, 1] = btnx11;
            matrix_x_btns[1, 2] = btnx12;
            matrix_x_btns[2, 0] = btnx20;
            matrix_x_btns[2, 1] = btnx21;
            matrix_x_btns[2, 2] = btnx22;

            matrix_O_btns[0, 0] = btnO00;
            matrix_O_btns[0, 1] = btnO01;
            matrix_O_btns[0, 2] = btnO02;
            matrix_O_btns[1, 0] = btnO10;
            matrix_O_btns[1, 1] = btnO11;
            matrix_O_btns[1, 2] = btnO12;
            matrix_O_btns[2, 0] = btnO20;
            matrix_O_btns[2, 1] = btnO21;
            matrix_O_btns[2, 2] = btnO22;

            matrix_labels[0, 0] = lbl00;
            matrix_labels[0, 1] = lbl01;
            matrix_labels[0, 2] = lbl02;
            matrix_labels[1, 0] = lbl10;
            matrix_labels[1, 1] = lbl11;
            matrix_labels[1, 2] = lbl12;
            matrix_labels[2, 0] = lbl20;
            matrix_labels[2, 1] = lbl21;
            matrix_labels[2, 2] = lbl22;
        }
    }
}
