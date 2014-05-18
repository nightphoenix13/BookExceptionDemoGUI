namespace BookExceptionDemoGUI
{
    partial class Form1
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.pagesLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.pagesTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.newBookGroupBox = new System.Windows.Forms.GroupBox();
            this.removeBookGroupBox = new System.Windows.Forms.GroupBox();
            this.bookComboBox = new System.Windows.Forms.ComboBox();
            this.addBookButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.bookGroupBox = new System.Windows.Forms.GroupBox();
            this.booksTextBox = new System.Windows.Forms.TextBox();
            this.newBookGroupBox.SuspendLayout();
            this.removeBookGroupBox.SuspendLayout();
            this.bookGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(10, 21);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title:";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(10, 43);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(41, 13);
            this.authorLabel.TabIndex = 1;
            this.authorLabel.Text = "Author:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(10, 65);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(43, 13);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Price: $";
            // 
            // pagesLabel
            // 
            this.pagesLabel.AutoSize = true;
            this.pagesLabel.Location = new System.Drawing.Point(10, 87);
            this.pagesLabel.Name = "pagesLabel";
            this.pagesLabel.Size = new System.Drawing.Size(40, 13);
            this.pagesLabel.TabIndex = 3;
            this.pagesLabel.Text = "Pages:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(59, 62);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 4;
            // 
            // pagesTextBox
            // 
            this.pagesTextBox.Location = new System.Drawing.Point(59, 84);
            this.pagesTextBox.Name = "pagesTextBox";
            this.pagesTextBox.Size = new System.Drawing.Size(100, 20);
            this.pagesTextBox.TabIndex = 5;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(59, 40);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(100, 20);
            this.authorTextBox.TabIndex = 6;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(59, 18);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 20);
            this.titleTextBox.TabIndex = 7;
            // 
            // newBookGroupBox
            // 
            this.newBookGroupBox.Controls.Add(this.addBookButton);
            this.newBookGroupBox.Controls.Add(this.authorTextBox);
            this.newBookGroupBox.Controls.Add(this.titleTextBox);
            this.newBookGroupBox.Controls.Add(this.titleLabel);
            this.newBookGroupBox.Controls.Add(this.authorLabel);
            this.newBookGroupBox.Controls.Add(this.pagesTextBox);
            this.newBookGroupBox.Controls.Add(this.priceLabel);
            this.newBookGroupBox.Controls.Add(this.priceTextBox);
            this.newBookGroupBox.Controls.Add(this.pagesLabel);
            this.newBookGroupBox.Location = new System.Drawing.Point(13, 13);
            this.newBookGroupBox.Name = "newBookGroupBox";
            this.newBookGroupBox.Size = new System.Drawing.Size(174, 141);
            this.newBookGroupBox.TabIndex = 8;
            this.newBookGroupBox.TabStop = false;
            this.newBookGroupBox.Text = "New Book";
            // 
            // removeBookGroupBox
            // 
            this.removeBookGroupBox.Controls.Add(this.removeButton);
            this.removeBookGroupBox.Controls.Add(this.bookComboBox);
            this.removeBookGroupBox.Location = new System.Drawing.Point(12, 160);
            this.removeBookGroupBox.Name = "removeBookGroupBox";
            this.removeBookGroupBox.Size = new System.Drawing.Size(174, 80);
            this.removeBookGroupBox.TabIndex = 9;
            this.removeBookGroupBox.TabStop = false;
            this.removeBookGroupBox.Text = "Remove Book";
            // 
            // bookComboBox
            // 
            this.bookComboBox.FormattingEnabled = true;
            this.bookComboBox.Items.AddRange(new object[] {
            "Book 1",
            "Book 2",
            "Book 3",
            "Book 4",
            "Book 5"});
            this.bookComboBox.Location = new System.Drawing.Point(27, 19);
            this.bookComboBox.Name = "bookComboBox";
            this.bookComboBox.Size = new System.Drawing.Size(121, 21);
            this.bookComboBox.TabIndex = 0;
            this.bookComboBox.Text = "Select a book:";
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(81, 110);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(78, 23);
            this.addBookButton.TabIndex = 8;
            this.addBookButton.Text = "Add Book -->";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Enabled = false;
            this.removeButton.Location = new System.Drawing.Point(50, 46);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // bookGroupBox
            // 
            this.bookGroupBox.Controls.Add(this.booksTextBox);
            this.bookGroupBox.Location = new System.Drawing.Point(194, 13);
            this.bookGroupBox.Name = "bookGroupBox";
            this.bookGroupBox.Size = new System.Drawing.Size(257, 227);
            this.bookGroupBox.TabIndex = 10;
            this.bookGroupBox.TabStop = false;
            this.bookGroupBox.Text = "Books";
            // 
            // booksTextBox
            // 
            this.booksTextBox.Location = new System.Drawing.Point(7, 20);
            this.booksTextBox.Multiline = true;
            this.booksTextBox.Name = "booksTextBox";
            this.booksTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.booksTextBox.Size = new System.Drawing.Size(244, 201);
            this.booksTextBox.TabIndex = 0;
            this.booksTextBox.Text = "No Current Books";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 249);
            this.Controls.Add(this.bookGroupBox);
            this.Controls.Add(this.removeBookGroupBox);
            this.Controls.Add(this.newBookGroupBox);
            this.Name = "Form1";
            this.Text = "Book Exception Demo";
            this.newBookGroupBox.ResumeLayout(false);
            this.newBookGroupBox.PerformLayout();
            this.removeBookGroupBox.ResumeLayout(false);
            this.bookGroupBox.ResumeLayout(false);
            this.bookGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label pagesLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox pagesTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.GroupBox newBookGroupBox;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.GroupBox removeBookGroupBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ComboBox bookComboBox;
        private System.Windows.Forms.GroupBox bookGroupBox;
        private System.Windows.Forms.TextBox booksTextBox;
    }
}

