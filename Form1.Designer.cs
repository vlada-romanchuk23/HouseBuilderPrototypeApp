namespace HouseBuilderPrototypeApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateHouse = new System.Windows.Forms.Button();
            this.btnCloneHouse = new System.Windows.Forms.Button();
            this.listBoxHouses = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCreateHouse
            // 
            this.btnCreateHouse.Location = new System.Drawing.Point(51, 41);
            this.btnCreateHouse.Name = "btnCreateHouse";
            this.btnCreateHouse.Size = new System.Drawing.Size(134, 32);
            this.btnCreateHouse.TabIndex = 0;
            this.btnCreateHouse.Text = "Створити будинок";
            this.btnCreateHouse.UseVisualStyleBackColor = true;
            this.btnCreateHouse.Click += new System.EventHandler(this.btnCreateHouse_Click);
            // 
            // btnCloneHouse
            // 
            this.btnCloneHouse.Location = new System.Drawing.Point(51, 94);
            this.btnCloneHouse.Name = "btnCloneHouse";
            this.btnCloneHouse.Size = new System.Drawing.Size(134, 30);
            this.btnCloneHouse.TabIndex = 1;
            this.btnCloneHouse.Text = "Клонувати будинок";
            this.btnCloneHouse.UseVisualStyleBackColor = true;
            this.btnCloneHouse.Click += new System.EventHandler(this.btnCloneHouse_Click);
            // 
            // listBoxHouses
            // 
            this.listBoxHouses.FormattingEnabled = true;
            this.listBoxHouses.Location = new System.Drawing.Point(248, 41);
            this.listBoxHouses.Name = "listBoxHouses";
            this.listBoxHouses.Size = new System.Drawing.Size(430, 199);
            this.listBoxHouses.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxHouses);
            this.Controls.Add(this.btnCloneHouse);
            this.Controls.Add(this.btnCreateHouse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateHouse;
        private System.Windows.Forms.Button btnCloneHouse;
        private System.Windows.Forms.ListBox listBoxHouses;
    }
}

