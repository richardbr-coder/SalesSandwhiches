namespace SalsSandwiches

{

    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblbread = new System.Windows.Forms.Label();
            this.lstSandwich = new System.Windows.Forms.ListBox();
            this.lstBreadType = new System.Windows.Forms.ListBox();
            this.lstAdditions = new System.Windows.Forms.ListBox();
            this.lblAdditions = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose a sandwich";

            // lblbread
            this.lblbread.AutoSize = true;
            this.lblbread.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbread.Location = new System.Drawing.Point(226, 46);
            this.lblbread.Name = "lblbread";
            this.lblbread.Size = new System.Drawing.Size(114, 20);
            this.lblbread.TabIndex = 1;
            this.lblbread.Text = "Types of bread";

            // lstSandwich
            this.lstSandwich.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSandwich.FormattingEnabled = true;
            this.lstSandwich.ItemHeight = 18;
            this.lstSandwich.Items.AddRange(new object[] {
                    "Roast beef ",
                    "Chicken",
                    "Turkey",
                    "Pork"});
            this.lstSandwich.Location = new System.Drawing.Point(37, 86);
            this.lstSandwich.Name = "lstSandwich";
            this.lstSandwich.Size = new System.Drawing.Size(140, 94);
            this.lstSandwich.TabIndex = 2;
            this.lstSandwich.SelectedIndexChanged += new System.EventHandler(this.lstSandwich_SelectedIndexChanged);

            // lstBreadType
            this.lstBreadType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBreadType.FormattingEnabled = true;
            this.lstBreadType.ItemHeight = 18;
            this.lstBreadType.Items.AddRange(new object[] {
                    "Whole wheat ",
                    "White",
                    "Cheese",
                    "Garlic 'white' Bread"});
            this.lstBreadType.Location = new System.Drawing.Point(215, 86);
            this.lstBreadType.Name = "lstBreadType";
            this.lstBreadType.Size = new System.Drawing.Size(140, 94);
            this.lstBreadType.TabIndex = 3;
            this.lstBreadType.SelectedIndexChanged += new System.EventHandler(this.lstBreadType_SelectedIndexChanged);

            // lstAdditions
            this.lstAdditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAdditions.FormattingEnabled = true;
            this.lstAdditions.ItemHeight = 18;
            this.lstAdditions.Items.AddRange(new object[] {
                    "Lettuce",
                    "Pickles",
                    "Onions"});
            this.lstAdditions.Location = new System.Drawing.Point(400, 86);
            this.lstAdditions.Name = "lstAdditions";
            this.lstAdditions.Size = new System.Drawing.Size(140, 94);
            this.lstAdditions.TabIndex = 4;
            this.lstAdditions.SelectedIndexChanged += new System.EventHandler(this.lstAdditions_SelectedIndexChanged);

            // lblAdditions
            this.lblAdditions.AutoSize = true;
            this.lblAdditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdditions.Location = new System.Drawing.Point(411, 46);
            this.lblAdditions.Name = "lblAdditions";
            this.lblAdditions.Size = new System.Drawing.Size(79, 20);
            this.lblAdditions.TabIndex = 5;
            this.lblAdditions.Text = "Additions ";

            // lblMessage
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(129, 264);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 20);
            this.lblMessage.TabIndex = 6;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 360);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblAdditions);
            this.Controls.Add(this.lstAdditions);
            this.Controls.Add(this.lstBreadType);
            this.Controls.Add(this.lstSandwich);
            this.Controls.Add(this.lblbread);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sandwich shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblbread;
        private System.Windows.Forms.ListBox lstSandwich;
        private System.Windows.Forms.ListBox lstBreadType;
        private System.Windows.Forms.ListBox lstAdditions;
        private System.Windows.Forms.Label lblAdditions;
        private System.Windows.Forms.Label lblMessage;

    }

}