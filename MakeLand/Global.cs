using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Media;

namespace MakeLand
{
    

    public static class G
    {
        public static Form2 form2 = null;
        public static Random rnd = new Random(101);

        public static string status = "null";
        public static Population pop = null;
        public static int popCount=0; // temp for testing

        public static int duplicateGenomesGen = 0; // When we last checked for duplicate geneomes 
        public static int mutationCount = 0;
        public static int dupGeneCount = 0;
        public static int dupGeneomeCount = 0;

        public static Color colorSea = Color.DarkBlue;    // 0=Sea color
        public static Color colorLand = Color.Green;      // 1=Land color
        public static Color colorFresh = Color.LightBlue; // 2 = fresh water color

        public static Color[] ca;

        public static void init()
        {
            ca = new Color[3];
            ca[0] = colorSea;
            ca[1] = colorLand;
            ca[2] = colorFresh;
        }
    }

    public static class Params
    {
        public static double percentLand = 0.70;  // % map thats land 
        public static double percentFresh = 0.04; // % map thats freshwater
        public static double percenSea = 1 - percentLand - percentFresh; // %map thats sea

        public static int populationCnt = 300;
        public static int genotypeSize = 500;
        public static int dimX = 128;
        public static int dimY = 128;
        public static int maxRepeat = 13;

        public static double mutationPercent = 0.0;
        public static bool checkDuplicateGenes = true; // 
        public static int checkDuplicateGenomes = -1; // -1 is never 1=every turn 10=every 10th generation ... etc 



    }
}


