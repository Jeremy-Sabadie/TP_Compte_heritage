namespace TP_Compte
{
    internal class Compte
    {
        //Atttributs de la classe:
        private float _sold;
        private int compteCode;
        //Constructeur qui permet de préciser son solde initial:
        public Compte(float sold)
        {
            Sold = sold;
            compteCode += 1;
        }


        //Accesseurs en lecture seule des pro^riétés de la classe:
        public float Sold { get => _sold; protected set => _sold = value; }
        public int SoldCode { get => compteCode; private set => compteCode = value; }
        //Méthode ToString qui affiche qui permet de consulter le compte:
        public void ToString()
        {


        }
        public float Deposer(Compte C, int amount)
        {
            ;
            Sold = Sold + amount;

            return Sold;
        }
        public float Retirer(Compte C, int amount)
        {
            ;
            Sold = Sold - amount;

            return Sold;
        }




    }
}
