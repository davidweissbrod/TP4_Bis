public static class Pais{
    public static string nombre{get; set;}
    public static string imgBandera {get; set;}
    public static int poblacion{get; set;}
    public static Datetime fechaIndependencia{get; set;}
    public static string atractivosTuristicos {get; set;}

    public static Pais(string nom, string imgBan, int pob, Datetime fi, string aT){
        nombre = nom;
        imgBandera = imgBan;
        poblacion = pob;
        fechaIndependencia = fi;
        atractivosTuristicos = aT;
    }
}