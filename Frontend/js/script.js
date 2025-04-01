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
                    <td>${grado._IdGrado}</td>
                    <td>${grado._Abreviatura}</td>
                    <td>${grado._GradoCompleto}</td>
                    <td>
                        <button class="btn btn-info btn-sm" >Detalle</button>
                        <button class="btn btn-warning btn-sm" >Editar</button>
                        <button class="btn btn-danger btn-sm" onclick="Eliminar(${grado._IdGrado})">Eliminar</button>
                    </td>
                </tr>`;
                tableBody.innerHTML += row;
            });
        });
}

function Eliminar(_IdGrado) {
    fetch(`${apiUrl}/${_IdGrado}`, {
        method: "DELETE"
    })
    .then(() => cargarGrados());
}