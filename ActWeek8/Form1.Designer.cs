namespace ActWeek8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCon = new Button();
            btnLoad = new Button();
            dgvStudInfo = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbID = new TextBox();
            tbLast = new TextBox();
            tbFirst = new TextBox();
            btnInsert = new Button();
            btnDel = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudInfo).BeginInit();
            SuspendLayout();
            // 
            // btnCon
            // 
            btnCon.Location = new Point(12, 568);
            btnCon.Name = "btnCon";
            btnCon.Size = new Size(159, 29);
            btnCon.TabIndex = 0;
            btnCon.Text = "Connection Test";
            btnCon.UseVisualStyleBackColor = true;
            btnCon.Click += btnCon_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(177, 568);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(89, 29);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load Data";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // dgvStudInfo
            // 
            dgvStudInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudInfo.Dock = DockStyle.Right;
            dgvStudInfo.Location = new Point(334, 0);
            dgvStudInfo.Name = "dgvStudInfo";
            dgvStudInfo.RowHeadersWidth = 51;
            dgvStudInfo.Size = new Size(633, 609);
            dgvStudInfo.TabIndex = 2;
            dgvStudInfo.CellClick += dgvStudInfo_CellClick;
            dgvStudInfo.CellContentClick += dgvStudInfo_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 7.8F);
            label1.Location = new Point(12, 60);
            label1.Name = "label1";
            label1.Size = new Size(86, 16);
            label1.TabIndex = 3;
            label1.Text = "STUDENT ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 7.8F);
            label2.Location = new Point(12, 102);
            label2.Name = "label2";
            label2.Size = new Size(80, 16);
            label2.TabIndex = 4;
            label2.Text = "LAST NAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Fax", 7.8F);
            label3.Location = new Point(12, 145);
            label3.Name = "label3";
            label3.Size = new Size(84, 16);
            label3.TabIndex = 5;
            label3.Text = "FIRST NAME";
            // 
            // tbID
            // 
            tbID.Location = new Point(110, 54);
            tbID.Name = "tbID";
            tbID.Size = new Size(203, 27);
            tbID.TabIndex = 6;
            // 
            // tbLast
            // 
            tbLast.Location = new Point(110, 96);
            tbLast.Name = "tbLast";
            tbLast.Size = new Size(203, 27);
            tbLast.TabIndex = 7;
            // 
            // tbFirst
            // 
            tbFirst.Location = new Point(110, 139);
            tbFirst.Name = "tbFirst";
            tbFirst.Size = new Size(203, 27);
            tbFirst.TabIndex = 8;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(15, 197);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(85, 29);
            btnInsert.TabIndex = 9;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(121, 197);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(85, 29);
            btnDel.TabIndex = 10;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(228, 196);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(85, 29);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 609);
            Controls.Add(btnDel);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(tbFirst);
            Controls.Add(tbLast);
            Controls.Add(tbID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvStudInfo);
            Controls.Add(btnLoad);
            Controls.Add(btnCon);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvStudInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCon;
        private Button btnLoad;
        private DataGridView dgvStudInfo;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbID;
        private TextBox tbLast;
        private TextBox tbFirst;
        private Button btnInsert;
        private Button btnDel;
        private Button btnUpdate;
    }
}
