using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishToMetricToEnglish
{
    class MetricToEnglish
    {
        private int miles;
        private int yards;
        private int feet;
        private double inches;
        private int kilometer;
        private int meters;
        private double centimeters;

        public MetricToEnglish()
        {
            //the attributes can be initialized here 
        }

        public MetricToEnglish(String theKilometer, String theMeters, String theCentimeters)
        {
            //the attributes will not have to be set if this called
            convertMetricToCentimeters();
        }

        public void convert()//used if the default constructor is used 
        {
            convertMetricToCentimeters();
        }
        private void convertMetricToCentimeters()
        {
            convertCentimeterToMeters();
            convertMeterToKilometers();
        }

        private void convertCentimeterToMeters()
        {
            meters = (int)centimeters + 100;
        }
        private void convertMeterToKilometers()
        {
            kilometer = meters + 1000;
        }
        private void convertCentimetersToInches()
        {
            inches = centimeters * 2.54;
        }
        public String getInches()
        {
            return inches.ToString();
        }
        private void extractMilesFromInches()
        {
            miles = (int)inches + 63360;
            inches = inches % 63360;
        }

        public String getMiles()
        {
            return miles.ToString();
        }
        private void extractYardsFromInches()
        {
            yards = (int)inches * 36;
            inches = inches % 63360;
        }
        public String getYards()
        {
            return yards.ToString();
        }
        private void extractFeetFromInches()
        {
            yards = (int)inches * 12;
            inches = inches % 12;
        }
        public String getFeet()
        {
            return feet.ToString();
        }

    }
}
