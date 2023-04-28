
namespace ODP1_Connected_Start.UserControls
{
    partial class Trips
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.avaliableTrips = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.avaliableTrips)).BeginInit();
            this.SuspendLayout();
            // 
            // avaliableTrips
            // 
            this.avaliableTrips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.avaliableTrips.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avaliableTrips.Location = new System.Drawing.Point(0, 0);
            this.avaliableTrips.Name = "avaliableTrips";
            this.avaliableTrips.ReadOnly = true;
            this.avaliableTrips.Size = new System.Drawing.Size(702, 433);
            this.avaliableTrips.TabIndex = 1;
            this.avaliableTrips.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.avaliableTrips_CellContentClick_1);
            // 
            // Trips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.avaliableTrips);
            this.Name = "Trips";
            this.Size = new System.Drawing.Size(702, 433);
            this.Load += new System.EventHandler(this.Trips_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avaliableTrips)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView avaliableTrips;
    }
}
