namespace WebApplication1.Models
{
    public class CsapatEredmenyei
    {
        public string csapatNev { get; set; }
        public int gyozelmekSzama { get; set; }
        public int dontetlenekSzama { get; set; }
        public int veresegekSzama { get; set; }
        public int lottGolokSzama { get; set; }
        public int kapottGolokSzama { get; set; }

        public int jatszottMecssekSzama { get => gyozelmekSzama + dontetlenekSzama + veresegekSzama; }
        public int 
    }
}
