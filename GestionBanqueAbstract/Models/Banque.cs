﻿namespace GestionBanque.Models;

internal class Banque
{
    public string Nom { get; set; }

    private Dictionary<string, Compte> _comptes = new Dictionary<string, Compte>();

    public KeyValuePair<string, Compte>[] Comptes 
    {
        get 
        {
            return _comptes.ToArray();
        }
    }

    public Compte this[string numero]
    {
        get {
            /*_comptes.TryGetValue(numero, out Courant c);
            return c;*/
            if (!_comptes.ContainsKey(numero)) return null;
            return _comptes[numero];
        }
        //Pas besoin de set dans ce context car juste de la récupération
        private set
        {
            if (value is null) return;
            if (value.Numero != numero) return;
            if (_comptes.ContainsKey(numero)) _comptes[numero] = value;
            else Ajouter(value);
        }
    }

    public void Ajouter(Compte compte)
    {
        if (compte is null) return;
        if (_comptes.ContainsKey(compte.Numero)) return; 
        _comptes.Add(compte.Numero, compte);
    }

    public void Supprimer(string numero)
    {
        if (numero is null) return;
        if (!_comptes.ContainsKey(numero)) return;
        _comptes.Remove(numero);
    }

    public double AvoirDesComptes(Personne titulaire)
    {
        double total = 0;

        foreach(Compte compte in _comptes.Values)
        {
            if (compte.Titulaire.Equals(titulaire))
            {
                // Le code va implicitement inféré le type du compte en DOUBLE
                // et va effectuer l'incrémentation du total des comptes sur lesquels on boucle
                total += compte; 
            }
        }

        return total;
    }
}

