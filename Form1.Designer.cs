namespace Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pname = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.txtpname = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pID = new System.Windows.Forms.Label();
            this.txtpID = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 62);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Registration";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtdiscount);
            this.panel2.Controls.Add(this.txtprice);
            this.panel2.Controls.Add(this.txtpname);
            this.panel2.Controls.Add(this.price);
            this.panel2.Controls.Add(this.discount);
            this.panel2.Controls.Add(this.pname);
            this.panel2.Location = new System.Drawing.Point(12, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 261);
            this.panel2.TabIndex = 1;
            // 
            // pname
            // 
            this.pname.AutoSize = true;
            this.pname.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pname.Location = new System.Drawing.Point(24, 37);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(148, 26);
            this.pname.TabIndex = 0;
            this.pname.Text = "Product Name";
            // 
            // discount
            // 
            this.discount.AutoSize = true;
            this.discount.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount.Location = new System.Drawing.Point(14, 183);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(96, 26);
            this.discount.TabIndex = 1;
            this.discount.Text = "Discount";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(34, 116);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(59, 26);
            this.price.TabIndex = 2;
            this.price.Text = "Price";
            // 
            // txtpname
            // 
            this.txtpname.Location = new System.Drawing.Point(246, 41);
            this.txtpname.Name = "txtpname";
            this.txtpname.Size = new System.Drawing.Size(240, 22);
            this.txtpname.TabIndex = 3;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(246, 120);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(240, 22);
            this.txtprice.TabIndex = 4;
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(246, 187);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(240, 22);
            this.txtdiscount.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(602, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(612, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 56);
            this.button2.TabIndex = 3;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pID
            // 
            this.pID.AutoSize = true;
            this.pID.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pID.Location = new System.Drawing.Point(37, 381);
            this.pID.Name = "pID";
            this.pID.Size = new System.Drawing.Size(113, 26);
            this.pID.TabIndex = 6;
            this.pID.Text = "Product ID";
            // 
            // txtpID
            // 
            this.txtpID.Location = new System.Drawing.Point(248, 381);
            this.txtpID.Name = "txtpID";
            this.txtpID.Size = new System.Drawing.Size(235, 22);
            this.txtpID.TabIndex = 7;
            this.txtpID.TextChanged += new System.EventHandler(this.txtpID_TextChanged);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(612, 365);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 52);
            this.button3.TabIndex = 4;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pID);
            this.Controls.Add(this.txtpID);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtpname;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label discount;
        private System.Windows.Forms.Label pname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtpID;
        private System.Windows.Forms.Label pID;
        private System.Windows.Forms.Button button3;
    }
}

