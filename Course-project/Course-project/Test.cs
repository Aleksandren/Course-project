//Медведский А.В. 52492 Трансляция и вычисление произвольных арифметических выражений. 
// Форма с тестами.

using System;
using System.Windows.Forms;

namespace Course_project
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        int iquestion;

        private void btn_next_Click(object sender, EventArgs e)
        {
            btn_clock.Visible = true;
            btn_clock.Enabled = true;
            iquestion = iquestion + 1;

            {
                switch (iquestion)
                {
                    case 2:
                        iquestion = 2;
                        btn_next.Text = Convert.ToString(iquestion);
                        groupBox_Inform.Visible = false;
                        groupBox_Question2.Visible = true;
                        groupBox_Question3.Visible = false;
                        groupBox_Question4.Visible = false;
                        groupBox_Question5.Visible = false;
                        groupBox_TestOver.Visible = false;
                        break;

                    case 3:
                        iquestion = 3;
                        btn_next.Text = Convert.ToString(iquestion);
                        groupBox_Inform.Visible = false;
                        groupBox_Question2.Visible = false;
                        groupBox_Question3.Visible = true;
                        groupBox_Question4.Visible = false;
                        groupBox_Question5.Visible = false;
                        groupBox_TestOver.Visible = false;
                        break;

                    case 4:
                        iquestion = 4;
                        btn_next.Text = Convert.ToString(iquestion);
                        groupBox_Inform.Visible = false;
                        groupBox_Question2.Visible = false;
                        groupBox_Question3.Visible = false;
                        groupBox_Question4.Visible = true;
                        groupBox_Question5.Visible = false;
                        groupBox_TestOver.Visible = false;
                        break;

                    case 5:
                        iquestion = 5;
                        btn_next.Text = Convert.ToString(iquestion);
                        groupBox_Inform.Visible = false;
                        groupBox_Question2.Visible = false;
                        groupBox_Question3.Visible = false;
                        groupBox_Question4.Visible = false;
                        groupBox_Question5.Visible = true;
                        groupBox_TestOver.Visible = false;
                        break;

                    case 6:
                        iquestion = 6;
                        btn_next.Text = Convert.ToString(iquestion);
                        groupBox_Inform.Visible = false;
                        groupBox_Question2.Visible = false;
                        groupBox_Question3.Visible = false;
                        groupBox_Question4.Visible = false;
                        groupBox_Question5.Visible = false;
                        groupBox_TestOver.Visible = true;
                        break;
                }
            }
        }

        private void btn_startTest_Click(object sender, EventArgs e)
        {
            groupBox_Question1.Visible = true;
            btn_clock.Enabled = true;
            btn_timer.Visible = false;
            timer1.Start();
            btn_next.Enabled = true;
            btn_back.Enabled = true;
            btn_clock.Enabled = true;
            iquestion = 1;
            btn_next.Text = Convert.ToString(iquestion);
        }

        private void Test_Load(object sender, EventArgs e)
        {
            groupBox_Inform.Visible = true;
            groupBox_Question1.Visible = false;
            groupBox_Question2.Visible = false;
            groupBox_Question3.Visible = false;
            groupBox_Question4.Visible = false;
            groupBox_Question5.Visible = false;
            btn_timer.Visible = false;
            timer1.Stop();
            btn_next.Enabled = false;
            btn_back.Enabled = false;
            btn_clock.Enabled = false;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите выйти?", "Закрыть программу", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        int count = 300;
        private void timer1_Tick(object sender, EventArgs e)
        {
            count--;
            lbl_Timer.Text = "Времени осталось: " + count.ToString();
        }

        private void btn_clock_Click(object sender, EventArgs e)
        {
            btn_timer.Visible = true;
            lbl_Timer.Visible = true;
            btn_clock.Visible = false;

        }

        private void btn_timer_Click(object sender, EventArgs e)
        {
            btn_timer.Visible = false;
            lbl_Timer.Visible = false;
            btn_clock.Visible = true;
        }

        private void btn_review_Click(object sender, EventArgs e)
        {
            iquestion = 1;
            btn_back.Text = Convert.ToString(iquestion);
            groupBox_Question2.Visible = true;
            groupBox_Question3.Visible = false;
            groupBox_Question4.Visible = false;
            groupBox_Question5.Visible = false;
            groupBox_TestOver.Visible = false;
            btn_next.Text = Convert.ToString(iquestion);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            iquestion = iquestion - 1;

            {
                switch (iquestion)
                {
                    case 1:
                        iquestion = 1;
                        btn_next.Text = Convert.ToString(iquestion);
                        groupBox_Inform.Visible = false;
                        groupBox_Question1.Visible = true;
                        groupBox_Question2.Visible = false;
                        groupBox_Question3.Visible = false;
                        groupBox_Question4.Visible = false;
                        groupBox_Question5.Visible = false;
                        groupBox_TestOver.Visible = false;
                        break;

                    case 2:
                        iquestion = 2;
                        btn_next.Text = Convert.ToString(iquestion);
                        groupBox_Inform.Visible = false;
                        groupBox_Question2.Visible = true;
                        groupBox_Question3.Visible = false;
                        groupBox_Question4.Visible = false;
                        groupBox_Question5.Visible = false;
                        groupBox_TestOver.Visible = false;
                        break;

                    case 3:
                        iquestion = 3;
                        btn_next.Text = Convert.ToString(iquestion);
                        groupBox_Inform.Visible = false;
                        groupBox_Question2.Visible = false;
                        groupBox_Question3.Visible = true;
                        groupBox_Question4.Visible = false;
                        groupBox_Question5.Visible = false;
                        groupBox_TestOver.Visible = false;
                        break;

                    case 4:
                        iquestion = 4;
                        btn_next.Text = Convert.ToString(iquestion);
                        groupBox_Inform.Visible = false;
                        groupBox_Question2.Visible = false;
                        groupBox_Question3.Visible = false;
                        groupBox_Question4.Visible = true;
                        groupBox_Question5.Visible = false;
                        groupBox_TestOver.Visible = false;
                        break;

                    case 5:
                        iquestion = 5;
                        btn_next.Text = Convert.ToString(iquestion);
                        groupBox_Inform.Visible = false;
                        groupBox_Question2.Visible = false;
                        groupBox_Question3.Visible = false;
                        groupBox_Question4.Visible = false;
                        groupBox_Question5.Visible = true;
                        groupBox_TestOver.Visible = false;
                        break;

                    case 6:
                        iquestion = 6;
                        btn_next.Text = Convert.ToString(iquestion);
                        groupBox_Inform.Visible = false;
                        groupBox_Question2.Visible = false;
                        groupBox_Question3.Visible = false;
                        groupBox_Question4.Visible = false;
                        groupBox_Question5.Visible = false;
                        groupBox_TestOver.Visible = true;
                        break;
                }
            }
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            int ResultPoint = 0;

            if (checkBox_ex1_true.Checked == true)
            {
                checkBox_res1.Checked = true;
                ResultPoint = 20;
                lbl_Result.Text = Convert.ToString(ResultPoint);
            }

            if (checkBox_ex2_true.Checked == true)
            {
                checkBox_res2.Checked = true;
                ResultPoint = ResultPoint + 20;
                lbl_Result.Text = Convert.ToString(ResultPoint);
            }

            if (checkBox_ex3_true.Checked == true)
            {
                checkBox_res3.Checked = true;
                ResultPoint = ResultPoint + 20;
                lbl_Result.Text = Convert.ToString(ResultPoint);
            }

            if (textBox_ex4.Text == "1 2 + 4 * 3 +")
            {
                checkBox_res4.Checked = true;
                ResultPoint = ResultPoint + 20;
                lbl_Result.Text = Convert.ToString(ResultPoint);
            }

            if (textBox_ex5.Text == "19")
            {
                checkBox_res5.Checked = true;
                ResultPoint = ResultPoint + 20;
                lbl_Result.Text = Convert.ToString(ResultPoint);
            }

            groupBox_TestOver.Visible = false;
            groupBox_Result.Visible = true;
        }

        private void btn_resOK_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
