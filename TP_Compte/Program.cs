using TP_Compte;
//Création du compte épargne C1:
CompteEpargne C1 = new CompteEpargne(100);
Console.WriteLine($"{C1.SoldCode}");
//Affichage du compte C1 dand son état initial:
Console.WriteLine($"Solde de C1 vant le dépôt: {C1.Sold}.");
C1.ToString();
//Dépo de 100 sur le compte C1:
C1.Deposer(C1, 100);
//Affichage du compte C1 après le dépôt:
Console.WriteLine($"Solde de C1 après le dépôt: {C1.Sold}.");