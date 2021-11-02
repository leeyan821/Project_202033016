
namespace Project_202033016
{
    partial class MyPageForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.정보수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theaterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.정보수정ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(874, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 정보수정ToolStripMenuItem
            // 
            this.정보수정ToolStripMenuItem.Name = "정보수정ToolStripMenuItem";
            this.정보수정ToolStripMenuItem.Size = new System.Drawing.Size(106, 29);
            this.정보수정ToolStripMenuItem.Text = "정보 수정";
            this.정보수정ToolStripMenuItem.Click += new System.EventHandler(this.정보수정ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(856, 416);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "예매 현황";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.theaterDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.movieBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(575, 255);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.useridDataGridViewTextBoxColumn,
            this.seatDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.reservationBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(587, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 30;
            this.dataGridView2.Size = new System.Drawing.Size(263, 255);
            this.dataGridView2.TabIndex = 1;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "Userid";
            this.useridDataGridViewTextBoxColumn.FillWeight = 113.6364F;
            this.useridDataGridViewTextBoxColumn.HeaderText = "유저";
            this.useridDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            // 
            // seatDataGridViewTextBoxColumn
            // 
            this.seatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.seatDataGridViewTextBoxColumn.DataPropertyName = "Seat";
            this.seatDataGridViewTextBoxColumn.FillWeight = 86.36364F;
            this.seatDataGridViewTextBoxColumn.HeaderText = "좌석";
            this.seatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.seatDataGridViewTextBoxColumn.Name = "seatDataGridViewTextBoxColumn";
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataSource = typeof(Project_202033016.Reservation);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "영화";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "시간";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "날짜";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 140;
            // 
            // theaterDataGridViewTextBoxColumn
            // 
            this.theaterDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.theaterDataGridViewTextBoxColumn.DataPropertyName = "Theater";
            this.theaterDataGridViewTextBoxColumn.HeaderText = "상영관";
            this.theaterDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.theaterDataGridViewTextBoxColumn.Name = "theaterDataGridViewTextBoxColumn";
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataSource = typeof(Project_202033016.Movie);
            // 
            // MyPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(874, 500);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MyPageForm";
            this.Text = "MyPageForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 정보수정ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn theaterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource reservationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatDataGridViewTextBoxColumn;
    }
}