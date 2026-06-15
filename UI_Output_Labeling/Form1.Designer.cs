
namespace UI_Output_Labeling
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbIOT = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbOutput = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStartPause = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbConnection = new System.Windows.Forms.ComboBox();
            this.btnStartProject = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dtUpdate = new System.Windows.Forms.Timer(this.components);
            this.pbSelectPath = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIOT)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "OUTPUT LABELING";
            // 
            // MainTimer
            // 
            this.MainTimer.Interval = 500;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pbIOT);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(391, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 258);
            this.panel1.TabIndex = 6;
            // 
            // pbIOT
            // 
            this.pbIOT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbIOT.Image = global::UI_Output_Labeling.Properties.Resources.iot;
            this.pbIOT.Location = new System.Drawing.Point(120, 173);
            this.pbIOT.Name = "pbIOT";
            this.pbIOT.Size = new System.Drawing.Size(39, 34);
            this.pbIOT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIOT.TabIndex = 8;
            this.pbIOT.TabStop = false;
            this.pbIOT.Click += new System.EventHandler(this.pbIOT_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(128, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "IOT";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbOutput, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(34, 97);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(213, 47);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // lbOutput
            // 
            this.lbOutput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbOutput.AutoSize = true;
            this.lbOutput.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbOutput.Location = new System.Drawing.Point(92, 5);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(28, 37);
            this.lbOutput.TabIndex = 3;
            this.lbOutput.Text = "-";
            this.lbOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnStop);
            this.panel2.Controls.Add(this.btnStartPause);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(38, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 258);
            this.panel2.TabIndex = 7;
            // 
            // btnStop
            // 
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(77, 170);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(130, 37);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStartPause
            // 
            this.btnStartPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartPause.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartPause.ForeColor = System.Drawing.Color.White;
            this.btnStartPause.Location = new System.Drawing.Point(77, 107);
            this.btnStartPause.Name = "btnStartPause";
            this.btnStartPause.Size = new System.Drawing.Size(130, 37);
            this.btnStartPause.TabIndex = 4;
            this.btnStartPause.Text = "START";
            this.btnStartPause.UseVisualStyleBackColor = true;
            this.btnStartPause.Click += new System.EventHandler(this.btnStartPause_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(38, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "CONTROL ROBOT";
            // 
            // cbConnection
            // 
            this.cbConnection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbConnection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConnection.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbConnection.FormattingEnabled = true;
            this.cbConnection.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbConnection.Location = new System.Drawing.Point(539, 364);
            this.cbConnection.Name = "cbConnection";
            this.cbConnection.Size = new System.Drawing.Size(49, 25);
            this.cbConnection.TabIndex = 189;
            this.cbConnection.TabStop = false;
            // 
            // btnStartProject
            // 
            this.btnStartProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartProject.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartProject.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStartProject.Location = new System.Drawing.Point(600, 361);
            this.btnStartProject.Name = "btnStartProject";
            this.btnStartProject.Size = new System.Drawing.Size(90, 27);
            this.btnStartProject.TabIndex = 191;
            this.btnStartProject.TabStop = false;
            this.btnStartProject.Text = "Start Project";
            this.btnStartProject.UseVisualStyleBackColor = true;
            this.btnStartProject.Click += new System.EventHandler(this.btnStartProject_Click_1);
            // 
            // tbPath
            // 
            this.tbPath.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPath.Location = new System.Drawing.Point(111, 367);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(280, 25);
            this.tbPath.TabIndex = 188;
            this.tbPath.TabStop = false;
            this.tbPath.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(11, 366);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 20);
            this.label12.TabIndex = 186;
            this.label12.Text = "Project Path :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(442, 367);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 20);
            this.label17.TabIndex = 187;
            this.label17.Text = "Connection :";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtUpdate
            // 
            this.dtUpdate.Enabled = true;
            this.dtUpdate.Interval = 1000;
            this.dtUpdate.Tick += new System.EventHandler(this.dtUpdate_Tick);
            // 
            // pbSelectPath
            // 
            this.pbSelectPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSelectPath.Image = global::UI_Output_Labeling.Properties.Resources.kisspng_computer_icons_directory_5adb9732d688c4_8228585315243405308787;
            this.pbSelectPath.Location = new System.Drawing.Point(397, 361);
            this.pbSelectPath.Name = "pbSelectPath";
            this.pbSelectPath.Size = new System.Drawing.Size(39, 34);
            this.pbSelectPath.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSelectPath.TabIndex = 192;
            this.pbSelectPath.TabStop = false;
            this.pbSelectPath.Click += new System.EventHandler(this.pbSelectPath_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UI_Output_Labeling.Properties.Resources.Kinpo_group_logo_transparent;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(143, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pbExit
            // 
            this.pbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExit.Image = global::UI_Output_Labeling.Properties.Resources.exit;
            this.pbExit.Location = new System.Drawing.Point(679, 3);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(39, 34);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit.TabIndex = 0;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(720, 400);
            this.Controls.Add(this.pbSelectPath);
            this.Controls.Add(this.cbConnection);
            this.Controls.Add(this.btnStartProject);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIOT)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectPath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStartPause;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbConnection;
        private System.Windows.Forms.Button btnStartProject;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pbSelectPath;
        private System.Windows.Forms.Label lbOutput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer dtUpdate;
        private System.Windows.Forms.PictureBox pbIOT;
        private System.Windows.Forms.Label label4;
    }
}

