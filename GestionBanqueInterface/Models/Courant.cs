namespace GestionBanque.Models;

internal class Courant : Compte
{
    private double _ligneDeCredit;
    public double LigneDeCredit
    {
        get { return _ligneDeCredit; }
        set
        {
            if (value >= 0)
            {
                _ligneDeCredit = value;
            }
        }
    }

    public override void Retrait(double montant)
    {
        Retrait(montant, LigneDeCredit);
    }

    protected override double CalculInteret()
    {
        //if (Solde < 0)
        //{
        //    return Solde * 9.75 / 100;
        //}
        //else
        //{
        //    return Solde * 3 / 100;
        //}

        return (Solde < 0) ? Solde * 9.75 / 100 : Solde * 3 / 100;
    }
}
