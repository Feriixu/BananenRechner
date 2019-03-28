using System;

namespace BananenRechner
{
    public partial class Dashboard : MetroFramework.Forms.MetroForm
    {
        private const int BANANAKCAL100G = 95;
        int bCount = 0;
        int bWeight = 0;
        int tWeight = 0;
        int bKcal = 0;
        int tKcal = 0;
        KcalRechner kRechner;
        NaehrwertRechner nRechner;

        private readonly double[] naehrwerte = 
        {
            73.812,
            1.15,
            0.18,
            21.39,
            2.0
        };

        private readonly double[] mineralstoffe =
        {
            1.0,
            393.0,
            9.0,
            36.0,
            28.0,
            13.0,
            109.0
        };


        public Dashboard()
        {
            InitializeComponent();
            kRechner = new KcalRechner(BANANAKCAL100G);
            nRechner = new NaehrwertRechner(naehrwerte, mineralstoffe);
            UpdateValues();
        }

        private void textBoxBananaCount_TextChanged(object sender, EventArgs e) => UpdateValues();
        private void textBoxWeightPerBanana_TextChanged(object sender, EventArgs e) => UpdateValues();

        private void UpdateValues()
        {
            // Parse Values
            if (!int.TryParse(textBoxBananaCount.Text, out bCount))
            {
                bCount = 0;
            }

            if (!int.TryParse(textBoxWeightPerBanana.Text, out bWeight))
            {
                bWeight = 0;
            }

            // Calculate values
            bKcal = kRechner.KcalPerBanana(bWeight);
            tKcal = kRechner.KcalTotal(bWeight, bCount);
            tWeight = bCount * bWeight;

            double[] composition = nRechner.CalcComposition(tWeight);
            double[] minerals = nRechner.CalcMinerals(tWeight);

            // Display values
            textBoxTotalWeight.Text = tWeight.ToString() + " g";
            textBoxKcalPerBanana.Text = bKcal.ToString() + " kcal";
            textBoxTotalKcal.Text = tKcal.ToString() + " kcal";

            textBoxWater.Text = composition[0].ToString() + " ml";
            textBoxProtein.Text = composition[1].ToString() + " g";
            textBoxFat.Text = composition[2].ToString() + " g";
            textBoxCarbohydrates.Text = composition[3].ToString() + " g";
            textBoxFiber.Text = composition[4].ToString() + " g";

            textBoxSodium.Text = minerals[0].ToString() + " mg";
            textBoxPotassium.Text = minerals[1].ToString() + " mg";
            textBoxCalcium.Text = minerals[2].ToString() + " mg";
            textBoxMagnesium.Text = minerals[3].ToString() + " mg";
            textBoxPhosphorus.Text = minerals[4].ToString() + " mg";
            textBoxSulfur.Text = minerals[5].ToString() + " mg";
            textBoxChloride.Text = minerals[6].ToString() + " mg";
        }
    }
}
