var faktoriális = function (n) {
    let er = 1;
    for (let i = 2; i <= n; i++) {
        er = er * i;
    }
    return er;
}
window.onload = () => {
    console.log("betöltődött");

    //var pascal = document.getElementById("pascal")

    for (var sor = 0; sor < 10; sor++) {

        var ujsor = document.createElement("div");
        ujsor.classList.add("sor");
        document.getElementById("pascal").appendChild(ujsor);

        for (var oszlop = 0; oszlop <= sor; oszlop++) {

            var ujelem = document.createElement("div");
            ujelem.classList.add("elem");
            ujelem.innerHTML = faktoriális(sor) / (faktoriális(oszlop) * faktoriális(sor - oszlop));
            ujsor.appendChild(ujelem);

        }
    }
}
