namespace GestionBanque.Models;

internal class Epargne : Compte
{

    public DateTime DateDernierRetrait { get; set; }

    public override void Retrait(double montant)
    {
        var AncienSolde = Solde;
        base.Retrait(montant);

        if (Solde != AncienSolde)
        {
            DateDernierRetrait = DateTime.Now;
        }
    }
}
