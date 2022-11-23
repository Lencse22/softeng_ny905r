var viccek;

fetch("/questions.json")
    .then(r => r.json())
    .then(d => adatÉrkezett(d));

function letöltés(adat) {
    let ide = document.getElementById("ide");
    console.log(`${adat.length} kérdés érketett`)
    letöltésBefejeződött(d)
}



    function letöltésBefejeződött(d) {
        console.log("Sikeres letöltés")
        console.log(d)
        viccek = d;
        for (var i = 0; i < viccek.length; i++) {
            console.log(viccek[i].questionText)
            let elem = document.createElement("li")
            elem.innerHTML = viccek[i].questionText
            ide.appendChild(elem)
        }
    }