namespace Hotel_SoftWare
{
    partial class RoomStatusForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnXroomStatus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(652, 417);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnXroomStatus
            // 
            this.btnXroomStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXroomStatus.BackColor = System.Drawing.Color.Red;
            this.btnXroomStatus.ForeColor = System.Drawing.Color.Transparent;
            this.btnXroomStatus.Location = new System.Drawing.Point(643, 12);
            this.btnXroomStatus.Name = "btnXroomStatus";
            this.btnXroomStatus.Size = new System.Drawing.Size(46, 38);
            this.btnXroomStatus.TabIndex = 2;
            this.btnXroomStatus.Text = "X";
            this.btnXroomStatus.UseVisualStyleBackColor = false;
            this.btnXroomStatus.Click += new System.EventHandler(this.btnXroomStatus_Click);
            // 
            // RoomStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 522);
            this.Controls.Add(this.btnXroomStatus);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RoomStatusForm";
            this.Text = "RoomStatusForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnXroomStatus;

    }
}