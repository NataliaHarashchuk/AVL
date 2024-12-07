namespace AlgoDes3
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
            this.AddButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VisualizeButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.LightGray;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(44, 65);
            this.AddButton.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(277, 72);
            this.AddButton.TabIndex = 0;
            this.AddButton.Tag = "AddButton";
            this.AddButton.Text = "Додати\r\n";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.LemonChiffon;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Location = new System.Drawing.Point(44, 181);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(277, 72);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Tag = "SearchButton";
            this.SearchButton.Text = "Знайти";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.NavajoWhite;
            this.EditButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditButton.Location = new System.Drawing.Point(48, 293);
            this.EditButton.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(277, 72);
            this.EditButton.TabIndex = 2;
            this.EditButton.Tag = "EditButton";
            this.EditButton.Text = "Змінити";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.LightCoral;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(44, 405);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(277, 72);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Tag = "DeleteButton";
            this.DeleteButton.Text = "Видалити";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.VisualizeButton);
            this.groupBox1.Controls.Add(this.EditButton);
            this.groupBox1.Controls.Add(this.SearchButton);
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Location = new System.Drawing.Point(40, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(40);
            this.groupBox1.Size = new System.Drawing.Size(365, 641);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // VisualizeButton
            // 
            this.VisualizeButton.BackColor = System.Drawing.Color.RosyBrown;
            this.VisualizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VisualizeButton.Location = new System.Drawing.Point(44, 519);
            this.VisualizeButton.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.VisualizeButton.Name = "VisualizeButton";
            this.VisualizeButton.Size = new System.Drawing.Size(277, 72);
            this.VisualizeButton.TabIndex = 4;
            this.VisualizeButton.Tag = "VisualizeButton";
            this.VisualizeButton.Text = "Візуалізувати";
            this.VisualizeButton.UseVisualStyleBackColor = false;
            this.VisualizeButton.Click += new System.EventHandler(this.VisualizeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(40);
            this.Text = "AVL Tree";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button VisualizeButton;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;

        #endregion
    }
}