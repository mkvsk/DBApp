
namespace DataBaseApp
{
    partial class FormLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogIn));
            this.labelLog = new System.Windows.Forms.Label();
            this.panelAllElements = new System.Windows.Forms.Panel();
            this.Loader = new System.Windows.Forms.PictureBox();
            this.buttonNextStep = new System.Windows.Forms.Button();
            this.panelDataToEnter = new System.Windows.Forms.Panel();
            this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.textBoxDataToEnter = new System.Windows.Forms.TextBox();
            this.panelAllElements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Loader)).BeginInit();
            this.panelDataToEnter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.labelLog.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelLog.Location = new System.Drawing.Point(56, 42);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(97, 37);
            this.labelLog.TabIndex = 0;
            this.labelLog.Text = "LOGIN";
            this.labelLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelAllElements
            // 
            this.panelAllElements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panelAllElements.Controls.Add(this.labelLog);
            this.panelAllElements.Controls.Add(this.Loader);
            this.panelAllElements.Controls.Add(this.buttonNextStep);
            this.panelAllElements.Controls.Add(this.panelDataToEnter);
            this.panelAllElements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAllElements.Location = new System.Drawing.Point(0, 0);
            this.panelAllElements.Name = "panelAllElements";
            this.panelAllElements.Size = new System.Drawing.Size(509, 286);
            this.panelAllElements.TabIndex = 0;
            // 
            // Loader
            // 
            this.Loader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Loader.Image = ((System.Drawing.Image)(resources.GetObject("Loader.Image")));
            this.Loader.Location = new System.Drawing.Point(215, 114);
            this.Loader.Name = "Loader";
            this.Loader.Size = new System.Drawing.Size(80, 80);
            this.Loader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Loader.TabIndex = 0;
            this.Loader.TabStop = false;
            this.Loader.Visible = false;
            // 
            // buttonNextStep
            // 
            this.buttonNextStep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNextStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonNextStep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNextStep.Enabled = false;
            this.buttonNextStep.FlatAppearance.BorderSize = 0;
            this.buttonNextStep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(84)))), ((int)(((byte)(149)))));
            this.buttonNextStep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonNextStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextStep.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNextStep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.buttonNextStep.Location = new System.Drawing.Point(62, 200);
            this.buttonNextStep.Name = "buttonNextStep";
            this.buttonNextStep.Size = new System.Drawing.Size(388, 56);
            this.buttonNextStep.TabIndex = 1;
            this.buttonNextStep.Text = "password";
            this.buttonNextStep.UseVisualStyleBackColor = false;
            this.buttonNextStep.Click += new System.EventHandler(this.buttonNextStep_Click);
            // 
            // panelDataToEnter
            // 
            this.panelDataToEnter.BackColor = System.Drawing.Color.White;
            this.panelDataToEnter.Controls.Add(this.pictureBoxPassword);
            this.panelDataToEnter.Controls.Add(this.pictureBoxUser);
            this.panelDataToEnter.Controls.Add(this.textBoxDataToEnter);
            this.panelDataToEnter.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelDataToEnter.Location = new System.Drawing.Point(62, 119);
            this.panelDataToEnter.Name = "panelDataToEnter";
            this.panelDataToEnter.Size = new System.Drawing.Size(388, 56);
            this.panelDataToEnter.TabIndex = 0;
            // 
            // pictureBoxPassword
            // 
            this.pictureBoxPassword.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPassword.Image")));
            this.pictureBoxPassword.Location = new System.Drawing.Point(15, 10);
            this.pictureBoxPassword.Name = "pictureBoxPassword";
            this.pictureBoxPassword.Size = new System.Drawing.Size(36, 36);
            this.pictureBoxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPassword.TabIndex = 2;
            this.pictureBoxPassword.TabStop = false;
            this.pictureBoxPassword.Visible = false;
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUser.Image")));
            this.pictureBoxUser.Location = new System.Drawing.Point(15, 10);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(36, 36);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUser.TabIndex = 1;
            this.pictureBoxUser.TabStop = false;
            // 
            // textBoxDataToEnter
            // 
            this.textBoxDataToEnter.BackColor = System.Drawing.Color.White;
            this.textBoxDataToEnter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDataToEnter.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDataToEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxDataToEnter.Location = new System.Drawing.Point(62, 11);
            this.textBoxDataToEnter.Name = "textBoxDataToEnter";
            this.textBoxDataToEnter.Size = new System.Drawing.Size(312, 32);
            this.textBoxDataToEnter.TabIndex = 0;
            this.textBoxDataToEnter.TabStop = false;
            this.textBoxDataToEnter.Text = "enter username";
            this.textBoxDataToEnter.Click += new System.EventHandler(this.textBoxDataToEnter_Click);
            this.textBoxDataToEnter.TextChanged += new System.EventHandler(this.textBoxDataToEnter_TextChanged);
            this.textBoxDataToEnter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxDataToEnter_KeyDown);
            this.textBoxDataToEnter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDataToEnter_KeyPress);
            // 
            // FormLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(509, 286);
            this.Controls.Add(this.panelAllElements);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(525, 325);
            this.MinimumSize = new System.Drawing.Size(525, 325);
            this.Name = "FormLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLogIn_FormClosed);
            this.Load += new System.EventHandler(this.FormLogIn_Load);
            this.panelAllElements.ResumeLayout(false);
            this.panelAllElements.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Loader)).EndInit();
            this.panelDataToEnter.ResumeLayout(false);
            this.panelDataToEnter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.Panel panelAllElements;
        private System.Windows.Forms.PictureBox Loader;
        private System.Windows.Forms.Panel panelDataToEnter;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.TextBox textBoxDataToEnter;
        private System.Windows.Forms.Button buttonNextStep;
    }
}

