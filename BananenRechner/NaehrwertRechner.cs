namespace BananenRechner
{
    public class NaehrwertRechner
    {
        // waterPer100g
        // proteinsPer100g
        // fatPer100g
        // carbohydratesPer100g
        // fiberPer100g
        double[] compositionValues;

        // sodiumPer100g
        // potassiumPer100g
        // calciumPer100g
        // magnesiumPer100g
        // phosphorusPer100g
        // sulfurPer100g
        // chloridePer100g
        double[] mineralValues;

        public NaehrwertRechner(double[] compositionValues, double[] minerals)
        {
            this.compositionValues = compositionValues;
            this.mineralValues = minerals;
        }

        public double[] CalcComposition(int tWeight)
        {
            double[] values = new double[compositionValues.Length];
            for (int i = 0; i < compositionValues.Length; i++)
            {
                values[i] = (compositionValues[i] * tWeight) / 100;
            }

            return values;
        }

        public double[] CalcMinerals(int tWeight)
        {
            double[] values = new double[mineralValues.Length];
            for (int i = 0; i < mineralValues.Length; i++)
            {
                values[i] = (mineralValues[i] * tWeight) / 100;
            }

            return values;
        }
    }
}
