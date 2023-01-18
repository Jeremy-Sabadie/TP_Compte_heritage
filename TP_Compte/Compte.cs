namespace TP_Compte
{
    internal class Compte
    {
        //Atttributs de la classe:
        private int Sold;
        private int compteCode;
        //Constructeur qui permet de préciser son solde initial:
        public Compte(int sold)
        {
            Sold = sold;
            compteCode += 1;
        }


        //Accesseurs en lecture seule des pro^riétés de la classe:
        public int Sold1 { get => Sold; private set => Sold = value; }
        public int SoldCode { get => compteCode; private set => compteCode = value; }
        //Méthode ToString qui affiche qui permet de consulter le compte:
        public void ToString()
        {
            Console.WriteLine($"Code du compte:{compteCode}");
            Console.WriteLine($"solde du compte:{Sold}");
        }



    }
}
