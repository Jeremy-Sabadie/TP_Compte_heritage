using TP_Compte;
//Création du compte épargne C1:
CompteEpargne C1 = new CompteEpargne(100);
Console.WriteLine($"Compte n°:{C1.SoldCode}");

//Affichage du compte C1 dand son état initial:
Console.WriteLine($"Solde initial de C1 vant un  dépôt: {C1.Sold}.");
C1.ToString();
//Dépôt de 100 sur le compte C1:
C1.Deposer(C1, 100);
//Affichage du compte C1 après le dépôt:
Console.WriteLine($"Solde de C1 après le dépôt: {C1.Sold}.");
//Retraait de 50 sur le compte C1.
C1.Retirer(C1, 50);
//Affichage du compte C1 après le retrait:
Console.WriteLine($"Solde de C1 après le retrait: {C1.Sold}.");
//Calcul du solde de C1 après le calcul des intêrets:
C1.CalculerInterets();
Console.WriteLine($"Solde de C1 après l'application des intérêts: {C1.Sold}.");