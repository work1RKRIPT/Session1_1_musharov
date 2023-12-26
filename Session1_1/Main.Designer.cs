namespace Session1_1
{
    partial class Main
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.LabelMainText = new System.Windows.Forms.Label();
            this.buttonAuth = new System.Windows.Forms.Button();
            this.buttonTovar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(12, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(96, 33);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Закрыть";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // LabelMainText
            // 
            this.LabelMainText.AutoSize = true;
            this.LabelMainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMainText.Location = new System.Drawing.Point(107, 69);
            this.LabelMainText.Name = "LabelMainText";
            this.LabelMainText.Size = new System.Drawing.Size(275, 39);
            this.LabelMainText.TabIndex = 1;
            this.LabelMainText.Text = "Список товаров";
            // 
            // buttonAuth
            // 
            this.buttonAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAuth.Location = new System.Drawing.Point(147, 182);
            this.buttonAuth.Name = "buttonAuth";
            this.buttonAuth.Size = new System.Drawing.Size(197, 33);
            this.buttonAuth.TabIndex = 3;
            this.buttonAuth.Text = "Авторизация";
            this.buttonAuth.UseVisualStyleBackColor = true;
            // 
            // buttonTovar
            // 
            this.buttonTovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTovar.Location = new System.Drawing.Point(147, 143);
            this.buttonTovar.Name = "buttonTovar";
            this.buttonTovar.Size = new System.Drawing.Size(197, 33);
            this.buttonTovar.TabIndex = 4;
            this.buttonTovar.Text = "Смотреть товар";
            this.buttonTovar.UseVisualStyleBackColor = true;
            this.buttonTovar.Click += new System.EventHandler(this.buttonTovar_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 298);
            this.Controls.Add(this.buttonTovar);
            this.Controls.Add(this.buttonAuth);
            this.Controls.Add(this.LabelMainText);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label LabelMainText;
        private System.Windows.Forms.Button buttonAuth;
        private System.Windows.Forms.Button buttonTovar;
    }
}

