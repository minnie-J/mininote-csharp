namespace MiniNote
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.introPanel = new System.Windows.Forms.TableLayoutPanel();
            this.startButton = new System.Windows.Forms.Button();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.blLabel = new System.Windows.Forms.Label();
            this.mainMenu = new System.Windows.Forms.TabControl();
            this.toDoTab = new System.Windows.Forms.TabPage();
            this.todoListPanel = new System.Windows.Forms.Panel();
            //this.toDoItem2 = new MiniNote.ToDoItem();
            //this.toDoItem1 = new MiniNote.ToDoItem();
            this.addButton = new System.Windows.Forms.Button();
            this.totalCount = new System.Windows.Forms.Label();
            this.noteTab = new System.Windows.Forms.TabPage();
            this.aotButton = new System.Windows.Forms.Label();
            this.introPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.mainMenu.SuspendLayout();
            this.toDoTab.SuspendLayout();
            this.todoListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // introPanel
            // 
            this.introPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.introPanel.ColumnCount = 1;
            this.introPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.introPanel.Controls.Add(this.startButton, 0, 3);
            this.introPanel.Controls.Add(this.logoBox, 0, 1);
            this.introPanel.Controls.Add(this.blLabel, 0, 2);
            this.introPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.introPanel.Location = new System.Drawing.Point(0, 0);
            this.introPanel.Name = "introPanel";
            this.introPanel.RowCount = 5;
            this.introPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.introPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.introPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.introPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.introPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.introPanel.Size = new System.Drawing.Size(384, 461);
            this.introPanel.TabIndex = 0;
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Location = new System.Drawing.Point(142, 343);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 34);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "시작하기";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // logoBox
            // 
            this.logoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.Location = new System.Drawing.Point(3, 83);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(378, 164);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logoBox.TabIndex = 0;
            this.logoBox.TabStop = false;
            // 
            // blLabel
            // 
            this.blLabel.AutoSize = true;
            this.blLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blLabel.Font = new System.Drawing.Font("Bradley Hand ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.blLabel.Location = new System.Drawing.Point(3, 250);
            this.blLabel.Name = "blLabel";
            this.blLabel.Size = new System.Drawing.Size(378, 40);
            this.blLabel.TabIndex = 1;
            this.blLabel.Text = "MINI NOTE";
            this.blLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainMenu
            // 
            this.mainMenu.Controls.Add(this.toDoTab);
            this.mainMenu.Controls.Add(this.noteTab);
            this.mainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenu.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.SelectedIndex = 0;
            this.mainMenu.Size = new System.Drawing.Size(384, 461);
            this.mainMenu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Visible = false;
            // 
            // toDoTab
            // 
            this.toDoTab.Controls.Add(this.todoListPanel);
            this.toDoTab.Controls.Add(this.addButton);
            this.toDoTab.Controls.Add(this.totalCount);
            this.toDoTab.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.toDoTab.Location = new System.Drawing.Point(4, 26);
            this.toDoTab.Name = "toDoTab";
            this.toDoTab.Padding = new System.Windows.Forms.Padding(3);
            this.toDoTab.Size = new System.Drawing.Size(376, 431);
            this.toDoTab.TabIndex = 0;
            this.toDoTab.Text = "TO DO";
            this.toDoTab.UseVisualStyleBackColor = true;
            // 
            // todoListPanel
            // 
            this.todoListPanel.AutoScroll = true;
            //this.todoListPanel.Controls.Add(this.toDoItem2);
            //this.todoListPanel.Controls.Add(this.toDoItem1);
            this.todoListPanel.Location = new System.Drawing.Point(0, 36);
            this.todoListPanel.Name = "todoListPanel";
            this.todoListPanel.Size = new System.Drawing.Size(376, 395);
            this.todoListPanel.TabIndex = 2;
            //// 
            //// toDoItem2
            //// 
            //this.toDoItem2.Location = new System.Drawing.Point(8, 50);
            //this.toDoItem2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            //this.toDoItem2.Name = "toDoItem2";
            //this.toDoItem2.Size = new System.Drawing.Size(360, 34);
            //this.toDoItem2.TabIndex = 1;
            //// 
            //// toDoItem1
            //// 
            //this.toDoItem1.Location = new System.Drawing.Point(8, 8);
            //this.toDoItem1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            //this.toDoItem1.Name = "toDoItem1";
            //this.toDoItem1.Size = new System.Drawing.Size(360, 34);
            //this.toDoItem1.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Location = new System.Drawing.Point(293, 7);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "New";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // totalCount
            // 
            this.totalCount.AutoSize = true;
            this.totalCount.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.totalCount.Location = new System.Drawing.Point(8, 10);
            this.totalCount.Name = "totalCount";
            this.totalCount.Size = new System.Drawing.Size(53, 17);
            this.totalCount.TabIndex = 0;
            this.totalCount.Text = "Total 0";
            // 
            // noteTab
            // 
            this.noteTab.Location = new System.Drawing.Point(4, 26);
            this.noteTab.Name = "noteTab";
            this.noteTab.Padding = new System.Windows.Forms.Padding(3);
            this.noteTab.Size = new System.Drawing.Size(376, 431);
            this.noteTab.TabIndex = 1;
            this.noteTab.Text = "NOTE";
            this.noteTab.UseVisualStyleBackColor = true;
            // 
            // aotButton
            // 
            this.aotButton.AutoSize = true;
            this.aotButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aotButton.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aotButton.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.aotButton.Location = new System.Drawing.Point(276, 4);
            this.aotButton.Name = "aotButton";
            this.aotButton.Size = new System.Drawing.Size(103, 17);
            this.aotButton.TabIndex = 2;
            this.aotButton.Text = "Always On Top";
            this.aotButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.aotButton.Click += new System.EventHandler(this.aotButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.aotButton);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.introPanel);
            this.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "MININOTE";
            this.introPanel.ResumeLayout(false);
            this.introPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.toDoTab.ResumeLayout(false);
            this.toDoTab.PerformLayout();
            this.todoListPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel introPanel;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label blLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TabControl mainMenu;
        private System.Windows.Forms.TabPage toDoTab;
        private System.Windows.Forms.TabPage noteTab;
        private System.Windows.Forms.Label totalCount;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel todoListPanel;
        private System.Windows.Forms.Label aotButton;
        //private ToDoItem toDoItem1;
        //private ToDoItem toDoItem2;
    }
}

