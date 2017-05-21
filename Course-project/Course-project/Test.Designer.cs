namespace Course_project
{
    partial class Test
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox_Interface = new System.Windows.Forms.GroupBox();
            this.btn_timer = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_clock = new System.Windows.Forms.Button();
            this.groupBox_Inform = new System.Windows.Forms.GroupBox();
            this.btn_startTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Question3 = new System.Windows.Forms.GroupBox();
            this.checkBox_ex3_false3 = new System.Windows.Forms.CheckBox();
            this.checkBox_ex3_true = new System.Windows.Forms.CheckBox();
            this.checkBox_ex3_false2 = new System.Windows.Forms.CheckBox();
            this.checkBox_ex3_false1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox_Question1 = new System.Windows.Forms.GroupBox();
            this.checkBox_ex1_false1 = new System.Windows.Forms.CheckBox();
            this.checkBox_ex1_false2 = new System.Windows.Forms.CheckBox();
            this.checkBox_ex1_true = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_Result = new System.Windows.Forms.GroupBox();
            this.btn_resOK = new System.Windows.Forms.Button();
            this.checkBox_res5 = new System.Windows.Forms.CheckBox();
            this.checkBox_res4 = new System.Windows.Forms.CheckBox();
            this.checkBox_res1 = new System.Windows.Forms.CheckBox();
            this.checkBox_res3 = new System.Windows.Forms.CheckBox();
            this.checkBox_res2 = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox_Question2 = new System.Windows.Forms.GroupBox();
            this.checkBox_ex2_false3 = new System.Windows.Forms.CheckBox();
            this.checkBox_ex2_false1 = new System.Windows.Forms.CheckBox();
            this.checkBox_ex2_false2 = new System.Windows.Forms.CheckBox();
            this.checkBox_ex2_true = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox_Question5 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox_Question4 = new System.Windows.Forms.GroupBox();
            this.textBox_ex4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox_TestOver = new System.Windows.Forms.GroupBox();
            this.btn_check = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_Timer = new System.Windows.Forms.Label();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.textBox_ex5 = new System.Windows.Forms.TextBox();
            this.lbl_ex5 = new System.Windows.Forms.Label();
            this.groupBox_Interface.SuspendLayout();
            this.groupBox_Inform.SuspendLayout();
            this.groupBox_Question3.SuspendLayout();
            this.groupBox_Question1.SuspendLayout();
            this.groupBox_Result.SuspendLayout();
            this.groupBox_Question2.SuspendLayout();
            this.groupBox_Question5.SuspendLayout();
            this.groupBox_Question4.SuspendLayout();
            this.groupBox_TestOver.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox_Interface
            // 
            this.groupBox_Interface.Controls.Add(this.btn_timer);
            this.groupBox_Interface.Controls.Add(this.btn_exit);
            this.groupBox_Interface.Controls.Add(this.btn_next);
            this.groupBox_Interface.Controls.Add(this.btn_back);
            this.groupBox_Interface.Controls.Add(this.btn_clock);
            this.groupBox_Interface.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Interface.Name = "groupBox_Interface";
            this.groupBox_Interface.Size = new System.Drawing.Size(895, 155);
            this.groupBox_Interface.TabIndex = 0;
            this.groupBox_Interface.TabStop = false;
            // 
            // btn_timer
            // 
            this.btn_timer.Location = new System.Drawing.Point(195, 38);
            this.btn_timer.Name = "btn_timer";
            this.btn_timer.Size = new System.Drawing.Size(82, 80);
            this.btn_timer.TabIndex = 10;
            this.btn_timer.Text = "Таймер";
            this.btn_timer.UseVisualStyleBackColor = true;
            this.btn_timer.Click += new System.EventHandler(this.btn_timer_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(626, 38);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(82, 80);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Выход";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(481, 38);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(82, 80);
            this.btn_next.TabIndex = 6;
            this.btn_next.Text = "Следую";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(345, 38);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(82, 80);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "назад";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_clock
            // 
            this.btn_clock.Location = new System.Drawing.Point(195, 38);
            this.btn_clock.Name = "btn_clock";
            this.btn_clock.Size = new System.Drawing.Size(82, 80);
            this.btn_clock.TabIndex = 2;
            this.btn_clock.Text = "Таймер";
            this.btn_clock.UseVisualStyleBackColor = true;
            this.btn_clock.Click += new System.EventHandler(this.btn_clock_Click);
            // 
            // groupBox_Inform
            // 
            this.groupBox_Inform.Controls.Add(this.btn_startTest);
            this.groupBox_Inform.Controls.Add(this.label1);
            this.groupBox_Inform.Location = new System.Drawing.Point(15, 179);
            this.groupBox_Inform.Name = "groupBox_Inform";
            this.groupBox_Inform.Size = new System.Drawing.Size(892, 470);
            this.groupBox_Inform.TabIndex = 1;
            this.groupBox_Inform.TabStop = false;
            // 
            // btn_startTest
            // 
            this.btn_startTest.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_startTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_startTest.Location = new System.Drawing.Point(717, 315);
            this.btn_startTest.Name = "btn_startTest";
            this.btn_startTest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_startTest.Size = new System.Drawing.Size(82, 80);
            this.btn_startTest.TabIndex = 10;
            this.btn_startTest.Text = "Начать";
            this.btn_startTest.UseVisualStyleBackColor = true;
            this.btn_startTest.Click += new System.EventHandler(this.btn_startTest_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(711, 254);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // groupBox_Question3
            // 
            this.groupBox_Question3.Controls.Add(this.checkBox_ex3_false3);
            this.groupBox_Question3.Controls.Add(this.checkBox_ex3_true);
            this.groupBox_Question3.Controls.Add(this.checkBox_ex3_false2);
            this.groupBox_Question3.Controls.Add(this.checkBox_ex3_false1);
            this.groupBox_Question3.Controls.Add(this.label7);
            this.groupBox_Question3.Controls.Add(this.label6);
            this.groupBox_Question3.Location = new System.Drawing.Point(15, 179);
            this.groupBox_Question3.Name = "groupBox_Question3";
            this.groupBox_Question3.Size = new System.Drawing.Size(892, 470);
            this.groupBox_Question3.TabIndex = 12;
            this.groupBox_Question3.TabStop = false;
            this.groupBox_Question3.Visible = false;
            // 
            // checkBox_ex3_false3
            // 
            this.checkBox_ex3_false3.AutoSize = true;
            this.checkBox_ex3_false3.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_ex3_false3.Location = new System.Drawing.Point(122, 313);
            this.checkBox_ex3_false3.Name = "checkBox_ex3_false3";
            this.checkBox_ex3_false3.Size = new System.Drawing.Size(95, 33);
            this.checkBox_ex3_false3.TabIndex = 24;
            this.checkBox_ex3_false3.Text = "1926";
            this.checkBox_ex3_false3.UseVisualStyleBackColor = true;
            // 
            // checkBox_ex3_true
            // 
            this.checkBox_ex3_true.AutoSize = true;
            this.checkBox_ex3_true.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_ex3_true.Location = new System.Drawing.Point(122, 196);
            this.checkBox_ex3_true.Name = "checkBox_ex3_true";
            this.checkBox_ex3_true.Size = new System.Drawing.Size(95, 33);
            this.checkBox_ex3_true.TabIndex = 21;
            this.checkBox_ex3_true.Text = "1920";
            this.checkBox_ex3_true.UseVisualStyleBackColor = true;
            // 
            // checkBox_ex3_false2
            // 
            this.checkBox_ex3_false2.AutoSize = true;
            this.checkBox_ex3_false2.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_ex3_false2.Location = new System.Drawing.Point(122, 274);
            this.checkBox_ex3_false2.Name = "checkBox_ex3_false2";
            this.checkBox_ex3_false2.Size = new System.Drawing.Size(95, 33);
            this.checkBox_ex3_false2.TabIndex = 23;
            this.checkBox_ex3_false2.Text = "1934";
            this.checkBox_ex3_false2.UseVisualStyleBackColor = true;
            // 
            // checkBox_ex3_false1
            // 
            this.checkBox_ex3_false1.AutoSize = true;
            this.checkBox_ex3_false1.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_ex3_false1.Location = new System.Drawing.Point(122, 235);
            this.checkBox_ex3_false1.Name = "checkBox_ex3_false1";
            this.checkBox_ex3_false1.Size = new System.Drawing.Size(95, 33);
            this.checkBox_ex3_false1.TabIndex = 22;
            this.checkBox_ex3_false1.Text = "1900";
            this.checkBox_ex3_false1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(117, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(664, 88);
            this.label7.TabIndex = 20;
            this.label7.Text = "В каком году была предложена постфиксная нотация?";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(0, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(895, 39);
            this.label6.TabIndex = 2;
            this.label6.Text = "Задание 3";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_Question1
            // 
            this.groupBox_Question1.Controls.Add(this.checkBox_ex1_false1);
            this.groupBox_Question1.Controls.Add(this.checkBox_ex1_false2);
            this.groupBox_Question1.Controls.Add(this.checkBox_ex1_true);
            this.groupBox_Question1.Controls.Add(this.label3);
            this.groupBox_Question1.Controls.Add(this.label2);
            this.groupBox_Question1.Location = new System.Drawing.Point(15, 179);
            this.groupBox_Question1.Name = "groupBox_Question1";
            this.groupBox_Question1.Size = new System.Drawing.Size(892, 470);
            this.groupBox_Question1.TabIndex = 11;
            this.groupBox_Question1.TabStop = false;
            this.groupBox_Question1.Visible = false;
            // 
            // checkBox_ex1_false1
            // 
            this.checkBox_ex1_false1.AutoSize = true;
            this.checkBox_ex1_false1.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_ex1_false1.Location = new System.Drawing.Point(73, 158);
            this.checkBox_ex1_false1.Name = "checkBox_ex1_false1";
            this.checkBox_ex1_false1.Size = new System.Drawing.Size(260, 33);
            this.checkBox_ex1_false1.TabIndex = 17;
            this.checkBox_ex1_false1.Text = "Запись вида + a b";
            this.checkBox_ex1_false1.UseVisualStyleBackColor = true;
            // 
            // checkBox_ex1_false2
            // 
            this.checkBox_ex1_false2.AutoSize = true;
            this.checkBox_ex1_false2.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_ex1_false2.Location = new System.Drawing.Point(73, 236);
            this.checkBox_ex1_false2.Name = "checkBox_ex1_false2";
            this.checkBox_ex1_false2.Size = new System.Drawing.Size(260, 33);
            this.checkBox_ex1_false2.TabIndex = 19;
            this.checkBox_ex1_false2.Text = "Запись вида a + b";
            this.checkBox_ex1_false2.UseVisualStyleBackColor = true;
            // 
            // checkBox_ex1_true
            // 
            this.checkBox_ex1_true.AutoSize = true;
            this.checkBox_ex1_true.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_ex1_true.Location = new System.Drawing.Point(73, 197);
            this.checkBox_ex1_true.Name = "checkBox_ex1_true";
            this.checkBox_ex1_true.Size = new System.Drawing.Size(260, 33);
            this.checkBox_ex1_true.TabIndex = 18;
            this.checkBox_ex1_true.Text = "Запись вида a b +";
            this.checkBox_ex1_true.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(68, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(561, 46);
            this.label3.TabIndex = 16;
            this.label3.Text = "Что такое постфиксная запись?";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(0, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(895, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Задание 1 ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_Result
            // 
            this.groupBox_Result.Controls.Add(this.lbl_Result);
            this.groupBox_Result.Controls.Add(this.btn_resOK);
            this.groupBox_Result.Controls.Add(this.checkBox_res5);
            this.groupBox_Result.Controls.Add(this.checkBox_res4);
            this.groupBox_Result.Controls.Add(this.checkBox_res1);
            this.groupBox_Result.Controls.Add(this.checkBox_res3);
            this.groupBox_Result.Controls.Add(this.checkBox_res2);
            this.groupBox_Result.Controls.Add(this.label12);
            this.groupBox_Result.Location = new System.Drawing.Point(15, 179);
            this.groupBox_Result.Name = "groupBox_Result";
            this.groupBox_Result.Size = new System.Drawing.Size(892, 470);
            this.groupBox_Result.TabIndex = 16;
            this.groupBox_Result.TabStop = false;
            this.groupBox_Result.Visible = false;
            // 
            // btn_resOK
            // 
            this.btn_resOK.Location = new System.Drawing.Point(645, 347);
            this.btn_resOK.Name = "btn_resOK";
            this.btn_resOK.Size = new System.Drawing.Size(78, 43);
            this.btn_resOK.TabIndex = 26;
            this.btn_resOK.Text = "ОК";
            this.btn_resOK.UseVisualStyleBackColor = true;
            this.btn_resOK.Click += new System.EventHandler(this.btn_resOK_Click);
            // 
            // checkBox_res5
            // 
            this.checkBox_res5.AutoCheck = false;
            this.checkBox_res5.AutoSize = true;
            this.checkBox_res5.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_res5.Location = new System.Drawing.Point(73, 317);
            this.checkBox_res5.Name = "checkBox_res5";
            this.checkBox_res5.Size = new System.Drawing.Size(147, 33);
            this.checkBox_res5.TabIndex = 25;
            this.checkBox_res5.Text = "Вопрос 5";
            this.checkBox_res5.UseVisualStyleBackColor = true;
            // 
            // checkBox_res4
            // 
            this.checkBox_res4.AutoCheck = false;
            this.checkBox_res4.AutoSize = true;
            this.checkBox_res4.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_res4.Location = new System.Drawing.Point(73, 278);
            this.checkBox_res4.Name = "checkBox_res4";
            this.checkBox_res4.Size = new System.Drawing.Size(147, 33);
            this.checkBox_res4.TabIndex = 24;
            this.checkBox_res4.Text = "Вопрос 4";
            this.checkBox_res4.UseVisualStyleBackColor = true;
            // 
            // checkBox_res1
            // 
            this.checkBox_res1.AutoCheck = false;
            this.checkBox_res1.AutoSize = true;
            this.checkBox_res1.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_res1.Location = new System.Drawing.Point(73, 161);
            this.checkBox_res1.Name = "checkBox_res1";
            this.checkBox_res1.Size = new System.Drawing.Size(147, 33);
            this.checkBox_res1.TabIndex = 21;
            this.checkBox_res1.Text = "Вопрос 1";
            this.checkBox_res1.UseVisualStyleBackColor = true;
            // 
            // checkBox_res3
            // 
            this.checkBox_res3.AutoCheck = false;
            this.checkBox_res3.AutoSize = true;
            this.checkBox_res3.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_res3.Location = new System.Drawing.Point(73, 239);
            this.checkBox_res3.Name = "checkBox_res3";
            this.checkBox_res3.Size = new System.Drawing.Size(147, 33);
            this.checkBox_res3.TabIndex = 23;
            this.checkBox_res3.Text = "Вопрос 3";
            this.checkBox_res3.UseVisualStyleBackColor = true;
            // 
            // checkBox_res2
            // 
            this.checkBox_res2.AutoCheck = false;
            this.checkBox_res2.AutoSize = true;
            this.checkBox_res2.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_res2.Location = new System.Drawing.Point(73, 200);
            this.checkBox_res2.Name = "checkBox_res2";
            this.checkBox_res2.Size = new System.Drawing.Size(147, 33);
            this.checkBox_res2.TabIndex = 22;
            this.checkBox_res2.Text = "Вопрос 2";
            this.checkBox_res2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(-3, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(895, 39);
            this.label12.TabIndex = 15;
            this.label12.Text = "Результаты ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_Question2
            // 
            this.groupBox_Question2.Controls.Add(this.checkBox_ex2_false3);
            this.groupBox_Question2.Controls.Add(this.checkBox_ex2_false1);
            this.groupBox_Question2.Controls.Add(this.checkBox_ex2_false2);
            this.groupBox_Question2.Controls.Add(this.checkBox_ex2_true);
            this.groupBox_Question2.Controls.Add(this.label5);
            this.groupBox_Question2.Controls.Add(this.label4);
            this.groupBox_Question2.Location = new System.Drawing.Point(15, 179);
            this.groupBox_Question2.Name = "groupBox_Question2";
            this.groupBox_Question2.Size = new System.Drawing.Size(892, 470);
            this.groupBox_Question2.TabIndex = 12;
            this.groupBox_Question2.TabStop = false;
            this.groupBox_Question2.Visible = false;
            // 
            // checkBox_ex2_false3
            // 
            this.checkBox_ex2_false3.AutoSize = true;
            this.checkBox_ex2_false3.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_ex2_false3.Location = new System.Drawing.Point(49, 275);
            this.checkBox_ex2_false3.Name = "checkBox_ex2_false3";
            this.checkBox_ex2_false3.Size = new System.Drawing.Size(142, 33);
            this.checkBox_ex2_false3.TabIndex = 20;
            this.checkBox_ex2_false3.Text = "С. Банах";
            this.checkBox_ex2_false3.UseVisualStyleBackColor = true;
            // 
            // checkBox_ex2_false1
            // 
            this.checkBox_ex2_false1.AutoSize = true;
            this.checkBox_ex2_false1.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_ex2_false1.Location = new System.Drawing.Point(49, 158);
            this.checkBox_ex2_false1.Name = "checkBox_ex2_false1";
            this.checkBox_ex2_false1.Size = new System.Drawing.Size(128, 33);
            this.checkBox_ex2_false1.TabIndex = 17;
            this.checkBox_ex2_false1.Text = "Д. Кнут";
            this.checkBox_ex2_false1.UseVisualStyleBackColor = true;
            // 
            // checkBox_ex2_false2
            // 
            this.checkBox_ex2_false2.AutoSize = true;
            this.checkBox_ex2_false2.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_ex2_false2.Location = new System.Drawing.Point(49, 236);
            this.checkBox_ex2_false2.Name = "checkBox_ex2_false2";
            this.checkBox_ex2_false2.Size = new System.Drawing.Size(192, 33);
            this.checkBox_ex2_false2.TabIndex = 19;
            this.checkBox_ex2_false2.Text = "Э. Дейкстра ";
            this.checkBox_ex2_false2.UseVisualStyleBackColor = true;
            // 
            // checkBox_ex2_true
            // 
            this.checkBox_ex2_true.AutoSize = true;
            this.checkBox_ex2_true.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_ex2_true.Location = new System.Drawing.Point(49, 197);
            this.checkBox_ex2_true.Name = "checkBox_ex2_true";
            this.checkBox_ex2_true.Size = new System.Drawing.Size(200, 33);
            this.checkBox_ex2_true.TabIndex = 18;
            this.checkBox_ex2_true.Text = "Я. Лукасевич";
            this.checkBox_ex2_true.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(44, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(561, 46);
            this.label5.TabIndex = 16;
            this.label5.Text = "Кто предложил постфиксную нотацию?";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(0, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(895, 39);
            this.label4.TabIndex = 1;
            this.label4.Text = "Задание 2 ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_Question5
            // 
            this.groupBox_Question5.Controls.Add(this.textBox_ex5);
            this.groupBox_Question5.Controls.Add(this.lbl_ex5);
            this.groupBox_Question5.Controls.Add(this.label10);
            this.groupBox_Question5.Location = new System.Drawing.Point(15, 179);
            this.groupBox_Question5.Name = "groupBox_Question5";
            this.groupBox_Question5.Size = new System.Drawing.Size(892, 470);
            this.groupBox_Question5.TabIndex = 12;
            this.groupBox_Question5.TabStop = false;
            this.groupBox_Question5.Visible = false;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(-3, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(895, 39);
            this.label10.TabIndex = 15;
            this.label10.Text = "Задание 5";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_Question4
            // 
            this.groupBox_Question4.Controls.Add(this.textBox_ex4);
            this.groupBox_Question4.Controls.Add(this.label9);
            this.groupBox_Question4.Controls.Add(this.label8);
            this.groupBox_Question4.Location = new System.Drawing.Point(15, 179);
            this.groupBox_Question4.Name = "groupBox_Question4";
            this.groupBox_Question4.Size = new System.Drawing.Size(892, 470);
            this.groupBox_Question4.TabIndex = 20;
            this.groupBox_Question4.TabStop = false;
            this.groupBox_Question4.Visible = false;
            // 
            // textBox_ex4
            // 
            this.textBox_ex4.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ex4.Location = new System.Drawing.Point(49, 195);
            this.textBox_ex4.Name = "textBox_ex4";
            this.textBox_ex4.Size = new System.Drawing.Size(525, 35);
            this.textBox_ex4.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(44, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(585, 85);
            this.label9.TabIndex = 20;
            this.label9.Text = "Переведите выражение (1+2) * 4 + 3 в постфиксную запись. Элементы записать через " +
    "пробел.";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(0, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(895, 39);
            this.label8.TabIndex = 14;
            this.label8.Text = "Задание 4";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_TestOver
            // 
            this.groupBox_TestOver.Controls.Add(this.btn_check);
            this.groupBox_TestOver.Controls.Add(this.label14);
            this.groupBox_TestOver.Controls.Add(this.label15);
            this.groupBox_TestOver.Location = new System.Drawing.Point(15, 179);
            this.groupBox_TestOver.Name = "groupBox_TestOver";
            this.groupBox_TestOver.Size = new System.Drawing.Size(892, 470);
            this.groupBox_TestOver.TabIndex = 19;
            this.groupBox_TestOver.TabStop = false;
            this.groupBox_TestOver.Visible = false;
            // 
            // btn_check
            // 
            this.btn_check.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_check.Location = new System.Drawing.Point(327, 290);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(218, 43);
            this.btn_check.TabIndex = 18;
            this.btn_check.Text = "Продолжить";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(151, 156);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(594, 63);
            this.label14.TabIndex = 16;
            this.label14.Text = "Нажмите продолжить для окончания теста.";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label15.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(-3, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(895, 39);
            this.label15.TabIndex = 15;
            this.label15.Text = "Конец теста";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Timer
            // 
            this.lbl_Timer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Timer.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Timer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Timer.Location = new System.Drawing.Point(8, 667);
            this.lbl_Timer.Name = "lbl_Timer";
            this.lbl_Timer.Size = new System.Drawing.Size(922, 39);
            this.lbl_Timer.TabIndex = 21;
            this.lbl_Timer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Result
            // 
            this.lbl_Result.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Result.Location = new System.Drawing.Point(359, 87);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(215, 56);
            this.lbl_Result.TabIndex = 27;
            // 
            // textBox_ex5
            // 
            this.textBox_ex5.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ex5.Location = new System.Drawing.Point(62, 212);
            this.textBox_ex5.Name = "textBox_ex5";
            this.textBox_ex5.Size = new System.Drawing.Size(103, 35);
            this.textBox_ex5.TabIndex = 23;
            // 
            // lbl_ex5
            // 
            this.lbl_ex5.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ex5.Location = new System.Drawing.Point(57, 125);
            this.lbl_ex5.Name = "lbl_ex5";
            this.lbl_ex5.Size = new System.Drawing.Size(636, 51);
            this.lbl_ex5.TabIndex = 22;
            this.lbl_ex5.Text = "Вычислить значение выражения 7 5 2 - 4 * +. ";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 719);
            this.Controls.Add(this.groupBox_Result);
            this.Controls.Add(this.groupBox_TestOver);
            this.Controls.Add(this.groupBox_Question5);
            this.Controls.Add(this.groupBox_Question4);
            this.Controls.Add(this.groupBox_Question3);
            this.Controls.Add(this.groupBox_Question2);
            this.Controls.Add(this.lbl_Timer);
            this.Controls.Add(this.groupBox_Question1);
            this.Controls.Add(this.groupBox_Interface);
            this.Controls.Add(this.groupBox_Inform);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Test";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Test_Load);
            this.groupBox_Interface.ResumeLayout(false);
            this.groupBox_Inform.ResumeLayout(false);
            this.groupBox_Question3.ResumeLayout(false);
            this.groupBox_Question3.PerformLayout();
            this.groupBox_Question1.ResumeLayout(false);
            this.groupBox_Question1.PerformLayout();
            this.groupBox_Result.ResumeLayout(false);
            this.groupBox_Result.PerformLayout();
            this.groupBox_Question2.ResumeLayout(false);
            this.groupBox_Question2.PerformLayout();
            this.groupBox_Question5.ResumeLayout(false);
            this.groupBox_Question5.PerformLayout();
            this.groupBox_Question4.ResumeLayout(false);
            this.groupBox_Question4.PerformLayout();
            this.groupBox_TestOver.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox_Interface;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_clock;
        private System.Windows.Forms.GroupBox groupBox_Inform;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_startTest;
        private System.Windows.Forms.GroupBox groupBox_Question1;
        private System.Windows.Forms.Button btn_timer;
        private System.Windows.Forms.GroupBox groupBox_Question2;
        private System.Windows.Forms.GroupBox groupBox_Question3;
        private System.Windows.Forms.GroupBox groupBox_Question5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_ex1_false1;
        private System.Windows.Forms.CheckBox checkBox_ex1_false2;
        private System.Windows.Forms.CheckBox checkBox_ex1_true;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_ex2_false3;
        private System.Windows.Forms.CheckBox checkBox_ex2_false1;
        private System.Windows.Forms.CheckBox checkBox_ex2_false2;
        private System.Windows.Forms.CheckBox checkBox_ex2_true;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_ex3_false3;
        private System.Windows.Forms.CheckBox checkBox_ex3_true;
        private System.Windows.Forms.CheckBox checkBox_ex3_false2;
        private System.Windows.Forms.CheckBox checkBox_ex3_false1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox_Question4;
        private System.Windows.Forms.TextBox textBox_ex4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox_Result;
        private System.Windows.Forms.Button btn_resOK;
        private System.Windows.Forms.CheckBox checkBox_res5;
        private System.Windows.Forms.CheckBox checkBox_res4;
        private System.Windows.Forms.CheckBox checkBox_res1;
        private System.Windows.Forms.CheckBox checkBox_res3;
        private System.Windows.Forms.CheckBox checkBox_res2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_Timer;
        private System.Windows.Forms.GroupBox groupBox_TestOver;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.TextBox textBox_ex5;
        private System.Windows.Forms.Label lbl_ex5;
    }
}