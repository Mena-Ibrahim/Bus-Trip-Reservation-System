namespace ODP1_Connected_Start
{
    partial class AdminForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGrd = new System.Windows.Forms.DataGridView();
            this.radioUsers = new System.Windows.Forms.RadioButton();
            this.radioTrips = new System.Windows.Forms.RadioButton();
            this.radioReservations = new System.Windows.Forms.RadioButton();
            this.radioRefunds = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(827, 487);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(153, 40);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // dataGrd
            // 
            this.dataGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrd.Location = new System.Drawing.Point(354, 23);
            this.dataGrd.Name = "dataGrd";
            this.dataGrd.RowHeadersWidth = 51;
            this.dataGrd.RowTemplate.Height = 24;
            this.dataGrd.Size = new System.Drawing.Size(636, 414);
            this.dataGrd.TabIndex = 4;
            // 
            // radioUsers
            // 
            this.radioUsers.AutoSize = true;
            this.radioUsers.Location = new System.Drawing.Point(37, 42);
            this.radioUsers.Name = "radioUsers";
            this.radioUsers.Size = new System.Drawing.Size(64, 20);
            this.radioUsers.TabIndex = 6;
            this.radioUsers.TabStop = true;
            this.radioUsers.Text = "Users";
            this.radioUsers.UseVisualStyleBackColor = true;
            this.radioUsers.CheckedChanged += new System.EventHandler(this.radioUsers_CheckedChanged);
            // 
            // radioTrips
            // 
            this.radioTrips.AutoSize = true;
            this.radioTrips.Location = new System.Drawing.Point(37, 97);
            this.radioTrips.Name = "radioTrips";
            this.radioTrips.Size = new System.Drawing.Size(59, 20);
            this.radioTrips.TabIndex = 7;
            this.radioTrips.TabStop = true;
            this.radioTrips.Text = "Trips";
            this.radioTrips.UseVisualStyleBackColor = true;
            this.radioTrips.CheckedChanged += new System.EventHandler(this.radioTrips_CheckedChanged);
            // 
            // radioReservations
            // 
            this.radioReservations.AutoSize = true;
            this.radioReservations.Location = new System.Drawing.Point(37, 150);
            this.radioReservations.Name = "radioReservations";
            this.radioReservations.Size = new System.Drawing.Size(108, 20);
            this.radioReservations.TabIndex = 8;
            this.radioReservations.TabStop = true;
            this.radioReservations.Text = "Reservations";
            this.radioReservations.UseVisualStyleBackColor = true;
            this.radioReservations.CheckedChanged += new System.EventHandler(this.radioReservations_CheckedChanged);
            // 
            // radioRefunds
            // 
            this.radioRefunds.AutoSize = true;
            this.radioRefunds.Location = new System.Drawing.Point(37, 200);
            this.radioRefunds.Name = "radioRefunds";
            this.radioRefunds.Size = new System.Drawing.Size(78, 20);
            this.radioRefunds.TabIndex = 9;
            this.radioRefunds.TabStop = true;
            this.radioRefunds.Text = "Refunds";
            this.radioRefunds.UseVisualStyleBackColor = true;
            this.radioRefunds.CheckedChanged += new System.EventHandler(this.radioRefunds_CheckedChanged);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 559);
            this.Controls.Add(this.radioRefunds);
            this.Controls.Add(this.radioReservations);
            this.Controls.Add(this.radioTrips);
            this.Controls.Add(this.radioUsers);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGrd);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGrd;
        private System.Windows.Forms.RadioButton radioUsers;
        private System.Windows.Forms.RadioButton radioTrips;
        private System.Windows.Forms.RadioButton radioReservations;
        private System.Windows.Forms.RadioButton radioRefunds;
    }
}