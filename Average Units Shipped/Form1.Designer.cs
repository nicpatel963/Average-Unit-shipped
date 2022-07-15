
namespace Average_Units_Shipped
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
            this.components = new System.ComponentModel.Container();
            this.units = new System.Windows.Forms.Label();
            this.days_lbl = new System.Windows.Forms.Label();
            this.Results = new System.Windows.Forms.Label();
            this.inputbox = new System.Windows.Forms.TextBox();
            this.enterbtn = new System.Windows.Forms.Button();
            this.resetbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.displaybox = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // units
            // 
            this.units.AutoSize = true;
            this.units.Location = new System.Drawing.Point(70, 30);
            this.units.Name = "units";
            this.units.Size = new System.Drawing.Size(40, 17);
            this.units.TabIndex = 0;
            this.units.Text = "Units";
            // 
            // days_lbl
            // 
            this.days_lbl.AutoSize = true;
            this.days_lbl.Location = new System.Drawing.Point(222, 30);
            this.days_lbl.Name = "days_lbl";
            this.days_lbl.Size = new System.Drawing.Size(0, 17);
            this.days_lbl.TabIndex = 1;
            // 
            // Results
            // 
            this.Results.AutoSize = true;
            this.Results.Location = new System.Drawing.Point(70, 223);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(0, 17);
            this.Results.TabIndex = 0;
            // 
            // inputbox
            // 
            this.inputbox.Location = new System.Drawing.Point(116, 25);
            this.inputbox.Name = "inputbox";
            this.inputbox.Size = new System.Drawing.Size(100, 22);
            this.inputbox.TabIndex = 1;
            this.toolTip4.SetToolTip(this.inputbox, "In this box user add the unit according to the day");
            this.inputbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputbox_KeyPress);
            // 
            // enterbtn
            // 
            this.enterbtn.Location = new System.Drawing.Point(26, 253);
            this.enterbtn.Name = "enterbtn";
            this.enterbtn.Size = new System.Drawing.Size(84, 33);
            this.enterbtn.TabIndex = 2;
            this.enterbtn.Text = "Enter";
            this.toolTip1.SetToolTip(this.enterbtn, "This button will add the data into the display box");
            this.enterbtn.UseVisualStyleBackColor = true;
            this.enterbtn.Click += new System.EventHandler(this.enterbtn_Click);
            // 
            // resetbtn
            // 
            this.resetbtn.Location = new System.Drawing.Point(116, 253);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(85, 33);
            this.resetbtn.TabIndex = 3;
            this.resetbtn.Text = "Reset";
            this.toolTip2.SetToolTip(this.resetbtn, "This button will reset the application and start everything with zero");
            this.resetbtn.UseVisualStyleBackColor = true;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            this.resetbtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.resetbtn_KeyPress);
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(207, 253);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(80, 33);
            this.exitbtn.TabIndex = 4;
            this.exitbtn.Text = "Exit";
            this.toolTip3.SetToolTip(this.exitbtn, "This button is used to exit out of application");
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // displaybox
            // 
            this.displaybox.Location = new System.Drawing.Point(73, 62);
            this.displaybox.Name = "displaybox";
            this.displaybox.Size = new System.Drawing.Size(182, 158);
            this.displaybox.TabIndex = 5;
            this.displaybox.Text = "";
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 311);
            this.Controls.Add(this.displaybox);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.enterbtn);
            this.Controls.Add(this.inputbox);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.days_lbl);
            this.Controls.Add(this.units);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Units Shipped";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label units;
        private System.Windows.Forms.Label days_lbl;
        private System.Windows.Forms.Label Results;
        private System.Windows.Forms.TextBox inputbox;
        private System.Windows.Forms.Button enterbtn;
        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.RichTextBox displaybox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
    }
}

