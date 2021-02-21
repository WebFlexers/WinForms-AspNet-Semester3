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
    public partial class Form1 : Form
    {
        private Point point;
        bool move,stopBisActive,stopWisActive;
        int totalSeconds,hoursInput,minutesInput,secondsInput,timeW,timeB;
        DataReader mydatareader;
        public Form1()
        {
            InitializeComponent();

            menupanel.Visible = true;
            chessPanel.Visible = false;
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
                menupanel.Visible = false;
                chessPanel.Visible = true;
                mydataentry.InsertData(Player1Txtb.Text, Player2Txtb.Text, "Data Source = chessDB.db;Version=3;");


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
            else
            {
                timeW--;
                hours = timeW / 3600;
                min = (timeW - (hours * 3600)) / 60;
                sec = (timeW - (hours * 3600) - (min * 60));
                timeWLbl.Text = hours.ToString() + ":" + min.ToString() + ":" + sec.ToString();
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
                PawnW1.Location = new Point(PawnW1.Left + e.X - point.X, PawnW1.Top + e.Y - point.Y);
            }
        }

        private void PawnW2_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            move = true;
        }

        private void PawnW3_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            move = true;
        }

        private void PawnW4_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            move = true;
        }

        private void PawnW5_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            move = true;
        }

        private void PawnW6_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            move = true;
        }

        private void PawnW7_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            move = true;
        }

        private void PawnW8_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            move = true;
        }

        private void RookW1_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            move = true;
        }

        private void KnightW1_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            move = true;
        }

        private void BishopW1_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            move = true;
        }

        private void QueenW_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            move = true;
        }


        private void BishopW2_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            move = true;
        }

        private void KnightW2_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            move = true;
        }

        private void RookW2_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            move = true;
        }

        private void PawnB1_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            move = true;
        }

        private void PawnB2_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            move = true;
        }

        private void PawnB3_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            move = true;
        }

        private void PawnB4_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            move = true;
        }

        private void PawnB5_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            move = true;
        }

        private void PawnB6_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            move = true;
        }

        private void PawnB7_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            move = true;
        }

        private void PawnB8_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            move = true;
        }

        private void RookB1_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            move = true;
        }

        private void KnightB1_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            move = true;
        }

        private void BishopB1_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            move = true;
        }

        private void KingB_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            move = true;
        }

        private void QueenB_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            move = true;
        }

        private void BishopB2_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            move = true;
        }

        private void KnightB2_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            move = true;
        }

        private void RookB2_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            move = true;
        }

        private void PawnW2_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void PawnW3_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void PawnW4_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void PawnW5_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void PawnW6_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void PawnW7_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void PawnW8_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void RookW1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void KnightW1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void BishopW1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void QueenW_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }


        private void BishopW2_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void KnightW2_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void RookW2_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void PawnB1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void PawnB2_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void PawnB3_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void PawnB4_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void PawnB5_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void PawnB6_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void PawnB7_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void PawnB8_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void RookB1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void KnightB1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void BishopB1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void KingB_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void QueenB_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void BishopB2_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void KnightB2_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void RookB2_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void PawnW2_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                PawnW2.Location = new Point(PawnW2.Left + e.X - point.X, PawnW2.Top + e.Y - point.Y);
            }
        }

        private void PawnW3_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                PawnW3.Location = new Point(PawnW3.Left + e.X - point.X, PawnW3.Top + e.Y - point.Y);
            }
        }

        private void PawnW4_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                PawnW4.Location = new Point(PawnW4.Left + e.X - point.X, PawnW4.Top + e.Y - point.Y);
            }
        }

        private void PawnW5_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                PawnW5.Location = new Point(PawnW5.Left + e.X - point.X, PawnW5.Top + e.Y - point.Y);
            }
        }

        private void PawnW6_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                PawnW6.Location = new Point(PawnW6.Left + e.X - point.X, PawnW6.Top + e.Y - point.Y);
            }
        }

        private void PawnW7_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                PawnW7.Location = new Point(PawnW7.Left + e.X - point.X, PawnW7.Top + e.Y - point.Y);
            }
        }

        private void PawnW8_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                PawnW8.Location = new Point(PawnW8.Left + e.X - point.X, PawnW8.Top + e.Y - point.Y);
            }
        }

        private void RookW1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                RookW1.Location = new Point(RookW1.Left + e.X - point.X, RookW1.Top + e.Y - point.Y);
            }
        }

        private void KnightW1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                KnightW1.Location = new Point(KnightW1.Left + e.X - point.X, KnightW1.Top + e.Y - point.Y);
            }
        }

        private void BishopW1_MouseMove(object sender, MouseEventArgs e)
        {

            if (move)
            {
                BishopW1.Location = new Point(BishopW1.Left + e.X - point.X, BishopW1.Top + e.Y - point.Y);
            }
        }

        private void QueenW_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                QueenW.Location = new Point(QueenW.Left + e.X - point.X, QueenW.Top + e.Y - point.Y);
            }
        }


        private void BishopW2_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                BishopW2.Location = new Point(BishopW2.Left + e.X - point.X, BishopW2.Top + e.Y - point.Y);
            }
        }

        private void KnightW2_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                KnightW2.Location = new Point(KnightW2.Left + e.X - point.X, KnightW2.Top + e.Y - point.Y);
            }
        }

        private void RookW2_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                RookW2.Location = new Point(RookW2.Left + e.X - point.X, RookW2.Top + e.Y - point.Y);
            }
        }

        private void PawnB1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                PawnB1.Location = new Point(PawnB1.Left + e.X - point.X, PawnB1.Top + e.Y - point.Y);
            }
        }

        private void PawnB2_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                PawnB2.Location = new Point(PawnB2.Left + e.X - point.X, PawnB2.Top + e.Y - point.Y);
            }
        }

        private void PawnB3_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                PawnB3.Location = new Point(PawnB3.Left + e.X - point.X, PawnB3.Top + e.Y - point.Y);
            }
        }

        private void PawnB4_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                PawnB4.Location = new Point(PawnB4.Left + e.X - point.X, PawnB4.Top + e.Y - point.Y);
            }
        }

        private void PawnB5_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                PawnB5.Location = new Point(PawnB5.Left + e.X - point.X, PawnB5.Top + e.Y - point.Y);
            }
        }

        private void PawnB6_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                PawnB6.Location = new Point(PawnB6.Left + e.X - point.X, PawnB6.Top + e.Y - point.Y);
            }
        }

        private void PawnB7_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                PawnB7.Location = new Point(PawnB7.Left + e.X - point.X, PawnB7.Top + e.Y - point.Y);
            }
        }

        private void PawnB8_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                PawnB8.Location = new Point(PawnB8.Left + e.X - point.X, PawnB8.Top + e.Y - point.Y);
            }
        }

        private void RookB1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                RookB1.Location = new Point(RookB1.Left + e.X - point.X, RookB1.Top + e.Y - point.Y);
            }
        }

        private void KnightB1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                KnightB1.Location = new Point(KnightB1.Left + e.X - point.X, KnightB1.Top + e.Y - point.Y);
            }
        }

        private void BishopB1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                BishopB1.Location = new Point(BishopB1.Left + e.X - point.X, BishopB1.Top + e.Y - point.Y);
            }
        }

        private void KingB_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                KingB.Location = new Point(KingB.Left + e.X - point.X, KingB.Top + e.Y - point.Y);
            }
        }

   

        private void QueenB_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                QueenB.Location = new Point(QueenB.Left + e.X - point.X, QueenB.Top + e.Y - point.Y);
            }
        }

        private void BishopB2_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                BishopB2.Location = new Point(BishopB2.Left + e.X - point.X, BishopB2.Top + e.Y - point.Y);
            }
        }

    

        private void KnightB2_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                KnightB2.Location = new Point(KnightB2.Left + e.X - point.X, KnightB2.Top + e.Y - point.Y);
            }
        }

        private void RookB2_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                RookB2.Location = new Point(RookB2.Left + e.X - point.X, RookB2.Top + e.Y - point.Y);
            }
        }

   

        private void KingW_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            move = true;
        }

        private void KingW_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void KingW_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                King.Location = new Point(King.Left + e.X - point.X, King.Top + e.Y - point.Y);
            }
        }
    }
}
