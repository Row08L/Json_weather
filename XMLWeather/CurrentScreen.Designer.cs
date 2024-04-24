namespace XMLWeather
{
    partial class CurrentScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.currentOutput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.locationTextInput = new System.Windows.Forms.TextBox();
            this.locationTextLabel = new System.Windows.Forms.Label();
            this.ticks = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cuTemp = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.apTemp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rainChance = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cloudCoverPercent = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.ForeColor = System.Drawing.Color.White;
            this.currentOutput.Location = new System.Drawing.Point(175, 151);
            this.currentOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(29, 16);
            this.currentOutput.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 34);
            this.label3.TabIndex = 40;
            this.label3.Text = "Today";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(188, 18);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(110, 34);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(26, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 33);
            this.label5.TabIndex = 42;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // locationTextInput
            // 
            this.locationTextInput.Location = new System.Drawing.Point(32, 86);
            this.locationTextInput.Name = "locationTextInput";
            this.locationTextInput.Size = new System.Drawing.Size(100, 22);
            this.locationTextInput.TabIndex = 43;
            this.locationTextInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.locationTextInput_KeyDown);
            this.locationTextInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.locationTextInput_KeyUp);
            // 
            // locationTextLabel
            // 
            this.locationTextLabel.AutoSize = true;
            this.locationTextLabel.ForeColor = System.Drawing.Color.White;
            this.locationTextLabel.Location = new System.Drawing.Point(31, 66);
            this.locationTextLabel.Name = "locationTextLabel";
            this.locationTextLabel.Size = new System.Drawing.Size(62, 17);
            this.locationTextLabel.TabIndex = 44;
            this.locationTextLabel.Text = "Location";
            // 
            // ticks
            // 
            this.ticks.Enabled = true;
            this.ticks.Tick += new System.EventHandler(this.ticks_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "label1";
            // 
            // cuTemp
            // 
            this.cuTemp.AutoSize = true;
            this.cuTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuTemp.ForeColor = System.Drawing.Color.White;
            this.cuTemp.Location = new System.Drawing.Point(177, 111);
            this.cuTemp.Name = "cuTemp";
            this.cuTemp.Size = new System.Drawing.Size(198, 55);
            this.cuTemp.TabIndex = 46;
            this.cuTemp.Text = "cuTemp";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(3, 466);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1103, 23);
            this.progressBar.TabIndex = 47;
            // 
            // apTemp
            // 
            this.apTemp.AutoSize = true;
            this.apTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apTemp.ForeColor = System.Drawing.Color.White;
            this.apTemp.Location = new System.Drawing.Point(135, 170);
            this.apTemp.Name = "apTemp";
            this.apTemp.Size = new System.Drawing.Size(85, 25);
            this.apTemp.TabIndex = 48;
            this.apTemp.Text = "apTemp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 29);
            this.label2.TabIndex = 49;
            this.label2.Text = "Current Temp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 29);
            this.label4.TabIndex = 50;
            this.label4.Text = "Feels Like:";
            // 
            // locationLabel
            // 
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.ForeColor = System.Drawing.Color.White;
            this.locationLabel.Location = new System.Drawing.Point(305, 12);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(801, 71);
            this.locationLabel.TabIndex = 51;
            this.locationLabel.Text = "location";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(226, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 29);
            this.label6.TabIndex = 52;
            this.label6.Text = "Cance of Percipitaion:";
            // 
            // rainChance
            // 
            this.rainChance.AutoSize = true;
            this.rainChance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rainChance.ForeColor = System.Drawing.Color.White;
            this.rainChance.Location = new System.Drawing.Point(480, 169);
            this.rainChance.Name = "rainChance";
            this.rainChance.Size = new System.Drawing.Size(47, 25);
            this.rainChance.TabIndex = 53;
            this.rainChance.Text = "rn%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(4, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 29);
            this.label7.TabIndex = 54;
            this.label7.Text = "Cloud Cover:";
            // 
            // cloudCoverPercent
            // 
            this.cloudCoverPercent.AutoSize = true;
            this.cloudCoverPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cloudCoverPercent.ForeColor = System.Drawing.Color.White;
            this.cloudCoverPercent.Location = new System.Drawing.Point(157, 209);
            this.cloudCoverPercent.Name = "cloudCoverPercent";
            this.cloudCoverPercent.Size = new System.Drawing.Size(70, 25);
            this.cloudCoverPercent.TabIndex = 55;
            this.cloudCoverPercent.Text = "cldC%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(39, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 25);
            this.label9.TabIndex = 57;
            this.label9.Text = "Hour";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(39, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 25);
            this.label8.TabIndex = 58;
            this.label8.Text = "Temp";
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cloudCoverPercent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rainChance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.apTemp);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.cuTemp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.locationTextLabel);
            this.Controls.Add(this.locationTextInput);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.currentOutput);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(1109, 492);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox locationTextInput;
        private System.Windows.Forms.Label locationTextLabel;
        private System.Windows.Forms.Timer ticks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cuTemp;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label apTemp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label rainChance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label cloudCoverPercent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}
