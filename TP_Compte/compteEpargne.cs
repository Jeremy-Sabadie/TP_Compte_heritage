namespace TP_Compte
{
    internal class CompteEpargne : Compte
    {
        public CompteEpargne(float solde) //Constructeur classe enfant CompteEpargne.
            : base(solde)//Appel du constructeur classe parent Compte.
        {
            TauxInteret = 6;
        }

        private float _TauxInteret;

        public float TauxInteret { get => _TauxInteret; set => _TauxInteret = value; }

        public double CalculerInterets()
        {//CApplication des intérêts sur le solde du compte.
            Sold += Sold * TauxInteret / 100f;
            return Sold;
        }

    }

}
