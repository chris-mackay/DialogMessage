namespace DialogMessage
{
    partial class Message
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
            this.pnlWhiteSpace = new System.Windows.Forms.Panel();
            this.content = new System.Windows.Forms.Label();
            this.mainInstruction = new System.Windows.Forms.Label();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.pnlWhiteSpace.SuspendLayout();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWhiteSpace
            // 
            this.pnlWhiteSpace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWhiteSpace.BackColor = System.Drawing.Color.White;
            this.pnlWhiteSpace.Controls.Add(this.content);
            this.pnlWhiteSpace.Controls.Add(this.mainInstruction);
            this.pnlWhiteSpace.Location = new System.Drawing.Point(0, 0);
            this.pnlWhiteSpace.Name = "pnlWhiteSpace";
            this.pnlWhiteSpace.Size = new System.Drawing.Size(383, 79);
            this.pnlWhiteSpace.TabIndex = 1;
            // 
            // content
            // 
            this.content.AutoSize = true;
            this.content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.content.Location = new System.Drawing.Point(12, 48);
            this.content.MaximumSize = new System.Drawing.Size(353, 0);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(44, 13);
            this.content.TabIndex = 1;
            this.content.Text = "Content";
            // 
            // mainInstruction
            // 
            this.mainInstruction.AutoSize = true;
            this.mainInstruction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainInstruction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(188)))));
            this.mainInstruction.Location = new System.Drawing.Point(12, 9);
            this.mainInstruction.Margin = new System.Windows.Forms.Padding(5, 0, 3, 18);
            this.mainInstruction.MaximumSize = new System.Drawing.Size(353, 0);
            this.mainInstruction.Name = "mainInstruction";
            this.mainInstruction.Size = new System.Drawing.Size(123, 21);
            this.mainInstruction.TabIndex = 0;
            this.mainInstruction.Text = "Main Instruction";
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.Button1, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Button2, 1, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(232, 83);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(146, 29);
            this.TableLayoutPanel1.TabIndex = 2;
            // 
            // Button1
            // 
            this.Button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button1.Location = new System.Drawing.Point(3, 3);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(67, 23);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "Button1";
            // 
            // Button2
            // 
            this.Button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button2.Location = new System.Drawing.Point(76, 3);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(67, 23);
            this.Button2.TabIndex = 1;
            this.Button2.Text = "Button2";
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 118);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Controls.Add(this.pnlWhiteSpace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(360, 157);
            this.Name = "Message";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Window Title";
            this.Load += new System.EventHandler(this.DialogMessage_Load);
            this.pnlWhiteSpace.ResumeLayout(false);
            this.pnlWhiteSpace.PerformLayout();
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel pnlWhiteSpace;
        internal System.Windows.Forms.Label content;
        internal System.Windows.Forms.Label mainInstruction;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button Button2;
    }
}