﻿
namespace HotelManagement
{
    partial class occupiedRoomForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(occupiedRoomForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.allRoomBtn = new System.Windows.Forms.Button();
            this.suitRoomBtn = new System.Windows.Forms.Button();
            this.familyRoomBtn = new System.Windows.Forms.Button();
            this.doubleRoomBtn = new System.Windows.Forms.Button();
            this.singleRoomBtn = new System.Windows.Forms.Button();
            this.roomDataList = new System.Windows.Forms.DataGridView();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomDataList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.panel1.Controls.Add(this.allRoomBtn);
            this.panel1.Controls.Add(this.suitRoomBtn);
            this.panel1.Controls.Add(this.familyRoomBtn);
            this.panel1.Controls.Add(this.doubleRoomBtn);
            this.panel1.Controls.Add(this.singleRoomBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 500);
            this.panel1.TabIndex = 0;
            // 
            // allRoomBtn
            // 
            this.allRoomBtn.FlatAppearance.BorderSize = 0;
            this.allRoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allRoomBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.allRoomBtn.Location = new System.Drawing.Point(0, 15);
            this.allRoomBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.allRoomBtn.Name = "allRoomBtn";
            this.allRoomBtn.Size = new System.Drawing.Size(267, 86);
            this.allRoomBtn.TabIndex = 5;
            this.allRoomBtn.Text = "ALL ROOM";
            this.allRoomBtn.UseVisualStyleBackColor = true;
            this.allRoomBtn.Click += new System.EventHandler(this.allRoomBtn_Click);
            // 
            // suitRoomBtn
            // 
            this.suitRoomBtn.FlatAppearance.BorderSize = 0;
            this.suitRoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suitRoomBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.suitRoomBtn.Location = new System.Drawing.Point(0, 389);
            this.suitRoomBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.suitRoomBtn.Name = "suitRoomBtn";
            this.suitRoomBtn.Size = new System.Drawing.Size(267, 86);
            this.suitRoomBtn.TabIndex = 4;
            this.suitRoomBtn.Text = "SUIT ROOM";
            this.suitRoomBtn.UseVisualStyleBackColor = true;
            this.suitRoomBtn.Click += new System.EventHandler(this.suitRoomBtn_Click);
            // 
            // familyRoomBtn
            // 
            this.familyRoomBtn.FlatAppearance.BorderSize = 0;
            this.familyRoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.familyRoomBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.familyRoomBtn.Location = new System.Drawing.Point(0, 295);
            this.familyRoomBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.familyRoomBtn.Name = "familyRoomBtn";
            this.familyRoomBtn.Size = new System.Drawing.Size(267, 86);
            this.familyRoomBtn.TabIndex = 3;
            this.familyRoomBtn.Text = "FAMILY ROOM";
            this.familyRoomBtn.UseVisualStyleBackColor = true;
            this.familyRoomBtn.Click += new System.EventHandler(this.familyRoomBtn_Click);
            // 
            // doubleRoomBtn
            // 
            this.doubleRoomBtn.FlatAppearance.BorderSize = 0;
            this.doubleRoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doubleRoomBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.doubleRoomBtn.Location = new System.Drawing.Point(0, 202);
            this.doubleRoomBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.doubleRoomBtn.Name = "doubleRoomBtn";
            this.doubleRoomBtn.Size = new System.Drawing.Size(267, 86);
            this.doubleRoomBtn.TabIndex = 2;
            this.doubleRoomBtn.Text = "DOUBLE ROOM";
            this.doubleRoomBtn.UseVisualStyleBackColor = true;
            this.doubleRoomBtn.Click += new System.EventHandler(this.doubleRoomBtn_Click);
            // 
            // singleRoomBtn
            // 
            this.singleRoomBtn.FlatAppearance.BorderSize = 0;
            this.singleRoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.singleRoomBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.singleRoomBtn.Location = new System.Drawing.Point(0, 108);
            this.singleRoomBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.singleRoomBtn.Name = "singleRoomBtn";
            this.singleRoomBtn.Size = new System.Drawing.Size(267, 86);
            this.singleRoomBtn.TabIndex = 1;
            this.singleRoomBtn.Text = "SINGLE ROOM";
            this.singleRoomBtn.UseVisualStyleBackColor = true;
            this.singleRoomBtn.Click += new System.EventHandler(this.singleRoomBtn_Click);
            // 
            // roomDataList
            // 
            this.roomDataList.AllowUserToAddRows = false;
            this.roomDataList.AllowUserToDeleteRows = false;
            this.roomDataList.AllowUserToResizeColumns = false;
            this.roomDataList.AllowUserToResizeRows = false;
            this.roomDataList.BackgroundColor = System.Drawing.Color.White;
            this.roomDataList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomDataList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.roomDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomDataList.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.roomDataList.DefaultCellStyle = dataGridViewCellStyle2;
            this.roomDataList.Location = new System.Drawing.Point(275, 64);
            this.roomDataList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roomDataList.Name = "roomDataList";
            this.roomDataList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.roomDataList.RowHeadersVisible = false;
            this.roomDataList.RowHeadersWidth = 51;
            this.roomDataList.RowTemplate.Height = 33;
            this.roomDataList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.roomDataList.Size = new System.Drawing.Size(1243, 428);
            this.roomDataList.TabIndex = 1;
            this.roomDataList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomDataList_CellContentClick);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(12, 18);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(69, 14);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox11.TabIndex = 17;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(125, 18);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(63, 14);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox12.TabIndex = 18;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(295, 17);
            this.pictureBox13.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(129, 17);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox13.TabIndex = 19;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(561, 16);
            this.pictureBox14.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(86, 14);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox14.TabIndex = 20;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
            this.pictureBox15.Location = new System.Drawing.Point(740, 16);
            this.pictureBox15.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(97, 14);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox15.TabIndex = 21;
            this.pictureBox15.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.panel2.Controls.Add(this.pictureBox15);
            this.panel2.Controls.Add(this.pictureBox11);
            this.panel2.Controls.Add(this.pictureBox14);
            this.panel2.Controls.Add(this.pictureBox12);
            this.panel2.Controls.Add(this.pictureBox13);
            this.panel2.Location = new System.Drawing.Point(275, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(929, 50);
            this.panel2.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(1212, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // occupiedRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 500);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.roomDataList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "occupiedRoomForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomDataList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button singleRoomBtn;
        private System.Windows.Forms.Button allRoomBtn;
        private System.Windows.Forms.Button suitRoomBtn;
        private System.Windows.Forms.Button familyRoomBtn;
        private System.Windows.Forms.Button doubleRoomBtn;
        private System.Windows.Forms.DataGridView roomDataList;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}