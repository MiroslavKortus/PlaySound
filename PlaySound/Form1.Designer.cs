namespace PlaySound
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
            btnPlaySentence = new Button();
            lblLesson = new Label();
            numUpDnLessonNumber = new NumericUpDown();
            btnLoadLessonData = new Button();
            lblHomeLanguageSentence = new Label();
            lblForeignLanguageSentence = new Label();
            tabCntrlMain = new TabControl();
            tabSentences = new TabPage();
            lblComment = new Label();
            btnDisplayTranslation = new Button();
            lblSoundFileName = new Label();
            btnPrevious = new Button();
            btnNext = new Button();
            tabArticles = new TabPage();
            btnPlayArticle = new Button();
            txtHomeLanguage = new TextBox();
            txtForeignLanguage = new TextBox();
            tabGrammar = new TabPage();
            ((System.ComponentModel.ISupportInitialize)numUpDnLessonNumber).BeginInit();
            tabCntrlMain.SuspendLayout();
            tabSentences.SuspendLayout();
            tabArticles.SuspendLayout();
            SuspendLayout();
            // 
            // btnPlaySentence
            // 
            btnPlaySentence.Location = new Point(1707, 781);
            btnPlaySentence.Name = "btnPlaySentence";
            btnPlaySentence.Size = new Size(94, 29);
            btnPlaySentence.TabIndex = 0;
            btnPlaySentence.Text = "Přehrát text";
            btnPlaySentence.UseVisualStyleBackColor = true;
            btnPlaySentence.Click += btnPlaySentence_Click;
            // 
            // lblLesson
            // 
            lblLesson.AutoSize = true;
            lblLesson.Location = new Point(14, 12);
            lblLesson.Name = "lblLesson";
            lblLesson.Size = new Size(46, 20);
            lblLesson.TabIndex = 1;
            lblLesson.Text = "Lekce";
            // 
            // numUpDnLessonNumber
            // 
            numUpDnLessonNumber.Location = new Point(63, 9);
            numUpDnLessonNumber.Margin = new Padding(3, 4, 3, 4);
            numUpDnLessonNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numUpDnLessonNumber.Name = "numUpDnLessonNumber";
            numUpDnLessonNumber.Size = new Size(45, 27);
            numUpDnLessonNumber.TabIndex = 2;
            numUpDnLessonNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numUpDnLessonNumber.KeyPress += numUpDnLessonNumber_KeyPress;
            // 
            // btnLoadLessonData
            // 
            btnLoadLessonData.Location = new Point(114, 7);
            btnLoadLessonData.Margin = new Padding(3, 4, 3, 4);
            btnLoadLessonData.Name = "btnLoadLessonData";
            btnLoadLessonData.Size = new Size(86, 31);
            btnLoadLessonData.TabIndex = 3;
            btnLoadLessonData.Text = "Načíst lekci";
            btnLoadLessonData.UseVisualStyleBackColor = true;
            btnLoadLessonData.Click += btnLoadLessonData_Click;
            // 
            // lblHomeLanguageSentence
            // 
            lblHomeLanguageSentence.AutoSize = true;
            lblHomeLanguageSentence.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblHomeLanguageSentence.Location = new Point(25, 37);
            lblHomeLanguageSentence.MaximumSize = new Size(1614, 53);
            lblHomeLanguageSentence.Name = "lblHomeLanguageSentence";
            lblHomeLanguageSentence.Size = new Size(0, 46);
            lblHomeLanguageSentence.TabIndex = 4;
            // 
            // lblForeignLanguageSentence
            // 
            lblForeignLanguageSentence.AutoSize = true;
            lblForeignLanguageSentence.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblForeignLanguageSentence.Location = new Point(25, 171);
            lblForeignLanguageSentence.MaximumSize = new Size(1614, 106);
            lblForeignLanguageSentence.Name = "lblForeignLanguageSentence";
            lblForeignLanguageSentence.Size = new Size(0, 46);
            lblForeignLanguageSentence.TabIndex = 5;
            // 
            // tabCntrlMain
            // 
            tabCntrlMain.Controls.Add(tabSentences);
            tabCntrlMain.Controls.Add(tabArticles);
            tabCntrlMain.Controls.Add(tabGrammar);
            tabCntrlMain.Dock = DockStyle.Bottom;
            tabCntrlMain.Location = new Point(0, 62);
            tabCntrlMain.Margin = new Padding(3, 4, 3, 4);
            tabCntrlMain.Name = "tabCntrlMain";
            tabCntrlMain.SelectedIndex = 0;
            tabCntrlMain.Size = new Size(1813, 891);
            tabCntrlMain.TabIndex = 6;
            // 
            // tabSentences
            // 
            tabSentences.Controls.Add(lblComment);
            tabSentences.Controls.Add(btnDisplayTranslation);
            tabSentences.Controls.Add(lblSoundFileName);
            tabSentences.Controls.Add(btnPrevious);
            tabSentences.Controls.Add(btnNext);
            tabSentences.Controls.Add(btnPlaySentence);
            tabSentences.Controls.Add(lblHomeLanguageSentence);
            tabSentences.Controls.Add(lblForeignLanguageSentence);
            tabSentences.Location = new Point(4, 29);
            tabSentences.Margin = new Padding(3, 4, 3, 4);
            tabSentences.Name = "tabSentences";
            tabSentences.Padding = new Padding(3, 4, 3, 4);
            tabSentences.Size = new Size(1805, 858);
            tabSentences.TabIndex = 0;
            tabSentences.Text = "Sentences";
            tabSentences.UseVisualStyleBackColor = true;
            // 
            // lblComment
            // 
            lblComment.AutoSize = true;
            lblComment.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblComment.Location = new Point(25, 333);
            lblComment.MaximumSize = new Size(1499, 106);
            lblComment.Name = "lblComment";
            lblComment.Size = new Size(0, 46);
            lblComment.TabIndex = 10;
            // 
            // btnDisplayTranslation
            // 
            btnDisplayTranslation.Location = new Point(1707, 737);
            btnDisplayTranslation.Name = "btnDisplayTranslation";
            btnDisplayTranslation.Size = new Size(94, 29);
            btnDisplayTranslation.TabIndex = 9;
            btnDisplayTranslation.Text = "Překlad";
            btnDisplayTranslation.UseVisualStyleBackColor = true;
            btnDisplayTranslation.Click += btnDisplayTranslation_Click;
            // 
            // lblSoundFileName
            // 
            lblSoundFileName.AutoSize = true;
            lblSoundFileName.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSoundFileName.Location = new Point(25, 564);
            lblSoundFileName.Name = "lblSoundFileName";
            lblSoundFileName.Size = new Size(0, 46);
            lblSoundFileName.TabIndex = 8;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(1707, 579);
            btnPrevious.Margin = new Padding(3, 4, 3, 4);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(86, 31);
            btnPrevious.TabIndex = 7;
            btnPrevious.Text = "Předchozí";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(1707, 628);
            btnNext.Margin = new Padding(3, 4, 3, 4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(86, 31);
            btnNext.TabIndex = 6;
            btnNext.Text = "Následující";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // tabArticles
            // 
            tabArticles.Controls.Add(btnPlayArticle);
            tabArticles.Controls.Add(txtHomeLanguage);
            tabArticles.Controls.Add(txtForeignLanguage);
            tabArticles.Location = new Point(4, 29);
            tabArticles.Name = "tabArticles";
            tabArticles.Size = new Size(1805, 858);
            tabArticles.TabIndex = 2;
            tabArticles.Text = "Articles";
            tabArticles.UseVisualStyleBackColor = true;
            // 
            // btnPlayArticle
            // 
            btnPlayArticle.Location = new Point(1689, 820);
            btnPlayArticle.Name = "btnPlayArticle";
            btnPlayArticle.Size = new Size(105, 29);
            btnPlayArticle.TabIndex = 2;
            btnPlayArticle.Text = "Čti Článek";
            btnPlayArticle.UseVisualStyleBackColor = true;
            btnPlayArticle.Click += btnPlayArticle_Click;
            // 
            // txtHomeLanguage
            // 
            txtHomeLanguage.AcceptsReturn = true;
            txtHomeLanguage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtHomeLanguage.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtHomeLanguage.Location = new Point(903, 20);
            txtHomeLanguage.Multiline = true;
            txtHomeLanguage.Name = "txtHomeLanguage";
            txtHomeLanguage.Size = new Size(891, 791);
            txtHomeLanguage.TabIndex = 1;
            // 
            // txtForeignLanguage
            // 
            txtForeignLanguage.AcceptsReturn = true;
            txtForeignLanguage.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtForeignLanguage.Location = new Point(10, 20);
            txtForeignLanguage.Multiline = true;
            txtForeignLanguage.Name = "txtForeignLanguage";
            txtForeignLanguage.Size = new Size(891, 791);
            txtForeignLanguage.TabIndex = 0;
            // 
            // tabGrammar
            // 
            tabGrammar.Location = new Point(4, 29);
            tabGrammar.Margin = new Padding(3, 4, 3, 4);
            tabGrammar.Name = "tabGrammar";
            tabGrammar.Padding = new Padding(3, 4, 3, 4);
            tabGrammar.Size = new Size(1805, 858);
            tabGrammar.TabIndex = 1;
            tabGrammar.Text = "Grammar";
            tabGrammar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1813, 953);
            Controls.Add(tabCntrlMain);
            Controls.Add(btnLoadLessonData);
            Controls.Add(numUpDnLessonNumber);
            Controls.Add(lblLesson);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numUpDnLessonNumber).EndInit();
            tabCntrlMain.ResumeLayout(false);
            tabSentences.ResumeLayout(false);
            tabSentences.PerformLayout();
            tabArticles.ResumeLayout(false);
            tabArticles.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPlaySentence;
        private Label lblLesson;
        private NumericUpDown numUpDnLessonNumber;
        private Button btnLoadLessonData;
        private Label lblHomeLanguageSentence;
        private Label lblForeignLanguageSentence;
        private TabControl tabCntrlMain;
        private TabPage tabSentences;
        private TabPage tabGrammar;
        private Button btnNext;
        private Button btnPrevious;
        private Label lblSoundFileName;
        private Button btnDisplayTranslation;
        private Label lblComment;
        private TabPage tabArticles;
        private TextBox txtForeignLanguage;
        private Button btnPlayArticle;
        private TextBox txtHomeLanguage;
    }
}