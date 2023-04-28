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
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(620, 396);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 32);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // dataGrd
            // 
            this.dataGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrd.Location = new System.Drawing.Point(266, 19);
            this.dataGrd.Margin = new System.Windows.Forms.Padding(2);
            this.dataGrd.Name = "dataGrd";
            this.dataGrd.RowHeadersWidth = 51;
            this.dataGrd.RowTemplate.Height = 24;
            this.dataGrd.Size = new System.Drawing.Size(477, 336);
            this.dataGrd.TabIndex = 4;
            //this.dataGrd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrd_CellContentClick);
            // 
            // radioUsers
            // 
            this.radioUsers.AutoSize = true;
            this.radioUsers.Location = new System.Drawing.Point(28, 34);
            this.radioUsers.Margin = new System.Windows.Forms.Padding(2);
            this.radioUsers.Name = "radioUsers";
            this.radioUsers.Size = new System.Drawing.Size(52, 17);
            this.radioUsers.TabIndex = 6;
            this.radioUsers.TabStop = true;
            this.radioUsers.Text = "Users";
            this.radioUsers.UseVisualStyleBackColor = true;
            this.radioUsers.CheckedChanged += new System.EventHandler(this.radioUsers_CheckedChanged);
            // 
            // radioTrips
            // 
            this.radioTrips.AutoSize = true;
            this.radioTrips.Location = new System.Drawing.Point(28, 79);
            this.radioTrips.Margin = new System.Windows.Forms.Padding(2);
            this.radioTrips.Name = "radioTrips";
            this.radioTrips.Size = new System.Drawing.Size(48, 17);
            this.radioTrips.TabIndex = 7;
            this.radioTrips.TabStop = true;
            this.radioTrips.Text = "Trips";
            this.radioTrips.UseVisualStyleBackColor = true;
            this.radioTrips.CheckedChanged += new System.EventHandler(this.radioTrips_CheckedChanged);
            // 
            // radioReservations
            // 
            this.radioReservations.AutoSize = true;
            this.radioReservations.Location = new System.Drawing.Point(28, 122);
            this.radioReservations.Margin = new System.Windows.Forms.Padding(2);
            this.radioReservations.Name = "radioReservations";
            this.radioReservations.Size = new System.Drawing.Size(87, 17);
            this.radioReservations.TabIndex = 8;
            this.radioReservations.TabStop = true;
            this.radioReservations.Text = "Reservations";
            this.radioReservations.UseVisualStyleBackColor = true;
            this.radioReservations.CheckedChanged += new System.EventHandler(this.radioReservations_CheckedChanged);
            // 
            // radioRefunds
            // 
            this.radioRefunds.AutoSize = true;
            this.radioRefunds.Location = new System.Drawing.Point(28, 162);
            this.radioRefunds.Margin = new System.Windows.Forms.Padding(2);
            this.radioRefunds.Name = "radioRefunds";
            this.radioRefunds.Size = new System.Drawing.Size(65, 17);
            this.radioRefunds.TabIndex = 9;
            this.radioRefunds.TabStop = true;
            this.radioRefunds.Text = "Refunds";
            this.radioRefunds.UseVisualStyleBackColor = true;
            this.radioRefunds.CheckedChanged += new System.EventHandler(this.radioRefunds_CheckedChanged);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(37, 469);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(153, 40);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 559);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.radioRefunds);
            this.Controls.Add(this.radioReservations);
            this.Controls.Add(this.radioTrips);
            this.Controls.Add(this.radioUsers);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGrd);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button btnLogout;
    }
}