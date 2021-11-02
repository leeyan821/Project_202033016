
namespace Project_202033016
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.예매취소ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.영화관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.로그인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.마이페이지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theaterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(10, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 367);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Today Movies";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.theaterDataGridViewTextBoxColumn,
            this.numDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.movieBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(728, 274);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.예매취소ToolStripMenuItem,
            this.영화관리ToolStripMenuItem,
            this.로그인ToolStripMenuItem,
            this.마이페이지ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 예매취소ToolStripMenuItem
            // 
            this.예매취소ToolStripMenuItem.Name = "예매취소ToolStripMenuItem";
            this.예매취소ToolStripMenuItem.Size = new System.Drawing.Size(119, 29);
            this.예매취소ToolStripMenuItem.Text = "예매 / 취소";
            this.예매취소ToolStripMenuItem.Click += new System.EventHandler(this.예매취소ToolStripMenuItem_Click);
            // 
            // 영화관리ToolStripMenuItem
            // 
            this.영화관리ToolStripMenuItem.Name = "영화관리ToolStripMenuItem";
            this.영화관리ToolStripMenuItem.Size = new System.Drawing.Size(106, 29);
            this.영화관리ToolStripMenuItem.Text = "영화 관리";
            this.영화관리ToolStripMenuItem.Click += new System.EventHandler(this.영화관리ToolStripMenuItem_Click);
            // 
            // 로그인ToolStripMenuItem
            // 
            this.로그인ToolStripMenuItem.Name = "로그인ToolStripMenuItem";
            this.로그인ToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            this.로그인ToolStripMenuItem.Text = "로그인";
            this.로그인ToolStripMenuItem.Click += new System.EventHandler(this.로그인ToolStripMenuItem_Click);
            // 
            // 마이페이지ToolStripMenuItem
            // 
            this.마이페이지ToolStripMenuItem.Name = "마이페이지ToolStripMenuItem";
            this.마이페이지ToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.마이페이지ToolStripMenuItem.Text = "마이페이지";
            this.마이페이지ToolStripMenuItem.Click += new System.EventHandler(this.마이페이지ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(13, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Today: 2021-10-28";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(671, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "새로고침";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // theaterDataGridViewTextBoxColumn
            // 
            this.theaterDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.theaterDataGridViewTextBoxColumn.DataPropertyName = "Theater";
            this.theaterDataGridViewTextBoxColumn.HeaderText = "상영관";
            this.theaterDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.theaterDataGridViewTextBoxColumn.Name = "theaterDataGridViewTextBoxColumn";
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numDataGridViewTextBoxColumn.DataPropertyName = "Num";
            this.numDataGridViewTextBoxColumn.HeaderText = "남은 좌석";
            this.numDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataSource = typeof(Project_202033016.Movie);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 616);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 예매취소ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 영화관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 로그인ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 마이페이지ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn theaterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}

