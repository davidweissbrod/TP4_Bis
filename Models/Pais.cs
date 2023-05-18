using System.Collections.Generic;

public class Pais{
    public static string nombre{get; set;}
    public static string imgBandera {get; set;}
    public static int poblacion{get; set;}
    public static DateTime fechaIndependencia{get; set;}
    public static string atractivosTuristicos {get; set;}

    public Pais(string nom, string imgBan, int pob, DateTime fi, string aT){
        nombre = nom;
        imgBandera = imgBan;
        poblacion = pob;
        fechaIndependencia = fi;
        atractivosTuristicos = aT;
    }
}