namespace Biblioteca_CSharp
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pbImageBook = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.btNewUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageBook)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(78, 58);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(136, 20);
            this.tbUsername.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(78, 90);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(136, 20);
            this.tbPassword.TabIndex = 1;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(15, 58);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(57, 17);
            this.lbUsername.TabIndex = 2;
            this.lbUsername.Text = "Usuário";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(15, 90);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(49, 17);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "Senha";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "books_1-512.png");
            // 
            // pbImageBook
            // 
            this.pbImageBook.Image = ((System.Drawing.Image)(resources.GetObject("pbImageBook.Image")));
            this.pbImageBook.Location = new System.Drawing.Point(270, 58);
            this.pbImageBook.Name = "pbImageBook";
            this.pbImageBook.Size = new System.Drawing.Size(130, 136);
            this.pbImageBook.TabIndex = 4;
            this.pbImageBook.TabStop = false;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(172, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(96, 25);
            this.lbTitle.TabIndex = 5;
            this.lbTitle.Text = "Biblioteca";
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(78, 142);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(136, 23);
            this.btLogin.TabIndex = 6;
            this.btLogin.Text = "Entrar";
            this.btLogin.UseVisualStyleBackColor = true;
            // 
            // btNewUser
            // 
            this.btNewUser.Location = new System.Drawing.Point(78, 171);
            this.btNewUser.Name = "btNewUser";
            this.btNewUser.Size = new System.Drawing.Size(136, 23);
            this.btNewUser.TabIndex = 7;
            this.btNewUser.Text = "Novo Usuário";
            this.btNewUser.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 225);
            this.Controls.Add(this.btNewUser);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pbImageBook);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImageBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pbImageBook;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btNewUser;
    }
}

