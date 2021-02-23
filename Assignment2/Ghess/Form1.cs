using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace Ghess
{
    public partial class Chess : Form
    {
        private Point point;
        bool move,stopBisActive,stopWisActive;
        int totalSeconds,hoursInput,minutesInput,secondsInput,timeW,timeB;
        DataReader mydatareader;
        public Chess()
        {
            InitializeComponent();

            menupanel.Visible = true;
            chessPanel.Visible = false;
            foreach (Piece piece in boardPanel.Controls.OfType<Piece>())
            {
                piece.InitialLocation = piece.Location; //saves the location of the pieces
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            bool flag = false;

            DataEntry mydataentry = new DataEntry();
       

            if (board0.Checked && Player1Txtb.TextLength >= 1 && Player2Txtb.TextLength >= 1)
            {
                boardPanel.BackgroundImage = Properties.Resources.board_0;
                flag = true;
            }
            else if (board1.Checked && Player1Txtb.TextLength >= 1 && Player2Txtb.TextLength >= 1)
            {
                boardPanel.BackgroundImage = Properties.Resources.board_1;
                flag = true;

            }
            else if (board2.Checked && Player1Txtb.TextLength >= 1 && Player2Txtb.TextLength >= 1)
            {
                boardPanel.BackgroundImage = Properties.Resources.board_2;
                flag = true;

            }
            else if (board3.Checked && Player1Txtb.TextLength >= 1 && Player2Txtb.TextLength >= 1)
            {
                 boardPanel.BackgroundImage = Properties.Resources.board_3;
                 flag = true;

            }
            else
            {
                 error.Visible = true;

            }

            try
            {
                hoursInput = Int32.Parse(hoursTxtB.Text);
                minutesInput = Int32.Parse(minutesTxtB.Text);
                secondsInput = Int32.Parse(secondsTxtB.Text);
                totalSeconds = (hoursInput * 60 * 60) + (minutesInput * 60) + (secondsInput);

                int hours = totalSeconds / 3600; //convert to the actual time.
                int min = (totalSeconds - (hours * 3600)) / 60;
                int sec = (totalSeconds - (hours * 3600) - (min * 60));
                timeB = totalSeconds;
                timeW = totalSeconds;
                timer1.Enabled = true;
                timeBLbl.Text = hours.ToString() + ":" + min.ToString() + ":" + sec.ToString(); 
                timeWLbl.Text = hours.ToString() + ":" + min.ToString() + ":" + sec.ToString();
            }
            catch (FormatException er)
            {
                Console.WriteLine(er.Message);
                flag = false;
                error.Visible = true;
            }
            
            if (flag)
            {
                foreach (Piece piece in boardPanel.Controls.OfType<Piece>())
                {
                    piece.Location = piece.InitialLocation; //resets the location of the pieces
                }
                menupanel.Visible = false;
                chessPanel.Visible = true;
                mydataentry.InsertData(Player1Txtb.Text, Player2Txtb.Text, "Data Source = chessDB.db;Version=3;");
                stopBisActive = true;
                stopWisActive = false;

            }

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            int hours,min,sec;
            if(timeB > 0 && stopWisActive) 
            {
                timeB--;
                hours = timeB / 3600;
                min = (timeB - (hours * 3600)) / 60;
                sec = (timeB - (hours * 3600) - (min * 60));
                timeBLbl.Text = hours.ToString() + ":" + min.ToString() + ":" + sec.ToString();
            }
            else if (timeW>0 && stopBisActive)
            {
                timeW--;
                hours = timeW / 3600;
                min = (timeW - (hours * 3600)) / 60;
                sec = (timeW - (hours * 3600) - (min * 60));
                timeWLbl.Text = hours.ToString() + ":" + min.ToString() + ":" + sec.ToString();
            }
            else
            {
                endGameLbl.Visible = true;
                timer1.Enabled = false;
                stopBisActive = false;
                stopWisActive = false;
            }

        }

        private void stopB_Click(object sender, EventArgs e)
        {
            stopBisActive = true;
            stopWisActive = false;
        }

        private void stopW_Click(object sender, EventArgs e)
        {
            stopBisActive = false;
            stopWisActive = true;
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            menupanel.Visible = true;
            chessPanel.Visible = false;
            stopBisActive = false;
            stopWisActive = false;
            endGameLbl.Visible = false;
        }

        private void giveUpBbtn_Click(object sender, EventArgs e)
        {
            endGameLbl.Visible = true;
            timer1.Enabled = false;
            stopBisActive = false;
            stopWisActive = false;
        }

        private void giveUpWbtn_Click(object sender, EventArgs e)
        {
            endGameLbl.Visible = true;
            timer1.Enabled = false;
            stopBisActive = false;
            stopWisActive = false;
        }

        public class DataEntry
        {
            public String Player1 { get; set; }
            public String Player2 { get; set; }
            public String Date { get; set; }
            public void InsertData (String player1, String player2, String connectionstring)
            {
                Player1 = player1;
                Player2 = player2;
                Date = DateTime.Now.ToString();
                SQLiteConnection conn = new SQLiteConnection(connectionstring);
                conn.Open();
                String insertQuery = "Insert into Games(player1,player2,date) values('" + Player1 + "','" + Player2 + "','" + Date + "')";
                SQLiteCommand mycommand = new SQLiteCommand(insertQuery, conn);
                mycommand.ExecuteNonQuery();
                conn.Close();
            }

        }

        public class DataReader
        {   
            public void ReadData(string connectionString,DataGridView aDataGridView)
            {
                SQLiteConnection conn = new SQLiteConnection(connectionString);
                conn.Open();
                String querycommand = "Select * from Games";
                SQLiteCommand cmd = new SQLiteCommand(querycommand,conn);
                SQLiteDataAdapter sda = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                aDataGridView.AutoResizeColumns();
                aDataGridView.AutoSize = true;
                aDataGridView.DataSource = dt;

            }
        }

        private void playerListBtn_Click(object sender, EventArgs e)
        {
            mydatareader = new DataReader();
            mydatareader.ReadData("Data Source = chessDB.db;Version=3;", dataGridView1);
            playerlistPanel.Visible = true;
            menupanel.Visible = false;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            menupanel.Visible = true;
            playerlistPanel.Visible = false;
        }

       
        private void PawnW1_MouseDown(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).BringToFront();
            point = e.Location;
            move = true;
        }

        private void PawnW1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void PawnW1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                ((PictureBox)sender).Location = new Point(((PictureBox)sender).Left + e.X - point.X, ((PictureBox)sender).Top + e.Y - point.Y);
            }
        }
        public class Piece : PictureBox
        {
          public  Point InitialLocation { get; set; }
          
        }
    }

}

