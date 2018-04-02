using System;
/*
    Classe de gestion des Dates
    Permet d'effectué des opérations sur les date
*/

/// <summary>
/// Classe de gestion des Dates
/// Permet d'effectué des opérations sur les date
/// </summary>
abstract class Date {

/*
    Donne le mois précedent à partir de la date système
*/
/// <summary>
/// Donne le mois précedent à partir de la date système
/// </summary>
/// <returns>
/// Retourne le mois précedent à partir de la date système 
/// </returns>
public static string getMoisPrecedent(){
   DateTime date = DateTime.Now;
   int mois = date.Month -1;
   string result = format(mois);
   return result;
}

/*
    Donne le mois précedent à partir de la date donnée en paramètre
*/
/// <summary>
///  Donne le mois précedent à partir de la date donnée en paramètre
/// </summary>
///<param name="date"> DateTime date </param>
/// <returns>
/// Retourne  Donne le mois précedent à partir de la date donnée en paramètre
/// </returns>
public static string getMoisPrecedent(DateTime date){
   int mois = date.Month -1;
   string result = format(mois);
   return result;
}

/*
    Donne le mois suivant à partir de la date système
*/
/// <summary>
/// Donne le mois suivant à partir de la date système
/// </summary>
/// <returns>
/// Retourne le mois suivant à partir de la date système 
/// </returns>
public static string getMoisSuivant(){
   DateTime date = DateTime.Now;
   int mois = date.Month +1;
   string result = format(mois);
   return result;
}


/*
    Donne le mois suivant à partir de la date donnée en paramètre
*/
/// <summary>
///  Donne le mois suivant à partir de la date donnée en paramètre
/// </summary>
///<param name="date"> DateTime date </param>
/// <returns>
/// Retourne  Donne le mois suivant à partir de la date donnée en paramètre
/// </returns>
public static string getMoisSuivant(DateTime date){
   int mois = date.Month +1;
   string result = format(mois);

   return result;
}


/*
   Test si la date (jour du mois) système est compris entre l'interval
   donné en paramètre 
*/
/// <summary>
///  Test si la date (jour du mois) système est compris entre l'interval donné en paramètre 
/// </summary>
///<param name="jour1"> int premier jour de l'interval </param>
///<param name="jour2"> int dernier jour de l'interval </param>
/// <returns>
/// Retourne  Vrai ou Faux
/// </returns>
public static bool entre(int jour1, int jour2){
   DateTime date = DateTime.Now;
   int jour = date.Day;
   return checkEstDansInterval(jour1,jour2,jour);
}

/*
   Test si la date (jour du mois) passée en paramètre est compris entre l'interval
   donné en paramètre 
*/
/// <summary>
///  Test si la date (jour du mois) passée en paramètre est compris entre l'interval donné en paramètre  
/// </summary>
///<param name="jour1"> int premier jour de l'interval </param>
///<param name="jour2"> int dernier jour de l'interval </param>
///<param name="date"> DateTime date à tester </param>
/// <returns>
/// Retourne  Vrai ou Faux
/// </returns>
public static bool entre(int jour1, int jour2, DateTime date){
   int jour = date.Day;
   return checkEstDansInterval(jour1,jour2,jour);
}


/*
    Format un mois donnée en paramètre sous la forme MM
*/
/// <summary>
/// Format un mois donnée en paramètre sous la forme MMe
/// </summary>
///<param name="mois"> int le mois à formatter </param>
/// <returns>
/// Retourne string le mois donnée en paramètre sous la forme MM 
/// </returns>
public static string format(int mois){
    if(mois > 12){
        mois = mois -12;
    }
    string result = "";
   if( mois <10){
       result = "0"+mois.ToString();
   }
   else{

       result = mois.ToString();
   }
   return result;
}



/*
   Test si une valeur passée en paramètre est compris entre l'interval
   donné en paramètre 
*/
/// <summary>
///  Test si la valeur passée en paramètre est compris entre l'interval donné en paramètre  
/// </summary>
///<param name="start"> int début de l'interval </param>
///<param name="end"> int fin de l'interval </param>
///<param name="value"> valeur à tester </param>
/// <returns>
/// Retourne  Vrai ou Faux
/// </returns>
public static bool checkEstDansInterval(int start, int end, int value){
   if (start <= value && value <= end)
   {
       return true;
   }
   else{
       return false;
   }
}

}