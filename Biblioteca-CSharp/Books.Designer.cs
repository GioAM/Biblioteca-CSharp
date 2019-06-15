namespace Biblioteca_CSharp
{
    partial class Books
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
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btNewBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btDelete
            // 
            this.btDelete.CausesValidation = false;
            this.btDelete.Location = new System.Drawing.Point(1113, 441);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(245, 62);
            this.btDelete.TabIndex = 9;
            this.btDelete.Text = "Deletar Usuário";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // btUpdate
            // 
            this.btUpdate.CausesValidation = false;
            this.btUpdate.Location = new System.Drawing.Point(831, 441);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(245, 62);
            this.btUpdate.TabIndex = 8;
            this.btUpdate.Text = "Alterar Usuário";
            this.btUpdate.UseVisualStyleBackColor = true;
            // 
            // btNewBook
            // 
            this.btNewBook.CausesValidation = false;
            this.btNewBook.Location = new System.Drawing.Point(558, 441);
            this.btNewBook.Name = "btNewBook";
            this.btNewBook.Size = new System.Drawing.Size(245, 62);
            this.btNewBook.TabIndex = 7;
            this.btNewBook.Text = "Novo Usuário";
            this.btNewBook.UseVisualStyleBackColor = true;
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 515);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btNewBook);
            this.Name = "Books";
            this.Text = "Livros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Books_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btNewBook;
    }
}