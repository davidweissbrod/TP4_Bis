using System.Collections.Generic;

public static class Info{

public static List<Pais> listaPaises = new List<Pais>();

private static void InicializarLista(){
  Pais Butan = new Pais("Butan", "bandera_Butan.png", 777486, new DateTime(1949,8,8), "Monasterios, Fortalezas");
  Pais Nepal = new Pais("Nepal", "bandera_Nepal.png", 33000000, new DateTime(2008,5,28), "Himalaya");
  Pais Vietnam = new Pais("Vietnam", "bandera_Vietnam.png", 97000000, new DateTime(1945,9,2), "Tuneles Guerra de Vietnam");
  Pais Polonia = new Pais("Polonia", "bandera_Polonia.png", 37000000, new DateTime(1918,11,11), "Auschwitz");
  Pais Alemania = new Pais("Alemania", "bandera_Alemania.png", 83000000, new DateTime(1871,1,18), "Castillos");

  listaPaises.Add(Butan);
  listaPaises.Add(Nepal);
  listaPaises.Add(Vietnam);
  listaPaises.Add(Polonia);
  listaPaises.Add(Alemania);
}

public static List<Pais> ListarPaises(){
    foreach(Pais item in listaPaises){
        InicializarLista();
        return listaPaises;
    }
}

public static string BuscarPais(string nom){
    foreach(Pais item in listaPaises){
        if(listaPaises = nom){
            return item.nombre;
        }
        else return item.nombre;
    }
}
}

