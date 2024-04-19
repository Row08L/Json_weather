using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        bool enterDown = false;
        public CurrentScreen()
        {
            InitializeComponent();
            progressBar.Visible = false;
        }

        public void DisplayCurrent()
        {
        apTemp.Text = (string)Form1.jweather["current"]["apparent_temperature"] + (string)Form1.jweather["current_units"]["apparent_temperature"];
        cuTemp.Text = (string)Form1.jweather["current"]["temperature_2m"] + (string)Form1.jweather["current_units"]["temperature_2m"];
        locationLabel.Text = "Location: " + Form1.jweather["location"];
        rainChance.Text = (string)Form1.jweather["daily"]["precipitation_probability_max"][0] + (string)Form1.jweather["daily_units"]["precipitation_probability_max"];
        cloudCoverPercent.Text = (string)Form1.jweather["current"]["cloud_cover"] + (string)Form1.jweather["current_units"]["cloud_cover"];

        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void locationTextInput_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (enterDown == true)
                    {
                        enterDown = false;
                    }
                    break;
            }
        }

        private void locationTextInput_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (enterDown == false)
                    {
                        Form1.place = locationTextInput.Text;
                        Form1.ExtractAll();
                        progressBar.Value = 0;
                        progressBar.Visible = true;
                        enterDown = true;
                    }
                    break;
            }
        }

        private void ticks_Tick(object sender, EventArgs e)
        {
            if (Form1.jweather != null)
            {
                progressBar.Value = 100;
                DisplayCurrent();
            }
            if (progressBar.Value == 100)
            {
                progressBar.Visible = false;
            }
        }
    }
}
