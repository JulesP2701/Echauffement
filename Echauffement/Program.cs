namespace Echauffement;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */

        // Etape 1 : présentez-vous en écrivant votre prénom et votre jeu préféré
        Console.WriteLine("Bonjour jules et mon jeu préférer est Cyberpunk2077");
        // Etape 2 : demandez à l'utilisateur son prénom et son âge
        Console.WriteLine("Quel est ton prénom");
        string Nom = Console.ReadLine();
		Console.WriteLine("Quel est ton age");
        int age = int.Parse(Console.ReadLine());
		Console.WriteLine($" Pénom : {Nom} + Age : {age}");
        // Etape 3 : affichez soit "Tu es majeur", soit "Tu es mineur" dépendant de l'âge fourni par l'utilisateur

        
        if(age > 18)
        {
            Console.WriteLine("Tu es majeur");

        }
        else
			Console.WriteLine("Tu es mineur");
		// Etape 4 : demandez maintenant à l'utilisateur combien d'euro il a (nombre décimal)
		Console.WriteLine("Combien d'euro as tu dans ton portefeuille?");
        int argent = int.Parse(Console.ReadLine());
        Console.WriteLine($"L'utilisateur a {argent} euro dans son portefeuille");

		// Etape 5 : affichez maintenant 4 choix d'armes avec chacune un prix
		Console.WriteLine("Welcome to the shop!");
		string Bigsword = "BigSword";
        int Bigswordprice = 30;
		string Axe = "Axe";
		int Axeprice = 20;
		string Bow = "Bow";
		int Bowprice = 25;
		string Spear = "BigSword";
		int Spearprice = 27;
        Console.Write($"1. {Bigsword} : {Bigswordprice}$ \n 2. {Axe} : {Axeprice}$ \n 3. {Bow} : {Bowprice} \n 4. {Spear} : {Spearprice}$");
        

		// Etape 6 : laissez l'utilisateur choisir l'une de ces 4 armes en indiquant un nombre entre 1 et 4
		Console.WriteLine("\n Choose your weapon!");
		string Response = Console.ReadLine();

	
		if (Response == "1" && argent >= 30 && age > 18)
		{
			Response = "You choose : BigSword  price : 30";
			Console.WriteLine($"Il te reste : {argent - Bigswordprice} ");

		}
		else if (Response == "2" && argent >= 20 && age > 18)
		{
			Response = "You choose : Axe  price : 20";
			Console.WriteLine($"Il te reste : {argent - Axeprice} ");
		}
		else if (Response == "3" && argent >= 25 && age > 18)
		{
			Response = "You choose : Bow price :  25";
			Console.WriteLine($"Il te reste : {argent - Bowprice} ");
		}
		else if (Response == "4" && argent >= 30 && age > 18)
		{
			Response = "You choose : Spear : 27";
			Console.WriteLine($"Il te reste : {argent - Spearprice} ");

		}
		else
			Console.WriteLine("You don't have enough money or you are a minor ");

		Console.WriteLine($"{Response}");



		// Etape 7a : vérifiez si l'utilisateur a assez d'argent par rapport à la somme qu'il avait rentré à l'étape 4

		// Etape 7b : modifiez l'étape 7a pour ajouter un connecteur logique qui vérifie que l'utilisateur est majeur en plus d'avoir assez d'argent
		// Lorsque l'utilisateur respecte ces demandes, retirez le prix de l'arme de l'argent de l'utilisateur, puis confirmez à l'utilisateur que l'action a été effectuée 
		// Dans tous les autres cas, informez l'utilisateur que l'action n'a pas été possible

		/*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
	}
}