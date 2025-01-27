namespace UI
{
    partial class BaseForm
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
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.ReatrieveAll = new System.Windows.Forms.Button();
            this.Reatrieve = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.BackHomeBase = new System.Windows.Forms.Button();
            this.BackToMain = new System.Windows.Forms.Button();
            this.BackHomeBase_2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Delete.Location = new System.Drawing.Point(855, 360);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(83, 23);
            this.Delete.TabIndex = 15;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Update.Location = new System.Drawing.Point(855, 306);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(83, 23);
            this.Update.TabIndex = 14;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // ReatrieveAll
            // 
            this.ReatrieveAll.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ReatrieveAll.Location = new System.Drawing.Point(855, 248);
            this.ReatrieveAll.Name = "ReatrieveAll";
            this.ReatrieveAll.Size = new System.Drawing.Size(83, 24);
            this.ReatrieveAll.TabIndex = 13;
            this.ReatrieveAll.Text = "Retrieve All";
            this.ReatrieveAll.UseVisualStyleBackColor = true;
            this.ReatrieveAll.Click += new System.EventHandler(this.ReatrieveAll_Click);
            // 
            // Reatrieve
            // 
            this.Reatrieve.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Reatrieve.Location = new System.Drawing.Point(855, 219);
            this.Reatrieve.Name = "Reatrieve";
            this.Reatrieve.Size = new System.Drawing.Size(83, 23);
            this.Reatrieve.TabIndex = 12;
            this.Reatrieve.Text = "Retrieve";
            this.Reatrieve.UseVisualStyleBackColor = true;
            this.Reatrieve.Click += new System.EventHandler(this.Reatrieve_Click);
            // 
            // Create
            // 
            this.Create.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Create.Location = new System.Drawing.Point(855, 165);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(83, 23);
            this.Create.TabIndex = 11;
            this.Create.Text = "New";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(71, 27);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(700, 439);
            this.listBox.TabIndex = 16;
            this.listBox.Visible = false;
            // 
            // BackHomeBase
            // 
            this.BackHomeBase.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BackHomeBase.Location = new System.Drawing.Point(114, 612);
            this.BackHomeBase.Name = "BackHomeBase";
            this.BackHomeBase.Size = new System.Drawing.Size(700, 23);
            this.BackHomeBase.TabIndex = 30;
            this.BackHomeBase.Text = "Back home";
            this.BackHomeBase.UseVisualStyleBackColor = true;
            this.BackHomeBase.Visible = false;
            this.BackHomeBase.Click += new System.EventHandler(this.BackHomeBase_Click);
            // 
            // BackToMain
            // 
            this.BackToMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BackToMain.Location = new System.Drawing.Point(866, 501);
            this.BackToMain.Name = "BackToMain";
            this.BackToMain.Size = new System.Drawing.Size(106, 28);
            this.BackToMain.TabIndex = 31;
            this.BackToMain.Text = "Back To Main";
            this.BackToMain.UseVisualStyleBackColor = true;
            this.BackToMain.Click += new System.EventHandler(this.BackToMain_Click);
            // 
            // BackHomeBase_2
            // 
            this.BackHomeBase_2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BackHomeBase_2.Location = new System.Drawing.Point(71, 501);
            this.BackHomeBase_2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackHomeBase_2.Name = "BackHomeBase_2";
            this.BackHomeBase_2.Size = new System.Drawing.Size(699, 20);
            this.BackHomeBase_2.TabIndex = 32;
            this.BackHomeBase_2.Text = "Back Home";
            this.BackHomeBase_2.UseVisualStyleBackColor = true;
            this.BackHomeBase_2.Visible = false;
            this.BackHomeBase_2.Click += new System.EventHandler(this.BackHome_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 541);
            this.Controls.Add(this.BackHomeBase_2);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.BackToMain);
            this.Controls.Add(this.BackHomeBase);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.ReatrieveAll);
            this.Controls.Add(this.Reatrieve);
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.ResumeLayout(false);

        }

        #endregion
        private Button Delete;
        private Button Update;
        private Button ReatrieveAll;
        private Button Reatrieve;
        private Button Create;
        protected ListBox listBox;
        protected Button BackHomeBase;
        private Button BackToMain;
        protected Button BackHomeBase_2;
    }
}