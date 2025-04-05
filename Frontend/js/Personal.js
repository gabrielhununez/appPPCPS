const apiUrl = "http://localhost:5064/api/personal";

document.addEventListener("DOMContentLoaded", () => {
    CargarPersonal();
});

document.getElementById("personal-form").addEventListener("submit", function (e) {
    e.preventDefault();
    const personal = document.getElementById("personal").value;

    fetch(apiUrl, {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({ personal : personal })
    })
    .then(response => response.json())
    .then(() => {
        document.getElementById("personal").value = "";
        CargarPersonal();
    });
});

function CargarPersonal() {
    fetch(apiUrl)
        .then(response => response.json())
        .then(data => {
            let tableBody = document.getElementById("personal-table");
            tableBody.innerHTML = "";

            data.forEach(personal => {
                let row = `<tr>
                    <td>${personal._idPersonal}</td>
                    <td>${personal._idGrado}</td>
                    <td>${personal._nombre} ${personal._segundoNombre}</td>
                    <td>${personal._apellido}</td>
                    <td>${personal._tipoDoc}</td>
                    <td>${personal._nroDoc}</td>

                    <td>
                        <button class="btn btn-info btn-sm" href=>Detalle</button>
                        <button class="btn btn-warning btn-sm" >Editar</button>
                        <button class="btn btn-danger btn-sm" onclick="Eliminar(${personal._idPersonal})">Eliminar</button>
                    </td>
                </tr>`;
                tableBody.innerHTML += row;
            });
        });
}

function Eliminar(_IdPersonal) {
    fetch(`${apiUrl}/${_IdPersonal}`, {
        method: "DELETE"
    })
    .then(() => CargarPersonal());
}
