var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $("#tbl").DataTable({
        "ajax": {
            "url":"/Admin/Category/GetAll"
        },
        "columns": [
            { "data": "name", "width": "60%"},
                {
                    "data": "id",
                    "render": function (data) {
                        return `
                    <div class="text-center">
                        <a href="/Admin/Category/Upsert/${data}" class="btn btn-dark text-white" style="cursor:pointer">
                            <i class="fas fa-edit"></i> &nbsp;
                        </a>
                        <a  class="btn btn-dark text-white" style="cursor:pointer">
                            <i class="fas fa-trash-alt"></i> &nbsp;
                        </a>
                    </div>`
                    }, "width":"40%"
            }
        ]
    })
}