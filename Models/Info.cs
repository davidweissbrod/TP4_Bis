using.System.Collections.Generic();

public static class info{

public static List<Pais> listaPaises = new list<Pais>();

private static void InicializarLista(){
  Pais Butan = new Pais("Butan", "bandera_Butan.png", 777486, 1949/8/8, "Monasterios, Fortalezas");
  Pais Nepal = new Pais("Nepal", "bandera_Nepal.png", 33000000, 2008/5/28, "Himalaya");
  Pais Vietnam = new Pais("Vietnam", "bandera_Vietnam.png", 97000000, 1945/9/2, "Tuneles Guerra de Vietnam");
  Pais Polonia = new Pais("Polonia", "bandera_Polonia.png", 37000000, 1918/11/11, "Auschwitz");
  Pais Alemania = new Pais("Alemania", "bandera_Alemania.png", 83000000, 1871/1/18, "Castillos");

  listaPaises.Add(Butan);
  listaPaises.Add(Nepal);
  listaPaises.Add(Vietnam);
  listaPaises.Add(Polonia);
  listaPaises.Add(Alemania);
}

public static List<Pais> ListarPaises(){
    foreach(Pais item in listaPaises){
        if(listaPaises = null) InicializarLista();
        else return listaPaises;
    }
}

public static string BuscarPais(string nombre){
    foreach(Pais item in listaPaises){
        if(listaPaises = nombre){
            return Pais(string nombre, string imgBandera, int poblacion, Datetime fechaIndependencia, string atractivosTuristicos);
        }
        else return null;
    }
}
}

