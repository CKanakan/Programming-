using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishToMetricToEnglish
{
    class EnglishToMetric
    {
        private int miles;
        private int yards;
        private int feet;
        private double inches;
        private int kilometer;
        private int meters;
        private double centimeters;

        public EnglishToMetric()
        {
            //the attributes will be initialized here 
        }

        public EnglishToMetric(String theMiles, String theYards, String feet, String theInches)
        {
            convertEnglishToInches();
            convertInchesToCentimeters();
            convertCentimetersToMetersAndKilometers();
        }

        //private bool setMiles(String theMiles)
        //{
        //This will set the Miles
        //}

        public void convert()
        {
            convertEnglishToInches();
        }

        private void convertEnglishToInches()
        {
            convertMilesToYards();
            convertYardsToFeet();
            convertFeetToInches();
        }

        private void convertMilesToYards()
        {
            yards += miles * 1760;
        }
        private void convertYardsToFeet()
        {
            feet = yards * 3;
        }

        private void convertFeetToInches()
        {
            inches = feet * 12;
        }
        private void convertInchesToCentimeters()
        {
            centimeters = inches * 0.393701;
        }
        private void extractKilometerFromCentimeter()
        {
            //will take centimeters and turn it into
            //Kilometers
            kilometer = (int)centimeters / 100000;
            centimeters = centimeters % 100000;
        }

        public String getKilometers()
        {
            return kilometer.ToString();
        }

        private void extractMetersFromCentimeter()
        {
            //will take centimeters and turn it into
            //Meters
            meters = (int)centimeters / 100;
            centimeters = centimeters % 100;
        }

        public String getMeters()
        {
            return meters.ToString();
        }

        private void convertCentimetersToMetersAndKilometers()
        {
            extractMetersFromCentimeter();
            extractKilometerFromCentimeter();
        }



    }
}
