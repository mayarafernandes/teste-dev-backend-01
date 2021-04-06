
namespace Owner.JogoGourmet.GUI
{
    partial class JogoGourmet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JogoGourmet));
            this.labelQuestion = new System.Windows.Forms.Label();
            this.panelKnowledge = new System.Windows.Forms.Panel();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.panelActions = new System.Windows.Forms.Panel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonNo = new System.Windows.Forms.Button();
            this.buttonYes = new System.Windows.Forms.Button();
            this.panelKnowledge.SuspendLayout();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelQuestion.Location = new System.Drawing.Point(1, 17);
            this.labelQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(650, 46);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "Pense em um prato que você gosta...";
            this.labelQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelKnowledge
            // 
            this.panelKnowledge.Controls.Add(this.textBoxAnswer);
            this.panelKnowledge.Controls.Add(this.labelQuestion);
            this.panelKnowledge.Location = new System.Drawing.Point(14, 14);
            this.panelKnowledge.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelKnowledge.Name = "panelKnowledge";
            this.panelKnowledge.Size = new System.Drawing.Size(652, 138);
            this.panelKnowledge.TabIndex = 1;
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAnswer.Location = new System.Drawing.Point(122, 74);
            this.textBoxAnswer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(408, 32);
            this.textBoxAnswer.TabIndex = 1;
            this.textBoxAnswer.Text = "answer";
            this.textBoxAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelActions
            // 
            this.panelActions.Controls.Add(this.buttonOk);
            this.panelActions.Controls.Add(this.buttonNo);
            this.panelActions.Controls.Add(this.buttonYes);
            this.panelActions.Location = new System.Drawing.Point(14, 155);
            this.panelActions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(652, 104);
            this.panelActions.TabIndex = 2;
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonOk.ForeColor = System.Drawing.Color.White;
            this.buttonOk.Location = new System.Drawing.Point(270, 25);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(117, 46);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonNo
            // 
            this.buttonNo.BackColor = System.Drawing.Color.Red;
            this.buttonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNo.ForeColor = System.Drawing.Color.White;
            this.buttonNo.Location = new System.Drawing.Point(330, 25);
            this.buttonNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(117, 46);
            this.buttonNo.TabIndex = 1;
            this.buttonNo.Text = "NÃO";
            this.buttonNo.UseVisualStyleBackColor = false;
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // buttonYes
            // 
            this.buttonYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonYes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonYes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonYes.ForeColor = System.Drawing.Color.White;
            this.buttonYes.Location = new System.Drawing.Point(206, 25);
            this.buttonYes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(117, 46);
            this.buttonYes.TabIndex = 0;
            this.buttonYes.Text = "SIM";
            this.buttonYes.UseVisualStyleBackColor = false;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // JogoGourmet
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 265);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.panelKnowledge);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "JogoGourmet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo Gourmet";
            this.panelKnowledge.ResumeLayout(false);
            this.panelKnowledge.PerformLayout();
            this.panelActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Panel panelKnowledge;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.TextBox textBoxAnswer;
    }
}

