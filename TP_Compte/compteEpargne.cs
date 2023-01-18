namespace TP_Compte
{
    internal class CompteEpargne : Compte
    {
        public CompteEpargne(int solde) //Constructeur classe enfant ComptEpargne.
            : base(solde)//Appel du constructeur classe parent Compte.
        {
            TauxInteret = 6;
        }

        private int TauxInteret;

        public int TauxInteret1 { get => TauxInteret; set => TauxInteret = value; }
    }
}
