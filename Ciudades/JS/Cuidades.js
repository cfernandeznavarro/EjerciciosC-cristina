var inputCitiesNumber = 0;
var ciudadesOrdenadas = [];

function CititesNumber() 
{
    let cantidad = "";
    let i;
    inputCitiesNumber = document.getElementById("citiesNumber").value;

    if (!isNaN(inputCitiesNumber))
    {
        num = 1 * inputCitiesNumber;

        for (i = 0; i < num; i++)
        {
            cantidad += /*document.getElementById("citiesContainer").innerHTML =*/ '<p>Introduce una ciudad</p> <input id="caja' + i + '"type="text"><br>'

        }
    }

    document.getElementById("citiesContainer").innerHTML = cantidad + '<br> <button class="btn btn-info" onclick="ciudades()">ciudades</button>';

    //return inputCitiesNumber;
}

function ciudades()
{
    let nombreCiudades = [];
    let prueba = "";
    let concatenar = "";

    for (i = 0; i < inputCitiesNumber; i++)
    {
        prueba = document.getElementById("caja" + i).value;
                //alert(prueba);
                /*concatenar = */nombreCiudades.push(prueba);
    }

    /*document.getElementById("citiesContainer").innerHTML = "<br><br> Las Ciudades introducidas son: " + nombreCiudades.sort()); //ordenar array*/

    ciudadesOrdenadas = nombreCiudades.sort();
    let e = "";
    for (i = 0; i < inputCitiesNumber; i++)
    {
        e += "<br>" + ciudadesOrdenadas[i];
    }

    document.getElementById("answer").innerHTML = "<br><br> Fase 2:<br> Las Ciudades introducidas y ordenadas alfabeticamente son: " + e;
    document.getElementById("arraymodificado").innerHTML = '<br> <button class="btn btn-info" onclick="replaceCharacter()">Modificar caracteres</button>';
}


function replaceCharacter()
{
    let juntar = "";
    let i;

    for (i = 0; i < ciudadesOrdenadas.length; i++)
    {
        let currentCity = ciudadesOrdenadas[i];
        let j;
        for (j = 0; j < currentCity.length; j++)
        {
            let currentcitychar = currentCity[j].replace('a', '4');
            juntar += "<br>" + currentcitychar;
        }
    }

    document.getElementById("answer").innerHTML = "<br><br> Fase 3:<br> El nombre las ciudades sustituyendo la voval 'a' por '4' son: " + juntar;
    document.getElementById("arraymodificado").innerHTML = '<br> <button class="btn btn-info" onclick="nuevosArrays()">Modificar nuevos Arrays</button>';

}


function nuevosArrays()
{
    let arrayCityUser = [];
    let i;
    let nomCiutat;

    for (i = 0; i < ciudadesOrdenadas.length; i++)
    {
        nomCiutat = ciudadesOrdenadas[i];
        for (j = 0; j < nomCiutat.length; j++)
        {
            arrayCityUser.push(nomCiutat[j])  //como subirlos separando cada array?
        }
    }
    document.getElementById("answer").innerHTML = "<br> Fase 4:<br> Los nuevos arrays formados por los caracteres de cada ciudad son: " + arrayCityUser;
    document.getElementById("arraymodificado").innerHTML = '';

}

