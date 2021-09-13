using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace statsProgram
{
    public partial class rtReorganized : Form
    {
        public rtReorganized()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            lbReorganized.Text = "Reorganized Data\n";
            lbModeFrequencies.Text = "Index, Freq, Val\n";
            lbSampleVar.Text = "Sample Variance = 0";
            lbStdVar.Text = "Standard Deviation = 0";
            lbMean.Text = "Mean:";
            lbMode.Text = "Mode:";
            lbMedian.Text = "Median:";
            lbSum.Text = "Sum:";
            lbRange.Text = "Range:";
            lbBellCurveX.Text = "Bell Curve X: 0";
            lbLargest.Text = "Largest Value:";
            lbSmallest.Text = "Smallest Value:";
            lbProportion.Text = "Proportion:";

        }

        private double getProportionWithinDev(List<double> doubleData, double lowerBound, double upperBound)
        {
            double countIfInBetween = 0;
            double numOfList = doubleData.Count;
            foreach (double num in doubleData)
            {
                if (num >= lowerBound && num <= upperBound)
                {
                    countIfInBetween += 1;
                }
            }

            double proportion = (countIfInBetween / numOfList);
            return proportion;
        }

        private double getSampleVar(double sum, List<double> doubleData)
        {
            double squaredVals = 0.0;
            foreach (double num in doubleData)
            {
                squaredVals += (num * num);
            }

            double sampleVar = (squaredVals - ((sum * sum) / doubleData.Count)) / (doubleData.Count - 1);
            return sampleVar;
        }

        private double getRange(List<double> doubleData)
        {
            return getElement(doubleData,doubleData.Count - 1) - getElement(doubleData, 0);
        }

        private double middleNum(List<double> doubleData, int quartile, int half, int quarter)
        {
            double whatNumber = 0.0;

            switch (quartile)
            {
                case 1:
                    whatNumber = doubleData.ElementAt(quarter);
                    break;
                case 2:
                    whatNumber = doubleData.ElementAt(half);
                    break;
                case 3:
                    whatNumber = doubleData.ElementAt(half + quarter + 1);
                    break;
            }
            return whatNumber;
        }

        private double doubleMedians(List<double> doubleData, int index)
        {
            double[] middleNums = { doubleData.ElementAt(index), doubleData.ElementAt(index - 1) };
            return middleNums.Sum() / 2;
        }


        private double getMedian(List<double> doubleData, int quartile)
        {

            double decHalf = doubleData.Count / 2.0;
            int half = (int)Math.Floor(decHalf); // because odd / odd = x.5 and since indexes start at 0, the floor provides the middle index

            double decQuarter = half / 2.0;
            int quarter = (int)Math.Floor(decQuarter); // floor because you need to think in terms of CS indexes. just add one later as needed

            double median = 0.0;
            try
            {
                if (doubleData.Count % 2 == 0)
                {
                    switch (quartile)
                    {
                        case 1:
                            median = doubleMedians(doubleData, quarter);
                            break;
                        case 2:
                            median = doubleMedians(doubleData, half);
                            break;
                        case 3:
                            median = doubleMedians(doubleData, quarter + half);
                            break;
                    }
                }
                else
                {
                    median = middleNum(doubleData, quartile, half, quarter);
                }
            }
            catch (Exception ex)
            {

            }
            return median;
        }

        private double getIQR(double q1, double q3)
        {
            return (q3 - q1);
        }

        private double getLowerFence(double q1, double iqr)
        {
            return (q1 - (1.5 * (iqr)));
        }
        private double getUpperFence(double q3, double iqr)
        {
            return (q3 + (1.5 * (iqr)));
        }

        private double getMostFrequent(Dictionary<double, int> groupedDoubleData)
        {
            //TODO: --1-- check for multiple modes

            double keyOfMostFrequent = 0.0;
            int mostFrequent = 1;

            foreach (KeyValuePair<double, int> kvp in groupedDoubleData)
            {
                /* if (kvp.Value != 1 && kvp.Value == mostFrequent)
                 {
                     //TODO: --1-- check for multiple modes
                 }
                 else */
                if (kvp.Value > mostFrequent)
                {
                    mostFrequent = kvp.Value;
                    keyOfMostFrequent = kvp.Key;
                }
            }
            return keyOfMostFrequent;
        }

        private string formatDbl(double num)
        {
            return String.Format("{0:0.000}", num);
        }

        private List<double> buildList(string[] dataArray)
        {
            List<double> doubleListData = new List<double>();

            foreach (string st in dataArray)
            {
                double asDouble = double.Parse(st);
                doubleListData.Add(asDouble);
            }
            return doubleListData;
        }

        private double sumOfList(List<double> data)
        {
            double sum = 0.0;
            foreach (double d in data)
            {
                sum += d;
            }
            return sum;
        }

        private double frequencyMean(double sumFreq, List<double> setData, List<double> freqData)
        {
            //TODO: --3-- get documentation on this. make sure midpoints are in DataSet and that the Frequencies of those midpoints are in the frequency section!

            //TODO: --3-- need to make it more clear that frequencies entered MUST BE ALIGNED WITH THE DATASET IN ASCENDING ORDER! so if dataSet contains 99, 40, 80 and the frequencies are 3, 17, 4; because the dataSet gets sorted in ASC, you MUST enter in the frequencies to correspond to the ascending order meaning it should be 17, 4, 3 so that the frequencies correspond to the correct indexed item
            try
            {
                double sumFreqDistribution = 0.0;
                for (int j = 0; j < setData.Count; j++)
                {
                    sumFreqDistribution += setData[j] * freqData[j];
                }
                double freqDev = sumFreqDistribution / sumFreq;
                return freqDev;
            }
            catch (Exception ex)
            {
                return 0.0;
            }
        }

        private double frequencyDeviation(double freqSimpleMean, double sumFreq, List<double> setData, List<double> freqData)
        {
            // USE THIS TO CHECK FOR DEVIATIONS WHENEVER HANDLING FREQUENCIES!
            try
            {
                double sumFreqDistribution = 0.0;
                for (int j = 0; j < setData.Count; j++)
                {
                    double i_sqr = Math.Round(Math.Abs(freqSimpleMean - setData[j]), 1);
                    sumFreqDistribution += (i_sqr * i_sqr) * freqData[j];
                }
                double freqDev = Math.Sqrt(sumFreqDistribution / sumFreq);
                return freqDev;
            }
            catch (Exception ex)
            {
                return 0.0;
            }
        }

        private double getElement(List<double> list, int index)
        {
            double value = 0.0;
            try
            {
                value = list.ElementAt(index);
            }
            catch
            {

            }
            return value;
        }

        private void Go()
        {
            Clear();
            try
            {

                #region Variable Declaration

                char[] splitTheseChars = new char[] { '\n', ',', ' ' };

                string[] arraySet = rtDataSet.Text.Split(splitTheseChars, StringSplitOptions.RemoveEmptyEntries);
                List<double> setData = buildList(arraySet);
                double sumSet = sumOfList(setData);
                setData.Sort();

                string[] arrayFreq = rtFrequency.Text.Split(splitTheseChars, StringSplitOptions.RemoveEmptyEntries);
                List<double> freqData = buildList(arrayFreq);
                double sumFreq = sumOfList(freqData);

                if (arrayFreq.Length != arraySet.Length && arrayFreq.Length != 0)
                {
                    MessageBox.Show("Frequency and Set data do not have the same number of entries!");
                }

                double stdDeviation = 0.0;
                double mean = sumSet / setData.Count;
                double median = getMedian(setData, 2);
                var allDoubles = from numbers in setData
                                 group numbers by numbers into grouped
                                 select new { Number = grouped.Key, Freq = grouped.Count() };
                Dictionary<double, int> groupedDoubleData = allDoubles.ToDictionary(x => x.Number, y => y.Freq);
                //groupedDoubleData.Add(0.0, 0); // 0 means no mode
                double mode = getMostFrequent(groupedDoubleData);
                double x_value = double.Parse(tbX_value.Text);
                double sampleVar = getSampleVar(sumSet, setData);
                stdDeviation = (sampleVar > 0 ? Math.Sqrt(sampleVar): double.Parse(tbZvalue_stdDev.Text));
                double smallestVal = getElement(setData, 0);
                double largestVal = getElement(setData, setData.Count - 1);
                double proportion = getProportionWithinDev(setData, double.Parse(tbDevLower.Text), double.Parse(tbDevUpper.Text));
                double coefficientOfVar = stdDeviation / mean;
                double std_dev_minus1 = x_value - stdDeviation;
                double std_dev_minus2 = x_value - (stdDeviation * 2);
                double std_dev_minus3 = x_value - (stdDeviation * 3);
                double std_dev_plus1 = x_value + stdDeviation;
                double std_dev_plus2 = x_value + (stdDeviation * 2);
                double std_dev_plus3 = x_value + (stdDeviation * 3);

                var std_dev_minus3_ratio = setData.Where(n => std_dev_minus3 <= n && n <= std_dev_minus2).Select(n => 1).Sum(n => n);
                var std_dev_minus2_ratio = setData.Where(n => std_dev_minus2 <= n && n <= std_dev_minus1).Select(n => 1).Sum(n => n);
                var std_dev_minus1_ratio = setData.Where(n => std_dev_minus1 <= n && n <= mean).Select(n => 1).Sum(n => n);
                var std_dev_plus3_ratio = setData.Where(n => std_dev_plus3 >= n && n >= std_dev_plus2).Select(n => 1).Sum(n => n);
                var std_dev_plus2_ratio = setData.Where(n => std_dev_plus2 >= n && n >= std_dev_plus1).Select(n => 1).Sum(n => n);
                var std_dev_plus1_ratio = setData.Where(n => std_dev_plus1 >= n && n >= mean).Select(n => 1).Sum(n => n);

                double freqSimpleMean = frequencyMean(sumFreq, setData, freqData);
                double freqStdDeviation = frequencyDeviation(freqSimpleMean, sumFreq, setData, freqData);
                double rounded_freqStdDeviation = Math.Round(freqStdDeviation, 1);
                double z_value = ((mean - x_value) / double.Parse(tbZvalue_stdDev.Text));
                double q1_median = getMedian(setData, 1);
                double q3_median = getMedian(setData, 3);
                double iqr = getIQR(q1_median, q3_median);
                double lower_fence = getLowerFence(q1_median, iqr);
                double upper_fence = getUpperFence(q3_median, iqr);

                #endregion Variable Declaration

                #region Text Modifying

                lbSum.Text = $"Sum: {formatDbl(sumSet)}";
                lbCount.Text = $"Count: {formatDbl(setData.Count)}";
                lbSmallest.Text = $"Smallest Value: {formatDbl(smallestVal)}";
                lbLargest.Text = $"Largest Value: {formatDbl(largestVal)}";
                lbMean.Text = $"Mean: {formatDbl(mean)}";
                lbMedian.Text = $"Median: {formatDbl(median)}";
                lbRange.Text = $"Range: {formatDbl(getRange(setData))}"; // occurs after it's sorted ascending so the smallest is at 0, largest is at .Count - 1
                lbStdVar.Text = $"Standard Deviation: {formatDbl(stdDeviation)}";
                lbSampleVar.Text = $"Sample Variance: {formatDbl(sampleVar)}";
                lbMode.Text = $"Mode: {formatDbl(mode)}";
                lbProportion.Text = $"Proportion: {formatDbl(proportion)}";
                lbCoefficientOfVar.Text = $"Coeff. of Var: {formatDbl(coefficientOfVar)}";
                lbFreqSimpleMean.Text = $"Freq. Simple Mean: {formatDbl(freqSimpleMean)}";
                lbFreqDeviation.Text = $"Freq. Deviation: {formatDbl(freqStdDeviation)}";
                lbZvalue.Text = $"z-value: {formatDbl(z_value)}"; // To Calculate, put the single mean number in the setData section, the manual deviation in z-val dev, and the "x" for the formula in the x/mean textbox right below it
                lbMedianQ1.Text = $"MedianQ1: {formatDbl(q1_median)}";
                lbMedianQ3.Text = $"MedianQ3: {formatDbl(q3_median)}";
                lb_iqr.Text = $"InterQuartileRange (IQR): {formatDbl(iqr)}";
                lbUpperFence.Text = $"Upper Fence: {formatDbl(upper_fence)}";
                lbLowerFence.Text = $"Lower Fence: {formatDbl(lower_fence)}";

                lbBellCurveX.Text = $"Bell Curve X: \n{formatDbl(std_dev_minus3)}, {formatDbl(std_dev_minus2)}, {formatDbl(std_dev_minus1)}, || {formatDbl(std_dev_plus1)}, {formatDbl(std_dev_plus2)}, {formatDbl(std_dev_plus3)}\n{formatDbl(std_dev_minus3_ratio)}, {formatDbl(std_dev_minus2_ratio)}, {formatDbl(std_dev_minus1_ratio)} || {formatDbl(std_dev_plus1_ratio)}, {formatDbl(std_dev_plus2_ratio)}, {formatDbl(std_dev_plus3_ratio)}";
                lbBellCurveX_freqStdDev.Text = $"Curve Freq. Dev: {formatDbl(x_value - (rounded_freqStdDeviation * 3))}, {formatDbl(x_value - (rounded_freqStdDeviation * 2))}, {formatDbl(x_value - rounded_freqStdDeviation)}, || {formatDbl(x_value + rounded_freqStdDeviation)}, {formatDbl(x_value + (rounded_freqStdDeviation * 2))}, {formatDbl(x_value + (rounded_freqStdDeviation * 3))}";

                foreach (double item in setData)
                {
                    lbReorganized.Text += $"{item}\n";
                }

                for (int i = 0; i < groupedDoubleData.Count; i++)
                {
                    string i_str = "";
                    if (i < 9)
                    {
                        i_str = $"0{i + 1}";
                    }
                    else
                    {
                        i_str = i.ToString();
                    }
                    lbModeFrequencies.Text += $"{i_str}: {groupedDoubleData.ElementAt(i).Value} - {groupedDoubleData.ElementAt(i).Key}\n";
                }

                #endregion Text Modifying
            }
            catch (Exception ex)
            {
                Clear();
            }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            Go();
        }

        private void tbX_value_TextChanged(object sender, EventArgs e)
        {
            Go();
        }

        private void tbDevLower_TextChanged(object sender, EventArgs e)
        {
            Go();
        }

        private void tbDevUpper_TextChanged(object sender, EventArgs e)
        {
            Go();
        }

        private void rtFrequency_TextChanged(object sender, EventArgs e)
        {
            Go();
        }

        private void tbZvalue_stdDev_TextChanged(object sender, EventArgs e)
        {
            Go();
        }
    }
}
