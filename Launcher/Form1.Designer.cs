
using System.IO;

namespace Launcher
{
    partial class mainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.mainPnl = new System.Windows.Forms.Panel();
            this.btnInject = new System.Windows.Forms.Button();
            this.verLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.titleLbl = new System.Windows.Forms.Label();
            this.btnFrInject = new System.Windows.Forms.Button();
            this.mainPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPnl
            // 
            this.mainPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.mainPnl.Controls.Add(this.panel1);
            this.mainPnl.Controls.Add(this.verLbl);
            this.mainPnl.Controls.Add(this.btnInject);
            this.mainPnl.Location = new System.Drawing.Point(0, 0);
            this.mainPnl.Name = "mainPnl";
            this.mainPnl.Size = new System.Drawing.Size(314, 172);
            this.mainPnl.TabIndex = 0;
            // 
            // btnInject
            // 
            this.btnInject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInject.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInject.FlatAppearance.BorderSize = 0;
            this.btnInject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnInject.Location = new System.Drawing.Point(17, 114);
            this.btnInject.Name = "btnInject";
            this.btnInject.Size = new System.Drawing.Size(170, 40);
            this.btnInject.TabIndex = 2;
            this.btnInject.Text = "Inject into GTA V";
            this.btnInject.UseVisualStyleBackColor = false;
            this.btnInject.Click += new System.EventHandler(this.btnInject_Click);
            // 
            // verLbl
            // 
            this.verLbl.AutoSize = true;
            this.verLbl.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verLbl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.verLbl.Location = new System.Drawing.Point(14, 84);
            this.verLbl.Name = "verLbl";
            this.verLbl.Size = new System.Drawing.Size(171, 14);
            this.verLbl.TabIndex = 3;
            this.verLbl.Text = "Tims Pro Menu [unknown Version]";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.btnFrInject);
            this.panel1.Controls.Add(this.titleLbl);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 64);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.DarkRed;
            this.btnClose.Location = new System.Drawing.Point(283, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(17, 17);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.titleLbl.Location = new System.Drawing.Point(14, 13);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(173, 18);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = "Tims Pro Menu Injector";
            // 
            // btnFrInject
            // 
            this.btnFrInject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFrInject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFrInject.FlatAppearance.BorderSize = 0;
            this.btnFrInject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFrInject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrInject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnFrInject.Location = new System.Drawing.Point(17, 40);
            this.btnFrInject.Name = "btnFrInject";
            this.btnFrInject.Size = new System.Drawing.Size(75, 21);
            this.btnFrInject.TabIndex = 2;
            this.btnFrInject.Text = "Injection";
            this.btnFrInject.UseVisualStyleBackColor = false;
            this.btnFrInject.Click += new System.EventHandler(this.btnFrInject_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 172);
            this.Controls.Add(this.mainPnl);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tims Menu Injector";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.mainPnl.ResumeLayout(false);
            this.mainPnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPnl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFrInject;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label verLbl;
        private System.Windows.Forms.Button btnInject;
    }
}

