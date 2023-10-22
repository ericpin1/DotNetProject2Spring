namespace DotNetAssignment2
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
            this.label1 = new System.Windows.Forms.Label();
            this.TBCity = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labCondition = new System.Windows.Forms.Label();
            this.labDetails = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labSunrise = new System.Windows.Forms.Label();
            this.labSunset = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labWindSpeed = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labPressure = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labCloud = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(96, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "City:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TBCity
            // 
            this.TBCity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCity.Location = new System.Drawing.Point(152, 62);
            this.TBCity.Name = "TBCity";
            this.TBCity.Size = new System.Drawing.Size(197, 30);
            this.TBCity.TabIndex = 1;
            this.TBCity.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 10F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(375, 59);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 36);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labCondition
            // 
            this.labCondition.AutoSize = true;
            this.labCondition.BackColor = System.Drawing.Color.Transparent;
            this.labCondition.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCondition.ForeColor = System.Drawing.SystemColors.Window;
            this.labCondition.Location = new System.Drawing.Point(91, 230);
            this.labCondition.Name = "labCondition";
            this.labCondition.Size = new System.Drawing.Size(91, 23);
            this.labCondition.TabIndex = 3;
            this.labCondition.Text = "Condition";
            this.labCondition.Click += new System.EventHandler(this.label2_Click);
            // 
            // labDetails
            // 
            this.labDetails.AutoSize = true;
            this.labDetails.BackColor = System.Drawing.Color.Transparent;
            this.labDetails.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDetails.ForeColor = System.Drawing.SystemColors.Window;
            this.labDetails.Location = new System.Drawing.Point(91, 274);
            this.labDetails.Name = "labDetails";
            this.labDetails.Size = new System.Drawing.Size(70, 23);
            this.labDetails.TabIndex = 4;
            this.labDetails.Text = "Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(91, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sunrise:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // labSunrise
            // 
            this.labSunrise.AutoSize = true;
            this.labSunrise.BackColor = System.Drawing.Color.Transparent;
            this.labSunrise.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunrise.ForeColor = System.Drawing.SystemColors.Window;
            this.labSunrise.Location = new System.Drawing.Point(178, 317);
            this.labSunrise.Name = "labSunrise";
            this.labSunrise.Size = new System.Drawing.Size(42, 23);
            this.labSunrise.TabIndex = 6;
            this.labSunrise.Text = "N/A";
            this.labSunrise.Click += new System.EventHandler(this.label5_Click);
            // 
            // labSunset
            // 
            this.labSunset.AutoSize = true;
            this.labSunset.BackColor = System.Drawing.Color.Transparent;
            this.labSunset.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunset.ForeColor = System.Drawing.SystemColors.Window;
            this.labSunset.Location = new System.Drawing.Point(178, 356);
            this.labSunset.Name = "labSunset";
            this.labSunset.Size = new System.Drawing.Size(42, 23);
            this.labSunset.TabIndex = 8;
            this.labSunset.Text = "N/A";
            this.labSunset.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(91, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sunset:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // labWindSpeed
            // 
            this.labWindSpeed.AutoSize = true;
            this.labWindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labWindSpeed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWindSpeed.ForeColor = System.Drawing.SystemColors.Window;
            this.labWindSpeed.Location = new System.Drawing.Point(531, 230);
            this.labWindSpeed.Name = "labWindSpeed";
            this.labWindSpeed.Size = new System.Drawing.Size(42, 23);
            this.labWindSpeed.TabIndex = 10;
            this.labWindSpeed.Text = "N/A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(393, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "Wind Speed:";
            // 
            // labPressure
            // 
            this.labPressure.AutoSize = true;
            this.labPressure.BackColor = System.Drawing.Color.Transparent;
            this.labPressure.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPressure.ForeColor = System.Drawing.SystemColors.Window;
            this.labPressure.Location = new System.Drawing.Point(531, 274);
            this.labPressure.Name = "labPressure";
            this.labPressure.Size = new System.Drawing.Size(42, 23);
            this.labPressure.TabIndex = 12;
            this.labPressure.Text = "N/A";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(393, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 23);
            this.label10.TabIndex = 11;
            this.label10.Text = "Pressure:";
            // 
            // labCloud
            // 
            this.labCloud.AutoSize = true;
            this.labCloud.BackColor = System.Drawing.Color.Transparent;
            this.labCloud.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCloud.ForeColor = System.Drawing.SystemColors.Window;
            this.labCloud.Location = new System.Drawing.Point(531, 317);
            this.labCloud.Name = "labCloud";
            this.labCloud.Size = new System.Drawing.Size(42, 23);
            this.labCloud.TabIndex = 14;
            this.labCloud.Text = "N/A";
            this.labCloud.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Window;
            this.label12.Location = new System.Drawing.Point(393, 317);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 23);
            this.label12.TabIndex = 13;
            this.label12.Text = "Cloud:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Location = new System.Drawing.Point(100, 130);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(135, 77);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 15;
            this.picIcon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.labCloud);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.labPressure);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labWindSpeed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labSunset);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labSunrise);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labDetails);
            this.Controls.Add(this.labCondition);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.TBCity);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBCity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labCondition;
        private System.Windows.Forms.Label labDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labSunrise;
        private System.Windows.Forms.Label labSunset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labWindSpeed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labPressure;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labCloud;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox picIcon;
    }
}

