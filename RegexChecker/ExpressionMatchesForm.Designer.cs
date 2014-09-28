namespace RegexChecker
{
    partial class ExpressionMatchesForm
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
            this.expressionsList = new System.Windows.Forms.ListBox();
            this.removeExpressionBtn = new System.Windows.Forms.Button();
            this.loadExpressionBtn = new System.Windows.Forms.Button();
            this.clearListBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // expressionsList
            // 
            this.expressionsList.FormattingEnabled = true;
            this.expressionsList.Location = new System.Drawing.Point(12, 12);
            this.expressionsList.Name = "expressionsList";
            this.expressionsList.Size = new System.Drawing.Size(260, 238);
            this.expressionsList.TabIndex = 0;
            // 
            // removeExpressionBtn
            // 
            this.removeExpressionBtn.Location = new System.Drawing.Point(197, 256);
            this.removeExpressionBtn.Name = "removeExpressionBtn";
            this.removeExpressionBtn.Size = new System.Drawing.Size(75, 23);
            this.removeExpressionBtn.TabIndex = 1;
            this.removeExpressionBtn.Text = "Remove";
            this.removeExpressionBtn.UseVisualStyleBackColor = true;
            this.removeExpressionBtn.Click += new System.EventHandler(this.removeExpressionBtn_Click);
            // 
            // loadExpressionBtn
            // 
            this.loadExpressionBtn.Location = new System.Drawing.Point(12, 256);
            this.loadExpressionBtn.Name = "loadExpressionBtn";
            this.loadExpressionBtn.Size = new System.Drawing.Size(75, 23);
            this.loadExpressionBtn.TabIndex = 2;
            this.loadExpressionBtn.Text = "Load";
            this.loadExpressionBtn.UseVisualStyleBackColor = true;
            this.loadExpressionBtn.Click += new System.EventHandler(this.loadExpressionBtn_Click);
            // 
            // clearListBtn
            // 
            this.clearListBtn.Location = new System.Drawing.Point(93, 256);
            this.clearListBtn.Name = "clearListBtn";
            this.clearListBtn.Size = new System.Drawing.Size(98, 23);
            this.clearListBtn.TabIndex = 3;
            this.clearListBtn.Text = "Clear All";
            this.clearListBtn.UseVisualStyleBackColor = true;
            this.clearListBtn.Click += new System.EventHandler(this.clearListBtn_Click);
            // 
            // ExpressionMatchesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 287);
            this.Controls.Add(this.clearListBtn);
            this.Controls.Add(this.loadExpressionBtn);
            this.Controls.Add(this.removeExpressionBtn);
            this.Controls.Add(this.expressionsList);
            this.Name = "ExpressionMatchesForm";
            this.Text = "Expression Matches";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExpressionMatchesForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox expressionsList;
        public System.Windows.Forms.Button removeExpressionBtn;
        private System.Windows.Forms.Button loadExpressionBtn;
        private System.Windows.Forms.Button clearListBtn;

    }
}