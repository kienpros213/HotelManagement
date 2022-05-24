
namespace HotelManagement
{
    partial class bookingForm
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
            this.customerID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.customerFName = new System.Windows.Forms.TextBox();
            this.customerLName = new System.Windows.Forms.TextBox();
            this.customerStatus = new System.Windows.Forms.TextBox();
            this.customerAddress = new System.Windows.Forms.TextBox();
            this.reservation = new System.Windows.Forms.TextBox();
            this.fqwe = new System.Windows.Forms.Label();
            this.rew = new System.Windows.Forms.Label();
            this.sdf = new System.Windows.Forms.Label();
            this.bqe = new System.Windows.Forms.Label();
            this.vqe = new System.Windows.Forms.Label();
            this.sd = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerID
            // 
            this.customerID.Location = new System.Drawing.Point(206, 50);
            this.customerID.Name = "customerID";
            this.customerID.Size = new System.Drawing.Size(220, 20);
            this.customerID.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customerFName
            // 
            this.customerFName.Location = new System.Drawing.Point(206, 95);
            this.customerFName.Name = "customerFName";
            this.customerFName.Size = new System.Drawing.Size(220, 20);
            this.customerFName.TabIndex = 3;
            // 
            // customerLName
            // 
            this.customerLName.Location = new System.Drawing.Point(206, 141);
            this.customerLName.Name = "customerLName";
            this.customerLName.Size = new System.Drawing.Size(220, 20);
            this.customerLName.TabIndex = 5;
            // 
            // customerStatus
            // 
            this.customerStatus.Location = new System.Drawing.Point(206, 275);
            this.customerStatus.Name = "customerStatus";
            this.customerStatus.Size = new System.Drawing.Size(220, 20);
            this.customerStatus.TabIndex = 8;
            // 
            // customerAddress
            // 
            this.customerAddress.Location = new System.Drawing.Point(206, 229);
            this.customerAddress.Name = "customerAddress";
            this.customerAddress.Size = new System.Drawing.Size(220, 20);
            this.customerAddress.TabIndex = 7;
            // 
            // reservation
            // 
            this.reservation.Location = new System.Drawing.Point(206, 184);
            this.reservation.Name = "reservation";
            this.reservation.Size = new System.Drawing.Size(220, 20);
            this.reservation.TabIndex = 6;
            // 
            // fqwe
            // 
            this.fqwe.AutoSize = true;
            this.fqwe.Location = new System.Drawing.Point(115, 53);
            this.fqwe.Name = "fqwe";
            this.fqwe.Size = new System.Drawing.Size(61, 13);
            this.fqwe.TabIndex = 9;
            this.fqwe.Text = "customerID";
            // 
            // rew
            // 
            this.rew.AutoSize = true;
            this.rew.Location = new System.Drawing.Point(115, 184);
            this.rew.Name = "rew";
            this.rew.Size = new System.Drawing.Size(59, 13);
            this.rew.TabIndex = 10;
            this.rew.Text = "reservation";
            // 
            // sdf
            // 
            this.sdf.AutoSize = true;
            this.sdf.Location = new System.Drawing.Point(115, 232);
            this.sdf.Name = "sdf";
            this.sdf.Size = new System.Drawing.Size(85, 13);
            this.sdf.TabIndex = 11;
            this.sdf.Text = "customerAddess";
            // 
            // bqe
            // 
            this.bqe.AutoSize = true;
            this.bqe.Location = new System.Drawing.Point(115, 144);
            this.bqe.Name = "bqe";
            this.bqe.Size = new System.Drawing.Size(84, 13);
            this.bqe.TabIndex = 12;
            this.bqe.Text = "customerLName";
            // 
            // vqe
            // 
            this.vqe.AutoSize = true;
            this.vqe.Location = new System.Drawing.Point(115, 95);
            this.vqe.Name = "vqe";
            this.vqe.Size = new System.Drawing.Size(84, 13);
            this.vqe.TabIndex = 13;
            this.vqe.Text = "customerFName";
            // 
            // sd
            // 
            this.sd.AutoSize = true;
            this.sd.Location = new System.Drawing.Point(115, 278);
            this.sd.Name = "sd";
            this.sd.Size = new System.Drawing.Size(80, 13);
            this.sd.TabIndex = 14;
            this.sd.Text = "customerStatus";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(456, 47);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(730, 264);
            this.dataGridView.TabIndex = 15;
            // 
            // bookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.sd);
            this.Controls.Add(this.vqe);
            this.Controls.Add(this.bqe);
            this.Controls.Add(this.sdf);
            this.Controls.Add(this.rew);
            this.Controls.Add(this.fqwe);
            this.Controls.Add(this.customerStatus);
            this.Controls.Add(this.customerAddress);
            this.Controls.Add(this.reservation);
            this.Controls.Add(this.customerLName);
            this.Controls.Add(this.customerFName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customerID);
            this.Name = "bookingForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customerID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox customerFName;
        private System.Windows.Forms.TextBox customerLName;
        private System.Windows.Forms.TextBox customerStatus;
        private System.Windows.Forms.TextBox customerAddress;
        private System.Windows.Forms.TextBox reservation;
        private System.Windows.Forms.Label fqwe;
        private System.Windows.Forms.Label rew;
        private System.Windows.Forms.Label sdf;
        private System.Windows.Forms.Label bqe;
        private System.Windows.Forms.Label vqe;
        private System.Windows.Forms.Label sd;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}