namespace MiniNote
{
    partial class ToDoItem
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.todoItemPanel = new System.Windows.Forms.TableLayoutPanel();
            this.statucButton = new System.Windows.Forms.Button();
            this.todoText = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Label();
            this.todoItemPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // todoItemPanel
            // 
            this.todoItemPanel.ColumnCount = 3;
            this.todoItemPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.todoItemPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 276F));
            this.todoItemPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.todoItemPanel.Controls.Add(this.statucButton, 0, 0);
            this.todoItemPanel.Controls.Add(this.todoText, 1, 0);
            this.todoItemPanel.Controls.Add(this.deleteButton, 2, 0);
            this.todoItemPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.todoItemPanel.Location = new System.Drawing.Point(0, 0);
            this.todoItemPanel.Margin = new System.Windows.Forms.Padding(0);
            this.todoItemPanel.Name = "todoItemPanel";
            this.todoItemPanel.RowCount = 1;
            this.todoItemPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.todoItemPanel.Size = new System.Drawing.Size(360, 34);
            this.todoItemPanel.TabIndex = 0;
            // 
            // statucButton
            // 
            this.statucButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statucButton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.statucButton.Location = new System.Drawing.Point(3, 3);
            this.statucButton.Name = "statucButton";
            this.statucButton.Size = new System.Drawing.Size(54, 28);
            this.statucButton.TabIndex = 0;
            this.statucButton.Text = "Doing";
            this.statucButton.UseVisualStyleBackColor = true;
            this.statucButton.Click += new System.EventHandler(this.statucButton_Click);
            // 
            // todoText
            // 
            this.todoText.AutoEllipsis = true;
            this.todoText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.todoText.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.todoText.Location = new System.Drawing.Point(63, 3);
            this.todoText.Margin = new System.Windows.Forms.Padding(3);
            this.todoText.Name = "todoText";
            this.todoText.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.todoText.Size = new System.Drawing.Size(270, 28);
            this.todoText.TabIndex = 1;
            this.todoText.Text = "label1asdf asdf asdf asdf asdf asd fasdfasdf asdf asdfasdf asdfasdfasdf asdf asdf" +
    " asdf";
            this.todoText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSize = true;
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButton.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.deleteButton.Location = new System.Drawing.Point(336, 3);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(21, 28);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "×";
            // 
            // ToDoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.todoItemPanel);
            this.Name = "ToDoItem";
            this.Size = new System.Drawing.Size(360, 34);
            this.todoItemPanel.ResumeLayout(false);
            this.todoItemPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel todoItemPanel;
        private System.Windows.Forms.Button statucButton;
        private System.Windows.Forms.Label todoText;
        private System.Windows.Forms.Label deleteButton;
    }
}
