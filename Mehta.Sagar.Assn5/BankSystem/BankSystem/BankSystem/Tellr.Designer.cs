namespace BankSystem
{
    partial class Tellr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tellr));
            this.name = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.amountLbl = new System.Windows.Forms.Label();
            this.depositBtn = new System.Windows.Forms.Button();
            this.withDrawBtn = new System.Windows.Forms.Button();
            this.checkBtn = new System.Windows.Forms.Button();
            this.openActBtn = new System.Windows.Forms.Button();
            this.buttonLookUp = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.textBoxLookup = new System.Windows.Forms.TextBox();
            this.money = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(111, 14);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 0;
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(111, 62);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.address.Size = new System.Drawing.Size(100, 56);
            this.address.TabIndex = 1;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(111, 147);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(100, 20);
            this.amount.TabIndex = 2;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(12, 19);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(78, 15);
            this.nameLbl.TabIndex = 3;
            this.nameLbl.Text = "Enter Name";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLbl.Location = new System.Drawing.Point(12, 82);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(88, 15);
            this.addressLbl.TabIndex = 4;
            this.addressLbl.Text = "Enter Address";
            // 
            // amountLbl
            // 
            this.amountLbl.AutoSize = true;
            this.amountLbl.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLbl.Location = new System.Drawing.Point(12, 147);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(91, 15);
            this.amountLbl.TabIndex = 5;
            this.amountLbl.Text = "Enter Amount";
            // 
            // depositBtn
            // 
            this.depositBtn.Location = new System.Drawing.Point(249, 16);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.Size = new System.Drawing.Size(167, 20);
            this.depositBtn.TabIndex = 6;
            this.depositBtn.Text = "Deposit";
            this.depositBtn.UseVisualStyleBackColor = true;
            this.depositBtn.Click += new System.EventHandler(this.depositBtn_Click);
            // 
            // withDrawBtn
            // 
            this.withDrawBtn.Location = new System.Drawing.Point(435, 16);
            this.withDrawBtn.Name = "withDrawBtn";
            this.withDrawBtn.Size = new System.Drawing.Size(167, 20);
            this.withDrawBtn.TabIndex = 7;
            this.withDrawBtn.Text = "WithDraw";
            this.withDrawBtn.UseVisualStyleBackColor = true;
            this.withDrawBtn.Click += new System.EventHandler(this.withDrawBtn_Click);
            // 
            // checkBtn
            // 
            this.checkBtn.Location = new System.Drawing.Point(249, 98);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(167, 20);
            this.checkBtn.TabIndex = 8;
            this.checkBtn.Text = "Delete Customer";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // openActBtn
            // 
            this.openActBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.openActBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openActBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.openActBtn.Location = new System.Drawing.Point(15, 192);
            this.openActBtn.Name = "openActBtn";
            this.openActBtn.Size = new System.Drawing.Size(196, 20);
            this.openActBtn.TabIndex = 9;
            this.openActBtn.Text = "Open a New Account";
            this.openActBtn.UseVisualStyleBackColor = false;
            this.openActBtn.Click += new System.EventHandler(this.openActBtn_Click);
            // 
            // buttonLookUp
            // 
            this.buttonLookUp.Location = new System.Drawing.Point(435, 98);
            this.buttonLookUp.Name = "buttonLookUp";
            this.buttonLookUp.Size = new System.Drawing.Size(167, 20);
            this.buttonLookUp.TabIndex = 10;
            this.buttonLookUp.Text = "LookUp/Check Balance";
            this.buttonLookUp.UseVisualStyleBackColor = true;
            this.buttonLookUp.Click += new System.EventHandler(this.buttonLookUp_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AllowDrop = true;
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(12, 246);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(98, 15);
            this.labelInfo.TabIndex = 11;
            this.labelInfo.Text = "Display Area:";
            this.labelInfo.Click += new System.EventHandler(this.labelInfo_Click);
            // 
            // textBoxLookup
            // 
            this.textBoxLookup.Location = new System.Drawing.Point(435, 145);
            this.textBoxLookup.Name = "textBoxLookup";
            this.textBoxLookup.Size = new System.Drawing.Size(167, 20);
            this.textBoxLookup.TabIndex = 12;
            // 
            // money
            // 
            this.money.Location = new System.Drawing.Point(435, 62);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(167, 20);
            this.money.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Enter Customer Number:";
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Enter Amount:   $";
            // 
            // Tellr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(619, 353);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.money);
            this.Controls.Add(this.textBoxLookup);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonLookUp);
            this.Controls.Add(this.openActBtn);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.withDrawBtn);
            this.Controls.Add(this.depositBtn);
            this.Controls.Add(this.amountLbl);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.address);
            this.Controls.Add(this.name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tellr";
            this.Text = "Teller";
            this.Load += new System.EventHandler(this.Tellr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox name;
        public System.Windows.Forms.TextBox address;
        public System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.Label amountLbl;
        public System.Windows.Forms.Button depositBtn;
        public System.Windows.Forms.Button withDrawBtn;
        public System.Windows.Forms.Button checkBtn;
        public System.Windows.Forms.Button openActBtn;
        public System.Windows.Forms.Button buttonLookUp;
        public System.Windows.Forms.Label labelInfo;
        public System.Windows.Forms.TextBox textBoxLookup;
        public System.Windows.Forms.TextBox money;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;

    }
}