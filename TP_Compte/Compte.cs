namespace TP_Compte
{
    internal class Compte
    {
        //Atttributs de la classe:
        private int Sold = 0;
        private int soldCode;
        //Constructeur:
        public Compte(int sold, int soldCode)
        {
            Sold = sold;
            this.soldCode = soldCode;
            soldCode += 1;
        }


        //Accesseurs en lecture seule des pro^riétés de la classe:
        public int Sold1 { get => Sold; private set => Sold = value; }
        public int SoldCode { get => soldCode; private set => soldCode = value; }
        //Méthode ToString qui affiche qui permet de consulter le compte:
        public void ToString()
        {
            Console.WriteLine($"Code du compte:{}");
        }



    }
}
