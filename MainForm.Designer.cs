
namespace GoogleFakeAPI
{
   partial class MainForm
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
         this.txtSearch = new System.Windows.Forms.TextBox();
         this.listBox1 = new System.Windows.Forms.ListBox();
         this.SuspendLayout();
         // 
         // txtSearch
         // 
         this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
         this.txtSearch.Location = new System.Drawing.Point(0, 0);
         this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         this.txtSearch.Name = "txtSearch";
         this.txtSearch.Size = new System.Drawing.Size(800, 27);
         this.txtSearch.TabIndex = 0;
         this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
         // 
         // listBox1
         // 
         this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.listBox1.FormattingEnabled = true;
         this.listBox1.ItemHeight = 20;
         this.listBox1.Location = new System.Drawing.Point(0, 27);
         this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         this.listBox1.Name = "listBox1";
         this.listBox1.Size = new System.Drawing.Size(800, 535);
         this.listBox1.TabIndex = 1;
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 562);
         this.Controls.Add(this.listBox1);
         this.Controls.Add(this.txtSearch);
         this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         this.Name = "MainForm";
         this.Text = "Form1";
         this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
         this.Load += new System.EventHandler(this.MainForm_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox txtSearch;
      private System.Windows.Forms.ListBox listBox1;
   }
}

