using System;
using System.Collections;
using System.Drawing;
using System.Reflection;

namespace Picture_Sorter
{
    public static class ColorManagement
    {
        private static ArrayList WebColors = GetWebColors();
        /// <summary>
        /// Returns the "nearest" color from a given "color space"
        /// </summary>
        /// <param name="input_color">The color to be approximated</param>
        /// <returns>The nearest color</returns>
        public static Color GetNearestWebColor(Color input_color)
        {
            // initialize the RGB-Values of input_color
            double dbl_input_red = Convert.ToDouble(input_color.R);
            double dbl_input_green = Convert.ToDouble(input_color.G);
            double dbl_input_blue = Convert.ToDouble(input_color.B);
            // the Euclidean distance to be computed
            // set this to an arbitrary number
            // must be greater than the largest possible distance (appr. 441.7)
            double distance = 500.0;
            // store the interim result
            double temp;
            // RGB-Values of test colors
            double dbl_test_red;
            double dbl_test_green;
            double dbl_test_blue;
            // initialize the result
            Color nearest_color = Color.Empty;
            foreach (object o in WebColors)
            {
                // compute the Euclidean distance between the two colors
                // note, that the alpha-component is not used in this example
                dbl_test_red = Math.Pow(Convert.ToDouble(((Color)o).R) - dbl_input_red, 2.0);
                dbl_test_green = Math.Pow(Convert.ToDouble(((Color)o).G) - dbl_input_green, 2.0);
                dbl_test_blue = Math.Pow(Convert.ToDouble(((Color)o).B) - dbl_input_blue, 2.0);
                temp = Math.Sqrt(dbl_test_blue + dbl_test_green + dbl_test_red);
                // explore the result and store the nearest color
                if (temp < distance)
                {
                    distance = temp;
                    nearest_color = (Color)o;
                }
            }
            // done :-)
            return nearest_color;
        }
        /// <summary>
        /// Returns an ArrayList filled with "WebColors"
        /// </summary>
        /// <returns>WebColors</returns>
        /// <remarks>Many thanks to Julijan Sribar for his excellent article (http://www.codeproject.com/cs/miscctrl/MultiTabColorPicker.asp)</remarks>
        private static ArrayList GetWebColors()
        {
            Type color = (typeof(Color));
            PropertyInfo[] propertyInfos = color.GetProperties(BindingFlags.Public | BindingFlags.Static);
            ArrayList colors = new ArrayList();
            foreach (PropertyInfo pi in propertyInfos)
            {
                if (pi.PropertyType.Equals(typeof(Color)))
                {
                    Color c = (Color)pi.GetValue((object)(typeof(Color)), null);
                    colors.Add(c);
                }
            }
            return colors;
        }
    }
}
