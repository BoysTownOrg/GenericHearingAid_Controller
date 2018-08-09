using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MHA
{
    public class Parameters
    {
        const int MXCH = 32;

        public struct CHA_WDRC
        {
            public double attack;           // attack time (ms)
            public double release;          // release time (ms)
            public double maxdB;            // maximum signal (dB SPL)
            public int ear;                 // 0=left, 1=right
            public int nchannel;            // number of channels
            public double[] cross_freq;     // cross frequencies (Hz)
            public double[] tkgain;         // compression-start gain
            public double[] cr;             // compression ratio
            public double[] tk;             // compression-start kneepoint
            public double[] bolt;           // broadband output limiting threshold
        }

        //public CHA_WDRC cha_wdrc = new CHA_WDRC();        
        
        

        /// <summary>
        /// Saves settings to an XML file
        /// </summary>
        /// <returns></returns>
        public bool SaveSettings()
        {
            return true;
        }

        /// <summary>
        /// Loads settings from an XML file
        /// </summary>
        public void LoadSettings()
        {

        }

        /// <summary>
        /// Loads hard coded setting setting
        /// </summary>
        private void LoadDefaultSettings()
        {
            cha_wdrc.attack = 5;
            cha_wdrc.release = 50;
            cha_wdrc.maxdB = 119;
            cha_wdrc.ear = 0;
            cha_wdrc.nchannel = 8;
            cha_wdrc.cross_freq = new double[MXCH];
            cha_wdrc.tkgain = new double[MXCH];
            cha_wdrc.cr = new double[MXCH];
            cha_wdrc.tk = new double[MXCH];
        }

    }
}
