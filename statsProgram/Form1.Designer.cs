
namespace statsProgram
{
    partial class rtReorganized
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtDataSet = new System.Windows.Forms.RichTextBox();
            this.lbDataSet = new System.Windows.Forms.Label();
            this.lbMean = new System.Windows.Forms.Label();
            this.lbMedian = new System.Windows.Forms.Label();
            this.lbMode = new System.Windows.Forms.Label();
            this.lbModeFrequencies = new System.Windows.Forms.Label();
            this.lbReorganized = new System.Windows.Forms.Label();
            this.lbSampleVar = new System.Windows.Forms.Label();
            this.lbSum = new System.Windows.Forms.Label();
            this.lbRange = new System.Windows.Forms.Label();
            this.lbStdVar = new System.Windows.Forms.Label();
            this.lbBellCurveX = new System.Windows.Forms.Label();
            this.tbX_value = new System.Windows.Forms.TextBox();
            this.lbSmallest = new System.Windows.Forms.Label();
            this.lbLargest = new System.Windows.Forms.Label();
            this.tbDevLower = new System.Windows.Forms.TextBox();
            this.tbDevUpper = new System.Windows.Forms.TextBox();
            this.lbProportion = new System.Windows.Forms.Label();
            this.lbDevHigh = new System.Windows.Forms.Label();
            this.lbDevLow = new System.Windows.Forms.Label();
            this.lbX = new System.Windows.Forms.Label();
            this.lbCoefficientOfVar = new System.Windows.Forms.Label();
            this.rtFrequency = new System.Windows.Forms.RichTextBox();
            this.lbFreq = new System.Windows.Forms.Label();
            this.lbFreqDeviation = new System.Windows.Forms.Label();
            this.lbFreqSimpleMean = new System.Windows.Forms.Label();
            this.lbBellCurveX_freqStdDev = new System.Windows.Forms.Label();
            this.lbZvalue = new System.Windows.Forms.Label();
            this.lbManual_stdDev = new System.Windows.Forms.Label();
            this.tbZvalue_stdDev = new System.Windows.Forms.TextBox();
            this.lbMedianQ1 = new System.Windows.Forms.Label();
            this.lbMedianQ3 = new System.Windows.Forms.Label();
            this.lbUpperFence = new System.Windows.Forms.Label();
            this.lb_iqr = new System.Windows.Forms.Label();
            this.lbLowerFence = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtDataSet
            // 
            this.rtDataSet.Location = new System.Drawing.Point(46, 68);
            this.rtDataSet.Name = "rtDataSet";
            this.rtDataSet.Size = new System.Drawing.Size(65, 138);
            this.rtDataSet.TabIndex = 1;
            this.rtDataSet.Text = "";
            this.rtDataSet.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // lbDataSet
            // 
            this.lbDataSet.AutoSize = true;
            this.lbDataSet.Location = new System.Drawing.Point(46, 50);
            this.lbDataSet.Name = "lbDataSet";
            this.lbDataSet.Size = new System.Drawing.Size(47, 15);
            this.lbDataSet.TabIndex = 2;
            this.lbDataSet.Text = "DataSet";
            // 
            // lbMean
            // 
            this.lbMean.AutoSize = true;
            this.lbMean.Location = new System.Drawing.Point(388, 116);
            this.lbMean.Name = "lbMean";
            this.lbMean.Size = new System.Drawing.Size(40, 15);
            this.lbMean.TabIndex = 3;
            this.lbMean.Text = "Mean:";
            // 
            // lbMedian
            // 
            this.lbMedian.AutoSize = true;
            this.lbMedian.Location = new System.Drawing.Point(378, 131);
            this.lbMedian.Name = "lbMedian";
            this.lbMedian.Size = new System.Drawing.Size(50, 15);
            this.lbMedian.TabIndex = 4;
            this.lbMedian.Text = "Median:";
            // 
            // lbMode
            // 
            this.lbMode.AutoSize = true;
            this.lbMode.Location = new System.Drawing.Point(387, 146);
            this.lbMode.Name = "lbMode";
            this.lbMode.Size = new System.Drawing.Size(41, 15);
            this.lbMode.TabIndex = 5;
            this.lbMode.Text = "Mode:";
            // 
            // lbModeFrequencies
            // 
            this.lbModeFrequencies.AutoSize = true;
            this.lbModeFrequencies.Location = new System.Drawing.Point(222, 59);
            this.lbModeFrequencies.Name = "lbModeFrequencies";
            this.lbModeFrequencies.Size = new System.Drawing.Size(86, 15);
            this.lbModeFrequencies.TabIndex = 6;
            this.lbModeFrequencies.Text = "Index, Freq, Val";
            // 
            // lbReorganized
            // 
            this.lbReorganized.AutoSize = true;
            this.lbReorganized.Location = new System.Drawing.Point(117, 59);
            this.lbReorganized.Name = "lbReorganized";
            this.lbReorganized.Size = new System.Drawing.Size(99, 15);
            this.lbReorganized.TabIndex = 7;
            this.lbReorganized.Text = "Reorganized Data";
            // 
            // lbSampleVar
            // 
            this.lbSampleVar.AutoSize = true;
            this.lbSampleVar.Location = new System.Drawing.Point(330, 176);
            this.lbSampleVar.Name = "lbSampleVar";
            this.lbSampleVar.Size = new System.Drawing.Size(98, 15);
            this.lbSampleVar.TabIndex = 8;
            this.lbSampleVar.Text = "Sample Variation:";
            // 
            // lbSum
            // 
            this.lbSum.AutoSize = true;
            this.lbSum.Location = new System.Drawing.Point(394, 71);
            this.lbSum.Name = "lbSum";
            this.lbSum.Size = new System.Drawing.Size(34, 15);
            this.lbSum.TabIndex = 9;
            this.lbSum.Text = "Sum:";
            // 
            // lbRange
            // 
            this.lbRange.AutoSize = true;
            this.lbRange.Location = new System.Drawing.Point(385, 161);
            this.lbRange.Name = "lbRange";
            this.lbRange.Size = new System.Drawing.Size(43, 15);
            this.lbRange.TabIndex = 10;
            this.lbRange.Text = "Range:";
            // 
            // lbStdVar
            // 
            this.lbStdVar.AutoSize = true;
            this.lbStdVar.Location = new System.Drawing.Point(318, 191);
            this.lbStdVar.Name = "lbStdVar";
            this.lbStdVar.Size = new System.Drawing.Size(110, 15);
            this.lbStdVar.TabIndex = 11;
            this.lbStdVar.Text = "Standard Deviation:";
            // 
            // lbBellCurveX
            // 
            this.lbBellCurveX.AutoSize = true;
            this.lbBellCurveX.Location = new System.Drawing.Point(318, 236);
            this.lbBellCurveX.Name = "lbBellCurveX";
            this.lbBellCurveX.Size = new System.Drawing.Size(73, 15);
            this.lbBellCurveX.TabIndex = 12;
            this.lbBellCurveX.Text = "Bell Curve X:";
            // 
            // tbX_value
            // 
            this.tbX_value.Location = new System.Drawing.Point(58, 269);
            this.tbX_value.Name = "tbX_value";
            this.tbX_value.Size = new System.Drawing.Size(65, 23);
            this.tbX_value.TabIndex = 3;
            this.tbX_value.Text = "0";
            this.tbX_value.TextChanged += new System.EventHandler(this.tbX_value_TextChanged);
            // 
            // lbSmallest
            // 
            this.lbSmallest.AutoSize = true;
            this.lbSmallest.Location = new System.Drawing.Point(343, 86);
            this.lbSmallest.Name = "lbSmallest";
            this.lbSmallest.Size = new System.Drawing.Size(85, 15);
            this.lbSmallest.TabIndex = 14;
            this.lbSmallest.Text = "Smallest Value:";
            // 
            // lbLargest
            // 
            this.lbLargest.AutoSize = true;
            this.lbLargest.Location = new System.Drawing.Point(349, 101);
            this.lbLargest.Name = "lbLargest";
            this.lbLargest.Size = new System.Drawing.Size(79, 15);
            this.lbLargest.TabIndex = 15;
            this.lbLargest.Text = "Largest Value:";
            // 
            // tbDevLower
            // 
            this.tbDevLower.Location = new System.Drawing.Point(58, 298);
            this.tbDevLower.Name = "tbDevLower";
            this.tbDevLower.Size = new System.Drawing.Size(65, 23);
            this.tbDevLower.TabIndex = 4;
            this.tbDevLower.Text = "0";
            this.tbDevLower.TextChanged += new System.EventHandler(this.tbDevLower_TextChanged);
            // 
            // tbDevUpper
            // 
            this.tbDevUpper.Location = new System.Drawing.Point(58, 326);
            this.tbDevUpper.Name = "tbDevUpper";
            this.tbDevUpper.Size = new System.Drawing.Size(65, 23);
            this.tbDevUpper.TabIndex = 5;
            this.tbDevUpper.Text = "0";
            this.tbDevUpper.TextChanged += new System.EventHandler(this.tbDevUpper_TextChanged);
            // 
            // lbProportion
            // 
            this.lbProportion.AutoSize = true;
            this.lbProportion.Location = new System.Drawing.Point(361, 206);
            this.lbProportion.Name = "lbProportion";
            this.lbProportion.Size = new System.Drawing.Size(67, 15);
            this.lbProportion.TabIndex = 18;
            this.lbProportion.Text = "Proportion:";
            // 
            // lbDevHigh
            // 
            this.lbDevHigh.AutoSize = true;
            this.lbDevHigh.Location = new System.Drawing.Point(0, 334);
            this.lbDevHigh.Name = "lbDevHigh";
            this.lbDevHigh.Size = new System.Drawing.Size(53, 15);
            this.lbDevHigh.TabIndex = 21;
            this.lbDevHigh.Text = "DevHigh";
            // 
            // lbDevLow
            // 
            this.lbDevLow.AutoSize = true;
            this.lbDevLow.Location = new System.Drawing.Point(4, 301);
            this.lbDevLow.Name = "lbDevLow";
            this.lbDevLow.Size = new System.Drawing.Size(49, 15);
            this.lbDevLow.TabIndex = 20;
            this.lbDevLow.Text = "DevLow";
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Location = new System.Drawing.Point(4, 272);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(48, 15);
            this.lbX.TabIndex = 19;
            this.lbX.Text = "x/mean";
            // 
            // lbCoefficientOfVar
            // 
            this.lbCoefficientOfVar.AutoSize = true;
            this.lbCoefficientOfVar.Location = new System.Drawing.Point(351, 221);
            this.lbCoefficientOfVar.Name = "lbCoefficientOfVar";
            this.lbCoefficientOfVar.Size = new System.Drawing.Size(77, 15);
            this.lbCoefficientOfVar.TabIndex = 22;
            this.lbCoefficientOfVar.Text = "Coeff. Of Var:";
            // 
            // rtFrequency
            // 
            this.rtFrequency.Location = new System.Drawing.Point(46, 382);
            this.rtFrequency.Name = "rtFrequency";
            this.rtFrequency.Size = new System.Drawing.Size(65, 138);
            this.rtFrequency.TabIndex = 6;
            this.rtFrequency.Text = "";
            this.rtFrequency.TextChanged += new System.EventHandler(this.rtFrequency_TextChanged);
            // 
            // lbFreq
            // 
            this.lbFreq.AutoSize = true;
            this.lbFreq.Location = new System.Drawing.Point(22, 364);
            this.lbFreq.Name = "lbFreq";
            this.lbFreq.Size = new System.Drawing.Size(89, 15);
            this.lbFreq.TabIndex = 24;
            this.lbFreq.Text = "Frequency Data";
            // 
            // lbFreqDeviation
            // 
            this.lbFreqDeviation.AutoSize = true;
            this.lbFreqDeviation.Location = new System.Drawing.Point(339, 395);
            this.lbFreqDeviation.Name = "lbFreqDeviation";
            this.lbFreqDeviation.Size = new System.Drawing.Size(89, 15);
            this.lbFreqDeviation.TabIndex = 25;
            this.lbFreqDeviation.Text = "Freq. Deviation:";
            // 
            // lbFreqSimpleMean
            // 
            this.lbFreqSimpleMean.AutoSize = true;
            this.lbFreqSimpleMean.Location = new System.Drawing.Point(320, 380);
            this.lbFreqSimpleMean.Name = "lbFreqSimpleMean";
            this.lbFreqSimpleMean.Size = new System.Drawing.Size(108, 15);
            this.lbFreqSimpleMean.TabIndex = 26;
            this.lbFreqSimpleMean.Text = "Freq. Simple Mean:";
            // 
            // lbBellCurveX_freqStdDev
            // 
            this.lbBellCurveX_freqStdDev.AutoSize = true;
            this.lbBellCurveX_freqStdDev.Location = new System.Drawing.Point(298, 410);
            this.lbBellCurveX_freqStdDev.Name = "lbBellCurveX_freqStdDev";
            this.lbBellCurveX_freqStdDev.Size = new System.Drawing.Size(93, 15);
            this.lbBellCurveX_freqStdDev.TabIndex = 27;
            this.lbBellCurveX_freqStdDev.Text = "Curve Freq. Dev:";
            // 
            // lbZvalue
            // 
            this.lbZvalue.AutoSize = true;
            this.lbZvalue.Location = new System.Drawing.Point(380, 427);
            this.lbZvalue.Name = "lbZvalue";
            this.lbZvalue.Size = new System.Drawing.Size(48, 15);
            this.lbZvalue.TabIndex = 28;
            this.lbZvalue.Text = "z-value:";
            // 
            // lbManual_stdDev
            // 
            this.lbManual_stdDev.AutoSize = true;
            this.lbManual_stdDev.Location = new System.Drawing.Point(0, 243);
            this.lbManual_stdDev.Name = "lbManual_stdDev";
            this.lbManual_stdDev.Size = new System.Drawing.Size(55, 15);
            this.lbManual_stdDev.TabIndex = 30;
            this.lbManual_stdDev.Text = "z-val Dev";
            // 
            // tbZvalue_stdDev
            // 
            this.tbZvalue_stdDev.Location = new System.Drawing.Point(58, 240);
            this.tbZvalue_stdDev.Name = "tbZvalue_stdDev";
            this.tbZvalue_stdDev.Size = new System.Drawing.Size(65, 23);
            this.tbZvalue_stdDev.TabIndex = 2;
            this.tbZvalue_stdDev.Text = "0";
            this.tbZvalue_stdDev.TextChanged += new System.EventHandler(this.tbZvalue_stdDev_TextChanged);
            // 
            // lbMedianQ1
            // 
            this.lbMedianQ1.AutoSize = true;
            this.lbMedianQ1.Location = new System.Drawing.Point(360, 442);
            this.lbMedianQ1.Name = "lbMedianQ1";
            this.lbMedianQ1.Size = new System.Drawing.Size(68, 15);
            this.lbMedianQ1.TabIndex = 31;
            this.lbMedianQ1.Text = "Median Q1:";
            // 
            // lbMedianQ3
            // 
            this.lbMedianQ3.AutoSize = true;
            this.lbMedianQ3.Location = new System.Drawing.Point(360, 460);
            this.lbMedianQ3.Name = "lbMedianQ3";
            this.lbMedianQ3.Size = new System.Drawing.Size(68, 15);
            this.lbMedianQ3.TabIndex = 32;
            this.lbMedianQ3.Text = "Median Q3:";
            // 
            // lbUpperFence
            // 
            this.lbUpperFence.AutoSize = true;
            this.lbUpperFence.Location = new System.Drawing.Point(352, 505);
            this.lbUpperFence.Name = "lbUpperFence";
            this.lbUpperFence.Size = new System.Drawing.Size(76, 15);
            this.lbUpperFence.TabIndex = 33;
            this.lbUpperFence.Text = "Upper Fence:";
            // 
            // lb_iqr
            // 
            this.lb_iqr.AutoSize = true;
            this.lb_iqr.Location = new System.Drawing.Point(289, 475);
            this.lb_iqr.Name = "lb_iqr";
            this.lb_iqr.Size = new System.Drawing.Size(139, 15);
            this.lb_iqr.TabIndex = 34;
            this.lb_iqr.Text = "InterQuartileRange (IQR):";
            // 
            // lbLowerFence
            // 
            this.lbLowerFence.AutoSize = true;
            this.lbLowerFence.Location = new System.Drawing.Point(352, 490);
            this.lbLowerFence.Name = "lbLowerFence";
            this.lbLowerFence.Size = new System.Drawing.Size(76, 15);
            this.lbLowerFence.TabIndex = 35;
            this.lbLowerFence.Text = "Lower Fence:";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(385, 56);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(43, 15);
            this.lbCount.TabIndex = 36;
            this.lbCount.Text = "Count:";
            // 
            // rtReorganized
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.lbLowerFence);
            this.Controls.Add(this.lb_iqr);
            this.Controls.Add(this.lbUpperFence);
            this.Controls.Add(this.lbMedianQ3);
            this.Controls.Add(this.lbMedianQ1);
            this.Controls.Add(this.lbManual_stdDev);
            this.Controls.Add(this.tbZvalue_stdDev);
            this.Controls.Add(this.lbZvalue);
            this.Controls.Add(this.lbBellCurveX_freqStdDev);
            this.Controls.Add(this.lbFreqSimpleMean);
            this.Controls.Add(this.lbFreqDeviation);
            this.Controls.Add(this.lbFreq);
            this.Controls.Add(this.rtFrequency);
            this.Controls.Add(this.lbCoefficientOfVar);
            this.Controls.Add(this.lbDevHigh);
            this.Controls.Add(this.lbDevLow);
            this.Controls.Add(this.lbX);
            this.Controls.Add(this.lbProportion);
            this.Controls.Add(this.tbDevUpper);
            this.Controls.Add(this.tbDevLower);
            this.Controls.Add(this.lbLargest);
            this.Controls.Add(this.lbSmallest);
            this.Controls.Add(this.tbX_value);
            this.Controls.Add(this.lbBellCurveX);
            this.Controls.Add(this.lbStdVar);
            this.Controls.Add(this.lbRange);
            this.Controls.Add(this.lbSum);
            this.Controls.Add(this.lbSampleVar);
            this.Controls.Add(this.lbReorganized);
            this.Controls.Add(this.lbModeFrequencies);
            this.Controls.Add(this.lbMode);
            this.Controls.Add(this.lbMedian);
            this.Controls.Add(this.lbMean);
            this.Controls.Add(this.lbDataSet);
            this.Controls.Add(this.rtDataSet);
            this.MaximumSize = new System.Drawing.Size(700, 600);
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "rtReorganized";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtDataSet;
        private System.Windows.Forms.Label lbDataSet;
        private System.Windows.Forms.Label lbMean;
        private System.Windows.Forms.Label lbMedian;
        private System.Windows.Forms.Label lbMode;
        private System.Windows.Forms.Label lbModeFrequencies;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbReorganized;
        private System.Windows.Forms.Label lbSampleVar;
        private System.Windows.Forms.Label lbSum;
        private System.Windows.Forms.Label lbRange;
        private System.Windows.Forms.Label lbStdVar;
        private System.Windows.Forms.Label lbBellCurveX;
        private System.Windows.Forms.TextBox tbX_value;
        private System.Windows.Forms.Label lbSmallest;
        private System.Windows.Forms.Label lbLargest;
        private System.Windows.Forms.TextBox tbDevLower;
        private System.Windows.Forms.TextBox tbDevUpper;
        private System.Windows.Forms.Label lbProportion;
        private System.Windows.Forms.Label lbDevHigh;
        private System.Windows.Forms.Label lbDevLow;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.Label lbCoefficientOfVar;
        private System.Windows.Forms.RichTextBox rtFrequency;
        private System.Windows.Forms.Label lbFreq;
        private System.Windows.Forms.Label lbFreqDeviation;
        private System.Windows.Forms.Label lbFreqSimpleMean;
        private System.Windows.Forms.Label lbBellCurveX_freqStdDev;
        private System.Windows.Forms.Label lbZvalue;
        private System.Windows.Forms.Label lbManual_stdDev;
        private System.Windows.Forms.TextBox tbZvalue_stdDev;
        private System.Windows.Forms.Label lbMedianQ1;
        private System.Windows.Forms.Label lbMedianQ3;
        private System.Windows.Forms.Label lbUpperFence;
        private System.Windows.Forms.Label lb_iqr;
        private System.Windows.Forms.Label lbLowerFence;
        private System.Windows.Forms.Label lbCount;
    }
}

