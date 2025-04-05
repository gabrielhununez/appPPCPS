const apiUrl = "http://localhost:5064/api/grado";

document.addEventListener("DOMContentLoaded", () => {
    cargarGrados();
});

document.getElementById("grado-form").addEventListener("submit", function (e) {
    e.preventDefault();
    const grado = document.getElementById("grado").value;

    fetch(apiUrl, {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({ grado : grado })
    })
    .then(response => response.json())
    .then(() => {
        document.getElementById("grado").value = "";
        cargarGrados();
    });
});

function cargarGrados() {
    fetch(apiUrl)
        .then(response => response.json())
        .then(data => {
            let tableBody = document.getElementById("grado-table");
            tableBody.innerHTML = "";

            data.forEach(grado => {
                let row = `<tr>
                    <td>${grado._abreviatura}</td>
                    <td>${grado._gradoCompleto}</td>
                    <td>
                        <button class="btn btn-info btn-sm cambio-btn">
                            <span class="texto">Detalle</span>
                            <img class="icono" src="../../img/detalle.svg" alt="detalle"/>
                        </button>
                        <button class="btn btn-warning btn-sm cambio-btn">
                            <span class="texto">Editar</span>
                            <img class="icono" src="../../img/editar.svg" alt="editar"/>
                        </button>
                        <button class="btn btn-danger btn-sm cambio-btn" onclick="Eliminar(${grado._idGrado})">
                            <span class="texto">Eliminar</span>
                            <img class="icono" src="../../img/eliminar.svg" alt="Eliminar"/>
                        </button>
                    </td>
                </tr>`;
                tableBody.innerHTML += row;
            });
        });
}

function Eliminar(_idGrado) {
    fetch(`${apiUrl}/${_idGrado}`, {
        method: "DELETE"
    })
    .then(() => cargarGrados());
}
