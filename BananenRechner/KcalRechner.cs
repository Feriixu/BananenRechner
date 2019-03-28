namespace BananenRechner
{
    public class KcalRechner
    {
        int kcalPer100g;

        public KcalRechner(int kcalPer100g)
        {
            this.kcalPer100g = kcalPer100g;
        }

        public int KcalPerBanana(int bWeight)
        {
            int bKcal = (bWeight * this.kcalPer100g) / 100;
            return bKcal;
        }

        public int KcalTotal(int bWeight, int bCount)
        {
            int tWeight = bWeight * bCount;
            int tKcal = (tWeight * this.kcalPer100g) / 100;
            return tKcal;
        }
    }
}
